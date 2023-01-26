using MediaPlayer = android.media.MediaPlayer;
using VideoActivity = ru.yandex.taxi.activity.VideoActivity;

public class pe : MediaPlayer.OnCompletionListener
{
  public pe(VideoActivity paramVideoActivity)
  {
  }

  public virtual void onCompletion(MediaPlayer paramMediaPlayer)
  {
	this.a.finish();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pe.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */