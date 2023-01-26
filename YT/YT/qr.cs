using System;
using System.IO;

using Context = android.content.Context;
using Utils = ru.yandex.taxi.suggest.Utils;

public class qr
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static int a_Conflict = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly int[] b_Conflict = new int[] {2131099650, 2131099651, 2131099652, 2131099653, 2131099654, 2131099655, 2131099656, 2131099657};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static int d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static int e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static int[][] f_Conflict = new int[][] {b_Conflict};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Stream c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Stream[][] g_Conflict;

  public qr(Context paramContext)
  {
	int i = f_Conflict.Length;
	this.g_Conflict = new Stream[i][];
	for (sbyte b = 0; b < i; b++)
	{
	  int j = (f_Conflict[b]).length;
	  this.g_Conflict[b] = new Stream[j];
	  for (sbyte b1 = 0; b1 < j; b1++)
	  {
		this.g_Conflict[b][b1] = paramContext.getResources().openRawResource(f_Conflict[b][b1]);
	  }
	}
  }

  private sbyte[] a(sbyte[] paramArrayOfbyte, int paramInt1, int paramInt2)
  {
	sbyte[] arrayOfByte = new sbyte[paramInt1];
	this.c_Conflict.Read(arrayOfByte, 0, arrayOfByte.Length);
	Array.Copy(arrayOfByte, 0, paramArrayOfbyte, 0, paramInt1);
	if (f())
	{
	  paramInt2 -= paramInt1;
	  arrayOfByte = new sbyte[paramInt2];
	  this.c_Conflict.Read(arrayOfByte, 0, arrayOfByte.Length);
	  Array.Copy(arrayOfByte, 0, paramArrayOfbyte, paramInt1, paramInt2);
	}
	return paramArrayOfbyte;
  }

  private void h()
  {
	try
	{
	  if (d_Conflict < this.g_Conflict.Length)
	  {
		int i;
		this.c_Conflict = this.g_Conflict[d_Conflict][e_Conflict];
		this.c_Conflict.reset();
		if (a())
		{
		  i = 1048576;
		}
		else
		{
		  i = this.c_Conflict.available();
		}
		a_Conflict = i;
	  }
	}
	catch (IOException)
	{
	}
  }

  public virtual void a(int paramInt)
  {
	d_Conflict = paramInt;
	e_Conflict = 0;
	a_Conflict = 0;
	h();
  }

  public virtual bool a()
  {
	bool @bool = true;
	if (d_Conflict != 1)
	{
	  @bool = false;
	}
	return @bool;
  }

  public virtual sbyte[] a(sbyte[] paramArrayOfbyte)
  {
	int i = this.c_Conflict.available();
	int j = paramArrayOfbyte.Length;
	if (i > j)
	{
	  this.c_Conflict.Read(paramArrayOfbyte, 0, paramArrayOfbyte.Length);
	  return paramArrayOfbyte;
	}
	return a(paramArrayOfbyte, i, j);
  }

  public virtual void b()
  {
	try
	{
	  int i = f_Conflict.Length;
	  for (sbyte b = 0; b < i; b++)
	  {
		int j = (f_Conflict[b]).length;
		for (sbyte b1 = 0; b1 < j; b1++)
		{
		  this.g_Conflict[b][b1].Close();
		  this.g_Conflict[b][b1] = null;
		}
	  }
	  this.g_Conflict = null;
	}
	catch (IOException)
	{
	}
  }

  public virtual void b(int paramInt)
  {
	if (paramInt > a_Conflict)
	{
	  e_Conflict = paramInt / a_Conflict;
	  paramInt -= e_Conflict * a_Conflict;
	}
	else
	{
	  e_Conflict = 0;
	}
	h();
	this.c_Conflict.skip(paramInt);
  }

  public virtual int c()
  {
	return a_Conflict * (e_Conflict + 1) - this.c_Conflict.available();
  }

  public virtual void c(int paramInt)
  {
	int i = this.c_Conflict.available();
	if (i > paramInt)
	{
	  this.c_Conflict.skip(paramInt);
	  return;
	}
	if (f())
	{
	  this.c_Conflict.skip((paramInt - i));
	}
  }

  public virtual int d()
  {
	null = this.c_Conflict.available();
	return (null > 4) ? Utils.b(this.c_Conflict) : Utils.b(a(new sbyte[4], null, 4));
  }

  public virtual short e()
  {
	int i = this.c_Conflict.available();
	if (i > 2)
	{
	  i = Utils.a(this.c_Conflict);
	  return i;
	}
	i = Utils.a(a(new sbyte[2], i, 2));
	return i;
  }

  internal virtual bool f()
  {
	if (e_Conflict < (this.g_Conflict[d_Conflict]).length - 1)
	{
	  e_Conflict++;
	  h();
	  return true;
	}
	return false;
  }

  public virtual int g()
  {
	if (this.c_Conflict.available() == 0)
	{
	  f();
	}
	return this.c_Conflict.Read();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */