using System;

using Context = android.content.Context;
using Bitmap = android.graphics.Bitmap;
using BitmapFactory = android.graphics.BitmapFactory;

public class am
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static readonly int a_Conflict = b.a(new sbyte[] {89, 84, 76, 68}, 0);

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static BitmapFactory.Options b_Conflict;

  private an A;

  private long B;

  private float C = 1.0F;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public string c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public bool d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public bool e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public Bitmap f_Conflict;

  public sbyte g;

  public sbyte h;

  public readonly int i;

  public readonly int j;

  public sbyte k;

  public sbyte l;

  internal int m;

  internal int n;

  internal int o;

  internal string p;

  public sbyte[] pureData;

  public int q;

  public bool r;

  public bool s;

  public bool t;

  public readonly int type;

  public int u;

  public bool v;

  public bool w;

  public bool x;

  public am y;

  public am z;

  public readonly int zoom;

  public am(Context paramContext, long paramLong, int paramInt1, int paramInt2, int paramInt3, int paramInt4, string paramString, bool paramBoolean)
  {
	a(paramContext);
	this.B = paramLong;
	this.i = paramInt1;
	this.j = paramInt2;
	this.zoom = paramInt3;
	this.type = paramInt4;
	this.c_Conflict = paramString;
	this.d_Conflict = paramBoolean;
	this.e_Conflict = false;
	this.k = (sbyte)0;
	this.r = false;
	this.s = false;
	this.t = false;
	this.x = false;
	this.q = 0;
	this.l = (sbyte)-1;
	this.u = -1;
	this.v = false;
  }

  public static long a(int paramInt1, int paramInt2, int paramInt3, int paramInt4)
  {
	return paramInt4 << 53L | paramInt3 << 48L | paramInt1 << 24L | paramInt2;
  }

  public static BitmapFactory.Options a(Context paramContext)
  {
	// Byte code:
	//   0: ldc am
	//   2: monitorenter
	//   3: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   6: ifnonnull -> 55
	//   9: new android/graphics/BitmapFactory$Options
	//   12: astore_1
	//   13: aload_1
	//   14: invokespecial <init> : ()V
	//   17: aload_1
	//   18: putstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   21: aload_1
	//   22: getstatic android/graphics/Bitmap$Config.RGB_565 : Landroid/graphics/Bitmap$Config;
	//   25: putfield inPreferredConfig : Landroid/graphics/Bitmap$Config;
	//   28: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   31: iconst_0
	//   32: putfield inDither : Z
	//   35: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   38: aload_0
	//   39: invokestatic a : (Landroid/content/Context;)I
	//   42: putfield inDensity : I
	//   45: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   48: ldc 327680
	//   50: newarray byte
	//   52: putfield inTempStorage : [B
	//   55: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   58: astore_0
	//   59: ldc am
	//   61: monitorexit
	//   62: aload_0
	//   63: areturn
	//   64: astore_0
	//   65: ldc am
	//   67: monitorexit
	//   68: aload_0
	//   69: athrow
	// Exception table:
	//   from	to	target	type
	//   3	55	64	finally
	//   55	59	64	finally
  }

  public static void a(am paramam, Bitmap paramBitmap, ShortBuffer paramShortBuffer, sbyte paramByte)
  {
	// Byte code:
	//   0: ldc am
	//   2: monitorenter
	//   3: aload_1
	//   4: ifnull -> 40
	//   7: aload_1
	//   8: astore #4
	//   10: aload_1
	//   11: aload_2
	//   12: invokevirtual copyPixelsFromBuffer : (Ljava/nio/Buffer;)V
	//   15: aload_1
	//   16: ifnull -> 36
	//   19: aload_0
	//   20: aload_1
	//   21: putfield f : Landroid/graphics/Bitmap;
	//   24: aload_0
	//   25: aload_0
	//   26: getfield g : B
	//   29: iload_3
	//   30: ior
	//   31: i2b
	//   32: i2b
	//   33: putfield g : B
	//   36: ldc am
	//   38: monitorexit
	//   39: return
	//   40: aload_1
	//   41: astore #4
	//   43: sipush #128
	//   46: sipush #128
	//   49: getstatic android/graphics/Bitmap$Config.RGB_565 : Landroid/graphics/Bitmap$Config;
	//   52: invokestatic createBitmap : (IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;
	//   55: astore #5
	//   57: aload #5
	//   59: astore #4
	//   61: aload #5
	//   63: aload_2
	//   64: invokevirtual copyPixelsFromBuffer : (Ljava/nio/Buffer;)V
	//   67: aload #5
	//   69: astore_1
	//   70: aload #5
	//   72: astore #4
	//   74: aload_0
	//   75: getfield f : Landroid/graphics/Bitmap;
	//   78: ifnonnull -> 15
	//   81: aload #5
	//   83: astore_1
	//   84: aload #5
	//   86: ifnull -> 15
	//   89: aload #5
	//   91: astore #4
	//   93: invokestatic a : ()Lap;
	//   96: invokevirtual b : ()Lal;
	//   99: aload_0
	//   100: invokevirtual b : (Lam;)V
	//   103: aload #5
	//   105: astore_1
	//   106: goto -> 15
	//   109: astore_1
	//   110: invokestatic a : ()Lap;
	//   113: invokevirtual b : ()Lal;
	//   116: invokevirtual a : ()V
	//   119: aload #4
	//   121: astore_1
	//   122: goto -> 15
	//   125: astore_2
	//   126: new java/lang/StringBuilder
	//   129: astore_2
	//   130: aload_2
	//   131: invokespecial <init> : ()V
	//   134: ldc 'setBuffer'
	//   136: aload_2
	//   137: ldc ''
	//   139: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   142: aload_1
	//   143: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
	//   146: invokevirtual toString : ()Ljava/lang/String;
	//   149: invokestatic w : (Ljava/lang/String;Ljava/lang/String;)I
	//   152: pop
	//   153: aload #4
	//   155: astore_1
	//   156: goto -> 15
	//   159: astore_0
	//   160: ldc am
	//   162: monitorexit
	//   163: aload_0
	//   164: athrow
	// Exception table:
	//   from	to	target	type
	//   10	15	109	java/lang/Throwable
	//   10	15	159	finally
	//   19	36	159	finally
	//   43	57	109	java/lang/Throwable
	//   43	57	159	finally
	//   61	67	109	java/lang/Throwable
	//   61	67	159	finally
	//   74	81	109	java/lang/Throwable
	//   74	81	159	finally
	//   93	103	109	java/lang/Throwable
	//   93	103	159	finally
	//   110	119	125	java/lang/Throwable
	//   110	119	159	finally
	//   126	153	159	finally
  }

  public static bool a(am paramam)
  {
	// Byte code:
	//   0: iconst_0
	//   1: istore_1
	//   2: ldc am
	//   4: monitorenter
	//   5: aload_0
	//   6: getfield d : Z
	//   9: istore_2
	//   10: iload_2
	//   11: ifeq -> 19
	//   14: ldc am
	//   16: monitorexit
	//   17: iload_1
	//   18: ireturn
	//   19: aload_0
	//   20: getfield g : B
	//   23: istore_3
	//   24: invokestatic a : ()Lap;
	//   27: astore #4
	//   29: aload #4
	//   31: ifnull -> 103
	//   34: aload #4
	//   36: invokevirtual b : ()Lal;
	//   39: astore #4
	//   41: aload #4
	//   43: ifnull -> 103
	//   46: aload_0
	//   47: getfield h : B
	//   50: istore #5
	//   52: iload #5
	//   54: ifeq -> 103
	//   57: aload_0
	//   58: invokestatic b : (Lam;)Landroid/graphics/Bitmap;
	//   61: astore #6
	//   63: aload #6
	//   65: ifnonnull -> 120
	//   68: aload_0
	//   69: getfield f : Landroid/graphics/Bitmap;
	//   72: ifnull -> 81
	//   75: aload #4
	//   77: aload_0
	//   78: invokevirtual c : (Lam;)V
	//   81: aload_0
	//   82: aconst_null
	//   83: putfield f : Landroid/graphics/Bitmap;
	//   86: aload_0
	//   87: iconst_0
	//   88: i2b
	//   89: putfield g : B
	//   92: aload_0
	//   93: iconst_m1
	//   94: i2b
	//   95: putfield l : B
	//   98: aload_0
	//   99: iconst_m1
	//   100: putfield u : I
	//   103: aload_0
	//   104: getfield g : B
	//   107: istore #5
	//   109: iload_3
	//   110: iload #5
	//   112: if_icmpeq -> 14
	//   115: iconst_1
	//   116: istore_1
	//   117: goto -> 14
	//   120: aload_0
	//   121: getfield f : Landroid/graphics/Bitmap;
	//   124: ifnonnull -> 133
	//   127: aload #4
	//   129: aload_0
	//   130: invokevirtual b : (Lam;)V
	//   133: aload_0
	//   134: aload #6
	//   136: putfield f : Landroid/graphics/Bitmap;
	//   139: aload_0
	//   140: aload_0
	//   141: getfield h : B
	//   144: i2b
	//   145: putfield g : B
	//   148: goto -> 92
	//   151: astore #6
	//   153: aload #4
	//   155: invokevirtual a : ()V
	//   158: aload_0
	//   159: getfield f : Landroid/graphics/Bitmap;
	//   162: ifnull -> 171
	//   165: aload #4
	//   167: aload_0
	//   168: invokevirtual c : (Lam;)V
	//   171: aload_0
	//   172: aconst_null
	//   173: putfield f : Landroid/graphics/Bitmap;
	//   176: aload_0
	//   177: iconst_0
	//   178: i2b
	//   179: putfield g : B
	//   182: goto -> 92
	//   185: astore_0
	//   186: ldc am
	//   188: monitorexit
	//   189: aload_0
	//   190: athrow
	// Exception table:
	//   from	to	target	type
	//   5	10	185	finally
	//   19	29	185	finally
	//   34	41	185	finally
	//   46	52	185	finally
	//   57	63	151	java/lang/Throwable
	//   57	63	185	finally
	//   68	81	151	java/lang/Throwable
	//   68	81	185	finally
	//   81	92	151	java/lang/Throwable
	//   81	92	185	finally
	//   92	103	185	finally
	//   103	109	185	finally
	//   120	133	151	java/lang/Throwable
	//   120	133	185	finally
	//   133	148	151	java/lang/Throwable
	//   133	148	185	finally
	//   153	171	185	finally
	//   171	182	185	finally
  }

  public static Bitmap b(am paramam)
  {
	// Byte code:
	//   0: aconst_null
	//   1: astore_1
	//   2: aconst_null
	//   3: astore_2
	//   4: iconst_0
	//   5: istore_3
	//   6: ldc am
	//   8: monitorenter
	//   9: aload_0
	//   10: getfield h : B
	//   13: istore #4
	//   15: aload_0
	//   16: getfield d : Z
	//   19: istore #5
	//   21: iload #5
	//   23: ifeq -> 31
	//   26: ldc am
	//   28: monitorexit
	//   29: aload_2
	//   30: areturn
	//   31: iload #4
	//   33: ifeq -> 26
	//   36: aload_0
	//   37: invokevirtual a : ()[B
	//   40: getstatic aq.c : [B
	//   43: if_acmpne -> 53
	//   46: getstatic aq.b : Landroid/graphics/Bitmap;
	//   49: astore_2
	//   50: goto -> 26
	//   53: aload_0
	//   54: invokevirtual a : ()[B
	//   57: ifnull -> 172
	//   60: aload_0
	//   61: getfield A : Lan;
	//   64: ifnull -> 75
	//   67: aload_0
	//   68: getfield A : Lan;
	//   71: getfield e : I
	//   74: istore_3
	//   75: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   78: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   81: getfield inDensity : I
	//   84: i2f
	//   85: aload_0
	//   86: invokevirtual f : ()F
	//   89: fmul
	//   90: f2i
	//   91: putfield inTargetDensity : I
	//   94: new java/io/ByteArrayInputStream
	//   97: astore_2
	//   98: aload_2
	//   99: aload_0
	//   100: invokevirtual a : ()[B
	//   103: iload_3
	//   104: aload_0
	//   105: invokevirtual a : ()[B
	//   108: arraylength
	//   109: iload_3
	//   110: isub
	//   111: invokespecial <init> : ([BII)V
	//   114: new android/graphics/Rect
	//   117: astore_0
	//   118: aload_0
	//   119: iconst_m1
	//   120: iconst_m1
	//   121: iconst_m1
	//   122: iconst_m1
	//   123: invokespecial <init> : (IIII)V
	//   126: aload_2
	//   127: aload_0
	//   128: getstatic am.b : Landroid/graphics/BitmapFactory$Options;
	//   131: invokestatic decodeStream : (Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;
	//   134: astore_0
	//   135: aload_0
	//   136: astore_2
	//   137: aload_0
	//   138: ifnull -> 26
	//   141: aload_0
	//   142: invokevirtual getConfig : ()Landroid/graphics/Bitmap$Config;
	//   145: ifnull -> 160
	//   148: aload_0
	//   149: astore_2
	//   150: aload_0
	//   151: invokevirtual getConfig : ()Landroid/graphics/Bitmap$Config;
	//   154: getstatic android/graphics/Bitmap$Config.RGB_565 : Landroid/graphics/Bitmap$Config;
	//   157: if_acmpeq -> 26
	//   160: aload_0
	//   161: getstatic android/graphics/Bitmap$Config.RGB_565 : Landroid/graphics/Bitmap$Config;
	//   164: iconst_0
	//   165: invokevirtual copy : (Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;
	//   168: astore_2
	//   169: goto -> 26
	//   172: ldc 'ymm_fc'
	//   174: ldc 'bitmap data is null'
	//   176: invokestatic i : (Ljava/lang/String;Ljava/lang/String;)I
	//   179: pop
	//   180: aload_1
	//   181: astore_0
	//   182: goto -> 135
	//   185: astore_0
	//   186: invokestatic a : ()Lap;
	//   189: invokevirtual b : ()Lal;
	//   192: invokevirtual a : ()V
	//   195: aload_1
	//   196: astore_0
	//   197: goto -> 135
	//   200: astore_0
	//   201: ldc am
	//   203: monitorexit
	//   204: aload_0
	//   205: athrow
	//   206: astore_0
	//   207: aload_1
	//   208: astore_0
	//   209: goto -> 135
	// Exception table:
	//   from	to	target	type
	//   9	21	200	finally
	//   36	50	200	finally
	//   53	60	185	java/lang/OutOfMemoryError
	//   53	60	206	java/lang/Exception
	//   53	60	200	finally
	//   60	75	185	java/lang/OutOfMemoryError
	//   60	75	206	java/lang/Exception
	//   60	75	200	finally
	//   75	135	185	java/lang/OutOfMemoryError
	//   75	135	206	java/lang/Exception
	//   75	135	200	finally
	//   141	148	200	finally
	//   150	160	200	finally
	//   160	169	200	finally
	//   172	180	185	java/lang/OutOfMemoryError
	//   172	180	206	java/lang/Exception
	//   172	180	200	finally
	//   186	195	200	finally
  }

  public virtual void a(float paramFloat)
  {
	this.C = paramFloat;
  }

  public virtual void a(int paramInt)
  {
	if (this.A != null)
	{
	  this.A.c = paramInt;
	}
  }

  public virtual void a(sbyte[] paramArrayOfbyte)
  {
	if (paramArrayOfbyte != null && paramArrayOfbyte.Length >= 30 && b.a(paramArrayOfbyte, 0) == a_Conflict)
	{
	  this.pureData = paramArrayOfbyte;
	  try
	  {
		an an1 = new an();
		this(this.pureData);
		this.A = an1;
		return;
	  }
	  catch (Exception)
	  {
	  }
	}
	this.pureData = paramArrayOfbyte;
  }

  public virtual sbyte[] a()
  {
	return this.pureData;
  }

  public virtual int b()
  {
	return (this.A != null) ? this.A.c : 0;
  }

  public virtual string c()
  {
	return (this.A != null) ? this.A.f : "";
  }

  public virtual Bitmap d()
  {
	if (this.f_Conflict == null && !this.d_Conflict)
	{
	  a(this);
	}
	return this.f_Conflict;
  }

  public virtual long e()
  {
	return this.B;
  }

  public virtual float f()
  {
	return this.C;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\am.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */