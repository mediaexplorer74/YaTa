using DialogInterface = android.content.DialogInterface;

internal class mf : DialogInterface.OnCancelListener
{
  internal mf(md parammd)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	md.a(this.a, true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */