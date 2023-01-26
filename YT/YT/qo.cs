using System;
using System.Text;

using Attribute = ru.yandex.taxi.suggest.Attribute;
using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;

public class qo : Attribute
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static double a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static double b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static long c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static long d_Conflict;

  private static int o = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private long e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private long f_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private long h_Conflict = -1L;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private long i_Conflict = -1L;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string j_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string k_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string l_Conflict;

  private string m;

  private string n;

  public qo(int paramInt1, long paramLong1, long paramLong2, bool paramBoolean, int paramInt2) : base(true, paramInt1, paramInt2)
  {
	this.e_Conflict = paramLong1;
	this.f_Conflict = paramLong2;
	this.g_Conflict = paramBoolean;
  }

  public static void c()
  {
	o = 0;
  }

  public static void d()
  {
	o = 1;
  }

  public virtual long a()
  {
	if (this.h_Conflict == -1L)
	{
	  this.h_Conflict = Math.Abs(c_Conflict - this.e_Conflict) + Math.Abs(d_Conflict - this.f_Conflict);
	}
	return this.h_Conflict;
  }

  internal virtual void a(string paramString)
  {
	this.j_Conflict = paramString;
  }

  public virtual long b()
  {
	if (this.i_Conflict == -1L)
	{
	  this.i_Conflict = (long)CoordConversion.getDistance(a_Conflict, b_Conflict, this.e_Conflict / 1000.0D, this.f_Conflict / 1000.0D);
	}
	return this.i_Conflict;
  }

  internal virtual void b(string paramString)
  {
	this.k_Conflict = paramString;
  }

  public override int Compare(object paramObject1, object paramObject2)
  {
	sbyte b = 1;
	if (o == 0)
	{
	  long l3 = ((qo)paramObject1).a();
	  long l4 = ((qo)paramObject2).a();
	  if (l3 <= l4)
	  {
		if (l3 < l4)
		{
		  return -1;
		}
		b = 0;
	  }
	  return b;
	}
	long l1 = ((qo)paramObject1).Weight;
	long l2 = ((qo)paramObject2).Weight;
	if (l1 >= l2)
	{
	  if (l1 > l2)
	  {
		return -1;
	  }
	  b = 0;
	}
	return b;
  }

  public virtual bool e()
  {
	return !this.g_Conflict;
  }

  public virtual string f()
  {
	return this.j_Conflict;
  }

  public virtual string g()
  {
	return this.k_Conflict;
  }

  public virtual bool h()
  {
	return this.g_Conflict;
  }

  public virtual string i()
  {
	return this.m;
  }

  public virtual string j()
  {
	return this.l_Conflict;
  }

  public virtual void k()
  {
	StringBuilder stringBuffer = new StringBuilder();
	if (UA)
	{
	  if (h())
	  {
		stringBuffer.Append(f());
		stringBuffer.Append(", ");
	  }
	  stringBuffer.Append(Text);
	  this.m = stringBuffer.ToString();
	  stringBuffer.Length = 0;
	  stringBuffer.Append(Text);
	  if (h())
	  {
		stringBuffer.Append(", ");
		stringBuffer.Append(f());
	  }
	  this.l_Conflict = stringBuffer.ToString();
	  stringBuffer.Length = 0;
	  stringBuffer.Append("0");
	  stringBuffer.Append(" - ");
	  if (h())
	  {
		stringBuffer.Append(g());
		stringBuffer.Append(", ");
	  }
	  stringBuffer.Append(TextUA);
	}
	else
	{
	  if (h())
	  {
		stringBuffer.Append(f());
		stringBuffer.Append(", ");
	  }
	  stringBuffer.Append(Text);
	  this.m = stringBuffer.ToString();
	  stringBuffer.Length = 0;
	  stringBuffer.Append(Text);
	  if (h())
	  {
		stringBuffer.Append(", ");
		stringBuffer.Append(f());
	  }
	  this.l_Conflict = stringBuffer.ToString();
	  stringBuffer.Length = 0;
	  stringBuffer.Append("0");
	}
	this.n = stringBuffer.ToString();
  }

  public virtual string l()
  {
	return this.n;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qo.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */