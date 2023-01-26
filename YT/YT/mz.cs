using DialogInterface = android.content.DialogInterface;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class mz : DialogInterface.OnClickListener
{
  public mz(SearchTaxiActivity paramSearchTaxiActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(2);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */