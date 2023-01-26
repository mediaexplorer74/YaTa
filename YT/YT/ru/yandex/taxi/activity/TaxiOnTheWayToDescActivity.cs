namespace ru.yandex.taxi.activity
{
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using BitmapFactory = android.graphics.BitmapFactory;
	using Bundle = android.os.Bundle;
	using Vibrator = android.os.Vibrator;
	using PreferenceManager = android.preference.PreferenceManager;
	using KeyEvent = android.view.KeyEvent;
	using Menu = android.view.Menu;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUrlDemoUtils = ru.yandex.taxi.client.HttpUrlDemoUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;

	public class TaxiOnTheWayToDescActivity : TaxiOnTheWayToSourceActivity
	{
	  protected internal override TaxiClient TaxiClient
	  {
		  get
		  {
			if (this.mDemoMode)
			{
			  HttpUrlDemoUtils httpUrlDemoUtils = new HttpUrlDemoUtils();
			  return new TaxiClient(getApplicationContext(), (HttpUtils)httpUrlDemoUtils);
			}
			HttpUrlConnectionUtils httpUrlConnectionUtils = new HttpUrlConnectionUtils();
			return new TaxiClient(getApplicationContext(), (HttpUtils)httpUrlConnectionUtils);
		  }
	  }

	  public override void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		this.mSourceBitmap = BitmapFactory.decodeResource(getResources(), 2130837508);
		this.mWayDirection = 1;
		this.mAddress = this.mDestAddress;
		this.mCurrentStatus = "transporting";
		PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).edit().remove("last order date").commit();
	  }

	  public override bool onCreateOptionsMenu(Menu paramMenu)
	  {
		base.onCreateOptionsMenu(paramMenu);
		paramMenu.removeItem(0);
		return true;
	  }

	  public override bool onKeyDown(int paramInt, KeyEvent paramKeyEvent)
	  {
		switch (paramInt)
		{
		  default:
			return base.onKeyDown(paramInt, paramKeyEvent);
		  case 4:
			break;
		}
		finish();
		return true;
	  }

	  protected internal override void showTaxiArriveEvent()
	  {
		if (!this.mDemoMode)
		{
		  ((Vibrator)getSystemService("vibrator")).vibrate(1000L);
		}
		if (this.mDemoMode)
		{
		  finish();
		  return;
		}
		if (this.mActivityStarted)
		{
		  Intent intent = new Intent((Context)this, typeof(RateActivity));
		  intent.putExtra("taxi name", this.mParkiName);
		  intent.putExtra("park id", this.mParkId);
		  intent.putExtra("demo", this.mDemoMode);
		  intent.putExtra("order id", this.mOrderId);
		  intent.putExtra("taxi logo", this.mTaxiLogoUrl);
		  startActivityForResult(intent, 3);
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\TaxiOnTheWayToDescActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}