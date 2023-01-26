using DialogInterface = android.content.DialogInterface;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class km : DialogInterface.OnClickListener
{
  public km(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\km.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */