using Bitmap = android.graphics.Bitmap;
using MyLocationItem = ru.yandex.yandexmapkit.overlay.location.MyLocationItem;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class bo : MyLocationItem
{
  private float i = 0.0F;

  public bo() : this(new GeoPoint(0.0D, 0.0D), (Bitmap)null)
  {
  }

  public bo(GeoPoint paramGeoPoint, Bitmap paramBitmap) : base(paramGeoPoint, paramBitmap)
  {
	b(3);
	Visible = false;
	Priority = -128;
  }

  public virtual float a()
  {
	return this.i;
  }

  public virtual void a(float paramFloat)
  {
	this.i = paramFloat;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bo.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */