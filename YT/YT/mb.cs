using KeyEvent = android.view.KeyEvent;
using TextView = android.widget.TextView;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;

public class mb : TextView.OnEditorActionListener
{
  public mb(SearchStreetActivity paramSearchStreetActivity)
  {
  }

  public virtual bool onEditorAction(TextView paramTextView, int paramInt, KeyEvent paramKeyEvent)
  {
	if (paramKeyEvent == null || 1 == paramKeyEvent.getAction())
	{
	  SearchStreetActivity.a(this.a);
	}
	return true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */