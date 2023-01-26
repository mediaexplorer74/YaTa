using Context = android.content.Context;
using Intent = android.content.Intent;
using MotionEvent = android.view.MotionEvent;
using View = android.view.View;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;

public class gx : View.OnTouchListener
{
  public gx(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual bool onTouch(View paramView, MotionEvent paramMotionEvent)
  {
	if (1 == paramMotionEvent.getAction())
	{
	  if ((int)(paramView.getWidth() * 0.8D) < paramMotionEvent.getX())
	  {
		if ("".Equals(EditAddressActivity.f(this.a).getText().ToString()))
		{
		  EditAddressActivity.a(this.a, 1);
		}
		else
		{
		  EditAddressActivity.f(this.a).setText("");
		  EditAddressActivity.g(this.a).setText("");
		  EditAddressActivity.h(this.a).setText("");
		  EditAddressActivity.i(this.a).setText("");
		  EditAddressActivity.j(this.a).setText("");
		  EditAddressActivity.g(this.a).setEnabled(false);
		  EditAddressActivity.h(this.a).setEnabled(false);
		  EditAddressActivity.i(this.a).setEnabled(false);
		  EditAddressActivity.j(this.a).setEnabled(false);
		  EditAddressActivity.a(this.a, false);
		  EditAddressActivity.b(this.a, null);
		  EditAddressActivity.a(this.a, "");
		  EditAddressActivity.k(this.a).requestFocus();
		}
	  }
	  else
	  {
		string str;
		Intent intent = new Intent((Context)this.a, typeof(SearchStreetActivity));
		intent.putExtra("city name", EditAddressActivity.c(this.a).getText().ToString());
		intent.putExtra("only suggest", true);
		intent.putExtra("edit after search", true);
		if ("".Equals(EditAddressActivity.f(this.a).getText().ToString()))
		{
		  str = "";
		}
		else
		{
		  str = EditAddressActivity.l(this.a);
		}
		intent.putExtra("street name", str);
		intent.putExtra("type", EditAddressActivity.a(this.a));
		this.a.startActivityForResult(intent, 1);
	  }
	  EditAddressActivity.e(this.a);
	}
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */