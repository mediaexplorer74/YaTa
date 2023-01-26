using DialogInterface = android.content.DialogInterface;

internal class lg : DialogInterface.OnCancelListener
{
  internal lg(lf paramlf)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	lf.a(this.a, false);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */