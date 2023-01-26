using DialogInterface = android.content.DialogInterface;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;

public class gr : DialogInterface.OnClickListener
{
  public gr(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */