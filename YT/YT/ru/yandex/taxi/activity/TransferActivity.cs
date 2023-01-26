using System.Collections;

namespace ru.yandex.taxi.activity
{
	using ListActivity = android.app.ListActivity;
	using Bundle = android.os.Bundle;
	using ListAdapter = android.widget.ListAdapter;
	using ListView = android.widget.ListView;
	using oz;

	public class TransferActivity : ListActivity
	{
	  public const string CURRENCY = "currency";

	  public const string NAME = "name";

	  public const string TRANSFERS = "transfers";

	  private ListView a;

	  private string b;

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903080);
		setTitle(getIntent().getStringExtra("name"));
		this.a = getListView();
		this.b = getIntent().getStringExtra("currency");
		ArrayList arrayList = (ArrayList)getIntent().getSerializableExtra("transfers");
		this.a.setAdapter((ListAdapter)new oz(this, arrayList));
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\TransferActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}