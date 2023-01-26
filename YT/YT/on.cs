using Context = android.content.Context;
using DialogInterface = android.content.DialogInterface;
using Intent = android.content.Intent;
using RateActivity = ru.yandex.taxi.activity.RateActivity;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class on : DialogInterface.OnClickListener
{
  public on(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	Intent intent = new Intent((Context)this.a, typeof(RateActivity));
	intent.putExtra("taxi name", this.a.mParkiName);
	intent.putExtra("park id", this.a.mParkId);
	intent.putExtra("demo", this.a.mDemoMode);
	intent.putExtra("order id", this.a.mOrderId);
	this.a.startActivityForResult(intent, 3);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\on.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */