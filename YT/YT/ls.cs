using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using SearchCityActivity = ru.yandex.taxi.activity.SearchCityActivity;

public class ls : View.OnTouchListener
{
  public ls(SearchCityActivity paramSearchCityActivity)
  {
  }

  public virtual bool onTouch(View paramView, MotionEvent paramMotionEvent)
  {
	bool @bool = true;
	null = @bool;
	if (1 == paramMotionEvent.getAction())
	{
	  int i = (int)(paramView.getWidth() * 0.8D);
	  if (SearchCityActivity.a(this.a).getText().length() > 0 && i < paramMotionEvent.getX())
	  {
		SearchCityActivity.a(this.a).setText("");
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


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ls.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */