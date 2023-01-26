using System;

public sealed class al
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private volatile int b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly int c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly int d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int e_Conflict;

  private am f;

  private am g;

  private readonly ad h;

  public al(int paramInt1, int paramInt2)
  {
	this.h = new ad(paramInt2);
	this.a_Conflict = paramInt2;
	this.c_Conflict = paramInt1;
	this.d_Conflict = Math.Max(paramInt1 / 6, 1);
	this.b_Conflict = 0;
	this.e_Conflict = 0;
  }

  private void a(int paramInt)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: iload_1
	//   3: istore_2
	//   4: iload_1
	//   5: ifge -> 10
	//   8: iconst_0
	//   9: istore_2
	//   10: aload_0
	//   11: getfield e : I
	//   14: iload_2
	//   15: if_icmple -> 30
	//   18: aload_0
	//   19: invokespecial c : ()V
	//   22: goto -> 10
	//   25: astore_3
	//   26: aload_0
	//   27: monitorexit
	//   28: aload_3
	//   29: athrow
	//   30: iload_2
	//   31: ifne -> 64
	//   34: ldc 'img cache map'
	//   36: ldc 'reset() clear all!'
	//   38: invokestatic w : (Ljava/lang/String;Ljava/lang/String;)I
	//   41: pop
	//   42: aload_0
	//   43: getfield h : Lad;
	//   46: invokevirtual a : ()V
	//   49: aload_0
	//   50: iconst_0
	//   51: putfield b : I
	//   54: aload_0
	//   55: aconst_null
	//   56: putfield g : Lam;
	//   59: aload_0
	//   60: aconst_null
	//   61: putfield f : Lam;
	//   64: aload_0
	//   65: monitorexit
	//   66: return
	// Exception table:
	//   from	to	target	type
	//   10	22	25	finally
	//   34	64	25	finally
  }

  private void c()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: invokespecial d : ()Lam;
	//   6: astore_1
	//   7: aload_1
	//   8: getfield f : Landroid/graphics/Bitmap;
	//   11: ifnull -> 24
	//   14: aload_0
	//   15: aload_0
	//   16: getfield b : I
	//   19: iconst_1
	//   20: isub
	//   21: putfield b : I
	//   24: aload_0
	//   25: getfield h : Lad;
	//   28: aload_1
	//   29: invokevirtual e : ()J
	//   32: invokevirtual a : (J)V
	//   35: aload_0
	//   36: monitorexit
	//   37: return
	//   38: astore_1
	//   39: aload_0
	//   40: monitorexit
	//   41: aload_1
	//   42: athrow
	// Exception table:
	//   from	to	target	type
	//   2	24	38	finally
	//   24	35	38	finally
  }

  private am d()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield g : Lam;
	//   6: astore_1
	//   7: aload_1
	//   8: ifnull -> 48
	//   11: aload_0
	//   12: aload_0
	//   13: getfield e : I
	//   16: iconst_1
	//   17: isub
	//   18: putfield e : I
	//   21: aload_1
	//   22: aconst_null
	//   23: putfield z : Lam;
	//   26: aload_1
	//   27: getfield y : Lam;
	//   30: astore_2
	//   31: aload_1
	//   32: aconst_null
	//   33: putfield y : Lam;
	//   36: aload_2
	//   37: ifnonnull -> 52
	//   40: aload_0
	//   41: aload_0
	//   42: getfield f : Lam;
	//   45: putfield g : Lam;
	//   48: aload_0
	//   49: monitorexit
	//   50: aload_1
	//   51: areturn
	//   52: aload_0
	//   53: aload_2
	//   54: putfield g : Lam;
	//   57: goto -> 48
	//   60: astore_1
	//   61: aload_0
	//   62: monitorexit
	//   63: aload_1
	//   64: athrow
	// Exception table:
	//   from	to	target	type
	//   2	7	60	finally
	//   11	36	60	finally
	//   40	48	60	finally
	//   52	57	60	finally
  }

  private void d(am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: aload_0
	//   4: getfield e : I
	//   7: iconst_1
	//   8: iadd
	//   9: putfield e : I
	//   12: aload_0
	//   13: getfield f : Lam;
	//   16: ifnonnull -> 42
	//   19: aload_0
	//   20: aload_1
	//   21: putfield f : Lam;
	//   24: aload_0
	//   25: aload_1
	//   26: putfield g : Lam;
	//   29: aload_1
	//   30: aconst_null
	//   31: putfield y : Lam;
	//   34: aload_1
	//   35: aconst_null
	//   36: putfield z : Lam;
	//   39: aload_0
	//   40: monitorexit
	//   41: return
	//   42: aload_0
	//   43: getfield f : Lam;
	//   46: aload_1
	//   47: putfield y : Lam;
	//   50: aload_1
	//   51: aconst_null
	//   52: putfield y : Lam;
	//   55: aload_1
	//   56: aload_0
	//   57: getfield f : Lam;
	//   60: putfield z : Lam;
	//   63: aload_0
	//   64: aload_1
	//   65: putfield f : Lam;
	//   68: goto -> 39
	//   71: astore_1
	//   72: aload_0
	//   73: monitorexit
	//   74: aload_1
	//   75: athrow
	// Exception table:
	//   from	to	target	type
	//   2	39	71	finally
	//   42	68	71	finally
  }

  private void e(am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_1
	//   3: aload_0
	//   4: getfield f : Lam;
	//   7: if_acmpeq -> 60
	//   10: aload_1
	//   11: aload_0
	//   12: getfield g : Lam;
	//   15: if_acmpne -> 63
	//   18: aload_0
	//   19: aload_1
	//   20: getfield y : Lam;
	//   23: putfield g : Lam;
	//   26: aload_0
	//   27: getfield g : Lam;
	//   30: aconst_null
	//   31: putfield z : Lam;
	//   34: aload_1
	//   35: aconst_null
	//   36: putfield y : Lam;
	//   39: aload_1
	//   40: aload_0
	//   41: getfield f : Lam;
	//   44: putfield z : Lam;
	//   47: aload_0
	//   48: getfield f : Lam;
	//   51: aload_1
	//   52: putfield y : Lam;
	//   55: aload_0
	//   56: aload_1
	//   57: putfield f : Lam;
	//   60: aload_0
	//   61: monitorexit
	//   62: return
	//   63: aload_1
	//   64: getfield y : Lam;
	//   67: aload_1
	//   68: getfield z : Lam;
	//   71: putfield z : Lam;
	//   74: aload_1
	//   75: getfield z : Lam;
	//   78: aload_1
	//   79: getfield y : Lam;
	//   82: putfield y : Lam;
	//   85: aload_1
	//   86: aconst_null
	//   87: putfield y : Lam;
	//   90: aload_1
	//   91: aconst_null
	//   92: putfield z : Lam;
	//   95: aload_0
	//   96: getfield f : Lam;
	//   99: ifnonnull -> 130
	//   102: aload_0
	//   103: aload_1
	//   104: putfield f : Lam;
	//   107: aload_0
	//   108: aload_1
	//   109: putfield g : Lam;
	//   112: aload_1
	//   113: aconst_null
	//   114: putfield y : Lam;
	//   117: aload_1
	//   118: aconst_null
	//   119: putfield z : Lam;
	//   122: goto -> 60
	//   125: astore_1
	//   126: aload_0
	//   127: monitorexit
	//   128: aload_1
	//   129: athrow
	//   130: aload_0
	//   131: getfield f : Lam;
	//   134: aload_1
	//   135: putfield y : Lam;
	//   138: aload_1
	//   139: aconst_null
	//   140: putfield y : Lam;
	//   143: aload_1
	//   144: aload_0
	//   145: getfield f : Lam;
	//   148: putfield z : Lam;
	//   151: aload_0
	//   152: aload_1
	//   153: putfield f : Lam;
	//   156: goto -> 60
	// Exception table:
	//   from	to	target	type
	//   2	60	125	finally
	//   63	122	125	finally
	//   130	156	125	finally
  }

  public am a(long paramLong)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield h : Lad;
	//   6: lload_1
	//   7: invokevirtual c : (J)Lam;
	//   10: astore_3
	//   11: aload_3
	//   12: ifnull -> 38
	//   15: aload_0
	//   16: getfield a : I
	//   19: ifle -> 38
	//   22: aload_0
	//   23: getfield h : Lad;
	//   26: lload_1
	//   27: invokevirtual b : (J)Z
	//   30: ifeq -> 42
	//   33: aload_0
	//   34: aload_3
	//   35: invokespecial e : (Lam;)V
	//   38: aload_0
	//   39: monitorexit
	//   40: aload_3
	//   41: areturn
	//   42: aload_0
	//   43: aload_3
	//   44: invokespecial d : (Lam;)V
	//   47: aload_0
	//   48: getfield h : Lad;
	//   51: lload_1
	//   52: aload_3
	//   53: invokevirtual a : (JLam;)V
	//   56: aload_0
	//   57: getfield e : I
	//   60: aload_0
	//   61: getfield a : I
	//   64: if_icmple -> 38
	//   67: aload_0
	//   68: invokespecial c : ()V
	//   71: goto -> 38
	//   74: astore_3
	//   75: aload_0
	//   76: monitorexit
	//   77: aload_3
	//   78: athrow
	// Exception table:
	//   from	to	target	type
	//   2	11	74	finally
	//   15	38	74	finally
	//   42	71	74	finally
  }

  internal void a()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield d : I
	//   6: istore_1
	//   7: aload_0
	//   8: getfield g : Lam;
	//   11: astore_2
	//   12: iload_1
	//   13: ifle -> 84
	//   16: aload_2
	//   17: ifnull -> 84
	//   20: iload_1
	//   21: istore_3
	//   22: aload_2
	//   23: getfield f : Landroid/graphics/Bitmap;
	//   26: ifnull -> 74
	//   29: iload_1
	//   30: istore_3
	//   31: aload_2
	//   32: getfield w : Z
	//   35: ifne -> 74
	//   38: aload_2
	//   39: iconst_0
	//   40: i2b
	//   41: putfield g : B
	//   44: aload_2
	//   45: iconst_m1
	//   46: i2b
	//   47: putfield l : B
	//   50: aload_2
	//   51: iconst_m1
	//   52: putfield u : I
	//   55: aload_2
	//   56: aconst_null
	//   57: putfield f : Landroid/graphics/Bitmap;
	//   60: iload_1
	//   61: iconst_1
	//   62: isub
	//   63: istore_3
	//   64: aload_0
	//   65: aload_0
	//   66: getfield b : I
	//   69: iconst_1
	//   70: isub
	//   71: putfield b : I
	//   74: aload_2
	//   75: getfield y : Lam;
	//   78: astore_2
	//   79: iload_3
	//   80: istore_1
	//   81: goto -> 12
	//   84: aload_0
	//   85: monitorexit
	//   86: return
	//   87: astore_2
	//   88: aload_0
	//   89: monitorexit
	//   90: aload_2
	//   91: athrow
	// Exception table:
	//   from	to	target	type
	//   2	12	87	finally
	//   22	29	87	finally
	//   31	60	87	finally
	//   64	74	87	finally
	//   74	79	87	finally
  }

  public void a(long paramLong, am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield a : I
	//   6: ifle -> 49
	//   9: aload_0
	//   10: getfield h : Lad;
	//   13: lload_1
	//   14: invokevirtual b : (J)Z
	//   17: ifne -> 49
	//   20: aload_0
	//   21: aload_3
	//   22: invokespecial d : (Lam;)V
	//   25: aload_0
	//   26: getfield h : Lad;
	//   29: lload_1
	//   30: aload_3
	//   31: invokevirtual a : (JLam;)V
	//   34: aload_0
	//   35: getfield e : I
	//   38: aload_0
	//   39: getfield a : I
	//   42: if_icmple -> 49
	//   45: aload_0
	//   46: invokespecial c : ()V
	//   49: aload_0
	//   50: monitorexit
	//   51: return
	//   52: astore_3
	//   53: aload_0
	//   54: monitorexit
	//   55: aload_3
	//   56: athrow
	// Exception table:
	//   from	to	target	type
	//   2	49	52	finally
  }

  public void a(am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield a : I
	//   6: ifle -> 28
	//   9: aload_0
	//   10: getfield h : Lad;
	//   13: aload_1
	//   14: invokevirtual e : ()J
	//   17: invokevirtual b : (J)Z
	//   20: ifeq -> 28
	//   23: aload_0
	//   24: aload_1
	//   25: invokespecial e : (Lam;)V
	//   28: aload_0
	//   29: monitorexit
	//   30: return
	//   31: astore_1
	//   32: aload_0
	//   33: monitorexit
	//   34: aload_1
	//   35: athrow
	// Exception table:
	//   from	to	target	type
	//   2	28	31	finally
  }

  internal void b()
  {
	a(0);
  }

  public void b(am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield h : Lad;
	//   6: aload_1
	//   7: invokevirtual e : ()J
	//   10: invokevirtual b : (J)Z
	//   13: ifeq -> 40
	//   16: aload_0
	//   17: getfield b : I
	//   20: istore_2
	//   21: aload_0
	//   22: iload_2
	//   23: iconst_1
	//   24: iadd
	//   25: putfield b : I
	//   28: iload_2
	//   29: aload_0
	//   30: getfield c : I
	//   33: if_icmple -> 40
	//   36: aload_0
	//   37: invokevirtual a : ()V
	//   40: aload_0
	//   41: monitorexit
	//   42: return
	//   43: astore_1
	//   44: aload_0
	//   45: monitorexit
	//   46: aload_1
	//   47: athrow
	// Exception table:
	//   from	to	target	type
	//   2	40	43	finally
  }

  public void c(am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield h : Lad;
	//   6: aload_1
	//   7: invokevirtual e : ()J
	//   10: invokevirtual b : (J)Z
	//   13: ifeq -> 26
	//   16: aload_0
	//   17: aload_0
	//   18: getfield b : I
	//   21: iconst_1
	//   22: isub
	//   23: putfield b : I
	//   26: aload_0
	//   27: monitorexit
	//   28: return
	//   29: astore_1
	//   30: aload_0
	//   31: monitorexit
	//   32: aload_1
	//   33: athrow
	// Exception table:
	//   from	to	target	type
	//   2	26	29	finally
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\al.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */