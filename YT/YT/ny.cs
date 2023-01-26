using DialogInterface = android.content.DialogInterface;

internal class ny : DialogInterface.OnCancelListener
{
  internal ny(nx paramnx)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	nx.a(this.a, true);
	this.a.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ny.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */