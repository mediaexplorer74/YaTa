using DialogInterface = android.content.DialogInterface;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class fv : DialogInterface.OnCancelListener
{
  public fv(AuthorizeActivity paramAuthorizeActivity)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	this.a.setResult(0);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */