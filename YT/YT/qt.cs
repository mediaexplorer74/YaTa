using Activity = android.app.Activity;
using DialogInterface = android.content.DialogInterface;

public sealed class qt : DialogInterface.OnClickListener
{
  public qt(Activity paramActivity, int paramInt)
  {
  }

  public void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(this.b);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qt.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */