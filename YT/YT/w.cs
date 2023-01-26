using System;
using System.Collections;
using System.Threading;

using Context = android.content.Context;
using Canvas = android.graphics.Canvas;
using Matrix = android.graphics.Matrix;
using PointF = android.graphics.PointF;
using Handler = android.os.Handler;
using Looper = android.os.Looper;
using AttributeSet = android.util.AttributeSet;
using Log = android.util.Log;
using MotionEvent = android.view.MotionEvent;
using SurfaceHolder = android.view.SurfaceHolder;
using SurfaceView = android.view.SurfaceView;
using CoreApplication = ru.yandex.core.CoreApplication;
using MapController = ru.yandex.yandexmapkit.MapController;
using MapView = ru.yandex.yandexmapkit.MapView;
using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;

public sealed class w : SurfaceView, SurfaceHolder.Callback, Runnable, z
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal volatile bool a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal volatile bool b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal volatile bool c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal bool d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Thread e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Handler f_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly SurfaceHolder g_Conflict;

  private ArrayList h;

  private bool i;

  private Matrix j;

  private MapController k;

  private MapView l;

  public w(Context paramContext, AttributeSet paramAttributeSet, MapView paramMapView) : base(paramContext, paramAttributeSet)
  {
	new by();
	new PointF();
	this.i = false;
	this.d_Conflict = false;
	CoreApplication.initOnce(paramContext, new rg());
	this.l = paramMapView;
	getResources().getDisplayMetrics();
	this.k = new MapController(this, this.l);
	this.h = new ArrayList();
	this.g_Conflict = getHolder();
	this.g_Conflict.addCallback(this);
	this.a_Conflict = true;
	this.c_Conflict = true;
	setFocusableInTouchMode(true);
	setFocusable(true);
  }

  private void g()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield h : Ljava/util/ArrayList;
	//   6: invokevirtual isEmpty : ()Z
	//   9: ifne -> 88
	//   12: aload_0
	//   13: getfield f : Landroid/os/Handler;
	//   16: astore_1
	//   17: aload_1
	//   18: ifnonnull -> 27
	//   21: ldc2_w 250
	//   24: invokestatic sleep : (J)V
	//   27: aload_0
	//   28: getfield f : Landroid/os/Handler;
	//   31: ifnull -> 81
	//   34: aload_0
	//   35: getfield h : Ljava/util/ArrayList;
	//   38: invokevirtual iterator : ()Ljava/util/Iterator;
	//   41: astore_1
	//   42: aload_1
	//   43: invokeinterface hasNext : ()Z
	//   48: ifeq -> 81
	//   51: aload_1
	//   52: invokeinterface next : ()Ljava/lang/Object;
	//   57: checkcast java/lang/Integer
	//   60: astore_2
	//   61: aload_0
	//   62: getfield f : Landroid/os/Handler;
	//   65: aload_2
	//   66: invokevirtual intValue : ()I
	//   69: invokevirtual sendEmptyMessage : (I)Z
	//   72: pop
	//   73: goto -> 42
	//   76: astore_1
	//   77: aload_0
	//   78: monitorexit
	//   79: aload_1
	//   80: athrow
	//   81: aload_0
	//   82: getfield h : Ljava/util/ArrayList;
	//   85: invokevirtual clear : ()V
	//   88: aload_0
	//   89: monitorexit
	//   90: return
	//   91: astore_1
	//   92: goto -> 27
	// Exception table:
	//   from	to	target	type
	//   2	17	76	finally
	//   21	27	91	java/lang/Exception
	//   21	27	76	finally
	//   27	42	76	finally
	//   42	73	76	finally
	//   81	88	76	finally
  }

  public MapController a()
  {
	return this.k;
  }

  public void a(bool paramBoolean)
  {
	this.d_Conflict = paramBoolean;
  }

  public void b()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: iconst_1
	//   4: invokevirtual a : (Z)V
	//   7: aload_0
	//   8: getfield a : Z
	//   11: ifne -> 47
	//   14: aload_0
	//   15: getfield f : Landroid/os/Handler;
	//   18: ifnull -> 47
	//   21: aload_0
	//   22: getfield b : Z
	//   25: istore_1
	//   26: iload_1
	//   27: ifeq -> 47
	//   30: aload_0
	//   31: getfield f : Landroid/os/Handler;
	//   34: iconst_0
	//   35: invokevirtual removeMessages : (I)V
	//   38: aload_0
	//   39: getfield f : Landroid/os/Handler;
	//   42: iconst_0
	//   43: invokevirtual sendEmptyMessage : (I)Z
	//   46: pop
	//   47: aload_0
	//   48: monitorexit
	//   49: return
	//   50: astore_2
	//   51: aload_0
	//   52: monitorexit
	//   53: aload_2
	//   54: athrow
	//   55: astore_2
	//   56: goto -> 47
	// Exception table:
	//   from	to	target	type
	//   2	26	50	finally
	//   30	47	55	java/lang/Exception
	//   30	47	50	finally
  }

  public bool c()
  {
	return this.i;
  }

  public Matrix d()
  {
	return this.j;
  }

  public void e()
  {
	Canvas canvas = null;
	if (this.k.g().f())
	{
	  a(true);
	}
	if (this.c_Conflict)
	{
	  a(false);
	}
	if (this.d_Conflict)
	{
	  a(false);
	  try
	  {
		Canvas canvas1 = this.g_Conflict.lockCanvas(null);
		canvas = canvas1;
		try
		{
		  this.k.a(canvas);
		  System.Collections.IDictionary map = this.k.OverlayManager.a();
		  OverlayItem[] arrayOfOverlayItem = (OverlayItem[])map.Keys.toArray((object[])new OverlayItem[0]);
		  Array.Sort((object[])arrayOfOverlayItem);
		  return;
		}
		catch (Exception)
		{

		}
		finally
		{
		  canvas1 = null;
		}
		throw canvas1;
	  }
	  catch (Exception)
	  {

	  }
	  finally
	  {
		Exception exception = null;
		canvas = null;
	  }
	}
	else
	{
	  if (this.f_Conflict != null)
	  {
		this.f_Conflict.removeMessages(0);
		this.f_Conflict.sendEmptyMessageDelayed(0, 700L);
	  }
	  return;
	}
	if (canvas != null)
	{
	  this.g_Conflict.unlockCanvasAndPost(canvas);
	}
  }

  public void f()
  {
	this.b_Conflict = false;
	this.f_Conflict = null;
	Looper.myLooper().quit();
  }

  public bool onTouchEvent(MotionEvent paramMotionEvent)
  {
	return this.k.a(paramMotionEvent);
  }

  public bool onTrackballEvent(MotionEvent paramMotionEvent)
  {
	return this.k.b(paramMotionEvent);
  }

  public void run()
  {
	Looper.prepare();
	this.f_Conflict = new rh(this);
	g();
	Looper.loop();
  }

  public void surfaceChanged(SurfaceHolder paramSurfaceHolder, int paramInt1, int paramInt2, int paramInt3)
  {
	Log.d("mw", "surfaceChanged");
	try
	{
	  this.k.a(paramInt2, paramInt3);
	}
	catch (Exception)
	{
	}
  }

  public void surfaceCreated(SurfaceHolder paramSurfaceHolder)
  {
	Log.d("mw", "surfaceCreated");
	if (!this.b_Conflict)
	{
	  this.b_Conflict = true;
	  this.e_Conflict = new Thread(this, "ymm-main");
	  this.e_Conflict.Start();
	  while (this.f_Conflict == null)
	  {
		Thread.yield();
	  }
	}
	this.c_Conflict = false;
	g();
	this.k.i();
	Log.d("mw", "startAll");
	setFocusable(true);
	setFocusableInTouchMode(true);
	this.k.b();
	this.a_Conflict = false;
	b();
  }

  public void surfaceDestroyed(SurfaceHolder paramSurfaceHolder)
  {
	Log.d("mw", "surfaceDestroyed");
	this.c_Conflict = true;
	this.a_Conflict = true;
	this.k.j();
	this.k.c();
	if (this.f_Conflict != null)
	{
	  try
	  {
		this.f_Conflict.sendEmptyMessage(1);
	  }
	  catch (Exception)
	  {
	  }
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\w.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */