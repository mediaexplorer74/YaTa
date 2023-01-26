namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using ProgressDialog = android.app.ProgressDialog;
	using Context = android.content.Context;
	using MediaPlayer = android.media.MediaPlayer;
	using Uri = android.net.Uri;
	using Bundle = android.os.Bundle;
	using View = android.view.View;
	using MediaController = android.widget.MediaController;
	using VideoView = android.widget.VideoView;
	using pe;
	using pf;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;

	public class VideoActivity : Activity
	{
	  private MediaController a;

	  private VideoView b;

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903081);
		Uri uri = Uri.parse(TaxiClient.sServerUrl.replaceAll("https:", "http:") + "video/android/video.m4v");
		this.b = (VideoView)findViewById(2131558434);
		this.b.setOnCompletionListener((MediaPlayer.OnCompletionListener)new pe(this));
		ProgressDialog progressDialog = ProgressDialog.show((Context)this, "", getResources().getString(2131296577), true, true);
		this.b.setOnPreparedListener((MediaPlayer.OnPreparedListener)new pf(progressDialog));
		this.a = new MediaController((Context)this);
		this.a.setAnchorView((View)this.b);
		this.a.setMediaPlayer((MediaController.MediaPlayerControl)this.b);
		this.b.setMediaController(this.a);
		this.b.setVideoURI(uri);
		this.b.start();
	  }

	  protected internal virtual void onDestroy()
	  {
		this.b.stopPlayback();
		base.onDestroy();
	  }

	  protected internal virtual void onPause()
	  {
		this.b.pause();
		base.onPause();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\VideoActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}