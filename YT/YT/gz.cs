using View = android.view.View;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;

public class gz : View.OnClickListener
{
  public gz(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	bool @bool;
	EditAddressActivity editAddressActivity = this.a;
	if (!EditAddressActivity.o(this.a))
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	EditAddressActivity.b(editAddressActivity, @bool);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */