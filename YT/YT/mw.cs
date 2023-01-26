using System;

using DialogInterface = android.content.DialogInterface;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class mw : DialogInterface.OnClickListener
{
  public mw(SearchTaxiActivity paramSearchTaxiActivity, bool paramBoolean)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	(new mx(this)).execute((object[])new int?[] {Convert.ToInt32(0)});
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */