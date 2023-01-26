using GestureDetector = android.view.GestureDetector;
using MotionEvent = android.view.MotionEvent;
using SlidingDrawer = ru.yandex.taxi.ui.slider.SlidingDrawer;

public class qv : GestureDetector.SimpleOnGestureListener
{
  public qv(SlidingDrawer paramSlidingDrawer)
  {
  }

  public virtual bool onDown(MotionEvent paramMotionEvent)
  {
	SlidingDrawer.a(this.a, 0.0F);
	return base.onDown(paramMotionEvent);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */