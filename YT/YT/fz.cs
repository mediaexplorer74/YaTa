using DialogInterface = android.content.DialogInterface;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class fz : DialogInterface.OnClickListener
{
  public fz(AuthorizeActivity paramAuthorizeActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */