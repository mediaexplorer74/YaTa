using GestureDetector = android.view.GestureDetector;
using MotionEvent = android.view.MotionEvent;
using WheelScroller = ru.yandex.taxi.ui.wheel.WheelScroller;

public class qy : GestureDetector.SimpleOnGestureListener
{
  public qy(WheelScroller paramWheelScroller)
  {
  }

  public virtual bool onFling(MotionEvent paramMotionEvent1, MotionEvent paramMotionEvent2, float paramFloat1, float paramFloat2)
  {
	WheelScroller.a(this.a, 0);
	WheelScroller.b(this.a).fling(0, WheelScroller.a(this.a), 0, (int)-paramFloat2, 0, 0, -2147483647, 2147483647);
	WheelScroller.b(this.a, 0);
	return true;
  }

  public virtual bool onScroll(MotionEvent paramMotionEvent1, MotionEvent paramMotionEvent2, float paramFloat1, float paramFloat2)
  {
	return true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */