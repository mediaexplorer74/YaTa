using Context = android.content.Context;
using Intent = android.content.Intent;
using View = android.view.View;
using TransferActivity = ru.yandex.taxi.activity.TransferActivity;
using TransferListActivity = ru.yandex.taxi.activity.TransferListActivity;
using Tariff = ru.yandex.taxi.data.Tariff;

internal class pc : View.OnClickListener
{
  internal pc(pb parampb, int paramInt)
  {
  }

  public virtual void onClick(View paramView)
  {
	Intent intent = new Intent((Context)this.b.a, typeof(TransferActivity));
	intent.putExtra("currency", TransferListActivity.a(this.b.a));
	intent.putExtra("transfers", ((Tariff.Transfer)pb.a(this.b).get(this.a)).price);
	intent.putExtra("name", ((Tariff.Transfer)pb.a(this.b).get(this.a)).name);
	this.b.a.startActivity(intent);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */