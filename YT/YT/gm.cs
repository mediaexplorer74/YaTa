using DialogInterface = android.content.DialogInterface;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;

public class gm : DialogInterface.OnClickListener
{
  public gm(ConfirmActivity paramConfirmActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */