using System;

using Activity = android.app.Activity;
using Context = android.content.Context;
using LocationListener = android.location.LocationListener;
using LocationManager = android.location.LocationManager;
using MapUtils = ru.yandex.taxi.map.MapUtils;
using OnFindPointListener = ru.yandex.taxi.map.OnFindPointListener;

public sealed class qk : TimerTask
{
  public qk(LocationManager paramLocationManager, LocationListener paramLocationListener, long paramLong, OnFindPointListener paramOnFindPointListener, Activity paramActivity)
  {
  }

  public void run()
  {
	this.a.removeUpdates(this.b);
	MapUtils.a().remove(Convert.ToInt64(this.c));
	if (MapUtils.a().remove(Convert.ToInt64(this.c)) != null)
	{
	  this.d.locationFound(MapUtils.getLastKnownMyLocationPoint((Context)this.e), false);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qk.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */