using View = android.view.View;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class fy : View.OnClickListener
{
  public fy(AuthorizeActivity paramAuthorizeActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	this.a.removeDialog(2);
	this.a.setResult(0);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */