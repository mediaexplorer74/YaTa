using Intent = android.content.Intent;
using View = android.view.View;
using Utils = ru.yandex.taxi.Utils;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class or : View.OnClickListener
{
  public or(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	string str;
	if (TaxiOnTheWayToSourceActivity.d(this.a) > 0)
	{
	  str = String.format(this.a.getString(2131296333), new object[] {Utils.getWord(this.a.getResources().getStringArray(2131165194), TaxiOnTheWayToSourceActivity.d(this.a))});
	}
	else
	{
	  str = this.a.getResources().getString(2131296334);
	}
	Intent intent = new Intent("android.intent.action.SEND");
	intent.setType("text/plain");
	intent.putExtra("android.intent.extra.SUBJECT", this.a.getString(2131296332));
	intent.putExtra("android.intent.extra.TEXT", str);
	this.a.startActivity(Intent.createChooser(intent, this.a.getString(2131296331)));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\or.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */