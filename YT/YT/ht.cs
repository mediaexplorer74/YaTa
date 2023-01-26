using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ht : View.OnClickListener
{
  public ht(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ht.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */