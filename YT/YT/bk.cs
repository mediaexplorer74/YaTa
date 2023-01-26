using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
using BalloonOverlay = ru.yandex.yandexmapkit.overlay.balloon.BalloonOverlay;

public class bk : TimerTask
{
  public bk(BalloonOverlay paramBalloonOverlay, BalloonItem paramBalloonItem, Timer paramTimer)
  {
  }

  public virtual void run()
  {
	BalloonItem balloonItem = this.a;
	balloonItem.r += 6.5F * BalloonOverlay.a(this.c).a();
	if (this.a.r > 100.0F)
	{
	  this.a.r = 100.0F;
	  this.a.q = false;
	  this.b.cancel();
	}
	BalloonOverlay.b(this.c).notifyRepaint();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bk.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */