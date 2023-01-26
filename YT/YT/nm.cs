using SelectPointActivity = ru.yandex.taxi.activity.SelectPointActivity;
using DragAndDropOverlay = ru.yandex.taxi.map.DragAndDropOverlay;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class nm : DragAndDropOverlay.OnDragListener
{
  private nm(SelectPointActivity paramSelectPointActivity, sbyte paramByte)
  {
  }

  public virtual void completeDragging(GeoPoint paramGeoPoint)
  {
  }

  public virtual void stopDrag(GeoPoint paramGeoPoint)
  {
	if (SelectPointActivity.c(this.a) != null)
	{
	  SelectPointActivity.c(this.a).cancel(true);
	}
	SelectPointActivity.a(this.a, new nl(this.a));
	SelectPointActivity.c(this.a).execute((object[])new GeoPoint[] {paramGeoPoint});
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */