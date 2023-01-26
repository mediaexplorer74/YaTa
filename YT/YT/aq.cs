using System;
using System.Threading;

using Bitmap = android.graphics.Bitmap;
using Canvas = android.graphics.Canvas;
using Matrix = android.graphics.Matrix;
using Paint = android.graphics.Paint;
using PointF = android.graphics.PointF;
using Rect = android.graphics.Rect;
using RectF = android.graphics.RectF;
using MapController = ru.yandex.yandexmapkit.MapController;
using MapLayer = ru.yandex.yandexmapkit.map.MapLayer;

public sealed class aq : ThreadStart
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static Bitmap a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static Bitmap b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static readonly sbyte[] c_Conflict = new sbyte[] {15, 15, 15};

  private static aq t;

  private readonly object A;

  private int B;

  private double C;

  private double D;

  private Rect E;

  private RectF F;

  private am[] G;

  private int H;

  private int I;

  private Thread J;

  private readonly Paint K;

  private int L;

  private bool M;

  private long N;

  private float O = -1.0F;

  private bool P;

  private readonly Matrix Q;

  private double R;

  private double S;

  private bool T;

  private float U;

  private float V;

  private float W;

  private float X;

  private float Y;

  private float Z;

  private int aa;

  private int ab;

  private bool ac;

  private readonly Paint ad;

  private float ae = 1.0F;

  private int af = 128;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public readonly MapController.Map d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int f_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int h_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int i_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int j_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int k_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private float l_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private float m_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int n_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int o_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private am[] p_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private am[] q_Conflict;

  private bg[] r;

  private readonly ap s;

  private MapController u;

  private bool v;

  private bool w;

  private am[] x = new am[50];

  private int y;

  private int z;

  public aq(MapController paramMapController, MapController.Map paramMap, ap paramap)
  {
	new Paint();
	this.ad = new Paint(2);
	this.K = new Paint(2);
	this.K.setAntiAlias(false);
	this.u = paramMapController;
	this.M = false;
	this.P = false;
	this.L = 0;
	this.p_Conflict = new am[1];
	this.q_Conflict = new am[1];
	this.G = null;
	this.r = new bg[1];
	this.z = 0;
	this.y = 0;
	this.A = new object();
	int j = (int)(e() * d());
	this.E = new Rect(0, 0, j, j);
	this.F = new RectF();
	this.s = paramap;
	this.d_Conflict = paramMap;
	b();
	a(1.0F);
	this.Q = new Matrix();
	lock (this.u.d_Conflict)
	{
	  if (this.u.d_Conflict.Count > 0)
	  {
		i_Conflict = ((MapLayer)this.u.d_Conflict[0]).layerId;
	  }
	  this.n_Conflict = i_Conflict;
	  t = this;
	  this.w = false;
	  return;
	}
  }

  public static void a(aq paramaq)
  {
	t = paramaq;
  }

  private bool a(am paramam, aw paramaw, bool paramBoolean)
  {
	bool bool1 = false;
	bool bool2 = bool1;
	if (b.a(paramam.i, paramam.j, paramam.zoom))
	{
	  bool @bool;
	  if (paramam.k == 0 || ((paramam.k == 5 || paramam.k == 3 || paramam.k == 4) && paramam.h == 0 && paramam.w && !paramBoolean))
	  {
		this.s.b(paramam);
	  }
	  if (paramam.f_Conflict != null)
	  {
		@bool = true;
	  }
	  else
	  {
		@bool = false;
	  }
	  if (!paramam.d_Conflict && (paramam.v || (paramam.f_Conflict == null && (paramam.k == 3 || paramam.k == 5)) || (this.P && paramam.h == 0 && (paramam.g & 0x4) != 4) || av.a(paramaw, paramam, true)))
	  {
		a(paramam);
	  }
	  bool2 = bool1;
	  if (@bool)
	  {
		bool2 = bool1;
		if (paramam.f_Conflict == null)
		{
		  bool2 = true;
		}
	  }
	}
	return bool2;
  }

  public static aq i()
  {
	return t;
  }

  private bool p()
  {
	lock (this.A)
	{
	  if (this.z != this.y || this.x[this.y] != null)
	  {
		return true;
	  }
	  return false;
	}
  }

  private am q()
  {
	lock (this.A)
	{
	  return this.x[this.y];
	}
  }

  public by a(float paramFloat1, float paramFloat2, by paramby)
  {
	by by1 = paramby;
	if (paramby == null)
	{
	  by1 = new by();
	}
	by1.x = (long)(paramFloat1 * Math.Pow(2.0D, (23.0F - this.Z)));
	by1.y = (long)(paramFloat2 * Math.Pow(2.0D, (23.0F - this.Z)));
	return by1;
  }

  public void a()
  {
	this.v = false;
	this.J = new Thread(this);
	this.J.setName("ymm-img-creator");
	this.J.Start();
  }

  public void a(float paramFloat)
  {
	this.ae = paramFloat;
	b();
	int i = (int)(e() * d());
	this.E = new Rect(0, 0, i, i);
	ap.a(paramFloat);
  }

  public void a(int paramInt)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: iload_1
	//   4: putfield n : I
	//   7: aload_0
	//   8: monitorexit
	//   9: return
	//   10: astore_2
	//   11: aload_0
	//   12: monitorexit
	//   13: aload_2
	//   14: athrow
	// Exception table:
	//   from	to	target	type
	//   2	7	10	finally
  }

  public void a(int paramInt1, int paramInt2)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: iload_1
	//   4: putfield e : I
	//   7: aload_0
	//   8: iload_2
	//   9: putfield f : I
	//   12: aload_0
	//   13: aload_0
	//   14: getfield e : I
	//   17: aload_0
	//   18: getfield e : I
	//   21: imul
	//   22: aload_0
	//   23: getfield f : I
	//   26: aload_0
	//   27: getfield f : I
	//   30: imul
	//   31: iadd
	//   32: i2d
	//   33: invokestatic sqrt : (D)D
	//   36: invokestatic round : (D)J
	//   39: l2i
	//   40: putfield g : I
	//   43: aload_0
	//   44: iload_1
	//   45: bipush #7
	//   47: iushr
	//   48: iconst_1
	//   49: iadd
	//   50: putfield h : I
	//   53: iload_1
	//   54: bipush #127
	//   56: iand
	//   57: ifle -> 70
	//   60: aload_0
	//   61: aload_0
	//   62: getfield h : I
	//   65: iconst_1
	//   66: iadd
	//   67: putfield h : I
	//   70: aload_0
	//   71: iload_2
	//   72: bipush #7
	//   74: iushr
	//   75: iconst_1
	//   76: iadd
	//   77: putfield i : I
	//   80: iload_2
	//   81: bipush #127
	//   83: iand
	//   84: ifle -> 97
	//   87: aload_0
	//   88: aload_0
	//   89: getfield i : I
	//   92: iconst_1
	//   93: iadd
	//   94: putfield i : I
	//   97: aload_0
	//   98: aload_0
	//   99: getfield g : I
	//   102: bipush #7
	//   104: iushr
	//   105: iconst_1
	//   106: iadd
	//   107: putfield k : I
	//   110: aload_0
	//   111: aload_0
	//   112: getfield k : I
	//   115: iconst_1
	//   116: iadd
	//   117: putfield k : I
	//   120: aload_0
	//   121: getfield g : I
	//   124: bipush #127
	//   126: iand
	//   127: ifle -> 140
	//   130: aload_0
	//   131: aload_0
	//   132: getfield k : I
	//   135: iconst_1
	//   136: iadd
	//   137: putfield k : I
	//   140: aload_0
	//   141: aload_0
	//   142: getfield h : I
	//   145: aload_0
	//   146: getfield i : I
	//   149: invokestatic max : (II)I
	//   152: putfield j : I
	//   155: aload_0
	//   156: getfield p : [Lam;
	//   159: ifnonnull -> 178
	//   162: aload_0
	//   163: aload_0
	//   164: getfield k : I
	//   167: aload_0
	//   168: getfield k : I
	//   171: imul
	//   172: anewarray am
	//   175: putfield p : [Lam;
	//   178: aload_0
	//   179: aload_0
	//   180: getfield k : I
	//   183: aload_0
	//   184: getfield k : I
	//   187: imul
	//   188: anewarray am
	//   191: putfield q : [Lam;
	//   194: aload_0
	//   195: aload_0
	//   196: getfield k : I
	//   199: aload_0
	//   200: getfield k : I
	//   203: imul
	//   204: anewarray bg
	//   207: putfield r : [Lbg;
	//   210: aload_0
	//   211: getfield A : Ljava/lang/Object;
	//   214: astore_3
	//   215: aload_3
	//   216: monitorenter
	//   217: aload_0
	//   218: getfield k : I
	//   221: aload_0
	//   222: getfield k : I
	//   225: imul
	//   226: iconst_2
	//   227: ishl
	//   228: aload_0
	//   229: getfield x : [Lam;
	//   232: arraylength
	//   233: if_icmple -> 264
	//   236: aload_0
	//   237: aload_0
	//   238: getfield k : I
	//   241: aload_0
	//   242: getfield k : I
	//   245: imul
	//   246: iconst_2
	//   247: ishl
	//   248: anewarray am
	//   251: putfield x : [Lam;
	//   254: aload_0
	//   255: iconst_0
	//   256: putfield z : I
	//   259: aload_0
	//   260: iconst_0
	//   261: putfield y : I
	//   264: aload_3
	//   265: monitorexit
	//   266: aload_0
	//   267: iconst_1
	//   268: putfield w : Z
	//   271: aload_0
	//   272: invokevirtual f : ()Z
	//   275: pop
	//   276: aload_0
	//   277: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   280: invokevirtual notifyRepaint : ()V
	//   283: aload_0
	//   284: monitorexit
	//   285: return
	//   286: astore #4
	//   288: aload_3
	//   289: monitorexit
	//   290: aload #4
	//   292: athrow
	//   293: astore_3
	//   294: aload_0
	//   295: monitorexit
	//   296: aload_3
	//   297: athrow
	// Exception table:
	//   from	to	target	type
	//   2	53	293	finally
	//   60	70	293	finally
	//   70	80	293	finally
	//   87	97	293	finally
	//   97	140	293	finally
	//   140	178	293	finally
	//   178	217	293	finally
	//   217	264	286	finally
	//   264	266	286	finally
	//   266	283	293	finally
	//   288	293	293	finally
  }

  public void a(am paramam)
  {
	lock (this.A)
	{
	  int i = this.z;
	  am[] arrayOfAm = this.x;
	  int j = this.x.Length;
	  int k;
	  for (k = this.y; k != i; k = m_Conflict + 1)
	  {
		int m;
		if (k == j)
		{
		  m = -1;
		}
		else
		{
		  m = k;
		  if (paramam == arrayOfAm[k])
		  {
			return;
		  }
		}
	  }
	  k = i + 1;
	  arrayOfAm[i] = paramam;
	  if (k == j)
	  {
		this.z = 0;
	  }
	  else
	  {
		this.z = k;
	  }
	  Monitor.PulseAll(this.A);
	  return;
	}
  }

  public void a(Canvas paramCanvas)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield w : Z
	//   6: ifeq -> 427
	//   9: aload_0
	//   10: getfield T : Z
	//   13: ifeq -> 185
	//   16: aload_1
	//   17: iconst_m1
	//   18: invokevirtual drawColor : (I)V
	//   21: aload_0
	//   22: getfield L : I
	//   25: ifeq -> 427
	//   28: aload_0
	//   29: getfield U : F
	//   32: fstore_2
	//   33: aload_0
	//   34: getfield V : F
	//   37: fstore_3
	//   38: aload_0
	//   39: getfield F : Landroid/graphics/RectF;
	//   42: astore #4
	//   44: iconst_0
	//   45: istore #5
	//   47: iconst_0
	//   48: istore #6
	//   50: iload #5
	//   52: aload_0
	//   53: getfield I : I
	//   56: if_icmpge -> 427
	//   59: iconst_0
	//   60: istore #7
	//   62: iload #7
	//   64: aload_0
	//   65: getfield H : I
	//   68: if_icmpge -> 405
	//   71: aload_0
	//   72: getfield G : [Lam;
	//   75: iload #6
	//   77: aaload
	//   78: astore #8
	//   80: aload #8
	//   82: ifnull -> 169
	//   85: aload #8
	//   87: getfield f : Landroid/graphics/Bitmap;
	//   90: ifnull -> 169
	//   93: aload #4
	//   95: fload_3
	//   96: putfield top : F
	//   99: aload #4
	//   101: fload_2
	//   102: putfield left : F
	//   105: aload #4
	//   107: aload #4
	//   109: getfield top : F
	//   112: aload_0
	//   113: getfield W : F
	//   116: fadd
	//   117: putfield bottom : F
	//   120: aload #4
	//   122: aload #4
	//   124: getfield left : F
	//   127: aload_0
	//   128: getfield W : F
	//   131: fadd
	//   132: putfield right : F
	//   135: aload #8
	//   137: iconst_1
	//   138: putfield w : Z
	//   141: aload_0
	//   142: getfield s : Lap;
	//   145: aload #8
	//   147: invokevirtual a : (Lam;)V
	//   150: aload_1
	//   151: aload #8
	//   153: getfield f : Landroid/graphics/Bitmap;
	//   156: aload_0
	//   157: getfield E : Landroid/graphics/Rect;
	//   160: aload #4
	//   162: aload_0
	//   163: getfield K : Landroid/graphics/Paint;
	//   166: invokevirtual drawBitmap : (Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V
	//   169: iinc #6, 1
	//   172: iinc #7, 1
	//   175: fload_2
	//   176: aload_0
	//   177: getfield W : F
	//   180: fadd
	//   181: fstore_2
	//   182: goto -> 62
	//   185: aload_0
	//   186: getfield l : F
	//   189: fstore_2
	//   190: aload_0
	//   191: getfield m : F
	//   194: fstore_3
	//   195: aload_0
	//   196: getfield j : I
	//   199: istore #9
	//   201: aload_0
	//   202: getfield k : I
	//   205: istore #10
	//   207: aload_0
	//   208: getfield p : [Lam;
	//   211: astore #8
	//   213: aload_0
	//   214: getfield F : Landroid/graphics/RectF;
	//   217: astore #11
	//   219: iconst_0
	//   220: istore #5
	//   222: iconst_0
	//   223: istore #6
	//   225: iload #5
	//   227: iload #10
	//   229: if_icmpge -> 21
	//   232: iconst_0
	//   233: istore #7
	//   235: iload #7
	//   237: iload #9
	//   239: if_icmpge -> 383
	//   242: aload #8
	//   244: iload #6
	//   246: aaload
	//   247: astore #4
	//   249: aload #11
	//   251: fload_3
	//   252: putfield top : F
	//   255: aload #11
	//   257: fload_2
	//   258: putfield left : F
	//   261: aload #11
	//   263: aload #11
	//   265: getfield top : F
	//   268: aload_0
	//   269: getfield X : F
	//   272: fadd
	//   273: putfield bottom : F
	//   276: aload #11
	//   278: aload #11
	//   280: getfield left : F
	//   283: aload_0
	//   284: getfield X : F
	//   287: fadd
	//   288: putfield right : F
	//   291: aload #4
	//   293: ifnull -> 358
	//   296: aload #4
	//   298: getfield f : Landroid/graphics/Bitmap;
	//   301: ifnull -> 358
	//   304: aload #4
	//   306: getfield w : Z
	//   309: ifne -> 323
	//   312: aload #4
	//   314: getfield f : Landroid/graphics/Bitmap;
	//   317: getstatic aq.b : Landroid/graphics/Bitmap;
	//   320: if_acmpne -> 358
	//   323: aload_1
	//   324: aload #4
	//   326: getfield f : Landroid/graphics/Bitmap;
	//   329: aload_0
	//   330: getfield E : Landroid/graphics/Rect;
	//   333: aload #11
	//   335: aload_0
	//   336: getfield ad : Landroid/graphics/Paint;
	//   339: invokevirtual drawBitmap : (Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V
	//   342: iinc #6, 1
	//   345: iinc #7, 1
	//   348: fload_2
	//   349: aload_0
	//   350: getfield X : F
	//   353: fadd
	//   354: fstore_2
	//   355: goto -> 235
	//   358: aload_1
	//   359: getstatic aq.a : Landroid/graphics/Bitmap;
	//   362: aload_0
	//   363: getfield E : Landroid/graphics/Rect;
	//   366: aload #11
	//   368: aload_0
	//   369: getfield ad : Landroid/graphics/Paint;
	//   372: invokevirtual drawBitmap : (Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V
	//   375: goto -> 342
	//   378: astore_1
	//   379: aload_0
	//   380: monitorexit
	//   381: aload_1
	//   382: athrow
	//   383: aload_0
	//   384: getfield l : F
	//   387: fstore_2
	//   388: aload_0
	//   389: getfield X : F
	//   392: fstore #12
	//   394: iinc #5, 1
	//   397: fload #12
	//   399: fload_3
	//   400: fadd
	//   401: fstore_3
	//   402: goto -> 225
	//   405: aload_0
	//   406: getfield U : F
	//   409: fstore_2
	//   410: aload_0
	//   411: getfield W : F
	//   414: fstore #12
	//   416: iinc #5, 1
	//   419: fload #12
	//   421: fload_3
	//   422: fadd
	//   423: fstore_3
	//   424: goto -> 50
	//   427: aload_0
	//   428: monitorexit
	//   429: return
	// Exception table:
	//   from	to	target	type
	//   2	21	378	finally
	//   21	44	378	finally
	//   50	59	378	finally
	//   62	80	378	finally
	//   85	169	378	finally
	//   175	182	378	finally
	//   185	219	378	finally
	//   249	291	378	finally
	//   296	323	378	finally
	//   323	342	378	finally
	//   348	355	378	finally
	//   358	375	378	finally
	//   383	394	378	finally
	//   405	416	378	finally
  }

  public void b()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   6: invokevirtual getContext : ()Landroid/content/Context;
	//   9: invokevirtual getResources : ()Landroid/content/res/Resources;
	//   12: astore_1
	//   13: aload_0
	//   14: invokevirtual e : ()I
	//   17: i2f
	//   18: aload_0
	//   19: invokevirtual d : ()F
	//   22: fmul
	//   23: f2i
	//   24: istore_2
	//   25: aload_1
	//   26: aload_1
	//   27: ldc_w 'empty_image'
	//   30: ldc_w 'drawable'
	//   33: aload_0
	//   34: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   37: invokevirtual getContext : ()Landroid/content/Context;
	//   40: invokevirtual getPackageName : ()Ljava/lang/String;
	//   43: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
	//   46: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   49: invokestatic decodeResource : (Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;
	//   52: iload_2
	//   53: iload_2
	//   54: iconst_1
	//   55: invokestatic createScaledBitmap : (Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;
	//   58: astore_3
	//   59: aload_3
	//   60: putstatic aq.a : Landroid/graphics/Bitmap;
	//   63: aload_3
	//   64: invokevirtual getConfig : ()Landroid/graphics/Bitmap$Config;
	//   67: ifnonnull -> 83
	//   70: getstatic aq.a : Landroid/graphics/Bitmap;
	//   73: getstatic android/graphics/Bitmap$Config.RGB_565 : Landroid/graphics/Bitmap$Config;
	//   76: iconst_0
	//   77: invokevirtual copy : (Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;
	//   80: putstatic aq.a : Landroid/graphics/Bitmap;
	//   83: aload_1
	//   84: aload_1
	//   85: ldc_w 'no_map_image'
	//   88: ldc_w 'drawable'
	//   91: aload_0
	//   92: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   95: invokevirtual getContext : ()Landroid/content/Context;
	//   98: invokevirtual getPackageName : ()Ljava/lang/String;
	//   101: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
	//   104: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   107: invokestatic decodeResource : (Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;
	//   110: iload_2
	//   111: iload_2
	//   112: iconst_1
	//   113: invokestatic createScaledBitmap : (Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;
	//   116: astore_1
	//   117: aload_1
	//   118: putstatic aq.b : Landroid/graphics/Bitmap;
	//   121: aload_1
	//   122: invokevirtual getConfig : ()Landroid/graphics/Bitmap$Config;
	//   125: ifnonnull -> 141
	//   128: getstatic aq.b : Landroid/graphics/Bitmap;
	//   131: getstatic android/graphics/Bitmap$Config.RGB_565 : Landroid/graphics/Bitmap$Config;
	//   134: iconst_0
	//   135: invokevirtual copy : (Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;
	//   138: putstatic aq.b : Landroid/graphics/Bitmap;
	//   141: getstatic ap.a : Lam;
	//   144: ifnull -> 156
	//   147: getstatic ap.a : Lam;
	//   150: getstatic aq.b : Landroid/graphics/Bitmap;
	//   153: putfield f : Landroid/graphics/Bitmap;
	//   156: aload_0
	//   157: monitorexit
	//   158: return
	//   159: astore_1
	//   160: aload_0
	//   161: monitorexit
	//   162: aload_1
	//   163: athrow
	// Exception table:
	//   from	to	target	type
	//   2	83	159	finally
	//   83	141	159	finally
	//   141	156	159	finally
  }

  public bool b(int paramInt1, int paramInt2)
  {
	if (paramInt1 < 0 || paramInt2 < 0)
	{
	  return false;
	}
	if (this.v)
	{
	  return false;
	}
	int i = this.aa;
	int j = this.B;
	int k = this.ab;
	int m = this.B;
	int n = this.e_Conflict;
	int i1 = this.f_Conflict;
	for (sbyte b = 0; b < 2; b++)
	{
	  for (sbyte b1 = 0; b1 < 2; b1++)
	  {
		if (this.v)
		{
		  return false;
		}
		PointF pointF = this.u.e().c(((b << 7) + (paramInt1 << 7) - (i >> j) - (n >> 1)), ((b1 << 7) + (paramInt2 << 7) - (k >> m) - (i1 >> 1)));
		if (b.a(-64, -64, this.e_Conflict + 128, this.f_Conflict + 128, (long)Math.Round(pointF.x, MidpointRounding.AwayFromZero), (long)Math.Round(pointF.y, MidpointRounding.AwayFromZero)))
		{
		  return true;
		}
	  }
	}
	return false;
  }

  public int c()
  {
	return this.B;
  }

  public float d()
  {
	return this.ae;
  }

  public int e()
  {
	return this.af;
  }

  public bool f()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: iconst_0
	//   3: istore_1
	//   4: iconst_0
	//   5: istore_2
	//   6: iload_2
	//   7: istore_3
	//   8: aload_0
	//   9: getfield w : Z
	//   12: ifeq -> 297
	//   15: aload_0
	//   16: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   19: astore #4
	//   21: aload #4
	//   23: monitorenter
	//   24: aload_0
	//   25: aload_0
	//   26: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   29: invokevirtual k : ()I
	//   32: putfield o : I
	//   35: aload_0
	//   36: aload_0
	//   37: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   40: invokevirtual m : ()I
	//   43: putfield aa : I
	//   46: aload_0
	//   47: aload_0
	//   48: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   51: invokevirtual n : ()I
	//   54: putfield ab : I
	//   57: aload_0
	//   58: aload_0
	//   59: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   62: invokevirtual e : ()Z
	//   65: putfield T : Z
	//   68: aload_0
	//   69: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   72: invokevirtual f : ()F
	//   75: fstore #5
	//   77: aload_0
	//   78: aload_0
	//   79: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   82: invokevirtual i : ()Z
	//   85: putfield ac : Z
	//   88: aload_0
	//   89: aload_0
	//   90: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   93: invokevirtual j : ()F
	//   96: putfield Z : F
	//   99: aload #4
	//   101: monitorexit
	//   102: aload_0
	//   103: bipush #23
	//   105: aload_0
	//   106: getfield o : I
	//   109: isub
	//   110: putfield B : I
	//   113: aload_0
	//   114: getfield L : I
	//   117: ifne -> 127
	//   120: aload_0
	//   121: getfield T : Z
	//   124: ifeq -> 247
	//   127: ldc2_w 2.0
	//   130: fload #5
	//   132: f2d
	//   133: invokestatic pow : (DD)D
	//   136: d2f
	//   137: fstore #6
	//   139: aload_0
	//   140: aload_0
	//   141: getfield Y : F
	//   144: fload #6
	//   146: fmul
	//   147: putfield W : F
	//   150: ldc2_w 2.0
	//   153: ldc 23.0
	//   155: aload_0
	//   156: getfield O : F
	//   159: fsub
	//   160: f2d
	//   161: invokestatic pow : (DD)D
	//   164: d2f
	//   165: fstore #7
	//   167: aload_0
	//   168: getfield aa : I
	//   171: i2d
	//   172: aload_0
	//   173: invokevirtual d : ()F
	//   176: f2d
	//   177: dmul
	//   178: aload_0
	//   179: getfield R : D
	//   182: dsub
	//   183: fload #7
	//   185: f2d
	//   186: ddiv
	//   187: d2f
	//   188: fstore #8
	//   190: aload_0
	//   191: getfield ab : I
	//   194: i2d
	//   195: aload_0
	//   196: invokevirtual d : ()F
	//   199: f2d
	//   200: dmul
	//   201: aload_0
	//   202: getfield S : D
	//   205: dsub
	//   206: fload #7
	//   208: f2d
	//   209: ddiv
	//   210: d2f
	//   211: fstore #7
	//   213: aload_0
	//   214: aload_0
	//   215: getfield e : I
	//   218: iconst_1
	//   219: ishr
	//   220: i2f
	//   221: fload #8
	//   223: fload #6
	//   225: fmul
	//   226: fsub
	//   227: putfield U : F
	//   230: aload_0
	//   231: aload_0
	//   232: getfield f : I
	//   235: iconst_1
	//   236: ishr
	//   237: i2f
	//   238: fload #6
	//   240: fload #7
	//   242: fmul
	//   243: fsub
	//   244: putfield V : F
	//   247: aload_0
	//   248: getfield T : Z
	//   251: ifeq -> 322
	//   254: aload_0
	//   255: getfield K : Landroid/graphics/Paint;
	//   258: sipush #255
	//   261: invokevirtual setAlpha : (I)V
	//   264: aload_0
	//   265: getfield K : Landroid/graphics/Paint;
	//   268: iconst_1
	//   269: invokevirtual setFilterBitmap : (Z)V
	//   272: fload #5
	//   274: ldc_w 0.1
	//   277: fcmpl
	//   278: ifle -> 316
	//   281: iconst_2
	//   282: istore #9
	//   284: aload_0
	//   285: iload #9
	//   287: putfield L : I
	//   290: aload_0
	//   291: iconst_1
	//   292: putfield M : Z
	//   295: iload_2
	//   296: istore_3
	//   297: aload_0
	//   298: monitorexit
	//   299: iload_3
	//   300: ireturn
	//   301: astore #10
	//   303: aload #4
	//   305: monitorexit
	//   306: aload #10
	//   308: athrow
	//   309: astore #4
	//   311: aload_0
	//   312: monitorexit
	//   313: aload #4
	//   315: athrow
	//   316: iconst_1
	//   317: istore #9
	//   319: goto -> 284
	//   322: aload_0
	//   323: getfield M : Z
	//   326: ifeq -> 1109
	//   329: aload_0
	//   330: iconst_0
	//   331: putfield M : Z
	//   334: aload_0
	//   335: getfield L : I
	//   338: iconst_2
	//   339: if_icmpne -> 1021
	//   342: iconst_1
	//   343: istore #9
	//   345: iload #9
	//   347: ifeq -> 1027
	//   350: aload_0
	//   351: iconst_1
	//   352: putfield P : Z
	//   355: aload_0
	//   356: invokestatic currentTimeMillis : ()J
	//   359: putfield N : J
	//   362: ldc2_w 2.0
	//   365: ldc 23.0
	//   367: aload_0
	//   368: getfield Z : F
	//   371: fsub
	//   372: f2d
	//   373: invokestatic pow : (DD)D
	//   376: d2f
	//   377: fstore #5
	//   379: aload_0
	//   380: aload_0
	//   381: getfield aa : I
	//   384: i2d
	//   385: aload_0
	//   386: invokevirtual d : ()F
	//   389: f2d
	//   390: dmul
	//   391: fload #5
	//   393: f2d
	//   394: ddiv
	//   395: putfield C : D
	//   398: aload_0
	//   399: aload_0
	//   400: getfield ab : I
	//   403: i2d
	//   404: aload_0
	//   405: invokevirtual d : ()F
	//   408: f2d
	//   409: dmul
	//   410: fload #5
	//   412: f2d
	//   413: ddiv
	//   414: putfield D : D
	//   417: aload_0
	//   418: invokevirtual e : ()I
	//   421: i2f
	//   422: aload_0
	//   423: invokevirtual d : ()F
	//   426: fmul
	//   427: fstore #5
	//   429: aload_0
	//   430: fload #5
	//   432: f2d
	//   433: ldc2_w 2.0
	//   436: aload_0
	//   437: getfield Z : F
	//   440: aload_0
	//   441: getfield o : I
	//   444: i2f
	//   445: fsub
	//   446: f2d
	//   447: invokestatic pow : (DD)D
	//   450: dmul
	//   451: d2f
	//   452: putfield X : F
	//   455: aload_0
	//   456: getfield C : D
	//   459: aload_0
	//   460: getfield e : I
	//   463: iconst_1
	//   464: ishr
	//   465: i2d
	//   466: dsub
	//   467: dstore #11
	//   469: aload_0
	//   470: getfield D : D
	//   473: aload_0
	//   474: getfield f : I
	//   477: iconst_1
	//   478: ishr
	//   479: i2d
	//   480: dsub
	//   481: dstore #13
	//   483: aload_0
	//   484: getfield v : Z
	//   487: ifne -> 1369
	//   490: aload_0
	//   491: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   494: invokevirtual e : ()Lah;
	//   497: invokevirtual b : ()F
	//   500: fconst_0
	//   501: fcmpl
	//   502: ifeq -> 1369
	//   505: aload_0
	//   506: getfield e : I
	//   509: i2d
	//   510: dload #11
	//   512: dadd
	//   513: d2f
	//   514: fstore #15
	//   516: aload_0
	//   517: getfield f : I
	//   520: i2d
	//   521: dload #13
	//   523: dadd
	//   524: d2f
	//   525: fstore #6
	//   527: dload #11
	//   529: d2f
	//   530: aload_0
	//   531: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   534: invokevirtual e : ()Lah;
	//   537: invokevirtual e : ()F
	//   540: fadd
	//   541: fstore #7
	//   543: dload #13
	//   545: d2f
	//   546: aload_0
	//   547: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   550: invokevirtual e : ()Lah;
	//   553: invokevirtual f : ()F
	//   556: fadd
	//   557: fstore #8
	//   559: aload_0
	//   560: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   563: invokevirtual e : ()Lah;
	//   566: dload #11
	//   568: d2f
	//   569: dload #13
	//   571: d2f
	//   572: fload #7
	//   574: fload #8
	//   576: invokevirtual a : (FFFF)Landroid/graphics/PointF;
	//   579: astore #4
	//   581: aload_0
	//   582: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   585: invokevirtual e : ()Lah;
	//   588: fload #15
	//   590: dload #13
	//   592: d2f
	//   593: fload #7
	//   595: fload #8
	//   597: invokevirtual a : (FFFF)Landroid/graphics/PointF;
	//   600: astore #16
	//   602: aload_0
	//   603: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   606: invokevirtual e : ()Lah;
	//   609: dload #11
	//   611: d2f
	//   612: fload #6
	//   614: fload #7
	//   616: fload #8
	//   618: invokevirtual a : (FFFF)Landroid/graphics/PointF;
	//   621: astore #17
	//   623: aload_0
	//   624: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   627: invokevirtual e : ()Lah;
	//   630: fload #15
	//   632: fload #6
	//   634: fload #7
	//   636: fload #8
	//   638: invokevirtual a : (FFFF)Landroid/graphics/PointF;
	//   641: astore #10
	//   643: aload #4
	//   645: getfield x : F
	//   648: aload #16
	//   650: getfield x : F
	//   653: invokestatic min : (FF)F
	//   656: aload #17
	//   658: getfield x : F
	//   661: aload #10
	//   663: getfield x : F
	//   666: invokestatic min : (FF)F
	//   669: invokestatic min : (FF)F
	//   672: invokestatic round : (F)I
	//   675: i2d
	//   676: dstore #11
	//   678: aload #4
	//   680: getfield x : F
	//   683: aload #16
	//   685: getfield x : F
	//   688: invokestatic max : (FF)F
	//   691: aload #17
	//   693: getfield x : F
	//   696: aload #10
	//   698: getfield x : F
	//   701: invokestatic max : (FF)F
	//   704: invokestatic max : (FF)F
	//   707: invokestatic round : (F)I
	//   710: i2f
	//   711: fstore #6
	//   713: aload #4
	//   715: getfield y : F
	//   718: aload #16
	//   720: getfield y : F
	//   723: invokestatic min : (FF)F
	//   726: aload #17
	//   728: getfield y : F
	//   731: aload #10
	//   733: getfield y : F
	//   736: invokestatic min : (FF)F
	//   739: invokestatic min : (FF)F
	//   742: invokestatic round : (F)I
	//   745: i2d
	//   746: dstore #13
	//   748: aload #4
	//   750: getfield y : F
	//   753: aload #16
	//   755: getfield y : F
	//   758: invokestatic max : (FF)F
	//   761: aload #17
	//   763: getfield y : F
	//   766: aload #10
	//   768: getfield y : F
	//   771: invokestatic max : (FF)F
	//   774: invokestatic max : (FF)F
	//   777: invokestatic round : (F)I
	//   780: i2f
	//   781: fstore #8
	//   783: aload_0
	//   784: aload_0
	//   785: getfield e : I
	//   788: iconst_1
	//   789: ishr
	//   790: i2d
	//   791: aload_0
	//   792: getfield C : D
	//   795: dload #11
	//   797: dsub
	//   798: dsub
	//   799: dload #11
	//   801: aload_0
	//   802: getfield X : F
	//   805: f2d
	//   806: drem
	//   807: dsub
	//   808: d2f
	//   809: putfield l : F
	//   812: aload_0
	//   813: aload_0
	//   814: getfield f : I
	//   817: iconst_1
	//   818: ishr
	//   819: i2d
	//   820: aload_0
	//   821: getfield D : D
	//   824: dload #13
	//   826: dsub
	//   827: dsub
	//   828: dload #13
	//   830: aload_0
	//   831: getfield X : F
	//   834: f2d
	//   835: drem
	//   836: dsub
	//   837: d2f
	//   838: putfield m : F
	//   841: aload_0
	//   842: getfield e : I
	//   845: iconst_1
	//   846: ishr
	//   847: i2d
	//   848: fload #6
	//   850: f2d
	//   851: aload_0
	//   852: getfield C : D
	//   855: dsub
	//   856: dadd
	//   857: fload #6
	//   859: aload_0
	//   860: getfield X : F
	//   863: frem
	//   864: f2d
	//   865: dadd
	//   866: d2f
	//   867: fstore #6
	//   869: aload_0
	//   870: getfield f : I
	//   873: iconst_1
	//   874: ishr
	//   875: i2d
	//   876: fload #8
	//   878: f2d
	//   879: aload_0
	//   880: getfield D : D
	//   883: dsub
	//   884: dadd
	//   885: fload #8
	//   887: aload_0
	//   888: getfield X : F
	//   891: frem
	//   892: f2d
	//   893: dadd
	//   894: d2f
	//   895: fstore #8
	//   897: aload_0
	//   898: fload #6
	//   900: aload_0
	//   901: getfield l : F
	//   904: fsub
	//   905: fload #5
	//   907: fdiv
	//   908: f2d
	//   909: invokestatic ceil : (D)D
	//   912: d2i
	//   913: putfield j : I
	//   916: aload_0
	//   917: fload #8
	//   919: aload_0
	//   920: getfield m : F
	//   923: fsub
	//   924: fload #5
	//   926: fdiv
	//   927: f2d
	//   928: invokestatic ceil : (D)D
	//   931: d2i
	//   932: putfield k : I
	//   935: dload #11
	//   937: aload_0
	//   938: getfield X : F
	//   941: f2d
	//   942: ddiv
	//   943: d2i
	//   944: istore #18
	//   946: dload #11
	//   948: dconst_0
	//   949: dcmpg
	//   950: ifge -> 1494
	//   953: iconst_1
	//   954: istore #9
	//   956: iload #18
	//   958: iload #9
	//   960: isub
	//   961: istore #9
	//   963: dload #13
	//   965: aload_0
	//   966: getfield X : F
	//   969: f2d
	//   970: ddiv
	//   971: d2i
	//   972: istore #19
	//   974: dload #13
	//   976: dconst_0
	//   977: dcmpg
	//   978: ifge -> 1500
	//   981: iconst_1
	//   982: istore #18
	//   984: iload #19
	//   986: iload #18
	//   988: isub
	//   989: istore #19
	//   991: iload #9
	//   993: aload_0
	//   994: getfield j : I
	//   997: iadd
	//   998: istore #20
	//   1000: iload #19
	//   1002: aload_0
	//   1003: getfield k : I
	//   1006: iadd
	//   1007: istore #21
	//   1009: aload_0
	//   1010: getfield s : Lap;
	//   1013: ifnonnull -> 1506
	//   1016: iconst_0
	//   1017: istore_3
	//   1018: goto -> 297
	//   1021: iconst_0
	//   1022: istore #9
	//   1024: goto -> 345
	//   1027: aload_0
	//   1028: iconst_0
	//   1029: putfield P : Z
	//   1032: aload_0
	//   1033: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   1036: invokevirtual f : ()F
	//   1039: ldc_w -0.1
	//   1042: fcmpl
	//   1043: ifle -> 362
	//   1046: aload_0
	//   1047: getfield G : [Lam;
	//   1050: ifnull -> 1101
	//   1053: aload_0
	//   1054: getfield G : [Lam;
	//   1057: arraylength
	//   1058: iconst_1
	//   1059: isub
	//   1060: istore #9
	//   1062: iload #9
	//   1064: iflt -> 1101
	//   1067: aload_0
	//   1068: getfield G : [Lam;
	//   1071: iload #9
	//   1073: aaload
	//   1074: astore #4
	//   1076: aload #4
	//   1078: ifnull -> 1095
	//   1081: aload #4
	//   1083: iconst_0
	//   1084: putfield w : Z
	//   1087: aload_0
	//   1088: getfield G : [Lam;
	//   1091: iload #9
	//   1093: aconst_null
	//   1094: aastore
	//   1095: iinc #9, -1
	//   1098: goto -> 1062
	//   1101: aload_0
	//   1102: iconst_0
	//   1103: putfield L : I
	//   1106: goto -> 362
	//   1109: aload_0
	//   1110: getfield L : I
	//   1113: ifeq -> 362
	//   1116: aload_0
	//   1117: getfield ac : Z
	//   1120: ifeq -> 1236
	//   1123: invokestatic currentTimeMillis : ()J
	//   1126: aload_0
	//   1127: getfield N : J
	//   1130: lsub
	//   1131: lstore #22
	//   1133: lload #22
	//   1135: ldc2_w 200
	//   1138: lcmp
	//   1139: ifle -> 1207
	//   1142: aload_0
	//   1143: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   1146: invokevirtual h : ()V
	//   1149: aload_0
	//   1150: iconst_0
	//   1151: putfield L : I
	//   1154: aload_0
	//   1155: iconst_0
	//   1156: putfield P : Z
	//   1159: aload_0
	//   1160: getfield G : [Lam;
	//   1163: arraylength
	//   1164: iconst_1
	//   1165: isub
	//   1166: istore #9
	//   1168: iload #9
	//   1170: iflt -> 362
	//   1173: aload_0
	//   1174: getfield G : [Lam;
	//   1177: iload #9
	//   1179: aaload
	//   1180: astore #4
	//   1182: aload #4
	//   1184: ifnull -> 1201
	//   1187: aload #4
	//   1189: iconst_0
	//   1190: putfield w : Z
	//   1193: aload_0
	//   1194: getfield G : [Lam;
	//   1197: iload #9
	//   1199: aconst_null
	//   1200: aastore
	//   1201: iinc #9, -1
	//   1204: goto -> 1168
	//   1207: lload #22
	//   1209: ldc2_w 255
	//   1212: lmul
	//   1213: ldc2_w 200
	//   1216: ldiv
	//   1217: l2i
	//   1218: istore #9
	//   1220: aload_0
	//   1221: getfield K : Landroid/graphics/Paint;
	//   1224: sipush #255
	//   1227: iload #9
	//   1229: isub
	//   1230: invokevirtual setAlpha : (I)V
	//   1233: goto -> 362
	//   1236: aload_0
	//   1237: getfield L : I
	//   1240: iconst_1
	//   1241: if_icmpne -> 362
	//   1244: aload_0
	//   1245: getfield U : F
	//   1248: aload_0
	//   1249: getfield e : I
	//   1252: i2f
	//   1253: fcmpl
	//   1254: ifgt -> 1308
	//   1257: aload_0
	//   1258: getfield U : F
	//   1261: aload_0
	//   1262: getfield H : I
	//   1265: ineg
	//   1266: i2f
	//   1267: aload_0
	//   1268: getfield W : F
	//   1271: fmul
	//   1272: fcmpg
	//   1273: iflt -> 1308
	//   1276: aload_0
	//   1277: getfield V : F
	//   1280: aload_0
	//   1281: getfield I : I
	//   1284: ineg
	//   1285: i2f
	//   1286: aload_0
	//   1287: getfield W : F
	//   1290: fmul
	//   1291: fcmpg
	//   1292: iflt -> 1308
	//   1295: aload_0
	//   1296: getfield V : F
	//   1299: aload_0
	//   1300: getfield f : I
	//   1303: i2f
	//   1304: fcmpl
	//   1305: ifle -> 362
	//   1308: aload_0
	//   1309: getfield G : [Lam;
	//   1312: arraylength
	//   1313: iconst_1
	//   1314: isub
	//   1315: istore #9
	//   1317: iload #9
	//   1319: iflt -> 1356
	//   1322: aload_0
	//   1323: getfield G : [Lam;
	//   1326: iload #9
	//   1328: aaload
	//   1329: astore #4
	//   1331: aload #4
	//   1333: ifnull -> 1350
	//   1336: aload #4
	//   1338: iconst_0
	//   1339: putfield w : Z
	//   1342: aload_0
	//   1343: getfield G : [Lam;
	//   1346: iload #9
	//   1348: aconst_null
	//   1349: aastore
	//   1350: iinc #9, -1
	//   1353: goto -> 1317
	//   1356: aload_0
	//   1357: iconst_0
	//   1358: putfield L : I
	//   1361: aload_0
	//   1362: iconst_0
	//   1363: putfield P : Z
	//   1366: goto -> 362
	//   1369: dload #11
	//   1371: aload_0
	//   1372: getfield X : F
	//   1375: f2d
	//   1376: drem
	//   1377: d2f
	//   1378: fneg
	//   1379: fstore #6
	//   1381: dload #11
	//   1383: dconst_0
	//   1384: dcmpg
	//   1385: ifge -> 1482
	//   1388: aload_0
	//   1389: getfield X : F
	//   1392: fstore #5
	//   1394: aload_0
	//   1395: fload #6
	//   1397: fload #5
	//   1399: fsub
	//   1400: putfield l : F
	//   1403: dload #13
	//   1405: aload_0
	//   1406: getfield X : F
	//   1409: f2d
	//   1410: drem
	//   1411: d2f
	//   1412: fneg
	//   1413: fstore #6
	//   1415: dload #13
	//   1417: dconst_0
	//   1418: dcmpg
	//   1419: ifge -> 1488
	//   1422: aload_0
	//   1423: getfield X : F
	//   1426: fstore #5
	//   1428: aload_0
	//   1429: fload #6
	//   1431: fload #5
	//   1433: fsub
	//   1434: putfield m : F
	//   1437: aload_0
	//   1438: aload_0
	//   1439: getfield e : I
	//   1442: i2f
	//   1443: aload_0
	//   1444: getfield X : F
	//   1447: fdiv
	//   1448: f2d
	//   1449: invokestatic ceil : (D)D
	//   1452: d2i
	//   1453: iconst_1
	//   1454: iadd
	//   1455: putfield j : I
	//   1458: aload_0
	//   1459: aload_0
	//   1460: getfield f : I
	//   1463: i2f
	//   1464: aload_0
	//   1465: getfield X : F
	//   1468: fdiv
	//   1469: f2d
	//   1470: invokestatic ceil : (D)D
	//   1473: d2i
	//   1474: iconst_1
	//   1475: iadd
	//   1476: putfield k : I
	//   1479: goto -> 935
	//   1482: fconst_0
	//   1483: fstore #5
	//   1485: goto -> 1394
	//   1488: fconst_0
	//   1489: fstore #5
	//   1491: goto -> 1428
	//   1494: iconst_0
	//   1495: istore #9
	//   1497: goto -> 956
	//   1500: iconst_0
	//   1501: istore #18
	//   1503: goto -> 984
	//   1506: iconst_0
	//   1507: istore #18
	//   1509: iload #19
	//   1511: istore #24
	//   1513: iload #24
	//   1515: iload #21
	//   1517: if_icmpge -> 1589
	//   1520: iload #9
	//   1522: istore #25
	//   1524: iload #25
	//   1526: iload #20
	//   1528: if_icmpge -> 1583
	//   1531: aload_0
	//   1532: getfield s : Lap;
	//   1535: iload #25
	//   1537: iload #24
	//   1539: aload_0
	//   1540: getfield o : I
	//   1543: aload_0
	//   1544: getfield n : I
	//   1547: invokevirtual a : (IIII)Lam;
	//   1550: astore #4
	//   1552: aload #4
	//   1554: aload_0
	//   1555: iload #25
	//   1557: iload #24
	//   1559: invokevirtual b : (II)Z
	//   1562: putfield w : Z
	//   1565: aload_0
	//   1566: getfield q : [Lam;
	//   1569: iload #18
	//   1571: aload #4
	//   1573: aastore
	//   1574: iinc #25, 1
	//   1577: iinc #18, 1
	//   1580: goto -> 1524
	//   1583: iinc #24, 1
	//   1586: goto -> 1513
	//   1589: aload_0
	//   1590: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   1593: invokevirtual f : ()Law;
	//   1596: astore #4
	//   1598: aload_0
	//   1599: getfield u : Lru/yandex/yandexmapkit/MapController;
	//   1602: invokevirtual m : ()Lru/yandex/yandexmapkit/map/MapLayer;
	//   1605: astore #10
	//   1607: aload_0
	//   1608: getfield q : [Lam;
	//   1611: arraylength
	//   1612: istore #26
	//   1614: iconst_0
	//   1615: istore #18
	//   1617: iconst_1
	//   1618: istore #24
	//   1620: iload_1
	//   1621: istore_3
	//   1622: iload #18
	//   1624: iload #26
	//   1626: if_icmpge -> 1773
	//   1629: aload_0
	//   1630: getfield q : [Lam;
	//   1633: iload #18
	//   1635: aaload
	//   1636: astore #16
	//   1638: aload #16
	//   1640: ifnull -> 2658
	//   1643: aload #16
	//   1645: getfield w : Z
	//   1648: ifeq -> 2658
	//   1651: aload #16
	//   1653: getfield g : B
	//   1656: iconst_1
	//   1657: iand
	//   1658: iconst_1
	//   1659: if_icmpeq -> 1673
	//   1662: aload #16
	//   1664: getfield g : B
	//   1667: iconst_4
	//   1668: iand
	//   1669: iconst_4
	//   1670: if_icmpne -> 1767
	//   1673: iconst_1
	//   1674: istore #25
	//   1676: aload_0
	//   1677: aload #16
	//   1679: aload #4
	//   1681: iconst_0
	//   1682: invokespecial a : (Lam;Law;Z)Z
	//   1685: istore_2
	//   1686: aload_0
	//   1687: getfield s : Lap;
	//   1690: aload #16
	//   1692: getfield i : I
	//   1695: aload #16
	//   1697: getfield j : I
	//   1700: aload_0
	//   1701: getfield o : I
	//   1704: aload #10
	//   1706: getfield layerId : I
	//   1709: invokevirtual a : (IIII)Lam;
	//   1712: astore #16
	//   1714: aload #16
	//   1716: iconst_1
	//   1717: putfield w : Z
	//   1720: aload_0
	//   1721: aload #16
	//   1723: aload #4
	//   1725: iconst_0
	//   1726: invokespecial a : (Lam;Law;Z)Z
	//   1729: pop
	//   1730: aload #16
	//   1732: instanceof bg
	//   1735: ifeq -> 1750
	//   1738: aload_0
	//   1739: getfield r : [Lbg;
	//   1742: iload #18
	//   1744: aload #16
	//   1746: checkcast bg
	//   1749: aastore
	//   1750: iload #25
	//   1752: iload #24
	//   1754: iand
	//   1755: istore #24
	//   1757: iload_3
	//   1758: iload_2
	//   1759: ior
	//   1760: istore_3
	//   1761: iinc #18, 1
	//   1764: goto -> 1622
	//   1767: iconst_0
	//   1768: istore #25
	//   1770: goto -> 1676
	//   1773: aload_0
	//   1774: getfield s : Lap;
	//   1777: invokevirtual c : ()V
	//   1780: aload_0
	//   1781: getfield L : I
	//   1784: ifeq -> 1833
	//   1787: aload_0
	//   1788: getfield ac : Z
	//   1791: ifne -> 1833
	//   1794: aload_0
	//   1795: getfield T : Z
	//   1798: ifne -> 1833
	//   1801: iload #24
	//   1803: ifeq -> 1989
	//   1806: aload_0
	//   1807: invokestatic currentTimeMillis : ()J
	//   1810: putfield N : J
	//   1813: aload_0
	//   1814: iconst_0
	//   1815: putfield P : Z
	//   1818: aload_0
	//   1819: getfield L : I
	//   1822: iconst_1
	//   1823: if_icmpne -> 1981
	//   1826: aload_0
	//   1827: getfield d : Lru/yandex/yandexmapkit/MapController$Map;
	//   1830: invokevirtual g : ()V
	//   1833: aload_0
	//   1834: getfield p : [Lam;
	//   1837: arraylength
	//   1838: iconst_1
	//   1839: isub
	//   1840: istore #18
	//   1842: iload #18
	//   1844: iflt -> 2429
	//   1847: aload_0
	//   1848: getfield p : [Lam;
	//   1851: iload #18
	//   1853: aaload
	//   1854: astore #16
	//   1856: aload #16
	//   1858: ifnull -> 1975
	//   1861: aload #16
	//   1863: getfield f : Landroid/graphics/Bitmap;
	//   1866: ifnull -> 1975
	//   1869: aload #16
	//   1871: getstatic ap.a : Lam;
	//   1874: if_acmpeq -> 1975
	//   1877: iconst_1
	//   1878: istore #27
	//   1880: iload #26
	//   1882: iconst_1
	//   1883: isub
	//   1884: istore #25
	//   1886: iload #27
	//   1888: istore #24
	//   1890: iload #25
	//   1892: iflt -> 1964
	//   1895: aload_0
	//   1896: getfield q : [Lam;
	//   1899: iload #25
	//   1901: aaload
	//   1902: astore #10
	//   1904: aload #10
	//   1906: ifnull -> 2423
	//   1909: aload #16
	//   1911: getfield i : I
	//   1914: aload #10
	//   1916: getfield i : I
	//   1919: if_icmpne -> 2423
	//   1922: aload #16
	//   1924: getfield j : I
	//   1927: aload #10
	//   1929: getfield j : I
	//   1932: if_icmpne -> 2423
	//   1935: aload #16
	//   1937: getfield zoom : I
	//   1940: aload #10
	//   1942: getfield zoom : I
	//   1945: if_icmpne -> 2423
	//   1948: aload #16
	//   1950: getfield type : I
	//   1953: aload #10
	//   1955: getfield type : I
	//   1958: if_icmpne -> 2423
	//   1961: iconst_0
	//   1962: istore #24
	//   1964: iload #24
	//   1966: ifeq -> 1975
	//   1969: aload #16
	//   1971: iconst_0
	//   1972: putfield w : Z
	//   1975: iinc #18, -1
	//   1978: goto -> 1842
	//   1981: aload_0
	//   1982: iconst_0
	//   1983: putfield L : I
	//   1986: goto -> 1833
	//   1989: aload_0
	//   1990: getfield L : I
	//   1993: iconst_1
	//   1994: if_icmpne -> 1833
	//   1997: aload_0
	//   1998: getfield l : F
	//   2001: fstore #5
	//   2003: aload_0
	//   2004: getfield m : F
	//   2007: fstore #6
	//   2009: aload_0
	//   2010: getfield j : I
	//   2013: istore #28
	//   2015: aload_0
	//   2016: getfield k : I
	//   2019: istore #29
	//   2021: iload #19
	//   2023: istore #24
	//   2025: iconst_0
	//   2026: istore #18
	//   2028: iload #24
	//   2030: iload #19
	//   2032: iload #29
	//   2034: iadd
	//   2035: if_icmpge -> 2342
	//   2038: iload #9
	//   2040: istore #25
	//   2042: fload #5
	//   2044: fstore #8
	//   2046: iload #25
	//   2048: iload #9
	//   2050: iload #28
	//   2052: iadd
	//   2053: if_icmpge -> 2317
	//   2056: aload_0
	//   2057: getfield q : [Lam;
	//   2060: iload #18
	//   2062: aaload
	//   2063: getfield g : B
	//   2066: iconst_1
	//   2067: iand
	//   2068: iconst_1
	//   2069: if_icmpne -> 2295
	//   2072: aload_0
	//   2073: getfield U : F
	//   2076: fstore #5
	//   2078: aload_0
	//   2079: getfield V : F
	//   2082: fstore #7
	//   2084: iconst_0
	//   2085: istore #30
	//   2087: aload_0
	//   2088: getfield X : F
	//   2091: fstore #15
	//   2093: aload_0
	//   2094: getfield X : F
	//   2097: fstore #31
	//   2099: aload_0
	//   2100: getfield G : [Lam;
	//   2103: ifnull -> 2295
	//   2106: iconst_0
	//   2107: istore #27
	//   2109: iload #27
	//   2111: aload_0
	//   2112: getfield I : I
	//   2115: if_icmpge -> 2295
	//   2118: iconst_0
	//   2119: istore #32
	//   2121: iload #32
	//   2123: aload_0
	//   2124: getfield H : I
	//   2127: if_icmpge -> 2270
	//   2130: aload_0
	//   2131: getfield G : [Lam;
	//   2134: iload #30
	//   2136: aaload
	//   2137: astore #10
	//   2139: aload #10
	//   2141: ifnull -> 2252
	//   2144: aload #10
	//   2146: getfield f : Landroid/graphics/Bitmap;
	//   2149: ifnull -> 2252
	//   2152: fconst_2
	//   2153: fload #7
	//   2155: fadd
	//   2156: f2i
	//   2157: istore #33
	//   2159: fconst_2
	//   2160: fload #5
	//   2162: fadd
	//   2163: f2i
	//   2164: istore #34
	//   2166: iload #33
	//   2168: i2f
	//   2169: aload_0
	//   2170: getfield W : F
	//   2173: fadd
	//   2174: ldc_w 4.0
	//   2177: fsub
	//   2178: f2i
	//   2179: istore #35
	//   2181: iload #34
	//   2183: i2f
	//   2184: aload_0
	//   2185: getfield W : F
	//   2188: fadd
	//   2189: ldc_w 4.0
	//   2192: fsub
	//   2193: f2i
	//   2194: istore #36
	//   2196: iload #33
	//   2198: i2f
	//   2199: fload #6
	//   2201: fcmpl
	//   2202: ifle -> 2252
	//   2205: iload #34
	//   2207: i2f
	//   2208: fload #8
	//   2210: fcmpl
	//   2211: ifle -> 2252
	//   2214: iload #35
	//   2216: i2f
	//   2217: fload #6
	//   2219: fload #15
	//   2221: fadd
	//   2222: fcmpg
	//   2223: ifge -> 2252
	//   2226: iload #36
	//   2228: i2f
	//   2229: fload #8
	//   2231: fload #31
	//   2233: fadd
	//   2234: fcmpg
	//   2235: ifge -> 2252
	//   2238: aload #10
	//   2240: iconst_0
	//   2241: putfield w : Z
	//   2244: aload_0
	//   2245: getfield G : [Lam;
	//   2248: iload #30
	//   2250: aconst_null
	//   2251: aastore
	//   2252: iinc #30, 1
	//   2255: iinc #32, 1
	//   2258: fload #5
	//   2260: aload_0
	//   2261: getfield W : F
	//   2264: fadd
	//   2265: fstore #5
	//   2267: goto -> 2121
	//   2270: aload_0
	//   2271: getfield U : F
	//   2274: fstore #5
	//   2276: aload_0
	//   2277: getfield W : F
	//   2280: fstore #37
	//   2282: iinc #27, 1
	//   2285: fload #37
	//   2287: fload #7
	//   2289: fadd
	//   2290: fstore #7
	//   2292: goto -> 2109
	//   2295: aload_0
	//   2296: getfield X : F
	//   2299: fstore #5
	//   2301: iinc #25, 1
	//   2304: fload #5
	//   2306: fload #8
	//   2308: fadd
	//   2309: fstore #8
	//   2311: iinc #18, 1
	//   2314: goto -> 2046
	//   2317: aload_0
	//   2318: getfield l : F
	//   2321: fstore #5
	//   2323: aload_0
	//   2324: getfield X : F
	//   2327: fstore #8
	//   2329: iinc #24, 1
	//   2332: fload #8
	//   2334: fload #6
	//   2336: fadd
	//   2337: fstore #6
	//   2339: goto -> 2028
	//   2342: iconst_1
	//   2343: istore #25
	//   2345: iload #25
	//   2347: istore #24
	//   2349: aload_0
	//   2350: getfield G : [Lam;
	//   2353: ifnull -> 2399
	//   2356: aload_0
	//   2357: getfield G : [Lam;
	//   2360: arraylength
	//   2361: iconst_1
	//   2362: isub
	//   2363: istore #18
	//   2365: iload #25
	//   2367: istore #24
	//   2369: iload #18
	//   2371: iflt -> 2399
	//   2374: aload_0
	//   2375: getfield G : [Lam;
	//   2378: iload #18
	//   2380: aaload
	//   2381: astore #10
	//   2383: aload #10
	//   2385: ifnull -> 2417
	//   2388: aload #10
	//   2390: getfield f : Landroid/graphics/Bitmap;
	//   2393: ifnull -> 2417
	//   2396: iconst_0
	//   2397: istore #24
	//   2399: iload #24
	//   2401: ifeq -> 1833
	//   2404: aload_0
	//   2405: iconst_0
	//   2406: putfield L : I
	//   2409: aload_0
	//   2410: iconst_0
	//   2411: putfield P : Z
	//   2414: goto -> 1833
	//   2417: iinc #18, -1
	//   2420: goto -> 2365
	//   2423: iinc #25, -1
	//   2426: goto -> 1886
	//   2429: iload #19
	//   2431: iconst_1
	//   2432: isub
	//   2433: istore #18
	//   2435: iload #18
	//   2437: iload #21
	//   2439: iconst_1
	//   2440: iadd
	//   2441: if_icmpge -> 2506
	//   2444: aload_0
	//   2445: aload_0
	//   2446: getfield s : Lap;
	//   2449: iload #9
	//   2451: iconst_1
	//   2452: isub
	//   2453: iload #18
	//   2455: aload_0
	//   2456: getfield o : I
	//   2459: aload_0
	//   2460: getfield n : I
	//   2463: invokevirtual a : (IIII)Lam;
	//   2466: aload #4
	//   2468: iconst_1
	//   2469: invokespecial a : (Lam;Law;Z)Z
	//   2472: pop
	//   2473: aload_0
	//   2474: aload_0
	//   2475: getfield s : Lap;
	//   2478: iload #20
	//   2480: iload #18
	//   2482: aload_0
	//   2483: getfield o : I
	//   2486: aload_0
	//   2487: getfield n : I
	//   2490: invokevirtual a : (IIII)Lam;
	//   2493: aload #4
	//   2495: iconst_1
	//   2496: invokespecial a : (Lam;Law;Z)Z
	//   2499: pop
	//   2500: iinc #18, 1
	//   2503: goto -> 2435
	//   2506: iload #9
	//   2508: iload #20
	//   2510: if_icmpge -> 2575
	//   2513: aload_0
	//   2514: aload_0
	//   2515: getfield s : Lap;
	//   2518: iload #9
	//   2520: iload #19
	//   2522: iconst_1
	//   2523: isub
	//   2524: aload_0
	//   2525: getfield o : I
	//   2528: aload_0
	//   2529: getfield n : I
	//   2532: invokevirtual a : (IIII)Lam;
	//   2535: aload #4
	//   2537: iconst_1
	//   2538: invokespecial a : (Lam;Law;Z)Z
	//   2541: pop
	//   2542: aload_0
	//   2543: aload_0
	//   2544: getfield s : Lap;
	//   2547: iload #9
	//   2549: iload #21
	//   2551: aload_0
	//   2552: getfield o : I
	//   2555: aload_0
	//   2556: getfield n : I
	//   2559: invokevirtual a : (IIII)Lam;
	//   2562: aload #4
	//   2564: iconst_1
	//   2565: invokespecial a : (Lam;Law;Z)Z
	//   2568: pop
	//   2569: iinc #9, 1
	//   2572: goto -> 2506
	//   2575: aload_0
	//   2576: getfield s : Lap;
	//   2579: invokevirtual c : ()V
	//   2582: aload_0
	//   2583: getfield p : [Lam;
	//   2586: arraylength
	//   2587: aload_0
	//   2588: getfield q : [Lam;
	//   2591: arraylength
	//   2592: if_icmpeq -> 2630
	//   2595: aload_0
	//   2596: aload_0
	//   2597: getfield q : [Lam;
	//   2600: arraylength
	//   2601: anewarray am
	//   2604: putfield p : [Lam;
	//   2607: aload_0
	//   2608: getfield p : [Lam;
	//   2611: astore #4
	//   2613: aload_0
	//   2614: aload_0
	//   2615: getfield q : [Lam;
	//   2618: putfield p : [Lam;
	//   2621: aload_0
	//   2622: aload #4
	//   2624: putfield q : [Lam;
	//   2627: goto -> 297
	//   2630: aload_0
	//   2631: getfield p : [Lam;
	//   2634: arraylength
	//   2635: iconst_1
	//   2636: isub
	//   2637: istore #9
	//   2639: iload #9
	//   2641: iflt -> 2607
	//   2644: aload_0
	//   2645: getfield p : [Lam;
	//   2648: iload #9
	//   2650: aconst_null
	//   2651: aastore
	//   2652: iinc #9, -1
	//   2655: goto -> 2639
	//   2658: goto -> 1761
	// Exception table:
	//   from	to	target	type
	//   8	24	309	finally
	//   24	102	301	finally
	//   102	127	309	finally
	//   127	247	309	finally
	//   247	272	309	finally
	//   284	295	309	finally
	//   303	309	309	finally
	//   322	342	309	finally
	//   350	362	309	finally
	//   362	935	309	finally
	//   935	946	309	finally
	//   963	974	309	finally
	//   991	1016	309	finally
	//   1027	1062	309	finally
	//   1067	1076	309	finally
	//   1081	1095	309	finally
	//   1101	1106	309	finally
	//   1109	1133	309	finally
	//   1142	1168	309	finally
	//   1173	1182	309	finally
	//   1187	1201	309	finally
	//   1207	1233	309	finally
	//   1236	1308	309	finally
	//   1308	1317	309	finally
	//   1322	1331	309	finally
	//   1336	1350	309	finally
	//   1356	1366	309	finally
	//   1369	1381	309	finally
	//   1388	1394	309	finally
	//   1394	1415	309	finally
	//   1422	1428	309	finally
	//   1428	1479	309	finally
	//   1531	1574	309	finally
	//   1589	1614	309	finally
	//   1629	1638	309	finally
	//   1643	1673	309	finally
	//   1676	1750	309	finally
	//   1773	1801	309	finally
	//   1806	1833	309	finally
	//   1833	1842	309	finally
	//   1847	1856	309	finally
	//   1861	1877	309	finally
	//   1895	1904	309	finally
	//   1909	1961	309	finally
	//   1969	1975	309	finally
	//   1981	1986	309	finally
	//   1989	2021	309	finally
	//   2056	2084	309	finally
	//   2087	2106	309	finally
	//   2109	2118	309	finally
	//   2121	2139	309	finally
	//   2144	2152	309	finally
	//   2166	2196	309	finally
	//   2238	2252	309	finally
	//   2258	2267	309	finally
	//   2270	2282	309	finally
	//   2295	2301	309	finally
	//   2317	2329	309	finally
	//   2349	2365	309	finally
	//   2374	2383	309	finally
	//   2388	2396	309	finally
	//   2404	2414	309	finally
	//   2444	2500	309	finally
	//   2513	2569	309	finally
	//   2575	2607	309	finally
	//   2607	2627	309	finally
	//   2630	2639	309	finally
	//   2644	2652	309	finally
  }

  public int g()
  {
	return this.n_Conflict;
  }

  public void h()
  {
	if (this.u != null)
	{
	  this.u.notifyRepaint();
	}
  }

  public Thread j()
  {
	this.v = true;
	lock (this.A)
	{
	  Monitor.PulseAll(this.A);
	  this.s.d();
	  return this.J;
	}
  }

  public void k()
  {
	if (!this.d_Conflict.e())
	{
	  this.P = false;
	  f();
	  am[] arrayOfAm = this.p_Conflict;
	  if (this.G != null)
	  {
		for (sbyte b = 0; b < this.G.Length; b++)
		{
		  am am1 = this.G[b];
		  if (am1 != null)
		  {
			am1.w = false;
		  }
		}
	  }
	  this.G = new am[arrayOfAm.Length];
	  Array.Copy(arrayOfAm, 0, this.G, 0, arrayOfAm.Length);
	  this.H = this.j_Conflict;
	  this.I = this.k_Conflict;
	  this.O = this.Z;
	  float f = (float)Math.Pow(2.0D, (23.0F - this.Z));
	  this.R = (this.C - (this.e_Conflict >> 1) + this.l_Conflict) * f;
	  this.S = (this.D - (this.f_Conflict >> 1) + this.m_Conflict) * f;
	  this.Y = this.X;
	}
  }

  public float l()
  {
	return this.Z;
  }

  public int m()
  {
	return this.aa;
  }

  public int n()
  {
	return this.ab;
  }

  public bool o()
  {
	return this.T;
  }

  public void run()
  {
	aw aw = this.u.f();
	av av = aw.b();
	int i = 0;
	long l = 0L;
	while (true)
	{
	  if (!this.v)
	  {
		int j = i;
		while (true)
		{
		  long l1 = l;
		  i = j;
		  try
		  {
			am[] arrayOfAm = this.x;
		  }
		  finally
		  {
			long l1 = l;
			i = j;
			/* monitor exit ClassFileLocalVariableReferenceExpression{type=ObjectType{java/lang/Object}, name=SYNTHETIC_LOCAL_VARIABLE_13} */
			l1 = l;
			i = j;
		  }
		}
		break;
	  }
	  if (this.G != null)
	  {
		for (sbyte b1 = 0; b1 < this.G.Length; b1++)
		{
		  this.G[b1] = null;
		}
	  }
	  sbyte b;
	  for (b = 0; b < this.p_Conflict.Length; b++)
	  {
		this.p_Conflict[b] = null;
	  }
	  for (b = 0; b < this.q_Conflict.Length; b++)
	  {
		this.q_Conflict[b] = null;
	  }
	  for (b = 0; b < this.x.Length; b++)
	  {
		this.x[b] = null;
	  }
	  return;
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\aq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */