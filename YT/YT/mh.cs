using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;

public class mh : View.OnTouchListener
{
  public mh(SearchStreetActivity paramSearchStreetActivity)
  {
  }

  public virtual bool onTouch(View paramView, MotionEvent paramMotionEvent)
  {
	bool @bool = true;
	if (1 == paramMotionEvent.getAction())
	{
	  int i = (int)(paramView.getWidth() * SearchStreetActivity.j(this.a));
	  SearchStreetActivity searchStreetActivity = this.a;
	  if (i >= paramMotionEvent.getX())
	  {
		@bool = false;
	  }
	  SearchStreetActivity.b(searchStreetActivity, @bool);
	}
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */