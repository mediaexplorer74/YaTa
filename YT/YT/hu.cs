using Intent = android.content.Intent;
using Uri = android.net.Uri;
using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hu : View.OnClickListener
{
  public hu(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	Intent intent = new Intent("android.intent.action.VIEW");
	intent.setData(Uri.parse("market://details?id=" + this.a.getPackageName()));
	this.a.startActivity(intent);
	this.a.removeDialog(18);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */