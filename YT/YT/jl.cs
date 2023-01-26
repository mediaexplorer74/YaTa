using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;

public class jl : View.OnClickListener
{
  public jl(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	OrderActivity.s(this.a).edit().putString("last order date", TaxiClient.DATE_FORMAT.format(OrderActivity.r(this.a))).commit();
	if (!OrderActivity.t(this.a) || OrderActivity.s(this.a).getBoolean("authorized", false))
	{
	  (new jm(this)).execute((object[])new int?[0]);
	  return;
	}
	OrderActivity.v(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */