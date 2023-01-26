using System;
using System.Threading;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Intent = android.content.Intent;
	using Resources = android.content.res.Resources;
	using Bitmap = android.graphics.Bitmap;
	using Uri = android.net.Uri;
	using Bundle = android.os.Bundle;
	using Parcelable = android.os.Parcelable;
	using PowerManager = android.os.PowerManager;
	using Vibrator = android.os.Vibrator;
	using PreferenceManager = android.preference.PreferenceManager;
	using DisplayMetrics = android.util.DisplayMetrics;
	using Log = android.util.Log;
	using KeyEvent = android.view.KeyEvent;
	using Menu = android.view.Menu;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using WindowManager = android.view.WindowManager;
	using Button = android.widget.Button;
	using ImageView = android.widget.ImageView;
	using TextView = android.widget.TextView;
	using Toast = android.widget.Toast;
	using od;
	using oe;
	using of;
	using og;
	using oh;
	using oi;
	using oj;
	using om;
	using on;
	using oo;
	using op;
	using oq;
	using or;
	using ow;
	using Utils = ru.yandex.taxi.Utils;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUrlDemoUtils = ru.yandex.taxi.client.HttpUrlDemoUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using OnTheWayResponse = ru.yandex.taxi.client.response.OnTheWayResponse;
	using Driver = ru.yandex.taxi.data.Driver;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using MapUtils = ru.yandex.taxi.map.MapUtils;
	using TaxiDialogFactory = ru.yandex.taxi.ui.dialog.TaxiDialogFactory;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using MapView = ru.yandex.yandexmapkit.MapView;
	using OverlayManager = ru.yandex.yandexmapkit.OverlayManager;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class TaxiOnTheWayToSourceActivity : Activity
	{
	  public const string ARRIVED = "arrived";

	  protected internal const long ARRIVE_TAXI_VIBRATE_TIME = 1000L;

	  public const int CANCELED_BY_TAXI = 2;

	  public const int CANCELED_BY_USER = 1;

	  protected internal const long CANCEL_TAXI_VIBRATE_TIME = 1500L;

	  protected internal const int DIALOG_MSG = 3;

	  protected internal const long FOUND_STATE_DELAY_TIME = 5000L;

	  protected internal const int MENU_ITEM_AUTO = 4;

	  protected internal const int MENU_ITEM_CALL_TO_TAXI = 3;

	  protected internal const int MENU_ITEM_CANCEL = 0;

	  protected internal const int MENU_ITEM_NEW_ORDER = 1;

	  protected internal const int MENU_ITEM_TARIF = 2;

	  protected internal const string MSG = "msg";

	  public const string NEED_RATE = "need rate";

	  public const int REQUEST_AUTO_INFO = 0;

	  public const int REQUEST_BLOCK = 4;

	  public const int REQUEST_CALL_AFTER_CANCEL = 5;

	  public const int REQUEST_ORDER_FINISHED = 2;

	  public const int REQUEST_PARK_INFO = 1;

	  public const int REQUEST_RATING = 3;

	  public const int REQUEST_TAXI_DEST = 6;

	  public const string TAXI_ARRIVED_DIALOG = "taxi arrived dialog";

	  public const string TAXI_LOGO = "taxi logo";

	  protected internal const string TITLE = "title";

	  protected internal const int WAY_TO_DEST = 1;

	  protected internal const int WAY_TO_SRC = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private Thread a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private GeoPoint b_Conflict;

	  private string c;

	  private int d;

	  private PowerManager.WakeLock e;

	  private bool f;

	  private string g = "10 минут";

	  private bool h;

	  private View i;

	  private Overlay j;

	  protected internal bool mActivityStarted;

	  protected internal GeocodeJsonObject mAddress;

	  public bool mArrived;

	  protected internal string mBreak = "none";

	  public string mClientId;

	  public string mCurrentStatus;

	  public bool mDemoMode;

	  public GeocodeJsonObject mDestAddress;

	  protected internal string mDialogMsg;

	  protected internal int mDialogTitle;

	  public Driver mDriver;

	  public bool mInterrupt;

	  protected internal MapView mMap;

	  public MapController mMapController;

	  public string mOrderId;

	  public OverlayManager mOverlayManager;

	  public string mParkId;

	  public string mParkiName;

	  public Resources mResources;

	  public bool mScreenVisible;

	  public Overlay mSource;

	  public Bitmap mSourceBitmap;

	  public GeocodeJsonObject mSrcAddress;

	  protected internal string mTariffId;

	  protected internal string mTariffName;

	  public TaxiClient mTaxiClient;

	  protected internal string mTaxiLogoUrl;

	  protected internal bool mTaxiOnTheWayMode = true;

	  public int mWayDirection;

	  protected internal DateTime mWhen;

	  private void a()
	  {
		Intent intent = new Intent(getApplicationContext(), typeof(AutoActivity));
		intent.putExtra("driver", (Serializable)this.mDriver);
		intent.putExtra("tariff name", this.mTariffName);
		startActivityForResult(intent, 0);
	  }

	  private void b()
	  {
		Intent intent = new Intent((Context)this, typeof(ParkInfoActivity));
		intent.putExtra("type", 2);
		intent.putExtra("order id", this.mOrderId);
		intent.putExtra("park id", this.mParkId);
		intent.putExtra("tariff id", this.mTariffId);
		intent.putExtra("when", DateTime.Now);
		startActivityForResult(intent, 1);
	  }

	  public virtual void addAddressBalloon(GeoPoint paramGeoPoint, string paramString, OverlayItem paramOverlayItem, bool paramBoolean)
	  {
		Resources resources = getResources();
		BalloonItem balloonItem = new BalloonItem(paramGeoPoint, null);
		if (!paramBoolean)
		{
		  string str1;
		  string str2 = resources.getString(2131296302);
		  SimpleDateFormat simpleDateFormat = new SimpleDateFormat(resources.getString(2131296400), Utils.CurrentLocale);
		  paramString = string.Format("<b>{0}</b>", new object[] {paramString});
		  if (this.mWhen != null)
		  {
			str1 = simpleDateFormat.format(this.mWhen);
		  }
		  else
		  {
			str1 = "";
		  }
		  paramString = String.format(str2, new object[] {paramString, string.Format("<b>{0}</b>", new object[] {str1})});
		}
		balloonItem.Text = paramString;
		paramOverlayItem.BalloonItem = balloonItem;
		this.mMapController.notifyRepaint();
	  }

	  protected internal virtual void afterStartAction()
	  {
		this.a_Conflict = (Thread)new ow(this);
		this.a_Conflict.Start();
	  }

	  protected internal virtual void beforeStopAction()
	  {
		this.a_Conflict.Interrupt();
	  }

	  public virtual void downloadBitmap(string paramString, ImageView paramImageView)
	  {
		this.mTaxiLogoUrl = paramString;
		runOnUiThread((ThreadStart)new oh(this, paramImageView, paramString));
	  }

	  public virtual void finish()
	  {
		this.mInterrupt = true;
		if (this.f)
		{
		  PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).edit().putBoolean("notification call", true).commit();
		}
		base.finish();
	  }

	  protected internal virtual TaxiClient TaxiClient
	  {
		  get
		  {
			Context context = getApplicationContext();
			if (this.mDemoMode)
			{
			  HttpUrlDemoUtils httpUrlDemoUtils = new HttpUrlDemoUtils();
			  return new TaxiClient(context, (HttpUtils)httpUrlDemoUtils);
			}
			HttpUrlConnectionUtils httpUrlConnectionUtils = new HttpUrlConnectionUtils();
			return new TaxiClient(context, (HttpUtils)httpUrlConnectionUtils);
		  }
	  }

	  protected internal virtual void initOrderObjects()
	  {
		this.mAddress = this.mSrcAddress;
		this.mResources.getString(2131296324);
	  }

	  public virtual void initTaxiInfoUi(string paramString1, string paramString2, string paramString3, string paramString4, string paramString5)
	  {
		this.mParkId = paramString1;
		this.c = paramString2;
		this.mParkiName = paramString3;
		this.mTariffId = paramString4;
		this.mTariffName = paramString5;
		try
		{
		  DisplayMetrics displayMetrics = new DisplayMetrics();
		  this();
		  ((WindowManager)getSystemService("window")).getDefaultDisplay().getMetrics(displayMetrics);
		  int i = displayMetrics.densityDpi;
		  switch (i)
		  {
			default:
			  str = "hdpi";
			  findViewById(2131558501).setOnClickListener((View.OnClickListener)new og(this));
			  downloadBitmap(string.Format("http://yandex.st/taxi/android/{0}/{1}.png", new object[] {str, paramString1}), (ImageView)findViewById(2131558500));
			  return;
			case 240:
			  str = "hdpi";
			  findViewById(2131558501).setOnClickListener((View.OnClickListener)new og(this));
			  downloadBitmap(string.Format("http://yandex.st/taxi/android/{0}/{1}.png", new object[] {str, paramString1}), (ImageView)findViewById(2131558500));
			  return;
			case 160:
			  str = "mdpi";
			  findViewById(2131558501).setOnClickListener((View.OnClickListener)new og(this));
			  downloadBitmap(string.Format("http://yandex.st/taxi/android/{0}/{1}.png", new object[] {str, paramString1}), (ImageView)findViewById(2131558500));
			  return;
			case 120:
			  break;
		  }
		  string str = "ldpi";
		  findViewById(2131558501).setOnClickListener((View.OnClickListener)new og(this));
		  downloadBitmap(string.Format("http://yandex.st/taxi/android/{0}/{1}.png", new object[] {str, paramString1}), (ImageView)findViewById(2131558500));
		  return;
		}
		catch (Exception)
		{
		  Log.e("TaxiOnTheWayToSourceActivity", "Fail get density size");
		}
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		if (paramInt1 != 1 && paramInt1 != 0)
		{
		  finish();
		}
	  }

	  public virtual void onCreate(Bundle paramBundle)
	  {
		// Byte code:
		//   0: aload_0
		//   1: aload_1
		//   2: invokespecial onCreate : (Landroid/os/Bundle;)V
		//   5: aload_0
		//   6: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   9: ldc_w 'ui'
		//   12: invokestatic initExceptionHandler : (Landroid/content/Context;Ljava/lang/String;)V
		//   15: aload_0
		//   16: ldc_w 2130903079
		//   19: invokevirtual setContentView : (I)V
		//   22: aload_0
		//   23: invokevirtual getWindow : ()Landroid/view/Window;
		//   26: iconst_1
		//   27: invokevirtual setFormat : (I)V
		//   30: aload_0
		//   31: aload_0
		//   32: invokevirtual getResources : ()Landroid/content/res/Resources;
		//   35: putfield mResources : Landroid/content/res/Resources;
		//   38: aload_0
		//   39: aload_0
		//   40: ldc_w 2131558454
		//   43: invokevirtual findViewById : (I)Landroid/view/View;
		//   46: checkcast ru/yandex/yandexmapkit/MapView
		//   49: putfield mMap : Lru/yandex/yandexmapkit/MapView;
		//   52: aload_0
		//   53: aload_0
		//   54: getfield mMap : Lru/yandex/yandexmapkit/MapView;
		//   57: invokevirtual getMapController : ()Lru/yandex/yandexmapkit/MapController;
		//   60: putfield mMapController : Lru/yandex/yandexmapkit/MapController;
		//   63: aload_0
		//   64: aload_0
		//   65: getfield mMapController : Lru/yandex/yandexmapkit/MapController;
		//   68: invokevirtual getOverlayManager : ()Lru/yandex/yandexmapkit/OverlayManager;
		//   71: putfield mOverlayManager : Lru/yandex/yandexmapkit/OverlayManager;
		//   74: aload_0
		//   75: getfield mMap : Lru/yandex/yandexmapkit/MapView;
		//   78: iconst_1
		//   79: invokevirtual showZoomButtons : (Z)V
		//   82: aload_0
		//   83: getfield mMap : Lru/yandex/yandexmapkit/MapView;
		//   86: iconst_0
		//   87: invokevirtual showFindMeButton : (Z)V
		//   90: aload_0
		//   91: getfield mOverlayManager : Lru/yandex/yandexmapkit/OverlayManager;
		//   94: invokevirtual getMyLocation : ()Lru/yandex/yandexmapkit/overlay/location/MyLocationOverlay;
		//   97: iconst_0
		//   98: invokevirtual setEnabled : (Z)V
		//   101: aload_0
		//   102: aload_0
		//   103: ldc_w 2131558480
		//   106: invokevirtual findViewById : (I)Landroid/view/View;
		//   109: putfield i : Landroid/view/View;
		//   112: aload_0
		//   113: aload_0
		//   114: getfield mResources : Landroid/content/res/Resources;
		//   117: ldc_w 2130837507
		//   120: invokestatic decodeResource : (Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;
		//   123: putfield mSourceBitmap : Landroid/graphics/Bitmap;
		//   126: aload_0
		//   127: aload_0
		//   128: ldc_w 'power'
		//   131: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
		//   134: checkcast android/os/PowerManager
		//   137: bipush #10
		//   139: ldc_w 'TaxiOnTheWayToSourceActivity'
		//   142: invokevirtual newWakeLock : (ILjava/lang/String;)Landroid/os/PowerManager$WakeLock;
		//   145: putfield e : Landroid/os/PowerManager$WakeLock;
		//   148: aload_0
		//   149: ldc_w 'driving'
		//   152: putfield mCurrentStatus : Ljava/lang/String;
		//   155: aload_0
		//   156: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   159: invokestatic getDefaultSharedPreferences : (Landroid/content/Context;)Landroid/content/SharedPreferences;
		//   162: astore_1
		//   163: aload_0
		//   164: aload_1
		//   165: ldc_w 'client id'
		//   168: ldc_w ''
		//   171: invokeinterface getString : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   176: putfield mClientId : Ljava/lang/String;
		//   179: aload_0
		//   180: invokevirtual getIntent : ()Landroid/content/Intent;
		//   183: invokevirtual getExtras : ()Landroid/os/Bundle;
		//   186: astore_2
		//   187: aload_2
		//   188: ifnull -> 239
		//   191: aload_2
		//   192: ldc 'order id'
		//   194: invokevirtual containsKey : (Ljava/lang/String;)Z
		//   197: ifeq -> 239
		//   200: aload_0
		//   201: aload_2
		//   202: ldc_w 'demo'
		//   205: invokevirtual getBoolean : (Ljava/lang/String;)Z
		//   208: putfield mDemoMode : Z
		//   211: aload_0
		//   212: getfield mDemoMode : Z
		//   215: ifeq -> 560
		//   218: aload_0
		//   219: getstatic ru/yandex/taxi/client/HttpUrlDemoUtils.SRC_ADDRESS : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   222: putfield mSrcAddress : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   225: aload_0
		//   226: getstatic ru/yandex/taxi/client/HttpUrlDemoUtils.DEST_ADDRESS : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   229: putfield mDestAddress : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   232: aload_0
		//   233: ldc_w '123'
		//   236: putfield mOrderId : Ljava/lang/String;
		//   239: aload_0
		//   240: getfield mSrcAddress : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   243: ifnonnull -> 366
		//   246: aload_0
		//   247: invokevirtual getContentResolver : ()Landroid/content/ContentResolver;
		//   250: astore_3
		//   251: getstatic ru/yandex/taxi/db/StaticDataScheme$CurrentOrderTable.CONTENT_URI : Landroid/net/Uri;
		//   254: astore #4
		//   256: aload_0
		//   257: getfield mOrderId : Ljava/lang/String;
		//   260: astore #5
		//   262: aload_3
		//   263: aload #4
		//   265: iconst_2
		//   266: anewarray java/lang/String
		//   269: dup
		//   270: iconst_0
		//   271: ldc_w 'src'
		//   274: aastore
		//   275: dup
		//   276: iconst_1
		//   277: ldc_w 'desc'
		//   280: aastore
		//   281: ldc_w 'order_id = ?'
		//   284: iconst_1
		//   285: anewarray java/lang/String
		//   288: dup
		//   289: iconst_0
		//   290: aload #5
		//   292: aastore
		//   293: aconst_null
		//   294: invokevirtual query : (Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;
		//   297: astore #4
		//   299: aload #4
		//   301: invokeinterface getCount : ()I
		//   306: ifle -> 366
		//   309: aload #4
		//   311: invokeinterface moveToFirst : ()Z
		//   316: pop
		//   317: aload_0
		//   318: new ru/yandex/taxi/map/GeocodeJsonObject
		//   321: dup
		//   322: aload #4
		//   324: iconst_0
		//   325: invokeinterface getString : (I)Ljava/lang/String;
		//   330: invokespecial <init> : (Ljava/lang/String;)V
		//   333: putfield mSrcAddress : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   336: aload #4
		//   338: iconst_1
		//   339: invokeinterface getString : (I)Ljava/lang/String;
		//   344: ifnull -> 366
		//   347: aload_0
		//   348: new ru/yandex/taxi/map/GeocodeJsonObject
		//   351: dup
		//   352: aload #4
		//   354: iconst_1
		//   355: invokeinterface getString : (I)Ljava/lang/String;
		//   360: invokespecial <init> : (Ljava/lang/String;)V
		//   363: putfield mDestAddress : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   366: aload_0
		//   367: getfield mArrived : Z
		//   370: ifeq -> 387
		//   373: aload_0
		//   374: ldc_w 2131296558
		//   377: invokevirtual setTitle : (I)V
		//   380: aload_0
		//   381: ldc_w 'waiting'
		//   384: putfield mCurrentStatus : Ljava/lang/String;
		//   387: aload_2
		//   388: ifnull -> 427
		//   391: aload_2
		//   392: ldc_w 'notification call'
		//   395: invokevirtual containsKey : (Ljava/lang/String;)Z
		//   398: ifeq -> 427
		//   401: aload_1
		//   402: invokeinterface edit : ()Landroid/content/SharedPreferences$Editor;
		//   407: ldc_w 'notification call'
		//   410: iconst_0
		//   411: invokeinterface putBoolean : (Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;
		//   416: invokeinterface commit : ()Z
		//   421: pop
		//   422: aload_0
		//   423: iconst_1
		//   424: putfield f : Z
		//   427: aload_0
		//   428: invokevirtual initOrderObjects : ()V
		//   431: aload_0
		//   432: aload_0
		//   433: invokevirtual getTaxiClient : ()Lru/yandex/taxi/client/TaxiClient;
		//   436: putfield mTaxiClient : Lru/yandex/taxi/client/TaxiClient;
		//   439: aload_0
		//   440: getfield mMapController : Lru/yandex/yandexmapkit/MapController;
		//   443: astore_1
		//   444: aload_0
		//   445: getfield mDemoMode : Z
		//   448: ifeq -> 680
		//   451: ldc_w 14.0
		//   454: fstore #6
		//   456: aload_1
		//   457: fload #6
		//   459: invokevirtual setZoomCurrent : (F)V
		//   462: aload_0
		//   463: iconst_0
		//   464: putfield mWayDirection : I
		//   467: aload_0
		//   468: getfield mDemoMode : Z
		//   471: ifeq -> 688
		//   474: aload_0
		//   475: getfield mMap : Lru/yandex/yandexmapkit/MapView;
		//   478: iconst_0
		//   479: invokevirtual showFindMeButton : (Z)V
		//   482: aload_0
		//   483: getfield mMap : Lru/yandex/yandexmapkit/MapView;
		//   486: iconst_0
		//   487: invokevirtual showZoomButtons : (Z)V
		//   490: aload_0
		//   491: getfield mMap : Lru/yandex/yandexmapkit/MapView;
		//   494: iconst_0
		//   495: invokevirtual showJamsButton : (Z)V
		//   498: aload_0
		//   499: getfield mMapController : Lru/yandex/yandexmapkit/MapController;
		//   502: iconst_0
		//   503: invokevirtual setEnabled : (Z)V
		//   506: aload_0
		//   507: ldc_w 2131558459
		//   510: invokevirtual findViewById : (I)Landroid/view/View;
		//   513: ldc_w 2130837551
		//   516: invokevirtual setBackgroundResource : (I)V
		//   519: aload_0
		//   520: new java/lang/StringBuilder
		//   523: dup
		//   524: invokespecial <init> : ()V
		//   527: aload_0
		//   528: invokevirtual getResources : ()Landroid/content/res/Resources;
		//   531: ldc_w 2131296275
		//   534: invokevirtual getString : (I)Ljava/lang/String;
		//   537: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   540: ldc_w ': '
		//   543: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   546: aload_0
		//   547: invokevirtual getTitle : ()Ljava/lang/CharSequence;
		//   550: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   553: invokevirtual toString : ()Ljava/lang/String;
		//   556: invokevirtual setTitle : (Ljava/lang/CharSequence;)V
		//   559: return
		//   560: aload_0
		//   561: aload_2
		//   562: ldc_w 'src point'
		//   565: invokevirtual get : (Ljava/lang/String;)Ljava/lang/Object;
		//   568: checkcast ru/yandex/taxi/map/GeocodeJsonObject
		//   571: putfield mSrcAddress : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   574: aload_0
		//   575: aload_2
		//   576: ldc_w 'dest point'
		//   579: invokevirtual get : (Ljava/lang/String;)Ljava/lang/Object;
		//   582: checkcast ru/yandex/taxi/map/GeocodeJsonObject
		//   585: putfield mDestAddress : Lru/yandex/taxi/map/GeocodeJsonObject;
		//   588: aload_0
		//   589: aload_2
		//   590: ldc 'order id'
		//   592: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   595: putfield mOrderId : Ljava/lang/String;
		//   598: aload_0
		//   599: aload_2
		//   600: ldc 'arrived'
		//   602: iconst_0
		//   603: invokevirtual getBoolean : (Ljava/lang/String;Z)Z
		//   606: putfield mArrived : Z
		//   609: aload_0
		//   610: aload_2
		//   611: ldc 'when'
		//   613: invokevirtual getSerializable : (Ljava/lang/String;)Ljava/io/Serializable;
		//   616: checkcast java/util/Date
		//   619: putfield mWhen : Ljava/util/Date;
		//   622: aload_2
		//   623: ldc 'taxi logo'
		//   625: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   628: astore #4
		//   630: aload #4
		//   632: ifnull -> 239
		//   635: aload_0
		//   636: aload #4
		//   638: aload_0
		//   639: ldc_w 2131558500
		//   642: invokevirtual findViewById : (I)Landroid/view/View;
		//   645: checkcast android/widget/ImageView
		//   648: invokevirtual downloadBitmap : (Ljava/lang/String;Landroid/widget/ImageView;)V
		//   651: goto -> 239
		//   654: astore_1
		//   655: ldc_w 'TaxiOnTheWayToSourceActivity'
		//   658: ldc_w 'Fail init http client'
		//   661: aload_1
		//   662: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
		//   665: pop
		//   666: aload_0
		//   667: ldc_w 'Fail init http client'
		//   670: invokestatic showErrorMessage : (Landroid/content/Context;Ljava/lang/String;)V
		//   673: aload_0
		//   674: invokevirtual finish : ()V
		//   677: goto -> 439
		//   680: ldc_w 12.0
		//   683: fstore #6
		//   685: goto -> 456
		//   688: aload_0
		//   689: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   692: invokestatic getDefaultSharedPreferences : (Landroid/content/Context;)Landroid/content/SharedPreferences;
		//   695: astore_1
		//   696: aload_0
		//   697: getfield mMapController : Lru/yandex/yandexmapkit/MapController;
		//   700: aload_1
		//   701: ldc_w 'jams on'
		//   704: iconst_0
		//   705: invokeinterface getBoolean : (Ljava/lang/String;Z)Z
		//   710: invokevirtual setJamsVisible : (Z)V
		//   713: aload_1
		//   714: ldc 'need rate'
		//   716: invokeinterface contains : (Ljava/lang/String;)Z
		//   721: ifne -> 559
		//   724: aload_1
		//   725: invokeinterface edit : ()Landroid/content/SharedPreferences$Editor;
		//   730: ldc 'need rate'
		//   732: iconst_1
		//   733: invokeinterface putBoolean : (Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;
		//   738: invokeinterface commit : ()Z
		//   743: pop
		//   744: goto -> 559
		// Exception table:
		//   from	to	target	type
		//   431	439	654	java/lang/Exception
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		AlertDialog.Builder builder1;
		Button button;
		string str2;
		AlertDialog alertDialog3;
		Dialog dialog3;
		string str1;
		AlertDialog alertDialog2;
		Dialog dialog2;
		Dialog dialog1 = null;
		AlertDialog.Builder builder2 = new AlertDialog.Builder((Context)this);
		Dialog dialog4 = dialog1;
		switch (paramInt)
		{
		  default:
			dialog4 = dialog1;
			  goto case 2;
		  case 2:
			return dialog4;
		  case 0:
			builder1 = builder2.setTitle(2131296320);
			if (this.mTaxiOnTheWayMode)
			{
			  str2 = String.format(this.mResources.getString(2131296296), new object[] {this.g});
			}
			else
			{
			  str2 = this.mResources.getString(2131296297);
			}
			builder1.setMessage(str2).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new oj(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new oi());
			alertDialog3 = builder2.create();
			  goto case 1;
		  case 1:
			dialog3 = TaxiDialogFactory.createCancelByTaxiDialog(this, this.mParkiName, (DialogInterface.OnClickListener)new om(this), (DialogInterface.OnClickListener)new on(this));
			  goto case 3;
		  case 3:
			paramInt = this.mDialogTitle;
			str1 = this.mDialogMsg;
			builder1 = new AlertDialog.Builder((Context)this);
			builder1.setTitle(paramInt).setMessage(str1).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new of(this));
			alertDialog2 = builder1.create();
			  goto case 4;
		  case 4:
			dialog2 = new Dialog((Context)this);
			dialog2.setContentView(2130903063);
			dialog2.setTitle(2131296337);
			((TextView)dialog2.findViewById(2131558401)).setText(2131296338);
			dialog2.findViewById(2131558448).setVisibility(8);
			button = (Button)dialog2.findViewById(2131558486);
			if (this.mDriver != null)
			{
			  button.setText(2131296559);
			  button.setOnClickListener((View.OnClickListener)new oq(this));
			}
			else
			{
			  button.setVisibility(8);
			}
			button = (Button)dialog2.findViewById(2131558487);
			if (this.d >= 0)
			{
			  button.setText(2131296331);
			  button.setOnClickListener((View.OnClickListener)new or(this));
			}
			else
			{
			  button.setVisibility(8);
			}
			button = (Button)dialog2.findViewById(2131558415);
			button.setText(2131296336);
			button.setOnClickListener((View.OnClickListener)new oe(this));
			PreferenceManager.getDefaultSharedPreferences((Context)this).edit().putString("taxi arrived dialog", this.mOrderId).commit();
			  goto case 5;
		  case 5:
			break;
		}
		AlertDialog.Builder builder3 = new AlertDialog.Builder((Context)this);
		builder3.setTitle(2131296340).setMessage(2131296341).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new op(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new oo(this));
		AlertDialog alertDialog1 = builder3.create();
	  }

	  public virtual bool onCreateOptionsMenu(Menu paramMenu)
	  {
		if (!this.mDemoMode)
		{
		  paramMenu.add(0, 0, 0, 2131296322).setIcon(2130837604);
		  paramMenu.add(0, 2, 0, 2131296541).setIcon(2130837613);
		  paramMenu.add(0, 1, 0, 2131296321).setIcon(2130837611);
		  paramMenu.add(0, 3, 0, 2131296280).setIcon(2130837603);
		  paramMenu.add(0, 4, 0, 2131296330).setIcon(2130837605);
		}
		return true;
	  }

	  public virtual bool onKeyDown(int paramInt, KeyEvent paramKeyEvent)
	  {
		if (!this.mArrived)
		{
		  switch (paramInt)
		  {
			default:
			  return base.onKeyDown(paramInt, paramKeyEvent);
			case 4:
			  break;
		  }
		  showDialog(5);
		  return true;
		}
	  }

	  public virtual bool onOptionsItemSelected(MenuItem paramMenuItem)
	  {
		switch (paramMenuItem.getItemId())
		{
		  default:
			return true;
		  case 0:
			if (!this.mArrived)
			{
			  showDialog(0);
			}
			Toast.makeText((Context)this, 2131296567, 0).show();
			  goto case 1;
		  case 1:
			finish();
			  goto case 2;
		  case 2:
			b();
			  goto case 3;
		  case 3:
			startActivity(new Intent("android.intent.action.CALL", Uri.parse("tel:" + this.c)));
			  goto case 4;
		  case 4:
			break;
		}
		a();
	  }

	  protected internal virtual void onPause()
	  {
		this.mScreenVisible = false;
		PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).edit().putBoolean("jams on", this.mMapController.JamsVisible).commit();
		base.onPause();
	  }

	  public virtual bool onPrepareOptionsMenu(Menu paramMenu)
	  {
		bool @bool = true;
		if (!this.mDemoMode)
		{
		  bool bool1;
		  if (!string.ReferenceEquals(this.mParkId, null))
		  {
			bool1 = true;
		  }
		  else
		  {
			bool1 = false;
		  }
		  paramMenu.findItem(2).setEnabled(bool1);
		  MenuItem menuItem = paramMenu.findItem(4);
		  if (menuItem != null)
		  {
			if (this.mDriver != null)
			{
			  bool1 = true;
			}
			else
			{
			  bool1 = false;
			}
			menuItem.setEnabled(bool1);
		  }
		  menuItem = paramMenu.findItem(3);
		  if (!string.ReferenceEquals(this.c, null) && !"null".Equals(this.c))
		  {
			bool1 = true;
		  }
		  else
		  {
			bool1 = false;
		  }
		  menuItem.setEnabled(bool1);
		  menuItem = paramMenu.findItem(0);
		  if (menuItem != null)
		  {
			if (!this.mArrived)
			{
			  bool1 = @bool;
			}
			else
			{
			  bool1 = false;
			}
			menuItem.setVisible(bool1);
		  }
		}
		return base.onPrepareOptionsMenu(paramMenu);
	  }

	  protected internal virtual void onStart()
	  {
		base.onStart();
		if (PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).getBoolean("notification call", false))
		{
		  this.mInterrupt = true;
		  finish();
		}
		else
		{
		  this.mInterrupt = false;
		}
		this.mActivityStarted = true;
		this.e.acquire();
		afterStartAction();
	  }

	  protected internal virtual void onStop()
	  {
		beforeStopAction();
		this.mInterrupt = true;
		this.mActivityStarted = false;
		this.e.release();
		base.onStop();
	  }

	  public virtual OnTheWayResponse requestData()
	  {
		return this.mTaxiClient.doTaxiOnTheWay(this.mClientId, this.mOrderId, this.mBreak);
	  }

	  public virtual void showTaxiArriveEvent()
	  {
		if (!this.mDemoMode)
		{
		  ((Vibrator)getSystemService("vibrator")).vibrate(1000L);
		}
		if (this.mArrived)
		{
		  this.mInterrupt = true;
		  Intent intent = new Intent((Context)this, typeof(TaxiOnTheWayToDescActivity));
		  intent.putExtra("dest point", (Parcelable)this.mDestAddress);
		  intent.putExtra("order id", this.mOrderId);
		  intent.putExtra("demo", this.mDemoMode);
		  intent.putExtra("taxi logo", this.mTaxiLogoUrl);
		  startActivityForResult(intent, 6);
		  return;
		}
		runOnUiThread((ThreadStart)new od(this));
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\TaxiOnTheWayToSourceActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}