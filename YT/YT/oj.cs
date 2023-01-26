using System;

using DialogInterface = android.content.DialogInterface;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class oj : DialogInterface.OnClickListener
{
  public oj(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	(new ok(this)).execute((object[])new int?[] {Convert.ToInt32(0)});
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\oj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */