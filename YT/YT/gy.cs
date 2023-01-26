using View = android.view.View;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;

public class gy : View.OnClickListener
{
  public gy(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	if (!EditAddressActivity.m(this.a))
	{
	  (new hg(this.a)).execute((object[])new int?[0]);
	  return;
	}
	EditAddressActivity.n(this.a);
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */