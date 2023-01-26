using System.Threading;

using Context = android.content.Context;
using Toast = android.widget.Toast;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class mt : ThreadStart
{
  public mt(SearchTaxiActivity paramSearchTaxiActivity)
  {
  }

  public virtual void run()
  {
	Toast toast = Toast.makeText((Context)this.a, 2131296306, 1);
	toast.setGravity(16, 0, 0);
	toast.show();
	SearchTaxiActivity.c(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mt.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */