using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class @in : DialogInterface.OnClickListener
{
  public @in(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.G(this.a);
	paramDialogInterface.dismiss();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\in.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */