using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hq : DialogInterface.OnCancelListener
{
  public hq(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	OrderActivity.a(this.a, null);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */