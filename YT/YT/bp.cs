using Bitmap = android.graphics.Bitmap;
using MyLocationItem = ru.yandex.yandexmapkit.overlay.location.MyLocationItem;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class bp : MyLocationItem
{
  public bp(GeoPoint paramGeoPoint, Bitmap paramBitmap) : base(paramGeoPoint, paramBitmap)
  {
	b(2);
	Priority = (sbyte)126;
	Visible = false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */