using System.Threading;

using MapController = ru.yandex.yandexmapkit.MapController;

public class r : ThreadStart
{
  public r(MapController paramMapController)
  {
  }

  public virtual void run()
  {
	this.a.i.setEnabled(false);
	if (!this.a.h.isEnabled())
	{
	  this.a.h.setEnabled(true);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\r.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */