using System;

using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using SlidingDrawer = ru.yandex.taxi.ui.slider.SlidingDrawer;

public class jk : SlidingDrawer.OnDrawerOpenListener
{
  public jk(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onDrawerOpened()
  {
	OrderActivity.c(this.a, true);
	OrderActivity.d(this.a, true);
	OrderActivity.a(this.a, Convert.ToBoolean(false));
	OrderActivity.a(this.a, new ju(this.a));
	OrderActivity.l(this.a).start();
	OrderActivity.a(this.a, new jx(this.a));
	OrderActivity.k(this.a).start();
	if (OrderActivity.m(this.a).getCurrentTab() == 0)
	{
	  if (OrderActivity.n(this.a).getOverlayItems().size() == 0 && OrderActivity.o(this.a).getOverlayItems().size() == 0)
	  {
		OrderActivity.p(this.a).setVisibility(0);
	  }
	  OrderActivity.q(this.a).setVisible(false);
	  OrderActivity.o(this.a).setVisible(true);
	  OrderActivity.n(this.a).setVisible(true);
	  return;
	}
	if (OrderActivity.q(this.a).getOverlayItems().size() == 0)
	{
	  OrderActivity.p(this.a).setVisibility(0);
	}
	OrderActivity.o(this.a).setVisible(false);
	OrderActivity.n(this.a).setVisible(false);
	OrderActivity.q(this.a).setVisible(true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jk.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */