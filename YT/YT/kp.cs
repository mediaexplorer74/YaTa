using Intent = android.content.Intent;
using View = android.view.View;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class kp : View.OnClickListener
{
  public kp(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	Intent intent = new Intent(this.a.getApplicationContext(), typeof(AuthorizeActivity));
	intent.putExtra("make order", true);
	this.a.startActivityForResult(intent, 0);
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */