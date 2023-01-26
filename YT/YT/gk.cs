using DialogInterface = android.content.DialogInterface;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;

public class gk : DialogInterface.OnClickListener
{
  public gk(ConfirmActivity paramConfirmActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.setResult(-1);
	this.a.removeDialog(2);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gk.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */