using DialogInterface = android.content.DialogInterface;
using TaxiListActivity = ru.yandex.taxi.activity.TaxiListActivity;

public class nw : DialogInterface.OnClickListener
{
  public nw(TaxiListActivity paramTaxiListActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(2);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */