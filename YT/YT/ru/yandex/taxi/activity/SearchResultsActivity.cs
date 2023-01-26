using System;

namespace ru.yandex.taxi.activity
{
	using TabActivity = android.app.TabActivity;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using Build = android.os.Build;
	using Bundle = android.os.Bundle;
	using Log = android.util.Log;
	using KeyEvent = android.view.KeyEvent;
	using LayoutInflater = android.view.LayoutInflater;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using AdapterView = android.widget.AdapterView;
	using ImageView = android.widget.ImageView;
	using ListAdapter = android.widget.ListAdapter;
	using ListView = android.widget.ListView;
	using TabHost = android.widget.TabHost;
	using TextView = android.widget.TextView;
	using lv;
	using lw;
	using lx;
	using ly;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using EndlessAdapter = ru.yandex.taxi.ui.wheel.adapters.EndlessAdapter;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class SearchResultsActivity : TabActivity, AdapterView.OnItemClickListener
	{
	  public const string ADDRESSES = "addresses";

	  public const string DEFAULT_VIEW = "default view";

	  public const string ORGANIZATIONS = "organizations";

	  public const string QUERY = "query";

	  public const string USER_POINT = "user point";

	  private static System.Reflection.MethodInfo i;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private GeoPoint a_Conflict;

	  private string b;

	  private int c;

	  private string d = "addresses";

	  private GeocodeJsonObject e;

	  private GeocodeJsonObject f;

	  private TaxiClient g;

	  private TabHost h;

	  private void a()
	  {
		this.h.getTabWidget().setVisibility(8);
		findViewById(2131558458).setVisibility(8);
	  }

	  private void a(int paramInt1, string paramString, int paramInt2)
	  {
		TabHost.TabSpec tabSpec = this.h.newTabSpec(paramString);
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
		  ((ImageView)view.findViewById(2131558429)).setVisibility(8);
		  try
		  {
			if (i == null)
			{
			  System.Reflection.MethodInfo method = typeof(TabHost.TabSpec).GetMethod("setIndicator", new Type[] {typeof(View)});
			  i = method;
			  method.setAccessible(true);
			}
			i.invoke(tabSpec, new object[] {view});
		  }
		  catch (Exception exception)
		  {
			Log.e("SearchResultsActivity", "Fail set tab indicator by reflection", exception);
		  }
		}
		tabSpec.setContent(paramInt2);
		this.h.addTab(tabSpec);
	  }

	  private void a(GeocodeJsonObject paramGeocodeJsonObject, int paramInt)
	  {
		if (paramGeocodeJsonObject != null)
		{
		  ly ly = new ly(this, getApplicationContext(), 2130903056, 2131558473, paramGeocodeJsonObject);
		  ((ListView)findViewById(paramInt)).setAdapter((ListAdapter)new lv(this, getApplicationContext(), (ListAdapter)ly, 2130903052, ly));
		}
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		switch (paramInt2)
		{
		  default:
			return;
		  case -1:
		  case 3:
			break;
		}
		setResult(3, paramIntent);
		finish();
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903057);
		getWindow().setFormat(1);
		((ListView)findViewById(2131558476)).setOnItemClickListener(this);
		((ListView)findViewById(2131558477)).setOnItemClickListener(this);
		this.h = getTabHost();
		a(2131296344, "addresses", 2131558476);
		a(2131296345, "organizations", 2131558477);
		this.h.setCurrentTab(1);
		this.h.setCurrentTab(0);
		this.h.setOnTabChangedListener((TabHost.OnTabChangeListener)new lx());
		findViewById(2131558476);
		findViewById(2131558477);
		if (paramBundle == null)
		{
		  paramBundle = getIntent().getExtras();
		  this.c = paramBundle.getInt("type");
		  this.a_Conflict = (GeoPoint)paramBundle.getParcelable("user point");
		  this.e = (GeocodeJsonObject)paramBundle.getParcelable("addresses");
		  this.f = (GeocodeJsonObject)paramBundle.getParcelable("organizations");
		  this.b = paramBundle.getString("query");
		  this.d = paramBundle.getString("default view");
		  if (!string.ReferenceEquals(this.d, null) && this.h.getTabWidget().getTabCount() > 1)
		  {
			bool @bool;
			TabHost tabHost = this.h;
			if (this.d.Equals("addresses"))
			{
			  @bool = false;
			}
			else
			{
			  @bool = true;
			}
			tabHost.setCurrentTab(@bool);
		  }
		  this.g = new TaxiClient((Context)this, (HttpUtils)new HttpUrlConnectionUtils());
		  a(this.e, 2131558476);
		  a(this.f, 2131558477);
		  if (this.e.Count == 0)
		  {
			this.h.setCurrentTab(1);
			a();
			return;
		  }
		}
		else
		{
		  return;
		}
		if (this.f.Count == 0)
		{
		  a();
		}
	  }

	  public virtual void onItemClick<T1>(AdapterView<T1> paramAdapterView, View paramView, int paramInt, long paramLong)
	  {
		GeocodeJsonObject geocodeJsonObject = ((ly)((EndlessAdapter)paramAdapterView.getAdapter()).WrappedAdapter).a().getObject(paramInt);
		(new lw(this)).execute((object[])new GeocodeJsonObject[] {geocodeJsonObject});
	  }

	  public virtual bool onKeyDown(int paramInt, KeyEvent paramKeyEvent)
	  {
		switch (paramInt)
		{
		  default:
			return base.onKeyDown(paramInt, paramKeyEvent);
		  case 4:
			break;
		}
		setResult(0);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\SearchResultsActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}