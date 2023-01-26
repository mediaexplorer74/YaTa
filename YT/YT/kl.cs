using DialogInterface = android.content.DialogInterface;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class kl : DialogInterface.OnClickListener
{
  public kl(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	ParkInfoActivity.b(this.a).setSelection(paramInt);
	this.a.removeDialog(2);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */