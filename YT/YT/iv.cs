using System;
using System.Threading;

using ru.yandex.taxi;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using MapUtils = ru.yandex.taxi.map.MapUtils;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

internal class iv : ThreadStart
{
  internal iv(iu paramiu, GeoPoint paramGeoPoint, bool paramBoolean)
  {
  }

  public virtual void run()
  {
	GeocodeJsonObject geocodeJsonObject = it.a(this.c.a, new Pair(this.a, Convert.ToBoolean(this.b)));
	MapUtils.saveUserLocation(this.c.a.b.getApplicationContext(), geocodeJsonObject);
	this.c.a.b.runOnUiThread(new iw(this, geocodeJsonObject));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\iv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */