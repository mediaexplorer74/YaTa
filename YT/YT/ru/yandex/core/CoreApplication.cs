using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace ru.yandex.core
{
	using Context = android.content.Context;
	using SharedPreferences = android.content.SharedPreferences;
	using Location = android.location.Location;
	using LocationListener = android.location.LocationListener;
	using LocationManager = android.location.LocationManager;
	using Build = android.os.Build;
	using Bundle = android.os.Bundle;
	using Environment = android.os.Environment;
	using Handler = android.os.Handler;
	using Looper = android.os.Looper;
	using TelephonyManager = android.telephony.TelephonyManager;
	using DisplayMetrics = android.util.DisplayMetrics;
	using MotionEvent = android.view.MotionEvent;
	using c;
	using d;
	using l;

	public class CoreApplication : LocationListener
	{
	  private const int RFS_DATA = 2;

	  private const int RFS_INVALID = 0;

	  private const int RFS_NATIVE = 5;

	  private const int RFS_REMOVABLE = 4;

	  private const int RFS_RES = 1;

	  private const int RFS_TMP = 3;

	  public static int SDK_INT = 0;

	  internal static Context applicationContext;

	  private static CoreApplication coreApplication;

	  private const string coreApplicationPrefs = "ru.yandex.core.CoreApplication";

	  private static long coreGestureRecognizer = 0L;

	  private static KDActivity currentActivity;

	  private static KDView currentView;

	  private static ThreadStart deliver;

	  private static int deviceDpi = 0;

	  private static MotionEventProxy eventProxy;

	  private const string hashKey = "ru.yandex.core.CoreApplication.hashKey";

	  private static bool isActive = false;

	  private const string otherFsRootKey = "ru.yandex.core.CoreApplication.otherFsRoot";

	  private const string resFsRootKey = "ru.yandex.core.CoreApplication.resFsRoot";

	  private static readonly SignalStrengthListener signalStrengthListener;

	  private static readonly TelephonyListener telephonyListener;

	  private string activeProvider;

	  private bool currStatus = false;

	  private Location gpsLocation;

	  private int gpsStatus = 0;

	  private Location networkLocation;

	  private int networkStatus = 0;

	  private string otherFsRoot = null;

	  private CoreApplicationParams @params;

	  private string resFsRoot = null;

	  static CoreApplication()
	  {
		coreGestureRecognizer = 0L;
		deviceDpi = 0;
		SDK_INT = 3;
		try
		{
		  if (Build.VERSION.SDK.Equals("3"))
		  {
			SDK_INT = 3;
		  }
		  else
		  {
			System.Reflection.FieldInfo field = typeof(Build.VERSION).GetField("SDK_INT");
			if (field != null)
			{
			  SDK_INT = field.getInt(null);
			}
		  }
		}
		catch (Exception)
		{
		}
		deliver = (ThreadStart)new c();
		telephonyListener = new TelephonyListener();
		signalStrengthListener = new SignalStrengthListener();
		bool @bool;
		if (!typeof(CoreApplication).desiredAssertionStatus())
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		$assertionsDisabled = @bool;
	  }

	  public static Handler createHandlerForCurrentThread()
	  {
		if (Looper.myLooper() == null)
		{
		  Looper.prepare();
		}
		return new Handler();
	  }

	  public static object createSignalStrengthRequest(long paramLong)
	  {
		return new SignalStrengthRequest(paramLong);
	  }

	  public static object createTelephonyNetworkInfoRequest(long paramLong)
	  {
		return new TelephonyNetworkInfoRequest(paramLong);
	  }

	  public static object createWifiScanRequest(long paramLong)
	  {
		return new WifiScanRequest(paramLong);
	  }

	  public static object createWindow()
	  {
		return currentView.getHolder();
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void deliverEvents();

	  public static int destroyWindow(object paramObject)
	  {
		return 0;
	  }

	  private static bool dispatchGesture(MotionEvent paramMotionEvent, d paramd)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getAction : ()I
		//   4: sipush #255
		//   7: iand
		//   8: tableswitch default -> 52, 0 -> 56, 1 -> 272, 2 -> 102, 3 -> 295, 4 -> 52, 5 -> 79, 6 -> 79
		//   52: iconst_0
		//   53: istore_2
		//   54: iload_2
		//   55: ireturn
		//   56: getstatic ru/yandex/core/CoreApplication.coreGestureRecognizer : J
		//   59: aload_1
		//   60: getfield a : [F
		//   63: aload_1
		//   64: getfield b : [F
		//   67: aload_0
		//   68: invokevirtual getEventTime : ()J
		//   71: invokestatic touchesBegan : (J[F[FJ)V
		//   74: iconst_1
		//   75: istore_2
		//   76: goto -> 54
		//   79: getstatic ru/yandex/core/CoreApplication.coreGestureRecognizer : J
		//   82: aload_1
		//   83: getfield a : [F
		//   86: aload_1
		//   87: getfield b : [F
		//   90: aload_0
		//   91: invokevirtual getEventTime : ()J
		//   94: invokestatic touchesMoved : (J[F[FJ)V
		//   97: iconst_1
		//   98: istore_2
		//   99: goto -> 54
		//   102: getstatic ru/yandex/core/CoreApplication.eventProxy : Lru/yandex/core/MotionEventProxy;
		//   105: aload_0
		//   106: putfield ev : Landroid/view/MotionEvent;
		//   109: getstatic ru/yandex/core/CoreApplication.eventProxy : Lru/yandex/core/MotionEventProxy;
		//   112: invokevirtual getHistorySize : ()I
		//   115: istore_3
		//   116: getstatic ru/yandex/core/CoreApplication.eventProxy : Lru/yandex/core/MotionEventProxy;
		//   119: invokevirtual getPointerCount : ()I
		//   122: istore #4
		//   124: iload_3
		//   125: ifle -> 249
		//   128: new d
		//   131: dup
		//   132: iload #4
		//   134: newarray float
		//   136: iload #4
		//   138: newarray float
		//   140: invokespecial <init> : ([F[F)V
		//   143: astore #5
		//   145: iload_3
		//   146: bipush #6
		//   148: if_icmpge -> 318
		//   151: iconst_2
		//   152: istore #6
		//   154: iconst_0
		//   155: istore #7
		//   157: iload #7
		//   159: iload_3
		//   160: if_icmpge -> 249
		//   163: iconst_0
		//   164: istore #8
		//   166: iload #8
		//   168: iload #4
		//   170: if_icmpge -> 215
		//   173: aload #5
		//   175: getfield a : [F
		//   178: iload #8
		//   180: getstatic ru/yandex/core/CoreApplication.eventProxy : Lru/yandex/core/MotionEventProxy;
		//   183: iload #8
		//   185: iload #7
		//   187: invokevirtual getHistoricalX : (II)F
		//   190: fastore
		//   191: aload #5
		//   193: getfield b : [F
		//   196: iload #8
		//   198: getstatic ru/yandex/core/CoreApplication.eventProxy : Lru/yandex/core/MotionEventProxy;
		//   201: iload #8
		//   203: iload #7
		//   205: invokevirtual getHistoricalY : (II)F
		//   208: fastore
		//   209: iinc #8, 1
		//   212: goto -> 166
		//   215: getstatic ru/yandex/core/CoreApplication.coreGestureRecognizer : J
		//   218: aload #5
		//   220: getfield a : [F
		//   223: aload #5
		//   225: getfield b : [F
		//   228: getstatic ru/yandex/core/CoreApplication.eventProxy : Lru/yandex/core/MotionEventProxy;
		//   231: iload #7
		//   233: invokevirtual getHistoricalEventTime : (I)J
		//   236: invokestatic touchesMoved : (J[F[FJ)V
		//   239: iload #7
		//   241: iload #6
		//   243: iadd
		//   244: istore #7
		//   246: goto -> 157
		//   249: getstatic ru/yandex/core/CoreApplication.coreGestureRecognizer : J
		//   252: aload_1
		//   253: getfield a : [F
		//   256: aload_1
		//   257: getfield b : [F
		//   260: aload_0
		//   261: invokevirtual getEventTime : ()J
		//   264: invokestatic touchesMoved : (J[F[FJ)V
		//   267: iconst_1
		//   268: istore_2
		//   269: goto -> 54
		//   272: getstatic ru/yandex/core/CoreApplication.coreGestureRecognizer : J
		//   275: aload_1
		//   276: getfield a : [F
		//   279: aload_1
		//   280: getfield b : [F
		//   283: aload_0
		//   284: invokevirtual getEventTime : ()J
		//   287: invokestatic touchesEnded : (J[F[FJ)V
		//   290: iconst_1
		//   291: istore_2
		//   292: goto -> 54
		//   295: getstatic ru/yandex/core/CoreApplication.coreGestureRecognizer : J
		//   298: aload_1
		//   299: getfield a : [F
		//   302: aload_1
		//   303: getfield b : [F
		//   306: aload_0
		//   307: invokevirtual getEventTime : ()J
		//   310: invokestatic touchesCancelled : (J[F[FJ)V
		//   313: iconst_1
		//   314: istore_2
		//   315: goto -> 54
		//   318: iconst_3
		//   319: istore #6
		//   321: goto -> 154
	  }

	  public static bool dispatchTouchEvent(MotionEvent paramMotionEvent)
	  {
		d d = prepareForCore(paramMotionEvent);
		if (paramMotionEvent.getAction() == 0)
		{
		  postEvent(new int[] {57, 16387, (int)paramMotionEvent.getX(), (int)paramMotionEvent.getY(), 1});
		}
		bool @bool = dispatchGesture(paramMotionEvent, d);
		if (paramMotionEvent.getAction() == 1)
		{
		  postEvent(new int[] {57, 16387, (int)paramMotionEvent.getX(), (int)paramMotionEvent.getY(), 0});
		}
		return @bool;
	  }

	  public static KDActivity Activity
	  {
		  get
		  {
			return currentActivity;
		  }
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern String getAppFileSystemRootFromNative();

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern String getAppNameFromNative();

	  public static CoreApplication CoreApplication
	  {
		  get
		  {
			if (coreApplication == null)
			{
			  throw new Exception("here CoreApplication must exists!");
			}
			return coreApplication;
		  }
	  }

	  public static int DPI
	  {
		  get
		  {
			if (deviceDpi == 0)
			{
			  DisplayMetrics displayMetrics = new DisplayMetrics();
			  currentActivity.getWindowManager().getDefaultDisplay().getMetrics(displayMetrics);
			  try
			  {
				deviceDpi = typeof(DisplayMetrics).GetField("densityDpi").getInt(displayMetrics);
			  }
			  catch (Exception)
			  {
				deviceDpi = (long)Math.Round(displayMetrics.density * 160.0F, MidpointRounding.AwayFromZero);
			  }
			}
			return deviceDpi;
		  }
	  }

	  private string ExternalStorageDirectory
	  {
		  get
		  {
			return "/sdcard/" + getAppNameFromNative() + "/data";
		  }
	  }

	  private string LocalStorageDirectory
	  {
		  get
		  {
			return applicationContext.getFilesDir().getAbsolutePath() + "/" + getAppNameFromNative() + "/data";
		  }
	  }

	  private static string getRootForFileSystem(int paramInt)
	  {
		return CoreApplication.getRootForFileSystemImpl(paramInt);
	  }

	  private string getRootForFileSystemImpl(int paramInt)
	  {
		if (paramInt == 1)
		{
		  if (string.ReferenceEquals(this.resFsRoot, null))
		  {
			if (this.@params.shouldResourcesBeOnPhoneMemory() || !SdcardAvailable)
			{
			  this.resFsRoot = LocalStorageDirectory;
			}
			else
			{
			  this.resFsRoot = ExternalStorageDirectory;
			}
		  }
		  return this.resFsRoot;
		}
		if (string.ReferenceEquals(this.otherFsRoot, null))
		{
		  if (SdcardAvailable)
		  {
			this.otherFsRoot = ExternalStorageDirectory;
		  }
		  else
		  {
			this.otherFsRoot = LocalStorageDirectory;
		  }
		}
		return this.otherFsRoot;
	  }

	  public static KDView View
	  {
		  get
		  {
			return currentView;
		  }
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern int init();

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern long initGestureRecognizers(int paramInt);

	  public static void initOnce(Context paramContext, CoreApplicationParams paramCoreApplicationParams)
	  {
		if (coreApplication == null)
		{
		  applicationContext = paramContext.getApplicationContext();
		  CoreApplication coreApplication = new CoreApplication();
		  coreApplication = coreApplication;
		  coreApplication.initialize(paramCoreApplicationParams);
		}
	  }

	  private void initialize(CoreApplicationParams paramCoreApplicationParams)
	  {
		this.@params = paramCoreApplicationParams;
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for C#:
//		System.loadLibrary(paramCoreApplicationParams.NativeLibraryName);
		restoreFsRoot();
		installResources();
		init();
		eventProxy = MotionEventProxy.create();
		coreGestureRecognizer = initGestureRecognizers(paramCoreApplicationParams.GestureDispatcherConfig);
	  }

	  private void installResources()
	  {
		try
		{
		  SharedPreferences sharedPreferences = applicationContext.getSharedPreferences("ru.yandex.core.CoreApplication", 0);
		  sbyte[] arrayOfByte = new sbyte[32];
		  Stream inputStream = applicationContext.getResources().openRawResource(this.@params.HashResourceID);
		  inputStream.Read(arrayOfByte, 0, arrayOfByte.Length);
		  inputStream.Close();
		  string str = "";
		  this(arrayOfByte);
		  if (!sharedPreferences.getString("ru.yandex.core.CoreApplication.hashKey", "").Equals(str))
		  {
			unpackAssets();
			SharedPreferences.Editor editor = sharedPreferences.edit();
			editor.putString("ru.yandex.core.CoreApplication.hashKey", str);
			editor.commit();
		  }
		}
		catch (Exception)
		{
		}
	  }

	  internal static bool SdcardAvailable
	  {
		  get
		  {
			return Environment.getExternalStorageState().Equals("mounted");
		  }
	  }

	  public static int kdCancelTimer(CoreApplication$KDTimer paramCoreApplication$KDTimer)
	  {
		if (!paramCoreApplication$KDTimer.callerThread.Equals(Thread.CurrentThread))
		{
		  return -1;
		}
		paramCoreApplication$KDTimer.cancel();
		return 0;
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern long kdGetTimeUST();

	  public static CoreApplication$KDTimer kdSetTimer(long paramLong1, int paramInt, long paramLong2, long paramLong3)
	  {
		if (paramInt != 61)
		{
		  bool bool1 = true;
		  return new CoreApplication$KDTimer(bool1, paramLong1, paramLong2, paramLong3);
		}
		bool @bool = false;
		return new CoreApplication$KDTimer(@bool, paramLong1, paramLong2, paramLong3);
	  }

	  private static void onStopJobRequired()
	  {
		currentActivity.onStopRequired();
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void postEvent(int[] paramArrayOfint);

	  private static d prepareForCore(MotionEvent paramMotionEvent)
	  {
		eventProxy.ev = paramMotionEvent;
		int i = eventProxy.PointerCount;
		d d = new d(new float[i], new float[i]);
		for (sbyte b = 0; b < i; b++)
		{
		  d.a[b] = eventProxy.getX(b);
		  d.b[b] = eventProxy.getY(b);
		}
		return d;
	  }

	  public static void quitEventLoop()
	  {
		Looper.myLooper().quit();
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern int registerCurrentThread();

	  private void restoreFsRoot()
	  {
		SharedPreferences sharedPreferences = applicationContext.getSharedPreferences("ru.yandex.core.CoreApplication", 0);
		if (sharedPreferences.contains("ru.yandex.core.CoreApplication.resFsRoot"))
		{
		  this.resFsRoot = sharedPreferences.getString("ru.yandex.core.CoreApplication.resFsRoot", "");
		}
		else
		{
		  this.resFsRoot = getRootForFileSystem(1);
		  SharedPreferences.Editor editor = sharedPreferences.edit();
		  editor.putString("ru.yandex.core.CoreApplication.resFsRoot", this.resFsRoot);
		  editor.commit();
		}
		if (sharedPreferences.contains("ru.yandex.core.CoreApplication.otherFsRoot"))
		{
		  this.otherFsRoot = sharedPreferences.getString("ru.yandex.core.CoreApplication.otherFsRoot", "");
		}
		else
		{
		  this.otherFsRoot = getRootForFileSystem(2);
		  SharedPreferences.Editor editor = sharedPreferences.edit();
		  editor.putString("ru.yandex.core.CoreApplication.otherFsRoot", this.otherFsRoot);
		  editor.commit();
		}
		Directory.CreateDirectory(this.resFsRoot);
		Directory.CreateDirectory(this.otherFsRoot);
	  }

	  public static void runEventLoop()
	  {
		Looper.loop();
	  }

	  public static void sendEvent(int[] paramArrayOfint)
	  {
		postEvent(paramArrayOfint);
	  }

	  private static bool Active
	  {
		  set
		  {
			if (isActive != value)
			{
			  isActive = value;
			}
		  }
	  }

	  public static void setCurrent(KDActivity paramKDActivity, KDView paramKDView)
	  {
		currentActivity = paramKDActivity;
		currentView = paramKDView;
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern int shutdown();

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void shutdownGestureRecognizers(long paramLong);

	  public static void signalThreadWithNativeEventLoop(Handler paramHandler)
	  {
		paramHandler.post(deliver);
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void signalTimerFired(long paramLong1, long paramLong2);

	  public static void startGPS()
	  {
		LocationManager locationManager = (LocationManager)applicationContext.getSystemService("location");
		if (locationManager != null)
		{
		  locationManager.requestLocationUpdates("gps", 0L, 0.0F, coreApplication);
		  locationManager.requestLocationUpdates("network", 0L, 0.0F, coreApplication);
		}
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern void startJob(int paramInt);

	  public static void startListeningCurrentTelephonyNetwork()
	  {
		((TelephonyManager)applicationContext.getSystemService("phone")).listen(telephonyListener, 17);
	  }

	  public static void startListeningTelephonySignalStrength()
	  {
		((TelephonyManager)applicationContext.getSystemService("phone")).listen(signalStrengthListener, 2);
	  }

	  public static void stopGPS()
	  {
		LocationManager locationManager = (LocationManager)applicationContext.getSystemService("location");
		if (locationManager != null)
		{
		  locationManager.removeUpdates(coreApplication);
		}
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern void stopJob(int paramInt);

	  public static void stopListeningCurrentTelephonyNetwork()
	  {
		((TelephonyManager)applicationContext.getSystemService("phone")).listen(telephonyListener, 0);
	  }

	  public static void stopListeningTelephonySignalStrength()
	  {
		((TelephonyManager)applicationContext.getSystemService("phone")).listen(signalStrengthListener, 0);
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void touchesBegan(long paramLong1, float[] paramArrayOffloat1, float[] paramArrayOffloat2, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void touchesCancelled(long paramLong1, float[] paramArrayOffloat1, float[] paramArrayOffloat2, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void touchesEnded(long paramLong1, float[] paramArrayOffloat1, float[] paramArrayOffloat2, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void touchesMoved(long paramLong1, float[] paramArrayOffloat1, float[] paramArrayOffloat2, long paramLong2);

	  public static void tryPause()
	  {
		if (isActive && (!currentView.isSurfaceCreated || currentActivity.isPaused))
		{
		  l.b.a = true;
		  l.b = null;
		  postEvent(new int[] {45});
		  Active = false;
		}
	  }

	  public static void tryResume()
	  {
		if (!isActive && currentView.isSurfaceCreated && !currentActivity.isPaused)
		{
		  if (!currentActivity.isStarted)
		  {
			currentActivity.startJob();
		  }
		  Active = true;
		  postEvent(new int[] {46});
		  l l = new l();
		  l.b = l;
		  View.post((ThreadStart)l);
		}
	  }

	  private void unpackAssets()
	  {
		Debug.Assert(!string.ReferenceEquals(this.resFsRoot, null));
		string str = getAppNameFromNative() + ".pak";
		File file = new File(this.resFsRoot);
		sbyte[] arrayOfByte = new sbyte[65536];
		FileStream fileOutputStream = new FileStream(file.getAbsolutePath() + "/" + str, FileMode.Create, FileAccess.Write);
		foreach (string str1 in applicationContext.getResources().getAssets().list(""))
		{
		  if (str1.StartsWith(str, StringComparison.Ordinal))
		  {
			Stream inputStream = applicationContext.getResources().getAssets().open(str1);
			while (inputStream.available() > 0)
			{
			  fileOutputStream.Write(arrayOfByte, 0, inputStream.Read(arrayOfByte, 0, Math.Min(arrayOfByte.Length, inputStream.available())));
			}
			inputStream.Close();
		  }
		}
		fileOutputStream.Close();
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern int unregisterCurrentThread();

	  ~CoreApplication()
	  {
		shutdownGestureRecognizers(coreGestureRecognizer);
//JAVA TO C# CONVERTER NOTE: The base class finalizer method is automatically called in C#:
//		base.finalize();
	  }

	  public virtual void onLocationChanged(Location paramLocation)
	  {
		bool @bool;
		if (paramLocation.getProvider() != null && paramLocation.getProvider().Equals("gps"))
		{
		  this.gpsLocation = paramLocation;
		  @bool = true;
		}
		else
		{
		  this.networkLocation = paramLocation;
		  bool bool1 = true;
		  @bool = bool1;
		  if (!string.ReferenceEquals(this.activeProvider, null))
		  {
			@bool = bool1;
			if (this.activeProvider.Equals("gps"))
			{
			  return;
			}
		  }
		}
		this.activeProvider = paramLocation.getProvider();
		sendLocation(paramLocation, @bool);
	  }

	  public virtual void onProviderDisabled(string paramString)
	  {
	  }

	  public virtual void onProviderEnabled(string paramString)
	  {
	  }

	  public virtual void onStatusChanged(string paramString, int paramInt, Bundle paramBundle)
	  {
		bool @bool;
		if (!string.ReferenceEquals(paramString, null) && paramString.Equals("gps"))
		{
		  this.gpsStatus = paramInt;
		}
		else
		{
		  this.networkStatus = paramInt;
		}
		if (this.gpsStatus == 2 || this.networkStatus == 2)
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		if (@bool != this.currStatus)
		{
		  postEvent(new int[] {102, paramInt});
		}
		this.currStatus = @bool;
		if (!string.ReferenceEquals(paramString, null) && paramString.Equals("gps") && paramInt != 2 && this.networkStatus == 2)
		{
		  this.activeProvider = "network";
		  sendLocation(this.networkLocation, 1);
		}
	  }

	  internal virtual void sendLocation(Location paramLocation, int paramInt)
	  {
		double d1 = -1.0D;
		int i = (int)(paramLocation.getLatitude() * 1000000.0D);
		int j = (int)(paramLocation.getLongitude() * 1000000.0D);
		if (paramLocation.hasSpeed())
		{
		  d2 = paramLocation.getSpeed() * 10.0D;
		}
		else
		{
		  d2 = -1.0D;
		}
		int k = (int)d2;
		if (paramLocation.hasBearing())
		{
		  d2 = paramLocation.getBearing() * 10.0D;
		}
		else
		{
		  d2 = -1.0D;
		}
		int m = (int)d2;
		if (paramLocation.hasAccuracy())
		{
		  d2 = paramLocation.getAccuracy() * 10.0D;
		}
		else
		{
		  d2 = -1.0D;
		}
		int n = (int)d2;
		double d2 = d1;
		if (paramLocation.hasAltitude())
		{
		  d2 = paramLocation.getAltitude() * 10.0D;
		}
		postEvent(new int[] {101, i, j, k, m, n, (int)d2, paramInt});
	  }

	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\CoreApplication.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}