using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class ki : View.OnTouchListener
{
  public ki(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual bool onTouch(View paramView, MotionEvent paramMotionEvent)
  {
	null = true;
	if (paramMotionEvent.getAction() == 1)
	{
	  this.a.showDialog(2);
	  return null;
	}
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ki.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */