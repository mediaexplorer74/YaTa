using System;
using System.Collections.Generic;

public sealed class au : cd
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public readonly at[][] a_Conflict = new at[20][];

  public readonly SortedDictionary b = new SortedDictionary<object, object>();

  private int c;

  private int d;

  private float e;

  private float f;

  private int g;

  private int h;

  private int i;

  private int j;

  private int k;

  private float l;

  private float m;

  private float n;

  private float o;

  private float p;

  private float q;

  private float r;

  private bool s;

  public override void a(string paramString)
  {
	if (paramString.Equals("arrows"))
	{
	  this.d = 0;
	  return;
	}
	if (paramString.Equals("zoom"))
	{
	  at[] arrayOfAt;
	  this.d = 0;
	  int i = this.g;
	  if (i > this.a_Conflict.Length)
	  {
		at[] arrayOfAt1 = (at[])this.b[Convert.ToInt32(i)];
		arrayOfAt = arrayOfAt1;
		if (arrayOfAt1 == null)
		{
		  arrayOfAt = new at[24];
		  this.b[Convert.ToInt32(i)] = arrayOfAt;
		}
	  }
	  else
	  {
		if (this.a_Conflict[i] == null)
		{
		  this.a_Conflict[i] = new at[24];
		}
		arrayOfAt = this.a_Conflict[i];
	  }
	  i = this.h;
	  while (true)
	  {
		if (i <= this.i)
		{
		  arrayOfAt[i] = new at(this.e, this.f, this.j, this.l, this.m, this.s, this.k, this.n, this.o, this.p, this.q, this.r);
		  i++;
		  continue;
		}
		return;
	  }
	}
  }

  public override void a(string paramString, cc paramcc)
  {
	this.c = 0;
	if (paramString.Equals("style"))
	{
	  this.c = 1;
	  try
	  {
		this.g = int.Parse(paramcc.a("id"));
	  }
	  catch (Exception)
	  {
	  }
	  try
	  {
		paramString = paramcc.a("speed_from");
		if (!string.ReferenceEquals(paramString, null) && !paramString.Equals(""))
		{
		  this.e = float.Parse(paramString);
		}
		else
		{
		  this.e = -2.0F;
		}
	  }
	  catch (System.FormatException)
	  {
		this.e = -2.0F;
	  }
	  try
	  {
		paramString = paramcc.a("speed_to");
		if (!string.ReferenceEquals(paramString, null) && !paramString.Equals(""))
		{
		  this.f = float.Parse(paramString);
		  return;
		}
		this.f = -2.0F;
	  }
	  catch (System.FormatException)
	  {
		this.f = -2.0F;
	  }
	}
	if (exception.Equals("zoom"))
	{
	  this.s = false;
	  this.m = 0.0F;
	  this.d = 2;
	  this.c = 2;
	  this.h = 0;
	  this.i = 23;
	  try
	  {
		this.h = int.Parse(paramcc.a("from"));
		this.i = int.Parse(paramcc.a("to"));
		if (this.h < 0)
		{
		  this.h = 0;
		}
		if (this.i > 23)
		{
		  this.i = 23;
		}
	  }
	  catch (Exception)
	  {
	  }
	  return;
	}
	if (this.d == 2)
	{
	  if (exception.Equals("line_color"))
	  {
		this.c = 3;
		return;
	  }
	  if (exception.Equals("line_width"))
	  {
		this.c = 4;
		return;
	  }
	  if (exception.Equals("line_width_street_modifier"))
	  {
		this.c = 12;
		return;
	  }
	  if (exception.Equals("arrows"))
	  {
		this.d = 5;
		this.c = 5;
		this.s = true;
	  }
	  return;
	}
	if (this.d == 5)
	{
	  if (exception.Equals("color"))
	  {
		this.c = 6;
		return;
	  }
	  if (exception.Equals("dash"))
	  {
		this.c = 7;
		return;
	  }
	  if (exception.Equals("space"))
	  {
		this.c = 8;
		return;
	  }
	  if (exception.Equals("thickness"))
	  {
		this.c = 9;
		return;
	  }
	  if (exception.Equals("arrow_height"))
	  {
		this.c = 10;
		return;
	  }
	  if (exception.Equals("arrow_length"))
	  {
		this.c = 11;
	  }
	}
  }

  public override void a(char[] paramArrayOfchar, int paramInt)
  {
	switch (this.c)
	{
	  default:
		this.c = 0;
		return;
	  case 3:
		this.j = (int)Convert.ToInt64(new string(paramArrayOfchar, 0, paramInt), 16);
		  goto case 4;
	  case 4:
		this.l = b.a(paramArrayOfchar, 0, paramInt);
		  goto case 12;
	  case 12:
		this.m = b.a(paramArrayOfchar, 0, paramInt);
		  goto case 6;
	  case 6:
		this.k = (int)Convert.ToInt64(new string(paramArrayOfchar, 0, paramInt), 16);
		  goto case 7;
	  case 7:
		this.n = b.a(paramArrayOfchar, 0, paramInt);
		  goto case 8;
	  case 8:
		this.o = b.a(paramArrayOfchar, 0, paramInt);
		  goto case 9;
	  case 9:
		this.p = b.a(paramArrayOfchar, 0, paramInt);
		  goto case 10;
	  case 10:
		this.q = b.a(paramArrayOfchar, 0, paramInt);
		  goto case 11;
	  case 11:
		break;
	}
	this.r = b.a(paramArrayOfchar, 0, paramInt);
  }

  internal at[] a(int paramInt1, int paramInt2, float paramFloat)
  {
	// Byte code:
	//   0: fload_3
	//   1: fconst_0
	//   2: fcmpl
	//   3: ifle -> 167
	//   6: iconst_0
	//   7: istore #4
	//   9: iload #4
	//   11: aload_0
	//   12: getfield a : [[Lat;
	//   15: arraylength
	//   16: if_icmpge -> 213
	//   19: aload_0
	//   20: getfield a : [[Lat;
	//   23: iload #4
	//   25: aaload
	//   26: astore #5
	//   28: aload #5
	//   30: ifnull -> 72
	//   33: aload #5
	//   35: iload_2
	//   36: aaload
	//   37: astore #6
	//   39: aload #6
	//   41: ifnull -> 72
	//   44: fload_3
	//   45: aload #6
	//   47: getfield a : F
	//   50: fcmpg
	//   51: iflt -> 72
	//   54: fload_3
	//   55: aload #6
	//   57: getfield b : F
	//   60: fcmpl
	//   61: ifge -> 72
	//   64: aload #5
	//   66: ifnull -> 78
	//   69: aload #5
	//   71: areturn
	//   72: iinc #4, 1
	//   75: goto -> 9
	//   78: aload_0
	//   79: getfield b : Ljava/util/TreeMap;
	//   82: invokevirtual entrySet : ()Ljava/util/Set;
	//   85: invokeinterface iterator : ()Ljava/util/Iterator;
	//   90: astore #7
	//   92: aload #7
	//   94: invokeinterface hasNext : ()Z
	//   99: ifeq -> 206
	//   102: aload #7
	//   104: invokeinterface next : ()Ljava/lang/Object;
	//   109: checkcast java/util/Map$Entry
	//   112: invokeinterface getValue : ()Ljava/lang/Object;
	//   117: checkcast [Lat;
	//   120: astore #6
	//   122: aload #6
	//   124: ifnull -> 92
	//   127: aload #6
	//   129: iload_2
	//   130: aaload
	//   131: astore #8
	//   133: aload #8
	//   135: ifnull -> 92
	//   138: fload_3
	//   139: aload #8
	//   141: getfield a : F
	//   144: fcmpg
	//   145: iflt -> 92
	//   148: fload_3
	//   149: aload #8
	//   151: getfield b : F
	//   154: fcmpl
	//   155: ifge -> 92
	//   158: aload #6
	//   160: astore #5
	//   162: aload #6
	//   164: ifnonnull -> 69
	//   167: iload_1
	//   168: aload_0
	//   169: getfield a : [[Lat;
	//   172: arraylength
	//   173: if_icmple -> 195
	//   176: aload_0
	//   177: getfield b : Ljava/util/TreeMap;
	//   180: iload_1
	//   181: invokestatic valueOf : (I)Ljava/lang/Integer;
	//   184: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   187: checkcast [Lat;
	//   190: astore #5
	//   192: goto -> 69
	//   195: aload_0
	//   196: getfield a : [[Lat;
	//   199: iload_1
	//   200: aaload
	//   201: astore #5
	//   203: goto -> 69
	//   206: aload #5
	//   208: astore #6
	//   210: goto -> 158
	//   213: aconst_null
	//   214: astore #5
	//   216: goto -> 64
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\au.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */