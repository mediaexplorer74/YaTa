namespace ru.yandex.yandexmapkit.overlay.location
{
	using Bitmap = android.graphics.Bitmap;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class MyLocationItem : OverlayItem
	{
	  public const int GPS = 1;

	  public const int LBS = 2;

	  private int i = 0;

	  private float j = 0.0F;

	  private float k = 0.0F;

	  private int l;

	  private long m;

	  public MyLocationItem(GeoPoint paramGeoPoint, Bitmap paramBitmap) : base(paramGeoPoint, paramBitmap)
	  {
	  }

	  public virtual void a(int paramInt)
	  {
		this.i = paramInt;
	  }

	  public virtual void a(long paramLong)
	  {
		this.m = paramLong;
	  }

	  internal virtual void b(float paramFloat)
	  {
		this.j = paramFloat;
	  }

	  protected internal virtual void b(int paramInt)
	  {
		this.l = paramInt;
	  }

	  internal virtual void c(float paramFloat)
	  {
		this.k = paramFloat;
	  }

	  public virtual float Bearing
	  {
		  get
		  {
			return this.k;
		  }
	  }

	  public virtual int Rradius
	  {
		  get
		  {
			return this.i;
		  }
	  }

	  public virtual float Speed
	  {
		  get
		  {
			return this.j;
		  }
	  }

	  public virtual long Time
	  {
		  get
		  {
			return this.m;
		  }
	  }

	  public virtual int Type
	  {
		  get
		  {
			return this.l;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\location\MyLocationItem.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}