using System;
using System.Collections;

namespace ru.yandex.yandexmapkit.overlay
{
	using MotionEvent = android.view.MotionEvent;
	using b;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
	using BalloonOverlay = ru.yandex.yandexmapkit.overlay.balloon.BalloonOverlay;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class Overlay : IComparable
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  protected internal System.Collections.IList a_Conflict = new ArrayList();

	  protected internal System.Collections.IList b = new ArrayList();

	  protected internal MapController c;

	  private bool d = true;

	  private sbyte e;

	  private IRender f;

	  public Overlay(MapController paramMapController)
	  {
		this.c = paramMapController;
		this.f = new OverlayIRender();
	  }

	  private void a()
	  {
		if (this.c.OverlayManager != null)
		{
		  BalloonOverlay balloonOverlay = this.c.OverlayManager.Balloon;
		  if (balloonOverlay != null && balloonOverlay.Visible)
		  {
			BalloonItem balloonItem = balloonOverlay.BalloonItem;
			if (balloonItem != null && balloonItem.Visible && this.a_Conflict.Contains(balloonItem.OverlayItem))
			{
			  this.c.hideBalloon();
			}
		  }
		}
	  }

	  public virtual int a(Overlay paramOverlay)
	  {
		return (Priority > paramOverlay.Priority) ? -1 : ((Priority < paramOverlay.Priority) ? 1 : 0);
	  }

	  protected internal virtual OverlayItem a(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getPrepareDrawList : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_3
		//   10: aload_3
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 143
		//   19: aload_3
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/OverlayItem
		//   28: astore #4
		//   30: aload #4
		//   32: invokevirtual getBitmap : ()Landroid/graphics/Bitmap;
		//   35: ifnull -> 10
		//   38: aload #4
		//   40: invokevirtual getPoint : ()Lby;
		//   43: ifnull -> 10
		//   46: aload #4
		//   48: invokevirtual getScreenPoint : ()Lru/yandex/yandexmapkit/utils/ScreenPoint;
		//   51: astore #5
		//   53: aload #4
		//   55: invokevirtual getBitmap : ()Landroid/graphics/Bitmap;
		//   58: astore #6
		//   60: aload #4
		//   62: invokevirtual getOffsetCenterX : ()I
		//   65: ineg
		//   66: istore #7
		//   68: aload #4
		//   70: invokevirtual getOffsetX : ()I
		//   73: istore #8
		//   75: aload #4
		//   77: invokevirtual getOffsetCenterY : ()I
		//   80: ineg
		//   81: istore #9
		//   83: aload #4
		//   85: invokevirtual getOffsetY : ()I
		//   88: istore #10
		//   90: aload #5
		//   92: invokevirtual getX : ()F
		//   95: fstore #11
		//   97: iload #7
		//   99: iload #8
		//   101: isub
		//   102: i2f
		//   103: fload #11
		//   105: fadd
		//   106: f2i
		//   107: aload #5
		//   109: invokevirtual getY : ()F
		//   112: iload #9
		//   114: iload #10
		//   116: isub
		//   117: i2f
		//   118: fadd
		//   119: f2i
		//   120: aload #6
		//   122: invokevirtual getWidth : ()I
		//   125: aload #6
		//   127: invokevirtual getHeight : ()I
		//   130: fload_1
		//   131: f2i
		//   132: fload_2
		//   133: f2i
		//   134: invokestatic a : (IIIIII)Z
		//   137: ifeq -> 10
		//   140: aload #4
		//   142: areturn
		//   143: aconst_null
		//   144: astore #4
		//   146: goto -> 140
	  }

	  public virtual void addOverlayItem(OverlayItem paramOverlayItem)
	  {
		this.a_Conflict.Add(paramOverlayItem);
	  }

	  public virtual void clearOverlayItems()
	  {
		a();
		this.a_Conflict.Clear();
	  }

	  public virtual IRender IRender
	  {
		  get
		  {
			return this.f;
		  }
		  set
		  {
			this.f = value;
		  }
	  }

	  public virtual MapController MapController
	  {
		  get
		  {
			return this.c;
		  }
	  }

	  public virtual System.Collections.IList OverlayItems
	  {
		  get
		  {
			return new ArrayList(this.a_Conflict);
		  }
	  }

	  protected internal virtual System.Collections.IList PrepareDrawList
	  {
		  get
		  {
			return new ArrayList(this.b);
		  }
	  }

	  public virtual sbyte Priority
	  {
		  get
		  {
			return this.e;
		  }
		  set
		  {
			this.e = (sbyte)value;
		  }
	  }

	  public virtual bool Visible
	  {
		  get
		  {
			return this.d;
		  }
		  set
		  {
			this.d = value;
			if (!value)
			{
			  a();
			}
		  }
	  }

	  public virtual bool onDoubleTap(float paramFloat1, float paramFloat2)
	  {
		return false;
	  }

	  public virtual bool onDown(float paramFloat1, float paramFloat2)
	  {
		return false;
	  }

	  public virtual bool onLongPress(float paramFloat1, float paramFloat2)
	  {
		return (a(paramFloat1, paramFloat2) != null);
	  }

	  public virtual bool onScroll(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4)
	  {
		return false;
	  }

	  public virtual bool onSingleTapUp(float paramFloat1, float paramFloat2)
	  {
		OverlayItem overlayItem = a(paramFloat1, paramFloat2);
		if (overlayItem != null)
		{
		  if (overlayItem.BalloonItem != null)
		  {
			if (this.c.OverlayManager.Balloon.BalloonItem.Equals(overlayItem.BalloonItem) && this.c.OverlayManager.Balloon.Visible && overlayItem.BalloonItem.Visible)
			{
			  this.c.hideBalloon();
			}
			else
			{
			  this.c.showBalloon(overlayItem.BalloonItem);
			}
		  }
		  return true;
		}
		return false;
	  }

	  public virtual bool onTouchEvent(MotionEvent paramMotionEvent)
	  {
		return false;
	  }

	  public virtual bool onTrackballEvent(MotionEvent paramMotionEvent)
	  {
		return false;
	  }

	  public virtual bool onUp(float paramFloat1, float paramFloat2)
	  {
		return false;
	  }

	  public virtual System.Collections.IList prepareDraw()
	  {
		this.b.Clear();
		if (!Visible)
		{
		  return this.b;
		}
		foreach (OverlayItem overlayItem in OverlayItems)
		{
		  try
		  {
			if (overlayItem.Visible)
			{
			  ScreenPoint screenPoint = this.c.getScreenPoint(overlayItem.Point);
			  overlayItem.ScreenPoint = screenPoint;
			  int i = -overlayItem.OffsetCenterX;
			  int j = overlayItem.OffsetX;
			  int k = -overlayItem.OffsetCenterY;
			  int m = overlayItem.OffsetY;
			  float f = screenPoint.X;
			  if (b.a((int)((i - j) + f), (int)(screenPoint.Y + (k - m)), overlayItem.Bitmap.getWidth(), overlayItem.Bitmap.getHeight(), 0, 0, this.c.l().getWidth(), this.c.l().getHeight()))
			  {
				this.b.Add(overlayItem);
			  }
			}
		  }
		  catch (Exception)
		  {
		  }
		}
		return PrepareDrawList;
	  }

	  public virtual void removeOverlayItem(OverlayItem paramOverlayItem)
	  {
		if (this.c.OverlayManager != null)
		{
		  BalloonOverlay balloonOverlay = this.c.OverlayManager.Balloon;
		  if (balloonOverlay != null && balloonOverlay.Visible)
		  {
			BalloonItem balloonItem = balloonOverlay.BalloonItem;
			if (balloonItem != null && balloonItem.Visible && balloonItem.OverlayItem.Equals(paramOverlayItem))
			{
			  this.c.hideBalloon();
			}
		  }
		}
		this.a_Conflict.Remove(paramOverlayItem);
	  }



	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\Overlay.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}