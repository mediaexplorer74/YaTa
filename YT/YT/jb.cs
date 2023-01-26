using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class jb : DialogInterface.OnClickListener
{
  public jb(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	OrderActivity.H(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */