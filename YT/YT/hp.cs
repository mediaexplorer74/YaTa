using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hp : View.OnClickListener
{
  public hp(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	if (OrderActivity.g(this.a) == null || OrderActivity.y(this.a))
	{
	  OrderActivity.z(this.a);
	  return;
	}
	this.a.showDialog(7);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */