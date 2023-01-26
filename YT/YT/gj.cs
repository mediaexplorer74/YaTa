using DialogInterface = android.content.DialogInterface;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;

public class gj : DialogInterface.OnClickListener
{
  public gj(ConfirmActivity paramConfirmActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.setResult(2);
	this.a.removeDialog(2);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */