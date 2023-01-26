using System.Threading;

using Log = android.util.Log;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class mm : ThreadStart
{
	private bool InstanceFieldsInitialized = false;

	private void InitializeInstanceFields()
	{
		c = new mn(this);
	}

  internal float a;

  private ThreadStart c;

  public mm(SearchTaxiActivity paramSearchTaxiActivity)
  {
	  if (!InstanceFieldsInitialized)
	  {
		  InitializeInstanceFields();
		  InstanceFieldsInitialized = true;
	  }
  }

  public virtual void run()
  {
	this.a = 5.0F;
	while (SearchTaxiActivity.a(this.b).getZoomCurrent() > this.b.mOptimZoom && !this.b.mInterrupt)
	{
	  this.b.runOnUiThread(this.c);
	  try
	  {
		Thread.Sleep(50L);
	  }
	  catch (InterruptedException interruptedException)
	  {
		Log.e("SearchTaxiActivity", "Fail sleep before radar zoom step", interruptedException);
	  }
	}
	this.b.runOnUiThread(new mo(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */