using View = android.view.View;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class ke : View.OnClickListener
{
  public ke(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ke.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */