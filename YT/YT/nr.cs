using Context = android.content.Context;
using Intent = android.content.Intent;
using View = android.view.View;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;
using TariffListActivity = ru.yandex.taxi.activity.TariffListActivity;

internal class nr : View.OnClickListener
{
  internal nr(nq paramnq, nu paramnu)
  {
  }

  public virtual void onClick(View paramView)
  {
	Intent intent = new Intent((Context)this.b.a, typeof(ParkInfoActivity));
	intent.putExtra("type", 0);
	intent.putExtra("park id", this.a.a);
	intent.putExtra("tariff limits", (Serializable)TariffListActivity.a(this.b.a));
	intent.putExtra("when", TariffListActivity.i(this.b.a));
	this.b.a.startActivity(intent);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */