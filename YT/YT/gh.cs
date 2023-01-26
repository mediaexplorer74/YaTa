using KeyEvent = android.view.KeyEvent;
using View = android.view.View;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;

public class gh : View.OnKeyListener
{
  public gh(ConfirmActivity paramConfirmActivity)
  {
  }

  public virtual bool onKey(View paramView, int paramInt, KeyEvent paramKeyEvent)
  {
	bool @bool = false;
	switch (paramInt)
	{
	  default:
		return @bool;
	  case 66:
		break;
	}
	ConfirmActivity.a(this.a).performClick();
	@bool = true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */