using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class jp : View.OnClickListener
{
  public jp(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	OrderActivity.w(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */