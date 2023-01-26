using System.Threading;

using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class ne : Thread
{
  private long b;

  private bool c;

  public ne(SearchTaxiActivity paramSearchTaxiActivity)
  {
	long l;
	if (paramSearchTaxiActivity.mDemoMode)
	{
	  l = 2000L;
	}
	else
	{
	  l = 5000L;
	}
	this.b = l;
  }

  public virtual void run()
  {
	// Byte code:
	//   0: new nd
	//   3: astore_1
	//   4: aload_1
	//   5: aload_0
	//   6: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   9: invokespecial <init> : (Lru/yandex/taxi/activity/SearchTaxiActivity;)V
	//   12: aload_0
	//   13: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   16: getfield mInterrupt : Z
	//   19: istore_2
	//   20: iload_2
	//   21: ifne -> 189
	//   24: aload_0
	//   25: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   28: getfield mTaxiClient : Lru/yandex/taxi/client/TaxiClient;
	//   31: aload_0
	//   32: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   35: getfield mClientId : Ljava/lang/String;
	//   38: aload_0
	//   39: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   42: getfield mOrderId : Ljava/lang/String;
	//   45: aload_0
	//   46: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   49: getfield mBreak : Ljava/lang/String;
	//   52: invokevirtual doTaxiSearch : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lru/yandex/taxi/client/response/SearchResponse;
	//   55: astore_3
	//   56: aload_3
	//   57: ifnull -> 549
	//   60: aload_0
	//   61: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   64: invokestatic v : (Lru/yandex/taxi/activity/SearchTaxiActivity;)I
	//   67: pop
	//   68: aload_0
	//   69: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   72: invokestatic w : (Lru/yandex/taxi/activity/SearchTaxiActivity;)I
	//   75: i2l
	//   76: ldc2_w 4
	//   79: lcmp
	//   80: ifle -> 101
	//   83: aload_0
	//   84: getfield b : J
	//   87: ldc2_w 20000
	//   90: lcmp
	//   91: ifeq -> 101
	//   94: aload_0
	//   95: ldc2_w 20000
	//   98: putfield b : J
	//   101: aload_0
	//   102: getfield c : Z
	//   105: ifeq -> 137
	//   108: aload_0
	//   109: iconst_0
	//   110: putfield c : Z
	//   113: aload_0
	//   114: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   117: astore #4
	//   119: new ng
	//   122: astore #5
	//   124: aload #5
	//   126: aload_0
	//   127: invokespecial <init> : (Lne;)V
	//   130: aload #4
	//   132: aload #5
	//   134: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   137: aload_3
	//   138: invokevirtual getCode : ()I
	//   141: sipush #200
	//   144: if_icmpne -> 468
	//   147: aload_3
	//   148: invokevirtual isExpired : ()Z
	//   151: ifeq -> 226
	//   154: aload_0
	//   155: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   158: iconst_1
	//   159: putfield mStopSearch : Z
	//   162: aload_0
	//   163: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   166: iconst_1
	//   167: putfield mInterrupt : Z
	//   170: aload_0
	//   171: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   174: astore_3
	//   175: new nh
	//   178: astore_1
	//   179: aload_1
	//   180: aload_0
	//   181: invokespecial <init> : (Lne;)V
	//   184: aload_3
	//   185: aload_1
	//   186: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   189: return
	//   190: astore_3
	//   191: ldc 'SearchTaxiActivity'
	//   193: ldc 'Taxi search connection error:'
	//   195: aload_3
	//   196: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
	//   199: pop
	//   200: aload_0
	//   201: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   204: astore #4
	//   206: new nf
	//   209: astore_3
	//   210: aload_3
	//   211: aload_0
	//   212: invokespecial <init> : (Lne;)V
	//   215: aload #4
	//   217: aload_3
	//   218: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   221: aconst_null
	//   222: astore_3
	//   223: goto -> 56
	//   226: aload_0
	//   227: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   230: invokestatic x : (Lru/yandex/taxi/activity/SearchTaxiActivity;)Z
	//   233: ifne -> 409
	//   236: aload_3
	//   237: invokevirtual getCalibrate : ()Ljava/lang/String;
	//   240: ifnull -> 409
	//   243: ldc '0'
	//   245: aload_3
	//   246: invokevirtual getCalibrate : ()Ljava/lang/String;
	//   249: invokevirtual equals : (Ljava/lang/Object;)Z
	//   252: ifne -> 409
	//   255: aload_0
	//   256: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   259: invokevirtual getContentResolver : ()Landroid/content/ContentResolver;
	//   262: astore #4
	//   264: getstatic ru/yandex/taxi/db/StaticDataScheme$NoCalibrateTable.CONTENT_URI : Landroid/net/Uri;
	//   267: astore #5
	//   269: aload_0
	//   270: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   273: getfield mOrderId : Ljava/lang/String;
	//   276: astore #6
	//   278: aload #4
	//   280: aload #5
	//   282: iconst_1
	//   283: anewarray java/lang/String
	//   286: dup
	//   287: iconst_0
	//   288: ldc '_id'
	//   290: aastore
	//   291: ldc 'order_id = ?'
	//   293: iconst_1
	//   294: anewarray java/lang/String
	//   297: dup
	//   298: iconst_0
	//   299: aload #6
	//   301: aastore
	//   302: aconst_null
	//   303: invokevirtual query : (Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;
	//   306: invokeinterface getCount : ()I
	//   311: ifne -> 377
	//   314: aload_0
	//   315: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   318: iconst_1
	//   319: putfield mStopSearch : Z
	//   322: aload_0
	//   323: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   326: iconst_1
	//   327: putfield mInterrupt : Z
	//   330: aload_0
	//   331: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   334: aload_3
	//   335: invokevirtual getCalibrate : ()Ljava/lang/String;
	//   338: invokestatic a : (Lru/yandex/taxi/activity/SearchTaxiActivity;Ljava/lang/String;)Ljava/lang/String;
	//   341: pop
	//   342: aload_0
	//   343: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   346: astore_1
	//   347: new ni
	//   350: astore_3
	//   351: aload_3
	//   352: aload_0
	//   353: invokespecial <init> : (Lne;)V
	//   356: aload_1
	//   357: aload_3
	//   358: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   361: goto -> 189
	//   364: astore_3
	//   365: ldc 'SearchTaxiActivity'
	//   367: ldc 'Fail update taxi cars data'
	//   369: aload_3
	//   370: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
	//   373: pop
	//   374: goto -> 189
	//   377: aload_0
	//   378: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   381: iconst_1
	//   382: invokestatic b : (Lru/yandex/taxi/activity/SearchTaxiActivity;Z)Z
	//   385: pop
	//   386: aload_1
	//   387: aload_3
	//   388: putfield a : Lru/yandex/taxi/client/response/SearchResponse;
	//   391: aload_0
	//   392: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   395: aload_1
	//   396: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   399: aload_0
	//   400: getfield b : J
	//   403: invokestatic sleep : (J)V
	//   406: goto -> 12
	//   409: aload_3
	//   410: invokevirtual isFound : ()Z
	//   413: ifeq -> 452
	//   416: aload_0
	//   417: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   420: iconst_1
	//   421: putfield mStopSearch : Z
	//   424: aload_0
	//   425: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   428: iconst_1
	//   429: putfield mInterrupt : Z
	//   432: aload_0
	//   433: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   436: astore_3
	//   437: aload_0
	//   438: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   441: getfield mTaxiClient : Lru/yandex/taxi/client/TaxiClient;
	//   444: astore_1
	//   445: aload_3
	//   446: invokestatic f : (Lru/yandex/taxi/activity/SearchTaxiActivity;)V
	//   449: goto -> 189
	//   452: aload_1
	//   453: aload_3
	//   454: putfield a : Lru/yandex/taxi/client/response/SearchResponse;
	//   457: aload_0
	//   458: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   461: aload_1
	//   462: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   465: goto -> 399
	//   468: aload_3
	//   469: invokevirtual isBlocked : ()Z
	//   472: ifeq -> 399
	//   475: aload_0
	//   476: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   479: ldc 'vibrator'
	//   481: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
	//   484: checkcast android/os/Vibrator
	//   487: ldc2_w 1000
	//   490: invokevirtual vibrate : (J)V
	//   493: new android/content/Intent
	//   496: astore_1
	//   497: aload_1
	//   498: aload_0
	//   499: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   502: ldc ru/yandex/taxi/activity/AuthorizeActivity
	//   504: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
	//   507: aload_1
	//   508: ldc 'block'
	//   510: iconst_1
	//   511: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
	//   514: pop
	//   515: aload_1
	//   516: ldc 'release date'
	//   518: aload_3
	//   519: invokevirtual getBlockDate : ()Ljava/util/Date;
	//   522: invokevirtual putExtra : (Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;
	//   525: pop
	//   526: aload_1
	//   527: ldc 'block type'
	//   529: aload_3
	//   530: invokevirtual getBlockType : ()Ljava/lang/String;
	//   533: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
	//   536: pop
	//   537: aload_0
	//   538: getfield a : Lru/yandex/taxi/activity/SearchTaxiActivity;
	//   541: aload_1
	//   542: iconst_0
	//   543: invokevirtual startActivityForResult : (Landroid/content/Intent;I)V
	//   546: goto -> 189
	//   549: aload_0
	//   550: iconst_1
	//   551: putfield c : Z
	//   554: goto -> 399
	// Exception table:
	//   from	to	target	type
	//   0	12	364	java/lang/Exception
	//   12	20	364	java/lang/Exception
	//   24	56	190	java/lang/Exception
	//   60	101	364	java/lang/Exception
	//   101	137	364	java/lang/Exception
	//   137	189	364	java/lang/Exception
	//   191	221	364	java/lang/Exception
	//   226	361	364	java/lang/Exception
	//   377	399	364	java/lang/Exception
	//   399	406	364	java/lang/Exception
	//   409	449	364	java/lang/Exception
	//   452	465	364	java/lang/Exception
	//   468	546	364	java/lang/Exception
	//   549	554	364	java/lang/Exception
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ne.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */