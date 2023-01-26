using AsyncTask = android.os.AsyncTask;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using LaunchResponse = ru.yandex.taxi.client.response.LaunchResponse;

public class jq : AsyncTask<int, int, LaunchResponse>
{
  private jq(OrderActivity paramOrderActivity, sbyte paramByte)
  {
  }

  protected internal virtual LaunchResponse a()
  {
	return OrderActivity.e(this.a).checkAuthorization();
  }

  protected internal virtual void a(LaunchResponse paramLaunchResponse)
  {
	// Byte code:
	//   0: aload_1
	//   1: invokevirtual getServerMsgs : ()Ljava/util/List;
	//   4: invokeinterface size : ()I
	//   9: ifle -> 126
	//   12: aload_0
	//   13: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   16: invokestatic s : (Lru/yandex/taxi/activity/OrderActivity;)Landroid/content/SharedPreferences;
	//   19: ldc 'last msg show'
	//   21: lconst_0
	//   22: invokeinterface getLong : (Ljava/lang/String;J)J
	//   27: lstore_2
	//   28: aload_1
	//   29: invokevirtual getServerMsgs : ()Ljava/util/List;
	//   32: iconst_0
	//   33: invokeinterface get : (I)Ljava/lang/Object;
	//   38: checkcast ru/yandex/taxi/data/ServerMsg
	//   41: getfield date : Ljava/util/Date;
	//   44: invokevirtual getTime : ()J
	//   47: lload_2
	//   48: lcmp
	//   49: ifle -> 126
	//   52: aload_1
	//   53: invokevirtual getServerMsgs : ()Ljava/util/List;
	//   56: invokeinterface size : ()I
	//   61: iconst_1
	//   62: isub
	//   63: istore #4
	//   65: iload #4
	//   67: iflt -> 126
	//   70: lload_2
	//   71: aload_1
	//   72: invokevirtual getServerMsgs : ()Ljava/util/List;
	//   75: iload #4
	//   77: invokeinterface get : (I)Ljava/lang/Object;
	//   82: checkcast ru/yandex/taxi/data/ServerMsg
	//   85: getfield date : Ljava/util/Date;
	//   88: invokevirtual getTime : ()J
	//   91: lcmp
	//   92: ifge -> 354
	//   95: aload_0
	//   96: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   99: aload_1
	//   100: invokevirtual getServerMsgs : ()Ljava/util/List;
	//   103: invokestatic b : (Lru/yandex/taxi/activity/OrderActivity;Ljava/util/List;)Ljava/util/List;
	//   106: pop
	//   107: aload_0
	//   108: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   111: invokestatic aa : (Lru/yandex/taxi/activity/OrderActivity;)Z
	//   114: ifeq -> 341
	//   117: aload_0
	//   118: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   121: bipush #16
	//   123: invokevirtual showDialog : (I)V
	//   126: aload_1
	//   127: invokevirtual getCurrentOrders : ()Ljava/util/List;
	//   130: invokeinterface size : ()I
	//   135: ifle -> 169
	//   138: aload_0
	//   139: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   142: invokestatic aa : (Lru/yandex/taxi/activity/OrderActivity;)Z
	//   145: ifeq -> 169
	//   148: aload_0
	//   149: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   152: aload_1
	//   153: invokevirtual getCurrentOrders : ()Ljava/util/List;
	//   156: invokestatic a : (Lru/yandex/taxi/activity/OrderActivity;Ljava/util/List;)Ljava/util/List;
	//   159: pop
	//   160: aload_0
	//   161: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   164: bipush #9
	//   166: invokevirtual showDialog : (I)V
	//   169: aload_0
	//   170: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   173: ldc '1'
	//   175: aload_1
	//   176: invokevirtual getData : ()Ljava/util/HashMap;
	//   179: ldc 'checked'
	//   181: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   184: invokevirtual equals : (Ljava/lang/Object;)Z
	//   187: invokestatic e : (Lru/yandex/taxi/activity/OrderActivity;Z)Z
	//   190: pop
	//   191: aload_1
	//   192: invokevirtual getData : ()Ljava/util/HashMap;
	//   195: ldc 'server_time'
	//   197: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   200: ifnull -> 340
	//   203: aload_0
	//   204: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   207: invokestatic C : (Lru/yandex/taxi/activity/OrderActivity;)I
	//   210: ifne -> 340
	//   213: getstatic ru/yandex/taxi/client/TaxiClient.DATE_FORMAT : Ljava/text/SimpleDateFormat;
	//   216: aload_1
	//   217: invokevirtual getData : ()Ljava/util/HashMap;
	//   220: ldc 'server_time'
	//   222: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   225: checkcast java/lang/String
	//   228: invokevirtual parse : (Ljava/lang/String;)Ljava/util/Date;
	//   231: astore_1
	//   232: new java/util/Date
	//   235: astore #5
	//   237: aload #5
	//   239: invokespecial <init> : ()V
	//   242: aload_0
	//   243: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   246: aload_1
	//   247: invokevirtual getTime : ()J
	//   250: aload #5
	//   252: invokevirtual getTime : ()J
	//   255: lsub
	//   256: ldc2_w 60000
	//   259: ldiv
	//   260: l2i
	//   261: invokestatic b : (Lru/yandex/taxi/activity/OrderActivity;I)I
	//   264: pop
	//   265: aload_0
	//   266: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   269: invokestatic ab : (Lru/yandex/taxi/activity/OrderActivity;)Z
	//   272: ifne -> 308
	//   275: invokestatic getInstance : ()Ljava/util/Calendar;
	//   278: astore_1
	//   279: aload_1
	//   280: bipush #20
	//   282: aload_0
	//   283: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   286: invokestatic C : (Lru/yandex/taxi/activity/OrderActivity;)I
	//   289: invokestatic a : (Ljava/util/Calendar;II)V
	//   292: aload_1
	//   293: invokestatic a : (Ljava/util/Calendar;)V
	//   296: aload_0
	//   297: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   300: aload_1
	//   301: invokevirtual getTime : ()Ljava/util/Date;
	//   304: invokestatic a : (Lru/yandex/taxi/activity/OrderActivity;Ljava/util/Date;)Ljava/util/Date;
	//   307: pop
	//   308: aload_0
	//   309: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   312: aload_0
	//   313: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   316: invokestatic r : (Lru/yandex/taxi/activity/OrderActivity;)Ljava/util/Date;
	//   319: aload_0
	//   320: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   323: invokestatic C : (Lru/yandex/taxi/activity/OrderActivity;)I
	//   326: invokestatic a : (Ljava/util/Date;I)Z
	//   329: invokestatic k : (Lru/yandex/taxi/activity/OrderActivity;Z)Z
	//   332: pop
	//   333: aload_0
	//   334: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   337: invokestatic E : (Lru/yandex/taxi/activity/OrderActivity;)V
	//   340: return
	//   341: aload_0
	//   342: getfield a : Lru/yandex/taxi/activity/OrderActivity;
	//   345: bipush #16
	//   347: invokestatic a : (Lru/yandex/taxi/activity/OrderActivity;I)I
	//   350: pop
	//   351: goto -> 126
	//   354: iinc #4, -1
	//   357: goto -> 65
	//   360: astore_1
	//   361: ldc 'OrderActivity'
	//   363: new java/lang/StringBuilder
	//   366: dup
	//   367: invokespecial <init> : ()V
	//   370: ldc 'Fail parse date format: '
	//   372: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   375: aload_1
	//   376: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
	//   379: invokevirtual toString : ()Ljava/lang/String;
	//   382: invokestatic e : (Ljava/lang/String;Ljava/lang/String;)I
	//   385: pop
	//   386: goto -> 340
	// Exception table:
	//   from	to	target	type
	//   213	308	360	java/text/ParseException
	//   308	340	360	java/text/ParseException
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */