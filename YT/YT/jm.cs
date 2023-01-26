using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using Resources = android.content.res.Resources;
using AsyncTask = android.os.AsyncTask;
using Toast = android.widget.Toast;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using LaunchResponse = ru.yandex.taxi.client.response.LaunchResponse;

internal class jm : AsyncTask<int, int, LaunchResponse>
{
  private bool b = true;

  private ProgressDialog c;

  internal jm(jl paramjl)
  {
  }

  protected internal virtual LaunchResponse a()
  {
	return OrderActivity.e(this.a.a).checkAuthorization();
  }

  protected internal virtual void a(LaunchResponse paramLaunchResponse)
  {
	this.c.dismiss();
	OrderActivity.e(this.a.a, "1".Equals(paramLaunchResponse.Data["checked"]));
	if (OrderActivity.t(this.a.a) && this.b)
	{
	  if (paramLaunchResponse.Blocked)
	  {
		Intent intent = new Intent((Context)this.a.a, typeof(AuthorizeActivity));
		intent.putExtra("block", true);
		intent.putExtra("release date", paramLaunchResponse.BlockDate);
		intent.putExtra("block type", paramLaunchResponse.BlockType);
		this.a.a.startActivityForResult(intent, 4);
		return;
	  }
	  OrderActivity.a(this.a.a, paramLaunchResponse.CurrentOrders);
	  if (OrderActivity.u(this.a.a).size() > 0)
	  {
		this.a.a.showDialog(17);
		return;
	  }
	  OrderActivity.v(this.a.a);
	  return;
	}
	Toast.makeText(this.a.a.getApplicationContext(), 2131296442, 0).show();
  }

  protected internal virtual void onPreExecute()
  {
	int i;
	OrderActivity orderActivity = this.a.a;
	Resources resources = this.a.a.getResources();
	if (OrderActivity.t(this.a.a))
	{
	  i = 2131296465;
	}
	else
	{
	  i = 2131296441;
	}
	this.c = ProgressDialog.show((Context)orderActivity, "", resources.getString(i), true, true);
	this.c.setOnCancelListener(new jn(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */