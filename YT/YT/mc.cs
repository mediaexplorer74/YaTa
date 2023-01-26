using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;

public class mc : View.OnTouchListener
{
  public mc(SearchStreetActivity paramSearchStreetActivity)
  {
  }

  public virtual bool onTouch(View paramView, MotionEvent paramMotionEvent)
  {
	bool @bool = true;
	null = @bool;
	if (1 == paramMotionEvent.getAction())
	{
	  int i = (int)(paramView.getWidth() * 0.8D);
	  if (SearchStreetActivity.b(this.a) && i < paramMotionEvent.getX())
	  {
		SearchStreetActivity.c(this.a).setText("");
		return @bool;
	  }
	}
	else
	{
	  return null;
	}
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */