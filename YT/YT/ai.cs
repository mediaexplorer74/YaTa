using System.Threading;

using Context = android.content.Context;
using WifiManager = android.net.wifi.WifiManager;
using CellLocation = android.telephony.CellLocation;
using PhoneStateListener = android.telephony.PhoneStateListener;
using TelephonyManager = android.telephony.TelephonyManager;
using GsmCellLocation = android.telephony.gsm.GsmCellLocation;

public sealed class ai : PhoneStateListener, ThreadStart
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static volatile long a_Conflict;

  private TelephonyManager b;

  private WifiManager c;

  private int d;

  private bool e = false;

  private int f;

  private int g;

  private string h;

  private string i;

  private volatile bool j = false;

  private readonly bool k;

  private Context l;

  public ai(bool paramBoolean)
  {
	a_Conflict = 0L;
	this.k = paramBoolean;
  }

  public int a(bool paramBoolean)
  {
	return paramBoolean ? this.d : (this.d * 2 - 113);
  }

  public ag a()
  {
	// Byte code:
	//   0: aconst_null
	//   1: astore_1
	//   2: aconst_null
	//   3: astore_2
	//   4: aload_0
	//   5: getfield j : Z
	//   8: ifne -> 26
	//   11: ldc2_w 300
	//   14: invokestatic sleep : (J)V
	//   17: aload_0
	//   18: getfield j : Z
	//   21: ifne -> 26
	//   24: aload_2
	//   25: areturn
	//   26: aload_1
	//   27: astore_3
	//   28: aload_0
	//   29: getfield h : Ljava/lang/String;
	//   32: ifnull -> 468
	//   35: aload_1
	//   36: astore_3
	//   37: aload_0
	//   38: getfield i : Ljava/lang/String;
	//   41: ifnull -> 468
	//   44: aload_1
	//   45: astore_3
	//   46: new ag
	//   49: astore_2
	//   50: aload_1
	//   51: astore_3
	//   52: aload_2
	//   53: invokespecial <init> : ()V
	//   56: aload_2
	//   57: astore_3
	//   58: aload_2
	//   59: aload_0
	//   60: getfield g : I
	//   63: putfield d : I
	//   66: aload_2
	//   67: astore_3
	//   68: aload_2
	//   69: aload_0
	//   70: getfield f : I
	//   73: putfield e : I
	//   76: aload_2
	//   77: astore_3
	//   78: aload_2
	//   79: aload_0
	//   80: getfield h : Ljava/lang/String;
	//   83: putfield b : Ljava/lang/String;
	//   86: aload_2
	//   87: astore_3
	//   88: aload_2
	//   89: aload_0
	//   90: getfield i : Ljava/lang/String;
	//   93: putfield c : Ljava/lang/String;
	//   96: aload_2
	//   97: astore_3
	//   98: aload_2
	//   99: aload_0
	//   100: iconst_0
	//   101: invokevirtual a : (Z)I
	//   104: putfield f : I
	//   107: aload_2
	//   108: astore_3
	//   109: aload_2
	//   110: aload_0
	//   111: getfield e : Z
	//   114: putfield g : Z
	//   117: aload_2
	//   118: astore_1
	//   119: aload_2
	//   120: astore_3
	//   121: aload_0
	//   122: getfield c : Landroid/net/wifi/WifiManager;
	//   125: ifnull -> 450
	//   128: aload_2
	//   129: astore_1
	//   130: aload_2
	//   131: astore_3
	//   132: aload_0
	//   133: getfield c : Landroid/net/wifi/WifiManager;
	//   136: invokevirtual isWifiEnabled : ()Z
	//   139: ifeq -> 450
	//   142: aload_2
	//   143: astore_3
	//   144: aload_0
	//   145: getfield c : Landroid/net/wifi/WifiManager;
	//   148: invokevirtual getScanResults : ()Ljava/util/List;
	//   151: astore #4
	//   153: aload_2
	//   154: ifnonnull -> 465
	//   157: aload_2
	//   158: astore_3
	//   159: new ag
	//   162: astore_1
	//   163: aload_2
	//   164: astore_3
	//   165: aload_1
	//   166: invokespecial <init> : ()V
	//   169: aload_1
	//   170: astore_2
	//   171: aload #4
	//   173: ifnull -> 390
	//   176: aload_2
	//   177: astore_3
	//   178: aload #4
	//   180: invokeinterface size : ()I
	//   185: ifle -> 390
	//   188: aload_2
	//   189: astore_3
	//   190: new java/lang/StringBuilder
	//   193: astore #5
	//   195: aload_2
	//   196: astore_3
	//   197: aload #5
	//   199: sipush #200
	//   202: invokespecial <init> : (I)V
	//   205: aload_2
	//   206: astore_3
	//   207: aload #4
	//   209: invokeinterface size : ()I
	//   214: istore #6
	//   216: iconst_0
	//   217: istore #7
	//   219: iload #7
	//   221: iload #6
	//   223: if_icmpge -> 345
	//   226: aload_2
	//   227: astore_3
	//   228: aload #4
	//   230: iload #7
	//   232: invokeinterface get : (I)Ljava/lang/Object;
	//   237: checkcast android/net/wifi/ScanResult
	//   240: astore_1
	//   241: aload_2
	//   242: astore_3
	//   243: aload_1
	//   244: getfield BSSID : Ljava/lang/String;
	//   247: invokevirtual toUpperCase : ()Ljava/lang/String;
	//   250: invokevirtual toCharArray : ()[C
	//   253: astore #8
	//   255: iconst_0
	//   256: istore #9
	//   258: aload_2
	//   259: astore_3
	//   260: iload #9
	//   262: aload #8
	//   264: arraylength
	//   265: if_icmpge -> 298
	//   268: aload #8
	//   270: iload #9
	//   272: caload
	//   273: istore #10
	//   275: iload #10
	//   277: bipush #58
	//   279: if_icmpeq -> 292
	//   282: aload_2
	//   283: astore_3
	//   284: aload #5
	//   286: iload #10
	//   288: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   291: pop
	//   292: iinc #9, 1
	//   295: goto -> 258
	//   298: aload_2
	//   299: astore_3
	//   300: aload #5
	//   302: bipush #58
	//   304: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   307: pop
	//   308: aload_2
	//   309: astore_3
	//   310: aload #5
	//   312: aload_1
	//   313: getfield level : I
	//   316: invokevirtual append : (I)Ljava/lang/StringBuilder;
	//   319: pop
	//   320: iload #7
	//   322: iload #6
	//   324: iconst_1
	//   325: isub
	//   326: if_icmpge -> 339
	//   329: aload_2
	//   330: astore_3
	//   331: aload #5
	//   333: bipush #44
	//   335: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   338: pop
	//   339: iinc #7, 1
	//   342: goto -> 219
	//   345: aload_2
	//   346: astore_3
	//   347: aload_2
	//   348: aload #5
	//   350: invokevirtual toString : ()Ljava/lang/String;
	//   353: putfield a : Ljava/lang/String;
	//   356: aload_2
	//   357: astore_3
	//   358: invokestatic currentTimeMillis : ()J
	//   361: lstore #11
	//   363: aload_2
	//   364: astore_3
	//   365: getstatic ai.a : J
	//   368: lload #11
	//   370: lcmp
	//   371: ifle -> 400
	//   374: aload_2
	//   375: astore_3
	//   376: lload #11
	//   378: putstatic ai.a : J
	//   381: goto -> 24
	//   384: astore_2
	//   385: aload_3
	//   386: astore_2
	//   387: goto -> 24
	//   390: aload_2
	//   391: astore_3
	//   392: aload_2
	//   393: aconst_null
	//   394: putfield a : Ljava/lang/String;
	//   397: goto -> 356
	//   400: aload_2
	//   401: astore_3
	//   402: getstatic ai.a : J
	//   405: lstore #13
	//   407: lload #11
	//   409: lload #13
	//   411: lsub
	//   412: ldc2_w 30000
	//   415: lcmp
	//   416: ifle -> 448
	//   419: lload #11
	//   421: putstatic ai.a : J
	//   424: aload_0
	//   425: getfield c : Landroid/net/wifi/WifiManager;
	//   428: invokevirtual startScan : ()Z
	//   431: pop
	//   432: goto -> 24
	//   435: astore_3
	//   436: aload_2
	//   437: astore_3
	//   438: ldc2_w 300
	//   441: invokestatic sleep : (J)V
	//   444: goto -> 24
	//   447: astore_3
	//   448: aload_2
	//   449: astore_1
	//   450: aload_1
	//   451: astore_2
	//   452: goto -> 24
	//   455: astore_3
	//   456: goto -> 17
	//   459: astore_2
	//   460: aload_3
	//   461: astore_2
	//   462: goto -> 24
	//   465: goto -> 171
	//   468: aconst_null
	//   469: astore_2
	//   470: goto -> 117
	// Exception table:
	//   from	to	target	type
	//   11	17	455	java/lang/Exception
	//   28	35	384	java/lang/Throwable
	//   37	44	384	java/lang/Throwable
	//   46	50	384	java/lang/Throwable
	//   52	56	384	java/lang/Throwable
	//   58	66	459	java/lang/Throwable
	//   68	76	459	java/lang/Throwable
	//   78	86	459	java/lang/Throwable
	//   88	96	459	java/lang/Throwable
	//   98	107	459	java/lang/Throwable
	//   109	117	459	java/lang/Throwable
	//   121	128	459	java/lang/Throwable
	//   132	142	459	java/lang/Throwable
	//   144	153	459	java/lang/Throwable
	//   159	163	459	java/lang/Throwable
	//   165	169	459	java/lang/Throwable
	//   178	188	384	java/lang/Throwable
	//   190	195	384	java/lang/Throwable
	//   197	205	384	java/lang/Throwable
	//   207	216	384	java/lang/Throwable
	//   228	241	384	java/lang/Throwable
	//   243	255	384	java/lang/Throwable
	//   260	268	384	java/lang/Throwable
	//   284	292	384	java/lang/Throwable
	//   300	308	384	java/lang/Throwable
	//   310	320	384	java/lang/Throwable
	//   331	339	384	java/lang/Throwable
	//   347	356	384	java/lang/Throwable
	//   358	363	384	java/lang/Throwable
	//   365	374	384	java/lang/Throwable
	//   376	381	384	java/lang/Throwable
	//   392	397	384	java/lang/Throwable
	//   402	407	384	java/lang/Throwable
	//   419	432	435	java/lang/Throwable
	//   438	444	447	java/lang/Exception
	//   438	444	384	java/lang/Throwable
  }

  public void a(Context paramContext)
  {
	this.l = paramContext;
	(new Thread(this)).Start();
  }

  public void onCellLocationChanged(CellLocation paramCellLocation)
  {
	if (paramCellLocation != null && paramCellLocation is GsmCellLocation)
	{
	  GsmCellLocation gsmCellLocation = (GsmCellLocation)paramCellLocation;
	  this.f = gsmCellLocation.getLac();
	  this.g = gsmCellLocation.getCid();
	}
  }

  public void onSignalStrengthChanged(int paramInt)
  {
	this.e = true;
	this.d = paramInt;
  }

  public void run()
  {
	try
	{
	  this.b = (TelephonyManager)this.l.getSystemService("phone");
	  this.b.listen(this, 18);
	  string str = this.b.getNetworkOperator();
	  if (!string.ReferenceEquals(str, null) && str.Length > 3)
	  {
		this.h = str.Substring(0, 3);
		this.i = str.Substring(3);
	  }
	  else
	  {
		this.i = null;
		this.h = null;
		this.b.listen(this, 0);
	  }
	  if (this.k)
	  {
		this.c = (WifiManager)this.l.getSystemService("wifi");
	  }
	  this.j = true;
	  return;
	}
	finally
	{
	  this.l = null;
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ai.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */