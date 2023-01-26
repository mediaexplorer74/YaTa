namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using Bundle = android.os.Bundle;

	public class StartActivity : Activity
	{
	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		finish();
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		startActivityForResult(new Intent((Context)this, typeof(OrderActivity)), 0);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\StartActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}