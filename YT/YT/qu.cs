using Activity = android.app.Activity;
using DialogInterface = android.content.DialogInterface;
using Intent = android.content.Intent;
using Uri = android.net.Uri;

public sealed class qu : DialogInterface.OnClickListener
{
  public qu(string paramString, Activity paramActivity, int paramInt)
  {
  }

  public void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	Intent intent = new Intent("android.intent.action.CALL", Uri.parse("tel:" + this.a));
	this.b.startActivity(intent);
	this.b.removeDialog(this.c);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */