using DialogInterface = android.content.DialogInterface;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class of : DialogInterface.OnClickListener
{
  public of(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(3);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\of.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */