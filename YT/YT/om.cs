using DialogInterface = android.content.DialogInterface;
using Intent = android.content.Intent;
using Uri = android.net.Uri;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class om : DialogInterface.OnClickListener
{
  public om(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	Intent intent = new Intent("android.intent.action.CALL", Uri.parse("tel:" + TaxiOnTheWayToSourceActivity.b(this.a)));
	this.a.startActivityForResult(intent, 5);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\om.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */