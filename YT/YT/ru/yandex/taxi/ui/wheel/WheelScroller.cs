namespace ru.yandex.taxi.ui.wheel
{
	using Context = android.content.Context;
	using Handler = android.os.Handler;
	using GestureDetector = android.view.GestureDetector;
	using MotionEvent = android.view.MotionEvent;
	using Interpolator = android.view.animation.Interpolator;
	using Scroller = android.widget.Scroller;
	using qy;
	using qz;

	public class WheelScroller
	{
		private bool InstanceFieldsInitialized = false;

		private void InitializeInstanceFields()
		{
			h = (GestureDetector.SimpleOnGestureListener)new qy(this);
			i = (Handler)new qz(this);
		}

	  public const int MIN_DELTA_FOR_SCROLLING = 1;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private WheelScroller$ScrollingListener a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private Context b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private GestureDetector c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private Scroller d_Conflict;

	  private int e;

	  private float f;

	  private bool g;

	  private GestureDetector.SimpleOnGestureListener h;

	  private Handler i;

	  public WheelScroller(Context paramContext, WheelScroller$ScrollingListener paramWheelScroller$ScrollingListener)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
		this.c_Conflict = new GestureDetector(paramContext, (GestureDetector.OnGestureListener)this.h);
		this.c_Conflict.setIsLongpressEnabled(false);
		this.d_Conflict = new Scroller(paramContext);
		this.a_Conflict = paramWheelScroller$ScrollingListener;
		this.b_Conflict = paramContext;
	  }

	  private void a(int paramInt)
	  {
		b();
		this.i.sendEmptyMessage(paramInt);
	  }

	  private void b()
	  {
		this.i.removeMessages(0);
		this.i.removeMessages(1);
	  }

	  private void c()
	  {
		this.a_Conflict.onJustify();
		a(1);
	  }

	  private void d()
	  {
		if (!this.g)
		{
		  this.g = true;
		  this.a_Conflict.onStarted();
		}
	  }

	  public virtual void a()
	  {
		if (this.g)
		{
		  this.a_Conflict.onFinished();
		  this.g = false;
		}
	  }

	  public virtual bool onTouchEvent(MotionEvent paramMotionEvent)
	  {
		switch (paramMotionEvent.getAction())
		{
		  default:
			if (!this.c_Conflict.onTouchEvent(paramMotionEvent) && paramMotionEvent.getAction() == 1)
			{
			  c();
			}
			return true;
		  case 0:
			this.f = paramMotionEvent.getY();
			this.d_Conflict.forceFinished(true);
			b();
			  goto case 2;
		  case 2:
			break;
		}
		int i = (int)(paramMotionEvent.getY() - this.f);
		if (i != 0)
		{
		  d();
		  this.a_Conflict.onScroll(i);
		  this.f = paramMotionEvent.getY();
		}
	  }

	  public virtual void scroll(int paramInt1, int paramInt2)
	  {
		this.d_Conflict.forceFinished(true);
		this.e = 0;
		Scroller scroller = this.d_Conflict;
		if (paramInt2 == 0)
		{
		  paramInt2 = 400;
		}
		scroller.startScroll(0, 0, 0, paramInt1, paramInt2);
		a(0);
		d();
	  }

	  public virtual Interpolator Interpolator
	  {
		  set
		  {
			this.d_Conflict.forceFinished(true);
			this.d_Conflict = new Scroller(this.b_Conflict, value);
		  }
	  }

	  public virtual void stopScrolling()
	  {
		this.d_Conflict.forceFinished(true);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\WheelScroller.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}