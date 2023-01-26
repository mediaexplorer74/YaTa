using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ig : DialogInterface.OnClickListener
{
  public ig(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.c(this.a, (OrderActivity.F(this.a)).orderId);
	this.a.removeDialog(12);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ig.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */