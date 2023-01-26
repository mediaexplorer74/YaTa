using DialogInterface = android.content.DialogInterface;

public class oi : DialogInterface.OnClickListener
{
  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	paramDialogInterface.cancel();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\oi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */