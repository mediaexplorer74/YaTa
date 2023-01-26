using DialogInterface = android.content.DialogInterface;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class op : DialogInterface.OnClickListener
{
  public op(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.finish();
	this.a.removeDialog(5);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\op.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */