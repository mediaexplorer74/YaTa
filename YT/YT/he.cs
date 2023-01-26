using DialogInterface = android.content.DialogInterface;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;

internal class he : DialogInterface.OnCancelListener
{
  internal he(ha paramha)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	EditAddressActivity.c(this.a.b, true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\he.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */