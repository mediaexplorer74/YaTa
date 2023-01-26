using System;
using System.Threading;

using ru.yandex.taxi;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

internal class hc : ThreadStart
{
  internal hc(hb paramhb, GeoPoint paramGeoPoint, bool paramBoolean)
  {
  }

  public virtual void run()
  {
	GeocodeJsonObject geocodeJsonObject = ha.a(this.c.a, new Pair(this.a, Convert.ToBoolean(this.b)));
	this.c.a.b.runOnUiThread(new hd(this, geocodeJsonObject));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */