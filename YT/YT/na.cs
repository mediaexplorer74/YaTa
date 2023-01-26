using DialogInterface = android.content.DialogInterface;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class na : DialogInterface.OnClickListener
{
  public na(SearchTaxiActivity paramSearchTaxiActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	SearchTaxiActivity.e(this.a);
	this.a.mInterrupt = false;
	this.a.mStopSearch = false;
	SearchTaxiActivity.a(this.a, new ne(this.a));
	SearchTaxiActivity.g(this.a).start();
	this.a.removeDialog(3);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\na.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */