using AsyncTask = android.os.AsyncTask;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

internal class jw : AsyncTask<int, int, int>
{
  internal jw(jv paramjv)
  {
  }

  protected internal virtual int? a()
  {
	OrderActivity orderActivity = this.a.a;
	OrderActivity.a(jv.a(this.a).getFreeCars(), OrderActivity.q(this.a.a), OrderActivity.W(this.a.a));
	OrderActivity.c(this.a.a, true);
	return null;
  }

  protected internal virtual void b()
  {
	OrderActivity.X(this.a.a).notifyRepaint();
	OrderActivity.p(this.a.a).setVisibility(8);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */