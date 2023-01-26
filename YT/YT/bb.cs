using System;
using System.Collections;
using System.Collections.Generic;

using Context = android.content.Context;
using WifiManager = android.net.wifi.WifiManager;
using NeighboringCellInfo = android.telephony.NeighboringCellInfo;
using PhoneStateListener = android.telephony.PhoneStateListener;
using TelephonyManager = android.telephony.TelephonyManager;

public class bb : PhoneStateListener
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static System.Collections.IDictionary a_Conflict;

  private static readonly Type[] n = new Type[0];

  private static readonly object[] o = new object[0];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private TelephonyManager b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private WifiManager c_Conflict;

  private System.Collections.IList d;

  private long e;

  private string f;

  private string g;

  private int h;

  private string i;

  private string j;

  private string k;

  private string l;

  private long m;

  static bb()
  {
	Dictionary<object, object> hashMap = new Dictionary<object, object>();
	a_Conflict = hashMap;
	hashMap[Convert.ToInt32(1)] = "GPRS";
	a_Conflict[Convert.ToInt32(2)] = "EDGE";
	a_Conflict[Convert.ToInt32(3)] = "UMTS";
	a_Conflict[Convert.ToInt32(8)] = "HSDPA";
	a_Conflict[Convert.ToInt32(9)] = "HSUPA";
	a_Conflict[Convert.ToInt32(10)] = "HSPA";
	a_Conflict[Convert.ToInt32(4)] = "CDMA";
	a_Conflict[Convert.ToInt32(5)] = "EVDO_0";
	a_Conflict[Convert.ToInt32(6)] = "EVDO_A";
	a_Conflict[Convert.ToInt32(7)] = "1xRTT";
	a_Conflict[Convert.ToInt32(11)] = "IDEN";
	a_Conflict[Convert.ToInt32(0)] = "UNKNOWN";
  }

  public bb(Context paramContext)
  {
	this.b_Conflict = (TelephonyManager)paramContext.getSystemService("phone");
	this.b_Conflict.listen(this, 64);
	string str = this.b_Conflict.getNetworkOperator();
	if (!string.ReferenceEquals(str, null) && str.Length > 3)
	{
	  this.f = str.Substring(0, 3);
	  this.g = str.Substring(3);
	}
	else
	{
	  this.g = null;
	  this.f = null;
	  this.b_Conflict.listen(this, 0);
	}
	this.c_Conflict = (WifiManager)paramContext.getSystemService("wifi");
	this.d = new ArrayList();
	this.e = 0L;
	this.m = 0L;
	this.h = this.b_Conflict.getNetworkType();
  }

  private static string a(int paramInt)
  {
	switch (paramInt)
	{
	  default:
		return "UNKNOWN";
	  case -1:
		return "NONE";
	  case 1:
	  case 2:
	  case 3:
	  case 8:
	  case 9:
	  case 10:
		return "GSM";
	  case 4:
	  case 5:
	  case 6:
	  case 7:
		return "CDMA";
	  case 11:
		break;
	}
	return "IDEN";
  }

  private void a(int paramInt1, int paramInt2)
  {
	this.h = paramInt2;
	switch (paramInt1)
	{
	  default:
		return;
	  case 0:
		a("disconnected", DateTimeHelper.CurrentUnixTimeMillis());
		  goto case 2;
	  case 2:
		break;
	}
	a("connected", DateTimeHelper.CurrentUnixTimeMillis());
  }

  private void a(bc parambc)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield i : Ljava/lang/String;
	//   6: ifnull -> 57
	//   9: aload_0
	//   10: getfield i : Ljava/lang/String;
	//   13: invokevirtual length : ()I
	//   16: ifle -> 57
	//   19: invokestatic currentTimeMillis : ()J
	//   22: aload_0
	//   23: getfield m : J
	//   26: lsub
	//   27: ldc2_w 2000
	//   30: lcmp
	//   31: ifge -> 57
	//   34: aload_1
	//   35: aload_0
	//   36: getfield i : Ljava/lang/String;
	//   39: aload_0
	//   40: getfield j : Ljava/lang/String;
	//   43: aload_0
	//   44: getfield k : Ljava/lang/String;
	//   47: aload_0
	//   48: getfield l : Ljava/lang/String;
	//   51: invokevirtual a : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V
	//   54: aload_0
	//   55: monitorexit
	//   56: return
	//   57: invokestatic currentTimeMillis : ()J
	//   60: aload_0
	//   61: getfield m : J
	//   64: lsub
	//   65: ldc2_w 2000
	//   68: lcmp
	//   69: ifle -> 54
	//   72: aload_0
	//   73: aconst_null
	//   74: putfield l : Ljava/lang/String;
	//   77: aload_0
	//   78: aconst_null
	//   79: putfield k : Ljava/lang/String;
	//   82: aload_0
	//   83: aconst_null
	//   84: putfield j : Ljava/lang/String;
	//   87: aload_0
	//   88: aconst_null
	//   89: putfield i : Ljava/lang/String;
	//   92: goto -> 54
	//   95: astore_1
	//   96: aload_0
	//   97: monitorexit
	//   98: aload_1
	//   99: athrow
	// Exception table:
	//   from	to	target	type
	//   2	54	95	finally
	//   57	92	95	finally
  }

  private void b(bc parambc)
  {
	TelephonyManager telephonyManager = this.b_Conflict;
	if (telephonyManager != null)
	{
	  parambc.a((string)a_Conflict[Convert.ToInt32(this.h)], a(this.h));
	  IEnumerator<NeighboringCellInfo> iterator = telephonyManager.getNeighboringCellInfo().GetEnumerator();
	  while (true)
	  {
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
		if (iterator.hasNext())
		{
		  int j;
		  sbyte b;
		  bool @bool;
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
		  NeighboringCellInfo neighboringCellInfo = iterator.next();
		  int i = neighboringCellInfo.getCid();
		  try
		  {
			System.Reflection.MethodInfo method = typeof(NeighboringCellInfo).GetMethod("getLac", n);
			if (method != null)
			{
			  j = ((int?)method.invoke(neighboringCellInfo, o)).Value;
			}
			else
			{
			  j = -1;
			}
			b = j;
		  }
		  catch (Exception)
		  {
			b = -1;
		  }
		  try
		  {
			System.Reflection.MethodInfo method = typeof(NeighboringCellInfo).GetMethod("getNetworkType", n);
			if (method != null)
			{
			  @bool = ((int?)method.invoke(neighboringCellInfo, o)).Value;
			}
			else
			{
			  @bool = false;
			}
		  }
		  catch (Exception)
		  {
			@bool = false;
		  }
		  int k = neighboringCellInfo.getRssi();
		  if (i == -1)
		  {
			try
			{
			  System.Reflection.MethodInfo method = typeof(NeighboringCellInfo).GetMethod("getPsc", n);
			  if (method != null)
			  {
				j = ((int?)method.invoke(neighboringCellInfo, o)).Value;
			  }
			  else
			  {
				j = -1;
			  }
			}
			catch (Exception)
			{
			  j = -1;
			}
		  }
		  else
		  {
			j = i;
		  }
		  if (j != -1)
		  {
			string str2;
			string str3;
			string str4;
			if (b != -1)
			{
			  str2 = b.ToString();
			}
			else
			{
			  str2 = "";
			}
			if (!string.ReferenceEquals(this.g, null))
			{
			  str3 = this.g.ToString();
			}
			else
			{
			  str3 = "";
			}
			if (!string.ReferenceEquals(this.f, null))
			{
			  str4 = this.f.ToString();
			}
			else
			{
			  str4 = "";
			}
			string str1 = "";
			if (k != 99)
			{
			  if ("GSM".Equals(a(@bool)))
			  {
				str1 = ((k << 1) - 113).ToString();
			  }
			  else
			  {
				str1 = k.ToString();
			  }
			}
			parambc.a(j.ToString(), str2, str3, str4, str1, "");
		  }
		  continue;
		}
		return;
	  }
	}
  }

  public virtual void a()
  {
	this.b_Conflict.listen(this, 0);
  }

  public virtual void a(string paramString, long paramLong)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: new bc
	//   5: astore #4
	//   7: aload #4
	//   9: aload_1
	//   10: lload_2
	//   11: invokespecial <init> : (Ljava/lang/String;J)V
	//   14: aload_0
	//   15: aload #4
	//   17: invokespecial a : (Lbc;)V
	//   20: aload_0
	//   21: getfield c : Landroid/net/wifi/WifiManager;
	//   24: ifnull -> 192
	//   27: aload_0
	//   28: getfield c : Landroid/net/wifi/WifiManager;
	//   31: invokevirtual isWifiEnabled : ()Z
	//   34: ifeq -> 192
	//   37: aload_0
	//   38: getfield c : Landroid/net/wifi/WifiManager;
	//   41: invokevirtual getScanResults : ()Ljava/util/List;
	//   44: astore_1
	//   45: aload_1
	//   46: ifnull -> 192
	//   49: aload_1
	//   50: invokeinterface size : ()I
	//   55: ifle -> 192
	//   58: aload_1
	//   59: invokeinterface size : ()I
	//   64: istore #5
	//   66: iconst_0
	//   67: istore #6
	//   69: iload #6
	//   71: iload #5
	//   73: if_icmpge -> 192
	//   76: aload_1
	//   77: iload #6
	//   79: invokeinterface get : (I)Ljava/lang/Object;
	//   84: checkcast android/net/wifi/ScanResult
	//   87: astore #7
	//   89: aload #7
	//   91: getfield BSSID : Ljava/lang/String;
	//   94: invokevirtual toUpperCase : ()Ljava/lang/String;
	//   97: invokevirtual toCharArray : ()[C
	//   100: astore #8
	//   102: new java/lang/StringBuilder
	//   105: astore #9
	//   107: aload #9
	//   109: bipush #12
	//   111: invokespecial <init> : (I)V
	//   114: iconst_0
	//   115: istore #10
	//   117: iload #10
	//   119: aload #8
	//   121: arraylength
	//   122: if_icmpge -> 153
	//   125: aload #8
	//   127: iload #10
	//   129: caload
	//   130: istore #11
	//   132: iload #11
	//   134: bipush #58
	//   136: if_icmpeq -> 147
	//   139: aload #9
	//   141: iload #11
	//   143: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   146: pop
	//   147: iinc #10, 1
	//   150: goto -> 117
	//   153: aload #4
	//   155: aload #9
	//   157: invokevirtual toString : ()Ljava/lang/String;
	//   160: aload #7
	//   162: getfield SSID : Ljava/lang/String;
	//   165: invokevirtual getBytes : ()[B
	//   168: invokestatic a : ([B)Ljava/lang/String;
	//   171: ldc ''
	//   173: aload #7
	//   175: getfield level : I
	//   178: invokestatic valueOf : (I)Ljava/lang/String;
	//   181: ldc ''
	//   183: invokevirtual a : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V
	//   186: iinc #6, 1
	//   189: goto -> 69
	//   192: aload_0
	//   193: aload #4
	//   195: invokespecial b : (Lbc;)V
	//   198: aload_0
	//   199: getfield d : Ljava/util/List;
	//   202: aload #4
	//   204: invokeinterface add : (Ljava/lang/Object;)Z
	//   209: pop
	//   210: aload_0
	//   211: getfield e : J
	//   214: lload_2
	//   215: lcmp
	//   216: ifle -> 227
	//   219: aload_0
	//   220: lload_2
	//   221: putfield e : J
	//   224: aload_0
	//   225: monitorexit
	//   226: return
	//   227: aload_0
	//   228: getfield e : J
	//   231: lstore #12
	//   233: lload_2
	//   234: lload #12
	//   236: lsub
	//   237: ldc2_w 30000
	//   240: lcmp
	//   241: ifle -> 224
	//   244: aload_0
	//   245: lload_2
	//   246: putfield e : J
	//   249: aload_0
	//   250: getfield c : Landroid/net/wifi/WifiManager;
	//   253: invokevirtual startScan : ()Z
	//   256: pop
	//   257: goto -> 224
	//   260: astore_1
	//   261: ldc2_w 300
	//   264: invokestatic sleep : (J)V
	//   267: goto -> 224
	//   270: astore_1
	//   271: goto -> 224
	//   274: astore_1
	//   275: aload_0
	//   276: monitorexit
	//   277: aload_1
	//   278: athrow
	//   279: astore_1
	//   280: goto -> 224
	// Exception table:
	//   from	to	target	type
	//   2	45	279	java/lang/Throwable
	//   2	45	274	finally
	//   49	66	279	java/lang/Throwable
	//   49	66	274	finally
	//   76	114	279	java/lang/Throwable
	//   76	114	274	finally
	//   117	125	279	java/lang/Throwable
	//   117	125	274	finally
	//   139	147	279	java/lang/Throwable
	//   139	147	274	finally
	//   153	186	279	java/lang/Throwable
	//   153	186	274	finally
	//   192	224	279	java/lang/Throwable
	//   192	224	274	finally
	//   227	233	279	java/lang/Throwable
	//   227	233	274	finally
	//   244	257	260	java/lang/Throwable
	//   244	257	274	finally
	//   261	267	270	java/lang/Exception
	//   261	267	279	java/lang/Throwable
	//   261	267	274	finally
  }

  public virtual void a(string paramString1, string paramString2, string paramString3, string paramString4, long paramLong)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: aload_1
	//   4: putfield i : Ljava/lang/String;
	//   7: aload_0
	//   8: aload_2
	//   9: putfield j : Ljava/lang/String;
	//   12: aload_0
	//   13: aload_3
	//   14: putfield k : Ljava/lang/String;
	//   17: aload_0
	//   18: aload #4
	//   20: putfield l : Ljava/lang/String;
	//   23: aload_0
	//   24: lload #5
	//   26: putfield m : J
	//   29: aload_0
	//   30: monitorexit
	//   31: return
	//   32: astore_1
	//   33: aload_0
	//   34: monitorexit
	//   35: aload_1
	//   36: athrow
	// Exception table:
	//   from	to	target	type
	//   2	29	32	finally
  }

  public virtual System.Collections.IList b()
  {
	return this.d;
  }

  public virtual void c()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield d : Ljava/util/List;
	//   6: invokeinterface clear : ()V
	//   11: aload_0
	//   12: monitorexit
	//   13: return
	//   14: astore_1
	//   15: aload_0
	//   16: monitorexit
	//   17: aload_1
	//   18: athrow
	// Exception table:
	//   from	to	target	type
	//   2	11	14	finally
  }

  public virtual void onDataConnectionStateChanged(int paramInt)
  {
	if (b.b_Conflict < 7)
	{
	  a(paramInt, this.b_Conflict.getNetworkType());
	}
  }

  public virtual void onDataConnectionStateChanged(int paramInt1, int paramInt2)
  {
	if (b.b_Conflict >= 7)
	{
	  a(paramInt1, paramInt2);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */