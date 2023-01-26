using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using ProgressDialog = android.app.ProgressDialog;
	using TabActivity = android.app.TabActivity;
	using BroadcastReceiver = android.content.BroadcastReceiver;
	using ContentResolver = android.content.ContentResolver;
	using ContentValues = android.content.ContentValues;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Intent = android.content.Intent;
	using IntentFilter = android.content.IntentFilter;
	using SharedPreferences = android.content.SharedPreferences;
	using Resources = android.content.res.Resources;
	using Cursor = android.database.Cursor;
	using Bitmap = android.graphics.Bitmap;
	using BitmapFactory = android.graphics.BitmapFactory;
	using ConnectivityManager = android.net.ConnectivityManager;
	using Uri = android.net.Uri;
	using Build = android.os.Build;
	using Bundle = android.os.Bundle;
	using Parcelable = android.os.Parcelable;
	using PreferenceManager = android.preference.PreferenceManager;
	using Html = android.text.Html;
	using Log = android.util.Log;
	using KeyEvent = android.view.KeyEvent;
	using LayoutInflater = android.view.LayoutInflater;
	using Menu = android.view.Menu;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using Button = android.widget.Button;
	using ImageView = android.widget.ImageView;
	using LinearLayout = android.widget.LinearLayout;
	using ProgressBar = android.widget.ProgressBar;
	using TabHost = android.widget.TabHost;
	using TextView = android.widget.TextView;
	using hn;
	using ho;
	using hp;
	using hq;
	using hr;
	using hs;
	using ht;
	using hu;
	using hv;
	using hw;
	using hx;
	using hy;
	using hz;
	using ia;
	using ib;
	using ic;
	using id;
	using ie;
	using if;
	using ig;
	using ih;
	using ii;
	using ij;
	using ik;
	using il;
	using im;
	using @in;
	using io;
	using ip;
	using iq;
	using ir;
	using @is;
	using it;
	using ix;
	using iy;
	using iz;
	using ja;
	using jb;
	using jc;
	using jd;
	using je;
	using jf;
	using jg;
	using jh;
	using ji;
	using jk;
	using jl;
	using jo;
	using jp;
	using jq;
	using jr;
	using js;
	using ju;
	using jv;
	using jx;
	using jy;
	using Utils = ru.yandex.taxi.Utils;
	using Analytics = ru.yandex.taxi.analytics.Analytics;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using AllCarsResponse = ru.yandex.taxi.client.response.AllCarsResponse;
	using CurrentOrder = ru.yandex.taxi.data.CurrentOrder;
	using Requirements = ru.yandex.taxi.data.Requirements;
	using ServerMsg = ru.yandex.taxi.data.ServerMsg;
	using TariffLimits = ru.yandex.taxi.data.TariffLimits;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using MapUtils = ru.yandex.taxi.map.MapUtils;
	using SlidingDrawer = ru.yandex.taxi.ui.slider.SlidingDrawer;
	using OnWheelScrollListener = ru.yandex.taxi.ui.wheel.OnWheelScrollListener;
	using WheelView = ru.yandex.taxi.ui.wheel.WheelView;
	using AbstractWheelTextAdapter = ru.yandex.taxi.ui.wheel.adapters.AbstractWheelTextAdapter;
	using ru.yandex.taxi.ui.wheel.adapters;
	using DayArrayAdapter = ru.yandex.taxi.ui.wheel.adapters.DayArrayAdapter;
	using NumericWheelAdapter = ru.yandex.taxi.ui.wheel.adapters.NumericWheelAdapter;
	using WheelViewAdapter = ru.yandex.taxi.ui.wheel.adapters.WheelViewAdapter;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using MapView = ru.yandex.yandexmapkit.MapView;
	using OverlayManager = ru.yandex.yandexmapkit.OverlayManager;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class OrderActivity : TabActivity
	{
		private bool InstanceFieldsInitialized = false;

		public OrderActivity()
		{
			if (!InstanceFieldsInitialized)
			{
				InitializeInstanceFields();
				InstanceFieldsInitialized = true;
			}
		}

		private void InitializeInstanceFields()
		{
			H = new OrderActivity$1(this);
		}

	  public const int CRITICAL_DELAY_ORDER_TIMEOUT = 35;

	  public const int DEFAULT_MANUAL_ORDER_DELAY = 10;

	  public const int DEFAULT_ORDER_DELAY = 20;

	  public const string LAST_MSG_SHOW = "last msg show";

	  public const string LAST_ORDER_DATE = "last order date";

	  public const string NOTIFICATION_CALL = "notification call";

	  public const string NOT_VIDEO_VIEWED = "first launch";

	  public const int RUSH_ORDER_PERIOD = 40;

	  private static System.Reflection.MethodInfo ae;

	  private bool A;

	  private bool B;

	  private string C;

	  private int D;

	  private bool E;

	  private string F;

	  private string G;

	  private BroadcastReceiver H;

	  private List<TextView> I = new List<TextView>();

	  private Button J;

	  private TextView K;

	  private TextView L;

	  private TextView M;

	  private ProgressDialog N;

	  private View O;

	  private TextView P;

	  private bool? Q = Convert.ToBoolean(true);

	  private ju R;

	  private jx S;

	  private MapView T;

	  private MapController U;

	  private OverlayManager V;

	  private Bitmap W;

	  private Bitmap X;

	  private Overlay Y;

	  private Overlay Z;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private int a_Conflict = -1;

	  private Overlay aa;

	  private Overlay ab;

	  private TabHost ac;

	  private ProgressBar ad;

	  private bool af;

	  private bool ag;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private GeocodeJsonObject d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private GeocodeJsonObject e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private DateTime f_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private Requirements h_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private TariffLimits i_Conflict = new TariffLimits();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool j_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool k_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private int l_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private List<string> m_Conflict = new List<string>();

	  private List<string> n = new List<string>();

	  private bool o;

	  private TaxiClient p;

	  private List<string> q = new List<string>();

	  private bool r;

	  private SharedPreferences s;

	  private IList<CurrentOrder> t = new List<CurrentOrder>();

	  private IList<ServerMsg> u = new List<ServerMsg>();

	  private CurrentOrder v;

	  private Thread w;

	  private bool x;

	  private bool y;

	  private bool z = true;

	  private Dialog a(int paramInt, string paramString)
	  {
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)this);
		builder.setTitle(paramInt).setMessage(paramString).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new io(this));
		return (Dialog)builder.create();
	  }

	  private void a()
	  {
		bool @bool = true;
		long l = this.s.getLong("last address date", 0L);
		if (DateTimeHelper.CurrentUnixTimeMillis() - l < 3600000L)
		{
		  this.d_Conflict = new GeocodeJsonObject(this.s.getString("last address", ""));
		  this.r = c();
		  b();
		  this.B = true;
		}
		else
		{
		  @bool = false;
		}
		l = this.s.getLong("last dest address date", 0L);
		if (DateTimeHelper.CurrentUnixTimeMillis() - l < 3600000L)
		{
		  this.e_Conflict = new GeocodeJsonObject(this.s.getString("last dest address", ""));
		}
		string str = this.s.getString("last order date", null);
		if (!string.ReferenceEquals(str, null))
		{
		  try
		  {
			DateTime date = TaxiClient.DATE_FORMAT.parse(str);
			DateTime calendar = new DateTime();
			b(calendar, 10, this.l_Conflict);
			if (date > calendar)
			{
			  this.f_Conflict = date;
			  this.g_Conflict = true;
			}
			else
			{
			  this.s.edit().remove("last order date").commit();
			}
		  }
		  catch (ParseException parseException)
		  {
			Log.e("OrderActivity", "Fail restore last order date", parseException);
		  }
		}
		k();
		(new it(this, @bool)).execute((object[])new ru.yandex.yandexmapkit.utils.ScreenPoint[0]);
	  }

	  private void a(int paramInt1, int paramInt2, string paramString)
	  {
		TabHost.TabSpec tabSpec = this.ac.newTabSpec(paramString);
		if ("3".Equals(Build.VERSION.SDK))
		{
		  tabSpec.setIndicator(getResources().getString(paramInt1));
		}
		else
		{
		  View view = LayoutInflater.from((Context)this).inflate(2130903045, (ViewGroup)getTabWidget(), false);
		  TextView textView = (TextView)view.findViewById(2131558430);
		  textView.setTextColor(getResources().getColorStateList(2130837560));
		  textView.setText(paramInt1);
		  textView.setTextSize(2, 18.0F);
		  if (-1 != paramInt2)
		  {
			textView = (TextView)view.findViewById(2131558431);
			textView.setTextColor(getResources().getColorStateList(2130837560));
			textView.setText(paramInt2);
			textView.setVisibility(0);
		  }
		  try
		  {
			if (ae == null)
			{
			  System.Reflection.MethodInfo method = typeof(TabHost.TabSpec).GetMethod("setIndicator", new Type[] {typeof(View)});
			  ae = method;
			  method.setAccessible(true);
			}
			ae.invoke(tabSpec, new object[] {view});
		  }
		  catch (Exception exception)
		  {
			Log.e("OrderActivity", "Fail set tab indicator by reflection", exception);
		  }
		}
		tabSpec.setContent(2131558453);
		this.ac.addTab(tabSpec);
	  }

	  private void a(ViewGroup paramViewGroup, View paramView, int paramInt1, int paramInt2, View.OnClickListener paramOnClickListener)
	  {
		((ImageView)paramView.findViewById(2131558429)).setImageResource(paramInt1);
		((TextView)paramView.findViewById(2131558403)).setText(paramInt2);
		TextView textView = (TextView)paramView.findViewById(2131558457);
		this.I.Add(textView);
		paramView.setOnClickListener(paramOnClickListener);
		paramViewGroup.addView(paramView);
	  }

	  private void a(string paramString1, string paramString2)
	  {
		this.F = paramString1;
		this.G = paramString2;
		this.M.setText((CharSequence)Html.fromHtml(String.format(getResources().getString(2131296452), new object[] {String.format(this.c_Conflict, new object[] {paramString2}), String.format(this.c_Conflict, new object[] {paramString1})})));
	  }

	  private void a(CurrentOrder paramCurrentOrder)
	  {
		if ("driving".Equals(paramCurrentOrder.status))
		{
		  Intent intent = new Intent(getApplicationContext(), typeof(TaxiOnTheWayToSourceActivity));
		  intent.putExtra("order id", paramCurrentOrder.orderId);
		  intent.putExtra("when", paramCurrentOrder.due);
		  startActivity(intent);
		  return;
		}
		if ("waiting".Equals(paramCurrentOrder.status))
		{
		  Intent intent = new Intent(getApplicationContext(), typeof(TaxiOnTheWayToSourceActivity));
		  intent.putExtra("order id", paramCurrentOrder.orderId);
		  intent.putExtra("when", paramCurrentOrder.due);
		  intent.putExtra("arrived", true);
		  startActivity(intent);
		  return;
		}
		if ("transporting".Equals(paramCurrentOrder.status))
		{
		  Intent intent = new Intent(getApplicationContext(), typeof(TaxiOnTheWayToDescActivity));
		  intent.putExtra("order id", paramCurrentOrder.orderId);
		  startActivity(intent);
		  return;
		}
		if ("cancelled".Equals(paramCurrentOrder.status))
		{
		  this.C = getResources().getString(2131296312);
		  this.D = 2131296392;
		  showDialog(8);
		  return;
		}
		if ("failed".Equals(paramCurrentOrder.status))
		{
		  this.C = getResources().getString(2131296394);
		  this.D = 2131296392;
		  showDialog(8);
		  return;
		}
		if ("search".Equals(paramCurrentOrder.status))
		{
		  Intent intent = new Intent(getApplicationContext(), typeof(SearchTaxiActivity));
		  intent.putExtra("order id", paramCurrentOrder.orderId);
		  intent.putExtra("when", paramCurrentOrder.due);
		  intent.putExtra("server diff time", this.l_Conflict);
		  startActivity(intent);
		  return;
		}
		if ("pending".Equals(paramCurrentOrder.status))
		{
		  ContentResolver contentResolver = getContentResolver();
		  Uri uri = StaticDataScheme.CurrentOrderTable.CONTENT_URI;
		  string str = paramCurrentOrder.orderId;
		  Cursor cursor = contentResolver.query(uri, new string[] {"order_id", "src", "desc", "park_name", "park_phone", "park_id", "park_logo", "tariff_id"}, "order_id = ?", new string[] {str}, null);
		  if (cursor.getCount() > 0)
		  {
			GeocodeJsonObject geocodeJsonObject;
			cursor.moveToFirst();
			Intent intent = new Intent((Context)this, typeof(DelayOrderActivity));
			intent.putExtra("src point", (Parcelable)new GeocodeJsonObject(cursor.getString(1)));
			str = cursor.getString(2);
			if (string.ReferenceEquals(str, null))
			{
			  str = null;
			}
			else
			{
			  geocodeJsonObject = new GeocodeJsonObject(str);
			}
			intent.putExtra("dest point", (Parcelable)geocodeJsonObject);
			intent.putExtra("order id", paramCurrentOrder.orderId);
			intent.putExtra("when", paramCurrentOrder.due);
			intent.putExtra("park name", cursor.getString(3));
			intent.putExtra("park phone", cursor.getString(4));
			intent.putExtra("park id", cursor.getString(5));
			intent.putExtra("park logo url", cursor.getString(6));
			intent.putExtra("tariff id", cursor.getString(7));
			startActivity(intent);
		  }
		  else
		  {
			this.v = paramCurrentOrder;
			showDialog(12);
		  }
		  cursor.close();
		}
	  }

	  private void a(GeocodeJsonObject paramGeocodeJsonObject, string paramString1, string paramString2)
	  {
		SharedPreferences.Editor editor = this.s.edit();
		editor.putString(paramString1, paramGeocodeJsonObject.serialize());
		editor.putLong(paramString2, DateTimeHelper.CurrentUnixTimeMillis());
		editor.commit();
	  }

	  private void b()
	  {
		if (this.U != null && this.d_Conflict.GeoPoint != null && this.r)
		{
		  this.U.setPositionNoAnimationTo(this.d_Conflict.GeoPoint, 12);
		  if (this.ab == null)
		  {
			this.ab = new Overlay(this.U);
			OverlayItem overlayItem1 = new OverlayItem(this.d_Conflict.GeoPoint, BitmapFactory.decodeResource(getResources(), 2130837507));
			overlayItem1.Priority = 127;
			overlayItem1.OffsetX = -overlayItem1.Bitmap.getWidth() / 4;
			overlayItem1.OffsetY = overlayItem1.Bitmap.getHeight() / 2;
			BalloonItem balloonItem1 = new BalloonItem(this.d_Conflict.GeoPoint, null);
			balloonItem1.Text = this.d_Conflict.ShortAddress;
			overlayItem1.BalloonItem = balloonItem1;
			this.ab.addOverlayItem(overlayItem1);
			this.V.addOverlay(this.ab);
			return;
		  }
		  this.ab.Visible = true;
		  OverlayItem overlayItem = this.ab.OverlayItems[0];
		  overlayItem.GeoPoint = this.d_Conflict.GeoPoint;
		  BalloonItem balloonItem = new BalloonItem(this.d_Conflict.GeoPoint, null);
		  balloonItem.Text = this.d_Conflict.ShortAddress;
		  overlayItem.BalloonItem = balloonItem;
		  return;
		}
		if (this.ab != null)
		{
		  this.ab.Visible = false;
		}
	  }

	  private static void b(DateTime paramCalendar)
	  {
		int i = paramCalendar.Minute;
		int j = (int)Math.Ceiling(i / 5.0D) % 12;
		paramCalendar.set(12, j * 5);
		if (j == 0 && i > 5)
		{
		  paramCalendar = paramCalendar.AddHours(1);
		}
		paramCalendar.set(13, 0);
		paramCalendar.set(14, 0);
	  }

	  private static void b(DateTime paramCalendar, int paramInt1, int paramInt2)
	  {
		paramCalendar = paramCalendar.AddMinutes(paramInt1 + paramInt2);
	  }

	  private static void b(DateTime paramCalendar1, DateTime paramCalendar2, WheelView paramWheelView1, DateTime paramDate, WheelView paramWheelView2, DateTime paramCalendar3, bool paramBoolean)
	  {
		AbstractWheelTextAdapter abstractWheelTextAdapter1 = (AbstractWheelTextAdapter)paramWheelView1.ViewAdapter;
		AbstractWheelTextAdapter abstractWheelTextAdapter2 = (AbstractWheelTextAdapter)paramWheelView2.ViewAdapter;
		if (paramCalendar1.DayOfYear == paramCalendar2.DayOfYear)
		{
		  abstractWheelTextAdapter1.MinDisabledItemsBorder = paramDate.Hour;
		  if (paramCalendar1.Hour == paramCalendar2.Hour)
		  {
			abstractWheelTextAdapter2.MinDisabledItemsBorder = (int)Math.Ceiling(paramDate.Minute / 5.0D);
		  }
		  else
		  {
			abstractWheelTextAdapter2.MinDisabledItemsBorder = 0;
		  }
		}
		else
		{
		  abstractWheelTextAdapter1.MinDisabledItemsBorder = 0;
		  abstractWheelTextAdapter2.MinDisabledItemsBorder = 0;
		}
		if (paramBoolean)
		{
		  if (paramCalendar2.DayOfYear == paramCalendar3.DayOfYear)
		  {
			abstractWheelTextAdapter1.MaxDisabledItemsBorder = paramCalendar3.Hour;
			if (paramCalendar2.Hour == paramCalendar3.Hour)
			{
			  abstractWheelTextAdapter2.MaxDisabledItemsBorder = (int)Math.Ceiling(paramCalendar3.Minute / 5.0D);
			}
			else
			{
			  abstractWheelTextAdapter2.MaxDisabledItemsBorder = 2147483647;
			}
		  }
		  else
		  {
			abstractWheelTextAdapter1.MaxDisabledItemsBorder = 2147483647;
			abstractWheelTextAdapter2.MaxDisabledItemsBorder = 2147483647;
		  }
		}
		paramWheelView1.invalidateWheel(true);
		paramWheelView2.invalidateWheel(true);
	  }

	  private static void b(DateTime paramDate, TextView paramTextView, string paramString1, string paramString2, SimpleDateFormat paramSimpleDateFormat1, SimpleDateFormat paramSimpleDateFormat2, int paramInt)
	  {
		if (b(paramDate, paramInt))
		{
		  paramTextView.setText((CharSequence)Html.fromHtml(String.format(paramString1, new object[] {"<b><font size=20>" + paramSimpleDateFormat1.format(paramDate) + "</font></b>"})));
		  return;
		}
		paramTextView.setText((CharSequence)Html.fromHtml(String.format(paramString2, new object[] {"<b><font size=20>" + paramSimpleDateFormat2.format(paramDate) + "</font></b>"})));
	  }

	  private static bool b(DateTime paramDate, int paramInt)
	  {
		DateTime calendar = new DateTime();
		b(calendar, 40, paramInt);
		b(calendar);
		calendar = calendar.AddSeconds(1);
		return paramDate < calendar;
	  }

	  private bool c()
	  {
		return (this.q.Contains(this.d_Conflict.City) || (this.d_Conflict.GeoPoint != null && CoordConversion.getDistance(this.d_Conflict.GeoPoint, MapUtils.DEFAULT_POINT) < 100000.0D));
	  }

	  public static Dialog createDateTimeDialog(Activity paramActivity, int paramInt, DateTime paramDate, View.OnClickListener paramOnClickListener1, View.OnClickListener paramOnClickListener2, bool paramBoolean)
	  {
		Resources resources = paramActivity.getResources();
		Dialog dialog = new Dialog((Context)paramActivity);
		dialog.requestWindowFeature(3);
		dialog.setContentView(2130903043);
		dialog.setTitle(2131296417);
		dialog.setFeatureDrawable(3, resources.getDrawable(2130837571));
		DateTime calendar1 = new DateTime();
		b(calendar1, 0, paramInt);
		DateTime calendar2 = new DateTime();
		DateTime calendar3 = new DateTime();
		b(calendar3, 10, paramInt);
		b(calendar3);
		DateTime date1 = calendar3;
		DateTime calendar4 = new DateTime();
		b(calendar4, 40, paramInt);
		b(calendar4);
		DateTime date2 = calendar4;
		WheelView wheelView1 = (WheelView)dialog.findViewById(2131558412);
		wheelView1.ViewAdapter = (WheelViewAdapter)new NumericWheelAdapter((Context)paramActivity, 0, 23, "%02d");
		WheelView wheelView2 = (WheelView)dialog.findViewById(2131558413);
		string[] arrayOfString = new string[12];
		sbyte b1 = 0;
		for (sbyte b2 = 0; b1 < 60; b2++)
		{
		  arrayOfString[b2] = string.Format("{0:D2}", new object[] {Convert.ToInt32(b1)});
		  b1 += 5;
		}
		wheelView2.ViewAdapter = (WheelViewAdapter)new ArrayWheelAdapter((Context)paramActivity, (object[])arrayOfString);
		wheelView2.Cyclic = true;
		WheelView wheelView3 = (WheelView)dialog.findViewById(2131558411);
		wheelView3.ViewAdapter = (WheelViewAdapter)new DayArrayAdapter((Context)paramActivity, calendar1);
		calendar2 = new DateTime(paramDate);
		calendar2.set(11, calendar1.Hour);
		calendar2.set(12, calendar1.Minute);
		calendar2.set(13, calendar1.Second);
		calendar2.set(14, calendar1.Millisecond);
		wheelView3.CurrentItem = (int)((calendar2.Ticks - calendar1.Ticks) / 86400000L);
		calendar2 = new DateTime(paramDate);
		b(calendar2);
		wheelView1.CurrentItem = calendar2.Hour;
		wheelView2.CurrentItem = calendar2.Minute / 5;
		if (calendar3.Day != calendar1.Day)
		{
		  ((AbstractWheelTextAdapter)wheelView3.ViewAdapter).MinDisabledItemsBorder = 1;
		  if (wheelView3.CurrentItem == 0)
		  {
			wheelView3.CurrentItem = 1;
		  }
		}
		b(calendar3, calendar2, wheelView1, date1, wheelView2, calendar4, paramBoolean);
		if (paramBoolean)
		{
		  if (calendar3.DayOfYear == calendar4.DayOfYear)
		  {
			if (calendar3.Day != calendar1.Day)
			{
			  ((AbstractWheelTextAdapter)wheelView3.ViewAdapter).MaxDisabledItemsBorder = 1;
			  TextView textView2 = (TextView)dialog.findViewById(2131558401);
			  string str5 = resources.getString(2131296418);
			  string str6 = resources.getString(2131296419);
			  SimpleDateFormat simpleDateFormat3 = new SimpleDateFormat(resources.getString(2131296420), Utils.CurrentLocale);
			  simpleDateFormat2 = new SimpleDateFormat(resources.getString(2131296421), Utils.CurrentLocale);
			  b(calendar2, textView2, str5, str6, simpleDateFormat3, simpleDateFormat2, paramInt);
			  jf jf2 = new jf(calendar2, calendar1, wheelView3, wheelView1, arrayOfString, wheelView2, date1, calendar3, paramBoolean, date2, calendar4, simpleDateFormat2, simpleDateFormat3, textView2, str5, str6, paramInt);
			  wheelView1.addScrollingListener((OnWheelScrollListener)jf2);
			  wheelView2.addScrollingListener((OnWheelScrollListener)jf2);
			  wheelView3.addScrollingListener((OnWheelScrollListener)jf2);
			  jf2.onScrollingFinished(wheelView1);
			  ((Button)dialog.findViewById(2131558414)).setOnClickListener((View.OnClickListener)new jg(paramDate, calendar2, paramOnClickListener1));
			  ((Button)dialog.findViewById(2131558415)).setOnClickListener(paramOnClickListener2);
			  return dialog;
			}
			((AbstractWheelTextAdapter)wheelView3.ViewAdapter).MaxDisabledItemsBorder = 0;
			TextView textView1 = (TextView)dialog.findViewById(2131558401);
			string str3 = simpleDateFormat2.getString(2131296418);
			string str4 = simpleDateFormat2.getString(2131296419);
			SimpleDateFormat simpleDateFormat = new SimpleDateFormat(simpleDateFormat2.getString(2131296420), Utils.CurrentLocale);
			simpleDateFormat2 = new SimpleDateFormat(simpleDateFormat2.getString(2131296421), Utils.CurrentLocale);
			b(calendar2, textView1, str3, str4, simpleDateFormat, simpleDateFormat2, paramInt);
			jf jf1 = new jf(calendar2, calendar1, wheelView3, wheelView1, arrayOfString, wheelView2, date1, calendar3, paramBoolean, date2, calendar4, simpleDateFormat2, simpleDateFormat, textView1, str3, str4, paramInt);
			wheelView1.addScrollingListener((OnWheelScrollListener)jf1);
			wheelView2.addScrollingListener((OnWheelScrollListener)jf1);
			wheelView3.addScrollingListener((OnWheelScrollListener)jf1);
			jf1.onScrollingFinished(wheelView1);
			((Button)dialog.findViewById(2131558414)).setOnClickListener((View.OnClickListener)new jg(paramDate, calendar2, paramOnClickListener1));
			((Button)dialog.findViewById(2131558415)).setOnClickListener(paramOnClickListener2);
			return dialog;
		  }
		}
		else
		{
		  TextView textView1 = (TextView)dialog.findViewById(2131558401);
		  string str3 = simpleDateFormat2.getString(2131296418);
		  string str4 = simpleDateFormat2.getString(2131296419);
		  SimpleDateFormat simpleDateFormat = new SimpleDateFormat(simpleDateFormat2.getString(2131296420), Utils.CurrentLocale);
		  simpleDateFormat2 = new SimpleDateFormat(simpleDateFormat2.getString(2131296421), Utils.CurrentLocale);
		  b(calendar2, textView1, str3, str4, simpleDateFormat, simpleDateFormat2, paramInt);
		  jf jf1 = new jf(calendar2, calendar1, wheelView3, wheelView1, arrayOfString, wheelView2, date1, calendar3, paramBoolean, date2, calendar4, simpleDateFormat2, simpleDateFormat, textView1, str3, str4, paramInt);
		  wheelView1.addScrollingListener((OnWheelScrollListener)jf1);
		  wheelView2.addScrollingListener((OnWheelScrollListener)jf1);
		  wheelView3.addScrollingListener((OnWheelScrollListener)jf1);
		  jf1.onScrollingFinished(wheelView1);
		  ((Button)dialog.findViewById(2131558414)).setOnClickListener((View.OnClickListener)new jg(paramDate, calendar2, paramOnClickListener1));
		  ((Button)dialog.findViewById(2131558415)).setOnClickListener(paramOnClickListener2);
		  return dialog;
		}
		((AbstractWheelTextAdapter)wheelView3.ViewAdapter).MaxDisabledItemsBorder = 1;
		TextView textView = (TextView)dialog.findViewById(2131558401);
		string str1 = simpleDateFormat2.getString(2131296418);
		string str2 = simpleDateFormat2.getString(2131296419);
		SimpleDateFormat simpleDateFormat1 = new SimpleDateFormat(simpleDateFormat2.getString(2131296420), Utils.CurrentLocale);
		SimpleDateFormat simpleDateFormat2 = new SimpleDateFormat(simpleDateFormat2.getString(2131296421), Utils.CurrentLocale);
		b(calendar2, textView, str1, str2, simpleDateFormat1, simpleDateFormat2, paramInt);
		jf jf = new jf(calendar2, calendar1, wheelView3, wheelView1, arrayOfString, wheelView2, date1, calendar3, paramBoolean, date2, calendar4, simpleDateFormat2, simpleDateFormat1, textView, str1, str2, paramInt);
		wheelView1.addScrollingListener((OnWheelScrollListener)jf);
		wheelView2.addScrollingListener((OnWheelScrollListener)jf);
		wheelView3.addScrollingListener((OnWheelScrollListener)jf);
		jf.onScrollingFinished(wheelView1);
		((Button)dialog.findViewById(2131558414)).setOnClickListener((View.OnClickListener)new jg(paramDate, calendar2, paramOnClickListener1));
		((Button)dialog.findViewById(2131558415)).setOnClickListener(paramOnClickListener2);
		return dialog;
	  }

	  private void d()
	  {
		if (this.d_Conflict == null || (this.r && "".Equals(this.d_Conflict.House) && !this.d_Conflict.Exact))
		{
		  showDialog(3);
		  return;
		}
		e();
	  }

	  private void e()
	  {
		if (this.o && this.r)
		{
		  DateTime calendar = new DateTime();
		  b(calendar, 10, this.l_Conflict);
		  DateTime date = calendar;
		  if (this.i_Conflict.AllUnchecked)
		  {
			showDialog(14);
			return;
		  }
		  if (this.f_Conflict < date)
		  {
			showDialog(15);
			return;
		  }
		  if (this.s.getBoolean("authorized", false))
		  {
			showDialog(5);
			return;
		  }
		  showDialog(4);
		  return;
		}
		f();
	  }

	  private void f()
	  {
		this.t.Clear();
		DateTime calendar = new DateTime();
		b(calendar, 35, this.l_Conflict);
		if (!this.r || this.f_Conflict > calendar)
		{
		  Intent intent = new Intent((Context)this, typeof(TaxiListActivity));
		  intent.putExtra("src point", (Parcelable)this.d_Conflict);
		  intent.putExtra("dest point", (Parcelable)this.e_Conflict);
		  intent.putExtra("when", this.f_Conflict);
		  intent.putExtra("requirements", (Serializable)this.h_Conflict);
		  startActivity(intent);
		  return;
		}
		showDialog(11);
	  }

	  private void g()
	  {
		(new hr(this)).execute((object[])new int?[0]);
	  }

	  public static string getDateString(Resources paramResources, DateTime paramDate, int paramInt)
	  {
		string str2 = paramResources.getString(2131296398);
		string str3 = paramResources.getString(2131296399);
		string str1 = paramResources.getString(2131296400);
		DateTime calendar = new DateTime();
		b(calendar, 0, paramInt);
		if (calendar.Day != paramDate.Day)
		{
		  calendar = calendar.AddDays(1);
		  if (calendar.Day == paramDate.Day)
		  {
			str1 = str3;
			return (new SimpleDateFormat(str1, Utils.CurrentLocale)).format(paramDate);
		  }
		  str1 = str2;
		}
		return (new SimpleDateFormat(str1, Utils.CurrentLocale)).format(paramDate);
	  }

	  private Dialog h()
	  {
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)this);
		long l = this.s.getLong("last msg show", 0L);
		int i = this.u.Count;
		ServerMsg serverMsg = null;
		i--;
		while (true)
		{
		  if (i >= 0)
		  {
			serverMsg = this.u[i];
			this.u.Remove(serverMsg);
			if (serverMsg.date.Ticks > l)
			{
			  this.s.edit().putLong("last msg show", serverMsg.date.Ticks).commit();
			  builder.setTitle(serverMsg.header).setMessage(serverMsg.msg).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new ia(this));
			  return (Dialog)builder.create();
			}
		  }
		  else
		  {
			builder.setTitle(serverMsg.header).setMessage(serverMsg.msg).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new ia(this));
			return (Dialog)builder.create();
		  }
		  i--;
		}
	  }

	  private Dialog i()
	  {
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)this);
		string[] arrayOfString = new string[this.t.Count];
		for (sbyte b = 0; b < this.t.Count; b++)
		{
		  CurrentOrder currentOrder = this.t[b];
		  arrayOfString[b] = getDateString(getResources(), currentOrder.due, this.l_Conflict);
		}
		builder.setTitle(2131296449).setItems((CharSequence[])arrayOfString, (DialogInterface.OnClickListener)new ij(this));
		return (Dialog)builder.create();
	  }

	  private string j()
	  {
		string str1 = this.s.getString("phone number", "");
		string str2 = "";
		if (str1.Length > 0)
		{
		  str2 = Utils.getFormatedPhoneNumber(str1).replaceAll("\\s", " ");
		}
		return str2;
	  }

	  private void k()
	  {
		int i;
		this.o = b(this.f_Conflict, this.l_Conflict);
		if (!this.o || (this.d_Conflict != null && !this.r))
		{
		  i = 2131296403;
		}
		else
		{
		  i = 2131296404;
		}
		this.J.setText(i);
		(new jy(this)).execute((object[])new int?[] {Convert.ToInt32(0)});
		l();
	  }

	  private void l()
	  {
		Resources resources = getResources();
		TextView textView = this.I[0];
		if (this.d_Conflict == null)
		{
		  str = resources.getString(2131296405);
		}
		else if (this.r)
		{
		  str = this.d_Conflict.ShortAddress;
		}
		else
		{
		  str = this.d_Conflict.City;
		}
		textView.setText(str);
		textView = this.I[1];
		if (this.e_Conflict == null)
		{
		  str = resources.getString(2131296406);
		}
		else if (this.r)
		{
		  str = this.e_Conflict.ShortAddress;
		}
		else
		{
		  str = this.e_Conflict.City;
		}
		textView.setText(str);
		((TextView)this.I[2]).setText(getDateString(getResources(), this.f_Conflict, this.l_Conflict));
		string str = "";
		if (this.o)
		{
		  string str1;
		  if (this.i_Conflict.ClassesCount != 3)
		  {
			if (this.i_Conflict.ClassesCount == 1)
			{
			  str1 = this.m_Conflict[this.n.IndexOf(this.i_Conflict.getClass(0))];
			}
			else
			{
			  str1 = String.format(resources.getString(2131296409), new object[] {this.m_Conflict[this.n.IndexOf(this.i_Conflict.getClass(0))], ((string)this.m_Conflict[this.n.IndexOf(this.i_Conflict.getClass(1))]).ToLower()});
			}
		  }
		  else
		  {
			str1 = resources.getString(2131296407);
		  }
		  str = str1;
		  if (this.i_Conflict.ExcludeParksCount > 0)
		  {
			string str2 = resources.getString(2131296408);
			str = str2;
			if (!"".Equals(str1))
			{
			  str = ", " + str2.ToLower();
			}
			str = str1 + str;
		  }
		}
		if (this.h_Conflict.Default)
		{
		  string str1 = resources.getString(2131296410);
		  StringBuilder stringBuilder = (new StringBuilder()).Append(str);
		  if ("".Equals(str))
		  {
			str = str1;
		  }
		  else
		  {
			str = ", " + str1.ToLower();
		  }
		  str = stringBuilder.Append(str).ToString();
		}
		else
		{
		  string str1 = str;
		  if (this.h_Conflict.conditioner)
		  {
			StringBuilder stringBuilder = (new StringBuilder()).Append(str);
			if ("".Equals(str))
			{
			  str = "";
			}
			else
			{
			  str = ", ";
			}
			str1 = stringBuilder.Append(str).Append(resources.getString(2131296416)).ToString();
		  }
		  if ("2".Equals(this.h_Conflict.smoke))
		  {
			StringBuilder stringBuilder = (new StringBuilder()).Append(str1);
			if ("".Equals(str1))
			{
			  str = "";
			}
			else
			{
			  str = ", ";
			}
			str = stringBuilder.Append(str).Append(resources.getString(2131296412)).ToString();
		  }
		  else
		  {
			str = str1;
			if ("1".Equals(this.h_Conflict.smoke))
			{
			  StringBuilder stringBuilder = (new StringBuilder()).Append(str1);
			  if ("".Equals(str1))
			  {
				str = "";
			  }
			  else
			  {
				str = ", ";
			  }
			  str = stringBuilder.Append(str).Append(resources.getString(2131296413)).ToString();
			}
		  }
		  str1 = str;
		  if (this.h_Conflict.animal)
		  {
			StringBuilder stringBuilder = (new StringBuilder()).Append(str);
			if ("".Equals(str))
			{
			  str = "";
			}
			else
			{
			  str = ", ";
			}
			str1 = stringBuilder.Append(str).Append(resources.getString(2131296414)).ToString();
		  }
		  str = str1;
		  if (this.h_Conflict.universal)
		  {
			StringBuilder stringBuilder = (new StringBuilder()).Append(str1);
			if ("".Equals(str1))
			{
			  str = "";
			}
			else
			{
			  str = ", ";
			}
			str = stringBuilder.Append(str).Append(resources.getString(2131296411)).ToString();
		  }
		  if (!this.o && !"0".Equals(this.h_Conflict.childChair))
		  {
			StringBuilder stringBuilder = (new StringBuilder()).Append(str);
			if ("".Equals(str))
			{
			  str = "";
			}
			else
			{
			  str = ", ";
			}
			str = stringBuilder.Append(str).Append(resources.getString(2131296415)).ToString();
		  }
		}
		((TextView)this.I[3]).setText(str);
	  }

	  private void m()
	  {
		if (this.t.Count == 1)
		{
		  a(this.t[0]);
		  return;
		}
		if (this.t.Count > 1)
		{
		  showDialog(10);
		  return;
		}
		this.C = getResources().getString(2131296395);
		this.D = 2131296392;
		showDialog(8);
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
			  this.h_Conflict = (Requirements)paramIntent.getSerializableExtra("requirements");
				goto case 5;
			case 5:
			  this.i_Conflict = (TariffLimits)paramIntent.getSerializableExtra("tariff limits");
			  this.h_Conflict = (Requirements)paramIntent.getSerializableExtra("requirements");
				goto case 1;
			case 1:
			  this.B = true;
			  this.d_Conflict = (GeocodeJsonObject)paramIntent.getParcelableExtra("address");
			  if (this.d_Conflict == null)
			  {
				this.s.edit().putLong("last address date", DateTimeHelper.CurrentUnixTimeMillis() - 3600000L - 1L).commit();
				a();
			  }
			  this.r = c();
			  b();
			  if (!this.r)
			  {
				showDialog(1);
			  }
			  if (this.d_Conflict != null)
			  {
				if (!this.d_Conflict.Exact)
				{
				  this.A = true;
				  (new jr(this, this.d_Conflict, 0)).execute((object[])new int?[0]);
				}
				a(this.d_Conflict, "last address", "last address date");
			  }
				goto case 2;
			case 2:
			  this.e_Conflict = (GeocodeJsonObject)paramIntent.getParcelableExtra("address");
			  this.s.edit().putLong("last dest address date", DateTimeHelper.CurrentUnixTimeMillis() - 3600000L - 1L).commit();
			  if (this.e_Conflict != null && !this.e_Conflict.Exact)
			  {
				(new jr(this, this.e_Conflict, 1)).execute((object[])new int?[0]);
			  }
			  if (this.e_Conflict != null)
			  {
				a(this.e_Conflict, "last dest address", "last dest address date");
			  }
				goto case 3;
			case 3:
			  this.d_Conflict = (GeocodeJsonObject)paramIntent.getParcelableExtra("address");
			  if (this.d_Conflict != null)
			  {
				this.r = c();
				b();
				EditAddressActivity.saveStreetHistory(-1L, getContentResolver(), 1, this.d_Conflict, false, false);
				a(this.d_Conflict, "last address", "last address date");
				e();
			  }
			  this.s.edit().putLong("last address date", DateTimeHelper.CurrentUnixTimeMillis() - 3600000L - 1L).commit();
			  a();
				goto case 4;
			case 4:
			  if (this.r)
			  {
				g();
			  }
			  f();
				goto case 6;
			case 6:
			  break;
		  }
		  m();
		}
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		Analytics.initExceptionHandler(getApplicationContext(), "ui");
		setContentView(2130903049);
		getWindow().setFormat(1);
		this.J = (Button)findViewById(2131558448);
		this.K = (TextView)findViewById(2131558445);
		this.L = (TextView)findViewById(2131558444);
		this.M = (TextView)findViewById(2131558432);
		this.O = findViewById(2131558446);
		this.P = (TextView)findViewById(2131558447);
		SlidingDrawer slidingDrawer = (SlidingDrawer)findViewById(2131558449);
		slidingDrawer.OnDrawerCloseListener = (SlidingDrawer.OnDrawerCloseListener)new jh(this);
		slidingDrawer.OnDrawerOpenListener = (SlidingDrawer.OnDrawerOpenListener)new jk(this);
		this.J.setOnClickListener((View.OnClickListener)new jl(this));
		LinearLayout linearLayout = (LinearLayout)findViewById(2131558442);
		LayoutInflater layoutInflater = (LayoutInflater)getSystemService("layout_inflater");
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2130837576, 2131296423, (View.OnClickListener)new jp(this));
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2130837598, 2131296424, (View.OnClickListener)new hn(this));
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2130837599, 2131296417, (View.OnClickListener)new ho(this));
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2130837582, 2131296388, (View.OnClickListener)new hp(this));
		((TextView)this.I[3]).setSingleLine(false);
		Resources resources = getResources();
		this.W = BitmapFactory.decodeResource(resources, 2130837546);
		this.X = BitmapFactory.decodeResource(resources, 2130837550);
		this.T = (MapView)findViewById(2131558454);
		this.T.showZoomButtons(true);
		this.T.showJamsButton(true);
		this.T.showFindMeButton(false);
		this.U = this.T.MapController;
		this.V = this.U.OverlayManager;
		this.U.ZoomCurrent = 12.0F;
		this.V.MyLocation.Enabled = false;
		this.Y = new Overlay(this.U);
		this.Z = new Overlay(this.U);
		this.aa = new Overlay(this.U);
		this.V.addOverlay(this.Y);
		this.V.addOverlay(this.Z);
		this.V.addOverlay(this.aa);
		this.ac = getTabHost();
		this.ad = (ProgressBar)findViewById(2131558455);
		a(2131296462, -1, "all taxi");
		a(2131296463, 2131296464, "free taxi");
		this.ac.setCurrentTab(1);
		this.ac.setCurrentTab(0);
		this.ac.setOnTabChangedListener((TabHost.OnTabChangeListener)new jo(this));
		this.s = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
		resources = getResources();
		this.m_Conflict.Add(resources.getString(2131296532));
		this.m_Conflict.Add(resources.getString(2131296533));
		this.m_Conflict.Add(resources.getString(2131296534));
		this.n.Add("econom");
		this.n.Add("business");
		this.n.Add("vip");
		this.p = new TaxiClient(getApplicationContext(), (HttpUtils)new HttpUrlConnectionUtils());
		(new jq(this)).execute((object[])new int?[0]);
		this.b_Conflict = "<b><font size='24' color='white'>%1$s</font></b>";
		this.c_Conflict = "<b><font size='+10'>%1$s</font></b>";
		this.q = (List<string>)new ii(this);
		DateTime calendar = new DateTime();
		b(calendar, 20, this.l_Conflict);
		b(calendar);
		this.f_Conflict = calendar;
		this.h_Conflict = new Requirements((Context)this);
		this.h_Conflict.Requirements = this.s.getString("requirements", "");
		this.i_Conflict.setTariffLimits(this.s.getString("classes", this.i_Conflict.ClassesString), this.s.getString("excluded parks", ""));
		a();
		if (!this.s.getBoolean("first launch", false) && ((ConnectivityManager)getSystemService("connectivity")).getNetworkInfo(1).isConnected() && Utils.isVideoCompatible((Activity)this))
		{
		  this.s.edit().putBoolean("first launch", true).commit();
		  showDialog(13);
		}
		if (this.s.getBoolean("need rate", false))
		{
		  this.s.edit().putBoolean("need rate", false).commit();
		  showDialog(18);
		}
		(new Thread((ThreadStart)new hx(this))).Start();
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		AlertDialog.Builder builder9;
		AlertDialog alertDialog11;
		string str4;
		AlertDialog alertDialog10;
		Dialog dialog6;
		AlertDialog.Builder builder8;
		AlertDialog alertDialog9;
		AlertDialog.Builder builder7;
		AlertDialog alertDialog8;
		Dialog dialog5;
		string str3;
		Button button1;
		Dialog dialog4;
		string str2;
		AlertDialog alertDialog7;
		string str1;
		AlertDialog.Builder builder6;
		AlertDialog alertDialog6;
		Dialog dialog3;
		AlertDialog.Builder builder5;
		AlertDialog alertDialog5;
		AlertDialog.Builder builder4;
		AlertDialog alertDialog4;
		AlertDialog.Builder builder3;
		AlertDialog alertDialog3;
		AlertDialog.Builder builder2;
		AlertDialog alertDialog2;
		Dialog dialog2;
		AlertDialog.Builder builder1;
		AlertDialog alertDialog1;
		AlertDialog.Builder builder11;
		Button button3;
		Dialog dialog8;
		AlertDialog.Builder builder10;
		string str5;
		TextView textView;
		Resources resources;
		Dialog dialog7 = null;
		switch (paramInt)
		{
		  default:
			return dialog7;
		  case 9:
			builder9 = new AlertDialog.Builder((Context)this);
			builder9.setTitle(2131296392).setMessage(2131296396).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new @in(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new im());
			alertDialog11 = builder9.create();
			  goto case 1;
		  case 1:
			if (this.d_Conflict == null)
			{
			  str4 = "";
			}
			else
			{
			  str4 = this.d_Conflict.City;
			}
			str4 = String.format(getResources().getString(2131296426), new object[] {str4});
			builder11 = new AlertDialog.Builder((Context)this);
			builder11.setTitle(2131296425).setMessage(str4).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new je(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new jd(this));
			alertDialog10 = builder11.create();
			  goto case 0;
		  case 0:
			dialog6 = createDateTimeDialog((Activity)this, this.l_Conflict, this.f_Conflict, (View.OnClickListener)new hs(this), (View.OnClickListener)new ht(this), false);
			  goto case 2;
		  case 2:
			builder8 = new AlertDialog.Builder((Context)this);
			builder8.setTitle(2131296432).setMessage(2131296434).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new jc(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new jb(this));
			alertDialog9 = builder8.create();
			  goto case 3;
		  case 3:
			builder7 = new AlertDialog.Builder((Context)this);
			builder7.setTitle(2131296432).setMessage(2131296433).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new ja(this));
			alertDialog8 = builder7.create();
			  goto case 4;
		  case 4:
			dialog5 = new Dialog((Context)this);
			dialog5.setContentView(2130903063);
			dialog5.setTitle(2131296404);
			((TextView)dialog5.findViewById(2131558401)).setText(2131296437);
			dialog5.findViewById(2131558448).setVisibility(8);
			button3 = (Button)dialog5.findViewById(2131558486);
			button3.setText(2131296440);
			button3.setOnClickListener((View.OnClickListener)new iy(this));
			((Button)dialog5.findViewById(2131558487)).setVisibility(8);
			((Button)dialog5.findViewById(2131558415)).setOnClickListener((View.OnClickListener)new iz(this));
			  goto case 5;
		  case 5:
			dialog8 = new Dialog((Context)this);
			dialog8.setContentView(2130903063);
			dialog8.setTitle(2131296404);
			textView = (TextView)dialog8.findViewById(2131558401);
			if (this.d_Conflict == null)
			{
			  str3 = String.format(getResources().getString(2131296436), new object[] {j()});
			}
			else
			{
			  str3 = String.format(getResources().getString(2131296435), new object[] {this.d_Conflict.ShortAddress, j()});
			}
			textView.setText((CharSequence)Html.fromHtml(str3));
			((Button)dialog8.findViewById(2131558448)).setOnClickListener((View.OnClickListener)new ir(this));
			button1 = (Button)dialog8.findViewById(2131558486);
			button1.setText(2131296439);
			button1.setOnClickListener((View.OnClickListener)new @is(this));
			((Button)dialog8.findViewById(2131558487)).setVisibility(8);
			((Button)dialog8.findViewById(2131558415)).setOnClickListener((View.OnClickListener)new ix(this));
			dialog4 = dialog8;
			  goto case 6;
		  case 6:
			str2 = this.C;
			builder10 = new AlertDialog.Builder((Context)this);
			builder10.setTitle(2131296508).setMessage(str2).setPositiveButton(2131296446, (DialogInterface.OnClickListener)new iq(this)).setNegativeButton(2131296279, (DialogInterface.OnClickListener)new ip(this));
			alertDialog7 = builder10.create();
			  goto case 7;
		  case 7:
			resources = getResources();
			str5 = resources.getString(2131296447);
			if (this.d_Conflict != null)
			{
			  str1 = this.d_Conflict.City;
			}
			else
			{
			  str1 = "";
			}
			str5 = String.format(str5, new object[] {str1, resources.getString(2131296388)});
			builder6 = new AlertDialog.Builder((Context)this);
			builder6.setTitle(2131296448).setMessage(str5).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new il(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new ik(this));
			alertDialog6 = builder6.create();
			  goto case 8;
		  case 8:
			dialog3 = a(this.D, this.C);
			  goto case 10;
		  case 10:
			dialog3 = i();
			  goto case 11;
		  case 11:
			dialog3 = a(2131296450, getResources().getString(2131296451));
			  goto case 12;
		  case 12:
			builder5 = new AlertDialog.Builder((Context)this);
			builder5.setTitle(2131296392).setMessage(2131296397).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new ig(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new if (this));
			alertDialog5 = builder5.create();
			  goto case 13;
		  case 13:
			builder4 = new AlertDialog.Builder((Context)this);
			builder4.setTitle(2131296457).setMessage(2131296458).setPositiveButton(2131296459, (DialogInterface.OnClickListener)new ie(this)).setNegativeButton(2131296279, (DialogInterface.OnClickListener)new id(this));
			alertDialog4 = builder4.create();
			  goto case 14;
		  case 14:
			builder3 = new AlertDialog.Builder((Context)this);
			builder3.setTitle(2131296508).setMessage(2131296460).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new ic(this));
			alertDialog3 = builder3.create();
			  goto case 15;
		  case 15:
			builder2 = new AlertDialog.Builder((Context)this);
			builder2.setTitle(2131296508).setMessage(2131296461).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new ib(this));
			alertDialog2 = builder2.create();
			  goto case 16;
		  case 16:
			dialog2 = h();
			  goto case 17;
		  case 17:
			builder1 = new AlertDialog.Builder((Context)this);
			builder1.setTitle(2131296466).setMessage(2131296467).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new hz(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new hy(this));
			alertDialog1 = builder1.create();
			  goto case 18;
		  case 18:
			break;
		}
		Dialog dialog1 = new Dialog((Context)this);
		dialog1.setContentView(2130903063);
		dialog1.setTitle(2131296468);
		((TextView)dialog1.findViewById(2131558401)).setText(2131296469);
		Button button2 = (Button)dialog1.findViewById(2131558448);
		button2.setText(2131296470);
		button2.setOnClickListener((View.OnClickListener)new hu(this));
		dialog1.findViewById(2131558486).setVisibility(8);
		button2 = (Button)dialog1.findViewById(2131558487);
		button2.setText(2131296471);
		button2.setOnClickListener((View.OnClickListener)new hv(this));
		button2 = (Button)dialog1.findViewById(2131558415);
		button2.setText(2131296472);
		button2.setOnClickListener((View.OnClickListener)new hw(this));
	  }

	  public virtual bool onCreateOptionsMenu(Menu paramMenu)
	  {
		paramMenu.add(0, 0, 0, 2131296392).setIcon(2130837608);
		paramMenu.add(0, 1, 0, 2131296473).setIcon(2130837609);
		paramMenu.add(0, 2, 0, 2131296393).setIcon(2130837606);
		return true;
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
		SlidingDrawer slidingDrawer = (SlidingDrawer)findViewById(2131558449);
		if (slidingDrawer.Opened)
		{
		  slidingDrawer.animateClose();
		  return true;
		}
	  }

	  public virtual bool onOptionsItemSelected(MenuItem paramMenuItem)
	  {
		switch (paramMenuItem.getItemId())
		{
		  default:
			return true;
		  case 1:
			startActivity(new Intent((Context)this, typeof(InfoActivity)));
			  goto case 0;
		  case 0:
			(new ji(this)).execute((object[])new int?[0]);
			  goto case 2;
		  case 2:
			break;
		}
		Intent intent = new Intent((Context)this, typeof(RequirementsActivity));
		intent.putExtra("requirements", (Serializable)this.h_Conflict);
		intent.putExtra("rush order", this.o);
		startActivityForResult(intent, 0);
	  }

	  protected internal virtual void onPause()
	  {
		if (this.w != null)
		{
		  this.w.Interrupt();
		}
		this.z = true;
		base.onPause();
	  }

	  public virtual bool onPrepareOptionsMenu(Menu paramMenu)
	  {
		MenuItem menuItem = paramMenu.getItem(2);
		if (this.d_Conflict == null || this.r)
		{
		  bool bool1 = true;
		  menuItem.setEnabled(bool1);
		  return base.onPrepareOptionsMenu(paramMenu);
		}
		bool @bool = false;
		menuItem.setEnabled(@bool);
		return base.onPrepareOptionsMenu(paramMenu);
	  }

	  protected internal virtual void onResume()
	  {
		this.z = false;
		DateTime calendar = new DateTime();
		b(calendar, 20, this.l_Conflict);
		DateTime date = calendar;
		if (!this.g_Conflict && this.f_Conflict < date)
		{
		  b(calendar);
		  this.f_Conflict = calendar;
		}
		k();
		if (this.a_Conflict >= 0)
		{
		  showDialog(this.a_Conflict);
		  this.a_Conflict = -1;
		}
		base.onResume();
	  }

	  protected internal virtual void onStart()
	  {
		base.onStart();
		this.s.edit().putBoolean("notification call", false).commit();
		this.y = true;
		IntentFilter intentFilter = new IntentFilter("android.net.conn.CONNECTIVITY_CHANGE");
		intentFilter.addAction("android.net.wifi.STATE_CHANGE");
		registerReceiver(this.H, intentFilter);
		string str1 = this.s.getString("online cars", null);
		string str2 = this.s.getString("online parks", null);
		if (!string.ReferenceEquals(str1, null))
		{
		  a(str2, str1);
		}
	  }

	  protected internal virtual void onStop()
	  {
		base.onStop();
		this.y = false;
		unregisterReceiver(this.H);
		SharedPreferences.Editor editor = this.s.edit();
		editor.putString("online parks", this.F);
		editor.putString("online cars", this.G);
		editor.commit();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\OrderActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}