using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ij : DialogInterface.OnClickListener
{
  public ij(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.a(this.a, OrderActivity.u(this.a).get(paramInt));
	this.a.removeDialog(10);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ij.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */