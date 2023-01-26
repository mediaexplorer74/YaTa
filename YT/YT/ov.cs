using MotionEvent = android.view.MotionEvent;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;
using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
using OnBalloonListener = ru.yandex.yandexmapkit.overlay.balloon.OnBalloonListener;

internal class ov : OnBalloonListener
{
  internal ov(ot paramot)
  {
  }

  public virtual void onBalloonClick(MotionEvent paramMotionEvent, BalloonItem paramBalloonItem)
  {
	TaxiOnTheWayToSourceActivity.c(this.a.b);
  }

  public virtual void onBalloonHide(BalloonItem paramBalloonItem)
  {
  }

  public virtual void onBalloonShow(BalloonItem paramBalloonItem)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ov.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */