using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ru.yandex.yandexmapkit
{
	using aj;
	using by;
	using q;
	using r;
	using MapEvent = ru.yandex.yandexmapkit.map.MapEvent;
	using OnMapListener = ru.yandex.yandexmapkit.map.OnMapListener;
	using s;

	public sealed class MapController$Map : ThreadStart
	{
	  public const int MAX_ZOOM = 17;

	  public const int MIN_ZOOM = 1;

	  private int A;

	  private int B;

	  private bool C;

	  private int D;

	  private long E;

	  private int F;

	  private int G;

	  private Thread H = null;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public int a_Conflict = 1298148171;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public int b_Conflict = 673221848;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public readonly long[] c_Conflict = new long[24];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal float d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal float e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public bool f_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal bool g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal float h_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal float i_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal by j_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public System.Collections.IList k_Conflict = new ArrayList();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public readonly LinkedList l_Conflict = new LinkedList();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public object m_Conflict = new object();

	  private int o;

	  private int p;

	  private Thread q;

	  private bool r;

	  private float s;

	  private float t;

	  private long u;

	  private long v;

	  private bool w;

	  private int x;

	  private int y;

	  private int z;

	  public MapController$Map(MapController paramMapController)
	  {
		a(12);
		this.i_Conflict = k();
		this.f_Conflict = false;
		this.r = false;
		this.w = false;
		this.C = false;
		while (b_Conflict <= 23)
		{
		  this.c_Conflict[b_Conflict] = 1L << b_Conflict;
		  b_Conflict++;
		}
	  }

	  private void a(float paramFloat1, float paramFloat2, bool paramBoolean)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: fload_1
		//   4: fload_2
		//   5: iconst_1
		//   6: iload_3
		//   7: invokespecial a : (FFZZ)V
		//   10: aload_0
		//   11: monitorexit
		//   12: return
		//   13: astore #4
		//   15: aload_0
		//   16: monitorexit
		//   17: aload #4
		//   19: athrow
		// Exception table:
		//   from	to	target	type
		//   2	10	13	finally
	  }

	  private void a(float paramFloat1, float paramFloat2, bool paramBoolean1, bool paramBoolean2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: ldc2_w 2.0
		//   5: ldc 23.0
		//   7: aload_0
		//   8: getfield i : F
		//   11: fsub
		//   12: f2d
		//   13: invokestatic pow : (DD)D
		//   16: d2f
		//   17: fstore #5
		//   19: fload_1
		//   20: aload_0
		//   21: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   24: getfield c : Laq;
		//   27: invokevirtual d : ()F
		//   30: fdiv
		//   31: fload #5
		//   33: fmul
		//   34: f2l
		//   35: lstore #6
		//   37: fload #5
		//   39: fload_2
		//   40: aload_0
		//   41: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   44: getfield c : Laq;
		//   47: invokevirtual d : ()F
		//   50: fdiv
		//   51: fmul
		//   52: f2l
		//   53: lstore #8
		//   55: lload #6
		//   57: lstore #10
		//   59: lload #8
		//   61: lstore #12
		//   63: iload_3
		//   64: ifeq -> 107
		//   67: aload_0
		//   68: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   71: getfield b : Lah;
		//   74: lload #6
		//   76: l2f
		//   77: lload #8
		//   79: l2f
		//   80: invokevirtual f : (FF)Landroid/graphics/PointF;
		//   83: astore #14
		//   85: aload #14
		//   87: getfield x : F
		//   90: invokestatic round : (F)I
		//   93: i2l
		//   94: lstore #10
		//   96: aload #14
		//   98: getfield y : F
		//   101: invokestatic round : (F)I
		//   104: i2l
		//   105: lstore #12
		//   107: aload_0
		//   108: lload #10
		//   110: lload #12
		//   112: iload #4
		//   114: invokespecial a : (JJZ)V
		//   117: aload_0
		//   118: monitorexit
		//   119: return
		//   120: astore #14
		//   122: aload_0
		//   123: monitorexit
		//   124: aload #14
		//   126: athrow
		// Exception table:
		//   from	to	target	type
		//   2	55	120	finally
		//   67	107	120	finally
		//   107	117	120	finally
	  }

	  private void a(long paramLong1, long paramLong2, int paramInt, bool paramBoolean1, bool paramBoolean2, bool paramBoolean3)
	  {
		if (!paramBoolean3 || !this.n.b.a())
		{
		  float f1;
		  float f2;
		  int i = this.n.e.getWidth();
		  int j = this.n.e.getHeight();
		  if (paramBoolean2)
		  {
			f1 = this.n.b.b(i);
		  }
		  else
		  {
			f1 = (i / 2);
		  }
		  if (paramBoolean2)
		  {
			f2 = this.n.b.b(i, j);
		  }
		  else
		  {
			f2 = (j / 2);
		  }
		  if (this.n.b.a() && (this.n.b.e() != this.n.b.b(i) || this.n.b.f() != this.n.b.b(i, j)))
		  {
			a(-this.n.b.b(i) + this.n.b.e(), -this.n.b.b(i, j) + this.n.b.f(), false, false);
			a(this.n.b.b(i) - this.n.b.e(), this.n.b.b(i, j) - this.n.b.f(), false);
			this.n.b.a(this.n.b.b(i), this.n.b.b(i, j));
		  }
		  if (!paramBoolean2)
		  {
			a(-f1 + this.n.b.e(), -f2 + this.n.b.f(), false, false);
			a(f1 - this.n.b.e(), f2 - this.n.b.f(), false);
			this.n.b.a(f1, f2);
		  }
		  long l = (j / 2 - (int)Math.Round(f2, MidpointRounding.AwayFromZero) << this.n.c.c());
		  if (paramBoolean1)
		  {
			if (paramBoolean2 && this.n.b.a())
			{
			  i = 200;
			}
			else
			{
			  i = 700;
			}
		  }
		  else
		  {
			i = 0;
		  }
		  a(paramLong1, paramLong2 + l, paramInt, i);
		}
	  }

	  private void a(long paramLong1, long paramLong2, bool paramBoolean)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: getfield a : I
		//   6: i2l
		//   7: lload_1
		//   8: ladd
		//   9: lstore_1
		//   10: lload_1
		//   11: ldc2_w 2147483647
		//   14: lcmp
		//   15: ifle -> 61
		//   18: aload_0
		//   19: ldc 2147483647
		//   21: putfield a : I
		//   24: aload_0
		//   25: getfield b : I
		//   28: i2l
		//   29: lload_3
		//   30: ladd
		//   31: lstore_1
		//   32: lload_1
		//   33: ldc2_w 2147483647
		//   36: lcmp
		//   37: ifle -> 95
		//   40: aload_0
		//   41: ldc 2147483647
		//   43: putfield b : I
		//   46: iload #5
		//   48: ifeq -> 58
		//   51: aload_0
		//   52: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   55: invokevirtual notifyRepaint : ()V
		//   58: aload_0
		//   59: monitorexit
		//   60: return
		//   61: lload_1
		//   62: lconst_0
		//   63: lcmp
		//   64: ifge -> 82
		//   67: aload_0
		//   68: iconst_0
		//   69: putfield a : I
		//   72: goto -> 24
		//   75: astore #6
		//   77: aload_0
		//   78: monitorexit
		//   79: aload #6
		//   81: athrow
		//   82: lload_1
		//   83: l2i
		//   84: istore #7
		//   86: aload_0
		//   87: iload #7
		//   89: putfield a : I
		//   92: goto -> 24
		//   95: lload_1
		//   96: lconst_0
		//   97: lcmp
		//   98: ifge -> 109
		//   101: aload_0
		//   102: iconst_0
		//   103: putfield b : I
		//   106: goto -> 46
		//   109: aload_0
		//   110: lload_1
		//   111: l2i
		//   112: putfield b : I
		//   115: goto -> 46
		// Exception table:
		//   from	to	target	type
		//   2	10	75	finally
		//   18	24	75	finally
		//   24	32	75	finally
		//   40	46	75	finally
		//   51	58	75	finally
		//   67	72	75	finally
		//   86	92	75	finally
		//   101	106	75	finally
		//   109	115	75	finally
	  }

	  private void e(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: iconst_1
		//   1: istore_3
		//   2: aload_0
		//   3: monitorenter
		//   4: aload_0
		//   5: invokevirtual c : ()V
		//   8: iload_3
		//   9: istore #4
		//   11: fload_1
		//   12: ldc -0.1
		//   14: fcmpl
		//   15: ifge -> 28
		//   18: fload_2
		//   19: ldc -0.1
		//   21: fcmpl
		//   22: iflt -> 177
		//   25: iload_3
		//   26: istore #4
		//   28: aload_0
		//   29: getfield g : Z
		//   32: ifne -> 83
		//   35: aload_0
		//   36: aload_0
		//   37: getfield i : F
		//   40: putfield h : F
		//   43: iload #4
		//   45: ifeq -> 83
		//   48: aload_0
		//   49: aload_0
		//   50: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   53: getfield c : Laq;
		//   56: fload_1
		//   57: fload_2
		//   58: aload_0
		//   59: getfield j : Lby;
		//   62: invokevirtual a : (FFLby;)Lby;
		//   65: putfield j : Lby;
		//   68: ldc2_w 2.0
		//   71: ldc 23.0
		//   73: aload_0
		//   74: getfield h : F
		//   77: fsub
		//   78: f2d
		//   79: invokestatic pow : (DD)D
		//   82: pop2
		//   83: aload_0
		//   84: invokestatic currentTimeMillis : ()J
		//   87: putfield v : J
		//   90: aload_0
		//   91: iconst_1
		//   92: putfield g : Z
		//   95: new ru/yandex/yandexmapkit/map/MapEvent
		//   98: astore #5
		//   100: aload #5
		//   102: iconst_4
		//   103: invokespecial <init> : (I)V
		//   106: aload_0
		//   107: aload #5
		//   109: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   112: aload_0
		//   113: getfield q : Ljava/lang/Thread;
		//   116: ifnonnull -> 193
		//   119: new java/lang/Thread
		//   122: astore #5
		//   124: aload #5
		//   126: aload_0
		//   127: invokespecial <init> : (Ljava/lang/Runnable;)V
		//   130: aload_0
		//   131: aload #5
		//   133: putfield q : Ljava/lang/Thread;
		//   136: aload_0
		//   137: getfield q : Ljava/lang/Thread;
		//   140: ldc 'ymm-map-mover'
		//   142: invokevirtual setName : (Ljava/lang/String;)V
		//   145: aload_0
		//   146: getfield q : Ljava/lang/Thread;
		//   149: astore #5
		//   151: aload #5
		//   153: ifnull -> 183
		//   156: aload #5
		//   158: invokevirtual isAlive : ()Z
		//   161: ifeq -> 183
		//   164: invokestatic yield : ()V
		//   167: goto -> 151
		//   170: astore #5
		//   172: aload_0
		//   173: monitorexit
		//   174: aload #5
		//   176: athrow
		//   177: iconst_0
		//   178: istore #4
		//   180: goto -> 28
		//   183: aload_0
		//   184: getfield q : Ljava/lang/Thread;
		//   187: invokevirtual start : ()V
		//   190: aload_0
		//   191: monitorexit
		//   192: return
		//   193: aload_0
		//   194: invokevirtual notifyAll : ()V
		//   197: goto -> 190
		// Exception table:
		//   from	to	target	type
		//   4	8	170	finally
		//   28	43	170	finally
		//   48	83	170	finally
		//   83	151	170	finally
		//   156	167	170	finally
		//   183	190	170	finally
		//   193	197	170	finally
	  }

	  public void a()
	  {
		this.f_Conflict = false;
	  }

	  internal void a(float paramFloat)
	  {
		if (paramFloat >= 1.0F && paramFloat <= 17.0F)
		{
		  a((int)paramFloat);
		  this.i_Conflict = paramFloat;
		  this.n.notifyRepaint();
		}
	  }

	  internal void a(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: fload_1
		//   4: fload_2
		//   5: iconst_1
		//   6: invokespecial a : (FFZ)V
		//   9: aload_0
		//   10: monitorexit
		//   11: return
		//   12: astore_3
		//   13: aload_0
		//   14: monitorexit
		//   15: aload_3
		//   16: athrow
		// Exception table:
		//   from	to	target	type
		//   2	9	12	finally
	  }

	  public void a(float paramFloat1, float paramFloat2, float paramFloat3)
	  {
		if (this.g_Conflict)
		{
		  paramFloat3 = (float)Math.Log(paramFloat3) / 0.69314F + this.h_Conflict;
		  if (paramFloat3 <= 17.0F && paramFloat3 >= 1.0F)
		  {
			this.i_Conflict = paramFloat3;
			paramFloat3 = this.d_Conflict;
			float f = this.e_Conflict;
			this.d_Conflict = paramFloat1;
			this.e_Conflict = paramFloat2;
			a(paramFloat3 - paramFloat1, f - paramFloat2, true);
			a(new MapEvent(8));
		  }
		}
	  }

	  internal void a(int paramInt)
	  {
		if (paramInt > 0 && paramInt <= 17)
		{
		  this.o = paramInt;
		}
		MapController mapController = this.n;
		if (mapController.g_Conflict != null)
		{
		  if (mapController.a_Conflict.k() == 17)
		  {
			if (mapController.h_Conflict.isEnabled())
			{
			  mapController.h_Conflict.post((ThreadStart)new q(mapController));
			}
			return;
		  }
		}
		else
		{
		  return;
		}
		if (mapController.a_Conflict.k() == 1)
		{
		  if (mapController.i_Conflict.isEnabled())
		  {
			mapController.i_Conflict.post((ThreadStart)new r(mapController));
		  }
		  return;
		}
		if (!mapController.i_Conflict.isEnabled())
		{
		  mapController.i_Conflict.setEnabled(true);
		}
		if (!mapController.h_Conflict.isEnabled())
		{
		  mapController.h_Conflict.setEnabled(true);
		}
	  }

	  public void a(long paramLong1, long paramLong2, int paramInt1, int paramInt2)
	  {
		// Byte code:
		//   0: ldc 2147483647
		//   2: istore #7
		//   4: aload_0
		//   5: monitorenter
		//   6: lload_1
		//   7: ldc2_w 2147483647
		//   10: lcmp
		//   11: ifle -> 266
		//   14: ldc 2147483647
		//   16: istore #8
		//   18: lload_3
		//   19: ldc2_w 2147483647
		//   22: lcmp
		//   23: ifle -> 285
		//   26: iload #8
		//   28: aload_0
		//   29: getfield a : I
		//   32: if_icmpne -> 60
		//   35: iload #7
		//   37: aload_0
		//   38: getfield b : I
		//   41: if_icmpne -> 60
		//   44: aload_0
		//   45: getfield g : Z
		//   48: ifne -> 60
		//   51: iload #5
		//   53: aload_0
		//   54: invokevirtual k : ()I
		//   57: if_icmpeq -> 311
		//   60: iload #6
		//   62: ifle -> 328
		//   65: aload_0
		//   66: getfield g : Z
		//   69: ifne -> 328
		//   72: iload #5
		//   74: aload_0
		//   75: invokevirtual k : ()I
		//   78: if_icmpne -> 328
		//   81: aload_0
		//   82: iload #8
		//   84: putfield z : I
		//   87: aload_0
		//   88: iload #7
		//   90: putfield A : I
		//   93: aload_0
		//   94: iload #5
		//   96: putfield B : I
		//   99: iload #5
		//   101: aload_0
		//   102: invokevirtual k : ()I
		//   105: if_icmple -> 114
		//   108: aload_0
		//   109: iload #5
		//   111: invokevirtual a : (I)V
		//   114: aload_0
		//   115: iload #6
		//   117: putfield D : I
		//   120: aload_0
		//   121: invokestatic currentTimeMillis : ()J
		//   124: putfield E : J
		//   127: aload_0
		//   128: aload_0
		//   129: getfield a : I
		//   132: putfield x : I
		//   135: aload_0
		//   136: aload_0
		//   137: getfield b : I
		//   140: putfield y : I
		//   143: aload_0
		//   144: aload_0
		//   145: getfield z : I
		//   148: aload_0
		//   149: getfield x : I
		//   152: isub
		//   153: aload_0
		//   154: getfield D : I
		//   157: idiv
		//   158: putfield F : I
		//   161: aload_0
		//   162: aload_0
		//   163: getfield A : I
		//   166: aload_0
		//   167: getfield y : I
		//   170: isub
		//   171: aload_0
		//   172: getfield D : I
		//   175: idiv
		//   176: putfield G : I
		//   179: aload_0
		//   180: iconst_1
		//   181: putfield C : Z
		//   184: new ru/yandex/yandexmapkit/map/MapEvent
		//   187: astore #9
		//   189: aload #9
		//   191: iconst_1
		//   192: invokespecial <init> : (I)V
		//   195: aload_0
		//   196: aload #9
		//   198: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   201: aload_0
		//   202: getfield q : Ljava/lang/Thread;
		//   205: ifnonnull -> 321
		//   208: new java/lang/Thread
		//   211: astore #9
		//   213: aload #9
		//   215: aload_0
		//   216: invokespecial <init> : (Ljava/lang/Runnable;)V
		//   219: aload_0
		//   220: aload #9
		//   222: putfield q : Ljava/lang/Thread;
		//   225: aload_0
		//   226: getfield q : Ljava/lang/Thread;
		//   229: ldc 'ymm-map-mover'
		//   231: invokevirtual setName : (Ljava/lang/String;)V
		//   234: aload_0
		//   235: getfield q : Ljava/lang/Thread;
		//   238: astore #9
		//   240: aload #9
		//   242: ifnull -> 304
		//   245: aload #9
		//   247: invokevirtual isAlive : ()Z
		//   250: ifeq -> 304
		//   253: invokestatic yield : ()V
		//   256: goto -> 240
		//   259: astore #9
		//   261: aload_0
		//   262: monitorexit
		//   263: aload #9
		//   265: athrow
		//   266: lload_1
		//   267: lconst_0
		//   268: lcmp
		//   269: ifge -> 278
		//   272: iconst_0
		//   273: istore #8
		//   275: goto -> 18
		//   278: lload_1
		//   279: l2i
		//   280: istore #8
		//   282: goto -> 18
		//   285: lload_3
		//   286: lconst_0
		//   287: lcmp
		//   288: ifge -> 297
		//   291: iconst_0
		//   292: istore #7
		//   294: goto -> 26
		//   297: lload_3
		//   298: l2i
		//   299: istore #7
		//   301: goto -> 26
		//   304: aload_0
		//   305: getfield q : Ljava/lang/Thread;
		//   308: invokevirtual start : ()V
		//   311: aload_0
		//   312: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   315: invokevirtual notifyRepaint : ()V
		//   318: aload_0
		//   319: monitorexit
		//   320: return
		//   321: aload_0
		//   322: invokevirtual notifyAll : ()V
		//   325: goto -> 311
		//   328: aload_0
		//   329: iload #8
		//   331: putfield a : I
		//   334: aload_0
		//   335: iload #7
		//   337: putfield b : I
		//   340: aload_0
		//   341: iload #5
		//   343: i2f
		//   344: invokevirtual a : (F)V
		//   347: goto -> 311
		// Exception table:
		//   from	to	target	type
		//   26	60	259	finally
		//   65	114	259	finally
		//   114	240	259	finally
		//   245	256	259	finally
		//   304	311	259	finally
		//   311	318	259	finally
		//   321	325	259	finally
		//   328	347	259	finally
	  }

	  internal void a(MapEvent paramMapEvent)
	  {
		lock (this.m_Conflict)
		{
		  Monitor.Pulse(this.m_Conflict);
		  this.l_Conflict.AddLast(paramMapEvent);
		  if (this.H == null || !this.H.IsAlive)
		  {
			this.H = null;
			Thread thread = new Thread();
			s s = new s();
			this(this);
			this((ThreadStart)s);
			this.H = thread;
			this.H.Start();
		  }
		  return;
		}
	  }

	  internal void a(OnMapListener paramOnMapListener)
	  {
		lock (this.k_Conflict)
		{
		  this.k_Conflict.Add(paramOnMapListener);
		  return;
		}
	  }

	  public aj b()
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: new aj
		//   5: dup
		//   6: aload_0
		//   7: getfield a : I
		//   10: aload_0
		//   11: getfield b : I
		//   14: aload_0
		//   15: invokevirtual k : ()I
		//   18: invokespecial <init> : (III)V
		//   21: astore_1
		//   22: aload_0
		//   23: monitorexit
		//   24: aload_1
		//   25: areturn
		//   26: astore_1
		//   27: aload_0
		//   28: monitorexit
		//   29: aload_1
		//   30: athrow
		// Exception table:
		//   from	to	target	type
		//   2	22	26	finally
	  }

	  internal void b(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: invokevirtual k : ()I
		//   6: bipush #17
		//   8: if_icmpge -> 44
		//   11: aload_0
		//   12: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   15: getfield c : Laq;
		//   18: invokevirtual k : ()V
		//   21: aload_0
		//   22: fload_1
		//   23: fload_2
		//   24: invokespecial e : (FF)V
		//   27: aload_0
		//   28: aload_0
		//   29: invokevirtual k : ()I
		//   32: iconst_1
		//   33: iadd
		//   34: invokevirtual b : (I)V
		//   37: aload_0
		//   38: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   41: invokevirtual notifyRepaint : ()V
		//   44: aload_0
		//   45: monitorexit
		//   46: return
		//   47: astore_3
		//   48: aload_0
		//   49: monitorexit
		//   50: aload_3
		//   51: athrow
		// Exception table:
		//   from	to	target	type
		//   2	44	47	finally
	  }

	  public void b(int paramInt)
	  {
		if (paramInt > 0 && paramInt <= 17)
		{
		  this.p = paramInt;
		}
	  }

	  internal void b(OnMapListener paramOnMapListener)
	  {
		lock (this.k_Conflict)
		{
		  this.k_Conflict.Remove(paramOnMapListener);
		  return;
		}
	  }

	  internal void c()
	  {
		this.r = false;
		this.w = false;
		if (this.C)
		{
		  this.C = false;
		  this.a_Conflict = this.z;
		  this.b_Conflict = this.A;
		  a(this.B);
		  this.n.notifyRepaint();
		}
	  }

	  internal void c(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: invokevirtual k : ()I
		//   6: iconst_1
		//   7: if_icmple -> 43
		//   10: aload_0
		//   11: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   14: getfield c : Laq;
		//   17: invokevirtual k : ()V
		//   20: aload_0
		//   21: fload_1
		//   22: fload_2
		//   23: invokespecial e : (FF)V
		//   26: aload_0
		//   27: aload_0
		//   28: invokevirtual k : ()I
		//   31: iconst_1
		//   32: isub
		//   33: invokevirtual b : (I)V
		//   36: aload_0
		//   37: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   40: invokevirtual notifyRepaint : ()V
		//   43: aload_0
		//   44: monitorexit
		//   45: return
		//   46: astore_3
		//   47: aload_0
		//   48: monitorexit
		//   49: aload_3
		//   50: athrow
		// Exception table:
		//   from	to	target	type
		//   2	43	46	finally
	  }

	  internal Thread d()
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: iconst_1
		//   4: putfield f : Z
		//   7: aload_0
		//   8: getfield m : Ljava/lang/Object;
		//   11: astore_1
		//   12: aload_1
		//   13: monitorenter
		//   14: aload_0
		//   15: getfield m : Ljava/lang/Object;
		//   18: invokevirtual notify : ()V
		//   21: aload_1
		//   22: monitorexit
		//   23: aload_0
		//   24: invokevirtual notifyAll : ()V
		//   27: aload_0
		//   28: getfield q : Ljava/lang/Thread;
		//   31: astore_1
		//   32: aload_0
		//   33: monitorexit
		//   34: aload_1
		//   35: areturn
		//   36: astore_2
		//   37: aload_1
		//   38: monitorexit
		//   39: aload_2
		//   40: athrow
		//   41: astore_1
		//   42: aload_0
		//   43: monitorexit
		//   44: aload_1
		//   45: athrow
		// Exception table:
		//   from	to	target	type
		//   2	14	41	finally
		//   14	23	36	finally
		//   23	32	41	finally
		//   37	41	41	finally
	  }

	  internal void d(float paramFloat1, float paramFloat2)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: getfield C : Z
		//   6: ifne -> 147
		//   9: fload_1
		//   10: ldc_w 3.0
		//   13: fdiv
		//   14: invokestatic abs : (F)F
		//   17: fload_2
		//   18: ldc_w 3.0
		//   21: fdiv
		//   22: invokestatic abs : (F)F
		//   25: invokestatic b : (FF)F
		//   28: fstore_3
		//   29: fload_1
		//   30: fstore #4
		//   32: fload_2
		//   33: fstore #5
		//   35: fload_3
		//   36: fconst_1
		//   37: fcmpl
		//   38: ifle -> 51
		//   41: fload_1
		//   42: fload_3
		//   43: fdiv
		//   44: fstore #4
		//   46: fload_2
		//   47: fload_3
		//   48: fdiv
		//   49: fstore #5
		//   51: aload_0
		//   52: fload #4
		//   54: putfield s : F
		//   57: aload_0
		//   58: fload #5
		//   60: putfield t : F
		//   63: aload_0
		//   64: invokestatic currentTimeMillis : ()J
		//   67: putfield u : J
		//   70: aload_0
		//   71: iconst_1
		//   72: putfield r : Z
		//   75: aload_0
		//   76: getfield q : Ljava/lang/Thread;
		//   79: ifnonnull -> 150
		//   82: new java/lang/Thread
		//   85: astore #6
		//   87: aload #6
		//   89: aload_0
		//   90: invokespecial <init> : (Ljava/lang/Runnable;)V
		//   93: aload_0
		//   94: aload #6
		//   96: putfield q : Ljava/lang/Thread;
		//   99: aload_0
		//   100: getfield q : Ljava/lang/Thread;
		//   103: ldc 'ymm-map-mover'
		//   105: invokevirtual setName : (Ljava/lang/String;)V
		//   108: aload_0
		//   109: getfield q : Ljava/lang/Thread;
		//   112: astore #6
		//   114: aload #6
		//   116: ifnull -> 140
		//   119: aload #6
		//   121: invokevirtual isAlive : ()Z
		//   124: ifeq -> 140
		//   127: invokestatic yield : ()V
		//   130: goto -> 114
		//   133: astore #6
		//   135: aload_0
		//   136: monitorexit
		//   137: aload #6
		//   139: athrow
		//   140: aload_0
		//   141: getfield q : Ljava/lang/Thread;
		//   144: invokevirtual start : ()V
		//   147: aload_0
		//   148: monitorexit
		//   149: return
		//   150: aload_0
		//   151: invokevirtual notifyAll : ()V
		//   154: goto -> 147
		// Exception table:
		//   from	to	target	type
		//   2	29	133	finally
		//   51	114	133	finally
		//   119	130	133	finally
		//   140	147	133	finally
		//   150	154	133	finally
	  }

	  public bool e()
	  {
		return this.g_Conflict;
	  }

	  public float f()
	  {
		return this.i_Conflict - this.h_Conflict;
	  }

	  public void g()
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: getfield g : Z
		//   6: ifne -> 18
		//   9: aload_0
		//   10: iconst_1
		//   11: putfield w : Z
		//   14: aload_0
		//   15: invokevirtual notifyAll : ()V
		//   18: aload_0
		//   19: monitorexit
		//   20: return
		//   21: astore_1
		//   22: aload_0
		//   23: monitorexit
		//   24: aload_1
		//   25: athrow
		// Exception table:
		//   from	to	target	type
		//   2	18	21	finally
	  }

	  public void h()
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: getfield g : Z
		//   6: ifne -> 14
		//   9: aload_0
		//   10: iconst_0
		//   11: putfield w : Z
		//   14: aload_0
		//   15: monitorexit
		//   16: return
		//   17: astore_1
		//   18: aload_0
		//   19: monitorexit
		//   20: aload_1
		//   21: athrow
		// Exception table:
		//   from	to	target	type
		//   2	14	17	finally
	  }

	  public bool i()
	  {
		return this.w;
	  }

	  public float j()
	  {
		return this.i_Conflict;
	  }

	  public int k()
	  {
		return this.o;
	  }

	  public int l()
	  {
		return this.p;
	  }

	  public int m()
	  {
		return this.a_Conflict;
	  }

	  public int n()
	  {
		return this.b_Conflict;
	  }

	  public void run()
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: getfield f : Z
		//   6: ifne -> 158
		//   9: aload_0
		//   10: getfield r : Z
		//   13: ifeq -> 217
		//   16: aload_0
		//   17: getfield f : Z
		//   20: istore_1
		//   21: iload_1
		//   22: ifne -> 217
		//   25: aload_0
		//   26: ldc2_w 40
		//   29: invokevirtual wait : (J)V
		//   32: aload_0
		//   33: getfield r : Z
		//   36: ifeq -> 200
		//   39: new ru/yandex/yandexmapkit/map/MapEvent
		//   42: astore_2
		//   43: aload_2
		//   44: iconst_2
		//   45: invokespecial <init> : (I)V
		//   48: aload_0
		//   49: aload_2
		//   50: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   53: invokestatic currentTimeMillis : ()J
		//   56: lstore_3
		//   57: lload_3
		//   58: aload_0
		//   59: getfield u : J
		//   62: lsub
		//   63: lstore #5
		//   65: aload_0
		//   66: lload_3
		//   67: putfield u : J
		//   70: aload_0
		//   71: aload_0
		//   72: getfield s : F
		//   75: ldc_w 0.79
		//   78: fmul
		//   79: putfield s : F
		//   82: aload_0
		//   83: aload_0
		//   84: getfield t : F
		//   87: ldc_w 0.79
		//   90: fmul
		//   91: putfield t : F
		//   94: aload_0
		//   95: getfield s : F
		//   98: lload #5
		//   100: l2f
		//   101: fmul
		//   102: fstore #7
		//   104: aload_0
		//   105: getfield t : F
		//   108: lload #5
		//   110: l2f
		//   111: fmul
		//   112: fstore #8
		//   114: fload #7
		//   116: fconst_1
		//   117: fcmpl
		//   118: ifgt -> 146
		//   121: fload #7
		//   123: ldc_w -1.0
		//   126: fcmpg
		//   127: iflt -> 146
		//   130: fload #8
		//   132: fconst_1
		//   133: fcmpl
		//   134: ifgt -> 146
		//   137: fload #8
		//   139: ldc_w -1.0
		//   142: fcmpg
		//   143: ifge -> 166
		//   146: aload_0
		//   147: fload #7
		//   149: fload #8
		//   151: invokevirtual a : (FF)V
		//   154: goto -> 9
		//   157: astore_2
		//   158: aload_0
		//   159: aconst_null
		//   160: putfield q : Ljava/lang/Thread;
		//   163: aload_0
		//   164: monitorexit
		//   165: return
		//   166: lload #5
		//   168: lconst_0
		//   169: lcmp
		//   170: ifle -> 9
		//   173: aload_0
		//   174: iconst_0
		//   175: putfield r : Z
		//   178: new ru/yandex/yandexmapkit/map/MapEvent
		//   181: astore_2
		//   182: aload_2
		//   183: iconst_3
		//   184: invokespecial <init> : (I)V
		//   187: aload_0
		//   188: aload_2
		//   189: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   192: goto -> 9
		//   195: astore_2
		//   196: aload_0
		//   197: monitorexit
		//   198: aload_2
		//   199: athrow
		//   200: new ru/yandex/yandexmapkit/map/MapEvent
		//   203: astore_2
		//   204: aload_2
		//   205: iconst_3
		//   206: invokespecial <init> : (I)V
		//   209: aload_0
		//   210: aload_2
		//   211: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   214: goto -> 9
		//   217: aload_0
		//   218: getfield C : Z
		//   221: ifeq -> 424
		//   224: aload_0
		//   225: getfield f : Z
		//   228: istore_1
		//   229: iload_1
		//   230: ifne -> 424
		//   233: aload_0
		//   234: ldc2_w 40
		//   237: invokevirtual wait : (J)V
		//   240: aload_0
		//   241: getfield C : Z
		//   244: ifeq -> 407
		//   247: new ru/yandex/yandexmapkit/map/MapEvent
		//   250: astore_2
		//   251: aload_2
		//   252: iconst_2
		//   253: invokespecial <init> : (I)V
		//   256: aload_0
		//   257: aload_2
		//   258: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   261: invokestatic currentTimeMillis : ()J
		//   264: aload_0
		//   265: getfield E : J
		//   268: lsub
		//   269: lstore #9
		//   271: aload_0
		//   272: getfield F : I
		//   275: i2l
		//   276: lstore #11
		//   278: aload_0
		//   279: getfield x : I
		//   282: i2l
		//   283: lstore_3
		//   284: aload_0
		//   285: getfield G : I
		//   288: i2l
		//   289: lstore #5
		//   291: aload_0
		//   292: getfield y : I
		//   295: i2l
		//   296: lstore #13
		//   298: aload_0
		//   299: getfield C : Z
		//   302: ifeq -> 343
		//   305: lload #9
		//   307: aload_0
		//   308: getfield D : I
		//   311: i2l
		//   312: lcmp
		//   313: ifge -> 343
		//   316: aload_0
		//   317: lload #11
		//   319: lload #9
		//   321: lmul
		//   322: lload_3
		//   323: ladd
		//   324: lload #5
		//   326: lload #9
		//   328: lmul
		//   329: lload #13
		//   331: ladd
		//   332: aload_0
		//   333: invokevirtual k : ()I
		//   336: iconst_0
		//   337: invokevirtual a : (JJII)V
		//   340: goto -> 217
		//   343: aload_0
		//   344: getfield C : Z
		//   347: ifeq -> 385
		//   350: aload_0
		//   351: aload_0
		//   352: getfield z : I
		//   355: i2l
		//   356: aload_0
		//   357: getfield A : I
		//   360: i2l
		//   361: aload_0
		//   362: getfield B : I
		//   365: iconst_0
		//   366: invokevirtual a : (JJII)V
		//   369: aload_0
		//   370: aload_0
		//   371: getfield z : I
		//   374: putfield a : I
		//   377: aload_0
		//   378: aload_0
		//   379: getfield A : I
		//   382: putfield b : I
		//   385: aload_0
		//   386: iconst_0
		//   387: putfield C : Z
		//   390: new ru/yandex/yandexmapkit/map/MapEvent
		//   393: astore_2
		//   394: aload_2
		//   395: iconst_3
		//   396: invokespecial <init> : (I)V
		//   399: aload_0
		//   400: aload_2
		//   401: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   404: goto -> 217
		//   407: new ru/yandex/yandexmapkit/map/MapEvent
		//   410: astore_2
		//   411: aload_2
		//   412: iconst_3
		//   413: invokespecial <init> : (I)V
		//   416: aload_0
		//   417: aload_2
		//   418: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   421: goto -> 217
		//   424: aload_0
		//   425: getfield g : Z
		//   428: ifeq -> 665
		//   431: aload_0
		//   432: getfield f : Z
		//   435: istore_1
		//   436: iload_1
		//   437: ifne -> 665
		//   440: aload_0
		//   441: ldc2_w 45
		//   444: invokevirtual wait : (J)V
		//   447: aload_0
		//   448: getfield g : Z
		//   451: ifeq -> 655
		//   454: new ru/yandex/yandexmapkit/map/MapEvent
		//   457: astore_2
		//   458: aload_2
		//   459: iconst_5
		//   460: invokespecial <init> : (I)V
		//   463: aload_0
		//   464: aload_2
		//   465: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   468: invokestatic currentTimeMillis : ()J
		//   471: lstore #5
		//   473: lload #5
		//   475: aload_0
		//   476: getfield v : J
		//   479: lsub
		//   480: l2f
		//   481: fstore #7
		//   483: aload_0
		//   484: lload #5
		//   486: putfield v : J
		//   489: fload #7
		//   491: ldc_w 300.0
		//   494: fdiv
		//   495: fstore #7
		//   497: aload_0
		//   498: getfield i : F
		//   501: aload_0
		//   502: invokevirtual l : ()I
		//   505: i2f
		//   506: fcmpl
		//   507: ifle -> 586
		//   510: aload_0
		//   511: getfield i : F
		//   514: fload #7
		//   516: fsub
		//   517: aload_0
		//   518: invokevirtual l : ()I
		//   521: i2f
		//   522: fcmpg
		//   523: ifge -> 572
		//   526: aload_0
		//   527: aload_0
		//   528: invokevirtual l : ()I
		//   531: i2f
		//   532: invokevirtual a : (F)V
		//   535: aload_0
		//   536: iconst_0
		//   537: putfield g : Z
		//   540: aload_0
		//   541: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   544: invokevirtual notifyRepaint : ()V
		//   547: new ru/yandex/yandexmapkit/map/MapEvent
		//   550: astore_2
		//   551: aload_2
		//   552: bipush #6
		//   554: invokespecial <init> : (I)V
		//   557: aload_0
		//   558: aload_2
		//   559: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   562: aload_0
		//   563: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   566: invokevirtual notifyRepaint : ()V
		//   569: goto -> 424
		//   572: aload_0
		//   573: aload_0
		//   574: getfield i : F
		//   577: fload #7
		//   579: fsub
		//   580: putfield i : F
		//   583: goto -> 562
		//   586: aload_0
		//   587: getfield i : F
		//   590: fload #7
		//   592: fadd
		//   593: aload_0
		//   594: invokevirtual l : ()I
		//   597: i2f
		//   598: fcmpl
		//   599: ifle -> 641
		//   602: aload_0
		//   603: aload_0
		//   604: invokevirtual l : ()I
		//   607: i2f
		//   608: invokevirtual a : (F)V
		//   611: aload_0
		//   612: iconst_0
		//   613: putfield g : Z
		//   616: aload_0
		//   617: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   620: invokevirtual notifyRepaint : ()V
		//   623: new ru/yandex/yandexmapkit/map/MapEvent
		//   626: astore_2
		//   627: aload_2
		//   628: bipush #6
		//   630: invokespecial <init> : (I)V
		//   633: aload_0
		//   634: aload_2
		//   635: invokevirtual a : (Lru/yandex/yandexmapkit/map/MapEvent;)V
		//   638: goto -> 562
		//   641: aload_0
		//   642: fload #7
		//   644: aload_0
		//   645: getfield i : F
		//   648: fadd
		//   649: putfield i : F
		//   652: goto -> 562
		//   655: aload_0
		//   656: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   659: invokevirtual notifyRepaint : ()V
		//   662: goto -> 424
		//   665: aload_0
		//   666: getfield w : Z
		//   669: ifeq -> 705
		//   672: aload_0
		//   673: getfield f : Z
		//   676: istore_1
		//   677: iload_1
		//   678: ifne -> 705
		//   681: aload_0
		//   682: ldc2_w 45
		//   685: invokevirtual wait : (J)V
		//   688: aload_0
		//   689: getfield w : Z
		//   692: ifeq -> 665
		//   695: aload_0
		//   696: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   699: invokevirtual notifyRepaint : ()V
		//   702: goto -> 665
		//   705: aload_0
		//   706: getfield f : Z
		//   709: ifne -> 2
		//   712: aload_0
		//   713: getfield g : Z
		//   716: ifne -> 2
		//   719: aload_0
		//   720: getfield w : Z
		//   723: ifne -> 2
		//   726: aload_0
		//   727: getfield r : Z
		//   730: istore_1
		//   731: iload_1
		//   732: ifne -> 2
		//   735: aload_0
		//   736: getfield n : Lru/yandex/yandexmapkit/MapController;
		//   739: invokevirtual notifyRepaint : ()V
		//   742: aload_0
		//   743: invokevirtual wait : ()V
		//   746: goto -> 2
		//   749: astore_2
		//   750: goto -> 2
		//   753: astore_2
		//   754: goto -> 32
		//   757: astore_2
		//   758: goto -> 240
		//   761: astore_2
		//   762: goto -> 447
		//   765: astore_2
		//   766: goto -> 688
		// Exception table:
		//   from	to	target	type
		//   2	9	157	java/lang/Throwable
		//   2	9	195	finally
		//   9	21	157	java/lang/Throwable
		//   9	21	195	finally
		//   25	32	753	java/lang/Exception
		//   25	32	157	java/lang/Throwable
		//   25	32	195	finally
		//   32	114	157	java/lang/Throwable
		//   32	114	195	finally
		//   146	154	157	java/lang/Throwable
		//   146	154	195	finally
		//   158	163	195	finally
		//   173	192	157	java/lang/Throwable
		//   173	192	195	finally
		//   200	214	157	java/lang/Throwable
		//   200	214	195	finally
		//   217	229	157	java/lang/Throwable
		//   217	229	195	finally
		//   233	240	757	java/lang/Exception
		//   233	240	157	java/lang/Throwable
		//   233	240	195	finally
		//   240	340	157	java/lang/Throwable
		//   240	340	195	finally
		//   343	385	157	java/lang/Throwable
		//   343	385	195	finally
		//   385	404	157	java/lang/Throwable
		//   385	404	195	finally
		//   407	421	157	java/lang/Throwable
		//   407	421	195	finally
		//   424	436	157	java/lang/Throwable
		//   424	436	195	finally
		//   440	447	761	java/lang/Exception
		//   440	447	157	java/lang/Throwable
		//   440	447	195	finally
		//   447	489	157	java/lang/Throwable
		//   447	489	195	finally
		//   497	562	157	java/lang/Throwable
		//   497	562	195	finally
		//   562	569	157	java/lang/Throwable
		//   562	569	195	finally
		//   572	583	157	java/lang/Throwable
		//   572	583	195	finally
		//   586	638	157	java/lang/Throwable
		//   586	638	195	finally
		//   641	652	157	java/lang/Throwable
		//   641	652	195	finally
		//   655	662	157	java/lang/Throwable
		//   655	662	195	finally
		//   665	677	157	java/lang/Throwable
		//   665	677	195	finally
		//   681	688	765	java/lang/Exception
		//   681	688	157	java/lang/Throwable
		//   681	688	195	finally
		//   688	702	157	java/lang/Throwable
		//   688	702	195	finally
		//   705	731	157	java/lang/Throwable
		//   705	731	195	finally
		//   735	746	749	java/lang/Exception
		//   735	746	157	java/lang/Throwable
		//   735	746	195	finally
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\MapController$Map.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}