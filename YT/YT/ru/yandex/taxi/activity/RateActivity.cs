using System.Threading;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using ContentResolver = android.content.ContentResolver;
	using SharedPreferences = android.content.SharedPreferences;
	using Bundle = android.os.Bundle;
	using Environment = android.os.Environment;
	using PreferenceManager = android.preference.PreferenceManager;
	using TextWatcher = android.text.TextWatcher;
	using Menu = android.view.Menu;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using Button = android.widget.Button;
	using EditText = android.widget.EditText;
	using RatingBar = android.widget.RatingBar;
	using TextView = android.widget.TextView;
	using kz;
	using la;
	using lb;
	using lc;
	using lf;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;

	public class RateActivity : Activity
	{
	  public const string PARK_ID = "park id";

	  public const string PARK_NAME = "taxi name";

	  private bool a;

	  private bool b;

	  private string c;

	  private string d;

	  private string e;

	  private string f;

	  private Button g;

	  public virtual void finish()
	  {
		if (this.b)
		{
		  PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).edit().putBoolean("notification call", true).commit();
		}
		base.finish();
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903053);
		getWindow().setFormat(1);
		SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
		this.d = sharedPreferences.getString("client id", "");
		sharedPreferences.edit().remove("last order date").commit();
		Bundle bundle = getIntent().getExtras();
		if (bundle != null && bundle.containsKey("notification call"))
		{
		  sharedPreferences.edit().putBoolean("notification call", false).commit();
		  this.b = true;
		}
		if (bundle != null && !sharedPreferences.getBoolean("notification call", false))
		{
		  this.a = bundle.getBoolean("demo");
		  this.e = bundle.getString("park id");
		  this.f = bundle.getString("order id");
		  if (bundle.containsKey("taxi name"))
		  {
			this.c = bundle.getString("taxi name");
		  }
		  else
		  {
			(new lf(this)).execute((object[])new string[] {this.e});
		  }
		  ContentResolver contentResolver = getContentResolver();
		  string str = bundle.getString("taxi logo");
		  if (!string.ReferenceEquals(str, null))
		  {
			File file = new File(Environment.getExternalStorageDirectory(), getResources().getString(2131296272));
			if (file.exists())
			{
			  File[] arrayOfFile = file.listFiles();
			  if (arrayOfFile != null)
			  {
				int i = arrayOfFile.Length;
				for (sbyte b = 0; b < i; b++)
				{
				  arrayOfFile[b].delete();
				}
			  }
			}
			contentResolver.delete(StaticDataScheme.CacheRequestTable.CONTENT_URI, "request = ?", new string[] {str});
		  }
		  contentResolver.delete(StaticDataScheme.CurrentOrderTable.CONTENT_URI, "order_id = ?", new string[] {this.f});
		}
		RatingBar ratingBar = (RatingBar)findViewById(2131558468);
		EditText editText = (EditText)findViewById(2131558407);
		editText.addTextChangedListener((TextWatcher)new la(this, ratingBar));
		ratingBar.setOnRatingBarChangeListener((RatingBar.OnRatingBarChangeListener)new lb(this, editText));
		if (!string.ReferenceEquals(this.c, null))
		{
		  ((TextView)findViewById(2131558467)).setText("«" + this.c + "»");
		}
		this.g = (Button)findViewById(2131558408);
		this.g.setEnabled(false);
		this.g.setOnClickListener((View.OnClickListener)new lc(this, editText, ratingBar));
		if (this.a)
		{
		  this.g.setEnabled(false);
		  editText.setEnabled(false);
		}
		if (this.a)
		{
		  findViewById(2131558459).setBackgroundResource(2130837551);
		  setTitle(getResources().getString(2131296275) + ": " + getTitle());
		  (new Thread((ThreadStart)new kz(this))).Start();
		}
	  }

	  public virtual bool onCreateOptionsMenu(Menu paramMenu)
	  {
		if (!this.a)
		{
		  paramMenu.add(0, 0, 0, 2131296321).setIcon(2130837611);
		}
		return true;
	  }

	  public virtual bool onOptionsItemSelected(MenuItem paramMenuItem)
	  {
		switch (paramMenuItem.getItemId())
		{
		  default:
			return true;
		  case 0:
			break;
		}
		finish();
	  }

	  protected internal virtual void onStart()
	  {
		base.onStart();
		if (PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).getBoolean("notification call", false))
		{
		  finish();
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\RateActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}