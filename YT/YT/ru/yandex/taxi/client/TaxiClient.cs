using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ru.yandex.taxi.client
{
	using PendingIntent = android.app.PendingIntent;
	using ContentResolver = android.content.ContentResolver;
	using ContentValues = android.content.ContentValues;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using SharedPreferences = android.content.SharedPreferences;
	using Cursor = android.database.Cursor;
	using Bitmap = android.graphics.Bitmap;
	using BitmapFactory = android.graphics.BitmapFactory;
	using Uri = android.net.Uri;
	using WifiInfo = android.net.wifi.WifiInfo;
	using WifiManager = android.net.wifi.WifiManager;
	using Build = android.os.Build;
	using Parcelable = android.os.Parcelable;
	using PreferenceManager = android.preference.PreferenceManager;
	using TelephonyManager = android.telephony.TelephonyManager;
	using GsmCellLocation = android.telephony.gsm.GsmCellLocation;
	using Log = android.util.Log;
	using Gson = com.google.gson.Gson;
	using HttpEntity = org.apache.http.HttpEntity;
	using HttpResponse = org.apache.http.HttpResponse;
	using HttpGet = org.apache.http.client.methods.HttpGet;
	using HttpUriRequest = org.apache.http.client.methods.HttpUriRequest;
	using DefaultHttpClient = org.apache.http.impl.client.DefaultHttpClient;
	using JSONArray = org.json.JSONArray;
	using JSONException = org.json.JSONException;
	using JSONObject = org.json.JSONObject;
	using pl;
	using pm;
	using pn;
	using po;
	using pp;
	using pq;
	using pr;
	using ps;
	using pt;
	using pu;
	using pv;
	using pz;
	using qa;
	using qb;
	using qc;
	using qd;
	using ru.yandex.taxi;
	using Startup = ru.yandex.taxi.Startup;
	using AllCarsResponse = ru.yandex.taxi.client.response.AllCarsResponse;
	using GeocodeResponse = ru.yandex.taxi.client.response.GeocodeResponse;
	using LaunchResponse = ru.yandex.taxi.client.response.LaunchResponse;
	using OnTheWayResponse = ru.yandex.taxi.client.response.OnTheWayResponse;
	using SearchResponse = ru.yandex.taxi.client.response.SearchResponse;
	using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;
	using TaxiResponse = ru.yandex.taxi.client.response.TaxiResponse;
	using CurrentOrder = ru.yandex.taxi.data.CurrentOrder;
	using Park = ru.yandex.taxi.data.Park;
	using Requirements = ru.yandex.taxi.data.Requirements;
	using ServerMsg = ru.yandex.taxi.data.ServerMsg;
	using Tariff = ru.yandex.taxi.data.Tariff;
	using TariffLimits = ru.yandex.taxi.data.TariffLimits;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class TaxiClient
	{
	  public const string BREAK_BY_TIMEOUT = "timeout";

	  public const string BREAK_BY_USER = "user";

	  public const string BREAK_NONE = "none";

	  public static readonly SimpleDateFormat DATE_FORMAT;

	  public const string PRODUCTION_SERVER = "production server";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static string a_Conflict = "TaxiClient";

	  private static int b;

	  public static string sProtocolUrl;

	  public static string sServerUrl;

	  private HttpUtils c;

	  private Context d;

	  static TaxiClient()
	  {
		DATE_FORMAT = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss");
		b = 3000;
	  }

	  public TaxiClient(Context paramContext, HttpUtils paramHttpUtils)
	  {
		this.d = paramContext;
		this.c = paramHttpUtils;
		if (string.ReferenceEquals(sServerUrl, null))
		{
		  switchServerUrl(paramContext);
		}
	  }

	  private SimpleResponse a(string paramString, string[] paramArrayOfString1, string[] paramArrayOfString2, string[] paramArrayOfString3)
	  {
		SimpleResponse simpleResponse = new SimpleResponse(a(paramString, (JSONObject)new pu(paramArrayOfString1, paramArrayOfString2), false));
		if (simpleResponse.Code == 200 && !simpleResponse.Blocked)
		{
		  JSONObject jSONObject = new JSONObject(simpleResponse.RowData);
		  Dictionary<object, object> hashMap = new Dictionary<object, object>();
		  a(paramArrayOfString3, jSONObject, (Hashtable)hashMap);
		  simpleResponse.Data = hashMap;
		}
		return simpleResponse;
	  }

	  private TaxiResponse a(string paramString, JSONObject paramJSONObject, bool paramBoolean)
	  {
		this.d.getPackageManager().getPackageInfo(this.d.getPackageName(), 0);
		TaxiResponse taxiResponse = this.c.post(sServerUrl + sProtocolUrl + paramString, (System.Collections.IDictionary)new pv(paramBoolean), paramJSONObject.ToString(), paramBoolean);
		if (taxiResponse.Code == 200 || taxiResponse.Code == 403)
		{
		  try
		  {
			paramJSONObject = new JSONObject();
			this(taxiResponse.RowData);
			if (!paramJSONObject.isNull("blocked"))
			{
			  taxiResponse.Blocked = true;
			  taxiResponse.BlockDate = DATE_FORMAT.parse(paramJSONObject.getString("blocked"));
			  if (!paramJSONObject.isNull("type"))
			  {
				taxiResponse.BlockType = paramJSONObject.getString("type");
			  }
			}
		  }
		  catch (JSONException)
		  {
		  }
		}
		return taxiResponse;
	  }

	  private Tariff.TariffDescription a(JSONObject paramJSONObject)
	  {
		Tariff.TariffDescription tariffDescription = new Tariff.TariffDescription();
		JSONArray jSONArray = paramJSONObject.getJSONArray("schedule");
		for (sbyte b = 0; b < jSONArray.length(); b++)
		{
		  JSONObject jSONObject1 = jSONArray.getJSONObject(b);
		  Tariff.Schedule schedule = new Tariff.Schedule();
		  schedule.start = jSONObject1.getString("start");
		  schedule.end = jSONObject1.getString("end");
		  JSONArray jSONArray1 = jSONObject1.getJSONArray("days");
		  for (sbyte b1 = 0; b1 < jSONArray1.length(); b1++)
		  {
			schedule.days.add(Convert.ToInt32(jSONArray1.getInt(b1)));
		  }
		  tariffDescription.schedules.add(schedule);
		}
		if (!paramJSONObject.isNull("special"))
		{
		  tariffDescription.special = paramJSONObject.getString("special");
		}
		if (!paramJSONObject.isNull("comment"))
		{
		  tariffDescription.comment = paramJSONObject.getString("comment");
		}
		a(tariffDescription.city, paramJSONObject.getJSONArray("city"));
		a(tariffDescription.region, paramJSONObject.getJSONArray("region"));
		JSONObject jSONObject = paramJSONObject.getJSONObject("transfers");
		if (!jSONObject.isNull("to_airport"))
		{
		  a(tariffDescription.toAirport, jSONObject.getJSONArray("to_airport"), "from");
		}
		if (!jSONObject.isNull("from_airport"))
		{
		  a(tariffDescription.fromAirport, jSONObject.getJSONArray("from_airport"), "to");
		}
		if (!jSONObject.isNull("other"))
		{
		  a(tariffDescription.other, jSONObject.getJSONArray("other"), "options");
		}
		if (!jSONObject.isNull("airport_to_airport"))
		{
		  a(tariffDescription.airportToAirport, jSONObject.getJSONArray("airport_to_airport"));
		}
		if (!jSONObject.isNull("overprice"))
		{
		  a(tariffDescription.transferComments, jSONObject.getJSONArray("overprice"));
		}
		if (!jSONObject.isNull("comment"))
		{
		  tariffDescription.transferComments.add(new Pair(this.d.getResources().getString(2131296485), jSONObject.getString("comment")));
		}
		if (!paramJSONObject.isNull("other"))
		{
		  a(tariffDescription.overprice, paramJSONObject.getJSONArray("other"));
		}
		return tariffDescription;
	  }

	  private static void a(List<Pair<string, string>> paramArrayList, JSONArray paramJSONArray)
	  {
		for (sbyte b = 0; b < paramJSONArray.length(); b++)
		{
		  JSONObject jSONObject = paramJSONArray.getJSONObject(b);
		  paramArrayList.Add(new Pair(jSONObject.getString("name"), jSONObject.getString("value")));
		}
	  }

	  private static void a(List<Tariff.Transfer> paramArrayList, JSONArray paramJSONArray, string paramString)
	  {
		for (sbyte b = 0; b < paramJSONArray.length(); b++)
		{
		  JSONObject jSONObject = paramJSONArray.getJSONObject(b);
		  string str = jSONObject.getString("name");
		  Tariff.Transfer transfer = new Tariff.Transfer();
		  transfer.name = str;
		  JSONArray jSONArray = jSONObject.getJSONArray(paramString);
		  for (sbyte b1 = 0; b1 < jSONArray.length(); b1++)
		  {
			JSONObject jSONObject1 = jSONArray.getJSONObject(b1);
			str = jSONObject1.getString("name");
			string str1 = jSONObject1.getString("value");
			transfer.price.add(new Pair(str, str1));
		  }
		  paramArrayList.Add(transfer);
		}
	  }

	  private static void a(OnTheWayResponse paramOnTheWayResponse, JSONObject paramJSONObject)
	  {
		string str = null;
		if (!paramOnTheWayResponse.Finished)
		{
		  paramOnTheWayResponse.Status = paramJSONObject.getString("status");
		  if (!"cancelled".Equals(paramOnTheWayResponse.Status))
		  {
			string str1;
			if (paramJSONObject.isNull("overdue"))
			{
			  paramOnTheWayResponse.Overdue = false;
			}
			else
			{
			  paramOnTheWayResponse.Overdue = "1".Equals(paramJSONObject.get("overdue"));
			}
			if (!paramJSONObject.isNull("block_time"))
			{
			  paramOnTheWayResponse.BlockTime = paramJSONObject.getString("block_time");
			}
			if (!paramJSONObject.isNull("source"))
			{
			  JSONArray jSONArray1 = paramJSONObject.getJSONArray("source");
			  paramOnTheWayResponse.addDestination(jSONArray1.getDouble(0), jSONArray1.getDouble(1));
			}
			JSONArray jSONArray = paramJSONObject.getJSONArray("destinations");
			for (sbyte b = 0; b < jSONArray.length(); b++)
			{
			  JSONArray jSONArray1 = jSONArray.getJSONArray(b);
			  paramOnTheWayResponse.addDestination(jSONArray1.getDouble(0), jSONArray1.getDouble(1));
			}
			if (!paramJSONObject.isNull("car"))
			{
			  JSONArray jSONArray1 = paramJSONObject.getJSONArray("car");
			  paramOnTheWayResponse.setCar(jSONArray1.getDouble(0), jSONArray1.getDouble(1));
			}
			JSONObject jSONObject1 = paramJSONObject.getJSONObject("tariff");
			paramOnTheWayResponse.setTariff(jSONObject1.getString("tariffid"), jSONObject1.getString("name"));
			JSONObject jSONObject2 = paramJSONObject.getJSONObject("taxi");
			if (!jSONObject2.isNull("logo"))
			{
			  string str2 = jSONObject2.getString("logo");
			}
			else
			{
			  jSONObject1 = null;
			}
			if (!jSONObject2.isNull("phone"))
			{
			  string str2 = jSONObject2.getString("phone");
			}
			else
			{
			  jSONArray = null;
			}
			paramOnTheWayResponse.setTaxi(jSONObject2.getString("parkid"), jSONObject2.getString("name"), (string)jSONObject1, (string)jSONArray);
			JSONObject jSONObject3 = paramJSONObject.getJSONObject("driver");
			if (!jSONObject3.isNull("model"))
			{
			  string str2 = jSONObject3.getString("model");
			}
			else
			{
			  jSONObject1 = null;
			}
			if (!jSONObject3.isNull("color"))
			{
			  string str2 = jSONObject3.getString("color");
			}
			else
			{
			  jSONArray = null;
			}
			if (!jSONObject3.isNull("plates"))
			{
			  string str2 = jSONObject3.getString("plates");
			}
			else
			{
			  jSONObject2 = null;
			}
			if (!jSONObject3.isNull("name"))
			{
			  str1 = jSONObject3.getString("name");
			}
			else
			{
			  str1 = null;
			}
			if (!jSONObject3.isNull("phone"))
			{
			  str = jSONObject3.getString("phone");
			}
			paramOnTheWayResponse.setDriver((string)jSONObject1, (string)jSONArray, (string)jSONObject2, str1, str);
			if (!paramJSONObject.isNull("driver_way_time"))
			{
			  paramOnTheWayResponse.DriverWayTime = paramJSONObject.getInt("driver_way_time");
			}
		  }
		}
	  }

	  private static void a(string[] paramArrayOfString, JSONObject paramJSONObject, Dictionary<string, string> paramHashMap)
	  {
		if (paramJSONObject != null)
		{
		  int i = paramArrayOfString.Length;
		  for (sbyte b = 0; b < i; b++)
		  {
			string str = paramArrayOfString[b];
			if (!paramJSONObject.isNull(str))
			{
			  paramHashMap[str] = paramJSONObject.getString(str);
			}
		  }
		}
	  }

	  public static Bitmap downloadBitmap(Context paramContext, string paramString)
	  {
		int i;
		Stream inputStream = null;
		DateTime calendar1 = null;
		DateTime calendar2 = new DateTime();
		calendar2 = calendar2.AddMilliseconds(-86400000);
		ContentResolver contentResolver = paramContext.getContentResolver();
		contentResolver.delete(StaticDataScheme.CacheRequestTable.CONTENT_URI, "request_date < ?", new string[] {DATE_FORMAT.format(calendar2)});
		Cursor cursor = contentResolver.query(StaticDataScheme.CacheRequestTable.CONTENT_URI, new string[] {"request_date", "response"}, "request = ?", new string[] {paramString}, null);
		cursor.moveToFirst();
		if (cursor.getCount() > 0)
		{
		  File file = new File(cursor.getString(1));
		  if (file.exists())
		  {
			Bitmap bitmap = BitmapFactory.decodeFile(file.getPath());
			i = 1;
		  }
		  else
		  {
			contentResolver.delete(StaticDataScheme.CacheRequestTable.CONTENT_URI, "request = ?", new string[] {paramString});
			i = 0;
			file = null;
		  }
		}
		else
		{
		  i = 0;
		  calendar2 = null;
		}
		cursor.close();
		DateTime calendar3 = calendar2;
		if (!i)
		{
		  DefaultHttpClient defaultHttpClient = new DefaultHttpClient();
		  HttpGet httpGet = new HttpGet(paramString);
		  calendar3 = calendar2;
		  try
		  {
			StringBuilder stringBuilder;
			HttpResponse httpResponse = defaultHttpClient.execute((HttpUriRequest)httpGet);
			calendar3 = calendar2;
			i = httpResponse.getStatusLine().getStatusCode();
			if (i != 200)
			{
			  calendar3 = calendar2;
			  stringBuilder = new StringBuilder();
			  calendar3 = calendar2;
			  this();
			  calendar3 = calendar2;
			  Log.w("ImageDownloader", stringBuilder.Append("Error ").Append(i).Append(" while retrieving bitmap from ").Append(paramString).ToString());
			  return (Bitmap)calendar1;
			}
			calendar3 = calendar2;
			HttpEntity httpEntity = httpResponse.getEntity();
			calendar3 = calendar2;
			if (httpEntity != null)
			{
			  calendar1 = calendar2;
			  return (Bitmap)exception;
			}
		  }
		  catch (Exception exception1)
		  {
			httpGet.abort();
			StringBuilder stringBuilder = new StringBuilder();
			this();
			Log.w("ImageDownloader", stringBuilder.Append("Error while retrieving bitmap from ").Append(paramString).ToString(), exception1);
			return (Bitmap)exception;
		  }
		  finally
		  {
			defaultHttpClient.getConnectionManager().shutdown();
		  }
		}
		return (Bitmap)exception;
	  }

	  public static void switchServerUrl(Context paramContext)
	  {
		if (PreferenceManager.getDefaultSharedPreferences(paramContext).getBoolean("production server", false))
		{
		  // cloned (test) server
		  sServerUrl = paramContext.getString(2131296258); // serverurl
		  sProtocolUrl = paramContext.getString(2131296260);
		  return;
		}

		// production server
		sServerUrl = paramContext.getString(2131296257);
		sProtocolUrl = paramContext.getString(2131296259);
	  }

	  public virtual LaunchResponse checkAuthorization()
	  {
		SharedPreferences.Editor editor1;
		SharedPreferences.Editor editor2;
		LaunchResponse launchResponse = new LaunchResponse(400);
		try
		{
		  LaunchResponse launchResponse1;
		  bool @bool;
		  SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(this.d);
		  string str1 = sharedPreferences.getString("client id", null);
		  string str2 = sharedPreferences.getString("phone number", "");
		  LaunchResponse launchResponse2 = doLaunch(str1, null);
		  try
		  {
			if (launchResponse2.Code == 200 || launchResponse2.Code == 403)
			{
			  launchResponse2.Data["checked"] = "1";
			  @bool = "1".Equals(launchResponse2.Data["authorized"]);
			  if (!string.ReferenceEquals(launchResponse2.Data["id"], null))
			  {
				str1 = (string)launchResponse2.Data["id"];
			  }
			  if (sharedPreferences.getInt("device token size", 0) == 0)
			  {
				Context context = this.d;
				if (Build.VERSION.SDK_INT >= 8)
				{
				  Intent intent1 = new Intent();
				  this("com.google.android.c2dm.intent.REGISTER");
				  Intent intent2 = new Intent();
				  this();
				  intent1.putExtra("app", (Parcelable)PendingIntent.getBroadcast(context, 0, intent2, 0));
				  intent1.putExtra("sender", "alexkir@yandex-team.ru");
				  context.startService(intent1);
				}
			  }
			  StringBuilder stringBuilder = new StringBuilder();
			  this();
			  List<string> arrayList = new ArrayList();
			  this();
			  foreach (CurrentOrder currentOrder in launchResponse2.CurrentOrders)
			  {
				stringBuilder.Append("order_id != ? OR ");
				arrayList.Add(currentOrder.orderId);
			  }
			  if (stringBuilder.Length > 0)
			  {
				stringBuilder.Length = stringBuilder.Length - " OR ".Length;
				this.d.getContentResolver().delete(StaticDataScheme.CurrentOrderTable.CONTENT_URI, stringBuilder.ToString(), arrayList.toArray<string>(new string[0]));
			  }
			  else
			  {
				this.d.getContentResolver().delete(StaticDataScheme.CurrentOrderTable.CONTENT_URI, null, null);
			  }
			}
			else
			{
			  @bool = false;
			}
		  }
		  catch (Exception exception1)
		  {
			launchResponse1 = launchResponse2;
			exception = exception1;
			Log.e(a_Conflict, "Fail launch", exception);
			return launchResponse1;
		  }
		  if ("".Equals(str2))
		  {
			exception.getData().put("authorized", "0");
			@bool = false;
		  }
		  editor1 = sharedPreferences.edit();
		  editor1.putString("client id", (string)launchResponse1);
		  editor1.putBoolean("authorized", @bool);
		  editor1.commit();
		  return (LaunchResponse)exception;
		}
		catch (Exception)
		{
		  editor2 = editor1;
		}
		Log.e(a_Conflict, "Fail launch", exception);
		return (LaunchResponse)editor2;
	  }

	  public virtual SimpleResponse doAuth(string paramString1, string paramString2, string paramString3)
	  {
		return a("auth", new string[] {"id", "phone", "name"}, new string[] {paramString1, paramString2, paramString3}, new string[0]);
	  }

	  public virtual SimpleResponse doAuthConfirm(string paramString1, string paramString2)
	  {
		return a("authconfirm", new string[] {"id", "confirmation_code"}, new string[] {paramString1, paramString2}, new string[] {"authorized", "block_time", "attempts_left"});
	  }

	  public virtual bool doFeedback(string paramString1, string paramString2, string paramString3, string paramString4)
	  {
		bool @bool = true;
		if (a("feedback", new string[] {"id", "msg", "orderid", "rating"}, new string[] {paramString1, paramString2, paramString3, paramString4}, new string[0]) == null)
		{
		  @bool = false;
		}
		return @bool;
	  }

	  public virtual GeocodeResponse doGeocode(string paramString)
	  {
		return doGeocode(paramString, null);
	  }

	  public virtual GeocodeResponse doGeocode(string paramString1, string paramString2)
	  {
		return doGeocode(paramString1, paramString2, 0);
	  }

	  public virtual GeocodeResponse doGeocode(string paramString1, string paramString2, int paramInt)
	  {
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("geocode", paramString1);
		jSONObject.put("skip", paramInt);
		if (!string.ReferenceEquals(paramString2, null))
		{
		  jSONObject.put("ll", paramString2);
		}
		GeocodeResponse geocodeResponse = new GeocodeResponse(a("geocode", jSONObject, false));
		if (geocodeResponse.Code == 200 && !geocodeResponse.Blocked)
		{
		  geocodeResponse.ResponseObject = new JSONObject(geocodeResponse.RowData);
		  geocodeResponse.GeocodeObject = (GeocodeJsonObject)(new Gson()).fromJson(geocodeResponse.RowData, typeof(GeocodeJsonObject));
		}
		return geocodeResponse;
	  }

	  public virtual GeocodeResponse doGeosearch(string paramString, GeoPoint paramGeoPoint)
	  {
		return doGeosearch(paramString, paramGeoPoint, 0, 0);
	  }

	  public virtual GeocodeResponse doGeosearch(string paramString, GeoPoint paramGeoPoint, int paramInt1, int paramInt2)
	  {
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("what", paramString);
		jSONObject.put("skip", paramInt1);
		jSONObject.put("oskip", paramInt2);
		if (paramGeoPoint != null)
		{
		  JSONArray jSONArray = new JSONArray();
		  jSONArray.put(paramGeoPoint.Lon);
		  jSONArray.put(paramGeoPoint.Lat);
		  jSONObject.put("ll", jSONArray);
		}
		GeocodeResponse geocodeResponse = new GeocodeResponse(a("geosearch", jSONObject, false));
		if (geocodeResponse.Code == 200 && !geocodeResponse.Blocked)
		{
		  geocodeResponse.ResponseObject = new JSONObject(geocodeResponse.RowData);
		  geocodeResponse.GeocodeObject = (GeocodeJsonObject)(new Gson()).fromJson(geocodeResponse.RowData, typeof(GeocodeJsonObject));
		}
		return geocodeResponse;
	  }

	  public virtual AllCarsResponse doGetAllCars(string[] paramArrayOfString1, string[] paramArrayOfString2)
	  {
		JSONObject jSONObject = new JSONObject();
		if (paramArrayOfString1 != null)
		{
		  jSONObject.put("parks", new pp(paramArrayOfString1));
		}
		if (paramArrayOfString2 != null)
		{
		  jSONObject.put("class", new pq(paramArrayOfString2));
		}
		AllCarsResponse allCarsResponse = new AllCarsResponse(a("allcars", jSONObject, true));
		sbyte b = 0;
		if (allCarsResponse.Code == 200 && !allCarsResponse.Blocked)
		{
		  JSONArray jSONArray = new JSONArray(allCarsResponse.RowData);
		  int i = jSONArray.length();
		  for (sbyte b1 = 0; b1 < i && b < b; b1++)
		  {
			JSONArray jSONArray1 = jSONArray.getJSONObject(b1).getJSONArray("cars");
			int j = jSONArray1.length();
			sbyte b2 = 0;
			while (b2 < j && b < b)
			{
			  JSONObject jSONObject1 = jSONArray1.getJSONObject(b2);
			  JSONArray jSONArray2 = jSONObject1.getJSONArray("geopoint");
			  GeoPoint geoPoint = new GeoPoint(jSONArray2.getDouble(1), jSONArray2.getDouble(0));
			  if ("1".Equals(jSONObject1.getString("free")))
			  {
				allCarsResponse.addFreeCar(geoPoint);
			  }
			  else
			  {
				allCarsResponse.addBusyCar(geoPoint);
			  }
			  b2++;
			  b++;
			}
		  }
		}
		return allCarsResponse;
	  }

	  public virtual AllCarsResponse doGetFreeCars(IList<Pair<string, string>> paramList, string[] paramArrayOfString1, string[] paramArrayOfString2)
	  {
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("city", "Москва");
		if (paramList != null)
		{
		  jSONObject.put("requirements", new pr(paramList));
		}
		if (paramArrayOfString1 != null)
		{
		  jSONObject.put("parks", new ps(paramArrayOfString1));
		}
		if (paramArrayOfString2 != null)
		{
		  jSONObject.put("class", new pt(paramArrayOfString2));
		}
		AllCarsResponse allCarsResponse = new AllCarsResponse(a("freecars", jSONObject, true));
		if (allCarsResponse.Code == 200 && !allCarsResponse.Blocked)
		{
		  JSONArray jSONArray = new JSONArray(allCarsResponse.RowData);
		  int i = jSONArray.length();
		  for (sbyte b = 0; b < i && b < b; b++)
		  {
			JSONArray jSONArray1 = jSONArray.getJSONArray(b);
			allCarsResponse.addFreeCar(new GeoPoint(jSONArray1.getDouble(1), jSONArray1.getDouble(0)));
		  }
		}
		return allCarsResponse;
	  }

	  public virtual Pair<GeoPoint, double> doGetLbsLocation()
	  {
		double d = 100000.0D;
		sbyte b = 0;
		GeoPoint geoPoint = null;
		while (true)
		{
		  Exception exception2;
		  if (b < 3)
		  {
			try
			{
			  TelephonyManager telephonyManager = (TelephonyManager)this.d.getSystemService("phone");
			  if (telephonyManager != null)
			  {
				GsmCellLocation gsmCellLocation = (GsmCellLocation)telephonyManager.getCellLocation();
			  }
			  else
			  {
				telephonyManager = null;
			  }
			  WifiManager wifiManager = (WifiManager)this.d.getSystemService("wifi");
			  if (wifiManager != null)
			  {
				WifiInfo wifiInfo = wifiManager.getConnectionInfo();
			  }
			  else
			  {
				wifiManager = null;
			  }
			  JSONObject jSONObject1 = new JSONObject();
			  this();
			  JSONObject jSONObject2 = new JSONObject();
			  this();
			  jSONObject2.put("version", "1.0");
			  jSONObject1.put("common", jSONObject2);
			  if (telephonyManager != null)
			  {
				JSONArray jSONArray = new JSONArray();
				this();
				jSONObject2 = new JSONObject();
				this();
				jSONObject2.put("countrycode", ((this.d.getResources().getConfiguration()).mcc).ToString());
				jSONObject2.put("operatorid", ((this.d.getResources().getConfiguration()).mnc).ToString());
				jSONObject2.put("cellid", telephonyManager.getCid().ToString());
				jSONObject2.put("lac", telephonyManager.getLac().ToString());
				jSONArray.put(jSONObject2);
				jSONObject1.put("gsm_cells", jSONArray);
			  }
			  if (wifiManager != null)
			  {
				JSONArray jSONArray = new JSONArray();
				this();
				jSONObject2 = new JSONObject();
				this();
				jSONObject2.put("mac", wifiManager.getMacAddress());
				jSONArray.put(jSONObject2);
				jSONObject1.put("wifi_networks", jSONArray);
				JSONObject jSONObject = new JSONObject();
				this();
				int i = wifiManager.getIpAddress();
				jSONObject.put("address_v4", string.Format("{0:D}.{1:D}.{2:D}.{3:D}", new object[] {Convert.ToInt32(i & 0xFF), Convert.ToInt32(i >> 8 & 0xFF), Convert.ToInt32(i >> 16 & 0xFF), Convert.ToInt32((int)((uint)i >> 24))}));
				jSONObject1.put("ip", jSONObject);
			  }
			  SimpleResponse simpleResponse = new SimpleResponse();
			  this(a("lbs", jSONObject1, false));
			  if (simpleResponse.Code == 200)
			  {
				JSONObject jSONObject = new JSONObject();
				this(simpleResponse.RowData);
				jSONObject = jSONObject.getJSONObject("position");
				GeoPoint geoPoint1 = new GeoPoint();
				this(jSONObject.getDouble("latitude"), jSONObject.getDouble("longitude"));
				try
				{
				  double d1 = jSONObject.getDouble("precision");
				  d = d1;
				  geoPoint = geoPoint1;
				  if (d1 >= 3000.0D)
				  {
					geoPoint = geoPoint1;
				  }
				  else
				  {
					return new Pair(geoPoint, Convert.ToDouble(d));
				  }
				  b++;
				  d = d1;
				}
				catch (Exception)
				{
				}
			  }
			  else
			  {
				double d1 = d;
				b++;
				d = d1;
			  }
			}
			catch (Exception exception)
			{
			  exception2 = exception1;
			  exception1 = exception;
			}
		  }
		  else
		  {
			return new Pair(exception1, Convert.ToDouble(d));
		  }
		  Log.e(a_Conflict, "error during getting location", exception1);
		  exception1 = exception2;
		  return new Pair(exception1, Convert.ToDouble(d));
		}
	  }

	  public virtual SimpleResponse doLaterTime(string paramString)
	  {
		return a("latertime", new string[] {"id"}, new string[] {paramString}, new string[] {"mintime", "maxtime"});
	  }

	  public virtual LaunchResponse doLaunch(string paramString1, string paramString2)
	  {
		JSONObject jSONObject2;
		Dictionary<object, object> hashMap;
		bool @bool = false;
		JSONObject jSONObject1 = new JSONObject();
		if (!string.ReferenceEquals(paramString1, null))
		{
		  jSONObject1.put("id", paramString1);
		}
		if (!string.ReferenceEquals(paramString2, null))
		{
		  jSONObject1.put("c2dm_token", paramString2);
		}
		SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(this.d);
		string str = sharedPreferences.getString("startup uid", "");
		if (!"".Equals(str))
		{
		  jSONObject1.put("uuid", str);
		}
		Startup startup = new Startup(this.d);
		LaunchResponse launchResponse2 = new LaunchResponse(a("launch" + startup.StartupParameters, jSONObject1, false));
		LaunchResponse launchResponse1 = launchResponse2;
		if (launchResponse2.Code == 200)
		{
		  launchResponse1 = launchResponse2;
		  if (!launchResponse2.Blocked)
		  {
			jSONObject2 = new JSONObject(launchResponse2.RowData);
			hashMap = new Dictionary<object, object>();
			a(new string[] {"id", "authorized", "status", "server_time", "uuid"}, jSONObject2, (Hashtable)hashMap);
			launchResponse1 = launchResponse2;
			if ("".Equals(str))
			{
			  string str2 = (string)hashMap["uuid"];
			  string str1 = (string)hashMap["id"];
			  sharedPreferences.edit().putString("startup uid", str2).commit();
			  jSONObject1.put("uuid", str2);
			  jSONObject1.put("id", str1);
			  LaunchResponse launchResponse4 = new LaunchResponse(a("launch" + startup.StartupParameters, jSONObject1, false));
			  LaunchResponse launchResponse3 = launchResponse4;
			  if (launchResponse4.Code == 200)
			  {
				launchResponse3 = launchResponse4;
				if (launchResponse4.Blocked)
				{
				  return launchResponse4;
				}
			  }
			  else
			  {
				return launchResponse3;
			  }
			}
		  }
		  else
		  {
			return launchResponse1;
		  }
		}
		else
		{
		  return launchResponse1;
		}
		launchResponse1.Data = hashMap;
		JSONArray jSONArray1 = jSONObject2.getJSONArray("orders");
		sbyte b;
		for (b = 0; b < jSONArray1.length(); b++)
		{
		  jSONObject1 = jSONArray1.getJSONObject(b);
		  launchResponse1.addOrderId(new CurrentOrder(jSONObject1.getString("orderid"), jSONObject1.getString("status"), jSONObject1.getString("due")));
		}
		JSONArray jSONArray2 = jSONObject2.getJSONArray("info");
		for (b = @bool; b < jSONArray2.length(); b++)
		{
		  JSONObject jSONObject = jSONArray2.getJSONObject(b);
		  launchResponse1.addServerMsg(new ServerMsg(jSONObject.getString("header"), jSONObject.getString("message"), DATE_FORMAT.parse(jSONObject.getString("time"))));
		}
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: java.util.Collections.sort(launchResponse1.getServerMsgs(), (java.util.Comparator<?>)new pl());
		launchResponse1.ServerMsgs.Sort((IComparer<object>)new pl());
		return launchResponse1;
	  }

	  public virtual SimpleResponse doOrder(string paramString1, string[] paramArrayOfString1, string[] paramArrayOfString2, bool paramBoolean, DateTime paramDate, string paramString2, IList<GeocodeJsonObject> paramList, IList<Pair<string, string>> paramList1, string paramString3)
	  {
		// Byte code:
		//   0: new org/json/JSONObject
		//   3: dup
		//   4: invokespecial <init> : ()V
		//   7: astore #10
		//   9: aload #10
		//   11: ldc_w 'id'
		//   14: aload_1
		//   15: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   18: pop
		//   19: aload #10
		//   21: ldc_w 'time'
		//   24: getstatic ru/yandex/taxi/client/TaxiClient.DATE_FORMAT : Ljava/text/SimpleDateFormat;
		//   27: aload #5
		//   29: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   32: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   35: pop
		//   36: aload #10
		//   38: ldc 'comment'
		//   40: aload #6
		//   42: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   45: pop
		//   46: iload #4
		//   48: ifeq -> 180
		//   51: ldc_w '1'
		//   54: astore #6
		//   56: aload #10
		//   58: ldc_w 'orderlater'
		//   61: aload #6
		//   63: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   66: pop
		//   67: aload #9
		//   69: ifnull -> 83
		//   72: aload #10
		//   74: ldc_w 'tariffid'
		//   77: aload #9
		//   79: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   82: pop
		//   83: aload #10
		//   85: ldc_w 'class'
		//   88: new pw
		//   91: dup
		//   92: aload_3
		//   93: invokespecial <init> : ([Ljava/lang/String;)V
		//   96: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   99: pop
		//   100: iload #4
		//   102: ifeq -> 188
		//   105: aload #10
		//   107: ldc_w 'parks'
		//   110: aload_2
		//   111: iconst_0
		//   112: aaload
		//   113: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   116: pop
		//   117: aload #10
		//   119: ldc_w 'requirements'
		//   122: new py
		//   125: dup
		//   126: aload #8
		//   128: invokespecial <init> : (Ljava/util/List;)V
		//   131: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   134: pop
		//   135: new org/json/JSONArray
		//   138: dup
		//   139: invokespecial <init> : ()V
		//   142: astore_2
		//   143: aload #7
		//   145: invokeinterface iterator : ()Ljava/util/Iterator;
		//   150: astore_3
		//   151: aload_3
		//   152: invokeinterface hasNext : ()Z
		//   157: ifeq -> 208
		//   160: aload_2
		//   161: aload_3
		//   162: invokeinterface next : ()Ljava/lang/Object;
		//   167: checkcast ru/yandex/taxi/map/GeocodeJsonObject
		//   170: invokevirtual getJsonObject : ()Lorg/json/JSONObject;
		//   173: invokevirtual put : (Ljava/lang/Object;)Lorg/json/JSONArray;
		//   176: pop
		//   177: goto -> 151
		//   180: ldc_w '0'
		//   183: astore #6
		//   185: goto -> 56
		//   188: aload #10
		//   190: ldc_w 'parks'
		//   193: new px
		//   196: dup
		//   197: aload_2
		//   198: invokespecial <init> : ([Ljava/lang/String;)V
		//   201: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   204: pop
		//   205: goto -> 117
		//   208: aload #10
		//   210: ldc_w 'route'
		//   213: aload_2
		//   214: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   217: pop
		//   218: new ru/yandex/taxi/client/response/SimpleResponse
		//   221: astore_2
		//   222: aload_2
		//   223: aload_0
		//   224: ldc_w 'order'
		//   227: aload #10
		//   229: iconst_0
		//   230: invokespecial a : (Ljava/lang/String;Lorg/json/JSONObject;Z)Lru/yandex/taxi/client/response/TaxiResponse;
		//   233: invokespecial <init> : (Lru/yandex/taxi/client/response/TaxiResponse;)V
		//   236: getstatic ru/yandex/taxi/client/TaxiClient.DATE_FORMAT : Ljava/text/SimpleDateFormat;
		//   239: aload #5
		//   241: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   244: astore #5
		//   246: iconst_0
		//   247: istore #11
		//   249: aload_2
		//   250: astore_3
		//   251: iload #11
		//   253: iconst_3
		//   254: if_icmpge -> 402
		//   257: aload_2
		//   258: ifnull -> 282
		//   261: aload_2
		//   262: astore_3
		//   263: aload_2
		//   264: invokevirtual getCode : ()I
		//   267: sipush #200
		//   270: if_icmpeq -> 402
		//   273: aload_2
		//   274: astore_3
		//   275: aload_2
		//   276: invokevirtual isBlocked : ()Z
		//   279: ifne -> 402
		//   282: ldc2_w 1000
		//   285: invokestatic sleep : (J)V
		//   288: aload_0
		//   289: aload_1
		//   290: aconst_null
		//   291: invokevirtual doLaunch : (Ljava/lang/String;Ljava/lang/String;)Lru/yandex/taxi/client/response/LaunchResponse;
		//   294: astore_3
		//   295: aload_3
		//   296: ifnull -> 490
		//   299: aload_3
		//   300: invokevirtual getCurrentOrders : ()Ljava/util/List;
		//   303: invokeinterface iterator : ()Ljava/util/Iterator;
		//   308: astore #6
		//   310: aload #6
		//   312: invokeinterface hasNext : ()Z
		//   317: ifeq -> 500
		//   320: aload #6
		//   322: invokeinterface next : ()Ljava/lang/Object;
		//   327: checkcast ru/yandex/taxi/data/CurrentOrder
		//   330: astore_3
		//   331: getstatic ru/yandex/taxi/client/TaxiClient.DATE_FORMAT : Ljava/text/SimpleDateFormat;
		//   334: aload_3
		//   335: getfield due : Ljava/util/Date;
		//   338: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   341: aload #5
		//   343: invokevirtual equals : (Ljava/lang/Object;)Z
		//   346: ifeq -> 310
		//   349: new org/json/JSONObject
		//   352: astore #6
		//   354: aload #6
		//   356: invokespecial <init> : ()V
		//   359: aload #6
		//   361: ldc_w 'orderid'
		//   364: aload_3
		//   365: getfield orderId : Ljava/lang/String;
		//   368: invokevirtual put : (Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;
		//   371: pop
		//   372: new ru/yandex/taxi/client/response/SimpleResponse
		//   375: astore_3
		//   376: aload_3
		//   377: sipush #200
		//   380: aload #6
		//   382: invokevirtual toString : ()Ljava/lang/String;
		//   385: invokespecial <init> : (ILjava/lang/String;)V
		//   388: iconst_1
		//   389: istore #12
		//   391: aload_3
		//   392: astore_2
		//   393: aload_2
		//   394: astore_3
		//   395: iload #12
		//   397: ifeq -> 492
		//   400: aload_2
		//   401: astore_3
		//   402: aload_3
		//   403: invokevirtual getCode : ()I
		//   406: sipush #200
		//   409: if_icmpne -> 459
		//   412: aload_3
		//   413: invokevirtual isBlocked : ()Z
		//   416: ifne -> 459
		//   419: new org/json/JSONObject
		//   422: dup
		//   423: aload_3
		//   424: invokevirtual getRowData : ()Ljava/lang/String;
		//   427: invokespecial <init> : (Ljava/lang/String;)V
		//   430: astore_1
		//   431: new java/util/HashMap
		//   434: dup
		//   435: invokespecial <init> : ()V
		//   438: astore_2
		//   439: aload_2
		//   440: ldc_w 'orderid'
		//   443: aload_1
		//   444: ldc_w 'orderid'
		//   447: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   450: invokevirtual put : (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
		//   453: pop
		//   454: aload_3
		//   455: aload_2
		//   456: invokevirtual setData : (Ljava/util/HashMap;)V
		//   459: aload_3
		//   460: areturn
		//   461: astore_2
		//   462: getstatic ru/yandex/taxi/client/TaxiClient.a : Ljava/lang/String;
		//   465: ldc_w 'Fail send order request'
		//   468: aload_2
		//   469: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
		//   472: pop
		//   473: aconst_null
		//   474: astore_2
		//   475: goto -> 236
		//   478: astore_3
		//   479: getstatic ru/yandex/taxi/client/TaxiClient.a : Ljava/lang/String;
		//   482: ldc_w 'Fail get order id after send order request'
		//   485: aload_3
		//   486: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
		//   489: pop
		//   490: aload_2
		//   491: astore_3
		//   492: iinc #11, 1
		//   495: aload_3
		//   496: astore_2
		//   497: goto -> 249
		//   500: iconst_0
		//   501: istore #12
		//   503: goto -> 393
		// Exception table:
		//   from	to	target	type
		//   218	236	461	java/lang/Exception
		//   282	295	478	java/lang/Exception
		//   299	310	478	java/lang/Exception
		//   310	388	478	java/lang/Exception
	  }

	  public virtual Park doParkDetails(string paramString1, string paramString2)
	  {
		SimpleResponse simpleResponse;
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("parkid", paramString1);
		if (!string.ReferenceEquals(paramString2, null))
		{
		  jSONObject.put("orderid", paramString2);
		}
		DateTime calendar = new DateTime();
		calendar = calendar.AddMilliseconds(-3600000);
		ContentResolver contentResolver = this.d.getContentResolver();
		Uri uri = StaticDataScheme.CacheRequestTable.CONTENT_URI;
		string str = DATE_FORMAT.format(calendar);
		Cursor cursor = contentResolver.query(uri, new string[] {"request_date", "response"}, "request = ? AND request_date > ?", new string[] {paramString1, str}, null);
		cursor.moveToFirst();
		if (string.ReferenceEquals(paramString2, null) && cursor.getCount() > 0)
		{
		  simpleResponse = new SimpleResponse(200, cursor.getString(1));
		}
		else
		{
		  SimpleResponse simpleResponse1 = new SimpleResponse(a("parkdetails", jSONObject, false));
		  if (string.ReferenceEquals(paramString2, null) && simpleResponse1.Code == 200 && !simpleResponse1.Blocked && simpleResponse1.RowData.Length > 2)
		  {
			ContentValues contentValues = new ContentValues();
			contentValues.put("request", (string)simpleResponse);
			contentValues.put("response", simpleResponse1.RowData);
			contentValues.put("request_date", DATE_FORMAT.format(DateTime.Now));
			contentResolver.insert(StaticDataScheme.CacheRequestTable.CONTENT_URI, contentValues);
		  }
		  simpleResponse = simpleResponse1;
		}
		cursor.close();
		Park park = new Park();
		if (simpleResponse.Code == 200 && !simpleResponse.Blocked)
		{
		  JSONObject jSONObject1 = new JSONObject(simpleResponse.RowData);
		  park.ParkId = jSONObject1.getString("id");
		  park.Name = jSONObject1.getString("name");
		  if (!jSONObject1.isNull("logo"))
		  {
			park.LogoUrl = jSONObject1.getString("logo");
		  }
		  if (!jSONObject1.isNull("phone"))
		  {
			park.Phone = jSONObject1.getString("phone");
		  }
		  if (!jSONObject1.isNull("car"))
		  {
			park.Car = jSONObject1.getString("car");
		  }
		  JSONArray jSONArray = jSONObject1.getJSONArray("tariffs");
		  for (sbyte b = 0; b < jSONArray.length(); b++)
		  {
			JSONObject jSONObject2 = jSONArray.getJSONObject(b);
			Tariff tariff = new Tariff();
			tariff.Id = jSONObject2.getString("id");
			tariff.Name = jSONObject2.getString("name");
			tariff.Clazz = jSONObject2.getString("class");
			tariff.Currency = jSONObject2.getString("currency");
			jSONObject2 = jSONObject2.getJSONObject("description");
			tariff.addInterval(a(jSONObject2.getJSONObject("day")));
			tariff.addInterval(a(jSONObject2.getJSONObject("night")));
			if (!jSONObject2.isNull("intervals"))
			{
			  JSONArray jSONArray1 = jSONObject2.getJSONArray("intervals");
			  for (sbyte b1 = 0; b1 < jSONArray1.length(); b1++)
			  {
				tariff.addInterval(a(jSONArray1.getJSONObject(b1)));
			  }
			}
			park.addTariff(tariff);
		  }
		}
		return park;
	  }

	  public virtual List<Park> doPriceCat()
	  {
		SimpleResponse simpleResponse;
		JSONObject jSONObject = new JSONObject();
		DateTime calendar = new DateTime();
		calendar = calendar.AddMilliseconds(-3600000);
		ContentResolver contentResolver = this.d.getContentResolver();
		contentResolver.delete(StaticDataScheme.CacheRequestTable.CONTENT_URI, "request_date < ?", new string[] {DATE_FORMAT.format(calendar)});
		Cursor cursor = contentResolver.query(StaticDataScheme.CacheRequestTable.CONTENT_URI, new string[] {"request_date", "response"}, "request = ?", new string[] {"pricecat"}, null);
		cursor.moveToFirst();
		if (cursor.getCount() > 0)
		{
		  simpleResponse = new SimpleResponse(200, cursor.getString(1));
		}
		else
		{
		  simpleResponse = new SimpleResponse(a("pricecat", (JSONObject)simpleResponse, false));
		  if (simpleResponse.Code == 200 && !simpleResponse.Blocked && simpleResponse.RowData.Length > 2)
		  {
			ContentValues contentValues = new ContentValues();
			contentValues.put("request", "pricecat");
			contentValues.put("response", simpleResponse.RowData);
			contentValues.put("request_date", DATE_FORMAT.format(DateTime.Now));
			contentResolver.insert(StaticDataScheme.CacheRequestTable.CONTENT_URI, contentValues);
		  }
		}
		cursor.close();
		List<Park> arrayList = new ArrayList();
		if (simpleResponse.Code == 200 && !simpleResponse.Blocked)
		{
		  JSONArray jSONArray = new JSONArray(simpleResponse.RowData);
		  if (jSONArray.length() != 0)
		  {
			for (sbyte b = 0; b < jSONArray.length(); b++)
			{
			  JSONObject jSONObject1 = jSONArray.getJSONObject(b);
			  Park park = new Park();
			  park.ParkId = jSONObject1.getString("parkid");
			  park.Name = jSONObject1.getString("name");
			  park.Type = jSONObject1.getString("type");
			  JSONArray jSONArray1 = jSONObject1.getJSONArray("tariffs");
			  for (sbyte b1 = 0; b1 < jSONArray1.length(); b1++)
			  {
				JSONObject jSONObject2 = jSONArray1.getJSONObject(b1);
				try
				{
				  string str1 = jSONObject2.getString("minimal_day");
				  string str2 = jSONObject2.getString("minimal_night");
				  string str3 = jSONObject2.getString("included_day");
				  string str4 = jSONObject2.getString("included_night");
				  if (!"null".Equals(str1) && !"null".Equals(str2) && !"null".Equals(str3) && !"null".Equals(str4))
				  {
					Tariff tariff = new Tariff();
					this();
					tariff.Clazz = jSONObject2.getString("class");
					tariff.DayPrice = Convert.ToInt32(str1);
					tariff.NightPrice = Convert.ToInt32(str2);
					tariff.Currency = jSONObject2.getString("currency");
					tariff.IncludedDay = str3;
					tariff.IncludedNight = str4;
					tariff.Other = jSONObject2.getString("other");
					park.addTariff(tariff);
				  }
				}
				catch (Exception exception)
				{
				  Log.e(a_Conflict, "Fail parse tariff data", exception);
				}
			  }
			  if (park.TariffsCount > 0)
			  {
				arrayList.Add(park);
			  }
			}
		  }
		}
		return arrayList;
	  }

	  public virtual SimpleResponse doReorder(string paramString1, string paramString2, DateTime paramDate, TariffLimits paramTariffLimits, Requirements paramRequirements)
	  {
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("id", paramString1);
		jSONObject.put("time", DATE_FORMAT.format(paramDate));
		jSONObject.put("orderid", paramString2);
		if (paramTariffLimits != null)
		{
		  jSONObject.put("class", new pz(paramTariffLimits));
		  jSONObject.put("parks", new qa(paramTariffLimits));
		}
		if (paramRequirements != null)
		{
		  jSONObject.put("requirements", new qb(paramRequirements));
		}
		SimpleResponse simpleResponse = new SimpleResponse(a("reorder", jSONObject, false));
		if (simpleResponse.Code == 200 && !simpleResponse.Blocked)
		{
		  JSONObject jSONObject1 = new JSONObject(simpleResponse.RowData);
		  Dictionary<object, object> hashMap = new Dictionary<object, object>();
		  a(new string[] {"orderid", "found"}, jSONObject1, (Hashtable)hashMap);
		  simpleResponse.Data = hashMap;
		}
		return simpleResponse;
	  }

	  public virtual SimpleResponse doRouteStats(GeoPoint paramGeoPoint1, GeoPoint paramGeoPoint2)
	  {
		sbyte b = 0;
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("source", new qc(paramGeoPoint1));
		jSONObject.put("destination", new qd(paramGeoPoint2));
		SimpleResponse simpleResponse = new SimpleResponse(a("routestats", jSONObject, false));
		if (simpleResponse.Code == 200 && !simpleResponse.Blocked)
		{
		  JSONObject jSONObject1 = new JSONObject(simpleResponse.RowData);
		  Dictionary<object, object> hashMap = new Dictionary<object, object>();
		  string[] arrayOfString = new string[2];
		  arrayOfString[0] = "time";
		  arrayOfString[1] = "distance";
		  int i = arrayOfString.Length;
		  while (b < i)
		  {
			string str = arrayOfString[b];
			if (!jSONObject1.isNull(str))
			{
			  hashMap[str] = jSONObject1.getString(str);
			}
			b++;
		  }
		  simpleResponse.Data = hashMap;
		}
		return simpleResponse;
	  }

	  public virtual SimpleResponse doTaxiCount(string paramString, string[] paramArrayOfString1, string[] paramArrayOfString2, IList<Pair<string, string>> paramList, DateTime paramDate, GeoPoint paramGeoPoint, bool paramBoolean)
	  {
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("id", paramString);
		if (paramGeoPoint != null)
		{
		  string str;
		  jSONObject.put("parks", new pm(paramArrayOfString1));
		  string[] arrayOfString = paramArrayOfString2;
		  if (paramArrayOfString2 == null)
		  {
			arrayOfString = new string[3];
			arrayOfString[0] = "econom";
			arrayOfString[1] = "business";
			arrayOfString[2] = "vip";
		  }
		  JSONArray jSONArray = new JSONArray();
		  int i = arrayOfString.Length;
		  for (sbyte b = 0; b < i; b++)
		  {
			jSONArray.put(arrayOfString[b]);
		  }
		  jSONObject.put("class", jSONArray);
		  if (paramList != null)
		  {
			jSONObject.put("requirements", new pn(paramList));
		  }
		  jSONObject.put("time", DATE_FORMAT.format(paramDate));
		  jSONObject.put("source", new po(paramGeoPoint));
		  if (paramBoolean)
		  {
			str = "1";
		  }
		  else
		  {
			str = "0";
		  }
		  jSONObject.put("airport", str);
		}
		SimpleResponse simpleResponse = new SimpleResponse(a("taxicount", jSONObject, false));
		if (simpleResponse.Code == 200 && !simpleResponse.Blocked)
		{
		  JSONObject jSONObject1 = new JSONObject(simpleResponse.RowData);
		  if (!jSONObject1.isNull("cars"))
		  {
			simpleResponse.Data["cars"] = jSONObject1.getString("cars");
		  }
		  if (!jSONObject1.isNull("parks"))
		  {
			simpleResponse.Data["parks"] = jSONObject1.getString("parks");
		  }
		  if (!jSONObject1.isNull("online"))
		  {
			simpleResponse.Data["online"] = jSONObject1.getString("online");
		  }
		  if (!jSONObject1.isNull("calibrate"))
		  {
			simpleResponse.Data["calibrate"] = jSONObject1.getString("calibrate");
		  }
		}
		return simpleResponse;
	  }

	  public virtual OnTheWayResponse doTaxiOnTheWay(string paramString1, string paramString2, string paramString3)
	  {
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("id", paramString1);
		jSONObject.put("orderid", paramString2);
		jSONObject.put("break", paramString3);
		OnTheWayResponse onTheWayResponse = new OnTheWayResponse(a("taxiontheway", jSONObject, false));
		if (onTheWayResponse.Code == 200 && !onTheWayResponse.Blocked)
		{
		  a(onTheWayResponse, new JSONObject(onTheWayResponse.RowData));
		}
		return onTheWayResponse;
	  }

	  public virtual SearchResponse doTaxiSearch(string paramString1, string paramString2, string paramString3)
	  {
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("id", paramString1);
		jSONObject.put("break", paramString3);
		jSONObject.put("orderid", paramString2);
		SearchResponse searchResponse = new SearchResponse(a("taxisearch", jSONObject, false));
		if (searchResponse.Code == 200 && !searchResponse.Blocked)
		{
		  sbyte b;
		  JSONObject jSONObject1 = new JSONObject(searchResponse.RowData);
		  if (!jSONObject1.isNull("found"))
		  {
			searchResponse.Found = "1".Equals(jSONObject1.getString("found"));
			b = 0;
		  }
		  else if (!jSONObject1.isNull("expired"))
		  {
			searchResponse.Expired = "1".Equals(jSONObject1.getString("expired"));
			b = 0;
		  }
		  else
		  {
			b = 1;
		  }
		  if (!b && !searchResponse.Found && !searchResponse.Expired)
		  {
			searchResponse.Calibrate = jSONObject1.getString("calibrate");
			JSONArray jSONArray2 = jSONObject1.getJSONArray("source");
			searchResponse.Source = new GeoPoint(jSONArray2.getDouble(1), jSONArray2.getDouble(0));
			JSONArray jSONArray3 = jSONObject1.getJSONArray("freecars");
			for (b = 0; b < jSONArray3.length(); b++)
			{
			  jSONArray2 = jSONArray3.getJSONArray(b);
			  searchResponse.addFreeCar(new GeoPoint(Convert.ToDouble(jSONArray2.getString(1)), Convert.ToDouble(jSONArray2.getString(0))));
			}
			JSONArray jSONArray1 = jSONObject1.getJSONArray("busycars");
			for (b = 0; b < jSONArray1.length(); b++)
			{
			  jSONArray2 = jSONArray1.getJSONArray(b);
			  searchResponse.addBusyCar(new GeoPoint(Convert.ToDouble(jSONArray2.getString(1)), Convert.ToDouble(jSONArray2.getString(0))));
			}
		  }
		}
		return searchResponse;
	  }

	  public virtual List<Park> doTaxiSearchLater(string paramString, DateTime paramDate)
	  {
		sbyte b = 0;
		JSONObject jSONObject = new JSONObject();
		jSONObject.put("city", paramString);
		if (paramDate != null)
		{
		  jSONObject.put("time", DATE_FORMAT.format(paramDate));
		}
		SimpleResponse simpleResponse = new SimpleResponse(a("taxisearchlater", jSONObject, false));
		List<Park> arrayList = new ArrayList();
		if (simpleResponse.Code == 200 && !simpleResponse.Blocked)
		{
		  JSONArray jSONArray = new JSONArray(simpleResponse.RowData);
		  if (jSONArray.length() != 0)
		  {
			while (b < jSONArray.length())
			{
			  JSONObject jSONObject1 = jSONArray.getJSONObject(b);
			  Park park = new Park();
			  if (jSONObject1.isNull("parkid"))
			  {
				park.ParkId = jSONObject1.getString("id");
			  }
			  else
			  {
				park.ParkId = jSONObject1.getString("parkid");
			  }
			  park.Name = jSONObject1.getString("name");
			  park.Phone = jSONObject1.getString("phone");
			  park.Type = jSONObject1.getString("type");
			  park.OrderAllowed = "1".Equals(jSONObject1.getString("orderallowed"));
			  if (!jSONObject1.isNull("rating"))
			  {
				park.Rating = double.Parse(jSONObject1.getString("rating"));
			  }
			  arrayList.Add(park);
			  b++;
			}
		  }
		}
		return arrayList;
	  }

	  public virtual GeocodeJsonObject getGeoObject(GeoPoint paramGeoPoint)
	  {
		GeoPoint geoPoint1;
		GeoPoint geoPoint2 = null;
		try
		{
		  StringBuilder stringBuilder = new StringBuilder();
		  this();
		  GeocodeResponse geocodeResponse = doGeocode(stringBuilder.Append(paramGeoPoint.Lon).Append(",").Append(paramGeoPoint.Lat).ToString());
		  paramGeoPoint = geoPoint2;
		  if (!geocodeResponse.Blocked)
		  {
			paramGeoPoint = geoPoint2;
			if (geocodeResponse.Code == 200)
			{
			  GeocodeJsonObject geocodeJsonObject = geocodeResponse.GeocodeObject;
			}
		  }
		}
		catch (Exception exception)
		{
		  Log.e(a_Conflict, "Fail get geo json object by user location", exception);
		  geoPoint1 = geoPoint2;
		}
		return (GeocodeJsonObject)geoPoint1;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\TaxiClient.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}