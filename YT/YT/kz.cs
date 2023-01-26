using System.Threading;

using Log = android.util.Log;
using RateActivity = ru.yandex.taxi.activity.RateActivity;

public class kz : ThreadStart
{
  public kz(RateActivity paramRateActivity)
  {
  }

  public virtual void run()
  {
	try
	{
	  Thread.Sleep(5000L);
	}
	catch (InterruptedException)
	{
	  Log.e("RateActivity", "Interrupt demo delay");
	}
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */