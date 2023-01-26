using System;
using System.Collections;
using System.Collections.Generic;

namespace ru.yandex.taxi.suggest
{
	using Context = android.content.Context;
	using qo;
	using qq;
	using qr;

	public class Suggest
	{
	  public const int MAX_ALL = 10;

	  public const int MAX_GEO = 8;

	  public const int MAX_POPULARITY = 10;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static int b_Conflict = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private qr a_Conflict;

	  private char[] c;

	  private char[] d;

	  private qq e = new qq();

	  private qq f;

	  private int g;

	  private int h;

	  private int i;

	  private int j;

	  private int k;

	  public Suggest(Context paramContext)
	  {
		this.a_Conflict = new qr(paramContext);
		this.a_Conflict.a(0);
		try
		{
		  this.a_Conflict.g();
		}
		catch (Exception)
		{
		}
		a();
		this.j = this.i;
		this.d = this.c;
		this.h = this.g;
	  }

	  private static int a(sbyte paramByte1, sbyte paramByte2, sbyte paramByte3, sbyte paramByte4)
	  {
		return paramByte1 & 0xFF | 0x0 | (paramByte2 & 0xFF) << 8 | (paramByte3 & 0xFF) << 16 | (paramByte4 & 0xFF) << 24;
	  }

	  private void a()
	  {
		sbyte b = 0;
		try
		{
		  this.g = this.a_Conflict.d();
		  int i = this.a_Conflict.g();
		  this.i = (i << 1) + 6;
		  this.c = new char[i];
		  while (b < i)
		  {
			sbyte[] arrayOfByte = new sbyte[2];
			this.a_Conflict.a(arrayOfByte);
			char[] arrayOfChar = this.c;
			string str = "";
			this(arrayOfByte, "UTF-16LE");
			arrayOfChar[b] = (char)str.ToCharArray()[0];
			b++;
		  }
		}
		catch (Exception)
		{
		}
	  }

	  private void a(string[] paramArrayOfString, bool paramBoolean)
	  {
		int i = 0;
		try
		{
		  int j = paramArrayOfString.Length;
		  int k = 0;
		  qq qq1 = null;
		  while (true)
		  {
			if (k < j)
			{
			  qq qq2 = new qq();
			  this(paramBoolean);
			  this.e = qq2;
			  i = this.c.Length;
			  int m = paramArrayOfString[k].Length;
			  int[] arrayOfInt = new int[m];
			  int n = 0;
			  while (n < m)
			  {
				char c = paramArrayOfString[k][n];
				sbyte b = 0;
				while (true)
				{
				  if (b < i)
				  {
					if (c == this.c[b])
					{
					  arrayOfInt[n] = b;
					}
					else
					{
					  b++;
					  continue;
					}
				  }
				  n++;
				  goto label266Continue;
				}
				  label266Continue:;
			  }
			  label266Break:
			  this.k = 0;
			  this.a_Conflict.b(this.i);
			  int i1 = 0;
			  while (true)
			  {
				bool @bool;
				n = this.a_Conflict.g();
				if ((n & 0x4) != 0)
				{
				  i = 1;
				}
				else
				{
				  i = 0;
				}
				if ((n & 0x2) != 0)
				{
				  m = 1;
				}
				else
				{
				  m = 0;
				}
				if ((n & 0x1) != 0)
				{
				  @bool = true;
				}
				else
				{
				  @bool = false;
				}
				n = -1;
				if (@bool)
				{
				  int i2 = this.a_Conflict.g();
				  sbyte b = -1;
				  if (i1 < arrayOfInt.Length)
				  {
					int i3 = arrayOfInt[i1];
					int i4 = 0;
					while (true)
					{
					  n = b;
					  if (i4 < i2)
					  {
						if (i3 == this.a_Conflict.g())
						{
						  n = this.a_Conflict.d();
						  this.a_Conflict.c((i2 - i4 - 1) * 5);
						}
						else
						{
						  this.a_Conflict.c(4);
						  i4++;
						  continue;
						}
					  }
					  if (i != 0)
					  {
						i = this.a_Conflict.d();
						i4 = this.a_Conflict.d();
						this.e.b(i);
						this.e.c(i4 + 1);
					  }
					  if (m != 0)
					  {
						this.k = this.a_Conflict.c();
						i = this.e.e();
						if (this.a_Conflict.a())
						{
						  this.a_Conflict.c(i * 13);
						}
						else
						{
						  this.a_Conflict.c(i << 3);
						}
						if (arrayOfInt.Length > i1)
						{
						  this.e.c(0);
						}
					  }
					  if (@bool && i1 < arrayOfInt.Length)
					  {
						if (n != -1)
						{
						  this.a_Conflict.b(n);
						  i1++;
						  goto label278Continue;
						}
						if (n == -1)
						{
						  this.e.b(0);
						  this.e.c(0);
						}
					  }
					  break;
					}
					break;
				  }
				  this.a_Conflict.c(i2 * 5);
				  n = b;
				  continue;
				}
				continue;
				  label278Continue:;
			  }
			  label278Break:
			  m = this.e.d();
			  i = this.e.e();
			  if (this.k != 0 && i - m > 0)
			  {
				this.a_Conflict.b(this.k);
				n = this.e.d();
				int i2 = this.e.e() - n;
				this.e.a(i2);
				bool @bool = this.a_Conflict.a();
				qr qr1 = this.a_Conflict;
				if (@bool)
				{
				  n *= 13;
				}
				else
				{
				  n <<= 3;
				}
				qr1.c(n);
				if (@bool)
				{
				  n = 13;
				}
				else
				{
				  n = 8;
				}
				sbyte[] arrayOfByte = new sbyte[n * i2];
				this.a_Conflict.a(arrayOfByte);
				i1 = 0;
				n = 0;
				while (n < i2)
				{
				  if (@bool)
				  {
					bool bool1;
					int i6 = i1 + 1;
					sbyte b4 = arrayOfByte[i1];
					i1 = i6 + 1;
					sbyte b5 = arrayOfByte[i6];
					i6 = i1 + 1;
					sbyte b6 = arrayOfByte[i1];
					int i5 = i6 + 1;
					i1 = a(b4, b5, b6, arrayOfByte[i6]);
					long l1 = (arrayOfByte[i5] & 0xFF | (arrayOfByte[i5 + 1] & 0xFF) << 8 | (arrayOfByte[i5 + 2] & 0x3) << 16);
					long l2 = ((arrayOfByte[i5 + 2] & 0xFC) >> 2 | (arrayOfByte[i5 + 3] & 0xFF) << 6 | (arrayOfByte[i5 + 4] & 0xF) << 14);
					if ((arrayOfByte[i5 + 4] & 0x10) >> 4 == 0)
					{
					  bool1 = true;
					}
					else
					{
					  bool1 = false;
					}
					i5 += 5;
					i6 = i5 + 1;
					b4 = arrayOfByte[i5];
					i5 = i6 + 1;
					b6 = arrayOfByte[i6];
					i6 = i5 + 1;
					i5 = a(b4, b6, arrayOfByte[i5], arrayOfByte[i6]);
					this.e.a(n, i5, l1, l2, bool1, i1);
					n++;
					i1 = i6 + 1;
					continue;
				  }
				  int i4 = i1 + 1;
				  sbyte b3 = arrayOfByte[i1];
				  i1 = i4 + 1;
				  sbyte b1 = arrayOfByte[i4];
				  i4 = i1 + 1;
				  sbyte b2 = arrayOfByte[i1];
				  int i3 = i4 + 1;
				  i1 = a(b3, b1, b2, arrayOfByte[i4]);
				  i4 = i3 + 1;
				  b1 = arrayOfByte[i3];
				  i3 = i4 + 1;
				  b3 = arrayOfByte[i4];
				  i4 = i3 + 1;
				  i3 = a(b1, b3, arrayOfByte[i3], arrayOfByte[i4]);
				  this.e.a(n, i3, i1);
				  n++;
				  i1 = i4 + 1;
				}
				n = i - m;
				this.e.b(0);
				this.e.c(n);
			  }
			  else
			  {
				n = i;
			  }
			  if (qq1 == null)
			  {
				qq1 = this.e;
			  }
			  else
			  {
				List<Attribute> vector = new ArrayList();
				this();
				i = qq1.f() - 1;
				Attribute[] arrayOfAttribute1 = qq1.a();
				Attribute attribute = new Attribute();
				this(true, 0, 0);
				Array.Sort(arrayOfAttribute1, 0, i + 1, attribute);
				m = n - 1;
				Attribute[] arrayOfAttribute2 = this.e.a();
				attribute = new Attribute();
				this(true, 0, 0);
				Array.Sort(arrayOfAttribute2, 0, m + 1, attribute);
				i1 = -1;
				n = -1;
				while (i1 < i && n < m)
				{
				  int i2 = arrayOfAttribute1[i1 + 1].Index;
				  int i3 = arrayOfAttribute2[n + 1].Index;
				  if (i2 < i3)
				  {
					i1++;
					continue;
				  }
				  if (i2 > i3)
				  {
					n++;
					continue;
				  }
				  i1++;
				  vector.Add(arrayOfAttribute2[++n]);
				}
				n = vector.Count;
				i1 = 0;
				while (i1 < n)
				{
				  i = i1 + 1;
				  while (true)
				  {
					if (i < n)
					{
					  Attribute attribute1 = vector[i1];
					  attribute = vector[i];
					  if (attribute1.Index == attribute.Index)
					  {
						vector.RemoveAt(i);
						n--;
					  }
					  else
					  {
						i++;
						continue;
					  }
					}
					i1++;
					goto label267Continue;
				  }
					label267Continue:;
				}
				label267Break:
				n = vector.Count;
				qq qq3 = new qq();
				this(paramBoolean);
				this.e = qq3;
				this.e.a_Conflict = new Attribute[n];
				vector.CopyTo((object[])this.e.a_Conflict);
				this.e.c(n);
				qq3 = this.e;
			  }
			  k++;
			  i = n;
			  continue;
			}
			paramBoolean = this.a_Conflict.a();
			if (this.e.f() > 0)
			{
			  this.e.b();
			  this.e.c();
			  if (paramBoolean)
			  {
				List<qo> arrayList = new ArrayList();
				this();
				long l = long.MaxValue;
				k = 0;
				int m = 0;
				int i3 = 0;
				int i1 = 0;
				Attribute[] arrayOfAttribute = this.e.a_Conflict;
				int i4 = this.e.f();
				int n = 0;
				int i2 = 0;
				while (true)
				{
				  int i6;
				  if (i2 < i4)
				  {
					qo qo = (qo)arrayOfAttribute[i2];
					if (!qo.e())
					{
					  long l1 = qo.a();
					  i6 = qo.Weight;
					  if (l1 < 1000L && i6 > i3)
					  {
						if (l < 70L && i3 > i1 && i2 > 0)
						{
						  m = i3;
						}
						else
						{
						  k = m;
						  m = i1;
						}
						i1 = m;
						m = k;
						k = i2;
						i3 = i6;
						l = l1;
					  }
					  else if (l1 < 70L && i6 > i1)
					  {
						i1 = i6;
						m = i2;
					  }
					  else
					  {
						n++;
					  }
					}
					else
					{
					  arrayList.Add(qo);
					}
					i2++;
					continue;
				  }
				  int i7 = arrayList.Count;
				  if (i3 > 0)
				  {
					i2 = 1;
				  }
				  else
				  {
					i2 = 0;
				  }
				  if (i1 > 0)
				  {
					i6 = 1;
				  }
				  else
				  {
					i6 = 0;
				  }
				  if (i7 > 0)
				  {
					j = 1;
				  }
				  else
				  {
					j = 0;
				  }
				  int i5 = i7;
				  if (i7 > 0)
				  {
					i5 = i7 - 1;
				  }
				  i2 = n + j + i2 + i6 + i5;
				  n = i2;
				  if (i2 >= b_Conflict)
				  {
					n = b_Conflict;
				  }
				  qo[] arrayOfQo = new qo[n];
				  if (i3 > 0)
				  {
					arrayOfQo[0] = (qo)arrayOfAttribute[k];
					i2 = 1;
					arrayOfQo[0].b();
				  }
				  else
				  {
					i2 = 0;
				  }
				  if (i1 > 0)
				  {
					arrayOfQo[i2] = (qo)arrayOfAttribute[m];
					i1 = i2 + 1;
					arrayOfQo[i2].b();
					i2 = i1;
				  }
				  if (arrayList.Count > 0)
				  {
					i6 = arrayList.Count;
					qo[] arrayOfQo1 = new qo[i6];
					arrayList.toArray(arrayOfQo1);
					qo.d();
					qo qo = new qo();
					this(0, 0L, 0L, false, 0);
//JAVA TO C# CONVERTER TODO TASK: There is no C# equivalent to the Java 'super' constraint:
//ORIGINAL LINE: java.util.Arrays.sort(arrayOfQo1, 0, i6, (java.util.Comparator<? super qo>)qo);
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
					Array.Sort(arrayOfQo1, 0, i6, (IComparer<object>)qo);
					qo.c();
					if (n == b_Conflict)
					{
					  arrayOfQo[i2] = arrayOfQo1[0];
					  i1 = i2 + 1;
					  arrayOfQo[i2].b();
					  i2 = n;
					  n = i1;
					}
					else
					{
					  i1 = -1;
					  while (true)
					  {
						i3 = i1 + 1;
						if (i3 < i6 && i2 < n)
						{
						  qo = arrayOfQo1[i3];
						  i1 = i3;
						  if (n != b_Conflict)
						  {
							i1 = i3;
							if (qo.e())
							{
							  arrayOfQo[i2] = qo;
							  arrayOfQo[i2].b();
							  n++;
							  i2++;
							  i1 = i3;
							}
						  }
						  continue;
						}
						break;
					  }
					  i1 = i2;
					  i2 = n;
					  n = i1;
					}
				  }
				  else
				  {
					i1 = n;
					n = i2;
					i2 = i1;
				  }
				  i1 = -1;
				  while (++i1 < i4 && n < i2)
				  {
					if (((qo)arrayOfAttribute[i1]).h() && i1 != k && i1 != m)
					{
					  arrayOfQo[n] = (qo)arrayOfAttribute[i1];
					  arrayOfQo[n].b();
					  n++;
					}
				  }
				  if (n > 0)
				  {
					this.e.a_Conflict = (Attribute[])arrayOfQo;
					i2 = n;
				  }
				  else
				  {
					i2 = i;
				  }
				  n = i2;
				  if (i2 > b_Conflict)
				  {
					n = b_Conflict;
				  }
				  this.e.c(n);
				  this.a_Conflict.b(this.g);
				  m = this.a_Conflict.d();
				  k = this.g;
				  for (i2 = 0; i2 < n; i2++)
				  {
					i = this.g;
					i1 = this.e.d(i2);
					this.a_Conflict.b(i + 4 + i1 * 6);
					i1 = this.a_Conflict.d();
					i = 0;
					if (paramBoolean)
					{
					  i = this.a_Conflict.e();
					}
					this.a_Conflict.b(i1);
					string[] arrayOfString = b();
					this.e.a(i2, arrayOfString[0]);
					if (arrayOfString.Length == 2)
					{
					  this.e.b(i2, arrayOfString[1]);
					}
					if (i > 0)
					{
					  this.a_Conflict.b((i - 1 << 2) + k + 4 + m * 6 + 2);
					  i = this.a_Conflict.d();
					  this.a_Conflict.b(i);
					  arrayOfString = b();
					  this.e.c(i2, arrayOfString[0]);
					  if (arrayOfString.Length == 2)
					  {
						this.e.d(i2, arrayOfString[1]);
					  }
					}
				  }
				  i = 0;
				  arrayOfAttribute = this.e.a();
				  k = 0;
				  while (true)
				  {
					if (k < n)
					{
					  i2 = k + 1;
					  while (true)
					  {
						m = i2;
						i2 = i + 1;
						i = m;
					  }
					  break;
					}
					if (i != 0)
					{
					  this.e.a_Conflict = arrayOfAttribute;
					  this.e.c(arrayOfAttribute.Length);
					}
					if (paramBoolean)
					{
					  i2 = this.e.e();
					  n = 0;
					  while (true)
					  {
						if (n < i2)
						{
						  ((qo)this.e.a_Conflict[n]).k();
						  n++;
						  continue;
						}
						return;
					  }
					  break;
					}
					goto label282Continue;
				  }
				  break;
				}
				break;
			  }
			  continue;
			}
			continue;
			  label282Continue:;
		  }
		  label282Break:;
		}
		catch (Exception)
		{
		}
	  }

	  private string[] b()
	  {
		sbyte b3;
		sbyte b1 = -1;
		sbyte[] arrayOfByte = new sbyte[512];
		this.a_Conflict.a(arrayOfByte);
		int i = 0;
		string str = null;
		sbyte b2 = -1;
		while (true)
		{
		  b3 = b2;
		  if (b1 != 0)
		  {
			b3 = b2;
			if (b2 < unchecked((sbyte)512))
			{
			  b1 = arrayOfByte[++b2];
			  b3 = b2;
			  if (b1 != 0)
			  {
				if (b1 == 36)
				{
				  str = StringHelper.NewString(arrayOfByte, i, b2, "UTF-8");
				  i = b2 + 1;
				}
				continue;
			  }
			}
		  }
		  break;
		}
		if (!string.ReferenceEquals(str, null))
		{
		  string[] arrayOfString1 = new string[2];
		  arrayOfString1[0] = str;
		  arrayOfString1[1] = StringHelper.NewString(arrayOfByte, i, b3 - i, "UTF-8");
		  return arrayOfString1;
		}
		string[] arrayOfString = new string[1];
		arrayOfString[0] = StringHelper.NewString(arrayOfByte, i, b3 - i, "UTF-8");
		return arrayOfString;
	  }

	  public virtual void close()
	  {
		this.a_Conflict.b();
	  }

	  public virtual Result search(string paramString, double paramDouble1, double paramDouble2)
	  {
		// Byte code:
		//   0: dload_2
		//   1: putstatic qo.a : D
		//   4: dload_2
		//   5: ldc2_w 1000.0
		//   8: dmul
		//   9: d2l
		//   10: putstatic qo.c : J
		//   13: dload #4
		//   15: putstatic qo.b : D
		//   18: dload #4
		//   20: ldc2_w 1000.0
		//   23: dmul
		//   24: d2l
		//   25: putstatic qo.d : J
		//   28: new java/util/Vector
		//   31: dup
		//   32: iconst_1
		//   33: invokespecial <init> : (I)V
		//   36: astore #6
		//   38: aload_1
		//   39: invokevirtual toCharArray : ()[C
		//   42: astore_1
		//   43: new java/lang/StringBuffer
		//   46: dup
		//   47: invokespecial <init> : ()V
		//   50: astore #7
		//   52: aload_1
		//   53: arraylength
		//   54: istore #8
		//   56: iconst_m1
		//   57: istore #9
		//   59: iload #9
		//   61: iconst_1
		//   62: iadd
		//   63: istore #10
		//   65: iload #10
		//   67: iload #8
		//   69: if_icmpge -> 146
		//   72: aload_1
		//   73: iload #10
		//   75: caload
		//   76: istore #11
		//   78: iload #11
		//   80: bipush #32
		//   82: if_icmpeq -> 93
		//   85: aload #7
		//   87: iload #11
		//   89: invokevirtual append : (C)Ljava/lang/StringBuffer;
		//   92: pop
		//   93: iload #11
		//   95: bipush #32
		//   97: if_icmpeq -> 113
		//   100: iload #10
		//   102: istore #9
		//   104: iload #10
		//   106: iload #8
		//   108: iconst_1
		//   109: isub
		//   110: if_icmpne -> 59
		//   113: aload #7
		//   115: invokevirtual length : ()I
		//   118: iconst_1
		//   119: if_icmple -> 133
		//   122: aload #6
		//   124: aload #7
		//   126: invokevirtual toString : ()Ljava/lang/String;
		//   129: invokevirtual add : (Ljava/lang/Object;)Z
		//   132: pop
		//   133: aload #7
		//   135: iconst_0
		//   136: invokevirtual setLength : (I)V
		//   139: iload #10
		//   141: istore #9
		//   143: goto -> 59
		//   146: aload #6
		//   148: invokevirtual size : ()I
		//   151: anewarray java/lang/String
		//   154: astore_1
		//   155: aload #6
		//   157: aload_1
		//   158: invokevirtual copyInto : ([Ljava/lang/Object;)V
		//   161: new ru/yandex/taxi/suggest/Result
		//   164: dup
		//   165: invokespecial <init> : ()V
		//   168: astore #6
		//   170: aload_1
		//   171: arraylength
		//   172: ifle -> 265
		//   175: bipush #11
		//   177: putstatic ru/yandex/taxi/suggest/Suggest.b : I
		//   180: aload_0
		//   181: aload_0
		//   182: getfield j : I
		//   185: putfield i : I
		//   188: aload_0
		//   189: aload_0
		//   190: getfield h : I
		//   193: putfield g : I
		//   196: aload_0
		//   197: aload_0
		//   198: getfield d : [C
		//   201: putfield c : [C
		//   204: aload_0
		//   205: getfield a : Lqr;
		//   208: iconst_0
		//   209: invokevirtual a : (I)V
		//   212: aload_0
		//   213: aload_1
		//   214: iconst_0
		//   215: invokespecial a : ([Ljava/lang/String;Z)V
		//   218: aload_0
		//   219: aload_0
		//   220: getfield e : Lqq;
		//   223: putfield f : Lqq;
		//   226: aload_0
		//   227: getfield f : Lqq;
		//   230: invokevirtual e : ()I
		//   233: istore #9
		//   235: iload #9
		//   237: anewarray qp
		//   240: astore_1
		//   241: aload_0
		//   242: getfield f : Lqq;
		//   245: invokevirtual a : ()[Lru/yandex/taxi/suggest/Attribute;
		//   248: iconst_0
		//   249: aload_1
		//   250: iconst_0
		//   251: iload #9
		//   253: invokestatic arraycopy : (Ljava/lang/Object;ILjava/lang/Object;II)V
		//   256: aload #6
		//   258: aload_1
		//   259: invokevirtual a : ([Lqp;)V
		//   262: aload #6
		//   264: areturn
		//   265: aload #6
		//   267: iconst_0
		//   268: anewarray qo
		//   271: invokevirtual a : ([Lqo;)V
		//   274: aload #6
		//   276: iconst_0
		//   277: anewarray qp
		//   280: invokevirtual a : ([Lqp;)V
		//   283: goto -> 262
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\suggest\Suggest.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}