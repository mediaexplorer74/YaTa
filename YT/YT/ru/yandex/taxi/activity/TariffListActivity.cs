using System;

namespace ru.yandex.taxi.activity
{
	using ListActivity = android.app.ListActivity;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using SharedPreferences = android.content.SharedPreferences;
	using ColorStateList = android.content.res.ColorStateList;
	using Bundle = android.os.Bundle;
	using PreferenceManager = android.preference.PreferenceManager;
	using Menu = android.view.Menu;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using Button = android.widget.Button;
	using ListView = android.widget.ListView;
	using ProgressBar = android.widget.ProgressBar;
	using nn;
	using no;
	using np;
	using nv;
	using Analytics = ru.yandex.taxi.analytics.Analytics;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using Requirements = ru.yandex.taxi.data.Requirements;
	using Tariff = ru.yandex.taxi.data.Tariff;
	using TariffLimits = ru.yandex.taxi.data.TariffLimits;

	public class TariffListActivity : ListActivity
	{
	  public const string CLASSES = "classes";

	  public const string EXCLUDED_PARKS = "excluded parks";

	  public const string TARIFF_LIMITS = "tariff limits";

	  public const string WHEN = "when";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private TariffLimits a_Conflict = new TariffLimits();

	  private Requirements b;

	  private int c = 3;

	  private TaxiClient d;

	  private bool e;

	  private DateTime f;

	  private bool[] g = new bool[0];

	  private Button h;

	  private Button i;

	  private Button j;

	  private ListView k;

	  private ProgressBar l;

	  private bool a()
	  {
		bool @bool = false;
		bool[] arrayOfBoolean = this.g;
		int i = arrayOfBoolean.Length;
		for (sbyte b = 0;; b++)
		{
		  bool bool1 = @bool;
		  if (b < i)
		  {
			if (arrayOfBoolean[b])
			{
			  return true;
			}
		  }
		  else
		  {
			return bool1;
		  }
		}
	  }

	  public virtual void finish()
	  {
		bool @bool;
		Intent intent = new Intent();
		TariffLimits tariffLimits = this.a_Conflict;
		if (!a())
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		tariffLimits.AllUnckecked = @bool;
		intent.putExtra("tariff limits", (Serializable)this.a_Conflict);
		intent.putExtra("requirements", (Serializable)this.b);
		setResult(-1, intent);
		base.finish();
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		if (-1 == paramInt2 || 3 == paramInt2)
		{
		  switch (paramInt1)
		  {
			default:
			  return;
			case 0:
			  break;
		  }
		  this.b = (Requirements)paramIntent.getSerializableExtra("requirements");
		}
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		ColorStateList colorStateList5;
		ColorStateList colorStateList4;
		ColorStateList colorStateList3;
		int j;
		int i = 2130837522;
		base.onCreate(paramBundle);
		Analytics.initExceptionHandler(getApplicationContext(), "ui");
		setContentView(2130903067);
		this.l = (ProgressBar)findViewById(2131558455);
		this.d = new TaxiClient(getApplicationContext(), (HttpUtils)new HttpUrlConnectionUtils());
		paramBundle = getIntent().getExtras();
		if (paramBundle != null)
		{
		  if (paramBundle.containsKey("tariff limits"))
		  {
			this.b = (Requirements)paramBundle.getSerializable("requirements");
			this.a_Conflict = (TariffLimits)paramBundle.getSerializable("tariff limits");
			this.c = this.a_Conflict.ClassesCount;
		  }
		  this.f = (DateTime)paramBundle.getSerializable("when");
		}
		this.e = Tariff.isDayNow(this.f);
		(new nv(this)).execute((object[])new int?[0]);
		this.h = (Button)findViewById(2131558489);
		this.i = (Button)findViewById(2131558490);
		this.j = (Button)findViewById(2131558491);
		ColorStateList colorStateList1 = getResources().getColorStateList(2130837658);
		ColorStateList colorStateList2 = getResources().getColorStateList(2130837659);
		Button button3 = this.h;
		if (this.a_Conflict.Econom)
		{
		  j = 2130837522;
		}
		else
		{
		  j = 2130837519;
		}
		button3.setBackgroundResource(j);
		Button button4 = this.h;
		if (this.a_Conflict.Econom)
		{
		  colorStateList5 = colorStateList2;
		}
		else
		{
		  colorStateList5 = colorStateList1;
		}
		button4.setTextColor(colorStateList5);
		this.h.setOnClickListener((View.OnClickListener)new nn(this, colorStateList2, colorStateList1));
		Button button2 = this.i;
		if (this.a_Conflict.Norm)
		{
		  j = 2130837522;
		}
		else
		{
		  j = 2130837519;
		}
		button2.setBackgroundResource(j);
		button4 = this.i;
		if (this.a_Conflict.Norm)
		{
		  colorStateList4 = colorStateList2;
		}
		else
		{
		  colorStateList4 = colorStateList1;
		}
		button4.setTextColor(colorStateList4);
		this.i.setOnClickListener((View.OnClickListener)new no(this, colorStateList2, colorStateList1));
		Button button1 = this.j;
		if (this.a_Conflict.Business)
		{
		  j = i;
		}
		else
		{
		  j = 2130837519;
		}
		button1.setBackgroundResource(j);
		button4 = this.j;
		if (this.a_Conflict.Business)
		{
		  colorStateList3 = colorStateList2;
		}
		else
		{
		  colorStateList3 = colorStateList1;
		}
		button4.setTextColor(colorStateList3);
		this.j.setOnClickListener((View.OnClickListener)new np(this, colorStateList2, colorStateList1));
		this.k = getListView();
	  }

	  public virtual bool onCreateOptionsMenu(Menu paramMenu)
	  {
		paramMenu.add(0, 0, 0, 2131296393).setIcon(2130837606);
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
		Intent intent = new Intent((Context)this, typeof(RequirementsActivity));
		intent.putExtra("requirements", (Serializable)this.b);
		intent.putExtra("rush order", true);
		startActivityForResult(intent, 0);
	  }

	  protected internal virtual void onStop()
	  {
		bool @bool;
		TariffLimits tariffLimits = this.a_Conflict;
		if (!a())
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		tariffLimits.AllUnckecked = @bool;
		SharedPreferences.Editor editor = PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).edit();
		editor.putString("excluded parks", this.a_Conflict.ExcludedParksString);
		editor.putString("classes", this.a_Conflict.ClassesString);
		editor.putString("requirements", this.b.RequirementsString).commit();
		editor.commit();
		base.onStop();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\TariffListActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}