using System.Collections.Generic;

namespace ru.yandex.taxi.activity
{
	using ListActivity = android.app.ListActivity;
	using ContentResolver = android.content.ContentResolver;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using Cursor = android.database.Cursor;
	using Uri = android.net.Uri;
	using Bundle = android.os.Bundle;
	using Parcelable = android.os.Parcelable;
	using TextWatcher = android.text.TextWatcher;
	using ContextMenu = android.view.ContextMenu;
	using KeyEvent = android.view.KeyEvent;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using AdapterView = android.widget.AdapterView;
	using EditText = android.widget.EditText;
	using FilterQueryProvider = android.widget.FilterQueryProvider;
	using ListAdapter = android.widget.ListAdapter;
	using ListView = android.widget.ListView;
	using SimpleCursorAdapter = android.widget.SimpleCursorAdapter;
	using TextView = android.widget.TextView;
	using Toast = android.widget.Toast;
	using ma;
	using mb;
	using mc;
	using md;
	using mg;
	using mh;
	using mi;
	using ml;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using MapUtils = ru.yandex.taxi.map.MapUtils;
	using YandexSuggestProvider = ru.yandex.taxi.suggest.YandexSuggestProvider;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class SearchStreetActivity : ListActivity
	{
	  public const string CITY_NAME = "city name";

	  public const string EDIT_AFTER_SEARCH = "edit after search";

	  public const string FINAL_SELECT = "final select";

	  public const string GEO_OBJECT = "geo object";

	  public const string ONLY_SUGGEST = "only suggest";

	  public const int SEARCH_LIST_RESULT = 0;

	  public const string SELECTED_LOCATION = "selected location";

	  public const string SELECT_POINT = "select point";

	  public const string STREET_NAME = "street name";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string[] a_Conflict = new string[] {"_id", "suggest_text_1", "suggest_text_2"};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private long b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool d_Conflict;

	  private GeoPoint e;

	  private Cursor f;

	  private List<GeocodeJsonObject> g = new List<GeocodeJsonObject>();

	  private int h;

	  private int i;

	  private bool j;

	  private bool k;

	  private GeoPoint l;

	  private ListView m;

	  private EditText n;

	  private bool o;

	  private double p = 0.8D;

	  private void a()
	  {
		(new md(this)).execute((object[])new string[0]);
	  }

	  private void a(Cursor paramCursor, string[] paramArrayOfString, int paramInt, FilterQueryProvider paramFilterQueryProvider)
	  {
		mi mi = new mi(this, getApplicationContext(), paramInt, paramCursor, paramArrayOfString, new int[] {2131558473});
		if (paramFilterQueryProvider != null)
		{
		  mi.setFilterQueryProvider(paramFilterQueryProvider);
		}
		ListAdapter listAdapter = this.m.getAdapter();
		if (listAdapter != null)
		{
		  Cursor cursor = ((SimpleCursorAdapter)listAdapter).getCursor();
		  if (cursor != null)
		  {
			cursor.close();
		  }
		}
		this.m.setAdapter((ListAdapter)mi);
		this.m.setOnTouchListener((View.OnTouchListener)new mh(this));
	  }

	  private void a(GeocodeJsonObject paramGeocodeJsonObject)
	  {
		EditAddressActivity.saveStreetHistory(-1L, getContentResolver(), this.i, paramGeocodeJsonObject, false, false);
		Intent intent = new Intent();
		intent.putExtra("address", (Parcelable)paramGeocodeJsonObject);
		setResult(3, intent);
		finish();
	  }

	  private void a(GeocodeJsonObject paramGeocodeJsonObject, long paramLong)
	  {
		Intent intent = new Intent((Context)this, typeof(EditAddressActivity));
		intent.putExtra("address", (Parcelable)paramGeocodeJsonObject);
		intent.putExtra("type", this.h);
		intent.putExtra("from city", paramGeocodeJsonObject.City);
		intent.putExtra("address id", paramLong);
		startActivityForResult(intent, 2);
	  }

	  private void a(GeoPoint paramGeoPoint)
	  {
		Intent intent = new Intent((Context)this, typeof(SelectPointActivity));
		intent.putExtra("type", this.h);
		intent.putExtra("init location", (Parcelable)paramGeoPoint);
		intent.putExtra("final select", this.k);
		startActivityForResult(intent, 0);
	  }

	  private void b()
	  {
		this.f = getContentResolver().query(StaticDataScheme.HistoryTable.CONTENT_URI, new string[] {"_id", "name", "value", "point"}, "type = 4", null, "last_use DESC");
	  }

	  private Cursor c()
	  {
		Cursor cursor = getContentResolver().query(YandexSuggestProvider.CONTENT_URI, this.a_Conflict, null, new string[] {""}, "suggest_text_1 ASC");
		ml ml = new ml(this);
		a(cursor, new string[] {"suggest_text_1", "suggest_text_2"}, 2130903064, (FilterQueryProvider)ml);
		return cursor;
	  }

	  private void d()
	  {
		ContentResolver contentResolver = getContentResolver();
		Uri uri = StaticDataScheme.HistoryTable.CONTENT_URI;
		string str = "type = " + this.i;
		a(contentResolver.query(uri, new string[] {"_id", "name", "value", "point"}, str, null, "last_use DESC"), new string[] {"name", "point"}, 2130903065, (FilterQueryProvider)null);
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		if (3 == paramInt2)
		{
		  setResult(3, paramIntent);
		  finish();
		}
		if (paramInt2 != 0)
		{
		  GeocodeJsonObject geocodeJsonObject;
		  switch (paramInt1)
		  {
			default:
			  return;
			case 0:
			  switch (paramInt2)
			  {
				default:
				  a((GeocodeJsonObject)paramIntent.getExtras().getParcelable("selected location"), -1L);
					goto case -1;
				case -1:
				  setResult(-1, paramIntent);
				  finish();
					goto case 2;
				case 2:
				  break;
			  }
			  geocodeJsonObject = (GeocodeJsonObject)paramIntent.getExtras().getParcelable("selected location");
			  if (geocodeJsonObject.Exact || this.k)
			  {
				geocodeJsonObject.Exact = true;
				a(geocodeJsonObject);
			  }
			  geocodeJsonObject.Exact = true;
			  a(geocodeJsonObject, -1L);
				goto case 1;
			case 1:
			case 2:
			  break;
		  }
		  d();
		  setResult(-1, (Intent)geocodeJsonObject);
		  finish();
		}
		if (this.j)
		{
		  setResult(0);
		  finish();
		}
	  }

	  public virtual bool onContextItemSelected(MenuItem paramMenuItem)
	  {
		switch (paramMenuItem.getItemId())
		{
		  default:
			return true;
		  case 0:
			break;
		}
		long l = this.b_Conflict;
		getContentResolver().delete(StaticDataScheme.HistoryTable.CONTENT_URI, "_id = " + l, null);
		b();
		d();
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		int i;
		base.onCreate(paramBundle);
		setContentView(2130903059);
		getWindow().setFormat(1);
		GeocodeJsonObject geocodeJsonObject = MapUtils.getUserLocation((Context)this);
		if (geocodeJsonObject != null)
		{
		  this.e = geocodeJsonObject.GeoPoint;
		}
		ma ma = new ma(this);
		if (geocodeJsonObject == null || "Москва".Equals(geocodeJsonObject.City))
		{
		  foreach (string str1 in getResources().getStringArray(2131165187))
		  {
			this.g.Add(new GeocodeJsonObject(str1));
		  }
		}
		else if (ma.Contains(str1.getCity()))
		{
		  foreach (string str1 in getResources().getStringArray(2131165188))
		  {
			this.g.Add(new GeocodeJsonObject(str1));
		  }
		}
		this.m = getListView();
		this.n = (EditText)findViewById(2131558479);
		this.n.requestFocus();
		this.n.setImeOptions(3);
		this.n.setOnEditorActionListener((TextView.OnEditorActionListener)new mb(this));
		this.n.setOnTouchListener((View.OnTouchListener)new mc(this));
		registerForContextMenu((View)this.m);
		string str2 = "";
		Bundle bundle = getIntent().getExtras();
		str1 = str2;
		if (bundle != null)
		{
		  str1 = str2;
		  if (bundle.containsKey("type"))
		  {
			this.h = bundle.getInt("type");
			if (this.h == 0)
			{
			  i = 1;
			}
			else
			{
			  i = 3;
			}
			this.i = i;
			bundle.getString("city name");
			str1 = bundle.getString("street name");
			this.d_Conflict = bundle.getBoolean("only suggest", false);
			this.j = bundle.getBoolean("select point", false);
			this.k = bundle.getBoolean("final select", false);
			this.l = (GeoPoint)bundle.getParcelable("init location");
			bundle.getBoolean("edit after search");
			GeocodeJsonObject geocodeJsonObject1 = (GeocodeJsonObject)bundle.getParcelable("selected location");
			if (geocodeJsonObject1 != null)
			{
			  this.d_Conflict = true;
			  str1 = geocodeJsonObject1.Name;
			}
			this.c_Conflict = this.d_Conflict;
		  }
		}
		b();
		if (this.d_Conflict)
		{
		  c();
		  getWindow().setSoftInputMode(5);
		}
		else
		{
		  d();
		  if (this.h == 0)
		  {
			i = 2131296423;
		  }
		  else
		  {
			i = 2131296424;
		  }
		  setTitle(i);
		}
		this.n.addTextChangedListener((TextWatcher)new mg(this));
		this.n.setText(str1);
		EditText editText = this.n;
		if (str1 == null)
		{
		  i = 0;
		}
		else
		{
		  i = str1.length();
		}
		editText.setSelection(i);
		if (this.j)
		{
		  a(this.l);
		}
	  }

	  public virtual void onCreateContextMenu(ContextMenu paramContextMenu, View paramView, ContextMenu.ContextMenuInfo paramContextMenuInfo)
	  {
		base.onCreateContextMenu(paramContextMenu, paramView, paramContextMenuInfo);
		AdapterView.AdapterContextMenuInfo adapterContextMenuInfo = (AdapterView.AdapterContextMenuInfo)paramContextMenuInfo;
		if (adapterContextMenuInfo.position > 0 && adapterContextMenuInfo.id > 0L)
		{
		  ContentResolver contentResolver = getContentResolver();
		  Uri uri = StaticDataScheme.HistoryTable.CONTENT_URI;
		  string str = "_id = " + adapterContextMenuInfo.id;
		  Cursor cursor = contentResolver.query(uri, new string[] {"name"}, str, null, null);
		  cursor.moveToFirst();
		  str = cursor.getString(0);
		  cursor.close();
		  this.b_Conflict = adapterContextMenuInfo.id;
		  paramContextMenu.add(0, 0, 0, 2131296343);
		  paramContextMenu.setHeaderTitle(str);
		}
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

	  protected internal virtual void onListItemClick(ListView paramListView, View paramView, int paramInt, long paramLong)
	  {
		GeoPoint geoPoint;
		paramListView = null;
		int i = 0;
		Cursor cursor = ((SimpleCursorAdapter)this.m.getAdapter()).getCursor();
		if (this.c_Conflict)
		{
		  if (cursor != null && cursor.getCount() != 0)
		  {
			cursor.moveToPosition(paramInt);
			string str = ((string)this.m.getAdapter().getItem(paramInt)).replaceAll("--", ",");
			this.n.setText(str);
			this.n.setSelection(str.Length);
			a();
		  }
		}
		if (paramInt > 2)
		{
		  GeocodeJsonObject geocodeJsonObject1;
		  int k;
		  int j = this.f.getCount();
		  if (j > 0)
		  {
			k = j + 1;
		  }
		  else
		  {
			k = 0;
		  }
		  k += true;
		  if (j != 0 && paramInt < j + 3)
		  {
			this.f.moveToPosition(paramInt - 3);
			paramInt = this.f.getInt(this.f.getColumnIndex("_id"));
			geocodeJsonObject1 = new GeocodeJsonObject(this.f.getString(this.f.getColumnIndex("value")));
		  }
		  else if (this.g.Count != 0 && paramInt > k && paramInt <= k + this.g.Count)
		  {
			List<GeocodeJsonObject> arrayList = this.g;
			if (j > 0)
			{
			  k = j + 1;
			}
			else
			{
			  k = 0;
			}
			geocodeJsonObject1 = arrayList[paramInt - 3 - k];
			geocodeJsonObject1.setAirport(true);
			this.o = true;
			paramInt = -1;
		  }
		  else if (paramLong != 0L)
		  {
			if (j > 0)
			{
			  k = j + 1;
			}
			else
			{
			  k = 0;
			}
			if (this.g.Count > 0)
			{
			  i = this.g.Count + 1;
			}
			cursor.moveToPosition(paramInt - 3 - k - i);
			paramInt = cursor.getInt(cursor.getColumnIndex("_id"));
			geocodeJsonObject1 = new GeocodeJsonObject(cursor.getString(cursor.getColumnIndex("value")));
		  }
		  else
		  {
			paramInt = -1;
		  }
		  if (geocodeJsonObject1 != null)
		  {
			if (this.o)
			{
			  a(geocodeJsonObject1, paramInt);
			}
			a(geocodeJsonObject1);
		  }
		}
		GeocodeJsonObject geocodeJsonObject = MapUtils.getUserLocation(getApplicationContext());
		switch (paramInt)
		{
		  default:
			return;
		  case 0:
			if (geocodeJsonObject != null && !string.ReferenceEquals(geocodeJsonObject.Street, null) && !"".Equals(geocodeJsonObject.Street))
			{
			  a(geocodeJsonObject, -1L);
			}
			Toast.makeText((Context)this, 2131296284, 0).show();
			  goto case 1;
		  case 1:
			break;
		}
		if (this.l != null)
		{
		  geoPoint = this.l;
		}
		else if (geoPoint != null)
		{
		  geoPoint = geoPoint.getGeoPoint();
		}
		else
		{
		  geoPoint = null;
		}
		a(geoPoint);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\SearchStreetActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}