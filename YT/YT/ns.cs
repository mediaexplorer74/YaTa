using CompoundButton = android.widget.CompoundButton;
using TariffListActivity = ru.yandex.taxi.activity.TariffListActivity;
using Park = ru.yandex.taxi.data.Park;

internal class ns : CompoundButton.OnCheckedChangeListener
{
  internal ns(nq paramnq, int paramInt, Park paramPark)
  {
  }

  public virtual void onCheckedChanged(CompoundButton paramCompoundButton, bool paramBoolean)
  {
	TariffListActivity.k(this.c.a)[this.a] = paramBoolean;
	if (paramBoolean)
	{
	  TariffListActivity.a(this.c.a).removeExcludePark(this.b.getParkId());
	  return;
	}
	TariffListActivity.a(this.c.a).addExcludePark(this.b.getParkId());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ns.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */