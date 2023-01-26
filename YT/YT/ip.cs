using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ip : DialogInterface.OnClickListener
{
  public ip(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(6);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ip.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */