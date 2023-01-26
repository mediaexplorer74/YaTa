using DialogInterface = android.content.DialogInterface;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;

public class gl : DialogInterface.OnClickListener
{
  public gl(ConfirmActivity paramConfirmActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */