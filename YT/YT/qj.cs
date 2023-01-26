using System.Threading;

using LocationListener = android.location.LocationListener;
using LocationManager = android.location.LocationManager;
using Log = android.util.Log;

public sealed class qj : ThreadStart
{
  public qj(LocationManager paramLocationManager, LocationListener paramLocationListener)
  {
  }

  public void run()
  {
	bool @bool;
	try
	{
	  @bool = this.a.isProviderEnabled("network");
	}
	catch (System.ArgumentException illegalArgumentException)
	{
	  Log.w("MapUtils", "No network provider found", illegalArgumentException);
	  @bool = false;
	}
	if (@bool)
	{
	  this.a.requestLocationUpdates("network", 0L, 0.0F, this.b);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */