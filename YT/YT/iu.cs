using System.Threading;

using OnFindPointListener = ru.yandex.taxi.map.OnFindPointListener;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

internal class iu : OnFindPointListener
{
  internal iu(it paramit)
  {
  }

  public virtual void locationFound(GeoPoint paramGeoPoint, bool paramBoolean)
  {
	if (paramGeoPoint != null)
	{
	  (new Thread(new iv(this, paramGeoPoint, paramBoolean))).Start();
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\iu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */