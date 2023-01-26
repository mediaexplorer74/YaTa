using System.Threading;

using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;

public class ow : Thread
{
  private long b;

  public ow(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity)
  {
	long l;
	if (paramTaxiOnTheWayToSourceActivity.mDemoMode)
	{
	  l = 2000L;
	}
	else
	{
	  l = 20000L;
	}
	this.b = l;
  }

  public virtual void run()
  {
	// Byte code:
	//   0: new ot
	//   3: astore_1
	//   4: aload_1
	//   5: aload_0
	//   6: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   9: invokespecial <init> : (Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;)V
	//   12: aload_0
	//   13: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   16: getfield mInterrupt : Z
	//   19: istore_2
	//   20: iload_2
	//   21: ifne -> 182
	//   24: aload_0
	//   25: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   28: invokevirtual requestData : ()Lru/yandex/taxi/client/response/OnTheWayResponse;
	//   31: astore_3
	//   32: aload_3
	//   33: ifnull -> 371
	//   36: aload_3
	//   37: invokevirtual getCode : ()I
	//   40: sipush #200
	//   43: if_icmpne -> 371
	//   46: ldc 'failed'
	//   48: aload_3
	//   49: invokevirtual getStatus : ()Ljava/lang/String;
	//   52: invokevirtual equals : (Ljava/lang/Object;)Z
	//   55: ifeq -> 219
	//   58: aload_3
	//   59: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   62: ldc 'parkid'
	//   64: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   67: ifnull -> 137
	//   70: aload_0
	//   71: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   74: aload_3
	//   75: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   78: ldc 'parkid'
	//   80: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   83: checkcast java/lang/String
	//   86: aload_3
	//   87: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   90: ldc 'phone'
	//   92: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   95: checkcast java/lang/String
	//   98: aload_3
	//   99: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   102: ldc 'name'
	//   104: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   107: checkcast java/lang/String
	//   110: aload_3
	//   111: invokevirtual getTariff : ()Ljava/util/HashMap;
	//   114: ldc 'tariffid'
	//   116: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   119: checkcast java/lang/String
	//   122: aload_3
	//   123: invokevirtual getTariff : ()Ljava/util/HashMap;
	//   126: ldc 'name'
	//   128: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   131: checkcast java/lang/String
	//   134: invokevirtual initTaxiInfoUi : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V
	//   137: aload_0
	//   138: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   141: ldc 'vibrator'
	//   143: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
	//   146: checkcast android/os/Vibrator
	//   149: ldc2_w 1500
	//   152: invokevirtual vibrate : (J)V
	//   155: aload_0
	//   156: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   159: astore_1
	//   160: new oy
	//   163: astore_3
	//   164: aload_3
	//   165: aload_0
	//   166: invokespecial <init> : (Low;)V
	//   169: aload_1
	//   170: aload_3
	//   171: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   174: aload_0
	//   175: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   178: iconst_1
	//   179: putfield mInterrupt : Z
	//   182: return
	//   183: astore_3
	//   184: ldc 'TaxiOnTheWayToSourceActivity'
	//   186: ldc 'Fail get taxi on the way data'
	//   188: invokestatic e : (Ljava/lang/String;Ljava/lang/String;)I
	//   191: pop
	//   192: aload_0
	//   193: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   196: astore_3
	//   197: new ox
	//   200: astore #4
	//   202: aload #4
	//   204: aload_0
	//   205: invokespecial <init> : (Low;)V
	//   208: aload_3
	//   209: aload #4
	//   211: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   214: aconst_null
	//   215: astore_3
	//   216: goto -> 32
	//   219: aload_0
	//   220: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   223: getfield mCurrentStatus : Ljava/lang/String;
	//   226: aload_3
	//   227: invokevirtual getStatus : ()Ljava/lang/String;
	//   230: invokevirtual equals : (Ljava/lang/Object;)Z
	//   233: ifeq -> 272
	//   236: aload_1
	//   237: aload_3
	//   238: putfield a : Lru/yandex/taxi/client/response/OnTheWayResponse;
	//   241: aload_0
	//   242: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   245: aload_1
	//   246: invokevirtual runOnUiThread : (Ljava/lang/Runnable;)V
	//   249: aload_0
	//   250: getfield b : J
	//   253: invokestatic sleep : (J)V
	//   256: goto -> 12
	//   259: astore_3
	//   260: ldc 'TaxiOnTheWayToSourceActivity'
	//   262: ldc 'Fail update taxi cars data'
	//   264: aload_3
	//   265: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
	//   268: pop
	//   269: goto -> 182
	//   272: aload_0
	//   273: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   276: getfield mParkId : Ljava/lang/String;
	//   279: ifnonnull -> 361
	//   282: aload_3
	//   283: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   286: ldc 'parkid'
	//   288: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   291: ifnull -> 361
	//   294: aload_0
	//   295: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   298: aload_3
	//   299: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   302: ldc 'parkid'
	//   304: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   307: checkcast java/lang/String
	//   310: aload_3
	//   311: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   314: ldc 'phone'
	//   316: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   319: checkcast java/lang/String
	//   322: aload_3
	//   323: invokevirtual getTaxi : ()Ljava/util/HashMap;
	//   326: ldc 'name'
	//   328: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   331: checkcast java/lang/String
	//   334: aload_3
	//   335: invokevirtual getTariff : ()Ljava/util/HashMap;
	//   338: ldc 'tariffid'
	//   340: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   343: checkcast java/lang/String
	//   346: aload_3
	//   347: invokevirtual getTariff : ()Ljava/util/HashMap;
	//   350: ldc 'name'
	//   352: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   355: checkcast java/lang/String
	//   358: invokevirtual initTaxiInfoUi : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V
	//   361: aload_0
	//   362: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   365: invokevirtual showTaxiArriveEvent : ()V
	//   368: goto -> 182
	//   371: aload_3
	//   372: ifnull -> 249
	//   375: aload_3
	//   376: invokevirtual isBlocked : ()Z
	//   379: ifeq -> 249
	//   382: aload_0
	//   383: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   386: ldc 'vibrator'
	//   388: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
	//   391: checkcast android/os/Vibrator
	//   394: ldc2_w 1500
	//   397: invokevirtual vibrate : (J)V
	//   400: new android/content/Intent
	//   403: astore_1
	//   404: aload_1
	//   405: aload_0
	//   406: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   409: ldc ru/yandex/taxi/activity/AuthorizeActivity
	//   411: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
	//   414: aload_1
	//   415: ldc 'block'
	//   417: iconst_1
	//   418: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
	//   421: pop
	//   422: aload_1
	//   423: ldc 'release date'
	//   425: aload_3
	//   426: invokevirtual getBlockDate : ()Ljava/util/Date;
	//   429: invokevirtual putExtra : (Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;
	//   432: pop
	//   433: aload_1
	//   434: ldc 'block type'
	//   436: aload_3
	//   437: invokevirtual getBlockType : ()Ljava/lang/String;
	//   440: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
	//   443: pop
	//   444: aload_0
	//   445: getfield a : Lru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity;
	//   448: aload_1
	//   449: iconst_4
	//   450: invokevirtual startActivityForResult : (Landroid/content/Intent;I)V
	//   453: goto -> 182
	// Exception table:
	//   from	to	target	type
	//   0	12	259	java/lang/Exception
	//   12	20	259	java/lang/Exception
	//   24	32	183	java/lang/Exception
	//   36	137	259	java/lang/Exception
	//   137	182	259	java/lang/Exception
	//   184	214	259	java/lang/Exception
	//   219	249	259	java/lang/Exception
	//   249	256	259	java/lang/Exception
	//   272	361	259	java/lang/Exception
	//   361	368	259	java/lang/Exception
	//   375	453	259	java/lang/Exception
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ow.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */