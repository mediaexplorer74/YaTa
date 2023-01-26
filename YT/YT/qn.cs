using System;

using Activity = android.app.Activity;
using Context = android.content.Context;
using LocationListener = android.location.LocationListener;
using LocationManager = android.location.LocationManager;
using ru.yandex.taxi;
using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
using HttpUtils = ru.yandex.taxi.client.HttpUtils;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using MapUtils = ru.yandex.taxi.map.MapUtils;
using OnFindPointListener = ru.yandex.taxi.map.OnFindPointListener;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class qn : TimerTask
{
  public qn(LocationManager paramLocationManager, LocationListener paramLocationListener, long paramLong, Activity paramActivity, OnFindPointListener paramOnFindPointListener)
  {
  }

  public void run()
  {
	this.a.removeUpdates(this.b);
	if (MapUtils.a().remove(Convert.ToInt64(this.c)) != null)
	{
	  Pair pair = (new TaxiClient((Context)this.d, (HttpUtils)new HttpUrlConnectionUtils())).doGetLbsLocation();
	  if (pair != null && ((double?)pair.second).Value < 3000.0D)
	  {
		bool @bool;
		OnFindPointListener onFindPointListener = this.e;
		GeoPoint geoPoint = (GeoPoint)pair.first;
		if (((double?)pair.second).Value < 100.0D)
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		onFindPointListener.locationFound(geoPoint, @bool);
		return;
	  }
	}
	else
	{
	  return;
	}
	MapUtils.a(this.d, this.e);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qn.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */