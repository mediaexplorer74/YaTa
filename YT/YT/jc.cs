using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class jc : DialogInterface.OnClickListener
{
  public jc(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.w(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */