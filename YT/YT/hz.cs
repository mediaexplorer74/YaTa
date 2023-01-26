using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hz : DialogInterface.OnClickListener
{
  public hz(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(17);
	OrderActivity.v(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */