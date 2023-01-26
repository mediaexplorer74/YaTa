using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using AsyncTask = android.os.AsyncTask;
using Toast = android.widget.Toast;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using LaunchResponse = ru.yandex.taxi.client.response.LaunchResponse;

public class ji : AsyncTask<int, int, LaunchResponse>
{
  private bool b = true;

  private ProgressDialog c;

  public ji(OrderActivity paramOrderActivity)
  {
  }

  protected internal virtual LaunchResponse a()
  {
	return OrderActivity.e(this.a).checkAuthorization();
  }

  protected internal virtual void a(LaunchResponse paramLaunchResponse)
  {
	this.c.dismiss();
	OrderActivity.e(this.a, "1".Equals(paramLaunchResponse.Data["checked"]));
	if (OrderActivity.t(this.a) && this.b)
	{
	  if (paramLaunchResponse.Blocked)
	  {
		Intent intent = new Intent((Context)this.a, typeof(AuthorizeActivity));
		intent.putExtra("block", true);
		intent.putExtra("release date", paramLaunchResponse.BlockDate);
		intent.putExtra("block type", paramLaunchResponse.BlockType);
		this.a.startActivityForResult(intent, 6);
		return;
	  }
	  OrderActivity.a(this.a, paramLaunchResponse.CurrentOrders);
	  OrderActivity.G(this.a);
	  return;
	}
	Toast.makeText(this.a.getApplicationContext(), 2131296442, 0).show();
  }

  protected internal virtual void onPreExecute()
  {
	this.c = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296441), true, true);
	this.c.setOnCancelListener(new jj(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ji.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */