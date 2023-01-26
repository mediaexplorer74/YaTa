using System;

using WheelScroller = ru.yandex.taxi.ui.wheel.WheelScroller;
using WheelView = ru.yandex.taxi.ui.wheel.WheelView;

public class ra : WheelScroller.ScrollingListener
{
  public ra(WheelView paramWheelView)
  {
  }

  public virtual void onFinished()
  {
	if (WheelView.c(this.a))
	{
	  this.a.notifyScrollingListenersAboutEnd();
	  WheelView.a(this.a, false);
	}
	WheelView.b(this.a, 0);
	this.a.invalidate();
  }

  public virtual void onJustify()
  {
	if (Math.Abs(WheelView.a(this.a)) > 1)
	{
	  WheelView.b(this.a).scroll(WheelView.a(this.a), 0);
	}
  }

  public virtual void onScroll(int paramInt)
  {
	WheelView.a(this.a, paramInt);
	paramInt = this.a.getHeight();
	if (WheelView.a(this.a) > paramInt)
	{
	  WheelView.b(this.a, paramInt);
	  WheelView.b(this.a).stopScrolling();
	  return;
	}
	if (WheelView.a(this.a) < -paramInt)
	{
	  WheelView.b(this.a, -paramInt);
	  WheelView.b(this.a).stopScrolling();
	}
  }

  public virtual void onStarted()
  {
	WheelView.a(this.a, true);
	this.a.notifyScrollingListenersAboutStart();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ra.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */