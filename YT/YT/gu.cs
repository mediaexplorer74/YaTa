using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using OnFindPointListener = ru.yandex.taxi.map.OnFindPointListener;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

internal class gu : OnFindPointListener
{
  internal gu(gt paramgt)
  {
  }

  public virtual void locationFound(GeoPoint paramGeoPoint, bool paramBoolean)
  {
	EditAddressActivity.a(this.a.a, paramGeoPoint);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */