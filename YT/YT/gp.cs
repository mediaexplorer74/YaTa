using System;
using System.Threading;

using Context = android.content.Context;
using Intent = android.content.Intent;
using Vibrator = android.os.Vibrator;
using Log = android.util.Log;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using DelayOrderActivity = ru.yandex.taxi.activity.DelayOrderActivity;
using OnTheWayResponse = ru.yandex.taxi.client.response.OnTheWayResponse;

public class gp : Thread
{
  private gp(DelayOrderActivity paramDelayOrderActivity, sbyte paramByte)
  {
  }

  public virtual void run()
  {
	while (true)
	{
	  try
	  {
		OnTheWayResponse onTheWayResponse;
		if (!this.a.mInterrupt)
		{
		  onTheWayResponse = this.a.mTaxiClient.doTaxiOnTheWay(this.a.mClientId, this.a.mOrderId, "none");
		  if (onTheWayResponse.Code == 200 && !this.a.mCurrentStatus.Equals(onTheWayResponse.Status))
		  {
			this.a.mInterrupt = true;
			DelayOrderActivity.a(this.a, "driving");
			return;
		  }
		}
		else
		{
		  return;
		}
		if (onTheWayResponse.Blocked)
		{
		  ((Vibrator)this.a.getSystemService("vibrator")).vibrate(1500L);
		  Intent intent = new Intent();
		  this((Context)this.a, typeof(AuthorizeActivity));
		  intent.putExtra("block type", onTheWayResponse.BlockType);
		  intent.putExtra("block", true);
		  intent.putExtra("release date", onTheWayResponse.BlockDate);
		  this.a.startActivityForResult(intent, 4);
		  return;
		}
	  }
	  catch (Exception exception)
	  {
		Log.e("DelayOrderActivity", "Fail update info about delay order status", exception);
		return;
	  }
	  if (!DelayOrderActivity.a(this.a) && this.a.mScreenVisible)
	  {
		DelayOrderActivity.a(this.a, true);
		DelayOrderActivity delayOrderActivity = this.a;
		gq gq = new gq();
		this(this);
		delayOrderActivity.runOnUiThread(gq);
	  }
	  Thread.Sleep(20000L);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */