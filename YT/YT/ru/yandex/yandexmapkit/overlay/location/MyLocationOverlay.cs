using System;
using System.Collections.Generic;
using System.Text;

namespace ru.yandex.yandexmapkit.overlay.location
{
	using ag;
	using ai;
	using Context = android.content.Context;
	using Resources = android.content.res.Resources;
	using BitmapFactory = android.graphics.BitmapFactory;
	using GeomagneticField = android.hardware.GeomagneticField;
	using Sensor = android.hardware.Sensor;
	using SensorEvent = android.hardware.SensorEvent;
	using SensorEventListener = android.hardware.SensorEventListener;
	using SensorManager = android.hardware.SensorManager;
	using Location = android.location.Location;
	using LocationListener = android.location.LocationListener;
	using LocationManager = android.location.LocationManager;
	using Bundle = android.os.Bundle;
	using Handler = android.os.Handler;
	using MotionEvent = android.view.MotionEvent;
	using WindowManager = android.view.WindowManager;
	using aq;
	using b;
	using bl;
	using bm;
	using bn;
	using bo;
	using bp;
	using bq;
	using by;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using GeoCode = ru.yandex.yandexmapkit.map.GeoCode;
	using GeoCodeListener = ru.yandex.yandexmapkit.map.GeoCodeListener;
	using MapEvent = ru.yandex.yandexmapkit.map.MapEvent;
	using OnMapListener = ru.yandex.yandexmapkit.map.OnMapListener;
	using DownloadHandler = ru.yandex.yandexmapkit.net.DownloadHandler;
	using DownloadJob = ru.yandex.yandexmapkit.net.DownloadJob;
	using Downloader = ru.yandex.yandexmapkit.net.Downloader;
	using IRender = ru.yandex.yandexmapkit.overlay.IRender;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
	using OnBalloonListener = ru.yandex.yandexmapkit.overlay.balloon.OnBalloonListener;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class MyLocationOverlay : Overlay, SensorEventListener, LocationListener, GeoCodeListener, OnMapListener, DownloadHandler, OnBalloonListener
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public bool d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public bool e_Conflict = true;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public bool f_Conflict = false;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal bl g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public bp h_Conflict;

	  public bo i;

	  internal MyLocationItem j;

	  private long k;

	  private volatile ag l;

	  private bool m = false;

	  private SensorManager n;

	  private long o = 0L;

	  private ai p;

	  private LocationManager q;

	  private bq r;

	  private Handler s;

	  private Context t;

	  private bool u = true;

	  private bn v;

	  private WindowManager w;

	  private OnBalloonListener x;

	  public MyLocationOverlay(MapController paramMapController) : base(paramMapController)
	  {
		this.t = paramMapController.Context;
		Resources resources = this.t.getResources();
		BalloonItem balloonItem = new BalloonItem(new GeoPoint(0.0D, 0.0D), null);
		balloonItem.OffsetY = -10;
		balloonItem.Text = "Это я";
		this.g_Conflict = new bl(new GeoPoint(0.0D, 0.0D), BitmapFactory.decodeResource(resources, resources.getIdentifier("user_location_gps", "drawable", this.t.getPackageName())));
		this.g_Conflict.BalloonItem = balloonItem;
		this.h_Conflict = new bp(new GeoPoint(0.0D, 0.0D), BitmapFactory.decodeResource(resources, resources.getIdentifier("user_location_lbs", "drawable", this.t.getPackageName())));
		this.h_Conflict.BalloonItem = balloonItem;
		this.i = new bo();
		addOverlayItem((OverlayItem)this.g_Conflict);
		addOverlayItem((OverlayItem)this.h_Conflict);
		addOverlayItem((OverlayItem)this.i);
		this.p = new ai(true);
		this.p.a(this.t);
		this.s = (Handler)new bm(this);
		this.v = new bn();
		IRender = (IRender)this.v;
		MapController.addMapListener(this);
		this.r = new bq(this);
		this.w = (WindowManager)this.t.getSystemService("window");
		this.q = (LocationManager)this.t.getSystemService("location");
		this.n = (SensorManager)this.t.getSystemService("sensor");
	  }

	  private bool a(float paramFloat, MyLocationItem paramMyLocationItem)
	  {
		// Byte code:
		//   0: ldc 180.0
		//   2: fstore_3
		//   3: invokestatic currentTimeMillis : ()J
		//   6: lstore #4
		//   8: lload #4
		//   10: aload_0
		//   11: getfield o : J
		//   14: lsub
		//   15: lstore #6
		//   17: lload #6
		//   19: ldc2_w 500
		//   22: lcmp
		//   23: ifge -> 32
		//   26: iconst_0
		//   27: istore #8
		//   29: iload #8
		//   31: ireturn
		//   32: fload_1
		//   33: aload_2
		//   34: invokevirtual getBearing : ()F
		//   37: fsub
		//   38: fstore #9
		//   40: fload #9
		//   42: ldc 180.0
		//   44: fcmpl
		//   45: ifle -> 109
		//   48: fload #9
		//   50: ldc 360.0
		//   52: fsub
		//   53: fstore #10
		//   55: lload #6
		//   57: ldc2_w 10000
		//   60: lcmp
		//   61: ifle -> 131
		//   64: fload #10
		//   66: fload_3
		//   67: fcmpl
		//   68: ifle -> 146
		//   71: aload_2
		//   72: invokevirtual getBearing : ()F
		//   75: fneg
		//   76: fload_3
		//   77: fadd
		//   78: fstore #9
		//   80: fload #9
		//   82: ldc 360.0
		//   84: fcmpl
		//   85: iflt -> 146
		//   88: aload_2
		//   89: fload #9
		//   91: ldc 360.0
		//   93: fsub
		//   94: invokevirtual c : (F)V
		//   97: aload_0
		//   98: lload #4
		//   100: putfield o : J
		//   103: iconst_1
		//   104: istore #8
		//   106: goto -> 29
		//   109: fload #9
		//   111: fstore #10
		//   113: fload #9
		//   115: ldc -180.0
		//   117: fcmpg
		//   118: ifge -> 55
		//   121: fload #9
		//   123: ldc 360.0
		//   125: fadd
		//   126: fstore #10
		//   128: goto -> 55
		//   131: lload #6
		//   133: ldc2_w 60
		//   136: lmul
		//   137: ldc2_w 1000
		//   140: ldiv
		//   141: l2f
		//   142: fstore_3
		//   143: goto -> 64
		//   146: fload #10
		//   148: fload_3
		//   149: fneg
		//   150: fcmpg
		//   151: ifge -> 181
		//   154: aload_2
		//   155: invokevirtual getBearing : ()F
		//   158: fload_3
		//   159: fsub
		//   160: fstore #10
		//   162: fload #10
		//   164: fconst_0
		//   165: fcmpg
		//   166: ifge -> 181
		//   169: aload_2
		//   170: fload #10
		//   172: ldc 360.0
		//   174: fadd
		//   175: invokevirtual c : (F)V
		//   178: goto -> 97
		//   181: aload_2
		//   182: fload_1
		//   183: invokevirtual c : (F)V
		//   186: goto -> 97
	  }

	  private void g()
	  {
		if (this.q != null)
		{
		  try
		  {
			this.q.requestLocationUpdates("gps", 500L, 1.0F, this);
		  }
		  catch (System.ArgumentException)
		  {
		  }
		}
		try
		{
		  if (this.n != null)
		  {
			IList<Sensor> list = this.n.getSensorList(3);
			if (list != null)
			{
			  this.n.registerListener(this, list[0], 2);
			}
		  }
		}
		catch (Exception)
		{
		}
	  }

	  private void h()
	  {
		if (this.n != null)
		{
		  this.n.unregisterListener(this);
		}
		if (this.q != null)
		{
		  this.q.removeUpdates(this);
		}
	  }

	  public virtual void a()
	  {
		ag ag1 = this.p.a();
		ag ag2 = this.l;
		if (ag1 != null && (ag2 == null || !ag2.Equals(ag1)))
		{
		  MapController.Downloader.downloadProccess(this, 1);
		}
	  }

	  public virtual void a(BalloonItem paramBalloonItem)
	  {
		this.g_Conflict.BalloonItem = paramBalloonItem;
		this.h_Conflict.BalloonItem = paramBalloonItem;
	  }

	  public virtual void a(bool paramBoolean)
	  {
		bool bool2;
		bool bool1 = true;
		this.g_Conflict.Visible = paramBoolean;
		bo bo1 = this.i;
		if (!paramBoolean)
		{
		  bool2 = true;
		}
		else
		{
		  bool2 = false;
		}
		bo1.Visible = bool2;
		bp bp1 = this.h_Conflict;
		if (!paramBoolean)
		{
		  bool2 = bool1;
		}
		else
		{
		  bool2 = false;
		}
		bp1.Visible = bool2;
		if (paramBoolean)
		{
		  bl bl1 = this.g_Conflict;
		}
		else
		{
		  bp1 = this.h_Conflict;
		}
		this.j = (MyLocationItem)bp1;
	  }

	  public virtual void b()
	  {
		onStatusChanged((string)null, 1, Bundle.EMPTY);
	  }

	  public virtual void c()
	  {
		if (this.q != null && !this.r.a())
		{
		  this.q.requestLocationUpdates("network", 10000L, 1.0F, (LocationListener)this.r);
		  this.r.a(true);
		}
	  }

	  public virtual void d()
	  {
		if (this.q != null && this.r.a())
		{
		  this.q.removeUpdates((LocationListener)this.r);
		  this.r.a(false);
		}
	  }

	  public virtual void e()
	  {
		if (Enabled)
		{
		  g();
		  c();
		  this.s.sendEmptyMessage(1);
		}
	  }

	  public virtual void f()
	  {
		if (Enabled)
		{
		  h();
		  d();
		  this.s.removeMessages(1);
		}
	  }

	  public virtual void findMe()
	  {
		MyLocationItem myLocationItem = MyLocationItem;
		if (myLocationItem != null)
		{
		  this.f_Conflict = true;
		  MapController.a(myLocationItem.Point);
		}
	  }

	  public virtual MyLocationItem MyLocationItem
	  {
		  get
		  {
			return this.j;
		  }
	  }

	  public virtual bool Enabled
	  {
		  get
		  {
			return this.u;
		  }
		  set
		  {
			this.u = value;
			if (Enabled)
			{
			  g();
			  return;
			}
			h();
		  }
	  }

	  public virtual void onAccuracyChanged(Sensor paramSensor, int paramInt)
	  {
	  }

	  public virtual void onBalloonClick(MotionEvent paramMotionEvent, BalloonItem paramBalloonItem)
	  {
		if (this.x != null)
		{
		  this.x.onBalloonClick(paramMotionEvent, paramBalloonItem);
		}
	  }

	  public virtual void onBalloonHide(BalloonItem paramBalloonItem)
	  {
	  }

	  public virtual void onBalloonShow(BalloonItem paramBalloonItem)
	  {
	  }

	  public virtual DownloadJob onCreateDownloadJob(int paramInt)
	  {
		if (paramInt == 2)
		{
		  StringBuilder stringBuilder = new StringBuilder(Downloader.getServer(15));
		  stringBuilder.Append("/stats/?action=gps&uuid=");
		  stringBuilder.Append(Downloader.UUID);
		  stringBuilder.Append("&internalgps=1");
		  return new DownloadJob(2, stringBuilder.ToString(), 0, null, this, null, 2500L);
		}
		if (paramInt == 1)
		{
		  ag ag1 = this.p.a();
		  if (ag1 != null)
		  {
			StringBuilder stringBuilder = new StringBuilder(Downloader.getServer(14));
			stringBuilder.Append("/cellid_location/?lac=");
			stringBuilder.Append(ag1.e);
			stringBuilder.Append("&cellid=");
			stringBuilder.Append(ag1.d);
			stringBuilder.Append("&operatorid=");
			stringBuilder.Append(ag1.c);
			stringBuilder.Append("&countrycode=");
			stringBuilder.Append(ag1.b);
			if (ag1.g)
			{
			  stringBuilder.Append("&signalstrength=");
			  stringBuilder.Append(ag1.f);
			}
			if (!string.ReferenceEquals(ag1.a_Conflict, null))
			{
			  stringBuilder.Append("&wifinetworks=");
			  stringBuilder.Append(ag1.a_Conflict);
			}
			stringBuilder.Append("&uuid=");
			stringBuilder.Append(Downloader.UUID);
			DownloadJob downloadJob = new DownloadJob(1, stringBuilder.ToString(), 0, null, this, ag1, 500L);
			downloadJob.Priority = 1;
			return downloadJob;
		  }
		}
		return null;
	  }

	  public virtual bool onFinishDownload(DownloadJob paramDownloadJob, bool paramBoolean)
	  {
		// Byte code:
		//   0: aload_1
		//   1: ifnull -> 32
		//   4: aload_1
		//   5: getfield a : I
		//   8: tableswitch default -> 32, 1 -> 36, 2 -> 334
		//   32: iconst_1
		//   33: istore_2
		//   34: iload_2
		//   35: ireturn
		//   36: aload_1
		//   37: getfield e : I
		//   40: sipush #200
		//   43: if_icmpne -> 297
		//   46: aload_1
		//   47: getfield f : [B
		//   50: ifnull -> 297
		//   53: iconst_1
		//   54: istore_3
		//   55: iload_3
		//   56: ifeq -> 365
		//   59: aload_1
		//   60: getfield i : Ljava/lang/Object;
		//   63: checkcast ag
		//   66: astore #4
		//   68: aload #4
		//   70: aload_1
		//   71: getfield f : [B
		//   74: invokevirtual a : ([B)Z
		//   77: istore #5
		//   79: iload #5
		//   81: istore #6
		//   83: iload #5
		//   85: ifeq -> 260
		//   88: iload #5
		//   90: istore #6
		//   92: aload_0
		//   93: getfield d : Z
		//   96: ifne -> 260
		//   99: aload_0
		//   100: aload #4
		//   102: putfield l : Lag;
		//   105: aload_0
		//   106: getfield r : Lbq;
		//   109: invokevirtual a : ()Z
		//   112: ifeq -> 124
		//   115: aload_0
		//   116: getfield s : Landroid/os/Handler;
		//   119: iconst_4
		//   120: invokevirtual sendEmptyMessage : (I)Z
		//   123: pop
		//   124: new by
		//   127: astore_1
		//   128: aload_1
		//   129: aload #4
		//   131: getfield j : J
		//   134: aload #4
		//   136: getfield k : J
		//   139: invokespecial <init> : (JJ)V
		//   142: aload_0
		//   143: getfield i : Lbo;
		//   146: astore #7
		//   148: new ru/yandex/yandexmapkit/utils/GeoPoint
		//   151: astore #8
		//   153: aload #8
		//   155: aload #4
		//   157: getfield h : F
		//   160: f2d
		//   161: aload #4
		//   163: getfield i : F
		//   166: f2d
		//   167: invokespecial <init> : (DD)V
		//   170: aload #7
		//   172: aload #8
		//   174: invokevirtual setGeoPoint : (Lru/yandex/yandexmapkit/utils/GeoPoint;)V
		//   177: aload_0
		//   178: getfield i : Lbo;
		//   181: aload #4
		//   183: getfield l : I
		//   186: invokevirtual a : (I)V
		//   189: aload_0
		//   190: getfield h : Lbp;
		//   193: astore #7
		//   195: new ru/yandex/yandexmapkit/utils/GeoPoint
		//   198: astore #8
		//   200: aload #8
		//   202: aload #4
		//   204: getfield h : F
		//   207: f2d
		//   208: aload #4
		//   210: getfield i : F
		//   213: f2d
		//   214: invokespecial <init> : (DD)V
		//   217: aload #7
		//   219: aload #8
		//   221: invokevirtual setGeoPoint : (Lru/yandex/yandexmapkit/utils/GeoPoint;)V
		//   224: aload_0
		//   225: getfield e : Z
		//   228: ifeq -> 302
		//   231: aload_0
		//   232: iconst_0
		//   233: putfield e : Z
		//   236: aload_0
		//   237: invokevirtual getMapController : ()Lru/yandex/yandexmapkit/MapController;
		//   240: aload_1
		//   241: invokevirtual a : (Lby;)V
		//   244: aload_0
		//   245: iconst_0
		//   246: invokevirtual a : (Z)V
		//   249: aload_0
		//   250: invokevirtual getMapController : ()Lru/yandex/yandexmapkit/MapController;
		//   253: invokevirtual notifyRepaint : ()V
		//   256: iload #5
		//   258: istore #6
		//   260: iload #6
		//   262: ifne -> 32
		//   265: aload_0
		//   266: getfield r : Lbq;
		//   269: invokevirtual a : ()Z
		//   272: ifne -> 284
		//   275: aload_0
		//   276: getfield s : Landroid/os/Handler;
		//   279: iconst_3
		//   280: invokevirtual sendEmptyMessage : (I)Z
		//   283: pop
		//   284: iload_2
		//   285: ifne -> 32
		//   288: iload_3
		//   289: ifne -> 32
		//   292: iconst_0
		//   293: istore_2
		//   294: goto -> 34
		//   297: iconst_0
		//   298: istore_3
		//   299: goto -> 55
		//   302: aload_0
		//   303: getfield f : Z
		//   306: ifeq -> 244
		//   309: aload_0
		//   310: invokevirtual getMapController : ()Lru/yandex/yandexmapkit/MapController;
		//   313: aload_0
		//   314: getfield h : Lbp;
		//   317: invokevirtual getPoint : ()Lby;
		//   320: invokevirtual b : (Lby;)V
		//   323: goto -> 244
		//   326: astore_1
		//   327: iload #5
		//   329: istore #6
		//   331: goto -> 260
		//   334: aload_1
		//   335: getfield e : I
		//   338: sipush #200
		//   341: if_icmpeq -> 348
		//   344: iload_2
		//   345: ifeq -> 353
		//   348: iconst_1
		//   349: istore_2
		//   350: goto -> 34
		//   353: iconst_0
		//   354: istore_2
		//   355: goto -> 34
		//   358: astore_1
		//   359: iconst_0
		//   360: istore #6
		//   362: goto -> 331
		//   365: iconst_0
		//   366: istore #6
		//   368: goto -> 260
		// Exception table:
		//   from	to	target	type
		//   59	79	358	java/lang/Exception
		//   92	124	326	java/lang/Exception
		//   124	244	326	java/lang/Exception
		//   244	256	326	java/lang/Exception
		//   302	323	326	java/lang/Exception
	  }

	  public virtual bool onFinishGeoCode(GeoCode paramGeoCode)
	  {
		if (paramGeoCode != null)
		{
		  BalloonItem balloonItem = MyLocationItem.BalloonItem;
		  balloonItem.Text = paramGeoCode.DisplayName;
		  a(balloonItem);
		}
		return true;
	  }

	  public virtual void onLocationChanged(Location paramLocation)
	  {
		if (paramLocation != null && ("gps".Equals(paramLocation.getProvider()) || (paramLocation.hasAccuracy() && paramLocation.getAccuracy() < 100.0F)))
		{
		  object @object;
		  float f;
		  if (!this.d_Conflict)
		  {
			this.s.removeMessages(1);
			this.s.sendEmptyMessage(4);
			a(true);
		  }
		  if (this.b.Contains(this.g_Conflict))
		  {
			@object = this.g_Conflict.Point;
		  }
		  else
		  {
			@object = null;
		  }
		  this.d_Conflict = true;
		  double d1 = paramLocation.getLatitude();
		  double d2 = paramLocation.getLongitude();
		  this.g_Conflict.GeoPoint = new GeoPoint(d1, d2);
		  if (this.e_Conflict)
		  {
			this.e_Conflict = false;
			MapController.a(this.g_Conflict.Point);
		  }
		  if (!this.g_Conflict.b())
		  {
			try
			{
			  GeomagneticField geomagneticField = new GeomagneticField();
			  this((float)d1, (float)d2, (float)paramLocation.getAltitude(), DateTimeHelper.CurrentUnixTimeMillis());
			  this.g_Conflict.a(geomagneticField.getDeclination());
			  this.g_Conflict.b(true);
			}
			catch (Exception)
			{
			}
		  }
		  bl bl1 = this.g_Conflict;
		  if (paramLocation.hasSpeed())
		  {
			f = paramLocation.getSpeed() * 3.6F;
		  }
		  else
		  {
			f = 0.0F;
		  }
		  bl1.b(f);
		  if (paramLocation.hasBearing() && this.g_Conflict.Speed >= 8.0F)
		  {
			this.g_Conflict.a(true);
			if (a(paramLocation.getBearing(), (MyLocationItem)this.g_Conflict))
			{
			  MapController.notifyRepaint();
			}
		  }
		  this.g_Conflict.a(paramLocation.getTime());
		  if (this.b.Contains(this.g_Conflict) && @object != null && !this.m)
		  {
			by by2 = this.g_Conflict.Point;
			by by1 = MapController.get23Point(new ScreenPoint((this.c.l().getWidth() / 2), (this.c.l().getHeight() / 2)));
			by1.x += by2.x - ((by)@object).x;
			by1.y += by2.y - ((by)@object).y;
			MapController.b(by1);
		  }
		  if (Downloader.e() == 2 && DateTimeHelper.CurrentUnixTimeMillis() - this.k > 300000L)
		  {
			this.k = DateTimeHelper.CurrentUnixTimeMillis();
			MapController.Downloader.downloadProccess(this, 2);
		  }
		  if (this.s != null)
		  {
			this.s.removeMessages(2);
			if (!paramLocation.hasAccuracy() || paramLocation.getAccuracy() > 35.0F)
			{
			  this.s.sendEmptyMessageDelayed(2, 20000L);
			}
		  }
		}
	  }

	  public virtual void onMapActionEvent(MapEvent paramMapEvent)
	  {
		this.e_Conflict = false;
		this.f_Conflict = false;
		switch (paramMapEvent.Msg)
		{
		  default:
			return;
		  case 1:
		  case 4:
		  case 7:
			this.m = true;
			  goto case 3;
		  case 3:
		  case 6:
		  case 9:
			break;
		}
		this.m = false;
	  }

	  public virtual void onProviderDisabled(string paramString)
	  {
		this.d_Conflict = false;
		if (this.s != null)
		{
		  this.s.sendEmptyMessage(1);
		}
	  }

	  public virtual void onProviderEnabled(string paramString)
	  {
	  }

	  public virtual void onSensorChanged(SensorEvent paramSensorEvent)
	  {
		float f1 = 0.0F;
		if (paramSensorEvent.sensor.getType() == 3 && !this.g_Conflict.a())
		{
		  float f = f1;
		  switch (this.w.getDefaultDisplay().getOrientation())
		  {
			default:
			  f = f1;
				goto case 0;
			case 0:
			  a((f + paramSensorEvent.values[0] + this.g_Conflict.c()) % 360.0F, (MyLocationItem)this.g_Conflict);
			  return;
			case 1:
			  f = 90.0F;
				goto case 2;
			case 2:
			  f = 180.0F;
				goto case 3;
			case 3:
			  break;
		  }
		}
		else
		{
		  return;
		}
		float f2 = 270.0F;
	  }

	  public override bool onSingleTapUp(float paramFloat1, float paramFloat2)
	  {
		bool @bool = base.onSingleTapUp(paramFloat1, paramFloat2);
		if (@bool)
		{
		  MapController.Downloader.getGeoCode(this, MyLocationItem.GeoPoint);
		}
		return @bool;
	  }

	  public virtual void onStartDownload(int paramInt)
	  {
	  }

	  public virtual void onStatusChanged(string paramString, int paramInt, Bundle paramBundle)
	  {
		bool @bool;
		if (paramInt == 2)
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		this.d_Conflict = @bool;
		if (this.s != null)
		{
		  if (!this.d_Conflict)
		  {
			this.s.sendEmptyMessage(1);
			return;
		  }
		}
		else
		{
		  return;
		}
		this.s.removeMessages(1);
	  }

	  public override System.Collections.IList prepareDraw()
	  {
		this.b.Clear();
		if (!Visible)
		{
		  return this.b;
		}
		foreach (OverlayItem overlayItem in this.a_Conflict)
		{
		  MyLocationItem myLocationItem = (MyLocationItem)overlayItem;
		  try
		  {
			if (myLocationItem.Visible)
			{
			  aq aq;
			  bool @bool;
			  int i;
			  int j;
			  int k;
			  int m;
			  float f;
			  ScreenPoint screenPoint = this.c.getScreenPoint(myLocationItem.Point);
			  myLocationItem.ScreenPoint = screenPoint;
			  switch (myLocationItem.Type)
			  {
				case 1:
				case 2:
				  i = -overlayItem.OffsetCenterX;
				  j = overlayItem.OffsetX;
				  k = -overlayItem.OffsetCenterY;
				  m = overlayItem.OffsetY;
				  f = screenPoint.X;
				  @bool = b.a((int)((i - j) + f), (int)(screenPoint.Y + (k - m)), overlayItem.Bitmap.getWidth(), overlayItem.Bitmap.getHeight(), 0, 0, this.c.l().getWidth(), this.c.l().getHeight());
				  if (@bool)
				  {
					this.b.Add(myLocationItem);
				  }
				  break;
				case 3:
				  j = myLocationItem.Rradius;
				  aq = MapController.g();
				  if (aq.o())
				  {
					f = (float)Math.Pow(2.0D, (23.0F - aq.l()));
					j = (int)(j / f);
				  }
				  else
				  {
					k = aq.c();
					j >>= k;
				  }
				  ((bo)overlayItem).a(j);
				  @bool = true;
				  if (@bool)
				  {
					this.b.Add(myLocationItem);
				  }
				  break;
			  }
			}
		  }
		  catch (Exception)
		  {
		  }
		}
		return PrepareDrawList;
	  }

	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\location\MyLocationOverlay.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}