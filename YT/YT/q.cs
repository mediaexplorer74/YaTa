using System.Threading;

using MapController = ru.yandex.yandexmapkit.MapController;

public class q : ThreadStart
{
  public q(MapController paramMapController)
  {
  }

  public virtual void run()
  {
	this.a.h.setEnabled(false);
	if (!this.a.i.isEnabled())
	{
	  this.a.i.setEnabled(true);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\q.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */