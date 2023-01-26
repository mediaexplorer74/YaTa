using System;

using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using SlidingDrawer = ru.yandex.taxi.ui.slider.SlidingDrawer;

public class jh : SlidingDrawer.OnDrawerCloseListener
{
  public jh(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onDrawerClosed()
  {
	OrderActivity.a(this.a, Convert.ToBoolean(true));
	if (OrderActivity.k(this.a) != null)
	{
	  OrderActivity.k(this.a).interrupt();
	}
	if (OrderActivity.l(this.a) != null)
	{
	  OrderActivity.l(this.a).interrupt();
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */