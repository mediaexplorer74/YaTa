using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ik : DialogInterface.OnClickListener
{
  public ik(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(7);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ik.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */