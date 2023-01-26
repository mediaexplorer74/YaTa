using DialogInterface = android.content.DialogInterface;
using InfoActivity = ru.yandex.taxi.activity.InfoActivity;

public class hl : DialogInterface.OnClickListener
{
  public hl(InfoActivity paramInfoActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */