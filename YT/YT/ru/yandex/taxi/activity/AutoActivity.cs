namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using Intent = android.content.Intent;
	using Uri = android.net.Uri;
	using Bundle = android.os.Bundle;
	using PreferenceManager = android.preference.PreferenceManager;
	using LayoutInflater = android.view.LayoutInflater;
	using Menu = android.view.Menu;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using LinearLayout = android.widget.LinearLayout;
	using TextView = android.widget.TextView;
	using gb;
	using gc;
	using gd;
	using ge;
	using gf;
	using Driver = ru.yandex.taxi.data.Driver;

	public class AutoActivity : Activity
	{
	  public const string DRIVER = "driver";

	  public const int MENU_ITEM_CALL = 3;

	  public const string TARIFF_NAME = "tariff name";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private Driver a_Conflict;

	  private string b;

	  private static void a(ViewGroup paramViewGroup, LayoutInflater paramLayoutInflater, 
		  int? paramInteger, int paramInt, string paramString, View.OnClickListener paramOnClickListener)
	  {
		if (!string.ReferenceEquals(paramString, null) && !"".Equals(paramString) && !"null".Equals(paramString))
		{
		  View view = paramLayoutInflater.inflate(2130903076, null);
		  if (paramInteger != null)
		  {
			view.setBackgroundResource(paramInteger.Value);
		  }
		  ((TextView)view.findViewById(2131558403)).setText(paramInt);
		  ((TextView)view.findViewById(2131558457)).setText(paramString);
		  view.setOnClickListener(paramOnClickListener);
		  paramViewGroup.addView(view);
		}
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903075);
		paramBundle = getIntent().getExtras();
		if (paramBundle != null && paramBundle.containsKey("driver"))
		{
		  this.a_Conflict = (Driver)paramBundle.getSerializable("driver");
		  this.b = paramBundle.getString("tariff name");
		  LinearLayout linearLayout = (LinearLayout)findViewById(2131558442);
		  LayoutInflater layoutInflater = (LayoutInflater)getSystemService("layout_inflater");
		  getResources();
		  a((ViewGroup)linearLayout, layoutInflater, (int?)null, 2131296553, 
			  this.a_Conflict.model, (View.OnClickListener)new gb());
		  a((ViewGroup)linearLayout, layoutInflater, (int?)null, 2131296561, 
			  this.a_Conflict.color, (View.OnClickListener)new gc());
		  a((ViewGroup)linearLayout, layoutInflater, (int?)null, 2131296562,
			  this.a_Conflict.plates, (View.OnClickListener)new gd());
		  a((ViewGroup)linearLayout, layoutInflater, (int?)null, 2131296563, 
			  this.a_Conflict.name, (View.OnClickListener)new ge());
		  a((ViewGroup)linearLayout, layoutInflater, (int?)null, 2131296541, 
			  this.b, (View.OnClickListener)new gf());
		  return;
		}
		finish();
	  }

	  public virtual bool onCreateOptionsMenu(Menu paramMenu)
	  {
		if (!string.ReferenceEquals(this.a_Conflict.phone, null))
		{
		  paramMenu.add(0, 3, 0, 2131296280).setIcon(2130837603);
		}
		return true;
	  }

	  public virtual bool onOptionsItemSelected(MenuItem paramMenuItem)
	  {
		switch (paramMenuItem.getItemId())
		{
		  default:
			return true;
		  case 3:
			break;
		}
		startActivity(new Intent("android.intent.action.CALL", Uri.parse("tel:" + this.a_Conflict.phone)));
	  }

	  protected internal virtual void onStart()
	  {
		base.onStart();
		if (PreferenceManager.getDefaultSharedPreferences(getApplicationContext())
				.getBoolean("notification call", false))
		{
		  finish();
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\AutoActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}