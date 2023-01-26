using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ja : DialogInterface.OnClickListener
{
  public ja(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	if (OrderActivity.g(this.a) == null)
	{
	  OrderActivity.w(this.a);
	  return;
	}
	OrderActivity.I(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ja.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */