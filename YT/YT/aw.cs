using System;
using System.Collections;
using System.Text;

using Paint = android.graphics.Paint;
using PointF = android.graphics.PointF;
using MapController = ru.yandex.yandexmapkit.MapController;
using DownloadHandler = ru.yandex.yandexmapkit.net.DownloadHandler;
using DownloadJob = ru.yandex.yandexmapkit.net.DownloadJob;
using Downloader = ru.yandex.yandexmapkit.net.Downloader;
using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class aw : DownloadHandler
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static int b_Conflict = 4;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public readonly ax[] a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool c_Conflict;

  private au d;

  private readonly MapController e;

  private readonly Paint f;

  private readonly ArrayList g;

  private ay h;

  private by i = new by();

  private readonly av j;

  public aw(MapController paramMapController)
  {
	this.e = paramMapController;
	this.a_Conflict = new ax[23];
	this.g = new ArrayList();
	this.j = new av(this);
	this.f = new Paint();
	this.f.setAntiAlias(false);
  }

  private void a(ax paramax)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_1
	//   3: ifnull -> 219
	//   6: aload_1
	//   7: getfield a : I
	//   10: iconst_m1
	//   11: if_icmpne -> 219
	//   14: aload_1
	//   15: getfield i : Laz;
	//   18: ifnull -> 219
	//   21: aload_0
	//   22: getfield a : [Lax;
	//   25: aload_1
	//   26: getfield d : B
	//   29: aload_1
	//   30: aastore
	//   31: aload_0
	//   32: monitorenter
	//   33: aload_0
	//   34: getfield g : Ljava/util/ArrayList;
	//   37: invokevirtual iterator : ()Ljava/util/Iterator;
	//   40: astore_2
	//   41: aload_2
	//   42: invokeinterface hasNext : ()Z
	//   47: ifeq -> 134
	//   50: aload_2
	//   51: invokeinterface next : ()Ljava/lang/Object;
	//   56: checkcast aj
	//   59: astore_3
	//   60: aload_3
	//   61: getfield c : I
	//   64: aload_1
	//   65: getfield d : B
	//   68: if_icmpne -> 41
	//   71: aload_3
	//   72: getfield a : I
	//   75: aload_1
	//   76: getfield k : I
	//   79: if_icmple -> 41
	//   82: aload_3
	//   83: getfield a : I
	//   86: aload_1
	//   87: getfield k : I
	//   90: aload_1
	//   91: getfield m : I
	//   94: iadd
	//   95: if_icmpge -> 41
	//   98: aload_3
	//   99: getfield b : I
	//   102: aload_1
	//   103: getfield l : I
	//   106: if_icmple -> 41
	//   109: aload_3
	//   110: getfield b : I
	//   113: aload_1
	//   114: getfield l : I
	//   117: aload_1
	//   118: getfield n : I
	//   121: iadd
	//   122: if_icmpge -> 41
	//   125: aload_0
	//   126: getfield g : Ljava/util/ArrayList;
	//   129: aload_3
	//   130: invokevirtual remove : (Ljava/lang/Object;)Z
	//   133: pop
	//   134: aload_0
	//   135: monitorexit
	//   136: aload_1
	//   137: getfield i : Laz;
	//   140: getfield a : J
	//   143: lstore #4
	//   145: iconst_0
	//   146: istore #6
	//   148: iload #6
	//   150: aload_0
	//   151: getfield a : [Lax;
	//   154: arraylength
	//   155: if_icmpge -> 207
	//   158: aload_0
	//   159: getfield a : [Lax;
	//   162: iload #6
	//   164: aaload
	//   165: astore_1
	//   166: aload_1
	//   167: ifnull -> 191
	//   170: aload_1
	//   171: getfield i : Laz;
	//   174: getfield a : J
	//   177: lload #4
	//   179: lcmp
	//   180: ifge -> 191
	//   183: aload_0
	//   184: getfield a : [Lax;
	//   187: iload #6
	//   189: aconst_null
	//   190: aastore
	//   191: iinc #6, 1
	//   194: goto -> 148
	//   197: astore_1
	//   198: aload_0
	//   199: monitorexit
	//   200: aload_1
	//   201: athrow
	//   202: astore_1
	//   203: aload_0
	//   204: monitorexit
	//   205: aload_1
	//   206: athrow
	//   207: aload_0
	//   208: iconst_1
	//   209: invokevirtual c : (Z)V
	//   212: aload_0
	//   213: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   216: invokevirtual notifyRepaint : ()V
	//   219: aload_0
	//   220: monitorexit
	//   221: return
	// Exception table:
	//   from	to	target	type
	//   6	33	202	finally
	//   33	41	197	finally
	//   41	134	197	finally
	//   134	136	197	finally
	//   136	145	202	finally
	//   148	166	202	finally
	//   170	191	202	finally
	//   198	202	202	finally
	//   207	219	202	finally
  }

  private bool a(aj paramaj)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   4: invokevirtual getWidth : ()I
	//   7: istore_2
	//   8: aload_0
	//   9: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   12: invokevirtual getHeight : ()I
	//   15: istore_3
	//   16: bipush #23
	//   18: aload_1
	//   19: getfield c : I
	//   22: isub
	//   23: istore #4
	//   25: iload_2
	//   26: iload #4
	//   28: ishl
	//   29: istore_2
	//   30: iload_3
	//   31: iload #4
	//   33: ishl
	//   34: istore #5
	//   36: aload_1
	//   37: getfield a : I
	//   40: istore #4
	//   42: aload_1
	//   43: getfield b : I
	//   46: istore #6
	//   48: aload_1
	//   49: getfield a : I
	//   52: istore #7
	//   54: aload_1
	//   55: getfield b : I
	//   58: istore_3
	//   59: aload_0
	//   60: monitorenter
	//   61: aload_0
	//   62: getfield g : Ljava/util/ArrayList;
	//   65: invokevirtual iterator : ()Ljava/util/Iterator;
	//   68: astore #8
	//   70: aload #8
	//   72: invokeinterface hasNext : ()Z
	//   77: ifeq -> 161
	//   80: aload #8
	//   82: invokeinterface next : ()Ljava/lang/Object;
	//   87: checkcast aj
	//   90: astore #9
	//   92: aload #9
	//   94: getfield c : I
	//   97: aload_1
	//   98: getfield c : I
	//   101: if_icmpne -> 70
	//   104: aload #9
	//   106: getfield a : I
	//   109: iload #4
	//   111: iload_2
	//   112: isub
	//   113: if_icmple -> 70
	//   116: aload #9
	//   118: getfield a : I
	//   121: iload #7
	//   123: iload_2
	//   124: iadd
	//   125: if_icmpge -> 70
	//   128: aload #9
	//   130: getfield b : I
	//   133: iload #6
	//   135: iload #5
	//   137: isub
	//   138: if_icmple -> 70
	//   141: aload #9
	//   143: getfield b : I
	//   146: iload #5
	//   148: iload_3
	//   149: iadd
	//   150: if_icmpge -> 70
	//   153: iconst_1
	//   154: istore #10
	//   156: aload_0
	//   157: monitorexit
	//   158: iload #10
	//   160: ireturn
	//   161: aload_0
	//   162: monitorexit
	//   163: iconst_0
	//   164: istore #10
	//   166: goto -> 158
	//   169: astore_1
	//   170: aload_0
	//   171: monitorexit
	//   172: aload_1
	//   173: athrow
	// Exception table:
	//   from	to	target	type
	//   61	70	169	finally
	//   70	153	169	finally
	//   156	158	169	finally
  }

  private void b(aj paramaj)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield d : Lau;
	//   4: ifnull -> 92
	//   7: aload_1
	//   8: getfield c : I
	//   11: getstatic aw.b : I
	//   14: if_icmplt -> 92
	//   17: aload_0
	//   18: aload_1
	//   19: invokespecial a : (Laj;)Z
	//   22: ifne -> 92
	//   25: getstatic ru/yandex/yandexmapkit/net/Downloader.b : Lbi;
	//   28: ifnull -> 92
	//   31: getstatic ru/yandex/yandexmapkit/net/Downloader.b : Lbi;
	//   34: ldc 'semaphores'
	//   36: aload_1
	//   37: getfield c : I
	//   40: invokevirtual a : (Ljava/lang/String;I)Z
	//   43: ifeq -> 92
	//   46: getstatic ru/yandex/yandexmapkit/net/Downloader.b : Lbi;
	//   49: getfield f : Ljava/util/Map;
	//   52: ldc 'semaphores'
	//   54: invokeinterface get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   59: pop
	//   60: aload_0
	//   61: monitorenter
	//   62: aload_0
	//   63: getfield g : Ljava/util/ArrayList;
	//   66: invokevirtual clear : ()V
	//   69: aload_0
	//   70: getfield g : Ljava/util/ArrayList;
	//   73: aload_1
	//   74: invokevirtual add : (Ljava/lang/Object;)Z
	//   77: pop
	//   78: aload_0
	//   79: monitorexit
	//   80: aload_0
	//   81: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   84: invokevirtual getDownloader : ()Lru/yandex/yandexmapkit/net/Downloader;
	//   87: aload_0
	//   88: iconst_2
	//   89: invokevirtual downloadProccess : (Lru/yandex/yandexmapkit/net/DownloadHandler;I)V
	//   92: return
	//   93: astore_1
	//   94: aload_0
	//   95: monitorexit
	//   96: aload_1
	//   97: athrow
	// Exception table:
	//   from	to	target	type
	//   62	80	93	finally
  }

  public ax a(am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_1
	//   3: getfield zoom : I
	//   6: getstatic aw.b : I
	//   9: if_icmplt -> 205
	//   12: aload_1
	//   13: getfield zoom : I
	//   16: istore_2
	//   17: aload_0
	//   18: getfield a : [Lax;
	//   21: aload_1
	//   22: getfield zoom : I
	//   25: aaload
	//   26: astore_3
	//   27: aload_3
	//   28: ifnonnull -> 227
	//   31: iload_2
	//   32: iconst_1
	//   33: isub
	//   34: istore #4
	//   36: iload #4
	//   38: getstatic aw.b : I
	//   41: if_icmplt -> 221
	//   44: aload_0
	//   45: getfield a : [Lax;
	//   48: iload #4
	//   50: aaload
	//   51: astore #5
	//   53: aload #5
	//   55: ifnull -> 193
	//   58: iload_2
	//   59: iconst_1
	//   60: iadd
	//   61: istore #4
	//   63: iload #4
	//   65: bipush #17
	//   67: if_icmpgt -> 215
	//   70: aload_0
	//   71: getfield a : [Lax;
	//   74: iload #4
	//   76: aaload
	//   77: astore #6
	//   79: aload #6
	//   81: ifnull -> 199
	//   84: aload #6
	//   86: astore_3
	//   87: aload #5
	//   89: ifnull -> 112
	//   92: iload_2
	//   93: aload #5
	//   95: getfield d : B
	//   98: isub
	//   99: aload #6
	//   101: getfield d : B
	//   104: iload_2
	//   105: isub
	//   106: if_icmple -> 215
	//   109: aload #6
	//   111: astore_3
	//   112: aload_3
	//   113: ifnull -> 205
	//   116: bipush #23
	//   118: aload_1
	//   119: getfield zoom : I
	//   122: isub
	//   123: istore #7
	//   125: aload_1
	//   126: getfield i : I
	//   129: istore_2
	//   130: aload_1
	//   131: getfield j : I
	//   134: istore #4
	//   136: sipush #128
	//   139: iload #7
	//   141: ishl
	//   142: istore #8
	//   144: iload_2
	//   145: iload #7
	//   147: bipush #7
	//   149: iadd
	//   150: ishl
	//   151: iload #4
	//   153: iload #7
	//   155: bipush #7
	//   157: iadd
	//   158: ishl
	//   159: iload #8
	//   161: iload #8
	//   163: aload_3
	//   164: getfield k : I
	//   167: aload_3
	//   168: getfield l : I
	//   171: aload_3
	//   172: getfield m : I
	//   175: aload_3
	//   176: getfield n : I
	//   179: invokestatic a : (IIIIIIII)Z
	//   182: istore #9
	//   184: iload #9
	//   186: ifeq -> 205
	//   189: aload_0
	//   190: monitorexit
	//   191: aload_3
	//   192: areturn
	//   193: iinc #4, -1
	//   196: goto -> 36
	//   199: iinc #4, 1
	//   202: goto -> 63
	//   205: aconst_null
	//   206: astore_3
	//   207: goto -> 189
	//   210: astore_1
	//   211: aload_0
	//   212: monitorexit
	//   213: aload_1
	//   214: athrow
	//   215: aload #5
	//   217: astore_3
	//   218: goto -> 112
	//   221: aload_3
	//   222: astore #5
	//   224: goto -> 58
	//   227: goto -> 112
	// Exception table:
	//   from	to	target	type
	//   2	27	210	finally
	//   36	53	210	finally
	//   70	79	210	finally
	//   92	109	210	finally
	//   116	136	210	finally
	//   144	184	210	finally
  }

  public void a(bool paramBoolean)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: iload_1
	//   4: putfield c : Z
	//   7: aload_0
	//   8: iconst_0
	//   9: invokevirtual b : (Z)V
	//   12: aload_0
	//   13: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   16: invokevirtual notifyRepaint : ()V
	//   19: aload_0
	//   20: monitorexit
	//   21: return
	//   22: astore_2
	//   23: aload_0
	//   24: monitorexit
	//   25: aload_2
	//   26: athrow
	// Exception table:
	//   from	to	target	type
	//   2	19	22	finally
  }

  public bool a()
  {
	return this.c_Conflict;
  }

  public av b()
  {
	return this.j;
  }

  public void b(bool paramBoolean)
  {
	MapController.Map map;
	ax ax1;
	int i;
	int j;
	int k;
	int m;
	bool @bool;
	if (this.d == null && this.c_Conflict)
	{
	  this.e.Downloader.downloadProccess(this, 1);
	  return;
	}
	lock (this.e.d())
	{
	  i = map.m();
	  j = map.n();
	  k = map.k();
	  ah ah = this.e.e();
	  if (ah.a())
	  {
		this.e.g().a(ah.e(), ah.f(), this.i);
		PointF pointF = ah.a(i, j, (float)this.i.x, (float)this.i.y);
		i = (long)Math.Round(pointF.x, MidpointRounding.AwayFromZero);
		j = (long)Math.Round(pointF.y, MidpointRounding.AwayFromZero);
	  }
	  ax1 = this.a_Conflict[k];
	  sbyte b = 0;
	  m = b;
	  if (ax1 != null)
	  {
		m = b;
		if (ax1.b())
		{
		  sbyte b1 = 1;
		  int n = this.a_Conflict.Length;
		  b = 0;
		  while (true)
		  {
			m = b1;
			if (b < n)
			{
			  if (this.a_Conflict[b] != null && this.a_Conflict[b].b())
			  {
				this.a_Conflict[b] = null;
			  }
			  b++;
			  continue;
			}
			break;
		  }
		}
	  }
	}
	if (m == 0)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	c(@bool);
	if (m != 0)
	{
	  this.e.notifyRepaint();
	}
	if (!paramBoolean)
	{
	  if (this.c_Conflict)
	  {
		if (ax1 != null && !ax1.a())
		{
		  if (k >= b_Conflict)
		  {
			int i1 = this.e.Width;
			int n = this.e.Height;
			m = 23 - k;
			i1 <<= m;
			m = n << m;
			if (!b.a((i - (i1 >> 1)), (j - (m >> 1)), i1, m, ax1.k, ax1.l, ax1.m, ax1.n))
			{
			  m = 1;
			}
			else
			{
			  m = 0;
			}
		  }
		  else
		  {
			m = 0;
		  }
		  if (m != 0)
		  {
			b(new aj(i, j, k));
			return;
		  }
		  return;
		}
	  }
	  else
	  {
		return;
	  }
	}
	b(new aj(i, j, k));
  }

  protected internal au c()
  {
	return this.d;
  }

  public void c(bool paramBoolean)
  {
	// Byte code:
	//   0: aconst_null
	//   1: astore_2
	//   2: aconst_null
	//   3: astore_3
	//   4: aload_2
	//   5: astore #4
	//   7: aload_0
	//   8: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   11: invokevirtual d : ()Lru/yandex/yandexmapkit/MapController$Map;
	//   14: invokevirtual m : ()I
	//   17: istore #5
	//   19: aload_2
	//   20: astore #4
	//   22: aload_0
	//   23: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   26: invokevirtual d : ()Lru/yandex/yandexmapkit/MapController$Map;
	//   29: invokevirtual n : ()I
	//   32: istore #6
	//   34: aload_2
	//   35: astore #4
	//   37: aload_0
	//   38: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   41: invokevirtual d : ()Lru/yandex/yandexmapkit/MapController$Map;
	//   44: invokevirtual k : ()I
	//   47: istore #7
	//   49: aload_2
	//   50: astore #4
	//   52: iload #7
	//   54: getstatic aw.b : I
	//   57: if_icmplt -> 242
	//   60: aload_2
	//   61: astore #4
	//   63: aload_0
	//   64: getfield a : [Lax;
	//   67: iload #7
	//   69: aaload
	//   70: astore_2
	//   71: aload_2
	//   72: ifnonnull -> 475
	//   75: iload #7
	//   77: iconst_1
	//   78: isub
	//   79: istore #8
	//   81: iload #8
	//   83: getstatic aw.b : I
	//   86: if_icmplt -> 470
	//   89: aload_0
	//   90: getfield a : [Lax;
	//   93: iload #8
	//   95: aaload
	//   96: astore_3
	//   97: aload_3
	//   98: ifnull -> 358
	//   101: iload #7
	//   103: iconst_1
	//   104: iadd
	//   105: istore #8
	//   107: aload_3
	//   108: astore_2
	//   109: iload #8
	//   111: bipush #17
	//   113: if_icmpgt -> 163
	//   116: aload_3
	//   117: astore #4
	//   119: aload_0
	//   120: getfield a : [Lax;
	//   123: iload #8
	//   125: aaload
	//   126: astore #9
	//   128: aload #9
	//   130: ifnull -> 364
	//   133: aload_3
	//   134: ifnull -> 160
	//   137: aload_3
	//   138: astore_2
	//   139: aload_3
	//   140: astore #4
	//   142: iload #7
	//   144: aload_3
	//   145: getfield d : B
	//   148: isub
	//   149: aload #9
	//   151: getfield d : B
	//   154: iload #7
	//   156: isub
	//   157: if_icmple -> 163
	//   160: aload #9
	//   162: astore_2
	//   163: aload_2
	//   164: astore_3
	//   165: aload_2
	//   166: ifnull -> 242
	//   169: aload_2
	//   170: astore #4
	//   172: iload #5
	//   174: aload_2
	//   175: getfield k : I
	//   178: if_icmplt -> 240
	//   181: aload_2
	//   182: astore #4
	//   184: iload #5
	//   186: aload_2
	//   187: getfield k : I
	//   190: aload_2
	//   191: getfield m : I
	//   194: iadd
	//   195: if_icmpgt -> 240
	//   198: aload_2
	//   199: astore #4
	//   201: iload #6
	//   203: aload_2
	//   204: getfield l : I
	//   207: if_icmplt -> 240
	//   210: aload_2
	//   211: astore #4
	//   213: aload_2
	//   214: getfield l : I
	//   217: istore #8
	//   219: aload_2
	//   220: astore #4
	//   222: aload_2
	//   223: getfield n : I
	//   226: istore #7
	//   228: aload_2
	//   229: astore_3
	//   230: iload #6
	//   232: iload #8
	//   234: iload #7
	//   236: iadd
	//   237: if_icmple -> 242
	//   240: aconst_null
	//   241: astore_3
	//   242: aload_3
	//   243: astore_2
	//   244: aload_2
	//   245: ifnull -> 447
	//   248: aload_2
	//   249: getfield g : I
	//   252: ifle -> 439
	//   255: aload_0
	//   256: aload_2
	//   257: getfield j : [Lay;
	//   260: iconst_0
	//   261: aaload
	//   262: putfield h : Lay;
	//   265: aload_0
	//   266: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   269: invokevirtual d : ()Lru/yandex/yandexmapkit/MapController$Map;
	//   272: invokevirtual b : ()Laj;
	//   275: invokevirtual a : ()Lru/yandex/yandexmapkit/utils/GeoPoint;
	//   278: astore_3
	//   279: iconst_0
	//   280: istore #8
	//   282: iconst_m1
	//   283: istore #6
	//   285: ldc2_w 1.7976931348623157E308
	//   288: dstore #10
	//   290: iload #8
	//   292: aload_2
	//   293: getfield g : I
	//   296: if_icmpge -> 377
	//   299: aload_2
	//   300: getfield j : [Lay;
	//   303: iload #8
	//   305: aaload
	//   306: astore #4
	//   308: aload #4
	//   310: ifnull -> 467
	//   313: aload_3
	//   314: invokevirtual getLat : ()D
	//   317: aload_3
	//   318: invokevirtual getLon : ()D
	//   321: aload #4
	//   323: getfield a : D
	//   326: aload #4
	//   328: getfield b : D
	//   331: invokestatic getDistance : (DDDD)D
	//   334: dstore #12
	//   336: dload #12
	//   338: dload #10
	//   340: dcmpg
	//   341: ifge -> 467
	//   344: iload #8
	//   346: istore #6
	//   348: dload #12
	//   350: dstore #10
	//   352: iinc #8, 1
	//   355: goto -> 290
	//   358: iinc #8, -1
	//   361: goto -> 81
	//   364: iinc #8, 1
	//   367: goto -> 107
	//   370: astore_2
	//   371: aload #4
	//   373: astore_2
	//   374: goto -> 244
	//   377: iload #6
	//   379: iflt -> 431
	//   382: aload_0
	//   383: aload_2
	//   384: getfield j : [Lay;
	//   387: iload #6
	//   389: aaload
	//   390: putfield h : Lay;
	//   393: aload_2
	//   394: ifnonnull -> 412
	//   397: aload_0
	//   398: getfield h : Lay;
	//   401: ifnonnull -> 412
	//   404: aload_0
	//   405: getfield g : Ljava/util/ArrayList;
	//   408: invokevirtual isEmpty : ()Z
	//   411: pop
	//   412: aload_0
	//   413: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   416: aload_0
	//   417: getfield h : Lay;
	//   420: invokevirtual a : (Lay;)V
	//   423: aload_0
	//   424: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   427: invokevirtual notifyRepaint : ()V
	//   430: return
	//   431: aload_0
	//   432: aconst_null
	//   433: putfield h : Lay;
	//   436: goto -> 393
	//   439: aload_0
	//   440: aconst_null
	//   441: putfield h : Lay;
	//   444: goto -> 393
	//   447: iload_1
	//   448: ifne -> 393
	//   451: aload_0
	//   452: aconst_null
	//   453: putfield h : Lay;
	//   456: goto -> 393
	//   459: astore #4
	//   461: aload_2
	//   462: astore #4
	//   464: goto -> 371
	//   467: goto -> 352
	//   470: aload_2
	//   471: astore_3
	//   472: goto -> 101
	//   475: goto -> 163
	// Exception table:
	//   from	to	target	type
	//   7	19	370	java/lang/Throwable
	//   22	34	370	java/lang/Throwable
	//   37	49	370	java/lang/Throwable
	//   52	60	370	java/lang/Throwable
	//   63	71	370	java/lang/Throwable
	//   81	97	459	java/lang/Throwable
	//   119	128	370	java/lang/Throwable
	//   142	160	370	java/lang/Throwable
	//   172	181	370	java/lang/Throwable
	//   184	198	370	java/lang/Throwable
	//   201	210	370	java/lang/Throwable
	//   213	219	370	java/lang/Throwable
	//   222	228	370	java/lang/Throwable
  }

  public DownloadJob onCreateDownloadJob(int paramInt)
  {
	if (paramInt == 1)
	{
	  return new DownloadJob(1, (Downloader.getServer(7) + "/tjamstyles.gz"), 0, null, this, null, 1000L);
	}
	if (paramInt == 2)
	{
	  aj aj = this.e.d().b();
	  int[] arrayOfInt = new int[6];
	  arrayOfInt[0] = aj.c;
	  paramInt = this.e.Width;
	  int i = this.e.Height;
	  int j = 23 - aj.c;
	  paramInt <<= j;
	  i <<= j;
	  int k = aj.a_Conflict - (paramInt >> 1);
	  j = aj.b - (i >> 1);
	  by by1 = new by();
	  by1.x = (k - paramInt);
	  by1.y = (j - i);
	  arrayOfInt[1] = (int)by1.x;
	  arrayOfInt[2] = (int)by1.y;
	  GeoPoint geoPoint1 = CoordConversion.toLL(by1);
	  by1.x = ((paramInt << 1) + k);
	  by1.y = ((i << 1) + j);
	  arrayOfInt[3] = (int)by1.x - arrayOfInt[1];
	  arrayOfInt[4] = (int)by1.y - arrayOfInt[2];
	  GeoPoint geoPoint2 = CoordConversion.toLL(by1);
	  StringBuilder stringBuilder1 = new StringBuilder();
	  stringBuilder1.Append(Downloader.getServer(7));
	  stringBuilder1.Append("/jamsvec?uuid=");
	  stringBuilder1.Append(Downloader.UUID);
	  stringBuilder1.Append("&zoom=");
	  stringBuilder1.Append(aj.c);
	  stringBuilder1.Append("&tl_lat=");
	  string str1 = b.a(geoPoint1.Lat);
	  stringBuilder1.Append(str1);
	  stringBuilder1.Append("&tl_lon=");
	  string str4 = b.a(geoPoint1.Lon);
	  stringBuilder1.Append(str4);
	  stringBuilder1.Append("&br_lat=");
	  string str2 = b.a(geoPoint2.Lat);
	  stringBuilder1.Append(str2);
	  stringBuilder1.Append("&br_lon=");
	  string str3 = b.a(geoPoint2.Lon);
	  stringBuilder1.Append(str3);
	  StringBuilder stringBuilder2 = new StringBuilder(50);
	  stringBuilder2.Append(str1);
	  stringBuilder2.Append(str4);
	  stringBuilder2.Append(str2);
	  stringBuilder2.Append(str3);
	  stringBuilder2.Append(aj.c);
	  long l = Downloader.a(stringBuilder2.ToString().GetBytes(), Downloader.UUIDBytes);
	  stringBuilder1.Append("&packetid=");
	  stringBuilder1.Append(l);
	  stringBuilder1.Append("&gzip");
	  stringBuilder1.Append("&betajams");
	  return new DownloadJob(2, stringBuilder1.ToString(), 0, null, this, arrayOfInt, 5000L);
	}
	return null;
  }

  public bool onFinishDownload(DownloadJob paramDownloadJob, bool paramBoolean)
  {
	// Byte code:
	//   0: aconst_null
	//   1: astore_3
	//   2: aconst_null
	//   3: astore #4
	//   5: iconst_0
	//   6: istore_2
	//   7: iconst_0
	//   8: istore #5
	//   10: aload_1
	//   11: getfield e : I
	//   14: sipush #200
	//   17: if_icmpne -> 452
	//   20: aload_1
	//   21: getfield f : [B
	//   24: ifnull -> 452
	//   27: new java/io/ByteArrayInputStream
	//   30: dup
	//   31: aload_1
	//   32: getfield f : [B
	//   35: invokespecial <init> : ([B)V
	//   38: astore #6
	//   40: aload_1
	//   41: getfield a : I
	//   44: tableswitch default -> 68, 1 -> 73, 2 -> 288
	//   68: iload #5
	//   70: istore_2
	//   71: iload_2
	//   72: ireturn
	//   73: aload #4
	//   75: astore_3
	//   76: aload_1
	//   77: getfield f : [B
	//   80: ifnull -> 521
	//   83: aload #4
	//   85: astore_3
	//   86: aload_1
	//   87: getfield f : [B
	//   90: invokestatic a : ([B)Z
	//   93: ifeq -> 238
	//   96: aload #4
	//   98: astore_3
	//   99: new java/util/zip/GZIPInputStream
	//   102: astore_1
	//   103: aload #4
	//   105: astore_3
	//   106: aload_1
	//   107: aload #6
	//   109: invokespecial <init> : (Ljava/io/InputStream;)V
	//   112: aload_1
	//   113: astore_3
	//   114: aload_1
	//   115: astore #6
	//   117: new au
	//   120: astore #4
	//   122: aload_1
	//   123: astore_3
	//   124: aload_1
	//   125: astore #6
	//   127: aload #4
	//   129: invokespecial <init> : ()V
	//   132: aload_1
	//   133: astore_3
	//   134: aload_1
	//   135: astore #6
	//   137: aload_0
	//   138: aload #4
	//   140: putfield d : Lau;
	//   143: aload_1
	//   144: astore_3
	//   145: aload_1
	//   146: astore #6
	//   148: aload_0
	//   149: getfield d : Lau;
	//   152: astore #4
	//   154: aload_1
	//   155: astore_3
	//   156: aload_1
	//   157: astore #6
	//   159: new bt
	//   162: astore #7
	//   164: aload_1
	//   165: astore_3
	//   166: aload_1
	//   167: astore #6
	//   169: aload #7
	//   171: aload_1
	//   172: invokespecial <init> : (Ljava/io/InputStream;)V
	//   175: aload_1
	//   176: astore_3
	//   177: aload_1
	//   178: astore #6
	//   180: aload #4
	//   182: aload #7
	//   184: invokestatic a : (Lcd;Ljava/io/Reader;)V
	//   187: aload_1
	//   188: astore_3
	//   189: aload_1
	//   190: astore #6
	//   192: aload_0
	//   193: getfield c : Z
	//   196: ifeq -> 218
	//   199: aload_1
	//   200: astore_3
	//   201: aload_1
	//   202: astore #6
	//   204: aload_0
	//   205: aload_0
	//   206: getfield e : Lru/yandex/yandexmapkit/MapController;
	//   209: invokevirtual d : ()Lru/yandex/yandexmapkit/MapController$Map;
	//   212: invokevirtual b : ()Laj;
	//   215: invokespecial b : (Laj;)V
	//   218: iconst_1
	//   219: istore #5
	//   221: iload #5
	//   223: istore_2
	//   224: aload_1
	//   225: ifnull -> 235
	//   228: aload_1
	//   229: invokevirtual close : ()V
	//   232: iload #5
	//   234: istore_2
	//   235: goto -> 71
	//   238: aload #6
	//   240: astore_1
	//   241: goto -> 112
	//   244: astore_1
	//   245: aload_3
	//   246: astore #6
	//   248: aload_0
	//   249: aconst_null
	//   250: putfield d : Lau;
	//   253: aload_3
	//   254: ifnull -> 516
	//   257: aload_3
	//   258: invokevirtual close : ()V
	//   261: iconst_0
	//   262: istore_2
	//   263: goto -> 235
	//   266: astore_1
	//   267: iconst_0
	//   268: istore_2
	//   269: goto -> 235
	//   272: astore_1
	//   273: aconst_null
	//   274: astore #6
	//   276: aload #6
	//   278: ifnull -> 286
	//   281: aload #6
	//   283: invokevirtual close : ()V
	//   286: aload_1
	//   287: athrow
	//   288: aload_1
	//   289: getfield f : [B
	//   292: ifnull -> 508
	//   295: aload_1
	//   296: getfield f : [B
	//   299: invokestatic a : ([B)Z
	//   302: ifeq -> 406
	//   305: new java/util/zip/GZIPInputStream
	//   308: astore #4
	//   310: aload #4
	//   312: aload #6
	//   314: invokespecial <init> : (Ljava/io/InputStream;)V
	//   317: aload #4
	//   319: astore_3
	//   320: aload_1
	//   321: getfield i : Ljava/lang/Object;
	//   324: checkcast [I
	//   327: astore #6
	//   329: new ax
	//   332: astore_1
	//   333: aload_1
	//   334: aload #6
	//   336: iconst_0
	//   337: iaload
	//   338: aload #6
	//   340: iconst_1
	//   341: iaload
	//   342: aload #6
	//   344: iconst_2
	//   345: iaload
	//   346: aload #6
	//   348: iconst_3
	//   349: iaload
	//   350: aload #6
	//   352: iconst_4
	//   353: iaload
	//   354: invokespecial <init> : (IIIII)V
	//   357: new java/io/InputStreamReader
	//   360: astore #6
	//   362: aload #6
	//   364: aload_3
	//   365: invokespecial <init> : (Ljava/io/InputStream;)V
	//   368: aload_1
	//   369: aload #6
	//   371: invokestatic a : (Lcd;Ljava/io/Reader;)V
	//   374: aload_0
	//   375: aload_1
	//   376: invokespecial a : (Lax;)V
	//   379: iconst_1
	//   380: istore #5
	//   382: iload #5
	//   384: istore_2
	//   385: aload_3
	//   386: ifnull -> 71
	//   389: aload_3
	//   390: invokevirtual close : ()V
	//   393: iload #5
	//   395: istore_2
	//   396: goto -> 71
	//   399: astore_1
	//   400: iload #5
	//   402: istore_2
	//   403: goto -> 71
	//   406: aload #6
	//   408: astore_3
	//   409: goto -> 320
	//   412: astore_1
	//   413: aload_3
	//   414: astore_1
	//   415: iload #5
	//   417: istore_2
	//   418: aload_1
	//   419: ifnull -> 71
	//   422: aload_1
	//   423: invokevirtual close : ()V
	//   426: iload #5
	//   428: istore_2
	//   429: goto -> 71
	//   432: astore_1
	//   433: iload #5
	//   435: istore_2
	//   436: goto -> 71
	//   439: astore_1
	//   440: aconst_null
	//   441: astore_3
	//   442: aload_3
	//   443: ifnull -> 450
	//   446: aload_3
	//   447: invokevirtual close : ()V
	//   450: aload_1
	//   451: athrow
	//   452: aload_0
	//   453: monitorenter
	//   454: aload_0
	//   455: getfield g : Ljava/util/ArrayList;
	//   458: invokevirtual clear : ()V
	//   461: aload_0
	//   462: monitorexit
	//   463: aload_0
	//   464: iconst_1
	//   465: invokevirtual c : (Z)V
	//   468: iload #5
	//   470: istore_2
	//   471: goto -> 71
	//   474: astore_1
	//   475: aload_0
	//   476: monitorexit
	//   477: aload_1
	//   478: athrow
	//   479: astore_1
	//   480: iload #5
	//   482: istore_2
	//   483: goto -> 235
	//   486: astore_3
	//   487: goto -> 286
	//   490: astore_3
	//   491: goto -> 450
	//   494: astore_1
	//   495: goto -> 442
	//   498: astore_1
	//   499: aload_3
	//   500: astore_1
	//   501: goto -> 415
	//   504: astore_1
	//   505: goto -> 276
	//   508: aconst_null
	//   509: astore_3
	//   510: iload_2
	//   511: istore #5
	//   513: goto -> 382
	//   516: iconst_0
	//   517: istore_2
	//   518: goto -> 235
	//   521: aconst_null
	//   522: astore_1
	//   523: iconst_0
	//   524: istore #5
	//   526: goto -> 221
	// Exception table:
	//   from	to	target	type
	//   76	83	244	java/lang/Throwable
	//   76	83	272	finally
	//   86	96	244	java/lang/Throwable
	//   86	96	272	finally
	//   99	103	244	java/lang/Throwable
	//   99	103	272	finally
	//   106	112	244	java/lang/Throwable
	//   106	112	272	finally
	//   117	122	244	java/lang/Throwable
	//   117	122	504	finally
	//   127	132	244	java/lang/Throwable
	//   127	132	504	finally
	//   137	143	244	java/lang/Throwable
	//   137	143	504	finally
	//   148	154	244	java/lang/Throwable
	//   148	154	504	finally
	//   159	164	244	java/lang/Throwable
	//   159	164	504	finally
	//   169	175	244	java/lang/Throwable
	//   169	175	504	finally
	//   180	187	244	java/lang/Throwable
	//   180	187	504	finally
	//   192	199	244	java/lang/Throwable
	//   192	199	504	finally
	//   204	218	244	java/lang/Throwable
	//   204	218	504	finally
	//   228	232	479	java/io/IOException
	//   248	253	504	finally
	//   257	261	266	java/io/IOException
	//   281	286	486	java/io/IOException
	//   288	317	412	java/lang/Throwable
	//   288	317	439	finally
	//   320	379	498	java/lang/Throwable
	//   320	379	494	finally
	//   389	393	399	java/io/IOException
	//   422	426	432	java/io/IOException
	//   446	450	490	java/io/IOException
	//   454	463	474	finally
  }

  public void onStartDownload(int paramInt)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\aw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */