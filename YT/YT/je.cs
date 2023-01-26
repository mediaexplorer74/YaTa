using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class je : DialogInterface.OnClickListener
{
  public je(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.J(this.a);
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\je.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */