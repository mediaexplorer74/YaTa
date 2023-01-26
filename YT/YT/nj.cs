using Context = android.content.Context;
using Intent = android.content.Intent;
using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using SelectPointActivity = ru.yandex.taxi.activity.SelectPointActivity;

public class nj : View.OnTouchListener
{
  public nj(SelectPointActivity paramSelectPointActivity)
  {
  }

  public virtual bool onTouch(View paramView, MotionEvent paramMotionEvent)
  {
	if (paramMotionEvent.getAction() == 1 && SelectPointActivity.a(this.a) != null)
	{
	  string str;
	  Intent intent = new Intent((Context)this.a, typeof(SearchStreetActivity));
	  if (SelectPointActivity.a(this.a) == null)
	  {
		str = "Москва";
	  }
	  else
	  {
		str = SelectPointActivity.a(this.a).getCity();
	  }
	  intent.putExtra("city name", str);
	  intent.putExtra("type", SelectPointActivity.b(this.a));
	  intent.putExtra("street name", SelectPointActivity.a(this.a).getName());
	  intent.putExtra("only suggest", true);
	  intent.putExtra("edit after search", true);
	  this.a.startActivityForResult(intent, 1);
	}
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */