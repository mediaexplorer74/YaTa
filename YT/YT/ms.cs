using System;
using System.Threading;

using Log = android.util.Log;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class ms : ThreadStart
{
  public ms(SearchTaxiActivity paramSearchTaxiActivity)
  {
  }

  public virtual void run()
  {
	while (SearchTaxiActivity.b(this.a))
	{
	  SearchTaxiActivity.a(this.a).notifyRepaint();
	  try
	  {
		Thread.Sleep(100L);
	  }
	  catch (Exception)
	  {
		Log.e("SearchTaxiActivity", "Fail sleep before radar update");
	  }
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ms.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */