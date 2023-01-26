using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class il : DialogInterface.OnClickListener
{
  public il(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.z(this.a);
	this.a.removeDialog(7);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\il.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */