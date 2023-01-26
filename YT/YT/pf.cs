using ProgressDialog = android.app.ProgressDialog;
using MediaPlayer = android.media.MediaPlayer;

public class pf : MediaPlayer.OnPreparedListener
{
  public pf(ProgressDialog paramProgressDialog)
  {
  }

  public virtual void onPrepared(MediaPlayer paramMediaPlayer)
  {
	this.a.dismiss();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */