using System;
using System.Collections;
using System.Collections.Generic;

using Paint = android.graphics.Paint;

public sealed class ca
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int a_Conflict = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool b_Conflict = false;

  private int c = -1;

  private ArrayList d;

  private ArrayList e;

  private int f = 0;

  private bw g;

  private bool h = true;

  private int i;

  private Paint[] j;

  private static int a(int paramInt1, int paramInt2, int paramInt3)
  {
	return paramInt1 << 31 | paramInt2 << 16 | 0xFFFF & paramInt3;
  }

  private int a(string paramString, sbyte paramByte)
  {
	return (int)this.j[paramByte].measureText(paramString);
  }

  private static int a(List<bw> paramArrayList)
  {
	for (int i = paramArrayList.Count - 1; i >= 0; i--)
	{
	  bw bw1 = paramArrayList[i];
	  for (int j = bw1.d.Length - 1; j >= 0; j = k - 1)
	  {
		char c = bw1.d[j];
		if (c == ' ')
		{
		  return a(1, j, i);
		}
		int k = j;
		if (c == '/')
		{
		  if (j == 0)
		  {
			return a(0, j, i);
		  }
		  if (bw1.d[j - 1] == '/')
		  {
			k = j - 1;
		  }
		  else
		  {
			return a(0, j, i);
		  }
		}
	  }
	}
	return -1;
  }

  private void a(bv parambv, ArrayList paramArrayList)
  {
	// Byte code:
	//   0: iconst_0
	//   1: istore_3
	//   2: aload_1
	//   3: invokevirtual d : ()I
	//   6: tableswitch default -> 36, 1 -> 78, 2 -> 48, 3 -> 66, 4 -> 84
	//   36: iload_3
	//   37: istore #4
	//   39: iload #4
	//   41: istore_3
	//   42: iload #4
	//   44: ifeq -> 2
	//   47: return
	//   48: aload_0
	//   49: aload_1
	//   50: iconst_1
	//   51: invokespecial a : (Lbv;Z)V
	//   54: aload_0
	//   55: aload_1
	//   56: aload_2
	//   57: invokespecial a : (Lbv;Ljava/util/ArrayList;)V
	//   60: iload_3
	//   61: istore #4
	//   63: goto -> 39
	//   66: aload_0
	//   67: aload_1
	//   68: iconst_0
	//   69: invokespecial a : (Lbv;Z)V
	//   72: iconst_1
	//   73: istore #4
	//   75: goto -> 39
	//   78: iconst_1
	//   79: istore #4
	//   81: goto -> 39
	//   84: aload_0
	//   85: aload_1
	//   86: invokevirtual a : ()Ljava/lang/String;
	//   89: invokespecial a : (Ljava/lang/String;)V
	//   92: iload_3
	//   93: istore #4
	//   95: goto -> 39
  }

  private void a(bv parambv, bool paramBoolean)
  {
	sbyte b = 0;
	string str1 = parambv.b();
	string str2 = str1;
	if (!string.ReferenceEquals(str1, null))
	{
	  str2 = str1.ToLower();
	}
	if ("br".Equals(str2))
	{
	  if (paramBoolean)
	  {
		a("\n");
	  }
	  return;
	}
	if ("b".Equals(str2))
	{
	  this.b_Conflict = paramBoolean;
	  return;
	}
	if ("font".Equals(str2))
	{
	  bool @bool;
	  if (paramBoolean)
	  {
		int i = -1;
		while (true)
		{
		  @bool = i;
		  try
		  {
			if (b < parambv.c())
			{
			  @bool = i;
			  if ("color".Equals(parambv.a(b).ToLower()))
			  {
				@bool = Convert.ToInt32(parambv.b(b).Substring(1), 16);
			  }
			  b++;
			  i = @bool;
			  continue;
			}
		  }
		  catch (Exception)
		  {
			@bool = i;
		  }
		  break;
		}
	  }
	  else
	  {
		@bool = false;
	  }
	  if (@bool != -1)
	  {
		this.a_Conflict = @bool;
	  }
	}
  }

  private void a(string paramString)
  {
	if (!string.ReferenceEquals(paramString, null) && paramString.Length != 0)
	{
	  bool @bool;
	  if (this.b_Conflict)
	  {
		bool bool1 = true;
		@bool = bool1;
	  }
	  else
	  {
		bool bool1 = false;
		@bool = bool1;
	  }
	  if (this.g == null)
	  {
		this.g = new bw(this.f, this.a_Conflict, @bool);
	  }
	  sbyte b = 0;
	  while (true)
	  {
		if (b < paramString.Length)
		{
		  char c = paramString[b];
		  if ((c == '\n' && paramString.Length == 1) || (c != '\n' && c != '\r'))
		  {
			char c1;
			if (c == '\t')
			{
			  c = ' ';
			  c1 = c;
			}
			else
			{
			  c1 = c;
			}
			string str = c1.ToString();
			if (c1 == '\n' || this.f + a(str, @bool) >= this.i)
			{
			  c = '\x0001';
			}
			else
			{
			  c = char.MinValue;
			}
			if (this.g.a_Conflict != this.a_Conflict || this.g.c != @bool || c != '\x0000')
			{
			  this.g.a();
			  this.e.Add(this.g);
			  if (c != '\x0000')
			  {
				bool bool1;
				this.f = 0;
				if (c1 == '\n' || c1 == ' ' || a(this.e) == -1)
				{
				  bool1 = true;
				}
				else
				{
				  bool1 = false;
				}
				this.h = bool1;
				if (this.h)
				{
				  this.b(this.e);
				  this.e = new ArrayList();
				}
				else
				{
				  int j = a(this.e);
				  int i = j & 0xFFFF;
				  bw bw1 = this.e[i];
				  int k = (int)((uint)j >> 16) & 0x7FFF;
				  j = (int)((uint)j >> 31);
				  List<bw> arrayList1 = new ArrayList();
				  if (k == 0 && j == 1)
				  {
					bw1.d = bw1.d.Substring(1);
					bw1.b = 0;
				  }
				  else
				  {
					string str1 = bw1.d;
					bw1.d = str1.Substring(0, k);
					bw1 = new bw(0, bw1.a_Conflict, bw1.c);
					bw1.d = str1.Substring(k + j);
					if (bw1.d.Length > 0)
					{
					  arrayList1.Add(bw1);
					  this.f = a(bw1.d, bw1.c);
					}
					i++;
				  }
				  List<bw> arrayList2 = new ArrayList(3);
				  while (i < this.e.Count)
				  {
					this.g = this.e[i];
					arrayList2.Add(this.g);
					this.g.b = this.f;
					this.f += a(this.g.d, this.g.c);
					arrayList1.Add(this.g);
					i++;
				  }
				  for (i = 0; i < arrayList2.Count; i++)
				  {
					this.e.Remove(arrayList2[i]);
				  }
				  this.b(this.e);
				  this.e = arrayList1;
				}
			  }
			  this.g = new bw(this.f, this.a_Conflict, @bool);
			}
			if (c1 != '\n' && (this.f != 0 || c1 != ' '))
			{
			  this.g.a(c1);
			  this.f += a(str, @bool);
			}
		  }
		  b++;
		  continue;
		}
		return;
	  }
	}
  }

  private void b(List<bw> paramArrayList)
  {
	bool @bool = false;
	if (this.c == 1 || this.c == 0)
	{
	  int i = 0;
	  int j = 0;
	  while (i < paramArrayList.Count)
	  {
		sbyte b;
		bw bw1 = paramArrayList[i];
		if (!string.ReferenceEquals(bw1.d, null))
		{
		  b = a(bw1.d, bw1.c);
		}
		else
		{
		  b = 0;
		}
		j += b;
		i++;
	  }
	  i = this.i - j;
	  if (this.c == 0)
	  {
		i >>= 1;
		j = @bool;
	  }
	  else
	  {
		j = @bool;
	  }
	  while (j < paramArrayList.Count)
	  {
		bw bw1 = paramArrayList[j];
		bw1.b += i;
		j++;
	  }
	}
	this.d.Add(paramArrayList);
  }

  public ArrayList a()
  {
	return this.d;
  }

  public void a(int paramInt)
  {
	this.a_Conflict = paramInt;
  }

  public void a(string paramString, Paint[] paramArrayOfPaint, int paramInt)
  {
	this.f = 0;
	this.b_Conflict = false;
	this.h = true;
	this.d = new ArrayList();
	this.e = new ArrayList();
	this.i = paramInt;
	bv bv = new bv();
	this.j = paramArrayOfPaint;
	try
	{
	  StringReader stringReader = new StringReader();
	  this(paramString);
	  bv.a(stringReader);
	  a(bv, this.d);
	  this.g.a();
	  if (this.g.d.Length > 0)
	  {
		this.e.Add(this.g);
	  }
	  this.g = null;
	  if (this.e.Count > 0)
	  {
		b(this.e);
	  }
	}
	catch (Exception)
	{
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ca.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */