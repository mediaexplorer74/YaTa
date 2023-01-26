namespace ru.yandex.yandexmapkit.overlay.drag
{
	using Bitmap = android.graphics.Bitmap;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class DragAndDropItem : OverlayItem
	{
	  private int i = 0;

	  private bool j = false;

	  private int k = 0;

	  public DragAndDropItem(GeoPoint paramGeoPoint, Bitmap paramBitmap) : base(paramGeoPoint, paramBitmap)
	  {
	  }

	  public virtual int a()
	  {
		return this.i;
	  }

	  public virtual void a(int paramInt)
	  {
		this.i = paramInt;
	  }

	  public virtual int b()
	  {
		return this.k;
	  }

	  public virtual void b(int paramInt)
	  {
		this.k = paramInt;
	  }

	  public virtual bool Dragable
	  {
		  get
		  {
			return this.j;
		  }
		  set
		  {
			this.j = value;
		  }
	  }

	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\drag\DragAndDropItem.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}