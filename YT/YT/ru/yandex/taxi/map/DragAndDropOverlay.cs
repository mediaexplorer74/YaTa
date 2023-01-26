namespace ru.yandex.taxi.map
{
	using MapController = ru.yandex.yandexmapkit.MapController;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using DragAndDropItem = ru.yandex.yandexmapkit.overlay.drag.DragAndDropItem;
	using DragAndDropOverlay = ru.yandex.yandexmapkit.overlay.drag.DragAndDropOverlay;

	public class DragAndDropOverlay : DragAndDropOverlay
	{
	  private DragAndDropOverlay$OnDragListener d;

	  public DragAndDropOverlay(MapController paramMapController) : base(paramMapController)
	  {
	  }

	  public virtual int compareTo(object paramObject)
	  {
		return 0;
	  }

	  protected internal override void onClickDragableItem(DragAndDropItem paramDragAndDropItem)
	  {
		base.onClickDragableItem(paramDragAndDropItem);
		if (this.d != null)
		{
		  this.d.completeDragging(((DragAndDropItem)OverlayItems[0]).GeoPoint);
		}
	  }

	  public override bool onSingleTapUp(float paramFloat1, float paramFloat2)
	  {
		bool @bool = base.onSingleTapUp(paramFloat1, paramFloat2);
		if (this.d != null)
		{
		  this.d.stopDrag(((OverlayItem)OverlayItems[0]).GeoPoint);
		}
		return @bool;
	  }

	  public override bool onUp(float paramFloat1, float paramFloat2)
	  {
		bool @bool = base.onUp(paramFloat1, paramFloat2);
		if (this.d != null)
		{
		  this.d.stopDrag(((OverlayItem)OverlayItems[0]).GeoPoint);
		}
		return @bool;
	  }

	  public virtual DragAndDropOverlay$OnDragListener OnDragListener
	  {
		  set
		  {
			this.d = value;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\map\DragAndDropOverlay.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}