using System;

using DialogInterface = android.content.DialogInterface;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ib : DialogInterface.OnClickListener
{
  public ib(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	DateTime calendar = new DateTime();
	OrderActivity.a(calendar, 20, OrderActivity.C(this.a));
	OrderActivity.a(calendar);
	OrderActivity.a(this.a, calendar);
	OrderActivity.E(this.a);
	this.a.showDialog(0);
	this.a.removeDialog(15);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ib.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */