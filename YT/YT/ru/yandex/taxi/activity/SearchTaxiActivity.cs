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
	using SharedPreferences = android.content.SharedPreferences;
	using Resources = android.content.res.Resources;
	using Cursor = android.database.Cursor;
	using Bitmap = android.graphics.Bitmap;
	using BitmapFactory = android.graphics.BitmapFactory;
	using Uri = android.net.Uri;
	using Bundle = android.os.Bundle;
	using Parcelable = android.os.Parcelable;
	using PowerManager = android.os.PowerManager;
	using Vibrator = android.os.Vibrator;
	using PreferenceManager = android.preference.PreferenceManager;
	using Log = android.util.Log;
	using KeyEvent = android.view.KeyEvent;
	using Menu = android.view.Menu;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using TextView = android.widget.TextView;
	using mm;
	using mp;
	using mq;
	using mr;
	using ms;
	using mt;
	using mu;
	using mv;
	using mw;
	using mz;
	using na;
	using nb;
	using ne;
	using ru.yandex.taxi;
	using Analytics = ru.yandex.taxi.analytics.Analytics;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUrlDemoUtils = ru.yandex.taxi.client.HttpUrlDemoUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using Requirements = ru.yandex.taxi.data.Requirements;
	using TariffLimits = ru.yandex.taxi.data.TariffLimits;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;
	using ErrorUtils = ru.yandex.taxi.error.ErrorUtils;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using RadarRender = ru.yandex.taxi.map.RadarRender;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using MapView = ru.yandex.yandexmapkit.MapView;
	using OverlayManager = ru.yandex.yandexmapkit.OverlayManager;
	using IRender = ru.yandex.yandexmapkit.overlay.IRender;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class SearchTaxiActivity : Activity
	{
	  public const string CALIBRATE_VALUE = "calibrate value";

	  public const int CANCELED_BY_USER = 1;

	  public const string DEMO = "demo";

	  public const string DEST_ADDRESS = "dest point";

	  protected internal const int DIALOG_CALIBRATE = 3;

	  protected internal const int DIALOG_CANCEL = 0;

	  protected internal const int DIALOG_EXPIRED = 2;

	  protected internal const int DIALOG_NO_TAXI = 1;

	  public const string INITIAL_STATE = "state";

	  public const string MAX_CAR_DISTANCE = "max car distance";

	  public const int NO_TAXI_FOUND = 3;

	  public const string ORDER_ID = "order id";

	  public const string PREF_JAMS_ON = "jams on";

	  public const string SERVER_DIFF_TIME = "server diff time";

	  public const string SRC_ADDRESS = "src point";

	  public const int STATE_BREAK = 1;

	  public const int STATE_CALIBRATE = 0;

	  public const int STATE_EXPIRED = 2;

	  public const int TAXI_FOUND = 2;

	  public const string USER_POINT = "user point";

	  public const string WHEN = "when";

	  private bool A;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private Thread a_Conflict;

	  private int b;

	  private string c;

	  private bool d;

	  private Thread e;

	  private SharedPreferences f;

	  private int g = -1;

	  private int h;

	  private TariffLimits i;

	  private Requirements j;

	  private MapController k;

	  private OverlayManager l;

	  private RadarRender m;

	  public string mBreak = "none";

	  public string mClientId;

	  public bool mDemoMode;

	  public GeocodeJsonObject mDestAddress;

	  public bool mInitZoom;

	  public bool mInitZoomFinished = true;

	  public bool mInterrupt;

	  public MapView mMap;

	  public int mOptimZoom = 12;

	  public string mOrderId;

	  protected internal Resources mResources;

	  public bool mScreenVisible;

	  public GeocodeJsonObject mSrcAddress;

	  public bool mStopSearch;

	  public TaxiClient mTaxiClient;

	  public Overlay mUser;

	  protected internal PowerManager.WakeLock mWakeLock;

	  public DateTime mWhen;

	  public bool mWrapTaxiZoomFinished = true;

	  private Overlay n;

	  private Overlay o;

	  private Overlay p;

	  private Overlay q;

	  private Overlay r;

	  private float s = -1.0F;

	  private GeoPoint t;

	  private GeoPoint u;

	  private Bitmap v;

	  private Bitmap w;

	  private Bitmap x;

	  private Bitmap y;

	  private ProgressDialog z;

	  private void a()
	  {
		TextView textView = (TextView)findViewById(2131558481);
		string str = getResources().getString(2131296299);
		DateTime calendar = new DateTime();
		calendar = calendar.AddMinutes(10);
		textView.setText(String.format(str, new object[] {(new SimpleDateFormat("HH:mm")).format(calendar)}));
	  }

	  private void a(GeoPoint paramGeoPoint, Pair<double, double> paramPair)
	  {
		IEnumerator<OverlayItem> iterator = this.o.OverlayItems.GetEnumerator();
		while (iterator.MoveNext())
		{
		  GeoPoint geoPoint = ((OverlayItem)iterator.Current).GeoPoint;
		  double d1 = CoordConversion.getDistance(paramGeoPoint.Lat, 0.0D, geoPoint.Lat, 0.0D);
		  double d2 = CoordConversion.getDistance(0.0D, paramGeoPoint.Lon, 0.0D, geoPoint.Lon);
		  if (((double?)paramPair.first).Value < d1)
		  {
			paramPair.first = Convert.ToDouble(d1);
		  }
		  if (((double?)paramPair.second).Value < d2)
		  {
			paramPair.second = Convert.ToDouble(d2);
		  }
		}
	  }

	  public static void initCarDistances(GeoPoint paramGeoPoint, IList<GeoPoint> paramList, double[] paramArrayOfdouble)
	  {
		for (sbyte b = 0; b < paramList.Count; b++)
		{
		  paramArrayOfdouble[b] = CoordConversion.getDistance(paramGeoPoint, (GeoPoint)paramList[b]);
		}
	  }

	  protected internal virtual void afterStartAction()
	  {
		this.e = new Thread((ThreadStart)new ms(this));
		this.e.Start();
		this.a_Conflict = (Thread)new ne(this);
		this.a_Conflict.Start();
	  }

	  protected internal virtual void beforeStopAction()
	  {
		if (this.a_Conflict != null)
		{
		  this.a_Conflict.Interrupt();
		}
	  }

	  public virtual void finish()
	  {
		this.mInterrupt = true;
		base.finish();
	  }

	  protected internal virtual void initFields()
	  {
		GeoPoint geoPoint;
		string str1 = null;
		this.mWakeLock = ((PowerManager)getSystemService("power")).newWakeLock(10, "SearchTaxiActivity");
		this.f = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
		this.mClientId = this.f.getString("client id", "");
		initOrderObjects();
		Bundle bundle = getIntent().getExtras();
		string str2 = str1;
		if (bundle != null)
		{
		  this.mDemoMode = bundle.getBoolean("demo");
		  if (this.mDemoMode)
		  {
			this.mSrcAddress = HttpUrlDemoUtils.SRC_ADDRESS;
			this.mDestAddress = HttpUrlDemoUtils.DEST_ADDRESS;
			this.mOrderId = "123";
		  }
		  else
		  {
			this.mSrcAddress = (GeocodeJsonObject)bundle.get("src point");
			this.mDestAddress = (GeocodeJsonObject)bundle.get("dest point");
			this.mOrderId = bundle.getString("order id");
			this.mWhen = (DateTime)bundle.getSerializable("when");
			this.b = bundle.getInt("server diff time");
			this.g = bundle.getInt("state", -1);
			this.c = bundle.getString("calibrate value");
		  }
		  if (this.mSrcAddress == null)
		  {
			ContentResolver contentResolver = getContentResolver();
			Uri uri = StaticDataScheme.CurrentOrderTable.CONTENT_URI;
			str2 = this.mOrderId;
			Cursor cursor = contentResolver.query(uri, new string[] {"src", "desc"}, "order_id = ?", new string[] {str2}, null);
			if (cursor.getCount() > 0)
			{
			  cursor.moveToFirst();
			  this.mSrcAddress = new GeocodeJsonObject(cursor.getString(0));
			  if (cursor.getString(1) != null)
			  {
				this.mDestAddress = new GeocodeJsonObject(cursor.getString(1));
			  }
			}
		  }
		  if (this.mSrcAddress == null)
		  {
			str2 = str1;
		  }
		  else
		  {
			geoPoint = this.mSrcAddress.GeoPoint;
		  }
		}
		if (geoPoint != null)
		{
		  initRouteObjects(geoPoint);
		}
		this.z = ProgressDialog.show((Context)this, "", getResources().getString(2131296304), true, true);
		if (this.mSrcAddress != null)
		{
		  this.k.setPositionNoAnimationTo(this.mSrcAddress.GeoPoint, 17);
		  this.z.hide();
		}
		else
		{
		  this.k.ZoomCurrent = 17.0F;
		}
		try
		{
		  HttpUrlConnectionUtils httpUrlConnectionUtils;
		  TaxiClient taxiClient = new TaxiClient();
		  Context context = getApplicationContext();
		  if (this.mDemoMode)
		  {
			HttpUrlDemoUtils httpUrlDemoUtils = new HttpUrlDemoUtils();
			this();
		  }
		  else
		  {
			httpUrlConnectionUtils = new HttpUrlConnectionUtils();
		  }
		  this(context, (HttpUtils)httpUrlConnectionUtils);
		  this.mTaxiClient = taxiClient;
		}
		catch (Exception exception)
		{
		  Log.e("SearchTaxiActivity", "Fail create http client", exception);
		  ErrorUtils.showErrorMessage((Context)this, "Fail create http client");
		  setResult(3);
		  finish();
		}
		getContentResolver().delete(StaticDataScheme.NoCalibrateTable.CONTENT_URI, "due< ?", new string[] {TaxiClient.DATE_FORMAT.format(DateTime.Now)});
		this.i = new TariffLimits();
		this.i.setTariffLimits(this.f.getString("classes", this.i.ClassesString), this.f.getString("excluded parks", ""));
		this.j = new Requirements((Context)this);
		this.j.Requirements = this.f.getString("requirements", "");
	  }

	  protected internal virtual void initOrderObjects()
	  {
		this.v = BitmapFactory.decodeResource(this.mResources, 2130837544);
		this.x = BitmapFactory.decodeResource(this.mResources, 2130837548);
		this.w = BitmapFactory.decodeResource(this.mResources, 2130837545);
		this.y = BitmapFactory.decodeResource(this.mResources, 2130837549);
	  }

	  public virtual void initRouteObjects(GeoPoint paramGeoPoint)
	  {
		int i;
		this.mUser = new Overlay(this.k);
		OverlayItem overlayItem2 = new OverlayItem(paramGeoPoint, BitmapFactory.decodeResource(this.mResources, 2130837625));
		overlayItem2.Priority = 127;
		this.mUser.addOverlayItem(overlayItem2);
		this.l.addOverlay(this.mUser);
		MapView mapView = this.mMap;
		Bitmap bitmap1 = BitmapFactory.decodeResource(this.mResources, 2130837624);
		Bitmap bitmap2 = BitmapFactory.decodeResource(this.mResources, 2130837623);
		if (this.v.getWidth() > this.x.getWidth())
		{
		  i = this.v.getWidth() / 2;
		}
		else
		{
		  i = this.x.getWidth() / 2;
		}
		this.m = new RadarRender(mapView, paramGeoPoint, bitmap1, bitmap2, i);
		this.n = new Overlay(this.k);
		this.n.IRender = (IRender)this.m;
		OverlayItem overlayItem1 = new OverlayItem(paramGeoPoint, BitmapFactory.decodeResource(this.mResources, 2130837624));
		overlayItem1.Priority = (sbyte)126;
		this.n.addOverlayItem(overlayItem1);
		this.l.addOverlay(this.n);
	  }

	  protected internal virtual void initUi()
	  {
		findViewById(2131558480);
		this.mMap = (MapView)findViewById(2131558454);
		this.k = this.mMap.MapController;
		this.l = this.k.OverlayManager;
		this.o = new Overlay(this.k);
		this.p = new Overlay(this.k);
		this.q = new Overlay(this.k);
		this.r = new Overlay(this.k);
		this.l.addOverlay(this.o);
		this.l.addOverlay(this.p);
		this.l.addOverlay(this.q);
		this.l.addOverlay(this.r);
		this.mMap.showZoomButtons(false);
		this.mMap.showFindMeButton(false);
		this.k.OverlayManager.MyLocation.Enabled = false;
		this.mMap.postDelayed((ThreadStart)new mu(this), 1000L);
		a();
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		switch (paramInt1)
		{
		  default:
			finish();
			  goto case 0;
		  case 0:
			return;
		  case 2:
			break;
		}
		TariffLimits tariffLimits = (TariffLimits)paramIntent.getSerializableExtra("tariff limits");
		Requirements requirements = (Requirements)paramIntent.getSerializableExtra("requirements");
		if (!this.i.Equals(tariffLimits) || !this.j.Equals(requirements))
		{
		  this.i = tariffLimits;
		  this.j = requirements;
		  (new nb(this, 0, 2131296307, getResources().getString(2131296389), this.j, this.i)).execute((object[])new int?[0]);
		}
	  }

	  public virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		Analytics.initExceptionHandler(getApplicationContext(), "ui");
		setContentView(2130903060);
		getWindow().setFormat(1);
		this.mResources = getResources();
		if (paramBundle != null)
		{
		  paramBundle.getBoolean("init timer");
		}
		initUi();
		initFields();
		this.k.Enabled = false;
		if (this.mDemoMode)
		{
		  findViewById(2131558482).setVisibility(0);
		  setTitle(getResources().getString(2131296275) + ": " + getTitle());
		  this.mMap.showFindMeButton(false);
		  this.mMap.showZoomButtons(false);
		  this.mMap.showJamsButton(false);
		  this.k.PositionAnimationTo = this.mSrcAddress.GeoPoint;
		  return;
		}
		this.k.JamsVisible = this.f.getBoolean("jams on", false);
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		bool @bool;
		AlertDialog.Builder builder;
		null = new AlertDialog.Builder((Context)this);
		switch (paramInt)
		{
		  default:
			return null;
		  case 0:
			@bool = "break".Equals(this.c);
			builder = SYNTHETIC_LOCAL_VARIABLE_2.setTitle(2131296295);
			if (@bool)
			{
			  paramInt = 2131296298;
			}
			else
			{
			  paramInt = 2131296297;
			}
			builder.setMessage(paramInt).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new mw(this, @bool)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new mv(this, @bool));
			this.c = null;
			return (Dialog)SYNTHETIC_LOCAL_VARIABLE_2.create();
		  case 2:
			SYNTHETIC_LOCAL_VARIABLE_2.setCancelable(false).setTitle(2131296293).setMessage(2131296294).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new mz(this));
			return (Dialog)SYNTHETIC_LOCAL_VARIABLE_2.create();
		  case 3:
			paramInt = int.Parse(this.c);
			SYNTHETIC_LOCAL_VARIABLE_2.setCancelable(false).setTitle(2131296289).setMessage(String.format(this.mResources.getString(2131296290), new object[] {this.c})).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new mp(this, paramInt)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new na(this));
			this.c = null;
			return (Dialog)SYNTHETIC_LOCAL_VARIABLE_2.create();
		  case 4:
			break;
		}
		this.mWhen.setSeconds(0);
		DateTime date = DateTime.Now;
		date = new DateTime(this.mWhen.Ticks);
		Dialog dialog = OrderActivity.createDateTimeDialog(this, this.b, date, (View.OnClickListener)new mq(this, date), (View.OnClickListener)new mr(this), true);
		dialog.setTitle(2131296309);
		return dialog;
	  }

	  public virtual bool onCreateOptionsMenu(Menu paramMenu)
	  {
		if (!this.mDemoMode)
		{
		  paramMenu.add(0, 0, 0, 2131296322).setIcon(2130837604);
		  paramMenu.add(0, 2, 0, 2131296308).setIcon(2130837614);
		  paramMenu.add(0, 3, 0, 2131296388).setIcon(2130837612);
		}
		return true;
	  }

	  public virtual bool onKeyDown(int paramInt, KeyEvent paramKeyEvent)
	  {
		if (!this.mDemoMode)
		{
		  switch (paramInt)
		  {
			default:
			  return base.onKeyDown(paramInt, paramKeyEvent);
			case 4:
			  break;
		  }
		  showDialog(0);
		  return true;
		}
	  }

	  public virtual bool onOptionsItemSelected(MenuItem paramMenuItem)
	  {
		switch (paramMenuItem.getItemId())
		{
		  default:
			return true;
		  case 0:
			showDialog(0);
			  goto case 2;
		  case 2:
			showDialog(4);
			  goto case 3;
		  case 3:
			break;
		}
		Intent intent = new Intent((Context)this, typeof(TariffListActivity));
		intent.putExtra("tariff limits", (Serializable)this.i);
		intent.putExtra("requirements", (Serializable)this.j);
		intent.putExtra("when", this.mWhen);
		startActivityForResult(intent, 2);
	  }

	  protected internal virtual void onPause()
	  {
		this.mScreenVisible = false;
		this.f.edit().putBoolean("jams on", this.k.JamsVisible).commit();
		base.onPause();
	  }

	  protected internal virtual void onResume()
	  {
		base.onResume();
		this.mScreenVisible = true;
		if (!this.mInitZoom && this.mDemoMode)
		{
		  this.mInitZoom = true;
		}
	  }

	  protected internal virtual void onStart()
	  {
		base.onStart();
		this.f = PreferenceManager.getDefaultSharedPreferences((Context)this);
		if (this.f.getBoolean("notification call", false))
		{
		  this.mStopSearch = true;
		  finish();
		}
		this.A = true;
		this.mWakeLock.acquire();
		if (!this.mStopSearch)
		{
		  this.mInterrupt = false;
		  afterStartAction();
		}
		if (this.g != -1)
		{
		  this.mStopSearch = true;
		  this.mInterrupt = true;
		  switch (this.g)
		  {
			default:
			  this.g = -1;
			  return;
			case 0:
			  showDialog(3);
				goto case 1;
			case 1:
			  showDialog(0);
				goto case 2;
			case 2:
			  break;
		  }
		}
		else
		{
		  return;
		}
		showDialog(2);
	  }

	  protected internal virtual void onStop()
	  {
		this.mInterrupt = true;
		this.A = false;
		beforeStopAction();
		this.mWakeLock.release();
		base.onStop();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\SearchTaxiActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}