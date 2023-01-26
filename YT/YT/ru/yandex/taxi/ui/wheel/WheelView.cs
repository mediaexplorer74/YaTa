using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.ui.wheel
{
	using Context = android.content.Context;
	using DataSetObserver = android.database.DataSetObserver;
	using Canvas = android.graphics.Canvas;
	using Drawable = android.graphics.drawable.Drawable;
	using GradientDrawable = android.graphics.drawable.GradientDrawable;
	using AttributeSet = android.util.AttributeSet;
	using MotionEvent = android.view.MotionEvent;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using Interpolator = android.view.animation.Interpolator;
	using LinearLayout = android.widget.LinearLayout;
	using ra;
	using rb;
	using WheelViewAdapter = ru.yandex.taxi.ui.wheel.adapters.WheelViewAdapter;

	public class WheelView : View
	{
		private bool InstanceFieldsInitialized = false;

		private void InitializeInstanceFields()
		{
			b_Conflict = (WheelScroller$ScrollingListener)new ra(this);
			p = new WheelRecycle(this);
			t = (DataSetObserver)new rb(this);
		}

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly int[] c_Conflict = new int[] {-15658735, 11184810, 11184810};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal bool a_Conflict = false;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal WheelScroller$ScrollingListener b_Conflict;

	  private int d = 0;

	  private int e = 5;

	  private int f = 0;

	  private Drawable g;

	  private GradientDrawable h;

	  private GradientDrawable i;

	  private WheelScroller j;

	  private bool k;

	  private int l;

	  private LinearLayout m;

	  private int n;

	  private WheelViewAdapter o;

	  private WheelRecycle p;

	  private IList<OnWheelChangedListener> q = new LinkedList<OnWheelChangedListener>();

	  private IList<OnWheelScrollListener> r = new LinkedList<OnWheelScrollListener>();

	  private IList<OnWheelClickedListener> s = new LinkedList<OnWheelClickedListener>();

	  private DataSetObserver t;

	  public WheelView(Context paramContext) : base(paramContext)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
		a();
	  }

	  public WheelView(Context paramContext, AttributeSet paramAttributeSet) : base(paramContext, paramAttributeSet)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
		a();
	  }

	  public WheelView(Context paramContext, AttributeSet paramAttributeSet, int paramInt) : base(paramContext, paramAttributeSet, paramInt)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
		a();
	  }

	  private int a(int paramInt1, int paramInt2)
	  {
		if (this.g == null)
		{
		  this.g = getContext().getResources().getDrawable(2130837666);
		}
		if (this.h == null)
		{
		  this.h = new GradientDrawable(GradientDrawable.Orientation.TOP_BOTTOM, c_Conflict);
		}
		if (this.i == null)
		{
		  this.i = new GradientDrawable(GradientDrawable.Orientation.BOTTOM_TOP, c_Conflict);
		}
		setBackgroundResource(2130837665);
		this.m.setLayoutParams(new ViewGroup.LayoutParams(-2, -2));
		this.m.measure(View.MeasureSpec.makeMeasureSpec(paramInt1, 0), View.MeasureSpec.makeMeasureSpec(0, 0));
		int i = this.m.getMeasuredWidth();
		if (paramInt2 == 1073741824)
		{
		  paramInt2 = paramInt1;
		  this.m.measure(View.MeasureSpec.makeMeasureSpec(paramInt2 - 20, 1073741824), View.MeasureSpec.makeMeasureSpec(0, 0));
		  return paramInt2;
		}
		i = Math.Max(i + 20, getSuggestedMinimumWidth());
		if (paramInt2 == int.MinValue)
		{
		  paramInt2 = paramInt1;
		  if (paramInt1 >= i)
		  {
			paramInt2 = i;
			this.m.measure(View.MeasureSpec.makeMeasureSpec(paramInt2 - 20, 1073741824), View.MeasureSpec.makeMeasureSpec(0, 0));
			return paramInt2;
		  }
		  this.m.measure(View.MeasureSpec.makeMeasureSpec(paramInt2 - 20, 1073741824), View.MeasureSpec.makeMeasureSpec(0, 0));
		  return paramInt2;
		}
		paramInt2 = i;
		this.m.measure(View.MeasureSpec.makeMeasureSpec(paramInt2 - 20, 1073741824), View.MeasureSpec.makeMeasureSpec(0, 0));
		return paramInt2;
	  }

	  private void a()
	  {
		this.j = new WheelScroller(getContext(), this.b_Conflict);
	  }

	  private bool a(int paramInt)
	  {
		return (this.o != null && this.o.ItemsCount > 0 && (this.a_Conflict || (paramInt >= 0 && paramInt < this.o.ItemsCount)));
	  }

	  private bool a(int paramInt, bool paramBoolean)
	  {
		View view;
		bool @bool = false;
		if (this.o == null || this.o.ItemsCount == 0)
		{
		  view = null;
		}
		else
		{
		  int i = this.o.ItemsCount;
		  int j = paramInt;
		  if (!a(paramInt))
		  {
			view = this.o.getEmptyItem(this.p.EmptyItem, (ViewGroup)this.m);
		  }
		  else
		  {
			while (j < 0)
			{
			  j += i;
			}
			view = this.o.getItem(j % i, this.p.Item, (ViewGroup)this.m);
		  }
		}
		if (view != null)
		{
		  if (paramBoolean)
		  {
			this.m.addView(view, 0);
		  }
		  else
		  {
			this.m.addView(view);
		  }
		  @bool = true;
		}
		return @bool;
	  }

	  private int b()
	  {
		if (this.f != 0)
		{
		  return this.f;
		}
		if (this.m != null && this.m.getChildAt(0) != null)
		{
		  this.f = this.m.getChildAt(0).getHeight();
		  return this.f;
		}
		return getHeight() / this.e;
	  }

	  private void b(int paramInt1, int paramInt2)
	  {
		this.m.layout(0, 0, paramInt1 - 20, paramInt2);
	  }

	  private void c()
	  {
		if (this.m == null)
		{
		  this.m = new LinearLayout(getContext());
		  this.m.setOrientation(1);
		}
	  }

	  public virtual void addChangingListener(OnWheelChangedListener paramOnWheelChangedListener)
	  {
		this.q.Add(paramOnWheelChangedListener);
	  }

	  public virtual void addClickingListener(OnWheelClickedListener paramOnWheelClickedListener)
	  {
		this.s.Add(paramOnWheelClickedListener);
	  }

	  public virtual void addScrollingListener(OnWheelScrollListener paramOnWheelScrollListener)
	  {
		this.r.Add(paramOnWheelScrollListener);
	  }

	  public virtual int CurrentItem
	  {
		  get
		  {
			return this.d;
		  }
		  set
		  {
			setCurrentItem(value, false);
		  }
	  }

	  public virtual WheelViewAdapter ViewAdapter
	  {
		  get
		  {
			return this.o;
		  }
		  set
		  {
			if (this.o != null)
			{
			  this.o.unregisterDataSetObserver(this.t);
			}
			this.o = value;
			if (this.o != null)
			{
			  this.o.registerDataSetObserver(this.t);
			}
			invalidateWheel(true);
		  }
	  }

	  public virtual int VisibleItems
	  {
		  get
		  {
			return this.e;
		  }
		  set
		  {
			this.e = value;
		  }
	  }

	  public virtual void invalidateWheel(bool paramBoolean)
	  {
		if (paramBoolean)
		{
		  this.p.clearAll();
		  if (this.m != null)
		  {
			this.m.removeAllViews();
		  }
		  this.l = 0;
		}
		else if (this.m != null)
		{
		  this.p.recycleItems(this.m, this.n, new ItemsRange());
		}
		invalidate();
	  }

	  public virtual bool Cyclic
	  {
		  get
		  {
			return this.a_Conflict;
		  }
		  set
		  {
			this.a_Conflict = value;
			invalidateWheel(false);
		  }
	  }

	  protected internal virtual void notifyChangingListeners(int paramInt1, int paramInt2)
	  {
		IEnumerator<OnWheelChangedListener> iterator = this.q.GetEnumerator();
		while (iterator.MoveNext())
		{
		  ((OnWheelChangedListener)iterator.Current).onChanged(this, paramInt1, paramInt2);
		}
	  }

	  protected internal virtual void notifyClickListenersAboutClick(int paramInt)
	  {
		IEnumerator<OnWheelClickedListener> iterator = this.s.GetEnumerator();
		while (iterator.MoveNext())
		{
		  ((OnWheelClickedListener)iterator.Current).onItemClicked(this, paramInt);
		}
	  }

	  public virtual void notifyScrollingListenersAboutEnd()
	  {
		IEnumerator<OnWheelScrollListener> iterator = this.r.GetEnumerator();
		while (iterator.MoveNext())
		{
		  ((OnWheelScrollListener)iterator.Current).onScrollingFinished(this);
		}
	  }

	  public virtual void notifyScrollingListenersAboutStart()
	  {
		IEnumerator<OnWheelScrollListener> iterator = this.r.GetEnumerator();
		while (iterator.MoveNext())
		{
		  ((OnWheelScrollListener)iterator.Current).onScrollingStarted(this);
		}
	  }

	  protected internal virtual void onDraw(Canvas paramCanvas)
	  {
		base.onDraw(paramCanvas);
		if (this.o != null && this.o.ItemsCount > 0)
		{
		  ItemsRange itemsRange;
		  if (b() == 0)
		  {
			itemsRange = null;
		  }
		  else
		  {
			int n = this.d;
			for (k = 1; b() * k < getHeight(); k += 2)
			{
			  n--;
			}
			int i1 = k;
			int i2 = n;
			if (this.l != 0)
			{
			  i2 = n;
			  if (this.l > 0)
			  {
				i2 = n - 1;
			  }
			  n = this.l / b();
			  i2 -= n;
			  i1 = (int)((k + 1) + Math.Asin(n));
			}
			itemsRange = new ItemsRange(i2, i1);
		  }
		  if (this.m != null)
		  {
			int n = this.p.recycleItems(this.m, this.n, itemsRange);
			if (this.n != n)
			{
			  k = 1;
			}
			else
			{
			  k = 0;
			}
			this.n = n;
		  }
		  else
		  {
			c();
			k = 1;
		  }
		  int j = k;
		  if (!k)
		  {
			if (this.n != itemsRange.First || this.m.getChildCount() != itemsRange.Count)
			{
			  j = 1;
			}
			else
			{
			  j = 0;
			}
		  }
		  if (this.n > itemsRange.First && this.n <= itemsRange.Last)
		  {
			for (k = this.n - 1; k >= itemsRange.First && a(k, true); k--)
			{
			  this.n = k;
			}
		  }
		  else
		  {
			this.n = itemsRange.First;
		  }
		  int k = this.n;
		  int m = this.m.getChildCount();
		  while (m < itemsRange.Count)
		  {
			int n = k;
			if (!a(this.n + m, false))
			{
			  n = k;
			  if (this.m.getChildCount() == 0)
			  {
				n = k + 1;
			  }
			}
			m++;
			k = n;
		  }
		  this.n = k;
		  if (j != 0)
		  {
			a(getWidth(), 1073741824);
			b(getWidth(), getHeight());
		  }
		  paramCanvas.save();
		  paramCanvas.translate(10.0F, (-((this.d - this.n) * b() + (b() - getHeight()) / 2) + this.l));
		  this.m.draw(paramCanvas);
		  paramCanvas.restore();
		  j = getHeight() / 2;
		  k = (int)((b() / 2) * 1.2D);
		  this.g.setBounds(0, j - k, getWidth(), j + k);
		  this.g.draw(paramCanvas);
		}
		int i = (int)(1.5D * b());
		this.h.setBounds(0, 0, getWidth(), i);
		this.h.draw(paramCanvas);
		this.i.setBounds(0, getHeight() - i, getWidth(), getHeight());
		this.i.draw(paramCanvas);
	  }

	  protected internal virtual void onLayout(bool paramBoolean, int paramInt1, int paramInt2, int paramInt3, int paramInt4)
	  {
		b(paramInt3 - paramInt1, paramInt4 - paramInt2);
	  }

	  protected internal virtual void onMeasure(int paramInt1, int paramInt2)
	  {
		int i = View.MeasureSpec.getMode(paramInt1);
		int j = View.MeasureSpec.getMode(paramInt2);
		int k = View.MeasureSpec.getSize(paramInt1);
		paramInt2 = View.MeasureSpec.getSize(paramInt2);
		if (this.m != null)
		{
		  this.p.recycleItems(this.m, this.n, new ItemsRange());
		}
		else
		{
		  c();
		}
		int m = this.e / 2;
		for (paramInt1 = this.d + m; paramInt1 >= this.d - m; paramInt1--)
		{
		  if (a(paramInt1, true))
		  {
			this.n = paramInt1;
		  }
		}
		k = a(k, i);
		if (j == 1073741824)
		{
		  paramInt1 = paramInt2;
		}
		else
		{
		  LinearLayout linearLayout = this.m;
		  if (linearLayout != null && linearLayout.getChildAt(0) != null)
		  {
			this.f = linearLayout.getChildAt(0).getMeasuredHeight();
		  }
		  i = Math.Max(this.f * this.e - this.f * 10 / 50, getSuggestedMinimumHeight());
		  paramInt1 = i;
		  if (j == int.MinValue)
		  {
			paramInt1 = Math.Min(i, paramInt2);
		  }
		}
		setMeasuredDimension(k, paramInt1);
	  }

	  public virtual bool onTouchEvent(MotionEvent paramMotionEvent)
	  {
		bool @bool = true;
		null = @bool;
		if (isEnabled())
		{
		  if (ViewAdapter == null)
		  {
			return @bool;
		  }
		}
		else
		{
		  return null;
		}
		switch (paramMotionEvent.getAction())
		{
		  default:
			return this.j.onTouchEvent(paramMotionEvent);
		  case 2:
			if (getParent() != null)
			{
			  getParent().requestDisallowInterceptTouchEvent(true);
			}
			  goto case 1;
		  case 1:
			break;
		}
		if (!this.k)
		{
		  int i = (int)paramMotionEvent.getY() - getHeight() / 2;
		  if (i > 0)
		  {
			i += b() / 2;
		  }
		  else
		  {
			i -= b() / 2;
		  }
		  i /= b();
		  if (i != 0 && a(this.d + i))
		  {
			notifyClickListenersAboutClick(i + this.d);
		  }
		}
	  }

	  public virtual void removeChangingListener(OnWheelChangedListener paramOnWheelChangedListener)
	  {
		this.q.Remove(paramOnWheelChangedListener);
	  }

	  public virtual void removeClickingListener(OnWheelClickedListener paramOnWheelClickedListener)
	  {
		this.s.Remove(paramOnWheelClickedListener);
	  }

	  public virtual void removeScrollingListener(OnWheelScrollListener paramOnWheelScrollListener)
	  {
		this.r.Remove(paramOnWheelScrollListener);
	  }

	  public virtual void scroll(int paramInt1, int paramInt2)
	  {
		int i = b();
		int j = this.l;
		this.j.scroll(i * paramInt1 - j, paramInt2);
	  }


	  public virtual void setCurrentItem(int paramInt, bool paramBoolean)
	  {
		// Byte code:
		//   0: aload_0
		//   1: getfield o : Lru/yandex/taxi/ui/wheel/adapters/WheelViewAdapter;
		//   4: ifnull -> 19
		//   7: aload_0
		//   8: getfield o : Lru/yandex/taxi/ui/wheel/adapters/WheelViewAdapter;
		//   11: invokeinterface getItemsCount : ()I
		//   16: ifne -> 20
		//   19: return
		//   20: aload_0
		//   21: getfield o : Lru/yandex/taxi/ui/wheel/adapters/WheelViewAdapter;
		//   24: invokeinterface getItemsCount : ()I
		//   29: istore_3
		//   30: iload_1
		//   31: iflt -> 42
		//   34: iload_1
		//   35: istore #4
		//   37: iload_1
		//   38: iload_3
		//   39: if_icmplt -> 65
		//   42: aload_0
		//   43: getfield a : Z
		//   46: ifeq -> 19
		//   49: iload_1
		//   50: ifge -> 60
		//   53: iload_1
		//   54: iload_3
		//   55: iadd
		//   56: istore_1
		//   57: goto -> 49
		//   60: iload_1
		//   61: iload_3
		//   62: irem
		//   63: istore #4
		//   65: iload #4
		//   67: aload_0
		//   68: getfield d : I
		//   71: if_icmpeq -> 19
		//   74: iload_2
		//   75: ifeq -> 148
		//   78: iload #4
		//   80: aload_0
		//   81: getfield d : I
		//   84: isub
		//   85: istore_1
		//   86: aload_0
		//   87: getfield a : Z
		//   90: ifeq -> 180
		//   93: iload_3
		//   94: iload #4
		//   96: aload_0
		//   97: getfield d : I
		//   100: invokestatic min : (II)I
		//   103: iadd
		//   104: iload #4
		//   106: aload_0
		//   107: getfield d : I
		//   110: invokestatic max : (II)I
		//   113: isub
		//   114: istore #4
		//   116: iload #4
		//   118: iload_1
		//   119: invokestatic abs : (I)I
		//   122: if_icmpge -> 180
		//   125: iload_1
		//   126: ifge -> 141
		//   129: iload #4
		//   131: istore_1
		//   132: aload_0
		//   133: iload_1
		//   134: iconst_0
		//   135: invokevirtual scroll : (II)V
		//   138: goto -> 19
		//   141: iload #4
		//   143: ineg
		//   144: istore_1
		//   145: goto -> 132
		//   148: aload_0
		//   149: iconst_0
		//   150: putfield l : I
		//   153: aload_0
		//   154: getfield d : I
		//   157: istore_1
		//   158: aload_0
		//   159: iload #4
		//   161: putfield d : I
		//   164: aload_0
		//   165: iload_1
		//   166: aload_0
		//   167: getfield d : I
		//   170: invokevirtual notifyChangingListeners : (II)V
		//   173: aload_0
		//   174: invokevirtual invalidate : ()V
		//   177: goto -> 19
		//   180: goto -> 132
	  }


	  public virtual Interpolator Interpolator
	  {
		  set
		  {
			this.j.Interpolator = value;
		  }
	  }



	  public virtual void stopScrolling()
	  {
		this.j.stopScrolling();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\WheelView.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}