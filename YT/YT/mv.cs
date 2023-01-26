using DialogInterface = android.content.DialogInterface;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class mv : DialogInterface.OnClickListener
{
  public mv(SearchTaxiActivity paramSearchTaxiActivity, bool paramBoolean)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	if (this.a)
	{
	  SearchTaxiActivity.e(this.b);
	  SearchTaxiActivity.a(this.b, this.a);
	}
	this.b.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */