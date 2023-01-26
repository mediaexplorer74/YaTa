using System;
using System.Collections.Generic;

using Attribute = ru.yandex.taxi.suggest.Attribute;

public class qq
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public Attribute[] a_Conflict = new Attribute[0];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool b_Conflict = false;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int c_Conflict = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int d_Conflict = 0;

  public qq()
  {
  }

  public qq(bool paramBoolean)
  {
  }

  public virtual void a(int paramInt)
  {
	this.a_Conflict = new Attribute[paramInt];
  }

  public virtual void a(int paramInt1, int paramInt2, int paramInt3)
  {
	this.a_Conflict[paramInt1] = new qp(paramInt2, paramInt3);
  }

  public virtual void a(int paramInt1, int paramInt2, long paramLong1, long paramLong2, bool paramBoolean, int paramInt3)
  {
	this.a_Conflict[paramInt1] = new qo(paramInt2, paramLong1, paramLong2, paramBoolean, paramInt3);
  }

  public virtual void a(int paramInt, string paramString)
  {
	this.a_Conflict[paramInt].Text = paramString;
  }

  public virtual Attribute[] a()
  {
	return this.a_Conflict;
  }

  public virtual void b()
  {
	if (this.b_Conflict == true)
	{
	  int i = this.a_Conflict.Length;
	  for (sbyte b = 0; b < i; b++)
	  {
		((qo)this.a_Conflict[b]).a();
	  }
	}
  }

  public virtual void b(int paramInt)
  {
	this.c_Conflict = paramInt;
  }

  public virtual void b(int paramInt, string paramString)
  {
	this.a_Conflict[paramInt].TextUA = paramString;
  }

  public virtual void c()
  {
	if (!this.b_Conflict)
	{
//JAVA TO C# CONVERTER TODO TASK: There is no C# equivalent to the Java 'super' constraint:
//ORIGINAL LINE: java.util.Arrays.sort(this.a, this.c, this.d, (java.util.Comparator<? super ru.yandex.taxi.suggest.Attribute>)new qp(0, 0));
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
	  Array.Sort(this.a_Conflict, this.c_Conflict, this.d_Conflict, (IComparer<object>)new qp(0, 0));
	  return;
	}
	if (this.b_Conflict == true)
	{
//JAVA TO C# CONVERTER TODO TASK: There is no C# equivalent to the Java 'super' constraint:
//ORIGINAL LINE: java.util.Arrays.sort(this.a, this.c, this.d, (java.util.Comparator<? super ru.yandex.taxi.suggest.Attribute>)new qo(0, 0L, 0L, false, 0));
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
	  Array.Sort(this.a_Conflict, this.c_Conflict, this.d_Conflict, (IComparer<object>)new qo(0, 0L, 0L, false, 0));
	}
  }

  public virtual void c(int paramInt)
  {
	this.d_Conflict = paramInt;
  }

  public virtual void c(int paramInt, string paramString)
  {
	((qo)this.a_Conflict[paramInt]).a(paramString);
  }

  public virtual int d()
  {
	return this.c_Conflict;
  }

  public virtual int d(int paramInt)
  {
	return this.a_Conflict[paramInt].Index;
  }

  public virtual void d(int paramInt, string paramString)
  {
	((qo)this.a_Conflict[paramInt]).b(paramString);
  }

  public virtual int e()
  {
	return this.d_Conflict;
  }

  public virtual int f()
  {
	return this.a_Conflict.Length;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */