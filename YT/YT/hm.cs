using Context = android.content.Context;
using DialogInterface = android.content.DialogInterface;
using Intent = android.content.Intent;
using PreferenceManager = android.preference.PreferenceManager;
using InfoActivity = ru.yandex.taxi.activity.InfoActivity;
using VideoActivity = ru.yandex.taxi.activity.VideoActivity;

public class hm : DialogInterface.OnClickListener
{
  public hm(InfoActivity paramInfoActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	PreferenceManager.getDefaultSharedPreferences(this.a.getApplicationContext()).edit().putBoolean("first launch", true).commit();
	Intent intent = new Intent((Context)this.a, typeof(VideoActivity));
	this.a.startActivity(intent);
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */