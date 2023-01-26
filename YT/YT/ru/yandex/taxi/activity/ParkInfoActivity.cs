using System;

namespace ru.yandex.taxi.activity
{
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using TabActivity = android.app.TabActivity;
	using ContentValues = android.content.ContentValues;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Intent = android.content.Intent;
	using SharedPreferences = android.content.SharedPreferences;
	using Build = android.os.Build;
	using Bundle = android.os.Bundle;
	using PreferenceManager = android.preference.PreferenceManager;
	using Html = android.text.Html;
	using Log = android.util.Log;
	using LayoutInflater = android.view.LayoutInflater;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using AdapterView = android.widget.AdapterView;
	using Button = android.widget.Button;
	using ImageView = android.widget.ImageView;
	using ListAdapter = android.widget.ListAdapter;
	using ListView = android.widget.ListView;
	using Spinner = android.widget.Spinner;
	using SpinnerAdapter = android.widget.SpinnerAdapter;
	using TabHost = android.widget.TabHost;
	using TextView = android.widget.TextView;
	using kd;
	using ke;
	using kf;
	using kg;
	using kh;
	using ki;
	using kj;
	using kk;
	using kl;
	using km;
	using kn;
	using ko;
	using kp;
	using kq;
	using ks;
	using kx;
	using Utils = ru.yandex.taxi.Utils;
	using Analytics = ru.yandex.taxi.analytics.Analytics;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using Park = ru.yandex.taxi.data.Park;
	using Requirements = ru.yandex.taxi.data.Requirements;
	using Tariff = ru.yandex.taxi.data.Tariff;
	using TariffLimits = ru.yandex.taxi.data.TariffLimits;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

	public class ParkInfoActivity : TabActivity
	{
	  public const string ORDER_ID = "order id";

	  public const string PARK_ID = "park id";

	  public const int RESULT_ORDER_REQUESTED = 10;

	  public const string TARIFF_ID = "tariff id";

	  public const string TARIFF_LIMITS = "tariff limits";

	  public const string TYPE = "type";

	  public const int TYPE_ORDER = 2;

	  public const int TYPE_TARIFF_LIST = 0;

	  public const int TYPE_TAXI_LIST = 1;

	  private static System.Reflection.MethodInfo q;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private int a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private TariffLimits b_Conflict;

	  private string c;

	  private string d;

	  private string e;

	  private Park f = new Park();

	  private int g;

	  private int h;

	  private TaxiClient i;

	  private GeocodeJsonObject j;

	  private GeocodeJsonObject k;

	  private Requirements l;

	  private DateTime m;

	  private LayoutInflater n;

	  private TabHost o;

	  private Spinner p;

	  private void a()
	  {
		(new kf(this)).execute((object[])new int?[0]);
	  }

	  private void a(int paramInt)
	  {
		ListView listView = (ListView)this.o.getCurrentView().findViewById(2131558463);
		if (this.p.getSelectedItemPosition() >= 0 && this.p.getSelectedItemPosition() < this.f.TariffsCount)
		{
		  listView.setAdapter((ListAdapter)new ks(this, this.f.getTariff(this.p.getSelectedItemPosition()), paramInt));
		}
	  }

	  private void a(int paramInt1, int paramInt2, string paramString)
	  {
		TabHost.TabSpec tabSpec = this.o.newTabSpec(paramString);
		if ("3".Equals(Build.VERSION.SDK))
		{
		  tabSpec.setIndicator(getResources().getString(paramInt1));
		}
		else
		{
		  View view = LayoutInflater.from((Context)this).inflate(2130903066, (ViewGroup)getTabWidget(), false);
		  TextView textView = (TextView)view.findViewById(2131558430);
		  textView.setTextColor(getResources().getColorStateList(2130837654));
		  textView.setText(paramInt1);
		  ((ImageView)view.findViewById(2131558429)).setImageResource(paramInt2);
		  try
		  {
			if (q == null)
			{
			  System.Reflection.MethodInfo method = typeof(TabHost.TabSpec).GetMethod("setIndicator", new Type[] {typeof(View)});
			  q = method;
			  method.setAccessible(true);
			}
			q.invoke(tabSpec, new object[] {view});
		  }
		  catch (Exception exception)
		  {
			Log.e("ParkInfoActivity", "Fail set tab indicator by reflection", exception);
		  }
		}
		tabSpec.setContent(2131558463);
		this.o.addTab(tabSpec);
	  }

	  private string b()
	  {
		string str1 = PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).getString("phone number", "");
		string str2 = "";
		if (str1.Length > 0)
		{
		  str2 = Utils.getFormatedPhoneNumber(str1);
		}
		return str2;
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		if (-1 == paramInt2)
		{
		  switch (paramInt1)
		  {
			default:
			  if (paramInt1 == 1)
			  {
				setResult(10);
				finish();
			  }
			  return;
			case 0:
			  break;
		  }
		  a();
		}
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		Analytics.initExceptionHandler(getApplicationContext(), "ui");
		setContentView(2130903051);
		this.n = (LayoutInflater)getSystemService("layout_inflater");
		paramBundle = getIntent().getExtras();
		this.h = paramBundle.getInt("type");
		this.c = paramBundle.getString("park id");
		this.e = paramBundle.getString("tariff id");
		this.d = paramBundle.getString("order id");
		this.b_Conflict = (TariffLimits)paramBundle.get("tariff limits");
		this.m = (DateTime)getIntent().getSerializableExtra("when");
		this.p = (Spinner)findViewById(2131558460);
		this.p.setSelection(0);
		this.p.setOnItemSelectedListener((AdapterView.OnItemSelectedListener)new kd(this));
		this.p.setOnTouchListener((View.OnTouchListener)new ki(this));
		findViewById(2131558461).setVisibility(8);
		this.o = getTabHost();
		a(2131296548, 2130837587, "day");
		a(2131296551, 2130837590, "night");
		this.g = 0;
		this.o.setCurrentTab(1);
		this.o.setCurrentTab(0);
		this.o.setOnTabChangedListener((TabHost.OnTabChangeListener)new kj(this));
		switch (this.h)
		{
		  default:
			if (getIntent().getExtras() != null)
			{
			  this.j = (GeocodeJsonObject)getIntent().getParcelableExtra("src point");
			  this.k = (GeocodeJsonObject)getIntent().getParcelableExtra("dest point");
			  this.l = (Requirements)getIntent().getSerializableExtra("requirements");
			}
			this.i = new TaxiClient(getApplicationContext(), (HttpUtils)new HttpUrlConnectionUtils());
			(new kq(this)).execute((object[])new int?[0]);
			return;
		  case 2:
			this.p.setVisibility(8);
			  goto case 0;
		  case 0:
			findViewById(2131558400).setVisibility(8);
			findViewById(2131558464).setVisibility(8);
			  goto case 1;
		  case 1:
			break;
		}
		((Button)findViewById(2131558465)).setOnClickListener((View.OnClickListener)new kk(this));
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		SharedPreferences sharedPreferences;
		Dialog dialog1;
		AlertDialog.Builder builder2;
		AlertDialog alertDialog2;
		Button button;
		Dialog dialog2 = null;
		switch (paramInt)
		{
		  default:
			return dialog2;
		  case 0:
			sharedPreferences = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
			if (!"".Equals(sharedPreferences.getString("phone number", "")) && sharedPreferences.getBoolean("authorized", false))
			{
			  paramInt = 1;
			}
			else
			{
			  paramInt = 0;
			}
			if (paramInt != 0)
			{
			  string str;
			  Dialog dialog4 = new Dialog((Context)this);
			  dialog4.setContentView(2130903063);
			  dialog4.setTitle(2131296404);
			  TextView textView = (TextView)dialog4.findViewById(2131558401);
			  if (this.j == null)
			  {
				str = String.format(getResources().getString(2131296436), new object[] {b()});
			  }
			  else
			  {
				str = String.format(getResources().getString(2131296435), new object[] {this.j.ShortAddress, b()});
			  }
			  textView.setText(str);
			  Button button1 = (Button)dialog4.findViewById(2131558448);
			  button1.setText(2131296552);
			  button1.setOnClickListener((View.OnClickListener)new ko(this));
			  button1 = (Button)dialog4.findViewById(2131558486);
			  button1.setText(2131296439);
			  button1.setOnClickListener((View.OnClickListener)new kp(this));
			  dialog4.findViewById(2131558487).setVisibility(8);
			  ((Button)dialog4.findViewById(2131558415)).setOnClickListener((View.OnClickListener)new ke(this));
			  Dialog dialog3 = dialog4;
			}
			dialog1 = new Dialog((Context)this);
			dialog1.setContentView(2130903063);
			dialog1.setTitle(2131296404);
			((TextView)dialog1.findViewById(2131558401)).setText(2131296437);
			dialog1.findViewById(2131558448).setVisibility(8);
			button = (Button)dialog1.findViewById(2131558486);
			button.setText(2131296440);
			button.setOnClickListener((View.OnClickListener)new kg(this));
			dialog1.findViewById(2131558487).setVisibility(8);
			((Button)dialog1.findViewById(2131558415)).setOnClickListener((View.OnClickListener)new kh(this));
			  goto case 1;
		  case 1:
			paramInt = this.a_Conflict;
			builder2 = new AlertDialog.Builder((Context)this);
			builder2.setTitle(2131296508).setMessage(paramInt).setPositiveButton(2131296446, (DialogInterface.OnClickListener)new kn(this)).setNegativeButton(2131296279, (DialogInterface.OnClickListener)new km(this));
			alertDialog2 = builder2.create();
			  goto case 2;
		  case 2:
			break;
		}
		AlertDialog.Builder builder1 = new AlertDialog.Builder((Context)this);
		builder1.setTitle(2131296402);
		builder1.setSingleChoiceItems((CharSequence[])this.f.getTariffList(), this.p.getSelectedItemPosition(), (DialogInterface.OnClickListener)new kl(this));
		AlertDialog alertDialog1 = builder1.create();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\ParkInfoActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}