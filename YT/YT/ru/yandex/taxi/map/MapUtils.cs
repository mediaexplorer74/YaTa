using System;
using System.Collections.Generic;
using System.Threading;

namespace ru.yandex.taxi.map
{
	using Activity = android.app.Activity;
	using Context = android.content.Context;
	using SharedPreferences = android.content.SharedPreferences;
	using Location = android.location.Location;
	using LocationListener = android.location.LocationListener;
	using LocationManager = android.location.LocationManager;
	using PreferenceManager = android.preference.PreferenceManager;
	using qi;
	using qj;
	using qk;
	using ru.yandex.taxi;
	using MapView = ru.yandex.yandexmapkit.MapView;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class MapUtils
	{
	  public const int DEAULT_ZOOM_TIMEOUT = 300;

	  public const string DEFAULT_CITY = "Москва";

	  public const string DEFAULT_COUNTRY = "Россия";

	  public static readonly GeoPoint DEFAULT_POINT = new GeoPoint(55.7538D, 37.62193D);

	  public static readonly string DEFAULT_USER_LOCATION_STRING = "Россия,Москва;;Москва;;Россия;;Москва;;null;;null;;null;;" + DEFAULT_POINT.Lat + "--" + DEFAULT_POINT.Lon + ";;" + char.MinValue;

	  public const float DEMO_ZOOM = 14.0F;

	  public const float HOUSE_ZOOM = 16.0F;

	  public const int MAX_DEFAULT_LBS_PRECISION = 1000;

	  public const int MAX_PRECISION = 100;

	  public const float MAX_ZOOM = 17.0F;

	  public const int MIN_PRECISION = 3000;

	  public const float NATURAL_ZOOM = 23.0F;

	  public const float NORM_ZOOM = 12.0F;

	  public const float TAXI_MAP_ZOOM = 12.0F;

	  public const int TAXI_RANGE = 100000;

	  public const string USER_LOCATION = "user location";

	  private static Dictionary<long, LocationListener> a = new Dictionary<long, LocationListener>();

	  private static long b(Activity paramActivity, OnFindPointListener paramOnFindPointListener)
	  {
		LocationManager locationManager = (LocationManager)paramActivity.getSystemService("location");
		long l = DateTimeHelper.CurrentUnixTimeMillis();
		qi qi = new qi(paramOnFindPointListener, locationManager, l);
		a[Convert.ToInt64(l)] = qi;
		paramActivity.runOnUiThread((ThreadStart)new qj(locationManager, (LocationListener)qi));
		(new Timer()).schedule((TimerTask)new qk(locationManager, (LocationListener)qi, l, paramOnFindPointListener, paramActivity), 15000L);
		return l;
	  }

	  public static GeoPoint getLastKnownMyLocationPoint(Context paramContext)
	  {
		GeoPoint geoPoint1;
		LocationManager locationManager = (LocationManager)paramContext.getSystemService("location");
		IList<string> list = locationManager.getProviders(true);
		paramContext = null;
		DateTime date = DateTime.Now;
		date.setYear(2000);
		for (int i = list.Count - 1; i >= 0; i--)
		{
		  Location location = locationManager.getLastKnownLocation(list[i]);
		  if (location != null && location.getTime() > date.Ticks)
		  {
			date = new DateTime(location.getTime());
			geoPoint1 = new GeoPoint(location.getLatitude(), location.getLongitude());
		  }
		}
		GeoPoint geoPoint2 = geoPoint1;
		if (geoPoint1 == null)
		{
		  geoPoint2 = DEFAULT_POINT;
		}
		return geoPoint2;
	  }

	  public static Pair<GeoPoint, bool> getLbsLocation(Activity paramActivity, OnFindPointListener paramOnFindPointListener, bool paramBoolean)
	  {
		// Byte code:
		//   0: aload_0
		//   1: ldc 'location'
		//   3: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
		//   6: checkcast android/location/LocationManager
		//   9: astore_3
		//   10: aload_3
		//   11: ldc 'gps'
		//   13: invokevirtual isProviderEnabled : (Ljava/lang/String;)Z
		//   16: istore #4
		//   18: iload_2
		//   19: ifeq -> 130
		//   22: iload #4
		//   24: ifeq -> 130
		//   27: aload_0
		//   28: ldc 'location'
		//   30: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
		//   33: checkcast android/location/LocationManager
		//   36: astore_3
		//   37: invokestatic currentTimeMillis : ()J
		//   40: lstore #5
		//   42: new ql
		//   45: dup
		//   46: aload_1
		//   47: aload_3
		//   48: lload #5
		//   50: invokespecial <init> : (Lru/yandex/taxi/map/OnFindPointListener;Landroid/location/LocationManager;J)V
		//   53: astore #7
		//   55: getstatic ru/yandex/taxi/map/MapUtils.a : Ljava/util/HashMap;
		//   58: lload #5
		//   60: invokestatic valueOf : (J)Ljava/lang/Long;
		//   63: aload #7
		//   65: invokevirtual put : (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
		//   68: pop
		//   69: aload_0
		//   70: new qm
		//   73: dup
		//   74: aload_3
		//   75: aload #7
		//   77: invokespecial <init> : (Landroid/location/LocationManager;Landroid/location/LocationListener;)V
		//   80: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
		//   83: new java/util/Timer
		//   86: dup
		//   87: invokespecial <init> : ()V
		//   90: new qn
		//   93: dup
		//   94: aload_3
		//   95: aload #7
		//   97: lload #5
		//   99: aload_0
		//   100: aload_1
		//   101: invokespecial <init> : (Landroid/location/LocationManager;Landroid/location/LocationListener;JLandroid/app/Activity;Lru/yandex/taxi/map/OnFindPointListener;)V
		//   104: ldc2_w 15000
		//   107: invokevirtual schedule : (Ljava/util/TimerTask;J)V
		//   110: aconst_null
		//   111: astore_0
		//   112: aload_0
		//   113: areturn
		//   114: astore_3
		//   115: ldc 'MapUtils'
		//   117: ldc 'No gps provider found'
		//   119: aload_3
		//   120: invokestatic w : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
		//   123: pop
		//   124: iconst_0
		//   125: istore #4
		//   127: goto -> 18
		//   130: new ru/yandex/taxi/client/TaxiClient
		//   133: dup
		//   134: aload_0
		//   135: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   138: new ru/yandex/taxi/client/HttpUrlConnectionUtils
		//   141: dup
		//   142: invokespecial <init> : ()V
		//   145: invokespecial <init> : (Landroid/content/Context;Lru/yandex/taxi/client/HttpUtils;)V
		//   148: invokevirtual doGetLbsLocation : ()Lru/yandex/taxi/Pair;
		//   151: astore_3
		//   152: aload_3
		//   153: getfield second : Ljava/lang/Object;
		//   156: checkcast java/lang/Double
		//   159: invokevirtual doubleValue : ()D
		//   162: ldc2_w 100.0
		//   165: dcmpl
		//   166: ifle -> 180
		//   169: aload_0
		//   170: aload_1
		//   171: invokestatic b : (Landroid/app/Activity;Lru/yandex/taxi/map/OnFindPointListener;)J
		//   174: pop2
		//   175: aconst_null
		//   176: astore_0
		//   177: goto -> 112
		//   180: aload_3
		//   181: getfield first : Ljava/lang/Object;
		//   184: astore_0
		//   185: aload_3
		//   186: getfield second : Ljava/lang/Object;
		//   189: checkcast java/lang/Double
		//   192: invokevirtual doubleValue : ()D
		//   195: ldc2_w 3000.0
		//   198: dcmpg
		//   199: ifge -> 220
		//   202: iconst_1
		//   203: istore_2
		//   204: new ru/yandex/taxi/Pair
		//   207: dup
		//   208: aload_0
		//   209: iload_2
		//   210: invokestatic valueOf : (Z)Ljava/lang/Boolean;
		//   213: invokespecial <init> : (Ljava/lang/Object;Ljava/lang/Object;)V
		//   216: astore_0
		//   217: goto -> 112
		//   220: iconst_0
		//   221: istore_2
		//   222: goto -> 204
		// Exception table:
		//   from	to	target	type
		//   10	18	114	java/lang/IllegalArgumentException
	  }

	  public static GeocodeJsonObject getUserLocation(Context paramContext)
	  {
		return new GeocodeJsonObject(PreferenceManager.getDefaultSharedPreferences(paramContext).getString("user location", DEFAULT_USER_LOCATION_STRING));
	  }

	  public static bool isVisible(MapView paramMapView, GeoPoint paramGeoPoint, int paramInt1, int paramInt2)
	  {
		ScreenPoint screenPoint = paramMapView.MapController.getScreenPoint(paramGeoPoint);
		if (screenPoint.X > 0.0F && screenPoint.Y > 0.0F)
		{
		  float f = screenPoint.Y;
		  if (paramInt2 <= 0)
		  {
			paramInt2 = paramMapView.getHeight();
		  }
		  if (f < paramInt2)
		  {
			f = screenPoint.X;
			if (paramInt1 <= 0)
			{
			  paramInt1 = paramMapView.getWidth();
			}
			if (f < paramInt1)
			{
			  return true;
			}
		  }
		}
		return false;
	  }

	  public static void saveUserLocation(Context paramContext, GeocodeJsonObject paramGeocodeJsonObject)
	  {
		if (paramGeocodeJsonObject != null && paramGeocodeJsonObject.Count != 0)
		{
		  SharedPreferences.Editor editor = PreferenceManager.getDefaultSharedPreferences(paramContext).edit();
		  editor.putString("user location", paramGeocodeJsonObject.serialize());
		  editor.commit();
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\map\MapUtils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}