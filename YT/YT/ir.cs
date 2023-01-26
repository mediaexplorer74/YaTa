using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ir : View.OnClickListener
{
  public ir(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	OrderActivity.H(this.a);
	this.a.removeDialog(5);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ir.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */