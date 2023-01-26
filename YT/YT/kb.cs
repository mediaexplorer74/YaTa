using System.Threading;

using TextView = android.widget.TextView;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;

internal class kb : ThreadStart
{
  internal kb(jz paramjz, SimpleResponse paramSimpleResponse, bool paramBoolean1, bool paramBoolean2)
  {
  }

  public virtual void run()
  {
	bool @bool;
	OrderActivity.g(this.d.a, false);
	if (!"1".Equals(this.a.getData().get("calibrate")))
	{
	  OrderActivity.d(this.d.a).setText(2131296454);
	  OrderActivity.d(this.d.a).setCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
	}
	else
	{
	  OrderActivity.g(this.d.a, true);
	  OrderActivity.d(this.d.a).setText(2131296453);
	  OrderActivity.d(this.d.a).setCompoundDrawablesWithIntrinsicBounds(2130837617, 0, 0, 0);
	}
	if (this.a.getData().get("online") != null)
	{
	  OrderActivity.a(this.d.a, (string)this.a.getData().get("parks"), (string)this.a.getData().get("online"));
	}
	else
	{
	  jz.a(this.d);
	}
	if (this.b)
	{
	  if (this.c)
	  {
		if (!OrderActivity.Q(this.d.a))
		{
		  OrderActivity.b(this.d.a).setVisibility(8);
		  OrderActivity.d(this.d.a).setVisibility(0);
		}
		else
		{
		  OrderActivity.i(this.d.a, true);
		}
	  }
	  else if (!OrderActivity.R(this.d.a))
	  {
		OrderActivity.d(this.d.a).setText(2131296455);
		OrderActivity.d(this.d.a).setCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
		OrderActivity.d(this.d.a).setVisibility(0);
	  }
	}
	TextView textView = OrderActivity.M(this.d.a);
	if (OrderActivity.O(this.d.a) || OrderActivity.M(this.d.a).getText().ToString().Equals(""))
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	textView.setVisibility(@bool);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */