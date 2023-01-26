using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class iq : DialogInterface.OnClickListener
{
  public iq(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.H(this.a);
	this.a.removeDialog(6);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\iq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */