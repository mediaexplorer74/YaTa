using View = android.view.View;
using SelectPointActivity = ru.yandex.taxi.activity.SelectPointActivity;

public class nk : View.OnClickListener
{
  public nk(SelectPointActivity paramSelectPointActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	SelectPointActivity.a(this.a, 2);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nk.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */