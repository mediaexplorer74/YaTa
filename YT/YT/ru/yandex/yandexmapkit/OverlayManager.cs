using System.Collections;
using System.Collections.Generic;

namespace ru.yandex.yandexmapkit
{
	using MotionEvent = android.view.MotionEvent;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
	using BalloonOverlay = ru.yandex.yandexmapkit.overlay.balloon.BalloonOverlay;
	using MyLocationOverlay = ru.yandex.yandexmapkit.overlay.location.MyLocationOverlay;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class OverlayManager
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly System.Collections.IList a_Conflict = new ArrayList();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly MyLocationOverlay b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly BalloonOverlay c_Conflict;

	  public OverlayManager(MapController paramMapController)
	  {
		this.c_Conflict = new BalloonOverlay(paramMapController);
		this.c_Conflict.Visible = false;
		BalloonItem balloonItem = new BalloonItem(new GeoPoint(15.64D, 17.5D), null);
		balloonItem.Text = "sdfsdfsdfsda<br>fasdfasdfasdfa";
		this.c_Conflict.BalloonItem = balloonItem;
		this.a_Conflict.Add(this.c_Conflict);
		this.b_Conflict = new MyLocationOverlay(paramMapController);
		this.a_Conflict.Add(this.b_Conflict);
	  }

	  public virtual System.Collections.IDictionary a()
	  {
		Dictionary<object, object> hashMap = new Dictionary<object, object>();
		foreach (Overlay overlay in Overlays)
		{
		  IEnumerator<OverlayItem> iterator = overlay.prepareDraw().GetEnumerator();
		  while (iterator.MoveNext())
		  {
			hashMap[iterator.Current] = overlay.IRender;
		  }
		}
		return hashMap;
	  }

	  public virtual bool a(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_3
		//   10: aload_3
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 42
		//   19: aload_3
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   28: fload_1
		//   29: fload_2
		//   30: invokevirtual onSingleTapUp : (FF)Z
		//   33: ifeq -> 10
		//   36: iconst_1
		//   37: istore #4
		//   39: iload #4
		//   41: ireturn
		//   42: iconst_0
		//   43: istore #4
		//   45: goto -> 39
	  }

	  public virtual bool a(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore #5
		//   11: aload #5
		//   13: invokeinterface hasNext : ()Z
		//   18: ifeq -> 48
		//   21: aload #5
		//   23: invokeinterface next : ()Ljava/lang/Object;
		//   28: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   31: fload_1
		//   32: fload_2
		//   33: fload_3
		//   34: fload #4
		//   36: invokevirtual onScroll : (FFFF)Z
		//   39: ifeq -> 11
		//   42: iconst_1
		//   43: istore #6
		//   45: iload #6
		//   47: ireturn
		//   48: iconst_0
		//   49: istore #6
		//   51: goto -> 45
	  }

	  public virtual bool a(MotionEvent paramMotionEvent)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_2
		//   10: aload_2
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 39
		//   19: aload_2
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   28: aload_1
		//   29: invokevirtual onTouchEvent : (Landroid/view/MotionEvent;)Z
		//   32: ifeq -> 10
		//   35: iconst_1
		//   36: istore_3
		//   37: iload_3
		//   38: ireturn
		//   39: iconst_0
		//   40: istore_3
		//   41: goto -> 37
	  }

	  public virtual void addOverlay(Overlay paramOverlay)
	  {
		this.a_Conflict.Add(paramOverlay);
		this.a_Conflict.Sort();
	  }

	  public virtual void b()
	  {
		if (MyLocation != null)
		{
		  MyLocation.e();
		}
	  }

	  public virtual bool b(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_3
		//   10: aload_3
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 42
		//   19: aload_3
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   28: fload_1
		//   29: fload_2
		//   30: invokevirtual onLongPress : (FF)Z
		//   33: ifeq -> 10
		//   36: iconst_1
		//   37: istore #4
		//   39: iload #4
		//   41: ireturn
		//   42: iconst_0
		//   43: istore #4
		//   45: goto -> 39
	  }

	  public virtual bool b(MotionEvent paramMotionEvent)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_2
		//   10: aload_2
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 39
		//   19: aload_2
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   28: aload_1
		//   29: invokevirtual onTrackballEvent : (Landroid/view/MotionEvent;)Z
		//   32: ifeq -> 10
		//   35: iconst_1
		//   36: istore_3
		//   37: iload_3
		//   38: ireturn
		//   39: iconst_0
		//   40: istore_3
		//   41: goto -> 37
	  }

	  public virtual void c()
	  {
		if (MyLocation != null)
		{
		  MyLocation.f();
		}
	  }

	  public virtual bool c(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_3
		//   10: aload_3
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 42
		//   19: aload_3
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   28: fload_1
		//   29: fload_2
		//   30: invokevirtual onDown : (FF)Z
		//   33: ifeq -> 10
		//   36: iconst_1
		//   37: istore #4
		//   39: iload #4
		//   41: ireturn
		//   42: iconst_0
		//   43: istore #4
		//   45: goto -> 39
	  }

	  public virtual bool d(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_3
		//   10: aload_3
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 42
		//   19: aload_3
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   28: fload_1
		//   29: fload_2
		//   30: invokevirtual onUp : (FF)Z
		//   33: ifeq -> 10
		//   36: iconst_1
		//   37: istore #4
		//   39: iload #4
		//   41: ireturn
		//   42: iconst_0
		//   43: istore #4
		//   45: goto -> 39
	  }

	  public virtual bool e(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokevirtual getOverlays : ()Ljava/util/List;
		//   4: invokeinterface iterator : ()Ljava/util/Iterator;
		//   9: astore_3
		//   10: aload_3
		//   11: invokeinterface hasNext : ()Z
		//   16: ifeq -> 42
		//   19: aload_3
		//   20: invokeinterface next : ()Ljava/lang/Object;
		//   25: checkcast ru/yandex/yandexmapkit/overlay/Overlay
		//   28: fload_1
		//   29: fload_2
		//   30: invokevirtual onDoubleTap : (FF)Z
		//   33: ifeq -> 10
		//   36: iconst_1
		//   37: istore #4
		//   39: iload #4
		//   41: ireturn
		//   42: iconst_0
		//   43: istore #4
		//   45: goto -> 39
	  }

	  public virtual BalloonOverlay Balloon
	  {
		  get
		  {
			return this.c_Conflict;
		  }
	  }

	  public virtual MyLocationOverlay MyLocation
	  {
		  get
		  {
			return this.b_Conflict;
		  }
	  }

	  public virtual System.Collections.IList Overlays
	  {
		  get
		  {
			return new ArrayList(this.a_Conflict);
		  }
	  }

	  public virtual void removeOverlay(Overlay paramOverlay)
	  {
		this.a_Conflict.Remove(paramOverlay);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\OverlayManager.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}