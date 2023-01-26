using System.Threading;

using Context = android.content.Context;
using Toast = android.widget.Toast;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

internal class ou : ThreadStart
{
  internal ou(ot paramot)
  {
  }

  public virtual void run()
  {
	int i;
	TaxiOnTheWayToSourceActivity taxiOnTheWayToSourceActivity = this.a.b;
	if (this.a.b.mArrived)
	{
	  i = 2131296329;
	}
	else
	{
	  i = 2131296328;
	}
	Toast.makeText((Context)taxiOnTheWayToSourceActivity, i, 0).show();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ou.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */