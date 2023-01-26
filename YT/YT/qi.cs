using System;

using Location = android.location.Location;
using LocationListener = android.location.LocationListener;
using LocationManager = android.location.LocationManager;
using Bundle = android.os.Bundle;
using MapUtils = ru.yandex.taxi.map.MapUtils;
using OnFindPointListener = ru.yandex.taxi.map.OnFindPointListener;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class qi : LocationListener
{
  public qi(OnFindPointListener paramOnFindPointListener, LocationManager paramLocationManager, long paramLong)
  {
  }

  public void onLocationChanged(Location paramLocation)
  {
	bool @bool;
	GeoPoint geoPoint = new GeoPoint();
	geoPoint.Lat = paramLocation.getLatitude();
	geoPoint.Lon = paramLocation.getLongitude();
	OnFindPointListener onFindPointListener = this.a;
	if (paramLocation.getAccuracy() < 1000.0F)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	onFindPointListener.locationFound(geoPoint, @bool);
	this.b.removeUpdates(this);
	MapUtils.a().remove(Convert.ToInt64(this.c));
  }

  public void onProviderDisabled(string paramString)
  {
  }

  public void onProviderEnabled(string paramString)
  {
  }

  public void onStatusChanged(string paramString, int paramInt, Bundle paramBundle)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */