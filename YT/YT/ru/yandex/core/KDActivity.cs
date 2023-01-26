namespace ru.yandex.core
{
	using Activity = android.app.Activity;
	using Application = android.app.Application;
	using Bundle = android.os.Bundle;
	using KeyEvent = android.view.KeyEvent;
	using View = android.view.View;

	public abstract class KDActivity : Activity
	{
	  internal bool isPaused = false;

	  internal bool isStarted = false;

	  internal KDView window;

	  protected internal abstract KDView createKDWindow(Application paramApplication);

	  protected internal abstract int JobID {get;}

	  public virtual void onBackPressed()
	  {
		CoreApplication.sendEvent(new int[] {56, 40961, 1});
	  }

	  public virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		this.window = createKDWindow(getApplication());
		setContentView((View)this.window);
		CoreApplication.setCurrent(this, this.window);
	  }

	  protected internal virtual void onDestroy()
	  {
		if (this.isStarted)
		{
		  this.isStarted = false;
		  CoreApplication.stopJob(JobID);
		}
		base.onDestroy();
	  }

	  public virtual bool onKeyUp(int paramInt, KeyEvent paramKeyEvent)
	  {
		if (paramInt == 82)
		{
		  this.window.performHapticFeedback(0);
		  CoreApplication.sendEvent(new int[] {56, 40963, 1});
		  return true;
		}
		return base.onKeyUp(paramInt, paramKeyEvent);
	  }

	  public virtual void onLowMemory()
	  {
		CoreApplication.sendEvent(new int[] {104});
		base.onLowMemory();
	  }

	  protected internal virtual void onPause()
	  {
		this.isPaused = true;
		CoreApplication.tryPause();
		base.onPause();
	  }

	  protected internal virtual void onResume()
	  {
		this.isPaused = false;
		CoreApplication.tryResume();
		base.onResume();
	  }

	  public virtual bool onSearchRequested()
	  {
		CoreApplication.sendEvent(new int[] {56, 40962, 1});
		return false;
	  }

	  public virtual void onStopRequired()
	  {
		finish();
	  }

	  internal virtual void startJob()
	  {
		this.isStarted = true;
		CoreApplication.startJob(JobID);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\KDActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}