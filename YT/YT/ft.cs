using KeyEvent = android.view.KeyEvent;
using View = android.view.View;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class ft : View.OnKeyListener
{
  public ft(AuthorizeActivity paramAuthorizeActivity)
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
	if (AuthorizeActivity.a(this.a).isEnabled())
	{
	  AuthorizeActivity.a(this.a).performClick();
	}
	@bool = true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ft.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */