using System;
using System.Threading;

using PointF = android.graphics.PointF;

public class ah : ThreadStart
{
  private static float[] m = new float[2];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private volatile float a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private float d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private float e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private float f_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool h_Conflict;

  private z i;

  private volatile bool j;

  private Thread k;

  private bool l;

  public ah(z paramz)
  {
	this.i = paramz;
	this.j = true;
  }

  private PointF a(float paramFloat1, float paramFloat2, float paramFloat3)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: fload_3
	//   3: f2i
	//   4: ifeq -> 82
	//   7: fload_3
	//   8: f2d
	//   9: dstore #4
	//   11: dload #4
	//   13: invokestatic toRadians : (D)D
	//   16: dstore #6
	//   18: fload_1
	//   19: f2d
	//   20: dload #6
	//   22: invokestatic cos : (D)D
	//   25: dmul
	//   26: fload_2
	//   27: f2d
	//   28: dload #6
	//   30: invokestatic sin : (D)D
	//   33: dmul
	//   34: dsub
	//   35: d2f
	//   36: fstore_3
	//   37: fload_1
	//   38: f2d
	//   39: dstore #8
	//   41: dload #6
	//   43: invokestatic sin : (D)D
	//   46: dstore #4
	//   48: fload_2
	//   49: f2d
	//   50: dstore #10
	//   52: new android/graphics/PointF
	//   55: dup
	//   56: fload_3
	//   57: dload #6
	//   59: invokestatic cos : (D)D
	//   62: dload #10
	//   64: dmul
	//   65: dload #8
	//   67: dload #4
	//   69: dmul
	//   70: dadd
	//   71: d2f
	//   72: invokespecial <init> : (FF)V
	//   75: astore #12
	//   77: aload_0
	//   78: monitorexit
	//   79: aload #12
	//   81: areturn
	//   82: new android/graphics/PointF
	//   85: dup
	//   86: fload_1
	//   87: fload_2
	//   88: invokespecial <init> : (FF)V
	//   91: astore #12
	//   93: goto -> 77
	//   96: astore #12
	//   98: aload_0
	//   99: monitorexit
	//   100: aload #12
	//   102: athrow
	// Exception table:
	//   from	to	target	type
	//   11	37	96	finally
	//   41	48	96	finally
	//   52	77	96	finally
	//   82	93	96	finally
  }

  private static PointF a(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4, float paramFloat5)
  {
	if ((int)paramFloat5 != 0)
	{
	  double d1 = Math.toRadians(paramFloat5);
	  paramFloat5 = (float)(paramFloat1 * Math.Cos(d1) - paramFloat2 * Math.Sin(d1) - paramFloat3 * (Math.Cos(d1) - 1.0D) + paramFloat4 * Math.Sin(d1));
	  double d2 = paramFloat1;
	  double d3 = Math.Sin(d1);
	  double d4 = paramFloat2;
	  double d5 = Math.Cos(d1);
	  double d6 = paramFloat4;
	  double d7 = Math.Cos(d1);
	  double d8 = paramFloat3;
	  return new PointF(paramFloat5, (float)(d2 * d3 + d4 * d5 - d6 * (d7 - 1.0D) - Math.Sin(d1) * d8));
	}
	return new PointF(paramFloat1, paramFloat2);
  }

  private void h()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield c : I
	//   6: i2f
	//   7: aload_0
	//   8: getfield a : F
	//   11: fsub
	//   12: f2i
	//   13: istore_1
	//   14: iload_1
	//   15: istore_2
	//   16: iload_1
	//   17: invokestatic abs : (I)I
	//   20: sipush #180
	//   23: if_icmple -> 36
	//   26: iload_1
	//   27: ifle -> 138
	//   30: iload_1
	//   31: sipush #360
	//   34: isub
	//   35: istore_2
	//   36: aload_0
	//   37: iload_2
	//   38: i2f
	//   39: ldc 600.0
	//   41: fdiv
	//   42: putfield d : F
	//   45: aload_0
	//   46: getfield d : F
	//   49: invokestatic abs : (F)F
	//   52: ldc 180.0
	//   54: fcmpl
	//   55: ifle -> 80
	//   58: aload_0
	//   59: getfield d : F
	//   62: fconst_0
	//   63: fcmpl
	//   64: ifle -> 147
	//   67: aload_0
	//   68: getfield d : F
	//   71: ldc 360.0
	//   73: fsub
	//   74: fstore_3
	//   75: aload_0
	//   76: fload_3
	//   77: putfield d : F
	//   80: aload_0
	//   81: getfield k : Ljava/lang/Thread;
	//   84: ifnonnull -> 168
	//   87: new java/lang/Thread
	//   90: astore #4
	//   92: aload #4
	//   94: aload_0
	//   95: ldc 'ymm-map-rotator'
	//   97: invokespecial <init> : (Ljava/lang/Runnable;Ljava/lang/String;)V
	//   100: aload_0
	//   101: aload #4
	//   103: putfield k : Ljava/lang/Thread;
	//   106: aload_0
	//   107: getfield k : Ljava/lang/Thread;
	//   110: astore #4
	//   112: aload #4
	//   114: ifnull -> 158
	//   117: aload #4
	//   119: invokevirtual isAlive : ()Z
	//   122: ifeq -> 158
	//   125: invokestatic yield : ()V
	//   128: goto -> 112
	//   131: astore #4
	//   133: aload_0
	//   134: monitorexit
	//   135: aload #4
	//   137: athrow
	//   138: iload_1
	//   139: sipush #360
	//   142: iadd
	//   143: istore_2
	//   144: goto -> 36
	//   147: aload_0
	//   148: getfield d : F
	//   151: ldc 360.0
	//   153: fadd
	//   154: fstore_3
	//   155: goto -> 75
	//   158: aload_0
	//   159: getfield k : Ljava/lang/Thread;
	//   162: invokevirtual start : ()V
	//   165: aload_0
	//   166: monitorexit
	//   167: return
	//   168: aload_0
	//   169: invokevirtual notifyAll : ()V
	//   172: goto -> 165
	// Exception table:
	//   from	to	target	type
	//   2	14	131	finally
	//   16	26	131	finally
	//   36	75	131	finally
	//   75	80	131	finally
	//   80	112	131	finally
	//   117	128	131	finally
	//   147	155	131	finally
	//   158	165	131	finally
	//   168	172	131	finally
  }

  public virtual PointF a(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: fload_1
	//   3: fload_2
	//   4: fload_3
	//   5: fload #4
	//   7: aload_0
	//   8: getfield b : I
	//   11: i2f
	//   12: invokestatic a : (FFFFF)Landroid/graphics/PointF;
	//   15: astore #5
	//   17: aload_0
	//   18: monitorexit
	//   19: aload #5
	//   21: areturn
	//   22: astore #5
	//   24: aload_0
	//   25: monitorexit
	//   26: aload #5
	//   28: athrow
	// Exception table:
	//   from	to	target	type
	//   2	17	22	finally
  }

  public virtual void a(float paramFloat)
  {
	this.c_Conflict = (int)Math.Round(paramFloat, MidpointRounding.AwayFromZero);
	if (!this.h_Conflict && this.g_Conflict)
	{
	  h();
	}
  }

  public virtual void a(float paramFloat1, float paramFloat2)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: fload_1
	//   4: putfield e : F
	//   7: aload_0
	//   8: fload_2
	//   9: putfield f : F
	//   12: aload_0
	//   13: monitorexit
	//   14: return
	//   15: astore_3
	//   16: aload_0
	//   17: monitorexit
	//   18: aload_3
	//   19: athrow
	// Exception table:
	//   from	to	target	type
	//   2	12	15	finally
  }

  public virtual bool a()
  {
	return (!this.g_Conflict && this.a_Conflict != 0.0F) ? true : this.g_Conflict;
  }

  public virtual float b()
  {
	return (int)this.a_Conflict;
  }

  public virtual float b(float paramFloat)
  {
	/* monitor enter ThisExpression{ObjectType{ah}} */
	paramFloat /= 2.0F;
	/* monitor exit ThisExpression{ObjectType{ah}} */
	return paramFloat;
  }

  public virtual float b(float paramFloat1, float paramFloat2)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield l : Z
	//   6: ifeq -> 81
	//   9: ldc 5.0
	//   11: fload_2
	//   12: fmul
	//   13: ldc 6.0
	//   15: fdiv
	//   16: fstore_2
	//   17: fload_2
	//   18: fstore_3
	//   19: aload_0
	//   20: invokevirtual a : ()Z
	//   23: ifeq -> 77
	//   26: fload_2
	//   27: fstore_3
	//   28: aload_0
	//   29: getfield i : Lz;
	//   32: invokeinterface c : ()Z
	//   37: ifeq -> 77
	//   40: getstatic ah.m : [F
	//   43: iconst_0
	//   44: aload_0
	//   45: fload_1
	//   46: invokevirtual b : (F)F
	//   49: fastore
	//   50: getstatic ah.m : [F
	//   53: iconst_1
	//   54: fload_2
	//   55: fastore
	//   56: aload_0
	//   57: getfield i : Lz;
	//   60: invokeinterface d : ()Landroid/graphics/Matrix;
	//   65: getstatic ah.m : [F
	//   68: invokevirtual mapPoints : ([F)V
	//   71: getstatic ah.m : [F
	//   74: iconst_1
	//   75: faload
	//   76: fstore_3
	//   77: aload_0
	//   78: monitorexit
	//   79: fload_3
	//   80: freturn
	//   81: fload_2
	//   82: fconst_2
	//   83: fdiv
	//   84: fstore_2
	//   85: goto -> 17
	//   88: astore #4
	//   90: aload_0
	//   91: monitorexit
	//   92: aload #4
	//   94: athrow
	// Exception table:
	//   from	to	target	type
	//   2	9	88	finally
	//   19	26	88	finally
	//   28	77	88	finally
  }

  public virtual int c()
  {
	return this.b_Conflict;
  }

  public virtual PointF c(float paramFloat1, float paramFloat2)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: fload_1
	//   3: fload_2
	//   4: aload_0
	//   5: getfield e : F
	//   8: aload_0
	//   9: getfield f : F
	//   12: aload_0
	//   13: getfield b : I
	//   16: ineg
	//   17: i2f
	//   18: invokestatic a : (FFFFF)Landroid/graphics/PointF;
	//   21: astore_3
	//   22: aload_0
	//   23: monitorexit
	//   24: aload_3
	//   25: areturn
	//   26: astore_3
	//   27: aload_0
	//   28: monitorexit
	//   29: aload_3
	//   30: athrow
	// Exception table:
	//   from	to	target	type
	//   2	22	26	finally
  }

  public virtual PointF d(float paramFloat1, float paramFloat2)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: fload_1
	//   3: fload_2
	//   4: aload_0
	//   5: getfield e : F
	//   8: aload_0
	//   9: getfield f : F
	//   12: aload_0
	//   13: getfield b : I
	//   16: i2f
	//   17: invokestatic a : (FFFFF)Landroid/graphics/PointF;
	//   20: astore_3
	//   21: aload_0
	//   22: monitorexit
	//   23: aload_3
	//   24: areturn
	//   25: astore_3
	//   26: aload_0
	//   27: monitorexit
	//   28: aload_3
	//   29: athrow
	// Exception table:
	//   from	to	target	type
	//   2	21	25	finally
  }

  public virtual void d()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: aload_0
	//   4: getfield a : F
	//   7: invokestatic round : (F)I
	//   10: putfield b : I
	//   13: aload_0
	//   14: monitorexit
	//   15: return
	//   16: astore_1
	//   17: aload_0
	//   18: monitorexit
	//   19: aload_1
	//   20: athrow
	// Exception table:
	//   from	to	target	type
	//   2	13	16	finally
  }

  public virtual float e()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield e : F
	//   6: fstore_1
	//   7: aload_0
	//   8: monitorexit
	//   9: fload_1
	//   10: freturn
	//   11: astore_2
	//   12: aload_0
	//   13: monitorexit
	//   14: aload_2
	//   15: athrow
	// Exception table:
	//   from	to	target	type
	//   2	7	11	finally
  }

  public virtual PointF e(float paramFloat1, float paramFloat2)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield i : Lz;
	//   6: astore_3
	//   7: fload_1
	//   8: fstore #4
	//   10: fload_2
	//   11: fstore #5
	//   13: aload_3
	//   14: invokeinterface c : ()Z
	//   19: ifeq -> 73
	//   22: fload_1
	//   23: fstore #4
	//   25: fload_2
	//   26: fstore #5
	//   28: aload_0
	//   29: invokevirtual a : ()Z
	//   32: ifeq -> 73
	//   35: getstatic ah.m : [F
	//   38: iconst_0
	//   39: fload_1
	//   40: fastore
	//   41: getstatic ah.m : [F
	//   44: iconst_1
	//   45: fload_2
	//   46: fastore
	//   47: aload_3
	//   48: invokeinterface d : ()Landroid/graphics/Matrix;
	//   53: getstatic ah.m : [F
	//   56: invokevirtual mapPoints : ([F)V
	//   59: getstatic ah.m : [F
	//   62: iconst_0
	//   63: faload
	//   64: fstore #4
	//   66: getstatic ah.m : [F
	//   69: iconst_1
	//   70: faload
	//   71: fstore #5
	//   73: aload_0
	//   74: fload #4
	//   76: fload #5
	//   78: invokevirtual d : (FF)Landroid/graphics/PointF;
	//   81: astore_3
	//   82: aload_0
	//   83: monitorexit
	//   84: aload_3
	//   85: areturn
	//   86: astore_3
	//   87: aload_0
	//   88: monitorexit
	//   89: aload_3
	//   90: athrow
	// Exception table:
	//   from	to	target	type
	//   2	7	86	finally
	//   13	22	86	finally
	//   28	73	86	finally
	//   73	82	86	finally
  }

  public virtual float f()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield f : F
	//   6: fstore_1
	//   7: aload_0
	//   8: monitorexit
	//   9: fload_1
	//   10: freturn
	//   11: astore_2
	//   12: aload_0
	//   13: monitorexit
	//   14: aload_2
	//   15: athrow
	// Exception table:
	//   from	to	target	type
	//   2	7	11	finally
  }

  public virtual PointF f(float paramFloat1, float paramFloat2)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: fload_1
	//   4: fload_2
	//   5: aload_0
	//   6: getfield b : I
	//   9: i2f
	//   10: invokespecial a : (FFF)Landroid/graphics/PointF;
	//   13: astore_3
	//   14: aload_0
	//   15: monitorexit
	//   16: aload_3
	//   17: areturn
	//   18: astore_3
	//   19: aload_0
	//   20: monitorexit
	//   21: aload_3
	//   22: athrow
	// Exception table:
	//   from	to	target	type
	//   2	14	18	finally
  }

  public virtual Thread g()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: iconst_0
	//   4: putfield j : Z
	//   7: aload_0
	//   8: invokevirtual notifyAll : ()V
	//   11: aload_0
	//   12: getfield k : Ljava/lang/Thread;
	//   15: astore_1
	//   16: aload_0
	//   17: monitorexit
	//   18: aload_1
	//   19: areturn
	//   20: astore_1
	//   21: aload_0
	//   22: monitorexit
	//   23: aload_1
	//   24: athrow
	// Exception table:
	//   from	to	target	type
	//   2	16	20	finally
  }

  public virtual void run()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield j : Z
	//   6: ifeq -> 38
	//   9: aload_0
	//   10: getfield i : Lz;
	//   13: invokeinterface b : ()V
	//   18: aload_0
	//   19: getfield j : Z
	//   22: istore_1
	//   23: iload_1
	//   24: ifeq -> 2
	//   27: aload_0
	//   28: invokevirtual wait : ()V
	//   31: goto -> 2
	//   34: astore_2
	//   35: goto -> 2
	//   38: aload_0
	//   39: aconst_null
	//   40: putfield k : Ljava/lang/Thread;
	//   43: aload_0
	//   44: monitorexit
	//   45: return
	//   46: astore_2
	//   47: aload_0
	//   48: monitorexit
	//   49: aload_2
	//   50: athrow
	// Exception table:
	//   from	to	target	type
	//   2	23	46	finally
	//   27	31	34	java/lang/Exception
	//   27	31	46	finally
	//   38	43	46	finally
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ah.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */