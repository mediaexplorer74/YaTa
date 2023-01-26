using System.Threading;

using OnFindPointListener = ru.yandex.taxi.map.OnFindPointListener;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

internal class hb : OnFindPointListener
{
  internal hb(ha paramha)
  {
  }

  public virtual void locationFound(GeoPoint paramGeoPoint, bool paramBoolean)
  {
	(new Thread(new hc(this, paramGeoPoint, paramBoolean))).Start();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */