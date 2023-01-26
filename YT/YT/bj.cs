using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

using MapController = ru.yandex.yandexmapkit.MapController;

public sealed class bj : ThreadStart
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal static readonly string[] a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal static readonly string[] b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly sbyte[] c_Conflict = "1".getBytes();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static volatile ArrayList d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly MapController e_Conflict;

  private readonly ArrayList f;

  private Thread g;

  private volatile ArrayList h;

  private bool i;

  private int j;

  private string k;

  private int l;

  private int m;

  static bj()
  {
	a_Conflict = new string[] {"uuid", "protocol_ver", "packetid", "tiles", "gzip", "api_key"};
	b_Conflict = new string[] {"text/plain", "text/plain", "text/plain", "application/gzip", "text/plain", "text/plain"};
  }

  public bj(MapController paramMapController, string paramString)
  {
	this.e_Conflict = paramMapController;
	d_Conflict = new ArrayList(40);
	this.f = new ArrayList(50);
	this.j = 0;
	this.k = paramString;
  }

  private am a(List<am> paramArrayList)
  {
	// Byte code:
	//   0: ldc bj
	//   2: monitorenter
	//   3: getstatic bj.d : Ljava/util/ArrayList;
	//   6: invokevirtual isEmpty : ()Z
	//   9: ifne -> 237
	//   12: aload_0
	//   13: getstatic bj.d : Ljava/util/ArrayList;
	//   16: iconst_1
	//   17: invokespecial a : (Ljava/util/ArrayList;Z)V
	//   20: aload_0
	//   21: aload_1
	//   22: iconst_0
	//   23: invokespecial a : (Ljava/util/ArrayList;Z)V
	//   26: getstatic bj.d : Ljava/util/ArrayList;
	//   29: invokevirtual size : ()I
	//   32: istore_2
	//   33: ldc2_w 9223372036854775807
	//   36: lstore_3
	//   37: iconst_0
	//   38: istore #5
	//   40: aconst_null
	//   41: astore #6
	//   43: iload #5
	//   45: iload_2
	//   46: if_icmpge -> 220
	//   49: getstatic bj.d : Ljava/util/ArrayList;
	//   52: iload #5
	//   54: invokevirtual get : (I)Ljava/lang/Object;
	//   57: checkcast am
	//   60: astore #7
	//   62: aload_1
	//   63: invokevirtual size : ()I
	//   66: iconst_1
	//   67: isub
	//   68: istore #8
	//   70: iload #8
	//   72: iflt -> 255
	//   75: aload_1
	//   76: iload #8
	//   78: invokevirtual get : (I)Ljava/lang/Object;
	//   81: aload #7
	//   83: if_acmpne -> 214
	//   86: iconst_1
	//   87: istore #8
	//   89: iload #8
	//   91: ifne -> 252
	//   94: bipush #23
	//   96: aload #7
	//   98: getfield zoom : I
	//   101: isub
	//   102: istore #9
	//   104: bipush #64
	//   106: iload #9
	//   108: ishl
	//   109: istore #10
	//   111: aload #7
	//   113: getfield i : I
	//   116: istore #8
	//   118: aload #7
	//   120: getfield j : I
	//   123: istore #11
	//   125: iload #8
	//   127: iload #9
	//   129: bipush #7
	//   131: iadd
	//   132: ishl
	//   133: iload #10
	//   135: iadd
	//   136: aload_0
	//   137: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   140: invokevirtual d : ()Lru/yandex/yandexmapkit/MapController$Map;
	//   143: invokevirtual m : ()I
	//   146: isub
	//   147: bipush #12
	//   149: ishr
	//   150: i2l
	//   151: lstore #12
	//   153: iload #11
	//   155: iload #9
	//   157: bipush #7
	//   159: iadd
	//   160: ishl
	//   161: iload #10
	//   163: iadd
	//   164: aload_0
	//   165: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   168: invokevirtual d : ()Lru/yandex/yandexmapkit/MapController$Map;
	//   171: invokevirtual n : ()I
	//   174: isub
	//   175: bipush #12
	//   177: ishr
	//   178: i2l
	//   179: lstore #14
	//   181: lload #14
	//   183: lload #14
	//   185: lmul
	//   186: lload #12
	//   188: lload #12
	//   190: lmul
	//   191: ladd
	//   192: lstore #14
	//   194: lload #14
	//   196: lload_3
	//   197: lcmp
	//   198: ifge -> 252
	//   201: lload #14
	//   203: lstore_3
	//   204: aload #7
	//   206: astore #6
	//   208: iinc #5, 1
	//   211: goto -> 43
	//   214: iinc #8, -1
	//   217: goto -> 70
	//   220: aload #6
	//   222: ifnull -> 237
	//   225: aload #6
	//   227: iconst_0
	//   228: putfield r : Z
	//   231: ldc bj
	//   233: monitorexit
	//   234: aload #6
	//   236: areturn
	//   237: ldc bj
	//   239: monitorexit
	//   240: aconst_null
	//   241: astore #6
	//   243: goto -> 234
	//   246: astore_1
	//   247: ldc bj
	//   249: monitorexit
	//   250: aload_1
	//   251: athrow
	//   252: goto -> 208
	//   255: iconst_0
	//   256: istore #8
	//   258: goto -> 89
	// Exception table:
	//   from	to	target	type
	//   3	33	246	finally
	//   49	70	246	finally
	//   75	86	246	finally
	//   94	104	246	finally
	//   111	181	246	finally
	//   225	234	246	finally
  }

  private void a(int paramInt)
  {
	if (d_Conflict.Count == 0)
	{
	  this.m = 0;
	  this.l = 0;
	}
	switch (paramInt)
	{
	  default:
		return;
	  case 0:
		this.m++;
		  goto case 1;
	  case 1:
		this.l += 100;
		  goto case 2;
	  case 2:
		break;
	}
	this.m--;
  }

  private void a(List<am> paramArrayList, int paramInt1, sbyte[] paramArrayOfbyte, int paramInt2, int paramInt3)
  {
	// Byte code:
	//   0: aload_1
	//   1: iload_2
	//   2: invokevirtual get : (I)Ljava/lang/Object;
	//   5: checkcast am
	//   8: astore #6
	//   10: aload #6
	//   12: getfield k : B
	//   15: ifne -> 19
	//   18: return
	//   19: aload #6
	//   21: getfield r : Z
	//   24: ifeq -> 115
	//   27: aload #6
	//   29: aload #6
	//   31: getfield q : I
	//   34: iconst_1
	//   35: iadd
	//   36: putfield q : I
	//   39: aload #6
	//   41: getfield q : I
	//   44: iconst_4
	//   45: if_icmple -> 18
	//   48: invokestatic a : ()Lap;
	//   51: astore_1
	//   52: aload #6
	//   54: iconst_0
	//   55: i2b
	//   56: putfield h : B
	//   59: aload #6
	//   61: aconst_null
	//   62: invokevirtual a : ([B)V
	//   65: aload_1
	//   66: ifnull -> 105
	//   69: aload_1
	//   70: aload #6
	//   72: iconst_0
	//   73: invokevirtual a : (Lam;Z)V
	//   76: ldc bj
	//   78: monitorenter
	//   79: getstatic bj.d : Ljava/util/ArrayList;
	//   82: aload #6
	//   84: invokevirtual remove : (Ljava/lang/Object;)Z
	//   87: pop
	//   88: aload_0
	//   89: iconst_1
	//   90: invokespecial a : (I)V
	//   93: ldc bj
	//   95: monitorexit
	//   96: goto -> 18
	//   99: astore_1
	//   100: ldc bj
	//   102: monitorexit
	//   103: aload_1
	//   104: athrow
	//   105: aload #6
	//   107: iconst_0
	//   108: i2b
	//   109: putfield k : B
	//   112: goto -> 76
	//   115: aload #6
	//   117: getfield s : Z
	//   120: ifne -> 198
	//   123: aload_3
	//   124: astore_1
	//   125: aload_3
	//   126: getstatic aq.c : [B
	//   129: if_acmpeq -> 176
	//   132: iconst_0
	//   133: iload #5
	//   135: invokestatic max : (II)I
	//   138: newarray byte
	//   140: astore #7
	//   142: aload_3
	//   143: ifnonnull -> 242
	//   146: iconst_0
	//   147: istore_2
	//   148: aload_3
	//   149: astore_1
	//   150: iload #5
	//   152: iload_2
	//   153: if_icmpeq -> 176
	//   156: aload_3
	//   157: astore_1
	//   158: aload_3
	//   159: ifnull -> 176
	//   162: aload_3
	//   163: iload #4
	//   165: aload #7
	//   167: iconst_0
	//   168: iload #5
	//   170: invokestatic arraycopy : (Ljava/lang/Object;ILjava/lang/Object;II)V
	//   173: aload #7
	//   175: astore_1
	//   176: aload #6
	//   178: getfield d : Z
	//   181: ifeq -> 248
	//   184: aload #6
	//   186: bipush #16
	//   188: i2b
	//   189: putfield h : B
	//   192: aload #6
	//   194: aload_1
	//   195: invokevirtual a : ([B)V
	//   198: invokestatic a : ()Lap;
	//   201: astore_1
	//   202: aload_1
	//   203: ifnull -> 258
	//   206: aload_1
	//   207: aload #6
	//   209: iconst_0
	//   210: invokevirtual a : (Lam;Z)V
	//   213: ldc bj
	//   215: monitorenter
	//   216: getstatic bj.d : Ljava/util/ArrayList;
	//   219: aload #6
	//   221: invokevirtual remove : (Ljava/lang/Object;)Z
	//   224: pop
	//   225: aload_0
	//   226: iconst_1
	//   227: invokespecial a : (I)V
	//   230: ldc bj
	//   232: monitorexit
	//   233: goto -> 18
	//   236: astore_1
	//   237: ldc bj
	//   239: monitorexit
	//   240: aload_1
	//   241: athrow
	//   242: aload_3
	//   243: arraylength
	//   244: istore_2
	//   245: goto -> 148
	//   248: aload #6
	//   250: iconst_1
	//   251: i2b
	//   252: putfield h : B
	//   255: goto -> 192
	//   258: aload #6
	//   260: iconst_3
	//   261: i2b
	//   262: putfield k : B
	//   265: goto -> 213
	// Exception table:
	//   from	to	target	type
	//   79	96	99	finally
	//   216	233	236	finally
  }

  private void a(ArrayList paramArrayList, bool paramBoolean)
  {
	// Byte code:
	//   0: aload_1
	//   1: invokevirtual size : ()I
	//   4: istore_3
	//   5: aload_0
	//   6: getfield f : Ljava/util/ArrayList;
	//   9: invokevirtual clear : ()V
	//   12: iconst_0
	//   13: istore #4
	//   15: iload #4
	//   17: iload_3
	//   18: if_icmpge -> 75
	//   21: aload_1
	//   22: iload #4
	//   24: invokevirtual get : (I)Ljava/lang/Object;
	//   27: checkcast am
	//   30: astore #5
	//   32: aload #5
	//   34: getfield x : Z
	//   37: ifne -> 69
	//   40: aload_0
	//   41: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   44: aload #5
	//   46: invokevirtual a : (Lam;)Z
	//   49: ifne -> 69
	//   52: aload_0
	//   53: getfield f : Ljava/util/ArrayList;
	//   56: aload #5
	//   58: invokevirtual add : (Ljava/lang/Object;)Z
	//   61: pop
	//   62: aload #5
	//   64: iconst_3
	//   65: i2b
	//   66: putfield k : B
	//   69: iinc #4, 1
	//   72: goto -> 15
	//   75: invokestatic a : ()Lap;
	//   78: astore #6
	//   80: aload_0
	//   81: getfield f : Ljava/util/ArrayList;
	//   84: invokevirtual size : ()I
	//   87: iconst_1
	//   88: isub
	//   89: istore_3
	//   90: iload_3
	//   91: iflt -> 208
	//   94: aload_0
	//   95: getfield f : Ljava/util/ArrayList;
	//   98: iload_3
	//   99: invokevirtual get : (I)Ljava/lang/Object;
	//   102: checkcast am
	//   105: astore #7
	//   107: aload_1
	//   108: aload #7
	//   110: invokevirtual remove : (Ljava/lang/Object;)Z
	//   113: pop
	//   114: aload #6
	//   116: ifnull -> 127
	//   119: aload #6
	//   121: aload #7
	//   123: iconst_0
	//   124: invokevirtual a : (Lam;Z)V
	//   127: iload_2
	//   128: ifeq -> 155
	//   131: aload_0
	//   132: getfield h : Ljava/util/ArrayList;
	//   135: astore #5
	//   137: aload #5
	//   139: ifnonnull -> 161
	//   142: iconst_0
	//   143: istore #4
	//   145: iload #4
	//   147: ifne -> 155
	//   150: aload_0
	//   151: iconst_2
	//   152: invokespecial a : (I)V
	//   155: iinc #3, -1
	//   158: goto -> 90
	//   161: aload #5
	//   163: invokevirtual size : ()I
	//   166: iconst_1
	//   167: isub
	//   168: istore #4
	//   170: iload #4
	//   172: iflt -> 202
	//   175: aload #7
	//   177: aload #5
	//   179: iload #4
	//   181: invokevirtual get : (I)Ljava/lang/Object;
	//   184: checkcast am
	//   187: if_acmpne -> 196
	//   190: iconst_1
	//   191: istore #4
	//   193: goto -> 145
	//   196: iinc #4, -1
	//   199: goto -> 170
	//   202: iconst_0
	//   203: istore #4
	//   205: goto -> 145
	//   208: aload_0
	//   209: getfield f : Ljava/util/ArrayList;
	//   212: invokevirtual clear : ()V
	//   215: return
  }

  private void b(ArrayList paramArrayList)
  {
	// Byte code:
	//   0: aload_1
	//   1: invokevirtual size : ()I
	//   4: istore_2
	//   5: aload_1
	//   6: invokestatic c : (Ljava/util/ArrayList;)[B
	//   9: astore_3
	//   10: aload_3
	//   11: invokevirtual clone : ()Ljava/lang/Object;
	//   14: checkcast [B
	//   17: invokestatic getUUIDBytes : ()[B
	//   20: invokestatic a : ([B[B)J
	//   23: invokestatic toString : (J)Ljava/lang/String;
	//   26: astore #4
	//   28: new java/lang/StringBuffer
	//   31: dup
	//   32: invokespecial <init> : ()V
	//   35: astore #5
	//   37: aload #5
	//   39: invokestatic c : ()Ljava/lang/String;
	//   42: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuffer;
	//   45: pop
	//   46: aload #5
	//   48: ldc '/printer?uuid='
	//   50: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuffer;
	//   53: invokestatic getUUID : ()Ljava/lang/String;
	//   56: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuffer;
	//   59: pop
	//   60: aload #5
	//   62: ldc '&protocol_ver='
	//   64: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuffer;
	//   67: ldc '1'
	//   69: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuffer;
	//   72: pop
	//   73: ldc ''
	//   75: astore #6
	//   77: aload_0
	//   78: getfield k : Ljava/lang/String;
	//   81: ifnull -> 105
	//   84: aload #5
	//   86: ldc '&api_key='
	//   88: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuffer;
	//   91: aload_0
	//   92: getfield k : Ljava/lang/String;
	//   95: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuffer;
	//   98: pop
	//   99: aload_0
	//   100: getfield k : Ljava/lang/String;
	//   103: astore #6
	//   105: getstatic bj.a : [Ljava/lang/String;
	//   108: getstatic bj.b : [Ljava/lang/String;
	//   111: bipush #6
	//   113: anewarray [B
	//   116: dup
	//   117: iconst_0
	//   118: invokestatic getUUID : ()Ljava/lang/String;
	//   121: invokevirtual getBytes : ()[B
	//   124: aastore
	//   125: dup
	//   126: iconst_1
	//   127: ldc '1'
	//   129: invokevirtual getBytes : ()[B
	//   132: aastore
	//   133: dup
	//   134: iconst_2
	//   135: aload #4
	//   137: invokevirtual getBytes : ()[B
	//   140: aastore
	//   141: dup
	//   142: iconst_3
	//   143: aload_3
	//   144: aastore
	//   145: dup
	//   146: iconst_4
	//   147: getstatic bj.c : [B
	//   150: aastore
	//   151: dup
	//   152: iconst_5
	//   153: aload #6
	//   155: invokevirtual getBytes : ()[B
	//   158: aastore
	//   159: invokestatic a : ([Ljava/lang/String;[Ljava/lang/String;[[B)[B
	//   162: astore #7
	//   164: iconst_0
	//   165: istore #8
	//   167: aconst_null
	//   168: astore #9
	//   170: aconst_null
	//   171: astore_3
	//   172: aconst_null
	//   173: astore #10
	//   175: aconst_null
	//   176: astore #6
	//   178: aload #6
	//   180: astore #11
	//   182: aload_3
	//   183: astore #4
	//   185: aload #10
	//   187: astore #12
	//   189: new java/net/URL
	//   192: astore #13
	//   194: aload #6
	//   196: astore #11
	//   198: aload_3
	//   199: astore #4
	//   201: aload #10
	//   203: astore #12
	//   205: aload #13
	//   207: aload #5
	//   209: invokevirtual toString : ()Ljava/lang/String;
	//   212: invokespecial <init> : (Ljava/lang/String;)V
	//   215: aload #6
	//   217: astore #11
	//   219: aload_3
	//   220: astore #4
	//   222: aload #10
	//   224: astore #12
	//   226: aload #13
	//   228: invokevirtual openConnection : ()Ljava/net/URLConnection;
	//   231: checkcast java/net/HttpURLConnection
	//   234: astore #6
	//   236: aload #6
	//   238: astore #11
	//   240: aload #6
	//   242: astore #4
	//   244: aload #6
	//   246: astore #12
	//   248: aload #6
	//   250: sipush #30000
	//   253: invokevirtual setConnectTimeout : (I)V
	//   256: aload #6
	//   258: astore #11
	//   260: aload #6
	//   262: astore #4
	//   264: aload #6
	//   266: astore #12
	//   268: aload #6
	//   270: sipush #30000
	//   273: invokevirtual setReadTimeout : (I)V
	//   276: aload #7
	//   278: ifnull -> 1587
	//   281: aload #6
	//   283: astore #11
	//   285: aload #6
	//   287: astore #4
	//   289: aload #6
	//   291: astore #12
	//   293: aload #6
	//   295: iconst_1
	//   296: invokevirtual setDoOutput : (Z)V
	//   299: aload #6
	//   301: astore #11
	//   303: aload #6
	//   305: astore #4
	//   307: aload #6
	//   309: astore #12
	//   311: aload #6
	//   313: ldc_w 'Content-Type'
	//   316: ldc_w 'multipart/form-data; boundary=edge_here'
	//   319: invokevirtual setRequestProperty : (Ljava/lang/String;Ljava/lang/String;)V
	//   322: aload #6
	//   324: astore #11
	//   326: aload #6
	//   328: astore #4
	//   330: aload #6
	//   332: astore #12
	//   334: new java/io/BufferedOutputStream
	//   337: astore_3
	//   338: aload #6
	//   340: astore #11
	//   342: aload #6
	//   344: astore #4
	//   346: aload #6
	//   348: astore #12
	//   350: aload_3
	//   351: aload #6
	//   353: invokevirtual getOutputStream : ()Ljava/io/OutputStream;
	//   356: aload #7
	//   358: arraylength
	//   359: invokespecial <init> : (Ljava/io/OutputStream;I)V
	//   362: aload_3
	//   363: aload #7
	//   365: invokevirtual write : ([B)V
	//   368: aload_3
	//   369: invokevirtual flush : ()V
	//   372: aload #6
	//   374: invokevirtual getResponseCode : ()I
	//   377: istore #14
	//   379: aconst_null
	//   380: astore #5
	//   382: iload #14
	//   384: sipush #200
	//   387: if_icmpeq -> 1581
	//   390: iload #14
	//   392: sipush #408
	//   395: if_icmpne -> 430
	//   398: iconst_1
	//   399: istore #15
	//   401: iconst_0
	//   402: istore #14
	//   404: iload #14
	//   406: iload_2
	//   407: if_icmpge -> 436
	//   410: aload_1
	//   411: iload #14
	//   413: invokevirtual get : (I)Ljava/lang/Object;
	//   416: checkcast am
	//   419: iload #15
	//   421: putfield r : Z
	//   424: iinc #14, 1
	//   427: goto -> 404
	//   430: iconst_0
	//   431: istore #15
	//   433: goto -> 401
	//   436: iload #15
	//   438: ifeq -> 657
	//   441: aconst_null
	//   442: astore #4
	//   444: iconst_1
	//   445: istore #16
	//   447: aload #4
	//   449: astore #5
	//   451: new java/io/BufferedInputStream
	//   454: dup
	//   455: aload #6
	//   457: invokevirtual getInputStream : ()Ljava/io/InputStream;
	//   460: sipush #16000
	//   463: invokespecial <init> : (Ljava/io/InputStream;I)V
	//   466: astore #12
	//   468: aload #6
	//   470: astore #10
	//   472: aload #12
	//   474: astore #9
	//   476: aload_3
	//   477: astore #11
	//   479: iload_2
	//   480: newarray int
	//   482: astore #13
	//   484: aload #6
	//   486: astore #10
	//   488: aload #12
	//   490: astore #9
	//   492: aload_3
	//   493: astore #11
	//   495: iload_2
	//   496: newarray short
	//   498: astore #17
	//   500: iload #16
	//   502: ifne -> 1575
	//   505: aload #6
	//   507: astore #10
	//   509: aload #12
	//   511: astore #9
	//   513: aload_3
	//   514: astore #11
	//   516: sipush #16384
	//   519: aload #6
	//   521: invokevirtual getContentLength : ()I
	//   524: invokestatic min : (II)I
	//   527: newarray byte
	//   529: astore #4
	//   531: aload #6
	//   533: astore #10
	//   535: aload #12
	//   537: astore #9
	//   539: aload_3
	//   540: astore #11
	//   542: aload #12
	//   544: aload #4
	//   546: iconst_0
	//   547: iload_2
	//   548: iconst_3
	//   549: ishl
	//   550: iconst_4
	//   551: iadd
	//   552: invokestatic a : (Ljava/io/InputStream;[BII)Z
	//   555: pop
	//   556: iconst_0
	//   557: istore #18
	//   559: iconst_0
	//   560: istore #14
	//   562: iload #14
	//   564: iload_2
	//   565: if_icmpge -> 665
	//   568: aload #6
	//   570: astore #10
	//   572: aload #12
	//   574: astore #9
	//   576: aload_3
	//   577: astore #11
	//   579: aload #17
	//   581: iload #14
	//   583: aload #4
	//   585: iload #14
	//   587: iconst_3
	//   588: ishl
	//   589: iconst_4
	//   590: iadd
	//   591: invokestatic b : ([BI)I
	//   594: i2s
	//   595: i2s
	//   596: sastore
	//   597: aload #6
	//   599: astore #10
	//   601: aload #12
	//   603: astore #9
	//   605: aload_3
	//   606: astore #11
	//   608: aload #13
	//   610: iload #14
	//   612: aload #4
	//   614: iload #14
	//   616: iconst_3
	//   617: ishl
	//   618: iconst_4
	//   619: iadd
	//   620: iconst_2
	//   621: iadd
	//   622: invokestatic b : ([BI)I
	//   625: iastore
	//   626: iload #18
	//   628: istore #19
	//   630: aload #13
	//   632: iload #14
	//   634: iaload
	//   635: iload #18
	//   637: if_icmple -> 647
	//   640: aload #13
	//   642: iload #14
	//   644: iaload
	//   645: istore #19
	//   647: iinc #14, 1
	//   650: iload #19
	//   652: istore #18
	//   654: goto -> 562
	//   657: getstatic aq.c : [B
	//   660: astore #4
	//   662: goto -> 444
	//   665: aload #6
	//   667: astore #10
	//   669: aload #12
	//   671: astore #9
	//   673: aload_3
	//   674: astore #11
	//   676: iload #18
	//   678: aload #4
	//   680: arraylength
	//   681: if_icmple -> 1572
	//   684: aload #6
	//   686: astore #10
	//   688: aload #12
	//   690: astore #9
	//   692: aload_3
	//   693: astore #11
	//   695: iload #18
	//   697: newarray byte
	//   699: astore #4
	//   701: iconst_0
	//   702: istore #19
	//   704: iload #8
	//   706: istore #18
	//   708: iload #19
	//   710: iload_2
	//   711: if_icmpge -> 1217
	//   714: aload #6
	//   716: astore #10
	//   718: aload #12
	//   720: astore #9
	//   722: aload_3
	//   723: astore #11
	//   725: aload_1
	//   726: iload #19
	//   728: invokevirtual get : (I)Ljava/lang/Object;
	//   731: checkcast am
	//   734: astore #7
	//   736: aload #6
	//   738: astore #10
	//   740: aload #12
	//   742: astore #9
	//   744: aload_3
	//   745: astore #11
	//   747: aload #7
	//   749: iconst_0
	//   750: putfield s : Z
	//   753: aload #6
	//   755: astore #10
	//   757: aload #12
	//   759: astore #9
	//   761: aload_3
	//   762: astore #11
	//   764: invokestatic a : ()Lap;
	//   767: astore #20
	//   769: aload #20
	//   771: ifnonnull -> 798
	//   774: aload_3
	//   775: ifnull -> 782
	//   778: aload_3
	//   779: invokevirtual close : ()V
	//   782: aload #12
	//   784: invokevirtual close : ()V
	//   787: aload #6
	//   789: ifnull -> 797
	//   792: aload #6
	//   794: invokevirtual disconnect : ()V
	//   797: return
	//   798: iload #16
	//   800: ifeq -> 878
	//   803: aload #5
	//   805: ifnonnull -> 859
	//   808: iconst_0
	//   809: istore #14
	//   811: aload #6
	//   813: astore #10
	//   815: aload #12
	//   817: astore #9
	//   819: aload_3
	//   820: astore #11
	//   822: aload_0
	//   823: aload_1
	//   824: iload #19
	//   826: aload #5
	//   828: iconst_0
	//   829: iload #14
	//   831: invokespecial a : (Ljava/util/ArrayList;I[BII)V
	//   834: iinc #18, 1
	//   837: aload #6
	//   839: astore #10
	//   841: aload #12
	//   843: astore #9
	//   845: aload_3
	//   846: astore #11
	//   848: aload_0
	//   849: iconst_0
	//   850: putfield j : I
	//   853: iinc #19, 1
	//   856: goto -> 708
	//   859: aload #6
	//   861: astore #10
	//   863: aload #12
	//   865: astore #9
	//   867: aload_3
	//   868: astore #11
	//   870: aload #5
	//   872: arraylength
	//   873: istore #14
	//   875: goto -> 811
	//   878: aload #6
	//   880: astore #10
	//   882: aload #12
	//   884: astore #9
	//   886: aload_3
	//   887: astore #11
	//   889: aload #12
	//   891: aload #4
	//   893: iconst_0
	//   894: aload #13
	//   896: iload #19
	//   898: iaload
	//   899: invokestatic a : (Ljava/io/InputStream;[BII)Z
	//   902: ifne -> 914
	//   905: aload #17
	//   907: iload #19
	//   909: sipush #408
	//   912: i2s
	//   913: sastore
	//   914: aload #17
	//   916: iload #19
	//   918: saload
	//   919: sipush #200
	//   922: if_icmpeq -> 972
	//   925: aload #17
	//   927: iload #19
	//   929: saload
	//   930: lookupswitch default -> 972, 304 -> 1165, 404 -> 1188, 408 -> 1142, 500 -> 1194
	//   972: iconst_0
	//   973: istore #14
	//   975: iload #14
	//   977: ifeq -> 1200
	//   980: aload #6
	//   982: astore #10
	//   984: aload #12
	//   986: astore #9
	//   988: aload_3
	//   989: astore #11
	//   991: getstatic aq.c : [B
	//   994: astore #7
	//   996: iload #14
	//   998: ifeq -> 1207
	//   1001: aload #6
	//   1003: astore #10
	//   1005: aload #12
	//   1007: astore #9
	//   1009: aload_3
	//   1010: astore #11
	//   1012: getstatic aq.c : [B
	//   1015: arraylength
	//   1016: istore #14
	//   1018: aload #6
	//   1020: astore #10
	//   1022: aload #12
	//   1024: astore #9
	//   1026: aload_3
	//   1027: astore #11
	//   1029: aload_0
	//   1030: aload_1
	//   1031: iload #19
	//   1033: aload #7
	//   1035: iconst_0
	//   1036: iload #14
	//   1038: invokespecial a : (Ljava/util/ArrayList;I[BII)V
	//   1041: goto -> 834
	//   1044: astore #4
	//   1046: aload_3
	//   1047: astore #4
	//   1049: aload #12
	//   1051: astore_3
	//   1052: ldc2_w 500
	//   1055: invokestatic sleep : (J)V
	//   1058: aload_0
	//   1059: getfield j : I
	//   1062: iconst_5
	//   1063: if_icmpgt -> 1076
	//   1066: aload_0
	//   1067: aload_0
	//   1068: getfield j : I
	//   1071: iconst_1
	//   1072: iadd
	//   1073: putfield j : I
	//   1076: aload #4
	//   1078: ifnull -> 1086
	//   1081: aload #4
	//   1083: invokevirtual close : ()V
	//   1086: aload_3
	//   1087: ifnull -> 1094
	//   1090: aload_3
	//   1091: invokevirtual close : ()V
	//   1094: aload #6
	//   1096: ifnull -> 1559
	//   1099: aload #6
	//   1101: invokevirtual disconnect : ()V
	//   1104: iload_2
	//   1105: istore #14
	//   1107: iload #14
	//   1109: iload_2
	//   1110: if_icmpge -> 797
	//   1113: aload_1
	//   1114: iload #14
	//   1116: invokevirtual get : (I)Ljava/lang/Object;
	//   1119: checkcast am
	//   1122: iconst_1
	//   1123: putfield r : Z
	//   1126: aload_0
	//   1127: aload_1
	//   1128: iload #14
	//   1130: aconst_null
	//   1131: iconst_0
	//   1132: iconst_0
	//   1133: invokespecial a : (Ljava/util/ArrayList;I[BII)V
	//   1136: iinc #14, 1
	//   1139: goto -> 1107
	//   1142: aload #6
	//   1144: astore #10
	//   1146: aload #12
	//   1148: astore #9
	//   1150: aload_3
	//   1151: astore #11
	//   1153: aload #7
	//   1155: iconst_1
	//   1156: putfield r : Z
	//   1159: iconst_0
	//   1160: istore #14
	//   1162: goto -> 975
	//   1165: aload #6
	//   1167: astore #10
	//   1169: aload #12
	//   1171: astore #9
	//   1173: aload_3
	//   1174: astore #11
	//   1176: aload #7
	//   1178: iconst_1
	//   1179: putfield s : Z
	//   1182: iconst_0
	//   1183: istore #14
	//   1185: goto -> 975
	//   1188: iconst_1
	//   1189: istore #14
	//   1191: goto -> 975
	//   1194: iconst_1
	//   1195: istore #14
	//   1197: goto -> 975
	//   1200: aload #4
	//   1202: astore #7
	//   1204: goto -> 996
	//   1207: aload #13
	//   1209: iload #19
	//   1211: iaload
	//   1212: istore #14
	//   1214: goto -> 1018
	//   1217: aload_3
	//   1218: ifnull -> 1225
	//   1221: aload_3
	//   1222: invokevirtual close : ()V
	//   1225: aload #12
	//   1227: invokevirtual close : ()V
	//   1230: aload #6
	//   1232: ifnull -> 1565
	//   1235: aload #6
	//   1237: invokevirtual disconnect : ()V
	//   1240: iload #18
	//   1242: istore #14
	//   1244: goto -> 1107
	//   1247: astore #6
	//   1249: aconst_null
	//   1250: astore #6
	//   1252: aconst_null
	//   1253: astore_3
	//   1254: aload #11
	//   1256: astore #4
	//   1258: aload #4
	//   1260: astore #10
	//   1262: aload #6
	//   1264: astore #9
	//   1266: aload_3
	//   1267: astore #11
	//   1269: invokestatic gc : ()V
	//   1272: aload #4
	//   1274: astore #10
	//   1276: aload #6
	//   1278: astore #9
	//   1280: aload_3
	//   1281: astore #11
	//   1283: ldc2_w 500
	//   1286: invokestatic sleep : (J)V
	//   1289: aload_3
	//   1290: ifnull -> 1297
	//   1293: aload_3
	//   1294: invokevirtual close : ()V
	//   1297: aload #6
	//   1299: ifnull -> 1307
	//   1302: aload #6
	//   1304: invokevirtual close : ()V
	//   1307: aload #4
	//   1309: ifnull -> 1559
	//   1312: aload #4
	//   1314: invokevirtual disconnect : ()V
	//   1317: iload_2
	//   1318: istore #14
	//   1320: goto -> 1107
	//   1323: astore_1
	//   1324: aconst_null
	//   1325: astore #6
	//   1327: aconst_null
	//   1328: astore_3
	//   1329: aload_3
	//   1330: ifnull -> 1337
	//   1333: aload_3
	//   1334: invokevirtual close : ()V
	//   1337: aload #6
	//   1339: ifnull -> 1347
	//   1342: aload #6
	//   1344: invokevirtual close : ()V
	//   1347: aload #4
	//   1349: ifnull -> 1357
	//   1352: aload #4
	//   1354: invokevirtual disconnect : ()V
	//   1357: aload_1
	//   1358: athrow
	//   1359: astore_1
	//   1360: goto -> 782
	//   1363: astore_1
	//   1364: goto -> 787
	//   1367: astore_3
	//   1368: goto -> 1225
	//   1371: astore_3
	//   1372: goto -> 1230
	//   1375: astore #11
	//   1377: goto -> 1058
	//   1380: astore #4
	//   1382: goto -> 1086
	//   1385: astore_3
	//   1386: goto -> 1094
	//   1389: astore #11
	//   1391: goto -> 1289
	//   1394: astore_3
	//   1395: goto -> 1297
	//   1398: astore #6
	//   1400: goto -> 1307
	//   1403: astore_3
	//   1404: goto -> 1337
	//   1407: astore #6
	//   1409: goto -> 1347
	//   1412: astore_1
	//   1413: aconst_null
	//   1414: astore #11
	//   1416: aload #6
	//   1418: astore #4
	//   1420: aload #11
	//   1422: astore #6
	//   1424: goto -> 1329
	//   1427: astore_1
	//   1428: aconst_null
	//   1429: astore #11
	//   1431: aload #6
	//   1433: astore #4
	//   1435: aload #11
	//   1437: astore #6
	//   1439: goto -> 1329
	//   1442: astore_1
	//   1443: aload #10
	//   1445: astore #4
	//   1447: aload #9
	//   1449: astore #6
	//   1451: aload #11
	//   1453: astore_3
	//   1454: goto -> 1329
	//   1457: astore_1
	//   1458: aload #4
	//   1460: astore #11
	//   1462: aload #6
	//   1464: astore #4
	//   1466: aload_3
	//   1467: astore #6
	//   1469: aload #11
	//   1471: astore_3
	//   1472: goto -> 1329
	//   1475: astore #4
	//   1477: aconst_null
	//   1478: astore #11
	//   1480: aload #6
	//   1482: astore #4
	//   1484: aload #11
	//   1486: astore #6
	//   1488: goto -> 1258
	//   1491: astore #4
	//   1493: aconst_null
	//   1494: astore #11
	//   1496: aload #6
	//   1498: astore #4
	//   1500: aload #11
	//   1502: astore #6
	//   1504: goto -> 1258
	//   1507: astore #4
	//   1509: aload #6
	//   1511: astore #4
	//   1513: aload #12
	//   1515: astore #6
	//   1517: goto -> 1258
	//   1520: astore #6
	//   1522: aconst_null
	//   1523: astore_3
	//   1524: aload #9
	//   1526: astore #4
	//   1528: aload #12
	//   1530: astore #6
	//   1532: goto -> 1052
	//   1535: astore #4
	//   1537: aload_3
	//   1538: astore #4
	//   1540: aconst_null
	//   1541: astore_3
	//   1542: goto -> 1052
	//   1545: astore #4
	//   1547: aconst_null
	//   1548: astore #11
	//   1550: aload_3
	//   1551: astore #4
	//   1553: aload #11
	//   1555: astore_3
	//   1556: goto -> 1052
	//   1559: iload_2
	//   1560: istore #14
	//   1562: goto -> 1107
	//   1565: iload #18
	//   1567: istore #14
	//   1569: goto -> 1107
	//   1572: goto -> 701
	//   1575: aconst_null
	//   1576: astore #4
	//   1578: goto -> 701
	//   1581: iconst_0
	//   1582: istore #16
	//   1584: goto -> 451
	//   1587: aconst_null
	//   1588: astore_3
	//   1589: goto -> 372
	// Exception table:
	//   from	to	target	type
	//   189	194	1520	java/lang/Exception
	//   189	194	1247	java/lang/OutOfMemoryError
	//   189	194	1323	finally
	//   205	215	1520	java/lang/Exception
	//   205	215	1247	java/lang/OutOfMemoryError
	//   205	215	1323	finally
	//   226	236	1520	java/lang/Exception
	//   226	236	1247	java/lang/OutOfMemoryError
	//   226	236	1323	finally
	//   248	256	1520	java/lang/Exception
	//   248	256	1247	java/lang/OutOfMemoryError
	//   248	256	1323	finally
	//   268	276	1520	java/lang/Exception
	//   268	276	1247	java/lang/OutOfMemoryError
	//   268	276	1323	finally
	//   293	299	1520	java/lang/Exception
	//   293	299	1247	java/lang/OutOfMemoryError
	//   293	299	1323	finally
	//   311	322	1520	java/lang/Exception
	//   311	322	1247	java/lang/OutOfMemoryError
	//   311	322	1323	finally
	//   334	338	1520	java/lang/Exception
	//   334	338	1247	java/lang/OutOfMemoryError
	//   334	338	1323	finally
	//   350	362	1520	java/lang/Exception
	//   350	362	1247	java/lang/OutOfMemoryError
	//   350	362	1323	finally
	//   362	372	1535	java/lang/Exception
	//   362	372	1475	java/lang/OutOfMemoryError
	//   362	372	1412	finally
	//   372	379	1545	java/lang/Exception
	//   372	379	1491	java/lang/OutOfMemoryError
	//   372	379	1427	finally
	//   410	424	1545	java/lang/Exception
	//   410	424	1491	java/lang/OutOfMemoryError
	//   410	424	1427	finally
	//   451	468	1545	java/lang/Exception
	//   451	468	1491	java/lang/OutOfMemoryError
	//   451	468	1427	finally
	//   479	484	1044	java/lang/Exception
	//   479	484	1507	java/lang/OutOfMemoryError
	//   479	484	1442	finally
	//   495	500	1044	java/lang/Exception
	//   495	500	1507	java/lang/OutOfMemoryError
	//   495	500	1442	finally
	//   516	531	1044	java/lang/Exception
	//   516	531	1507	java/lang/OutOfMemoryError
	//   516	531	1442	finally
	//   542	556	1044	java/lang/Exception
	//   542	556	1507	java/lang/OutOfMemoryError
	//   542	556	1442	finally
	//   579	597	1044	java/lang/Exception
	//   579	597	1507	java/lang/OutOfMemoryError
	//   579	597	1442	finally
	//   608	626	1044	java/lang/Exception
	//   608	626	1507	java/lang/OutOfMemoryError
	//   608	626	1442	finally
	//   657	662	1545	java/lang/Exception
	//   657	662	1491	java/lang/OutOfMemoryError
	//   657	662	1427	finally
	//   676	684	1044	java/lang/Exception
	//   676	684	1507	java/lang/OutOfMemoryError
	//   676	684	1442	finally
	//   695	701	1044	java/lang/Exception
	//   695	701	1507	java/lang/OutOfMemoryError
	//   695	701	1442	finally
	//   725	736	1044	java/lang/Exception
	//   725	736	1507	java/lang/OutOfMemoryError
	//   725	736	1442	finally
	//   747	753	1044	java/lang/Exception
	//   747	753	1507	java/lang/OutOfMemoryError
	//   747	753	1442	finally
	//   764	769	1044	java/lang/Exception
	//   764	769	1507	java/lang/OutOfMemoryError
	//   764	769	1442	finally
	//   778	782	1359	java/io/IOException
	//   782	787	1363	java/io/IOException
	//   822	834	1044	java/lang/Exception
	//   822	834	1507	java/lang/OutOfMemoryError
	//   822	834	1442	finally
	//   848	853	1044	java/lang/Exception
	//   848	853	1507	java/lang/OutOfMemoryError
	//   848	853	1442	finally
	//   870	875	1044	java/lang/Exception
	//   870	875	1507	java/lang/OutOfMemoryError
	//   870	875	1442	finally
	//   889	905	1044	java/lang/Exception
	//   889	905	1507	java/lang/OutOfMemoryError
	//   889	905	1442	finally
	//   991	996	1044	java/lang/Exception
	//   991	996	1507	java/lang/OutOfMemoryError
	//   991	996	1442	finally
	//   1012	1018	1044	java/lang/Exception
	//   1012	1018	1507	java/lang/OutOfMemoryError
	//   1012	1018	1442	finally
	//   1029	1041	1044	java/lang/Exception
	//   1029	1041	1507	java/lang/OutOfMemoryError
	//   1029	1041	1442	finally
	//   1052	1058	1375	java/lang/Exception
	//   1052	1058	1457	finally
	//   1058	1076	1457	finally
	//   1081	1086	1380	java/io/IOException
	//   1090	1094	1385	java/io/IOException
	//   1153	1159	1044	java/lang/Exception
	//   1153	1159	1507	java/lang/OutOfMemoryError
	//   1153	1159	1442	finally
	//   1176	1182	1044	java/lang/Exception
	//   1176	1182	1507	java/lang/OutOfMemoryError
	//   1176	1182	1442	finally
	//   1221	1225	1367	java/io/IOException
	//   1225	1230	1371	java/io/IOException
	//   1269	1272	1442	finally
	//   1283	1289	1389	java/lang/Exception
	//   1283	1289	1442	finally
	//   1293	1297	1394	java/io/IOException
	//   1302	1307	1398	java/io/IOException
	//   1333	1337	1403	java/io/IOException
	//   1342	1347	1407	java/io/IOException
  }

  private static sbyte[] c(List<am> paramArrayList)
  {
	StringBuilder stringBuilder = new StringBuilder(500);
	stringBuilder.Append("<?xml version=\"1.0\"?>");
	stringBuilder.Append("<tiles>");
	int i = paramArrayList.Count;
	for (sbyte b = 0; b < i; b++)
	{
	  am am = paramArrayList[b];
	  stringBuilder.Append("<tile x=\"").Append(am.i);
	  stringBuilder.Append("\" y=\"").Append(am.j);
	  stringBuilder.Append("\" zoom=\"").Append(am.zoom);
	  stringBuilder.Append("\" layer=\"").Append(am.c_Conflict);
	  stringBuilder.Append("\" size=\"").Append("1");
	  if (am.b() > 0)
	  {
		stringBuilder.Append("\" ver=\"").Append(am.b());
		stringBuilder.Append("\" checksum=\"").Append(am.c());
	  }
	  stringBuilder.Append("\" />");
	}
	stringBuilder.Append("</tiles>");
	string str = stringBuilder.ToString();
	try
	{
	  sbyte[] arrayOfByte2 = str.GetBytes();
	  MemoryStream byteArrayOutputStream = new MemoryStream();
	  this();
	  GZIPOutputStream gZIPOutputStream = new GZIPOutputStream();
	  this(byteArrayOutputStream);
	  gZIPOutputStream.write(arrayOfByte2, 0, arrayOfByte2.Length);
	  gZIPOutputStream.finish();
	  sbyte[] arrayOfByte1 = byteArrayOutputStream.toByteArray();
	}
	catch (IOException iOException)
	{
	  iOException = null;
	}
	return (sbyte[])iOException;
  }

  private static bool e()
  {
	// Byte code:
	//   0: ldc bj
	//   2: monitorenter
	//   3: getstatic bj.d : Ljava/util/ArrayList;
	//   6: invokevirtual isEmpty : ()Z
	//   9: ifne -> 26
	//   12: invokestatic e : ()I
	//   15: iconst_2
	//   16: if_icmpne -> 26
	//   19: iconst_1
	//   20: istore_0
	//   21: ldc bj
	//   23: monitorexit
	//   24: iload_0
	//   25: ireturn
	//   26: iconst_0
	//   27: istore_0
	//   28: goto -> 21
	//   31: astore_1
	//   32: ldc bj
	//   34: monitorexit
	//   35: aload_1
	//   36: athrow
	// Exception table:
	//   from	to	target	type
	//   3	19	31	finally
	//   21	24	31	finally
  }

  public void a()
  {
	this.i = false;
  }

  public void a(am paramam)
  {
	// Byte code:
	//   0: ldc bj
	//   2: monitorenter
	//   3: getstatic bj.d : Ljava/util/ArrayList;
	//   6: invokevirtual size : ()I
	//   9: iconst_1
	//   10: isub
	//   11: istore_2
	//   12: iload_2
	//   13: iflt -> 81
	//   16: getstatic bj.d : Ljava/util/ArrayList;
	//   19: iload_2
	//   20: invokevirtual get : (I)Ljava/lang/Object;
	//   23: checkcast am
	//   26: astore_3
	//   27: aload_3
	//   28: getfield i : I
	//   31: aload_1
	//   32: getfield i : I
	//   35: if_icmpne -> 75
	//   38: aload_3
	//   39: getfield j : I
	//   42: aload_1
	//   43: getfield j : I
	//   46: if_icmpne -> 75
	//   49: aload_3
	//   50: getfield zoom : I
	//   53: aload_1
	//   54: getfield zoom : I
	//   57: if_icmpne -> 75
	//   60: aload_3
	//   61: getfield type : I
	//   64: aload_1
	//   65: getfield type : I
	//   68: if_icmpne -> 75
	//   71: ldc bj
	//   73: monitorexit
	//   74: return
	//   75: iinc #2, -1
	//   78: goto -> 12
	//   81: getstatic bj.d : Ljava/util/ArrayList;
	//   84: aload_1
	//   85: invokevirtual add : (Ljava/lang/Object;)Z
	//   88: pop
	//   89: aload_0
	//   90: iconst_0
	//   91: putfield i : Z
	//   94: aload_0
	//   95: iconst_0
	//   96: invokespecial a : (I)V
	//   99: aload_0
	//   100: getfield g : Ljava/lang/Thread;
	//   103: ifnull -> 116
	//   106: aload_0
	//   107: getfield g : Ljava/lang/Thread;
	//   110: invokevirtual isAlive : ()Z
	//   113: ifne -> 147
	//   116: new java/lang/Thread
	//   119: astore_1
	//   120: aload_1
	//   121: aload_0
	//   122: invokespecial <init> : (Ljava/lang/Runnable;)V
	//   125: aload_0
	//   126: aload_1
	//   127: putfield g : Ljava/lang/Thread;
	//   130: aload_0
	//   131: getfield g : Ljava/lang/Thread;
	//   134: ldc_w 'ymm-downloader-tile'
	//   137: invokevirtual setName : (Ljava/lang/String;)V
	//   140: aload_0
	//   141: getfield g : Ljava/lang/Thread;
	//   144: invokevirtual start : ()V
	//   147: ldc bj
	//   149: monitorexit
	//   150: goto -> 74
	//   153: astore_1
	//   154: ldc bj
	//   156: monitorexit
	//   157: aload_1
	//   158: athrow
	// Exception table:
	//   from	to	target	type
	//   3	12	153	finally
	//   16	74	153	finally
	//   81	116	153	finally
	//   116	147	153	finally
	//   147	150	153	finally
  }

  internal void b()
  {
	// Byte code:
	//   0: ldc bj
	//   2: monitorenter
	//   3: invokestatic a : ()Lap;
	//   6: astore_1
	//   7: aload_1
	//   8: ifnull -> 69
	//   11: getstatic bj.d : Ljava/util/ArrayList;
	//   14: invokevirtual iterator : ()Ljava/util/Iterator;
	//   17: astore_2
	//   18: aload_2
	//   19: invokeinterface hasNext : ()Z
	//   24: ifeq -> 69
	//   27: aload_2
	//   28: invokeinterface next : ()Ljava/lang/Object;
	//   33: checkcast am
	//   36: astore_3
	//   37: aload_3
	//   38: iconst_0
	//   39: i2b
	//   40: putfield h : B
	//   43: aload_3
	//   44: aconst_null
	//   45: invokevirtual a : ([B)V
	//   48: aload_3
	//   49: iconst_0
	//   50: i2b
	//   51: putfield k : B
	//   54: aload_1
	//   55: aload_3
	//   56: iconst_0
	//   57: invokevirtual a : (Lam;Z)V
	//   60: goto -> 18
	//   63: astore_1
	//   64: ldc bj
	//   66: monitorexit
	//   67: aload_1
	//   68: athrow
	//   69: getstatic bj.d : Ljava/util/ArrayList;
	//   72: invokevirtual clear : ()V
	//   75: aload_0
	//   76: iconst_2
	//   77: invokespecial a : (I)V
	//   80: ldc bj
	//   82: monitorexit
	//   83: return
	// Exception table:
	//   from	to	target	type
	//   3	7	63	finally
	//   11	18	63	finally
	//   18	60	63	finally
	//   69	83	63	finally
  }

  public void c()
  {
	b();
	d();
  }

  internal void d()
  {
	// Byte code:
	//   0: aload_0
	//   1: iconst_1
	//   2: putfield i : Z
	//   5: aload_0
	//   6: aconst_null
	//   7: putfield h : Ljava/util/ArrayList;
	//   10: ldc bj
	//   12: monitorenter
	//   13: getstatic bj.d : Ljava/util/ArrayList;
	//   16: invokevirtual clear : ()V
	//   19: ldc bj
	//   21: monitorexit
	//   22: return
	//   23: astore_1
	//   24: ldc bj
	//   26: monitorexit
	//   27: aload_1
	//   28: athrow
	// Exception table:
	//   from	to	target	type
	//   13	22	23	finally
  }

  public void run()
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield i : Z
	//   4: ifne -> 109
	//   7: iconst_0
	//   8: istore_1
	//   9: aload_0
	//   10: getfield i : Z
	//   13: ifne -> 182
	//   16: iconst_0
	//   17: istore_2
	//   18: invokestatic e : ()Z
	//   21: ifeq -> 161
	//   24: new java/util/ArrayList
	//   27: astore_3
	//   28: aload_3
	//   29: bipush #10
	//   31: invokespecial <init> : (I)V
	//   34: iconst_0
	//   35: istore_2
	//   36: aload_3
	//   37: invokevirtual size : ()I
	//   40: bipush #10
	//   42: if_icmpge -> 122
	//   45: aload_0
	//   46: aload_3
	//   47: invokespecial a : (Ljava/util/ArrayList;)Lam;
	//   50: astore #4
	//   52: aload #4
	//   54: ifnonnull -> 110
	//   57: iload_2
	//   58: ifne -> 122
	//   61: ldc bj
	//   63: monitorenter
	//   64: ldc bj
	//   66: ldc2_w 200
	//   69: invokevirtual wait : (J)V
	//   72: ldc bj
	//   74: monitorexit
	//   75: iconst_1
	//   76: istore_2
	//   77: goto -> 36
	//   80: astore_3
	//   81: ldc bj
	//   83: monitorexit
	//   84: aload_3
	//   85: athrow
	//   86: astore_3
	//   87: aload_0
	//   88: aconst_null
	//   89: putfield h : Ljava/util/ArrayList;
	//   92: ldc bj
	//   94: monitorenter
	//   95: invokestatic e : ()Z
	//   98: ifne -> 285
	//   101: aload_0
	//   102: aconst_null
	//   103: putfield g : Ljava/lang/Thread;
	//   106: ldc bj
	//   108: monitorexit
	//   109: return
	//   110: aload_3
	//   111: aload #4
	//   113: invokevirtual add : (Ljava/lang/Object;)Z
	//   116: pop
	//   117: iconst_0
	//   118: istore_2
	//   119: goto -> 36
	//   122: aload_3
	//   123: invokevirtual isEmpty : ()Z
	//   126: ifne -> 349
	//   129: aload_0
	//   130: aload_3
	//   131: putfield h : Ljava/util/ArrayList;
	//   134: aload_0
	//   135: aload_3
	//   136: invokespecial b : (Ljava/util/ArrayList;)V
	//   139: aload_0
	//   140: aconst_null
	//   141: putfield h : Ljava/util/ArrayList;
	//   144: ldc2_w 10
	//   147: invokestatic sleep : (J)V
	//   150: iconst_1
	//   151: istore_2
	//   152: goto -> 18
	//   155: astore_3
	//   156: iconst_1
	//   157: istore_2
	//   158: goto -> 18
	//   161: ldc bj
	//   163: monitorenter
	//   164: iload_2
	//   165: ifne -> 213
	//   168: iinc #1, 1
	//   171: iload_1
	//   172: istore_2
	//   173: iload_1
	//   174: bipush #50
	//   176: if_icmple -> 215
	//   179: ldc bj
	//   181: monitorexit
	//   182: aload_0
	//   183: aconst_null
	//   184: putfield h : Ljava/util/ArrayList;
	//   187: ldc bj
	//   189: monitorenter
	//   190: invokestatic e : ()Z
	//   193: ifne -> 279
	//   196: aload_0
	//   197: aconst_null
	//   198: putfield g : Ljava/lang/Thread;
	//   201: ldc bj
	//   203: monitorexit
	//   204: goto -> 109
	//   207: astore_3
	//   208: ldc bj
	//   210: monitorexit
	//   211: aload_3
	//   212: athrow
	//   213: iconst_0
	//   214: istore_2
	//   215: invokestatic e : ()Z
	//   218: istore #5
	//   220: iload #5
	//   222: ifne -> 233
	//   225: ldc bj
	//   227: ldc2_w 400
	//   230: invokevirtual wait : (J)V
	//   233: ldc bj
	//   235: monitorexit
	//   236: iload_2
	//   237: istore_1
	//   238: goto -> 9
	//   241: astore_3
	//   242: ldc bj
	//   244: monitorexit
	//   245: aload_3
	//   246: athrow
	//   247: astore_3
	//   248: aload_0
	//   249: aconst_null
	//   250: putfield h : Ljava/util/ArrayList;
	//   253: ldc bj
	//   255: monitorenter
	//   256: invokestatic e : ()Z
	//   259: ifne -> 297
	//   262: aload_0
	//   263: aconst_null
	//   264: putfield g : Ljava/lang/Thread;
	//   267: ldc bj
	//   269: monitorexit
	//   270: goto -> 109
	//   273: astore_3
	//   274: ldc bj
	//   276: monitorexit
	//   277: aload_3
	//   278: athrow
	//   279: ldc bj
	//   281: monitorexit
	//   282: goto -> 0
	//   285: ldc bj
	//   287: monitorexit
	//   288: goto -> 0
	//   291: astore_3
	//   292: ldc bj
	//   294: monitorexit
	//   295: aload_3
	//   296: athrow
	//   297: ldc bj
	//   299: monitorexit
	//   300: goto -> 0
	//   303: astore_3
	//   304: aload_0
	//   305: aconst_null
	//   306: putfield h : Ljava/util/ArrayList;
	//   309: ldc bj
	//   311: monitorenter
	//   312: invokestatic e : ()Z
	//   315: ifne -> 335
	//   318: aload_0
	//   319: aconst_null
	//   320: putfield g : Ljava/lang/Thread;
	//   323: ldc bj
	//   325: monitorexit
	//   326: goto -> 109
	//   329: astore_3
	//   330: ldc bj
	//   332: monitorexit
	//   333: aload_3
	//   334: athrow
	//   335: ldc bj
	//   337: monitorexit
	//   338: aload_3
	//   339: athrow
	//   340: astore_3
	//   341: goto -> 233
	//   344: astore #4
	//   346: goto -> 72
	//   349: iconst_1
	//   350: istore_2
	//   351: goto -> 18
	// Exception table:
	//   from	to	target	type
	//   9	16	86	java/lang/Exception
	//   9	16	247	java/lang/Error
	//   9	16	303	finally
	//   18	34	86	java/lang/Exception
	//   18	34	247	java/lang/Error
	//   18	34	303	finally
	//   36	52	86	java/lang/Exception
	//   36	52	247	java/lang/Error
	//   36	52	303	finally
	//   61	64	86	java/lang/Exception
	//   61	64	247	java/lang/Error
	//   61	64	303	finally
	//   64	72	344	java/lang/Exception
	//   64	72	80	finally
	//   72	75	80	finally
	//   81	86	86	java/lang/Exception
	//   81	86	247	java/lang/Error
	//   81	86	303	finally
	//   95	109	291	finally
	//   110	117	86	java/lang/Exception
	//   110	117	247	java/lang/Error
	//   110	117	303	finally
	//   122	144	86	java/lang/Exception
	//   122	144	247	java/lang/Error
	//   122	144	303	finally
	//   144	150	155	java/lang/Exception
	//   144	150	247	java/lang/Error
	//   144	150	303	finally
	//   161	164	86	java/lang/Exception
	//   161	164	247	java/lang/Error
	//   161	164	303	finally
	//   179	182	86	java/lang/Exception
	//   179	182	247	java/lang/Error
	//   179	182	303	finally
	//   190	204	207	finally
	//   215	220	241	finally
	//   225	233	340	java/lang/Exception
	//   225	233	241	finally
	//   233	236	241	finally
	//   242	247	86	java/lang/Exception
	//   242	247	247	java/lang/Error
	//   242	247	303	finally
	//   256	270	273	finally
	//   312	326	329	finally
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */