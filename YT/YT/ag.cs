using System;
using System.IO;

using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class ag : cd
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public string a_Conflict;

  public string b;

  public string c;

  public int d;

  public int e;

  public int f;

  public bool g;

  public float h;

  public float i;

  public long j;

  public long k;

  public int l;

  private bool m;

  public override void a(string paramString)
  {
  }

  public override void a(string paramString, cc paramcc)
  {
	if (paramString.Equals("coordinates"))
	{
	  try
	  {
		this.h = float.Parse(paramcc.a("latitude"));
		this.i = float.Parse(paramcc.a("longitude"));
		GeoPoint geoPoint = new GeoPoint();
		this(this.h, this.i);
		by by = CoordConversion.toXY(geoPoint, null);
		this.j = by.x;
		this.k = by.y;
		try
		{
		  float f1 = float.Parse(paramcc.a("nlatitude"));
		  float f2 = float.Parse(paramcc.a("nlongitude"));
		  GeoPoint geoPoint1 = new GeoPoint();
		  this(f1, f2);
		  CoordConversion.toXY(geoPoint1, by);
		  long l1 = this.j - by.x;
		  long l2 = this.k - by.y;
		  this.l = (int)Math.Sqrt((l1 * l1 + l2 * l2));
		}
		catch (Exception)
		{
		}
		this.m = true;
	  }
	  catch (Exception)
	  {
	  }
	}
  }

  public override void a(char[] paramArrayOfchar, int paramInt)
  {
  }

  public bool a(sbyte[] paramArrayOfbyte)
  {
	MemoryStream byteArrayInputStream = new MemoryStream(paramArrayOfbyte);
	try
	{
	  MemoryStream byteArrayInputStream1;
	  if (b.a(paramArrayOfbyte))
	  {
		GZIPInputStream gZIPInputStream = new GZIPInputStream();
		this(byteArrayInputStream);
	  }
	  else
	  {
		byteArrayInputStream1 = byteArrayInputStream;
	  }
	  this.m = false;
	  StreamReader inputStreamReader = new StreamReader();
	  this(byteArrayInputStream1);
	  ce.a(this, inputStreamReader);
	}
	catch (Exception)
	{
	}
	return this.m;
  }

  public override bool Equals(object paramObject)
  {
	// Byte code:
	//   0: iconst_0
	//   1: istore_2
	//   2: aload_1
	//   3: ifnonnull -> 10
	//   6: iload_2
	//   7: istore_3
	//   8: iload_3
	//   9: ireturn
	//   10: iload_2
	//   11: istore_3
	//   12: aload_0
	//   13: invokevirtual getClass : ()Ljava/lang/Class;
	//   16: aload_1
	//   17: invokevirtual getClass : ()Ljava/lang/Class;
	//   20: if_acmpne -> 8
	//   23: aload_1
	//   24: checkcast ag
	//   27: astore_1
	//   28: aload_0
	//   29: getfield b : Ljava/lang/String;
	//   32: ifnonnull -> 130
	//   35: iload_2
	//   36: istore_3
	//   37: aload_1
	//   38: getfield b : Ljava/lang/String;
	//   41: ifnonnull -> 8
	//   44: aload_0
	//   45: getfield c : Ljava/lang/String;
	//   48: ifnonnull -> 149
	//   51: iload_2
	//   52: istore_3
	//   53: aload_1
	//   54: getfield c : Ljava/lang/String;
	//   57: ifnonnull -> 8
	//   60: iload_2
	//   61: istore_3
	//   62: aload_0
	//   63: getfield d : I
	//   66: aload_1
	//   67: getfield d : I
	//   70: if_icmpne -> 8
	//   73: iload_2
	//   74: istore_3
	//   75: aload_0
	//   76: getfield e : I
	//   79: aload_1
	//   80: getfield e : I
	//   83: if_icmpne -> 8
	//   86: aload_0
	//   87: getfield a : Ljava/lang/String;
	//   90: ifnonnull -> 102
	//   93: iload_2
	//   94: istore_3
	//   95: aload_1
	//   96: getfield a : Ljava/lang/String;
	//   99: ifnonnull -> 8
	//   102: aload_0
	//   103: getfield a : Ljava/lang/String;
	//   106: ifnull -> 125
	//   109: iload_2
	//   110: istore_3
	//   111: aload_0
	//   112: getfield a : Ljava/lang/String;
	//   115: aload_1
	//   116: getfield a : Ljava/lang/String;
	//   119: invokevirtual equals : (Ljava/lang/Object;)Z
	//   122: ifeq -> 8
	//   125: iconst_1
	//   126: istore_3
	//   127: goto -> 8
	//   130: aload_0
	//   131: getfield b : Ljava/lang/String;
	//   134: aload_1
	//   135: getfield b : Ljava/lang/String;
	//   138: invokevirtual equals : (Ljava/lang/Object;)Z
	//   141: ifne -> 44
	//   144: iload_2
	//   145: istore_3
	//   146: goto -> 8
	//   149: aload_0
	//   150: getfield c : Ljava/lang/String;
	//   153: aload_1
	//   154: getfield c : Ljava/lang/String;
	//   157: invokevirtual equals : (Ljava/lang/Object;)Z
	//   160: ifne -> 60
	//   163: iload_2
	//   164: istore_3
	//   165: goto -> 8
  }

  public override int GetHashCode()
  {
	return (this.d + 51) * 17 + this.e;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ag.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */