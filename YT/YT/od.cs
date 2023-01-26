using System.Threading;

using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class od : ThreadStart
{
  public od(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void run()
  {
	this.a.setTitle(2131296558);
	this.a.mArrived = true;
	this.a.mCurrentStatus = "waiting";
	this.a.showDialog(4);
	TaxiOnTheWayToSourceActivity.a(this.a, new ow(this.a));
	TaxiOnTheWayToSourceActivity.a(this.a).start();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\od.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */