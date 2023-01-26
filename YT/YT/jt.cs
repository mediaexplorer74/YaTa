using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

internal class jt : AsyncTask<int, int, int>
{
  internal jt(js paramjs)
  {
  }

  protected internal virtual int? a()
  {
	Log.d("OrderActivity", "Update all taxi: add cars");
	OrderActivity orderActivity = this.a.a;
	OrderActivity.a(js.a(this.a).getFreeCars(), OrderActivity.o(this.a.a), OrderActivity.W(this.a.a));
	orderActivity = this.a.a;
	OrderActivity.a(js.a(this.a).getBusyCars(), OrderActivity.n(this.a.a), OrderActivity.Z(this.a.a));
	OrderActivity.d(this.a.a, true);
	return null;
  }

  protected internal virtual void b()
  {
	OrderActivity.X(this.a.a).notifyRepaint();
	OrderActivity.p(this.a.a).setVisibility(8);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jt.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */