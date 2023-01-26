using System;

namespace ru.yandex.taxi.ui.slider
{
	using Context = android.content.Context;
	using TypedArray = android.content.res.TypedArray;
	using Bitmap = android.graphics.Bitmap;
	using Canvas = android.graphics.Canvas;
	using Rect = android.graphics.Rect;
	using Handler = android.os.Handler;
	using SystemClock = android.os.SystemClock;
	using AttributeSet = android.util.AttributeSet;
	using GestureDetector = android.view.GestureDetector;
	using MotionEvent = android.view.MotionEvent;
	using VelocityTracker = android.view.VelocityTracker;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using qv;
	using qw;
	using qx;
	using R = ru.yandex.taxi.R;

	public class SlidingDrawer : ViewGroup
	{
		private bool InstanceFieldsInitialized = false;

		private void InitializeInstanceFields()
		{
			t = (Handler)new qx(this);
		}

	  private bool A;

	  private bool B;

	  private bool C;

	  private readonly int D;

	  private readonly int E;

	  private readonly int F;

	  private readonly int G;

	  private readonly int H;

	  private readonly int I;

	  private readonly int J;

	  private float K;

	  private GestureDetector L;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly int a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly int b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly int c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly int d_Conflict;

	  private int e;

	  private View f;

	  private View g;

	  private View h;

	  private readonly Rect i = new Rect();

	  private readonly Rect j = new Rect();

	  private readonly Rect k = new Rect();

	  private bool l;

	  private bool m;

	  private VelocityTracker n;

	  private bool o;

	  private int p;

	  private SlidingDrawer$OnDrawerOpenListener q;

	  private SlidingDrawer$OnDrawerCloseListener r;

	  private SlidingDrawer$OnDrawerScrollListener s;

	  private Handler t;

	  private float u;

	  private float v;

	  private float w;

	  private long x;

	  private long y;

	  private int z;

	  public SlidingDrawer(Context paramContext, AttributeSet paramAttributeSet) : this(paramContext, paramAttributeSet, 0)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
	  }

	  public SlidingDrawer(Context paramContext, AttributeSet paramAttributeSet, int paramInt) : base(paramContext, paramAttributeSet, paramInt)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
		TypedArray typedArray = paramContext.obtainStyledAttributes(paramAttributeSet, R.styleable.SlidingDrawer, paramInt, 0);
		this.B = typedArray.getBoolean(5, true);
		this.C = typedArray.getBoolean(6, true);
		int i = typedArray.getResourceId(0, 0);
		if (i == 0)
		{
		  throw new System.ArgumentException("The handle attribute is required and must refer to a valid child.");
		}
		int j = typedArray.getResourceId(1, 0);
		if (j == 0)
		{
		  throw new System.ArgumentException("The top_content attribute is required and must refer to a valid child.");
		}
		paramInt = typedArray.getResourceId(2, 0);
		if (paramInt == 0)
		{
		  throw new System.ArgumentException("The bottom_content attribute is required and must refer to a valid child.");
		}
		if (i == j)
		{
		  throw new System.ArgumentException("The content and handle attributes must refer to different children.");
		}
		this.a_Conflict = i;
		this.b_Conflict = j;
		this.c_Conflict = paramInt;
		float f = (getResources().getDisplayMetrics()).density;
		this.D = (int)(6.0F * f + 0.5F);
		this.E = (int)(100.0F * f + 0.5F);
		this.F = (int)(150.0F * f + 0.5F);
		this.G = (int)(200.0F * f + 0.5F);
		this.H = (int)(2000.0F * f + 0.5F);
		this.I = (int)(2500.0F * f + 0.5F);
		this.J = (int)(1000.0F * f + 0.5F);
		this.d_Conflict = (int)(f * 10.0F);
		typedArray.recycle();
		setAlwaysDrawnWithCacheEnabled(false);
		this.L = new GestureDetector((GestureDetector.OnGestureListener)new qv(this));
	  }

	  private void a()
	  {
		if (!this.A)
		{
		  View view = this.g;
		  if (view.isLayoutRequested())
		  {
			int i = this.p;
			int j = getBottom();
			int k = getTop();
			view.measure(View.MeasureSpec.makeMeasureSpec(getRight() - getLeft(), 1073741824), View.MeasureSpec.makeMeasureSpec(j - k - i, 1073741824) + this.e);
			view.layout(0, 0, view.getMeasuredWidth(), view.getMeasuredHeight());
		  }
		  view.getViewTreeObserver().dispatchOnPreDraw();
		  view.buildDrawingCache();
		  view.setVisibility(8);
		  view = this.h;
		  if (view.isLayoutRequested())
		  {
			int i = this.p;
			int j = getBottom();
			int k = getTop();
			view.measure(View.MeasureSpec.makeMeasureSpec(getRight() - getLeft(), 1073741824), View.MeasureSpec.makeMeasureSpec(j - k - i, 1073741824));
			view.layout(0, i - this.d_Conflict, view.getMeasuredWidth(), getBottom());
		  }
		  view.getViewTreeObserver().dispatchOnPreDraw();
		  view.buildDrawingCache();
		  view.setVisibility(0);
		}
	  }

	  private void a(int paramInt)
	  {
		c(paramInt);
		a(paramInt, -this.I, true);
	  }

	  private void a(int paramInt, float paramFloat, bool paramBoolean)
	  {
		this.w = paramInt;
		this.v = paramFloat;
		if (this.o)
		{
		  if (paramBoolean || paramFloat > this.G || (paramInt > this.p && paramFloat > -this.G))
		  {
			this.u = this.H;
			if (paramFloat > 0.0F)
			{
			  this.v = 0.0F;
			}
		  }
		  else
		  {
			this.u = -this.H;
			if (paramFloat < 0.0F)
			{
			  this.v = 0.0F;
			}
		  }
		}
		else if (!paramBoolean && (paramFloat > this.G || (paramInt > getHeight() / 2 && paramFloat > -this.G)))
		{
		  this.u = this.H;
		  if (paramFloat > 0.0F)
		  {
			this.v = 0.0F;
		  }
		}
		else
		{
		  this.u = -this.H;
		  if (paramFloat < 0.0F)
		  {
			this.v = 0.0F;
		  }
		}
		long l = SystemClock.uptimeMillis();
		this.x = l;
		this.y = l + 16L;
		this.A = true;
		this.t.removeMessages(1000);
		this.t.sendMessageAtTime(this.t.obtainMessage(1000), this.y);
		this.f.setPressed(false);
		this.l = false;
		if (this.s != null)
		{
		  this.s.onScrollEnded();
		}
		if (this.n != null)
		{
		  this.n.recycle();
		  this.n = null;
		}
	  }

	  private void b()
	  {
		d(-10001);
		this.g.setVisibility(8);
		this.g.destroyDrawingCache();
		this.h.setVisibility(0);
		this.h.destroyDrawingCache();
		if (this.o)
		{
		  this.o = false;
		  if (this.r != null)
		  {
			this.r.onDrawerClosed();
		  }
		}
	  }

	  private void b(int paramInt)
	  {
		c(paramInt);
		a(paramInt, this.I, true);
	  }

	  private void c()
	  {
		d(-10002);
		this.g.setVisibility(0);
		if (!this.o)
		{
		  this.o = true;
		  if (this.q != null)
		  {
			this.q.onDrawerOpened();
		  }
		}
	  }

	  private void c(int paramInt)
	  {
		bool @bool;
		this.l = true;
		this.n = VelocityTracker.obtain();
		if (!this.o)
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		if (@bool)
		{
		  this.u = this.H;
		  this.v = this.G;
		  this.w = 0.0F;
		  d((int)this.w);
		  this.A = true;
		  this.t.removeMessages(1000);
		  long l = SystemClock.uptimeMillis();
		  this.x = l;
		  this.y = l + 16L;
		  this.A = true;
		  return;
		}
		if (this.A)
		{
		  this.A = false;
		  this.t.removeMessages(1000);
		}
		d(paramInt);
	  }

	  private void d(int paramInt)
	  {
		View view = this.f;
		if (paramInt == -10002)
		{
		  view.offsetTopAndBottom(getBottom() - getTop() - this.p - view.getTop());
		  invalidate();
		  return;
		}
		if (paramInt == -10001)
		{
		  view.offsetTopAndBottom(0 - view.getTop());
		  invalidate();
		  return;
		}
		int i = view.getTop();
		int j = paramInt - i;
		if (paramInt < 0)
		{
		  paramInt = 0 - i;
		}
		else
		{
		  paramInt = j;
		  if (j > getBottom() - getTop() - this.p - i)
		  {
			paramInt = getBottom() - getTop() - this.p - i;
		  }
		}
		view.offsetTopAndBottom(paramInt);
		Rect rect1 = this.i;
		Rect rect2 = this.k;
		view.getHitRect(rect1);
		rect2.set(rect1);
		rect2.union(rect1.left, rect1.top - paramInt, rect1.right, rect1.bottom - paramInt);
		rect2.union(0, rect1.top - paramInt - this.g.getHeight(), getWidth(), rect1.bottom - paramInt);
		invalidate(rect2);
	  }

	  public virtual void animateClose()
	  {
		a();
		SlidingDrawer$OnDrawerScrollListener slidingDrawer$OnDrawerScrollListener = this.s;
		if (slidingDrawer$OnDrawerScrollListener != null)
		{
		  slidingDrawer$OnDrawerScrollListener.onScrollStarted();
		}
		a(this.f.getTop());
		sendAccessibilityEvent(32);
		if (slidingDrawer$OnDrawerScrollListener != null)
		{
		  slidingDrawer$OnDrawerScrollListener.onScrollEnded();
		}
	  }

	  public virtual void animateOpen()
	  {
		a();
		SlidingDrawer$OnDrawerScrollListener slidingDrawer$OnDrawerScrollListener = this.s;
		if (slidingDrawer$OnDrawerScrollListener != null)
		{
		  slidingDrawer$OnDrawerScrollListener.onScrollStarted();
		}
		b(this.f.getTop());
		sendAccessibilityEvent(32);
		if (slidingDrawer$OnDrawerScrollListener != null)
		{
		  slidingDrawer$OnDrawerScrollListener.onScrollEnded();
		}
	  }

	  public virtual void animateToggle()
	  {
		if (!this.o)
		{
		  animateOpen();
		  return;
		}
		animateClose();
	  }

	  public virtual void close()
	  {
		b();
		invalidate();
		requestLayout();
	  }

	  protected internal virtual void dispatchDraw(Canvas paramCanvas)
	  {
		long l = getDrawingTime();
		View view = this.f;
		if (this.l || this.A)
		{
		  Bitmap bitmap1 = this.g.getDrawingCache();
		  Bitmap bitmap2 = this.h.getDrawingCache();
		  if (bitmap1 != null && bitmap2 != null)
		  {
			paramCanvas.save();
			paramCanvas.clipRect(getLeft(), view.getBottom() - this.d_Conflict, getRight(), getBottom());
			paramCanvas.drawBitmap(bitmap2, 0.0F, (view.getHeight() - this.d_Conflict), null);
			paramCanvas.restore();
			paramCanvas.drawBitmap(bitmap1, 0.0F, (view.getTop() - bitmap1.getHeight() + this.e), null);
		  }
		  else
		  {
			paramCanvas.save();
			paramCanvas.clipRect(getLeft(), view.getBottom() - this.d_Conflict, getRight(), getBottom());
			drawChild(paramCanvas, this.h, l);
			paramCanvas.restore();
			paramCanvas.save();
			paramCanvas.translate(0.0F, (view.getTop() - this.g.getHeight() + this.e));
			drawChild(paramCanvas, this.g, l);
			paramCanvas.restore();
		  }
		}
		else if (this.o)
		{
		  drawChild(paramCanvas, this.h, l);
		  paramCanvas.save();
		  paramCanvas.translate(0.0F, (view.getTop() - this.g.getHeight() + this.e));
		  drawChild(paramCanvas, this.g, l);
		  paramCanvas.restore();
		}
		else
		{
		  paramCanvas.save();
		  paramCanvas.translate(0.0F, (view.getTop() - this.g.getHeight() + this.e));
		  drawChild(paramCanvas, this.g, l);
		  paramCanvas.restore();
		  drawChild(paramCanvas, this.h, l);
		}
		drawChild(paramCanvas, view, l);
	  }

	  public virtual View BottomContent
	  {
		  get
		  {
			return this.g;
		  }
	  }

	  public virtual View Handle
	  {
		  get
		  {
			return this.f;
		  }
	  }

	  public virtual View TopContent
	  {
		  get
		  {
			return this.g;
		  }
	  }

	  public virtual bool Moving
	  {
		  get
		  {
			return (this.l || this.A);
		  }
	  }

	  public virtual bool Opened
	  {
		  get
		  {
			return this.o;
		  }
	  }

	  public virtual void @lock()
	  {
		this.m = true;
	  }

	  protected internal virtual void onFinishInflate()
	  {
		this.f = findViewById(this.a_Conflict);
		if (this.f == null)
		{
		  throw new System.ArgumentException("The handle attribute is must refer to an existing child.");
		}
		this.f.setOnClickListener((View.OnClickListener)new qw(this));
		this.g = findViewById(this.b_Conflict);
		if (this.g == null)
		{
		  throw new System.ArgumentException("The top_content attribute is must refer to an existing child.");
		}
		this.g.setVisibility(8);
		this.h = findViewById(this.c_Conflict);
		if (this.h == null)
		{
		  throw new System.ArgumentException("The bottom_content attribute is must refer to an existing child.");
		}
		this.h.setVisibility(0);
	  }

	  public virtual bool onInterceptTouchEvent(MotionEvent paramMotionEvent)
	  {
		bool @bool = false;
		this.L.onTouchEvent(paramMotionEvent);
		float f1 = paramMotionEvent.getX();
		float f2 = paramMotionEvent.getY();
		Math.Abs((int)f2 - (int)this.K);
		int i = this.D;
		float f3 = this.K;
		this.K = f2;
		if (!this.m)
		{
		  i = paramMotionEvent.getAction();
		  Rect rect1 = this.i;
		  View view = this.f;
		  view.getHitRect(rect1);
		  Rect rect2 = this.j;
		  this.h.getHitRect(rect2);
		  this.h.isShown();
		  rect2.contains((int)f1, (int)f2);
		  if (this.l || rect1.contains((int)f1, (int)f2))
		  {
			if (i == 0)
			{
			  this.l = true;
			  view.setPressed(true);
			  a();
			  if (this.s != null)
			  {
				this.s.onScrollStarted();
			  }
			  i = this.f.getTop();
			  this.z = (int)f2 - i;
			  c(i);
			  this.n.addMovement(paramMotionEvent);
			}
			@bool = true;
		  }
		}
		return @bool;
	  }

	  protected internal virtual void onLayout(bool paramBoolean, int paramInt1, int paramInt2, int paramInt3, int paramInt4)
	  {
		if (!this.l)
		{
		  View view1 = this.f;
		  int i = view1.getMeasuredWidth();
		  int j = view1.getMeasuredHeight();
		  View view2 = this.g;
		  View view3 = this.h;
		  paramInt3 = (paramInt3 - paramInt1 - i) / 2;
		  if (this.o)
		  {
			paramInt1 = paramInt4 - paramInt2 - j;
		  }
		  else
		  {
			paramInt1 = 0;
		  }
		  view2.layout(0, paramInt1 - view2.getMeasuredHeight() + this.e, view2.getMeasuredWidth(), paramInt1);
		  view3.layout(0, j - this.d_Conflict, view3.getMeasuredWidth(), getBottom());
		  view1.layout(paramInt3, paramInt1, paramInt3 + i, paramInt1 + j);
		  this.p = view1.getHeight();
		}
	  }

	  protected internal virtual void onMeasure(int paramInt1, int paramInt2)
	  {
		int i = View.MeasureSpec.getMode(paramInt1);
		int j = View.MeasureSpec.getSize(paramInt1);
		int k = View.MeasureSpec.getMode(paramInt2);
		int m = View.MeasureSpec.getSize(paramInt2);
		if (i == 0 || k == 0)
		{
		  throw new Exception("SlidingDrawer cannot have UNSPECIFIED dimensions");
		}
		View view = this.f;
		measureChild(view, paramInt1, paramInt2);
		paramInt1 = m - view.getMeasuredHeight();
		this.g.measure(View.MeasureSpec.makeMeasureSpec(j, 1073741824), View.MeasureSpec.makeMeasureSpec(paramInt1, 1073741824) + this.e);
		this.h.measure(View.MeasureSpec.makeMeasureSpec(j, 1073741824), View.MeasureSpec.makeMeasureSpec(paramInt1, 1073741824) + this.d_Conflict);
		setMeasuredDimension(j, m);
	  }

	  public virtual bool onTouchEvent(MotionEvent paramMotionEvent)
	  {
		if (this.m)
		{
		  return true;
		}
		if (this.l)
		{
		  VelocityTracker velocityTracker;
		  float f1;
		  float f2;
		  int i;
		  float f3;
		  this.n.addMovement(paramMotionEvent);
		  switch (paramMotionEvent.getAction())
		  {
			default:
			  if (this.l || this.A || base.onTouchEvent(paramMotionEvent))
			  {
				return true;
			  }
			  break;
			case 2:
			  d((int)paramMotionEvent.getY() - this.z);
				goto case 1;
			case 1:
			case 3:
			  velocityTracker = this.n;
			  velocityTracker.computeCurrentVelocity(this.J);
			  f1 = velocityTracker.getYVelocity();
			  f2 = velocityTracker.getXVelocity();
			  if (f1 < 0.0F)
			  {
				i = 1;
			  }
			  else
			  {
				i = 0;
			  }
			  f3 = f2;
			  if (f2 < 0.0F)
			  {
				f3 = -f2;
			  }
			  f2 = f3;
			  if (f3 > this.F)
			  {
				f2 = this.F;
			  }
			  f2 = (float)Math.hypot(f2, f1);
			  f3 = f2;
			  if (i)
			  {
				f3 = -f2;
			  }
			  i = this.f.getTop();
			  if (Math.Abs(f3) < this.E)
			  {
				if ((this.o && i > getBottom() - getTop() - this.p - this.D) || (!this.o && i < this.D))
				{
				  if (this.B)
				  {
					playSoundEffect(0);
					if (this.o)
					{
					  a(i);
					}
					else
					{
					  b(i);
					}
				  }
				  else
				  {
					a(i, f3, false);
				  }
				}
				else
				{
				  a(i, f3, false);
				}
			  }
			  else
			  {
				a(i, f3, false);
			  }
		  break;
		  }
		  return false;
		}
	  }

	  public virtual void open()
	  {
		c();
		invalidate();
		requestLayout();
		sendAccessibilityEvent(32);
	  }

	  public virtual SlidingDrawer$OnDrawerCloseListener OnDrawerCloseListener
	  {
		  set
		  {
			this.r = value;
		  }
	  }

	  public virtual SlidingDrawer$OnDrawerOpenListener OnDrawerOpenListener
	  {
		  set
		  {
			this.q = value;
		  }
	  }

	  public virtual SlidingDrawer$OnDrawerScrollListener OnDrawerScrollListener
	  {
		  set
		  {
			this.s = value;
		  }
	  }

	  public virtual void toggle()
	  {
		if (!this.o)
		{
		  c();
		}
		else
		{
		  b();
		}
		invalidate();
		requestLayout();
	  }

	  public virtual void unlock()
	  {
		this.m = false;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\slider\SlidingDrawer.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}