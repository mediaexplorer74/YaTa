using Intent = android.content.Intent;
using View = android.view.View;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class @is : View.OnClickListener
{
  public @is(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	Intent intent = new Intent(this.a.getApplicationContext(), typeof(AuthorizeActivity));
	intent.putExtra("make order", true);
	this.a.startActivityForResult(intent, 4);
	this.a.removeDialog(5);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\is.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */