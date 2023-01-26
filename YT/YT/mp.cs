using System;

using DialogInterface = android.content.DialogInterface;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class mp : DialogInterface.OnClickListener
{
  public mp(SearchTaxiActivity paramSearchTaxiActivity, int paramInt)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	string str = this.b.getResources().getString(2131296422);
	SimpleDateFormat simpleDateFormat = new SimpleDateFormat("HH:mm");
	DateTime calendar = new DateTime();
	calendar = new DateTime(this.b.mWhen);
	calendar = calendar.AddMinutes(this.a);
	str = String.format(str, new object[] {simpleDateFormat.format(calendar)});
	(new nb(this.b, this.a, 2131296291, str, null, null)).execute((object[])new int?[0]);
	this.b.removeDialog(3);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */