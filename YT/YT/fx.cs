using View = android.view.View;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class fx : View.OnClickListener
{
  public fx(AuthorizeActivity paramAuthorizeActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	AuthorizeActivity.f(this.a).edit().putBoolean("license accepted", true).commit();
	this.a.removeDialog(2);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */