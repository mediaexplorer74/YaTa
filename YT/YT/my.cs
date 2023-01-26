using DialogInterface = android.content.DialogInterface;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

internal class my : DialogInterface.OnCancelListener
{
  internal my(mx parammx)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	SearchTaxiActivity.a(this.a.a.b, this.a.a.a);
	this.a.a.b.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\my.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */