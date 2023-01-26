using Intent = android.content.Intent;
using View = android.view.View;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class iy : View.OnClickListener
{
  public iy(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	Intent intent = new Intent(this.a.getApplicationContext(), typeof(AuthorizeActivity));
	intent.putExtra("make order", true);
	this.a.startActivityForResult(intent, 4);
	this.a.removeDialog(4);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\iy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */