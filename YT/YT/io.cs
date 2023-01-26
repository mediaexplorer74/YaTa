using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class io : DialogInterface.OnClickListener
{
  public io(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(8);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\io.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */