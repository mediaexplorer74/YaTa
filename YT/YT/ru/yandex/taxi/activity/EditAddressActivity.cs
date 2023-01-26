using System;
using System.Collections.Generic;
using System.Threading;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using ProgressDialog = android.app.ProgressDialog;
	using ContentResolver = android.content.ContentResolver;
	using ContentValues = android.content.ContentValues;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Intent = android.content.Intent;
	using Cursor = android.database.Cursor;
	using Uri = android.net.Uri;
	using Bundle = android.os.Bundle;
	using Parcelable = android.os.Parcelable;
	using PreferenceManager = android.preference.PreferenceManager;
	using TextWatcher = android.text.TextWatcher;
	using KeyEvent = android.view.KeyEvent;
	using View = android.view.View;
	using InputMethodManager = android.view.inputmethod.InputMethodManager;
	using Button = android.widget.Button;
	using EditText = android.widget.EditText;
	using ImageView = android.widget.ImageView;
	using TextView = android.widget.TextView;
	using gr;
	using gs;
	using gt;
	using gv;
	using gw;
	using gx;
	using gy;
	using gz;
	using ha;
	using hf;
	using Analytics = ru.yandex.taxi.analytics.Analytics;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using MapUtils = ru.yandex.taxi.map.MapUtils;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class EditAddressActivity : Activity
	{
	  public const string ADDRESS = "address";

	  public const string ADDRESS_ID = "address id";

	  public const string FROM_CITY = "from city";

	  public const string TYPE = "type";

	  public const int TYPE_FROM = 0;

	  public const int TYPE_TO = 1;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private GeoPoint a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private GeoPoint b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool c_Conflict;

	  private bool d;

	  private string e;

	  private long f = -1L;

	  private List<string> g = new List<string>();

	  private int h = 0;

	  private ProgressDialog i;

	  private bool j;

	  private TaxiClient k;

	  private string l;

	  private bool m;

	  private EditText n;

	  private EditText o;

	  private EditText p;

	  private EditText q;

	  private EditText r;

	  private EditText s;

	  private EditText t;

	  private EditText u;

	  private EditText v;

	  private Button w;

	  private TextView x;

	  private ImageView y;

	  private void a(bool paramBoolean)
	  {
		int i;
		int j;
		if (paramBoolean)
		{
		  i = 2130837574;
		  j = getResources().getColor(2131230732);
		}
		else
		{
		  i = 2130837573;
		  j = -7829368;
		}
		this.m = paramBoolean;
		this.y.setImageResource(i);
		this.x.setTextColor(j);
	  }

	  private bool a()
	  {
		bool @bool = true;
		if ((this.h != 1 && !this.g.Contains(this.n.getText().ToString()) && (this.a_Conflict == null || CoordConversion.getDistance(this.a_Conflict, MapUtils.DEFAULT_POINT) >= 100000.0D)) || "".Equals(this.n.getText().ToString()))
		{
		  @bool = false;
		}
		return @bool;
	  }

	  private static bool a(ContentResolver paramContentResolver, string paramString)
	  {
		Cursor cursor = paramContentResolver.query(StaticDataScheme.HistoryTable.CONTENT_URI, new string[] {"_id"}, "name = ? AND type = 4", new string[] {paramString}, null);
		if (cursor.getCount() > 0)
		{
		  bool bool1 = true;
		  cursor.close();
		  return bool1;
		}
		bool @bool = false;
		cursor.close();
		return @bool;
	  }

	  private string b()
	  {
		return GeocodeJsonObject.getShortAddress(this.n.getText().ToString(), this.o.getText().ToString(), this.p.getText().ToString(), this.q.getText().ToString(), this.r.getText().ToString(), this.s.getText().ToString(), this.u.getText().ToString(), this.v.getText().ToString());
	  }

	  private static string b(GeocodeJsonObject paramGeocodeJsonObject)
	  {
		string str1 = paramGeocodeJsonObject.Street;
		string str2 = str1;
		if ("".Equals(str1))
		{
		  str2 = str1;
		  if (!paramGeocodeJsonObject.City.Equals(paramGeocodeJsonObject.ShortAddress))
		  {
			str2 = paramGeocodeJsonObject.ShortAddress;
		  }
		}
		return str2;
	  }

	  private void c()
	  {
		GeocodeJsonObject geocodeJsonObject;
		Intent intent = new Intent();
		ContentResolver contentResolver = null;
		if (!"".Equals(this.n.getText().ToString()))
		{
		  GeocodeJsonObject geocodeJsonObject1 = new GeocodeJsonObject();
		  if (this.g.Contains(this.n.getText().ToString()) || (this.a_Conflict != null && CoordConversion.getDistance(this.a_Conflict, MapUtils.DEFAULT_POINT) < 100000.0D) || this.h == 1)
		  {
			sbyte b;
			c(geocodeJsonObject1);
			long l = this.f;
			contentResolver = getContentResolver();
			if (this.h == 0)
			{
			  b = 1;
			}
			else
			{
			  b = 3;
			}
			saveStreetHistory(l, contentResolver, b, geocodeJsonObject1, this.m, true);
		  }
		  else
		  {
			geocodeJsonObject1.City = this.n.getText().ToString();
		  }
		  geocodeJsonObject = geocodeJsonObject1;
		  if (!"".Equals(this.n.getText().ToString()))
		  {
			sbyte b;
			ContentResolver contentResolver1 = getContentResolver();
			if (this.h == 0)
			{
			  b = 0;
			}
			else
			{
			  b = 2;
			}
			saveCityHistory(contentResolver1, b, this.n.getText().ToString());
			geocodeJsonObject = geocodeJsonObject1;
		  }
		}
		intent.putExtra("address", (Parcelable)geocodeJsonObject);
		setResult(3, intent);
	  }

	  private void c(GeocodeJsonObject paramGeocodeJsonObject)
	  {
		paramGeocodeJsonObject.Country = "Россия";
		paramGeocodeJsonObject.City = this.n.getText().ToString();
		paramGeocodeJsonObject.Street = this.o.getText().ToString();
		paramGeocodeJsonObject.House = this.p.getText().ToString();
		paramGeocodeJsonObject.Building = this.q.getText().ToString();
		paramGeocodeJsonObject.Construction = this.r.getText().ToString();
		paramGeocodeJsonObject.Entrance = this.s.getText().ToString();
		paramGeocodeJsonObject.Comment = this.t.getText().ToString();
		if (this.d)
		{
		  paramGeocodeJsonObject.setAirport(this.d);
		  paramGeocodeJsonObject.Terminal = this.u.getText().ToString();
		  paramGeocodeJsonObject.Flight = this.v.getText().ToString();
		}
		if (this.a_Conflict != null)
		{
		  paramGeocodeJsonObject.Text = this.e;
		  paramGeocodeJsonObject.GeoPoint = new GeoPoint(this.a_Conflict.Lat, this.a_Conflict.Lon);
		}
		paramGeocodeJsonObject.Text = paramGeocodeJsonObject.FullAddress;
		paramGeocodeJsonObject.Exact = this.c_Conflict;
		paramGeocodeJsonObject.Count = 1;
	  }

	  public static void saveCityHistory(ContentResolver paramContentResolver, int paramInt, string paramString)
	  {
		ContentValues contentValues = new ContentValues();
		contentValues.put("last_use", Convert.ToInt64(DateTimeHelper.CurrentUnixTimeMillis()));
		if (paramContentResolver.update(StaticDataScheme.HistoryTable.CONTENT_URI, contentValues, "name = ? AND type = " + paramInt, new string[] {paramString}) == 0)
		{
		  contentValues.put("name", paramString);
		  contentValues.put("type", Convert.ToInt32(paramInt));
		  paramContentResolver.insert(StaticDataScheme.HistoryTable.CONTENT_URI, contentValues);
		}
	  }

	  public static void saveStreetHistory(long paramLong, ContentResolver paramContentResolver, int paramInt, GeocodeJsonObject paramGeocodeJsonObject, bool paramBoolean1, bool paramBoolean2)
	  {
		string[] arrayOfString;
		string str1;
		string str2 = paramGeocodeJsonObject.serialize();
		ContentValues contentValues = new ContentValues();
		contentValues.put("last_use", Convert.ToInt64(DateTimeHelper.CurrentUnixTimeMillis()));
		contentValues.put("value", str2);
		GeoPoint geoPoint = paramGeocodeJsonObject.GeoPoint;
		if (geoPoint == null)
		{
		  str1 = "0--0";
		}
		else
		{
		  str1 = str1.getLat() + "--" + str1.getLon();
		}
		contentValues.put("point", str1);
		contentValues.put("name", paramGeocodeJsonObject.ShortAddress);
		if (paramBoolean2)
		{
		  int i;
		  if (paramBoolean1)
		  {
			i = 4;
		  }
		  else
		  {
			i = paramInt;
		  }
		  contentValues.put("type", Convert.ToInt32(i));
		}
		if (paramLong > -1L)
		{
		  paramGeocodeJsonObject = null;
		}
		else
		{
		  arrayOfString = new string[] {paramGeocodeJsonObject.ShortAddress};
		}
		if (paramBoolean1)
		{
		  Uri uri = StaticDataScheme.HistoryTable.CONTENT_URI;
		  if (paramLong > -1L)
		  {
			str1 = "_id = " + paramLong;
		  }
		  else
		  {
			str1 = "name = ?";
		  }
		  if (paramContentResolver.update(uri, contentValues, str1, arrayOfString) == 0)
		  {
			contentValues.put("type", Convert.ToInt32(4));
			paramContentResolver.insert(StaticDataScheme.HistoryTable.CONTENT_URI, contentValues);
			return;
		  }
		}
		if (!paramBoolean1)
		{
		  Uri uri = StaticDataScheme.HistoryTable.CONTENT_URI;
		  if (paramLong > -1L)
		  {
			str1 = "_id = " + paramLong;
		  }
		  else
		  {
			str1 = "name = ? AND (type = " + paramInt + " OR " + "type" + " = " + '\x0004' + ")";
		  }
		  if (paramContentResolver.update(uri, contentValues, str1, arrayOfString) == 0)
		  {
			contentValues.put("type", Convert.ToInt32(paramInt));
			paramContentResolver.insert(StaticDataScheme.HistoryTable.CONTENT_URI, contentValues);
		  }
		}
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		string str2;
		GeocodeJsonObject geocodeJsonObject;
		string str1;
		string str3;
		switch (paramInt2)
		{
		  default:

		  case -1:
			switch (paramInt1)
			{
			  default:
				a(a(getContentResolver(), b()));
				return;
			  case 0:
				str2 = paramIntent.getExtras().getString("city name");
				if (!this.n.getText().ToString().Equals(str2))
				{
				  this.c_Conflict = false;
				  this.a_Conflict = null;
				  this.e = "";
				}
				this.n.setText(str2);
				if (!a())
				{
				  c();
				  finish();
				}
				  goto case 1;
			  case 1:
				break;
			}
			str3 = str2.getExtras().getString("street name");
			if (!string.ReferenceEquals(str3, null))
			{
			  this.o.setText(str3);
			}
			geocodeJsonObject = (GeocodeJsonObject)str2.getExtras().getParcelable("address");
			if (geocodeJsonObject != null)
			{
			  this.o.setText(geocodeJsonObject.Street);
			  this.a_Conflict = geocodeJsonObject.GeoPoint;
			  this.c_Conflict = geocodeJsonObject.Exact;
			  this.e = geocodeJsonObject.Text;
			  str1 = geocodeJsonObject.House;
			  GeocodeJsonObject geocodeJsonObject1 = new GeocodeJsonObject();
			  GeocodeJsonObject.setHouseAndBuilding(geocodeJsonObject1, str1);
			  this.p.setText(geocodeJsonObject1.HouseOnly);
			  this.q.setText(geocodeJsonObject1.Building);
			  this.r.setText(geocodeJsonObject1.Construction);
			}
			c();
			finish();
			  goto case 3;
		  case 3:
			break;
		}
		setResult(paramInt2, (Intent)str1);
		finish();
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		GeocodeJsonObject geocodeJsonObject1;
		string str;
		GeocodeJsonObject geocodeJsonObject2;
		int i;
		bool @bool = false;
		base.onCreate(paramBundle);
		Analytics.initExceptionHandler(getApplicationContext(), "ui");
		setContentView(2130903044);
		getWindow().setFormat(1);
		setResult(0);
		Intent intent = getIntent();
		this.n = (EditText)findViewById(2131558416);
		this.o = (EditText)findViewById(2131558417);
		this.p = (EditText)findViewById(2131558419);
		this.q = (EditText)findViewById(2131558420);
		this.r = (EditText)findViewById(2131558421);
		this.s = (EditText)findViewById(2131558422);
		this.t = (EditText)findViewById(2131558407);
		this.u = (EditText)findViewById(2131558424);
		this.v = (EditText)findViewById(2131558425);
		gv gv = new gv(this);
		this.p.addTextChangedListener((TextWatcher)gv);
		this.q.addTextChangedListener((TextWatcher)gv);
		this.r.addTextChangedListener((TextWatcher)gv);
		this.n.addTextChangedListener((TextWatcher)new hf(this, this.n));
		this.n.setOnTouchListener((View.OnTouchListener)new gw(this));
		this.o.addTextChangedListener((TextWatcher)new hf(this, this.o));
		this.o.setOnTouchListener((View.OnTouchListener)new gx(this));
		this.w = (Button)findViewById(2131558428);
		this.w.setOnClickListener((View.OnClickListener)new gy(this));
		this.x = (TextView)findViewById(2131558427);
		this.y = (ImageView)findViewById(2131558426);
		gz gz = new gz(this);
		this.y.setOnClickListener((View.OnClickListener)gz);
		this.x.setOnClickListener((View.OnClickListener)gz);
		PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).getString("client id", "");
		this.g.AddRange(new List<string> {getResources().getStringArray(2131165185)});
		this.k = new TaxiClient((Context)this, (HttpUtils)new HttpUrlConnectionUtils());
		gz = null;
		if (paramBundle != null)
		{
		  geocodeJsonObject2 = (GeocodeJsonObject)paramBundle.getParcelable("address");
		  this.h = paramBundle.getInt("type");
		  geocodeJsonObject1 = geocodeJsonObject2;
		}
		else
		{
		  Bundle bundle = intent.getExtras();
		  geocodeJsonObject1 = geocodeJsonObject2;
		  if (bundle != null)
		  {
			geocodeJsonObject2 = (GeocodeJsonObject)bundle.getParcelable("address");
			this.f = bundle.getLong("address id", -1L);
			this.h = bundle.getInt("type");
			geocodeJsonObject1 = geocodeJsonObject2;
			if (this.h == 1)
			{
			  this.l = bundle.getString("from city");
			  geocodeJsonObject1 = geocodeJsonObject2;
			}
		  }
		}
		if (geocodeJsonObject1 == null)
		{
		  geocodeJsonObject2 = MapUtils.getUserLocation(getApplicationContext());
		  this.b_Conflict = geocodeJsonObject2.GeoPoint;
		  if (this.h == 0)
		  {
			if (geocodeJsonObject2 != null)
			{
			  this.n.setText(geocodeJsonObject2.City);
			  if (CoordConversion.getDistance(this.b_Conflict, geocodeJsonObject2.GeoPoint) < 100.0D)
			  {
				this.o.setText(b(geocodeJsonObject2));
				str = geocodeJsonObject2.House;
				GeocodeJsonObject geocodeJsonObject = new GeocodeJsonObject();
				GeocodeJsonObject.setHouseAndBuilding(geocodeJsonObject, str);
				this.p.setText(geocodeJsonObject.HouseOnly);
				this.q.setText(geocodeJsonObject.Building);
				this.r.setText(geocodeJsonObject.Construction);
			  }
			  this.a_Conflict = geocodeJsonObject2.GeoPoint;
			  this.c_Conflict = geocodeJsonObject2.Exact;
			  this.d = geocodeJsonObject2.getAirport().Value;
			  if (this.d)
			  {
				this.u.setText(geocodeJsonObject2.Terminal);
				this.v.setText(geocodeJsonObject2.Flight);
			  }
			}
			else
			{
			  this.n.setText("Москва");
			  this.a_Conflict = MapUtils.DEFAULT_POINT;
			  this.c_Conflict = false;
			}
		  }
		}
		else
		{
		  this.n.setText(str.getCity());
		  if (this.g.Contains(str.getCity()) || (str.getGeoPoint() != null && CoordConversion.getDistance(str.getGeoPoint(), MapUtils.DEFAULT_POINT) < 100000.0D))
		  {
			this.o.setText(str.getStreet());
			this.p.setText(str.getHouseOnly());
			this.q.setText(str.getBuilding());
			this.r.setText(str.getConstruction());
			this.s.setText(str.getEntrance());
		  }
		  this.t.setText(str.getComment());
		  this.a_Conflict = str.getGeoPoint();
		  this.e = str.getText();
		  this.c_Conflict = str.getExact();
		  this.d = str.getAirport().booleanValue();
		  if (this.d)
		  {
			this.u.setText(str.getTerminal());
			this.v.setText(str.getFlight());
		  }
		  this.b_Conflict = MapUtils.getLastKnownMyLocationPoint((Context)this);
		  (new Thread((ThreadStart)new gt(this))).Start();
		}
		if (this.d)
		{
		  findViewById(2131558423).setVisibility(0);
		  findViewById(2131558418).setVisibility(8);
		}
		if (!string.ReferenceEquals(this.l, null) && !"".Equals(this.l))
		{
		  this.n.setText(this.l);
		}
		EditText editText = this.r;
		if (this.h == 0)
		{
		  i = 2131558422;
		}
		else
		{
		  i = 2131558419;
		}
		editText.setNextFocusDownId(i);
		editText = this.s;
		if (this.h == 0)
		{
		  i = 0;
		}
		else
		{
		  i = 8;
		}
		editText.setVisibility(i);
		editText = this.t;
		if (this.h == 0)
		{
		  i = @bool;
		}
		else
		{
		  i = 8;
		}
		editText.setVisibility(i);
		a(a(getContentResolver(), b()));
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		Dialog dialog = null;
		switch (paramInt)
		{
		  default:
			return dialog;
		  case 0:
			break;
		}
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)this);
		builder.setTitle(2131296371).setMessage(2131296372).setPositiveButton(2131296373, (DialogInterface.OnClickListener)new gs(this)).setNegativeButton(2131296374, (DialogInterface.OnClickListener)new gr(this));
		AlertDialog alertDialog = builder.create();
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

	  protected internal virtual void onResume()
	  {
		bool bool1;
		base.onResume();
		bool @bool = a();
		if (!@bool)
		{
		  c();
		  finish();
		}
		this.t.setEnabled(@bool);
		this.o.setClickable(@bool);
		this.o.setEnabled(@bool);
		if (@bool && !"".Equals(this.o.getText().ToString()))
		{
		  bool1 = true;
		}
		else
		{
		  bool1 = false;
		}
		if (bool1)
		{
		  this.p.requestFocus();
		}
		else if (@bool)
		{
		  this.t.requestFocus();
		}
		this.p.setEnabled(bool1);
		this.q.setEnabled(bool1);
		this.r.setEnabled(bool1);
		this.s.setEnabled(bool1);
	  }

	  protected internal virtual void onSaveInstanceState(Bundle paramBundle)
	  {
		GeocodeJsonObject geocodeJsonObject = new GeocodeJsonObject();
		geocodeJsonObject.City = this.n.getText().ToString();
		geocodeJsonObject.Street = this.o.getText().ToString();
		geocodeJsonObject.House = this.p.getText().ToString();
		geocodeJsonObject.Building = this.q.getText().ToString();
		geocodeJsonObject.Construction = this.r.getText().ToString();
		geocodeJsonObject.Entrance = this.s.getText().ToString();
		geocodeJsonObject.Comment = this.t.getText().ToString();
		if (this.a_Conflict != null)
		{
		  geocodeJsonObject.Text = this.e;
		  geocodeJsonObject.GeoPoint = new GeoPoint(this.a_Conflict.Lat, this.a_Conflict.Lon);
		}
		paramBundle.putParcelable("address", (Parcelable)geocodeJsonObject);
		base.onSaveInstanceState(paramBundle);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\EditAddressActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}