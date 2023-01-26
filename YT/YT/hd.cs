using System.Threading;

using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using MapUtils = ru.yandex.taxi.map.MapUtils;

internal class hd : ThreadStart
{
  internal hd(hc paramhc, GeocodeJsonObject paramGeocodeJsonObject)
  {
  }

  public virtual void run()
  {
	MapUtils.saveUserLocation(this.b.c.a.b.getApplicationContext(), this.a);
	ha.a(this.b.c.a, false);
	this.b.c.a.a(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */