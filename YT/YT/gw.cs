using Context = android.content.Context;
using Intent = android.content.Intent;
using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using SearchCityActivity = ru.yandex.taxi.activity.SearchCityActivity;

public class gw : View.OnTouchListener
{
  public gw(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual bool onTouch(View paramView, MotionEvent paramMotionEvent)
  {
	if (1 == paramMotionEvent.getAction())
	{
	  if ((int)(paramView.getWidth() * 0.8D) < paramMotionEvent.getX())
	  {
		if ("".Equals(EditAddressActivity.c(this.a).getText().ToString()))
		{
		  EditAddressActivity.a(this.a, 0);
		}
		else
		{
		  EditAddressActivity.d(this.a);
		}
	  }
	  else
	  {
		Intent intent = new Intent((Context)this.a, typeof(SearchCityActivity));
		intent.putExtra("type", EditAddressActivity.a(this.a));
		this.a.startActivityForResult(intent, 0);
	  }
	  EditAddressActivity.e(this.a);
	}
	return true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */