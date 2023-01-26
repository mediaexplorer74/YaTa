using Bitmap = android.graphics.Bitmap;
using MyLocationItem = ru.yandex.yandexmapkit.overlay.location.MyLocationItem;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class bl : MyLocationItem
{
  private bool i = false;

  private bool j = false;

  private float k = 0.0F;

  public bl(GeoPoint paramGeoPoint, Bitmap paramBitmap) : base(paramGeoPoint, paramBitmap)
  {
	b(1);
	Visible = false;
	Priority = (sbyte)126;
  }

  public virtual void a(float paramFloat)
  {
	this.k = paramFloat;
  }

  public virtual void a(bool paramBoolean)
  {
	this.i = paramBoolean;
  }

  public virtual bool a()
  {
	return this.i;
  }

  public virtual void b(bool paramBoolean)
  {
	this.j = paramBoolean;
  }

  public virtual bool b()
  {
	return this.j;
  }

  public virtual float c()
  {
	return this.k;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */