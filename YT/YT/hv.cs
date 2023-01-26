using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hv : View.OnClickListener
{
  public hv(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	OrderActivity.s(this.a).edit().remove("need rate").commit();
	this.a.removeDialog(18);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */