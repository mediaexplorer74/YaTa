using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hs : View.OnClickListener
{
  public hs(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	OrderActivity.j(this.a);
	OrderActivity.f(this.a, true);
	OrderActivity.s(this.a).edit().remove("last order date").commit();
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hs.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */