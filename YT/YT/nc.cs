using DialogInterface = android.content.DialogInterface;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

internal class nc : DialogInterface.OnCancelListener
{
  internal nc(nb paramnb)
  {
  }

  public virtual void onCancel(DialogInterface paramDialogInterface)
  {
	nb.a(this.a, true);
	this.a.a.mStopSearch = false;
	this.a.a.mInterrupt = false;
	SearchTaxiActivity.a(this.a.a, new ne(this.a.a));
	SearchTaxiActivity.g(this.a.a).start();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */