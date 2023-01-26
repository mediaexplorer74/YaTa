using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hy : DialogInterface.OnClickListener
{
  public hy(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(17);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */