using DialogInterface = android.content.DialogInterface;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class oo : DialogInterface.OnClickListener
{
  public oo(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(5);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\oo.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */