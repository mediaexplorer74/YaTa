using TabHost = android.widget.TabHost;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class jo : TabHost.OnTabChangeListener
{
  public jo(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onTabChanged(string paramString)
  {
	if ("all taxi".Equals(paramString))
	{
	  OrderActivity.q(this.a).setVisible(false);
	  OrderActivity.o(this.a).setVisible(true);
	  OrderActivity.n(this.a).setVisible(true);
	  return;
	}
	OrderActivity.o(this.a).setVisible(false);
	OrderActivity.n(this.a).setVisible(false);
	OrderActivity.q(this.a).setVisible(true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jo.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */