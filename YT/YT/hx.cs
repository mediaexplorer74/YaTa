using System;
using System.Threading;

using Log = android.util.Log;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class hx : ThreadStart
{
  public hx(OrderActivity paramOrderActivity)
  {
  }

  public virtual void run()
  {
	string[] arrayOfString = null;
	try
	{
	  js js = new js();
	  this(this.a);
	  OrderActivity.a(this.a, js);
	  if (OrderActivity.a(this.a) != null)
	  {
		arrayOfString = OrderActivity.a(this.a).getClasses();
		string[] arrayOfString1 = OrderActivity.a(this.a).getExcludeParks();
	  }
	  else
	  {
		js = null;
	  }
	  jv jv = new jv();
	  this(this.a);
	  OrderActivity.a(this.a, jv, (string[])js, arrayOfString);
	}
	catch (Exception exception)
	{
	  Log.e("OrderActivity", "Fail init taxi map data", exception);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */