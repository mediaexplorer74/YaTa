using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ia : DialogInterface.OnClickListener
{
  public ia(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(16);
	if (OrderActivity.D(this.a).size() > 0)
	{
	  this.a.showDialog(16);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ia.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */