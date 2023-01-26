using System;

using AsyncTask = android.os.AsyncTask;
using EndlessAdapter = ru.yandex.taxi.ui.wheel.adapters.EndlessAdapter;

public class rd : AsyncTask<Void, Void, Exception>
{
  public rd(EndlessAdapter paramEndlessAdapter)
  {
  }

  protected internal virtual Exception a()
  {
	exception = null;
	try
	{
	  EndlessAdapter.a(this.a).set(this.a.cacheInBackground());
	}
	catch (Exception)
	{
	}
	return exception;
  }

  protected internal virtual void a(Exception paramException)
  {
	if (paramException == null)
	{
	  this.a.appendCachedData();
	}
	else
	{
	  EndlessAdapter.a(this.a).set(this.a.onException(EndlessAdapter.b(this.a), paramException));
	}
	EndlessAdapter.a(this.a, null);
	this.a.notifyDataSetChanged();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\rd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */