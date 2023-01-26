using Context = android.content.Context;
using DialogInterface = android.content.DialogInterface;
using Intent = android.content.Intent;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using VideoActivity = ru.yandex.taxi.activity.VideoActivity;

public class ie : DialogInterface.OnClickListener
{
  public ie(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	Intent intent = new Intent((Context)this.a, typeof(VideoActivity));
	this.a.startActivity(intent);
	this.a.removeDialog(13);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ie.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */