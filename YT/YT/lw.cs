using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using AsyncTask = android.os.AsyncTask;
using Parcelable = android.os.Parcelable;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using SearchResultsActivity = ru.yandex.taxi.activity.SearchResultsActivity;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class lw : AsyncTask<GeocodeJsonObject, int, GeocodeJsonObject>
{
  private ProgressDialog b;

  public lw(SearchResultsActivity paramSearchResultsActivity)
  {
  }

  protected internal virtual GeocodeJsonObject a(params GeocodeJsonObject[] paramVarArgs)
  {
	// Byte code:
	//   0: aload_1
	//   1: iconst_0
	//   2: aaload
	//   3: astore_2
	//   4: aload_0
	//   5: getfield a : Lru/yandex/taxi/activity/SearchResultsActivity;
	//   8: invokestatic d : (Lru/yandex/taxi/activity/SearchResultsActivity;)Lru/yandex/taxi/client/TaxiClient;
	//   11: astore_1
	//   12: aload_2
	//   13: invokevirtual getText : ()Ljava/lang/String;
	//   16: astore_3
	//   17: new java/lang/StringBuilder
	//   20: astore #4
	//   22: aload #4
	//   24: invokespecial <init> : ()V
	//   27: aload_1
	//   28: aload_3
	//   29: aload #4
	//   31: aload_2
	//   32: invokevirtual getGeoPoint : ()Lru/yandex/yandexmapkit/utils/GeoPoint;
	//   35: invokevirtual getLon : ()D
	//   38: invokevirtual append : (D)Ljava/lang/StringBuilder;
	//   41: ldc ','
	//   43: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   46: aload_2
	//   47: invokevirtual getGeoPoint : ()Lru/yandex/yandexmapkit/utils/GeoPoint;
	//   50: invokevirtual getLat : ()D
	//   53: invokevirtual append : (D)Ljava/lang/StringBuilder;
	//   56: invokevirtual toString : ()Ljava/lang/String;
	//   59: invokevirtual doGeocode : (Ljava/lang/String;Ljava/lang/String;)Lru/yandex/taxi/client/response/GeocodeResponse;
	//   62: astore_1
	//   63: aload_1
	//   64: invokevirtual getCode : ()I
	//   67: sipush #200
	//   70: if_icmpne -> 210
	//   73: aload_1
	//   74: invokevirtual isBlocked : ()Z
	//   77: ifne -> 210
	//   80: aload_1
	//   81: invokevirtual getGeocodeObject : ()Lru/yandex/taxi/map/GeocodeJsonObject;
	//   84: astore #4
	//   86: aload #4
	//   88: astore_1
	//   89: aload #4
	//   91: invokevirtual getCount : ()I
	//   94: ifne -> 167
	//   97: aload_0
	//   98: getfield a : Lru/yandex/taxi/activity/SearchResultsActivity;
	//   101: invokestatic d : (Lru/yandex/taxi/activity/SearchResultsActivity;)Lru/yandex/taxi/client/TaxiClient;
	//   104: astore_1
	//   105: new java/lang/StringBuilder
	//   108: astore #4
	//   110: aload #4
	//   112: invokespecial <init> : ()V
	//   115: aload_1
	//   116: aload #4
	//   118: aload_2
	//   119: invokevirtual getGeoPoint : ()Lru/yandex/yandexmapkit/utils/GeoPoint;
	//   122: invokevirtual getLon : ()D
	//   125: invokevirtual append : (D)Ljava/lang/StringBuilder;
	//   128: ldc ','
	//   130: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   133: aload_2
	//   134: invokevirtual getGeoPoint : ()Lru/yandex/yandexmapkit/utils/GeoPoint;
	//   137: invokevirtual getLat : ()D
	//   140: invokevirtual append : (D)Ljava/lang/StringBuilder;
	//   143: invokevirtual toString : ()Ljava/lang/String;
	//   146: invokevirtual doGeocode : (Ljava/lang/String;)Lru/yandex/taxi/client/response/GeocodeResponse;
	//   149: astore_1
	//   150: aload_1
	//   151: invokevirtual getCode : ()I
	//   154: sipush #200
	//   157: if_icmpeq -> 162
	//   160: aload_2
	//   161: areturn
	//   162: aload_1
	//   163: invokevirtual getGeocodeObject : ()Lru/yandex/taxi/map/GeocodeJsonObject;
	//   166: astore_1
	//   167: ldc 'organization'
	//   169: aload_2
	//   170: invokevirtual getType : ()Ljava/lang/String;
	//   173: invokevirtual equals : (Ljava/lang/Object;)Z
	//   176: ifeq -> 187
	//   179: aload_1
	//   180: aload_2
	//   181: invokevirtual getStreet : ()Ljava/lang/String;
	//   184: invokevirtual setComment : (Ljava/lang/String;)V
	//   187: aload_1
	//   188: aload_2
	//   189: invokevirtual getGeoPoint : ()Lru/yandex/yandexmapkit/utils/GeoPoint;
	//   192: invokevirtual setGeoPoint : (Lru/yandex/yandexmapkit/utils/GeoPoint;)V
	//   195: aload_1
	//   196: astore_2
	//   197: goto -> 160
	//   200: astore_1
	//   201: ldc 'SearchResultsActivity'
	//   203: ldc 'Fail get exact address for selected geo object'
	//   205: aload_1
	//   206: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
	//   209: pop
	//   210: aload_2
	//   211: astore_1
	//   212: goto -> 195
	// Exception table:
	//   from	to	target	type
	//   4	86	200	java/lang/Exception
	//   89	160	200	java/lang/Exception
	//   162	167	200	java/lang/Exception
	//   167	187	200	java/lang/Exception
	//   187	195	200	java/lang/Exception
  }

  protected internal virtual void a(GeocodeJsonObject paramGeocodeJsonObject)
  {
	if (!isCancelled())
	{
	  this.b.dismiss();
	  Intent intent = new Intent((Context)this.a, typeof(EditAddressActivity));
	  intent.putExtra("address", (Parcelable)paramGeocodeJsonObject);
	  intent.putExtra("type", SearchResultsActivity.e(this.a));
	  intent.putExtra("from city", paramGeocodeJsonObject.City);
	  this.a.startActivityForResult(intent, 0);
	}
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296366), true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */