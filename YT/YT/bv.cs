using System;
using System.Collections;
using System.Collections.Generic;

public sealed class bv
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Hashtable a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string[] c_Conflict = new string[16];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int[] d_Conflict = new int[4];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private Reader e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private char[] f_Conflict = new char[8192];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int h_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int i_Conflict;

  private int j;

  private char[] k = new char[128];

  private int l;

  private int m;

  private bool n;

  private string o;

  private string p;

  private string q;

  private bool r;

  private int s;

  private string[] t = new string[16];

  private int[] u = new int[2];

  private int v;

  private bool w;

  private bool x;

  private bool y;

  private void a(char paramChar)
  {
	if ((char)g() != paramChar)
	{
	  throw new Exception();
	}
  }

  private void a(int paramInt, bool paramBoolean)
  {
	int i = e(0);
	sbyte b = 0;
	while (i != -1 && i != paramInt && (paramInt != 32 || (i > 32 && i != 62)))
	{
	  if (i == 38)
	  {
		if (paramBoolean)
		{
		  f();
		}
		else
		{
		  break;
		}
	  }
	  else if (i == 10 && this.m == 2)
	  {
		g();
		d(32);
	  }
	  else
	  {
		d(g());
	  }
	  if (i == 62 && b >= 2 && paramInt != 93)
	  {
		throw new Exception();
	  }
	  if (i == 93)
	  {
		b++;
	  }
	  else
	  {
		b = 0;
	  }
	  i = e(0);
	}
  }

  private void a(bool paramBoolean)
  {
	if (!paramBoolean)
	{
	  g();
	}
	this.q = h();
	this.s = 0;
	while (true)
	{
	  while (true)
	  {
		i();
		int i = e(0);
		break;
	  }
	  if (SYNTHETIC_LOCAL_VARIABLE_5 != 32)
	  {
		g();
	  }
	}
  }

  private static string[] a(string[] paramArrayOfString, int paramInt)
  {
	if (paramArrayOfString.Length < paramInt)
	{
	  string[] arrayOfString = new string[paramInt + 16];
	  Array.Copy(paramArrayOfString, 0, arrayOfString, 0, paramArrayOfString.Length);
	  paramArrayOfString = arrayOfString;
	}
	return paramArrayOfString;
  }

  private string c(int paramInt)
  {
	return new string(this.k, paramInt, this.l - paramInt);
  }

  private void d(int paramInt)
  {
	bool bool2;
	bool bool1 = this.n;
	if (paramInt <= 32)
	{
	  bool2 = true;
	}
	else
	{
	  bool2 = false;
	}
	this.n = bool2 & bool1;
	if (this.l == this.k.Length)
	{
	  char[] arrayOfChar1 = new char[(this.l << 2) / 3 + 4];
	  Array.Copy(this.k, 0, arrayOfChar1, 0, this.l);
	  this.k = arrayOfChar1;
	}
	char[] arrayOfChar = this.k;
	int i = this.l;
	this.l = i + 1;
	arrayOfChar[i] = (char)(char)paramInt;
  }

  private int e()
  {
	char c = '\x0001';
	switch (e(0))
	{
	  default:
		c = '\x0004';
		  goto case -1;
	  case -1:
		return c;
	  case 38:
		c = '\x0006';
		  goto case 60;
	  case 60:
		break;
	}
	switch (e(1))
	{
	  default:
		c = '\x0002';
		  goto case 47;
	  case 47:
		c = '\x0003';
		  goto case 33;
	  case 33:
	  case 63:
		break;
	}
	c = 'ϧ';
  }

  private int e(int paramInt)
  {
	while (paramInt >= this.v)
	{
	  int i;
	  if (this.f_Conflict.Length <= 1)
	  {
		i = this.e_Conflict.read();
	  }
	  else if (this.g_Conflict < this.h_Conflict)
	  {
		char[] arrayOfChar = this.f_Conflict;
		i = this.g_Conflict;
		this.g_Conflict = i + 1;
		i = arrayOfChar[i];
	  }
	  else
	  {
		this.h_Conflict = this.e_Conflict.read(this.f_Conflict, 0, this.f_Conflict.Length);
		if (this.h_Conflict <= 0)
		{
		  i = -1;
		}
		else
		{
		  i = this.f_Conflict[0];
		}
		this.g_Conflict = 1;
	  }
	  if (i == 13)
	  {
		this.w = true;
		int[] arrayOfInt = this.u;
		i = this.v;
		this.v = i + 1;
		arrayOfInt[i] = 10;
		continue;
	  }
	  if (i == 10)
	  {
		if (!this.w)
		{
		  int[] arrayOfInt = this.u;
		  i = this.v;
		  this.v = i + 1;
		  arrayOfInt[i] = 10;
		}
	  }
	  else
	  {
		int[] arrayOfInt = this.u;
		int j = this.v;
		this.v = j + 1;
		arrayOfInt[j] = i;
	  }
	  this.w = false;
	}
	return this.u[paramInt];
  }

  private void f()
  {
	bool @bool = true;
	int i = 0;
	g();
	int j = this.l;
	while (true)
	{
	  int k = g();
	  if (k != 59)
	  {
		if (k < 128 && (k < 48 || k > 57) && (k < 97 || k > 122) && (k < 65 || k > 90) && k != 95 && k != 45 && k != 35)
		{
		  throw new Exception();
		}
		d(k);
		continue;
	  }
	  string str = c(j);
	  this.l = j;
	  if (this.y && this.m == 6)
	  {
		this.q = str;
	  }
	  if (str[0] == '#')
	  {
		if (str[1] == 'x')
		{
		  i = Convert.ToInt32(str.Substring(2), 16);
		}
		else
		{
		  i = int.Parse(str.Substring(1));
		}
		d(i);
		continue;
	  }
	  str = (string)this.a_Conflict[str];
	  if (!string.ReferenceEquals(str, null))
	  {
		@bool = false;
	  }
	  this.x = @bool;
	  if (this.x)
	  {
		if (!this.y)
		{
		  throw new Exception();
		}
		continue;
	  }
	  while (true)
	  {
		if (i < str.Length)
		{
		  d(str[i]);
		  i++;
		  continue;
		}
		return;
	  }
	  break;
	}
  }

  private int g()
  {
	int i;
	if (this.v == 0)
	{
	  i = e(0);
	}
	else
	{
	  i = this.u[0];
	  this.u[0] = this.u[1];
	}
	this.v--;
	this.j++;
	if (i == 10)
	{
	  this.i_Conflict++;
	  this.j = 1;
	}
	return i;
  }

  private string h()
  {
	int i = this.l;
	int j = e(0);
	if ((j < 97 || j > 122) && (j < 65 || j > 90) && j != 95 && j != 58 && j < 192)
	{
	  throw new Exception();
	}
	while (true)
	{
	  d(g());
	  j = e(0);
	  if ((j < 97 || j > 122) && (j < 65 || j > 90) && (j < 48 || j > 57) && j != 95 && j != 45 && j != 58 && j != 46 && j < 183)
	  {
		string str = c(i);
		this.l = i;
		return str;
	  }
	}
  }

  private void i()
  {
	while (true)
	{
	  int i = e(0);
	  if (i <= 32 && i != -1)
	  {
		g();
		continue;
	  }
	  break;
	}
  }

  public string a()
  {
	return (this.m < 4 || (this.m == 6 && this.x)) ? null : c(0);
  }

  public string a(int paramInt)
  {
	return this.t[(paramInt << 2) + 2];
  }

  public void a(Reader paramReader)
  {
	this.e_Conflict = paramReader;
	this.i_Conflict = 1;
	this.j = 0;
	this.m = 0;
	this.q = null;
	this.o = null;
	this.r = false;
	this.s = -1;
	if (paramReader != null)
	{
	  this.g_Conflict = 0;
	  this.h_Conflict = 0;
	  this.v = 0;
	  this.b_Conflict = 0;
	  this.a_Conflict = new Dictionary<object, object>();
	  this.a_Conflict["amp"] = "&";
	  this.a_Conflict["apos"] = "'";
	  this.a_Conflict["gt"] = ">";
	  this.a_Conflict["lt"] = "<";
	  this.a_Conflict["quot"] = "\"";
	  this.a_Conflict["nbsp"] = " ";
	}
  }

  public string b()
  {
	return this.q;
  }

  public string b(int paramInt)
  {
	return this.t[(paramInt << 2) + 3];
  }

  public int c()
  {
	return this.s;
  }

  public int d()
  {
	// Byte code:
	//   0: aload_0
	//   1: iconst_0
	//   2: putfield l : I
	//   5: aload_0
	//   6: iconst_1
	//   7: putfield n : Z
	//   10: sipush #9999
	//   13: istore_1
	//   14: aload_0
	//   15: iconst_0
	//   16: putfield y : Z
	//   19: aload_0
	//   20: getfield e : Ljava/io/Reader;
	//   23: ifnonnull -> 34
	//   26: new java/lang/RuntimeException
	//   29: dup
	//   30: invokespecial <init> : ()V
	//   33: athrow
	//   34: aload_0
	//   35: getfield m : I
	//   38: iconst_3
	//   39: if_icmpne -> 52
	//   42: aload_0
	//   43: aload_0
	//   44: getfield b : I
	//   47: iconst_1
	//   48: isub
	//   49: putfield b : I
	//   52: aload_0
	//   53: iconst_m1
	//   54: putfield s : I
	//   57: aload_0
	//   58: getfield r : Z
	//   61: ifeq -> 135
	//   64: aload_0
	//   65: iconst_0
	//   66: putfield r : Z
	//   69: aload_0
	//   70: iconst_3
	//   71: putfield m : I
	//   74: iload_1
	//   75: istore_2
	//   76: aload_0
	//   77: getfield m : I
	//   80: iload_1
	//   81: if_icmpge -> 89
	//   84: aload_0
	//   85: getfield m : I
	//   88: istore_2
	//   89: iload_2
	//   90: istore_1
	//   91: iload_2
	//   92: bipush #6
	//   94: if_icmpgt -> 19
	//   97: iload_2
	//   98: iconst_4
	//   99: if_icmplt -> 112
	//   102: iload_2
	//   103: istore_1
	//   104: aload_0
	//   105: invokespecial e : ()I
	//   108: iconst_4
	//   109: if_icmpge -> 19
	//   112: aload_0
	//   113: iload_2
	//   114: putfield m : I
	//   117: aload_0
	//   118: getfield m : I
	//   121: iconst_4
	//   122: if_icmple -> 130
	//   125: aload_0
	//   126: iconst_4
	//   127: putfield m : I
	//   130: aload_0
	//   131: getfield m : I
	//   134: ireturn
	//   135: aload_0
	//   136: aconst_null
	//   137: putfield p : Ljava/lang/String;
	//   140: aload_0
	//   141: aconst_null
	//   142: putfield q : Ljava/lang/String;
	//   145: aload_0
	//   146: aconst_null
	//   147: putfield o : Ljava/lang/String;
	//   150: aload_0
	//   151: aload_0
	//   152: invokespecial e : ()I
	//   155: putfield m : I
	//   158: aload_0
	//   159: getfield m : I
	//   162: tableswitch default -> 200, 1 -> 74, 2 -> 354, 3 -> 362, 4 -> 477, 5 -> 200, 6 -> 347
	//   200: aload_0
	//   201: getfield y : Z
	//   204: istore_3
	//   205: aload_0
	//   206: invokespecial g : ()I
	//   209: pop
	//   210: aload_0
	//   211: invokespecial g : ()I
	//   214: istore_2
	//   215: iload_2
	//   216: bipush #63
	//   218: if_icmpne -> 709
	//   221: aload_0
	//   222: iconst_0
	//   223: invokespecial e : (I)I
	//   226: bipush #120
	//   228: if_icmpeq -> 241
	//   231: aload_0
	//   232: iconst_0
	//   233: invokespecial e : (I)I
	//   236: bipush #88
	//   238: if_icmpne -> 668
	//   241: aload_0
	//   242: iconst_1
	//   243: invokespecial e : (I)I
	//   246: bipush #109
	//   248: if_icmpeq -> 261
	//   251: aload_0
	//   252: iconst_1
	//   253: invokespecial e : (I)I
	//   256: bipush #77
	//   258: if_icmpne -> 668
	//   261: iload_3
	//   262: ifeq -> 283
	//   265: aload_0
	//   266: aload_0
	//   267: iconst_0
	//   268: invokespecial e : (I)I
	//   271: invokespecial d : (I)V
	//   274: aload_0
	//   275: aload_0
	//   276: iconst_1
	//   277: invokespecial e : (I)I
	//   280: invokespecial d : (I)V
	//   283: aload_0
	//   284: invokespecial g : ()I
	//   287: pop
	//   288: aload_0
	//   289: invokespecial g : ()I
	//   292: pop
	//   293: aload_0
	//   294: iconst_0
	//   295: invokespecial e : (I)I
	//   298: bipush #108
	//   300: if_icmpeq -> 313
	//   303: aload_0
	//   304: iconst_0
	//   305: invokespecial e : (I)I
	//   308: bipush #76
	//   310: if_icmpne -> 668
	//   313: aload_0
	//   314: iconst_1
	//   315: invokespecial e : (I)I
	//   318: bipush #32
	//   320: if_icmpgt -> 668
	//   323: aload_0
	//   324: getfield i : I
	//   327: iconst_1
	//   328: if_icmpne -> 339
	//   331: aload_0
	//   332: getfield j : I
	//   335: iconst_4
	//   336: if_icmple -> 521
	//   339: new java/lang/RuntimeException
	//   342: dup
	//   343: invokespecial <init> : ()V
	//   346: athrow
	//   347: aload_0
	//   348: invokespecial f : ()V
	//   351: goto -> 74
	//   354: aload_0
	//   355: iconst_0
	//   356: invokespecial a : (Z)V
	//   359: goto -> 74
	//   362: aload_0
	//   363: invokespecial g : ()I
	//   366: pop
	//   367: aload_0
	//   368: invokespecial g : ()I
	//   371: pop
	//   372: aload_0
	//   373: aload_0
	//   374: invokespecial h : ()Ljava/lang/String;
	//   377: putfield q : Ljava/lang/String;
	//   380: aload_0
	//   381: invokespecial i : ()V
	//   384: aload_0
	//   385: bipush #62
	//   387: invokespecial a : (C)V
	//   390: aload_0
	//   391: getfield b : I
	//   394: iconst_1
	//   395: isub
	//   396: iconst_2
	//   397: ishl
	//   398: istore_2
	//   399: aload_0
	//   400: getfield b : I
	//   403: ifne -> 414
	//   406: new java/lang/RuntimeException
	//   409: dup
	//   410: invokespecial <init> : ()V
	//   413: athrow
	//   414: aload_0
	//   415: getfield q : Ljava/lang/String;
	//   418: aload_0
	//   419: getfield c : [Ljava/lang/String;
	//   422: iload_2
	//   423: iconst_3
	//   424: iadd
	//   425: aaload
	//   426: invokevirtual equals : (Ljava/lang/Object;)Z
	//   429: ifne -> 440
	//   432: new java/lang/RuntimeException
	//   435: dup
	//   436: invokespecial <init> : ()V
	//   439: athrow
	//   440: aload_0
	//   441: aload_0
	//   442: getfield c : [Ljava/lang/String;
	//   445: iload_2
	//   446: aaload
	//   447: putfield o : Ljava/lang/String;
	//   450: aload_0
	//   451: aload_0
	//   452: getfield c : [Ljava/lang/String;
	//   455: iload_2
	//   456: iconst_1
	//   457: iadd
	//   458: aaload
	//   459: putfield p : Ljava/lang/String;
	//   462: aload_0
	//   463: aload_0
	//   464: getfield c : [Ljava/lang/String;
	//   467: iload_2
	//   468: iconst_2
	//   469: iadd
	//   470: aaload
	//   471: putfield q : Ljava/lang/String;
	//   474: goto -> 74
	//   477: aload_0
	//   478: getfield y : Z
	//   481: ifne -> 516
	//   484: iconst_1
	//   485: istore_3
	//   486: aload_0
	//   487: bipush #60
	//   489: iload_3
	//   490: invokespecial a : (IZ)V
	//   493: aload_0
	//   494: getfield b : I
	//   497: ifne -> 74
	//   500: aload_0
	//   501: getfield n : Z
	//   504: ifeq -> 74
	//   507: aload_0
	//   508: bipush #7
	//   510: putfield m : I
	//   513: goto -> 74
	//   516: iconst_0
	//   517: istore_3
	//   518: goto -> 486
	//   521: aload_0
	//   522: iconst_1
	//   523: invokespecial a : (Z)V
	//   526: aload_0
	//   527: getfield s : I
	//   530: ifle -> 547
	//   533: ldc 'version'
	//   535: aload_0
	//   536: getfield t : [Ljava/lang/String;
	//   539: iconst_2
	//   540: aaload
	//   541: invokevirtual equals : (Ljava/lang/Object;)Z
	//   544: ifne -> 555
	//   547: new java/lang/RuntimeException
	//   550: dup
	//   551: invokespecial <init> : ()V
	//   554: athrow
	//   555: iconst_1
	//   556: aload_0
	//   557: getfield s : I
	//   560: if_icmpge -> 1118
	//   563: ldc 'encoding'
	//   565: aload_0
	//   566: getfield t : [Ljava/lang/String;
	//   569: bipush #6
	//   571: aaload
	//   572: invokevirtual equals : (Ljava/lang/Object;)Z
	//   575: ifeq -> 1118
	//   578: iconst_2
	//   579: istore_2
	//   580: iload_2
	//   581: istore #4
	//   583: iload_2
	//   584: aload_0
	//   585: getfield s : I
	//   588: if_icmpge -> 617
	//   591: iload_2
	//   592: istore #4
	//   594: ldc 'standalone'
	//   596: aload_0
	//   597: getfield t : [Ljava/lang/String;
	//   600: iload_2
	//   601: iconst_2
	//   602: ishl
	//   603: iconst_2
	//   604: iadd
	//   605: aaload
	//   606: invokevirtual equals : (Ljava/lang/Object;)Z
	//   609: ifeq -> 617
	//   612: iload_2
	//   613: iconst_1
	//   614: iadd
	//   615: istore #4
	//   617: iload #4
	//   619: aload_0
	//   620: getfield s : I
	//   623: if_icmpeq -> 634
	//   626: new java/lang/RuntimeException
	//   629: dup
	//   630: invokespecial <init> : ()V
	//   633: athrow
	//   634: aload_0
	//   635: iconst_1
	//   636: putfield n : Z
	//   639: aload_0
	//   640: iconst_0
	//   641: putfield l : I
	//   644: sipush #998
	//   647: istore #5
	//   649: aload_0
	//   650: iload #5
	//   652: putfield m : I
	//   655: aload_0
	//   656: getfield m : I
	//   659: sipush #998
	//   662: if_icmpeq -> 52
	//   665: goto -> 74
	//   668: bipush #8
	//   670: istore_2
	//   671: ldc ''
	//   673: astore #6
	//   675: bipush #63
	//   677: istore #4
	//   679: iconst_0
	//   680: istore #5
	//   682: iload #5
	//   684: aload #6
	//   686: invokevirtual length : ()I
	//   689: if_icmpge -> 785
	//   692: aload_0
	//   693: aload #6
	//   695: iload #5
	//   697: invokevirtual charAt : (I)C
	//   700: invokespecial a : (C)V
	//   703: iinc #5, 1
	//   706: goto -> 682
	//   709: iload_2
	//   710: bipush #33
	//   712: if_icmpne -> 777
	//   715: aload_0
	//   716: iconst_0
	//   717: invokespecial e : (I)I
	//   720: bipush #45
	//   722: if_icmpne -> 739
	//   725: bipush #9
	//   727: istore_2
	//   728: ldc '--'
	//   730: astore #6
	//   732: bipush #45
	//   734: istore #4
	//   736: goto -> 679
	//   739: aload_0
	//   740: iconst_0
	//   741: invokespecial e : (I)I
	//   744: bipush #91
	//   746: if_icmpne -> 764
	//   749: iconst_5
	//   750: istore_2
	//   751: ldc '[CDATA['
	//   753: astore #6
	//   755: bipush #93
	//   757: istore #4
	//   759: iconst_1
	//   760: istore_3
	//   761: goto -> 679
	//   764: bipush #10
	//   766: istore_2
	//   767: ldc 'DOCTYPE'
	//   769: astore #6
	//   771: iconst_m1
	//   772: istore #4
	//   774: goto -> 679
	//   777: new java/lang/RuntimeException
	//   780: dup
	//   781: invokespecial <init> : ()V
	//   784: athrow
	//   785: iload_2
	//   786: bipush #10
	//   788: if_icmpne -> 1112
	//   791: iconst_0
	//   792: istore #7
	//   794: iconst_1
	//   795: istore #8
	//   797: aload_0
	//   798: invokespecial g : ()I
	//   801: istore #9
	//   803: iload #9
	//   805: lookupswitch default -> 848, -1 -> 885, 39 -> 893, 60 -> 918, 62 -> 944
	//   848: iload #8
	//   850: istore #5
	//   852: iload #7
	//   854: istore #4
	//   856: iload #4
	//   858: istore #7
	//   860: iload #5
	//   862: istore #8
	//   864: iload_3
	//   865: ifeq -> 797
	//   868: aload_0
	//   869: iload #9
	//   871: invokespecial d : (I)V
	//   874: iload #4
	//   876: istore #7
	//   878: iload #5
	//   880: istore #8
	//   882: goto -> 797
	//   885: new java/lang/RuntimeException
	//   888: dup
	//   889: invokespecial <init> : ()V
	//   892: athrow
	//   893: iload #7
	//   895: ifne -> 908
	//   898: iconst_1
	//   899: istore #4
	//   901: iload #8
	//   903: istore #5
	//   905: goto -> 856
	//   908: iconst_0
	//   909: istore #4
	//   911: iload #8
	//   913: istore #5
	//   915: goto -> 856
	//   918: iload #7
	//   920: istore #4
	//   922: iload #8
	//   924: istore #5
	//   926: iload #7
	//   928: ifne -> 856
	//   931: iload #8
	//   933: iconst_1
	//   934: iadd
	//   935: istore #5
	//   937: iload #7
	//   939: istore #4
	//   941: goto -> 856
	//   944: iload #7
	//   946: istore #4
	//   948: iload #8
	//   950: istore #5
	//   952: iload #7
	//   954: ifne -> 856
	//   957: iinc #8, -1
	//   960: iload_2
	//   961: istore #5
	//   963: iload #8
	//   965: ifeq -> 649
	//   968: iload #7
	//   970: istore #4
	//   972: iload #8
	//   974: istore #5
	//   976: goto -> 856
	//   979: iload_3
	//   980: ifeq -> 989
	//   983: aload_0
	//   984: iload #7
	//   986: invokespecial d : (I)V
	//   989: iload #4
	//   991: bipush #63
	//   993: if_icmpeq -> 1003
	//   996: iload #7
	//   998: iload #4
	//   1000: if_icmpne -> 1023
	//   1003: aload_0
	//   1004: iconst_0
	//   1005: invokespecial e : (I)I
	//   1008: iload #4
	//   1010: if_icmpne -> 1023
	//   1013: aload_0
	//   1014: iconst_1
	//   1015: invokespecial e : (I)I
	//   1018: bipush #62
	//   1020: if_icmpeq -> 1047
	//   1023: iload #7
	//   1025: istore #5
	//   1027: aload_0
	//   1028: invokespecial g : ()I
	//   1031: istore #7
	//   1033: iload #7
	//   1035: iconst_m1
	//   1036: if_icmpne -> 979
	//   1039: new java/lang/RuntimeException
	//   1042: dup
	//   1043: invokespecial <init> : ()V
	//   1046: athrow
	//   1047: iload #4
	//   1049: bipush #45
	//   1051: if_icmpne -> 1069
	//   1054: iload #5
	//   1056: bipush #45
	//   1058: if_icmpne -> 1069
	//   1061: new java/lang/RuntimeException
	//   1064: dup
	//   1065: invokespecial <init> : ()V
	//   1068: athrow
	//   1069: aload_0
	//   1070: invokespecial g : ()I
	//   1073: pop
	//   1074: aload_0
	//   1075: invokespecial g : ()I
	//   1078: pop
	//   1079: iload_2
	//   1080: istore #5
	//   1082: iload_3
	//   1083: ifeq -> 649
	//   1086: iload_2
	//   1087: istore #5
	//   1089: iload #4
	//   1091: bipush #63
	//   1093: if_icmpeq -> 649
	//   1096: aload_0
	//   1097: aload_0
	//   1098: getfield l : I
	//   1101: iconst_1
	//   1102: isub
	//   1103: putfield l : I
	//   1106: iload_2
	//   1107: istore #5
	//   1109: goto -> 649
	//   1112: iconst_0
	//   1113: istore #5
	//   1115: goto -> 1027
	//   1118: iconst_1
	//   1119: istore_2
	//   1120: goto -> 580
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */