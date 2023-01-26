namespace ru.yandex.yandexmapkit.overlay.drag
{
	using MotionEvent = android.view.MotionEvent;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class DragAndDropOverlay : Overlay
	{
	  private static double d = 40.0D;

	  private DragAndDropItem e;

	  private bool f = false;

	  private bool g = true;

	  private float h = 1.0F;

	  public DragAndDropOverlay(MapController paramMapController) : base(paramMapController)
	  {
		Priority = (sbyte)125;
		this.h = (paramMapController.Context.getResources().getDisplayMetrics()).density;
		d *= this.h;
	  }

	  private void a(DragAndDropItem paramDragAndDropItem)
	  {
		if (paramDragAndDropItem != null && paramDragAndDropItem.BalloonItem != null)
		{
		  if (this.c.OverlayManager.Balloon.BalloonItem.Equals(paramDragAndDropItem.BalloonItem) && this.c.OverlayManager.Balloon.Visible && paramDragAndDropItem.BalloonItem.Visible)
		  {
			this.c.hideBalloon();
			return;
		  }
		}
		else
		{
		  return;
		}
		this.c.showBalloon(paramDragAndDropItem.BalloonItem);
	  }

	  public override void clearOverlayItems()
	  {
		base.clearOverlayItems();
		this.e = null;
	  }

	  public override sbyte Priority
	  {
		  get
		  {
			return 125;
		  }
	  }

	  public virtual void onClickDragableItem(DragAndDropItem paramDragAndDropItem)
	  {
		a(paramDragAndDropItem);
	  }

	  public override bool onLongPress(float paramFloat1, float paramFloat2)
	  {
		OverlayItem overlayItem = a(paramFloat1, paramFloat2);
		if (overlayItem != null)
		{
		  overlayItem = overlayItem;
		  if (overlayItem.isDragable() && overlayItem.a() == 0)
		  {
			DragItem = (DragAndDropItem)overlayItem;
			this.f = true;
			int i = overlayItem.Bitmap.getHeight();
			int j = (int)d;
			int k = overlayItem.OffsetCenterY;
			int m = overlayItem.OffsetY;
			overlayItem.a(1);
			overlayItem.b(i + j - k + m);
			overlayItem.OffsetY = overlayItem.OffsetY + overlayItem.b();
			MapController.notifyRepaint();
		  }
		  return true;
		}
		return false;
	  }

	  public override bool onScroll(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4)
	  {
		bool @bool = true;
		if (this.f)
		{
		  DragAndDropItem dragAndDropItem = this.e;
		  bool bool1 = @bool;
		  if (dragAndDropItem != null)
		  {
			bool1 = @bool;
			if (dragAndDropItem.Dragable)
			{
			  bool1 = @bool;
			  if (dragAndDropItem.a() == 1)
			  {
				dragAndDropItem.GeoPoint = MapController.getGeoPoint(new ScreenPoint(paramFloat3 + paramFloat1, paramFloat4 + paramFloat2));
				MapController.notifyRepaint();
				bool1 = @bool;
			  }
			}
		  }
		  return bool1;
		}
		return false;
	  }

	  public override bool onSingleTapUp(float paramFloat1, float paramFloat2)
	  {
		OverlayItem overlayItem = a(paramFloat1, paramFloat2);
		if (overlayItem != null)
		{
		  overlayItem = overlayItem;
		  if (overlayItem != null && overlayItem.isDragable())
		  {
			onClickDragableItem((DragAndDropItem)overlayItem);
		  }
		  else
		  {
			a((DragAndDropItem)overlayItem);
		  }
		  return true;
		}
		if (this.g && this.e != null)
		{
		  GeoPoint geoPoint = MapController.getGeoPoint(new ScreenPoint(paramFloat1, paramFloat2));
		  this.e.GeoPoint = geoPoint;
		  MapController.notifyRepaint();
		  return true;
		}
		return false;
	  }

	  public override bool onTouchEvent(MotionEvent paramMotionEvent)
	  {
		null = true;
		if (!base.onTouchEvent(paramMotionEvent) && this.f && paramMotionEvent.getAction() == 1)
		{
		  onUp(paramMotionEvent.getX(), paramMotionEvent.getY());
		  return null;
		}
		return false;
	  }

	  public override bool onUp(float paramFloat1, float paramFloat2)
	  {
		null = true;
		DragAndDropItem dragAndDropItem = this.e;
		if (this.f && dragAndDropItem != null && dragAndDropItem.Dragable && dragAndDropItem.a() == 1)
		{
		  dragAndDropItem.GeoPoint = MapController.getGeoPoint(new ScreenPoint(paramFloat1, paramFloat2 - dragAndDropItem.b()));
		  dragAndDropItem.a(0);
		  dragAndDropItem.Bitmap.getHeight();
		  dragAndDropItem.OffsetCenterY;
		  dragAndDropItem.OffsetY;
		  dragAndDropItem.OffsetY = dragAndDropItem.OffsetY - dragAndDropItem.b();
		  this.f = false;
		  MapController.notifyRepaint();
		  return null;
		}
		return false;
	  }

	  public override void removeOverlayItem(OverlayItem paramOverlayItem)
	  {
		base.removeOverlayItem(paramOverlayItem);
		if (paramOverlayItem == this.e)
		{
		  this.e = null;
		}
	  }

	  public virtual DragAndDropItem DragItem
	  {
		  set
		  {
			this.e = value;
			this.e.Dragable = true;
			this.e.Priority = (sbyte)126;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\drag\DragAndDropOverlay.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}