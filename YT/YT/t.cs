using System;

using Context = android.content.Context;
using Canvas = android.graphics.Canvas;
using Matrix = android.graphics.Matrix;
using Handler = android.os.Handler;
using AttributeSet = android.util.AttributeSet;
using Log = android.util.Log;
using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using CoreApplication = ru.yandex.core.CoreApplication;
using MapController = ru.yandex.yandexmapkit.MapController;
using MapView = ru.yandex.yandexmapkit.MapView;
using IRender = ru.yandex.yandexmapkit.overlay.IRender;
using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;

public class t : View, z
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public bool a_Conflict = false;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public Matrix b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal volatile bool c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private MapController d_Conflict;

  private MapView e;

  private Handler f;

  public t(Context paramContext, AttributeSet paramAttributeSet, MapView paramMapView) : base(paramContext, paramAttributeSet)
  {
	CoreApplication.initOnce(paramContext, new re());
	this.e = paramMapView;
	getResources().getDisplayMetrics();
	this.d_Conflict = new MapController(this, this.e);
	this.c_Conflict = true;
	setFocusableInTouchMode(true);
	setFocusable(true);
	this.f = new rf(this);
  }

  public virtual MapController a()
  {
	return this.d_Conflict;
  }

  public virtual void b()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield c : Z
	//   6: ifne -> 35
	//   9: aload_0
	//   10: getfield f : Landroid/os/Handler;
	//   13: astore_1
	//   14: aload_1
	//   15: ifnull -> 35
	//   18: aload_0
	//   19: getfield f : Landroid/os/Handler;
	//   22: iconst_0
	//   23: invokevirtual removeMessages : (I)V
	//   26: aload_0
	//   27: getfield f : Landroid/os/Handler;
	//   30: iconst_0
	//   31: invokevirtual sendEmptyMessage : (I)Z
	//   34: pop
	//   35: aload_0
	//   36: monitorexit
	//   37: return
	//   38: astore_1
	//   39: aload_0
	//   40: monitorexit
	//   41: aload_1
	//   42: athrow
	//   43: astore_1
	//   44: goto -> 35
	// Exception table:
	//   from	to	target	type
	//   2	14	38	finally
	//   18	35	43	java/lang/Exception
	//   18	35	38	finally
  }

  public virtual bool c()
  {
	return this.a_Conflict;
  }

  public virtual Matrix d()
  {
	return this.b_Conflict;
  }

  protected internal virtual void onDraw(Canvas paramCanvas)
  {
	paramCanvas.drawColor(-1);
	this.d_Conflict.g().f();
	try
	{
	  this.d_Conflict.a(paramCanvas);
	  System.Collections.IDictionary map = this.d_Conflict.OverlayManager.a();
	  OverlayItem[] arrayOfOverlayItem = (OverlayItem[])map.Keys.toArray((object[])new OverlayItem[0]);
	  Array.Sort((object[])arrayOfOverlayItem);
	  int i = arrayOfOverlayItem.Length;
	  for (sbyte b = 0; b < i; b++)
	  {
		OverlayItem overlayItem = arrayOfOverlayItem[b];
		((IRender)map[overlayItem]).draw(paramCanvas, overlayItem);
	  }
	}
	catch (Exception)
	{

	}
	finally
	{
	}
	invalidate();
  }

  protected internal virtual void onSizeChanged(int paramInt1, int paramInt2, int paramInt3, int paramInt4)
  {
	base.onSizeChanged(paramInt1, paramInt2, paramInt3, paramInt4);
	this.d_Conflict.a(paramInt1, paramInt2);
	Log.e("onSizeChanged", "w = " + paramInt1 + " h = " + paramInt2);
  }

  public virtual bool onTouchEvent(MotionEvent paramMotionEvent)
  {
	return this.d_Conflict.a(paramMotionEvent);
  }

  public virtual bool onTrackballEvent(MotionEvent paramMotionEvent)
  {
	return this.d_Conflict.b(paramMotionEvent);
  }

  protected internal virtual void onWindowVisibilityChanged(int paramInt)
  {
	base.onWindowVisibilityChanged(paramInt);
	Log.e("onWindowVisibilityChanged", "visibility = " + paramInt);
	if (paramInt == 0)
	{
	  this.d_Conflict.i();
	  Log.d("mw", "startAll");
	  setFocusable(true);
	  setFocusableInTouchMode(true);
	  this.d_Conflict.b();
	  this.c_Conflict = false;
	  return;
	}
	if (8 == paramInt)
	{
	  this.c_Conflict = true;
	  this.d_Conflict.j();
	  this.d_Conflict.c();
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\t.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */