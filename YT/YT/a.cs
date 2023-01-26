using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

using Context = android.content.Context;
using Bitmap = android.graphics.Bitmap;

public sealed class a : ThreadStart
{
  private static int C;

//JAVA TO C# CONVERTER NOTE: Members cannot have the same name as their enclosing type:
  public static int a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static WeakReference e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly sbyte[] f_Conflict = new sbyte[] {89, 78, 68, 88, 1, 0};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly int g_Conflict = b.a(f_Conflict, 0);

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly char[] h_Conflict = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};

  private static int r;

  private readonly char[] A = new char[300];

  private readonly char[][] B = new char[23][];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public volatile bool b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public volatile bool c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public volatile bool d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly object i_Conflict = new object();

  private readonly object j = new object();

  private volatile Thread k = null;

  private readonly ArrayList l = new ArrayList();

  private readonly ArrayList m = new ArrayList();

  private bool n;

  private bool o;

  private string p = "";

  private readonly int[] q = new int[24];

  private bool s;

  private volatile int t = 0;

  private bool u = false;

  private bool v = false;

  private bool w;

  private readonly char x = (char)Path.DirectorySeparatorChar;

  private int[] y = new int[600];

  private sbyte[] z = new sbyte[6000];

  static a()
  {
	a_Conflict = -1;
	r = 1;
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for C#:
//	System.loadLibrary("cache");
  }

  public a(Context paramContext)
  {
	a_Conflict(paramContext);
  }

  private string a(string paramString)
  {
	// Byte code:
	//   0: aload_1
	//   1: invokevirtual length : ()I
	//   4: ifle -> 26
	//   7: aload_1
	//   8: astore_2
	//   9: aload_1
	//   10: aload_1
	//   11: invokevirtual length : ()I
	//   14: iconst_1
	//   15: isub
	//   16: invokevirtual charAt : (I)C
	//   19: aload_0
	//   20: getfield x : C
	//   23: if_icmpeq -> 48
	//   26: new java/lang/StringBuilder
	//   29: dup
	//   30: invokespecial <init> : ()V
	//   33: aload_1
	//   34: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   37: aload_0
	//   38: getfield x : C
	//   41: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   44: invokevirtual toString : ()Ljava/lang/String;
	//   47: astore_2
	//   48: aload_2
	//   49: invokevirtual length : ()I
	//   52: ifle -> 69
	//   55: aload_2
	//   56: astore_1
	//   57: aload_2
	//   58: iconst_0
	//   59: invokevirtual charAt : (I)C
	//   62: aload_0
	//   63: getfield x : C
	//   66: if_icmpeq -> 91
	//   69: new java/lang/StringBuilder
	//   72: dup
	//   73: invokespecial <init> : ()V
	//   76: aload_0
	//   77: getfield x : C
	//   80: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   83: aload_2
	//   84: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   87: invokevirtual toString : ()Ljava/lang/String;
	//   90: astore_1
	//   91: new java/lang/StringBuilder
	//   94: dup
	//   95: invokespecial <init> : ()V
	//   98: aload_1
	//   99: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   102: ldc 'yandexmaps'
	//   104: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   107: aload_0
	//   108: getfield x : C
	//   111: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   114: invokevirtual toString : ()Ljava/lang/String;
	//   117: areturn
  }

//JAVA TO C# CONVERTER NOTE: Members cannot have the same name as their enclosing type:
  private void a_Conflict(string paramString, List<f> paramArrayList, bool paramBoolean)
  {
	File file = new File(paramString);
	if (file.exists())
	{
	  File[] arrayOfFile = file.listFiles();
	  int i = arrayOfFile.Length;
	  sbyte b = 0;
	  while (true)
	  {
		if (b < i)
		{
		  File file1 = arrayOfFile[b];
		  if (paramBoolean || !this.v)
		  {
			string str = file1.getName();
			if (str.Length <= 3 && str[0] != '.')
			{
			  if (file1.isDirectory())
			  {
				a_Conflict(file1.getAbsolutePath(), paramArrayList, paramBoolean);
			  }
			  else
			  {
				if (paramBoolean)
				{
				  file1.length();
				}
				if (paramBoolean)
				{
				  file1.lastModified();
				}
				paramArrayList.Add(new f(paramString, str));
			  }
			}
			b++;
			continue;
		  }
		}
		return;
	  }
	}
  }

  private am[] a(am[] paramArrayOfam)
  {
	// Byte code:
	//   0: aload_1
	//   1: ifnull -> 16
	//   4: aload_1
	//   5: arraylength
	//   6: ifeq -> 16
	//   9: aload_0
	//   10: getfield b : Z
	//   13: ifeq -> 18
	//   16: aload_1
	//   17: areturn
	//   18: iconst_0
	//   19: istore_2
	//   20: iload_2
	//   21: aload_1
	//   22: arraylength
	//   23: if_icmpge -> 468
	//   26: aload_1
	//   27: iload_2
	//   28: aaload
	//   29: astore_3
	//   30: aload_0
	//   31: getfield B : [[C
	//   34: aload_3
	//   35: getfield zoom : I
	//   38: aaload
	//   39: astore #4
	//   41: aload #4
	//   43: iconst_0
	//   44: aload_0
	//   45: getfield A : [C
	//   48: iconst_0
	//   49: aload #4
	//   51: arraylength
	//   52: invokestatic arraycopy : (Ljava/lang/Object;ILjava/lang/Object;II)V
	//   55: aload #4
	//   57: arraylength
	//   58: istore #5
	//   60: aload_0
	//   61: getfield q : [I
	//   64: aload_3
	//   65: getfield zoom : I
	//   68: iaload
	//   69: istore #6
	//   71: iconst_0
	//   72: istore #7
	//   74: iconst_1
	//   75: iload #6
	//   77: iconst_1
	//   78: isub
	//   79: iconst_4
	//   80: imul
	//   81: ishl
	//   82: istore #8
	//   84: iconst_0
	//   85: istore #9
	//   87: iconst_0
	//   88: istore #10
	//   90: iconst_0
	//   91: istore #11
	//   93: iconst_0
	//   94: istore #12
	//   96: iload #10
	//   98: iload #6
	//   100: iconst_2
	//   101: isub
	//   102: if_icmpge -> 257
	//   105: aload_3
	//   106: getfield i : I
	//   109: iload #7
	//   111: isub
	//   112: iload #8
	//   114: idiv
	//   115: istore #9
	//   117: aload_3
	//   118: getfield j : I
	//   121: iload #12
	//   123: isub
	//   124: iload #8
	//   126: idiv
	//   127: istore #11
	//   129: iload #7
	//   131: iload #8
	//   133: iload #9
	//   135: imul
	//   136: iadd
	//   137: istore #7
	//   139: iload #12
	//   141: iload #8
	//   143: iload #11
	//   145: imul
	//   146: iadd
	//   147: istore #13
	//   149: iload #8
	//   151: iconst_4
	//   152: ishr
	//   153: istore #8
	//   155: iload #5
	//   157: istore #12
	//   159: iload #10
	//   161: iload #6
	//   163: iconst_3
	//   164: isub
	//   165: if_icmpge -> 216
	//   168: aload_0
	//   169: getfield A : [C
	//   172: astore #4
	//   174: iload #5
	//   176: iconst_1
	//   177: iadd
	//   178: istore #14
	//   180: aload #4
	//   182: iload #5
	//   184: getstatic a.h : [C
	//   187: iload #9
	//   189: caload
	//   190: i2c
	//   191: castore
	//   192: aload_0
	//   193: getfield A : [C
	//   196: astore #4
	//   198: iload #14
	//   200: iconst_1
	//   201: iadd
	//   202: istore #12
	//   204: aload #4
	//   206: iload #14
	//   208: getstatic a.h : [C
	//   211: iload #11
	//   213: caload
	//   214: i2c
	//   215: castore
	//   216: iload #10
	//   218: iload #6
	//   220: iconst_3
	//   221: isub
	//   222: if_icmpge -> 1566
	//   225: aload_0
	//   226: getfield A : [C
	//   229: astore #4
	//   231: iload #12
	//   233: iconst_1
	//   234: iadd
	//   235: istore #5
	//   237: aload #4
	//   239: iload #12
	//   241: aload_0
	//   242: getfield x : C
	//   245: i2c
	//   246: castore
	//   247: iinc #10, 1
	//   250: iload #13
	//   252: istore #12
	//   254: goto -> 96
	//   257: aload_0
	//   258: getfield A : [C
	//   261: astore #4
	//   263: iload #5
	//   265: iconst_1
	//   266: iadd
	//   267: istore #10
	//   269: aload #4
	//   271: iload #5
	//   273: getstatic a.h : [C
	//   276: iload #9
	//   278: caload
	//   279: i2c
	//   280: castore
	//   281: aload_0
	//   282: getfield A : [C
	//   285: astore #4
	//   287: iload #10
	//   289: iconst_1
	//   290: iadd
	//   291: istore #5
	//   293: aload #4
	//   295: iload #10
	//   297: getstatic a.h : [C
	//   300: iload #11
	//   302: caload
	//   303: i2c
	//   304: castore
	//   305: aload_3
	//   306: getfield i : I
	//   309: iload #7
	//   311: isub
	//   312: istore #10
	//   314: aload_3
	//   315: getfield j : I
	//   318: iload #12
	//   320: isub
	//   321: istore #12
	//   323: iload #10
	//   325: iload #10
	//   327: bipush #8
	//   329: ishl
	//   330: ior
	//   331: ldc 16711935
	//   333: iand
	//   334: istore #10
	//   336: iload #10
	//   338: iload #10
	//   340: iconst_4
	//   341: ishl
	//   342: ior
	//   343: ldc 252645135
	//   345: iand
	//   346: istore #10
	//   348: iload #10
	//   350: iload #10
	//   352: iconst_2
	//   353: ishl
	//   354: ior
	//   355: ldc 858993459
	//   357: iand
	//   358: istore #10
	//   360: iload #12
	//   362: iload #12
	//   364: bipush #8
	//   366: ishl
	//   367: ior
	//   368: ldc 16711935
	//   370: iand
	//   371: istore #12
	//   373: iload #12
	//   375: iload #12
	//   377: iconst_4
	//   378: ishl
	//   379: ior
	//   380: ldc 252645135
	//   382: iand
	//   383: istore #12
	//   385: iload #12
	//   387: iload #12
	//   389: iconst_2
	//   390: ishl
	//   391: ior
	//   392: ldc 858993459
	//   394: iand
	//   395: istore #12
	//   397: aload_0
	//   398: getfield A : [C
	//   401: iload #5
	//   403: getstatic a.h : [C
	//   406: aload_3
	//   407: getfield type : I
	//   410: bipush #15
	//   412: iand
	//   413: caload
	//   414: i2c
	//   415: castore
	//   416: aload_3
	//   417: aload_0
	//   418: getfield A : [C
	//   421: iconst_0
	//   422: iload #5
	//   424: iconst_1
	//   425: iadd
	//   426: invokestatic valueOf : ([CII)Ljava/lang/String;
	//   429: putfield p : Ljava/lang/String;
	//   432: aload_3
	//   433: iload #10
	//   435: iload #10
	//   437: iconst_1
	//   438: ishl
	//   439: ior
	//   440: ldc 1431655765
	//   442: iand
	//   443: iload #12
	//   445: iload #12
	//   447: iconst_1
	//   448: ishl
	//   449: ior
	//   450: ldc 1431655765
	//   452: iand
	//   453: iconst_1
	//   454: ishl
	//   455: ior
	//   456: bipush #6
	//   458: imul
	//   459: putfield n : I
	//   462: iinc #2, 1
	//   465: goto -> 20
	//   468: iconst_0
	//   469: istore #5
	//   471: iload #5
	//   473: aload_1
	//   474: arraylength
	//   475: if_icmpge -> 642
	//   478: iload #5
	//   480: istore_2
	//   481: iload_2
	//   482: ifle -> 636
	//   485: aload_1
	//   486: iload_2
	//   487: iconst_1
	//   488: isub
	//   489: aaload
	//   490: getfield p : Ljava/lang/String;
	//   493: astore #4
	//   495: aload_1
	//   496: iload_2
	//   497: aaload
	//   498: getfield p : Ljava/lang/String;
	//   501: astore_3
	//   502: aload #4
	//   504: invokevirtual length : ()I
	//   507: istore #12
	//   509: iload #12
	//   511: aload_3
	//   512: invokevirtual length : ()I
	//   515: if_icmpeq -> 567
	//   518: iconst_0
	//   519: istore #12
	//   521: iload #12
	//   523: ifeq -> 616
	//   526: aload_1
	//   527: iload_2
	//   528: iconst_1
	//   529: isub
	//   530: aaload
	//   531: getfield n : I
	//   534: aload_1
	//   535: iload_2
	//   536: aaload
	//   537: getfield n : I
	//   540: if_icmple -> 636
	//   543: aload_1
	//   544: iload_2
	//   545: aaload
	//   546: astore_3
	//   547: aload_1
	//   548: iload_2
	//   549: aload_1
	//   550: iload_2
	//   551: iconst_1
	//   552: isub
	//   553: aaload
	//   554: aastore
	//   555: aload_1
	//   556: iload_2
	//   557: iconst_1
	//   558: isub
	//   559: aload_3
	//   560: aastore
	//   561: iinc #2, -1
	//   564: goto -> 481
	//   567: getstatic a.C : I
	//   570: istore #10
	//   572: iinc #12, -1
	//   575: iload #12
	//   577: iload #10
	//   579: if_icmple -> 610
	//   582: aload #4
	//   584: iload #12
	//   586: invokevirtual charAt : (I)C
	//   589: aload_3
	//   590: iload #12
	//   592: invokevirtual charAt : (I)C
	//   595: if_icmpeq -> 604
	//   598: iconst_0
	//   599: istore #12
	//   601: goto -> 521
	//   604: iinc #12, -1
	//   607: goto -> 575
	//   610: iconst_1
	//   611: istore #12
	//   613: goto -> 521
	//   616: aload_1
	//   617: iload_2
	//   618: iconst_1
	//   619: isub
	//   620: aaload
	//   621: getfield p : Ljava/lang/String;
	//   624: aload_1
	//   625: iload_2
	//   626: aaload
	//   627: getfield p : Ljava/lang/String;
	//   630: invokevirtual compareTo : (Ljava/lang/String;)I
	//   633: ifgt -> 543
	//   636: iinc #5, 1
	//   639: goto -> 471
	//   642: iconst_0
	//   643: istore #12
	//   645: aconst_null
	//   646: astore #15
	//   648: iload #12
	//   650: aload_1
	//   651: arraylength
	//   652: if_icmpge -> 16
	//   655: aload_1
	//   656: iload #12
	//   658: aaload
	//   659: getfield p : Ljava/lang/String;
	//   662: astore #4
	//   664: aload #15
	//   666: astore_3
	//   667: aload #4
	//   669: aload #15
	//   671: invokevirtual equals : (Ljava/lang/Object;)Z
	//   674: ifne -> 702
	//   677: new java/io/File
	//   680: astore_3
	//   681: aload_3
	//   682: aload_1
	//   683: iload #12
	//   685: aaload
	//   686: getfield p : Ljava/lang/String;
	//   689: invokespecial <init> : (Ljava/lang/String;)V
	//   692: aload_3
	//   693: invokevirtual exists : ()Z
	//   696: ifne -> 711
	//   699: aload #4
	//   701: astore_3
	//   702: iinc #12, 1
	//   705: aload_3
	//   706: astore #15
	//   708: goto -> 648
	//   711: new java/io/RandomAccessFile
	//   714: astore #15
	//   716: aload #15
	//   718: aload_3
	//   719: ldc 'r'
	//   721: invokespecial <init> : (Ljava/io/File;Ljava/lang/String;)V
	//   724: aload #15
	//   726: aload_0
	//   727: getfield z : [B
	//   730: iconst_0
	//   731: bipush #10
	//   733: invokevirtual readFully : ([BII)V
	//   736: aload_0
	//   737: getfield z : [B
	//   740: iconst_0
	//   741: invokestatic a : ([BI)I
	//   744: istore #5
	//   746: aload_0
	//   747: getfield z : [B
	//   750: iconst_4
	//   751: invokestatic b : ([BI)I
	//   754: istore #10
	//   756: getstatic a.g : I
	//   759: istore_2
	//   760: iload #5
	//   762: iload_2
	//   763: if_icmpeq -> 784
	//   766: aload #15
	//   768: invokevirtual close : ()V
	//   771: aload #4
	//   773: astore_3
	//   774: goto -> 702
	//   777: astore_3
	//   778: aload #4
	//   780: astore_3
	//   781: goto -> 702
	//   784: iload #10
	//   786: iconst_1
	//   787: if_icmpeq -> 805
	//   790: iload #10
	//   792: getstatic a.r : I
	//   795: if_icmpge -> 805
	//   798: aload_0
	//   799: iload #10
	//   801: iconst_1
	//   802: invokevirtual a : (IZ)V
	//   805: aload_0
	//   806: getfield z : [B
	//   809: bipush #6
	//   811: invokestatic a : ([BI)I
	//   814: istore #7
	//   816: iconst_0
	//   817: istore_2
	//   818: iconst_0
	//   819: istore #5
	//   821: iload #5
	//   823: aload_1
	//   824: arraylength
	//   825: if_icmpge -> 998
	//   828: iload_2
	//   829: istore #10
	//   831: aload_1
	//   832: iload #5
	//   834: aaload
	//   835: getfield p : Ljava/lang/String;
	//   838: aload #4
	//   840: invokevirtual compareTo : (Ljava/lang/String;)I
	//   843: ifne -> 976
	//   846: iload_2
	//   847: istore #10
	//   849: aload_1
	//   850: iload #5
	//   852: aaload
	//   853: invokevirtual a : ()[B
	//   856: ifnonnull -> 976
	//   859: aload_0
	//   860: getfield y : [I
	//   863: iload_2
	//   864: iload #5
	//   866: iastore
	//   867: iload_2
	//   868: iconst_1
	//   869: iadd
	//   870: istore #10
	//   872: iload #10
	//   874: aload_0
	//   875: getfield y : [I
	//   878: arraylength
	//   879: if_icmplt -> 912
	//   882: aload_0
	//   883: getfield y : [I
	//   886: arraylength
	//   887: iconst_1
	//   888: ishl
	//   889: newarray int
	//   891: astore_3
	//   892: aload_0
	//   893: getfield y : [I
	//   896: iconst_0
	//   897: aload_3
	//   898: iconst_0
	//   899: aload_0
	//   900: getfield y : [I
	//   903: arraylength
	//   904: invokestatic arraycopy : (Ljava/lang/Object;ILjava/lang/Object;II)V
	//   907: aload_0
	//   908: aload_3
	//   909: putfield y : [I
	//   912: aload #15
	//   914: aload_1
	//   915: iload #5
	//   917: aaload
	//   918: getfield n : I
	//   921: iload #7
	//   923: iadd
	//   924: i2l
	//   925: invokevirtual seek : (J)V
	//   928: aload #15
	//   930: aload_0
	//   931: getfield z : [B
	//   934: iconst_0
	//   935: bipush #6
	//   937: invokevirtual readFully : ([BII)V
	//   940: aload_0
	//   941: getfield z : [B
	//   944: iconst_0
	//   945: invokestatic a : ([BI)I
	//   948: istore_2
	//   949: aload_0
	//   950: getfield z : [B
	//   953: iconst_4
	//   954: invokestatic b : ([BI)I
	//   957: istore #8
	//   959: aload_1
	//   960: iload #5
	//   962: aaload
	//   963: iload_2
	//   964: putfield m : I
	//   967: aload_1
	//   968: iload #5
	//   970: aaload
	//   971: iload #8
	//   973: putfield o : I
	//   976: iinc #5, 1
	//   979: iload #10
	//   981: istore_2
	//   982: goto -> 821
	//   985: astore_3
	//   986: aload #15
	//   988: invokevirtual close : ()V
	//   991: goto -> 16
	//   994: astore_3
	//   995: goto -> 16
	//   998: iconst_0
	//   999: istore #5
	//   1001: iload #5
	//   1003: iload_2
	//   1004: if_icmpge -> 1093
	//   1007: iload #5
	//   1009: istore #10
	//   1011: iload #10
	//   1013: ifle -> 1087
	//   1016: aload_1
	//   1017: aload_0
	//   1018: getfield y : [I
	//   1021: iload #10
	//   1023: iconst_1
	//   1024: isub
	//   1025: iaload
	//   1026: aaload
	//   1027: getfield m : I
	//   1030: aload_1
	//   1031: aload_0
	//   1032: getfield y : [I
	//   1035: iload #10
	//   1037: iaload
	//   1038: aaload
	//   1039: getfield m : I
	//   1042: if_icmple -> 1087
	//   1045: aload_0
	//   1046: getfield y : [I
	//   1049: iload #10
	//   1051: iaload
	//   1052: istore #7
	//   1054: aload_0
	//   1055: getfield y : [I
	//   1058: iload #10
	//   1060: aload_0
	//   1061: getfield y : [I
	//   1064: iload #10
	//   1066: iconst_1
	//   1067: isub
	//   1068: iaload
	//   1069: iastore
	//   1070: aload_0
	//   1071: getfield y : [I
	//   1074: iload #10
	//   1076: iconst_1
	//   1077: isub
	//   1078: iload #7
	//   1080: iastore
	//   1081: iinc #10, -1
	//   1084: goto -> 1011
	//   1087: iinc #5, 1
	//   1090: goto -> 1001
	//   1093: iconst_0
	//   1094: istore #5
	//   1096: iload #5
	//   1098: iload_2
	//   1099: if_icmpge -> 1526
	//   1102: aload_1
	//   1103: aload_0
	//   1104: getfield y : [I
	//   1107: iload #5
	//   1109: iaload
	//   1110: aaload
	//   1111: astore #16
	//   1113: aload #16
	//   1115: getfield m : I
	//   1118: ifle -> 1458
	//   1121: aload #15
	//   1123: aload #16
	//   1125: getfield m : I
	//   1128: i2l
	//   1129: invokevirtual seek : (J)V
	//   1132: aload #16
	//   1134: getfield o : I
	//   1137: bipush #38
	//   1139: iadd
	//   1140: newarray byte
	//   1142: astore_3
	//   1143: aload #16
	//   1145: getfield o : I
	//   1148: istore #10
	//   1150: getstatic am.a : I
	//   1153: aload_3
	//   1154: iconst_0
	//   1155: invokestatic a : (I[BI)V
	//   1158: iconst_1
	//   1159: aload_3
	//   1160: iconst_4
	//   1161: invokestatic b : (I[BI)V
	//   1164: iconst_1
	//   1165: aload_3
	//   1166: bipush #6
	//   1168: invokestatic b : (I[BI)V
	//   1171: bipush #16
	//   1173: newarray byte
	//   1175: dup
	//   1176: iconst_0
	//   1177: ldc 0
	//   1179: bastore
	//   1180: dup
	//   1181: iconst_1
	//   1182: ldc 0
	//   1184: bastore
	//   1185: dup
	//   1186: iconst_2
	//   1187: ldc 0
	//   1189: bastore
	//   1190: dup
	//   1191: iconst_3
	//   1192: ldc 0
	//   1194: bastore
	//   1195: dup
	//   1196: iconst_4
	//   1197: ldc 0
	//   1199: bastore
	//   1200: dup
	//   1201: iconst_5
	//   1202: ldc 0
	//   1204: bastore
	//   1205: dup
	//   1206: bipush #6
	//   1208: ldc 0
	//   1210: bastore
	//   1211: dup
	//   1212: bipush #7
	//   1214: ldc 0
	//   1216: bastore
	//   1217: dup
	//   1218: bipush #8
	//   1220: ldc 0
	//   1222: bastore
	//   1223: dup
	//   1224: bipush #9
	//   1226: ldc 0
	//   1228: bastore
	//   1229: dup
	//   1230: bipush #10
	//   1232: ldc 0
	//   1234: bastore
	//   1235: dup
	//   1236: bipush #11
	//   1238: ldc 0
	//   1240: bastore
	//   1241: dup
	//   1242: bipush #12
	//   1244: ldc 0
	//   1246: bastore
	//   1247: dup
	//   1248: bipush #13
	//   1250: ldc 0
	//   1252: bastore
	//   1253: dup
	//   1254: bipush #14
	//   1256: ldc 0
	//   1258: bastore
	//   1259: dup
	//   1260: bipush #15
	//   1262: ldc 0
	//   1264: bastore
	//   1265: iconst_0
	//   1266: aload_3
	//   1267: bipush #8
	//   1269: bipush #16
	//   1271: invokestatic arraycopy : (Ljava/lang/Object;ILjava/lang/Object;II)V
	//   1274: getstatic a.r : I
	//   1277: aload_3
	//   1278: bipush #24
	//   1280: invokestatic b : (I[BI)V
	//   1283: iconst_0
	//   1284: aload_3
	//   1285: bipush #26
	//   1287: invokestatic a : (I[BI)V
	//   1290: iconst_1
	//   1291: aload_3
	//   1292: bipush #30
	//   1294: invokestatic a : (I[BI)V
	//   1297: iload #10
	//   1299: aload_3
	//   1300: bipush #34
	//   1302: invokestatic a : (I[BI)V
	//   1305: aload #15
	//   1307: aload_3
	//   1308: bipush #38
	//   1310: aload_3
	//   1311: arraylength
	//   1312: bipush #38
	//   1314: isub
	//   1315: invokevirtual read : ([BII)I
	//   1318: istore #10
	//   1320: iload #10
	//   1322: bipush #38
	//   1324: iadd
	//   1325: aload_3
	//   1326: arraylength
	//   1327: if_icmpge -> 1503
	//   1330: aload #15
	//   1332: aload_3
	//   1333: iload #10
	//   1335: bipush #38
	//   1337: iadd
	//   1338: aload_3
	//   1339: arraylength
	//   1340: iload #10
	//   1342: isub
	//   1343: bipush #38
	//   1345: isub
	//   1346: invokevirtual read : ([BII)I
	//   1349: istore #7
	//   1351: iload #7
	//   1353: iconst_m1
	//   1354: if_icmpeq -> 1491
	//   1357: iload #10
	//   1359: iload #7
	//   1361: iadd
	//   1362: istore #10
	//   1364: goto -> 1320
	//   1367: astore_3
	//   1368: new java/lang/StringBuilder
	//   1371: astore_3
	//   1372: aload_3
	//   1373: invokespecial <init> : ()V
	//   1376: ldc_w 'FCACHE'
	//   1379: aload_3
	//   1380: ldc_w 'j = '
	//   1383: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   1386: iload #5
	//   1388: invokevirtual append : (I)Ljava/lang/StringBuilder;
	//   1391: ldc_w ' tilesInCurrentFile.len = '
	//   1394: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   1397: aload_0
	//   1398: getfield y : [I
	//   1401: arraylength
	//   1402: invokevirtual append : (I)Ljava/lang/StringBuilder;
	//   1405: ldc_w ' tileRequests.len '
	//   1408: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   1411: aload_1
	//   1412: arraylength
	//   1413: invokevirtual append : (I)Ljava/lang/StringBuilder;
	//   1416: invokevirtual toString : ()Ljava/lang/String;
	//   1419: invokestatic w : (Ljava/lang/String;Ljava/lang/String;)I
	//   1422: pop
	//   1423: new java/lang/StringBuilder
	//   1426: astore_3
	//   1427: aload_3
	//   1428: invokespecial <init> : ()V
	//   1431: ldc_w 'FCACHE'
	//   1434: aload_3
	//   1435: ldc_w ' tilesInCurrentFile[j] = '
	//   1438: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   1441: aload_0
	//   1442: getfield y : [I
	//   1445: iload #5
	//   1447: iaload
	//   1448: invokevirtual append : (I)Ljava/lang/StringBuilder;
	//   1451: invokevirtual toString : ()Ljava/lang/String;
	//   1454: invokestatic w : (Ljava/lang/String;Ljava/lang/String;)I
	//   1457: pop
	//   1458: iinc #5, 1
	//   1461: goto -> 1096
	//   1464: astore_3
	//   1465: invokestatic gc : ()V
	//   1468: invokestatic gc : ()V
	//   1471: ldc2_w 250
	//   1474: invokestatic sleep : (J)V
	//   1477: aload #16
	//   1479: getfield o : I
	//   1482: bipush #38
	//   1484: iadd
	//   1485: newarray byte
	//   1487: astore_3
	//   1488: goto -> 1143
	//   1491: aload #15
	//   1493: invokevirtual close : ()V
	//   1496: goto -> 16
	//   1499: astore_3
	//   1500: goto -> 16
	//   1503: aload #16
	//   1505: aload_3
	//   1506: invokevirtual a : ([B)V
	//   1509: goto -> 1458
	//   1512: astore_1
	//   1513: aload #15
	//   1515: astore_3
	//   1516: aload_3
	//   1517: ifnull -> 1524
	//   1520: aload_3
	//   1521: invokevirtual close : ()V
	//   1524: aload_1
	//   1525: athrow
	//   1526: aload #15
	//   1528: invokevirtual close : ()V
	//   1531: aload #4
	//   1533: astore_3
	//   1534: goto -> 702
	//   1537: astore_3
	//   1538: aload #4
	//   1540: astore_3
	//   1541: goto -> 702
	//   1544: astore_3
	//   1545: goto -> 1477
	//   1548: astore_3
	//   1549: goto -> 1524
	//   1552: astore_1
	//   1553: aconst_null
	//   1554: astore_3
	//   1555: goto -> 1516
	//   1558: astore_3
	//   1559: goto -> 1458
	//   1562: astore_3
	//   1563: goto -> 1423
	//   1566: iload #12
	//   1568: istore #5
	//   1570: goto -> 247
	// Exception table:
	//   from	to	target	type
	//   677	699	1552	finally
	//   711	724	1552	finally
	//   724	760	1512	finally
	//   766	771	777	java/lang/Exception
	//   790	805	1512	finally
	//   805	816	1512	finally
	//   821	828	1512	finally
	//   831	846	1512	finally
	//   849	867	1512	finally
	//   872	912	1512	finally
	//   912	928	1512	finally
	//   928	940	985	java/lang/Exception
	//   928	940	1512	finally
	//   940	976	1512	finally
	//   986	991	994	java/lang/Exception
	//   1016	1081	1512	finally
	//   1102	1113	1367	java/lang/Exception
	//   1102	1113	1512	finally
	//   1113	1132	1512	finally
	//   1132	1143	1464	java/lang/OutOfMemoryError
	//   1132	1143	1512	finally
	//   1143	1320	1512	finally
	//   1320	1351	1512	finally
	//   1368	1423	1562	java/lang/Exception
	//   1368	1423	1512	finally
	//   1423	1458	1558	java/lang/Exception
	//   1423	1458	1512	finally
	//   1465	1471	1512	finally
	//   1471	1477	1544	java/lang/Exception
	//   1471	1477	1512	finally
	//   1477	1488	1512	finally
	//   1491	1496	1499	java/lang/Exception
	//   1503	1509	1512	finally
	//   1520	1524	1548	java/lang/Exception
	//   1526	1531	1537	java/lang/Exception
  }

  private static void c(am paramam)
  {
	ap ap = ap.a();
	if (ap != null)
	{
	  paramam.p = null;
	  try
	  {
		ap.a(paramam, true);
	  }
	  catch (Exception)
	  {
	  }
	}
  }

  private void g()
  {
	if (this.k == null)
	{
	  lock (this.j)
	  {
		Thread thread = new Thread();
		this(this, "ymm-file-cache");
		this.k = thread;
		this.k.setPriority(1);
		this.k.Start();
		return;
	  }
	}
  }

  private void h()
  {
	// Byte code:
	//   0: iconst_0
	//   1: istore_1
	//   2: aload_0
	//   3: iconst_0
	//   4: putfield u : Z
	//   7: aload_0
	//   8: iconst_0
	//   9: putfield t : I
	//   12: aload_0
	//   13: getfield v : Z
	//   16: ifeq -> 20
	//   19: return
	//   20: new java/util/ArrayList
	//   23: astore_2
	//   24: aload_2
	//   25: invokespecial <init> : ()V
	//   28: invokestatic getExternalStorageState : ()Ljava/lang/String;
	//   31: ldc_w 'mounted'
	//   34: invokevirtual equals : (Ljava/lang/Object;)Z
	//   37: ifeq -> 142
	//   40: invokestatic getExternalStorageDirectory : ()Ljava/io/File;
	//   43: invokevirtual getAbsolutePath : ()Ljava/lang/String;
	//   46: astore_3
	//   47: new java/lang/StringBuilder
	//   50: astore #4
	//   52: aload #4
	//   54: invokespecial <init> : ()V
	//   57: aload_0
	//   58: aload #4
	//   60: aload_0
	//   61: aload_3
	//   62: invokespecial a : (Ljava/lang/String;)Ljava/lang/String;
	//   65: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   68: ldc 'cache'
	//   70: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   73: aload_0
	//   74: getfield x : C
	//   77: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   80: invokevirtual toString : ()Ljava/lang/String;
	//   83: aload_2
	//   84: iconst_0
	//   85: invokespecial a : (Ljava/lang/String;Ljava/util/ArrayList;Z)V
	//   88: new java/lang/StringBuilder
	//   91: astore #4
	//   93: aload #4
	//   95: invokespecial <init> : ()V
	//   98: aload_0
	//   99: aload #4
	//   101: aload_0
	//   102: aload_3
	//   103: invokespecial a : (Ljava/lang/String;)Ljava/lang/String;
	//   106: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   109: ldc_w 'data'
	//   112: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   115: aload_0
	//   116: getfield x : C
	//   119: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   122: ldc 'cache'
	//   124: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   127: aload_0
	//   128: getfield x : C
	//   131: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   134: invokevirtual toString : ()Ljava/lang/String;
	//   137: aload_2
	//   138: iconst_0
	//   139: invokespecial a : (Ljava/lang/String;Ljava/util/ArrayList;Z)V
	//   142: getstatic a.e : Ljava/lang/ref/WeakReference;
	//   145: invokevirtual get : ()Ljava/lang/Object;
	//   148: checkcast android/content/Context
	//   151: astore_3
	//   152: aload_3
	//   153: ifnull -> 262
	//   156: aload_3
	//   157: ldc 'yandexmaps'
	//   159: iconst_1
	//   160: invokevirtual getDir : (Ljava/lang/String;I)Ljava/io/File;
	//   163: invokevirtual getAbsolutePath : ()Ljava/lang/String;
	//   166: astore_3
	//   167: new java/lang/StringBuilder
	//   170: astore #4
	//   172: aload #4
	//   174: invokespecial <init> : ()V
	//   177: aload_0
	//   178: aload #4
	//   180: aload_0
	//   181: aload_3
	//   182: invokespecial a : (Ljava/lang/String;)Ljava/lang/String;
	//   185: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   188: ldc 'cache'
	//   190: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   193: aload_0
	//   194: getfield x : C
	//   197: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   200: invokevirtual toString : ()Ljava/lang/String;
	//   203: aload_2
	//   204: iconst_0
	//   205: invokespecial a : (Ljava/lang/String;Ljava/util/ArrayList;Z)V
	//   208: new java/lang/StringBuilder
	//   211: astore #4
	//   213: aload #4
	//   215: invokespecial <init> : ()V
	//   218: aload_0
	//   219: aload #4
	//   221: aload_0
	//   222: aload_3
	//   223: invokespecial a : (Ljava/lang/String;)Ljava/lang/String;
	//   226: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   229: ldc_w 'data'
	//   232: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   235: aload_0
	//   236: getfield x : C
	//   239: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   242: ldc 'cache'
	//   244: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   247: aload_0
	//   248: getfield x : C
	//   251: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   254: invokevirtual toString : ()Ljava/lang/String;
	//   257: aload_2
	//   258: iconst_0
	//   259: invokespecial a : (Ljava/lang/String;Ljava/util/ArrayList;Z)V
	//   262: aload_0
	//   263: bipush #10
	//   265: putfield t : I
	//   268: aload_2
	//   269: invokevirtual size : ()I
	//   272: istore #5
	//   274: iload_1
	//   275: iload #5
	//   277: if_icmpge -> 415
	//   280: aload_2
	//   281: iload_1
	//   282: invokevirtual get : (I)Ljava/lang/Object;
	//   285: checkcast f
	//   288: astore_3
	//   289: aload_0
	//   290: getfield v : Z
	//   293: istore #6
	//   295: iload #6
	//   297: ifne -> 19
	//   300: new java/io/File
	//   303: astore #4
	//   305: new java/lang/StringBuilder
	//   308: astore #7
	//   310: aload #7
	//   312: invokespecial <init> : ()V
	//   315: aload #4
	//   317: aload #7
	//   319: aload_3
	//   320: getfield a : Ljava/lang/String;
	//   323: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   326: aload_0
	//   327: getfield x : C
	//   330: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   333: aload_3
	//   334: getfield b : Ljava/lang/String;
	//   337: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   340: invokevirtual toString : ()Ljava/lang/String;
	//   343: invokespecial <init> : (Ljava/lang/String;)V
	//   346: aload #4
	//   348: invokevirtual delete : ()Z
	//   351: ifne -> 365
	//   354: aload_0
	//   355: bipush #100
	//   357: putfield t : I
	//   360: aload_0
	//   361: iconst_1
	//   362: putfield v : Z
	//   365: aload_0
	//   366: iload_1
	//   367: bipush #90
	//   369: imul
	//   370: iload #5
	//   372: idiv
	//   373: bipush #10
	//   375: iadd
	//   376: putfield t : I
	//   379: iinc #1, 1
	//   382: goto -> 274
	//   385: astore_3
	//   386: aload_0
	//   387: bipush #100
	//   389: putfield t : I
	//   392: aload_0
	//   393: iconst_1
	//   394: putfield v : Z
	//   397: goto -> 365
	//   400: astore_2
	//   401: aload_0
	//   402: bipush #100
	//   404: putfield t : I
	//   407: aload_0
	//   408: iconst_1
	//   409: putfield v : Z
	//   412: goto -> 19
	//   415: aload_0
	//   416: bipush #100
	//   418: putfield t : I
	//   421: aload_0
	//   422: iconst_0
	//   423: putfield w : Z
	//   426: goto -> 19
	// Exception table:
	//   from	to	target	type
	//   20	142	400	java/lang/Throwable
	//   142	152	400	java/lang/Throwable
	//   156	262	400	java/lang/Throwable
	//   262	274	400	java/lang/Throwable
	//   280	295	400	java/lang/Throwable
	//   300	365	385	java/lang/Exception
	//   300	365	400	java/lang/Throwable
	//   365	379	400	java/lang/Throwable
	//   386	397	400	java/lang/Throwable
	//   415	426	400	java/lang/Throwable
  }

  private void i()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield m : Ljava/util/ArrayList;
	//   6: ifnull -> 52
	//   9: aload_0
	//   10: getfield m : Ljava/util/ArrayList;
	//   13: invokevirtual isEmpty : ()Z
	//   16: ifne -> 52
	//   19: iconst_0
	//   20: istore_1
	//   21: iload_1
	//   22: aload_0
	//   23: getfield m : Ljava/util/ArrayList;
	//   26: invokevirtual size : ()I
	//   29: if_icmpge -> 52
	//   32: aload_0
	//   33: getfield m : Ljava/util/ArrayList;
	//   36: iload_1
	//   37: invokevirtual get : (I)Ljava/lang/Object;
	//   40: checkcast am
	//   43: invokestatic c : (Lam;)V
	//   46: iinc #1, 1
	//   49: goto -> 21
	//   52: aload_0
	//   53: monitorexit
	//   54: return
	//   55: astore_2
	//   56: aload_0
	//   57: monitorexit
	//   58: aload_2
	//   59: athrow
	// Exception table:
	//   from	to	target	type
	//   2	19	55	finally
	//   21	46	55	finally
  }

  public string a()
  {
	if (string.ReferenceEquals(this.p, null) || this.p.Equals(""))
	{
	  c();
	}
	return this.p + "data" + this.x + "cache";
  }

  public Thread a(bool paramBoolean)
  {
	lock (this.j)
	{
	  Thread thread = this.k;
	  this.u = false;
	  if (paramBoolean || this.w)
	  {
		this.k = null;
		this.b_Conflict = true;
	  }
	  else
	  {
		this.c_Conflict = true;
	  }
	  if (this.w)
	  {
		this.w = false;
		this.v = true;
	  }
	  Monitor.PulseAll(this.j);
	  return thread;
	}
  }

//JAVA TO C# CONVERTER NOTE: Members cannot have the same name as their enclosing type:
  public void a_Conflict(int paramInt, bool paramBoolean)
  {
	r = paramInt;
	b.b_Conflict(paramInt, f_Conflict, 4);
	this.s |= paramBoolean;
  }

//JAVA TO C# CONVERTER NOTE: Members cannot have the same name as their enclosing type:
  public void a_Conflict(am paramam)
  {
	if (paramam.a() != null && (paramam.a()).Length >= 8 && (paramam.a()).Length < 65536)
	{
	  int i = paramam.i;
	  int j = paramam.j;
	  int k = paramam.zoom;
	  if (i >= 0 && j >= 0 && k >= 0 && k < 24 && i < 2 << k && j < 2 << k)
	  {
		i = 1;
	  }
	  else
	  {
		i = 0;
	  }
	  if (i != 0 && this.d_Conflict)
	  {
		Bitmap bitmap = null;
		try
		{
		  Bitmap bitmap1 = paramam.d();
		  bitmap = bitmap1;
		}
		catch (Exception)
		{
		}
		if (bitmap != null || paramam.d_Conflict)
		{
		  lock (this.i_Conflict)
		  {
			this.l.Add(paramam);
			g();
			return;
		  }
		}
	  }
	}
  }

//JAVA TO C# CONVERTER NOTE: Members cannot have the same name as their enclosing type:
  public void a_Conflict(Context paramContext)
  {
	e_Conflict = new WeakReference<Context>(paramContext);
	this.d_Conflict = true;
	this.b_Conflict = false;
	this.o = false;
	this.n = false;
	this.l.Clear();
	this.m.Clear();
	for (sbyte b = 0; b < 24; b++)
	{
	  long l = 1L;
	  sbyte b1 = 0;
	  while (l < 4L << b << 1)
	  {
		b1++;
		l <<= 8L;
	  }
	  this.q[b] = b1;
	}
	this.c_Conflict = false;
	this.s = false;
	if (a_Conflict > r)
	{
	  a_Conflict(a_Conflict, true);
	}
  }

  public char b()
  {
	return this.x;
  }

  public void b(am paramam)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield b : Z
	//   4: ifeq -> 12
	//   7: aload_1
	//   8: invokestatic c : (Lam;)V
	//   11: return
	//   12: aload_0
	//   13: getfield i : Ljava/lang/Object;
	//   16: astore_2
	//   17: aload_2
	//   18: monitorenter
	//   19: aload_1
	//   20: getfield i : I
	//   23: istore_3
	//   24: aload_1
	//   25: getfield j : I
	//   28: istore #4
	//   30: aload_1
	//   31: getfield zoom : I
	//   34: istore #5
	//   36: aload_1
	//   37: getfield type : I
	//   40: istore #6
	//   42: aload_0
	//   43: getfield m : Ljava/util/ArrayList;
	//   46: invokevirtual size : ()I
	//   49: istore #7
	//   51: iconst_0
	//   52: istore #8
	//   54: iload #8
	//   56: iload #7
	//   58: if_icmpge -> 130
	//   61: aload_0
	//   62: getfield m : Ljava/util/ArrayList;
	//   65: iload #8
	//   67: invokevirtual get : (I)Ljava/lang/Object;
	//   70: checkcast am
	//   73: astore #9
	//   75: aload #9
	//   77: getfield i : I
	//   80: iload_3
	//   81: if_icmpne -> 124
	//   84: aload #9
	//   86: getfield j : I
	//   89: iload #4
	//   91: if_icmpne -> 124
	//   94: aload #9
	//   96: getfield zoom : I
	//   99: iload #5
	//   101: if_icmpne -> 124
	//   104: aload #9
	//   106: getfield type : I
	//   109: iload #6
	//   111: if_icmpne -> 124
	//   114: aload_2
	//   115: monitorexit
	//   116: goto -> 11
	//   119: astore_1
	//   120: aload_2
	//   121: monitorexit
	//   122: aload_1
	//   123: athrow
	//   124: iinc #8, 1
	//   127: goto -> 54
	//   130: aload_0
	//   131: getfield m : Ljava/util/ArrayList;
	//   134: aload_1
	//   135: invokevirtual add : (Ljava/lang/Object;)Z
	//   138: pop
	//   139: aload_2
	//   140: monitorexit
	//   141: aload_0
	//   142: invokespecial g : ()V
	//   145: goto -> 11
	// Exception table:
	//   from	to	target	type
	//   19	51	119	finally
	//   61	116	119	finally
	//   130	141	119	finally
  }

  public void c()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: invokestatic getExternalStorageState : ()Ljava/lang/String;
	//   5: ldc_w 'mounted'
	//   8: invokevirtual equals : (Ljava/lang/Object;)Z
	//   11: ifeq -> 51
	//   14: invokestatic getExternalStorageDirectory : ()Ljava/io/File;
	//   17: invokevirtual getAbsolutePath : ()Ljava/lang/String;
	//   20: astore_1
	//   21: aload_1
	//   22: ifnull -> 79
	//   25: aload_0
	//   26: aload_1
	//   27: invokespecial a : (Ljava/lang/String;)Ljava/lang/String;
	//   30: astore_1
	//   31: aload_0
	//   32: getfield p : Ljava/lang/String;
	//   35: ldc ''
	//   37: invokevirtual equals : (Ljava/lang/Object;)Z
	//   40: ifeq -> 48
	//   43: aload_0
	//   44: aload_1
	//   45: putfield p : Ljava/lang/String;
	//   48: aload_0
	//   49: monitorexit
	//   50: return
	//   51: getstatic a.e : Ljava/lang/ref/WeakReference;
	//   54: invokevirtual get : ()Ljava/lang/Object;
	//   57: checkcast android/content/Context
	//   60: astore_1
	//   61: aload_1
	//   62: ifnull -> 91
	//   65: aload_1
	//   66: ldc 'yandexmaps'
	//   68: iconst_1
	//   69: invokevirtual getDir : (Ljava/lang/String;I)Ljava/io/File;
	//   72: invokevirtual getAbsolutePath : ()Ljava/lang/String;
	//   75: astore_1
	//   76: goto -> 21
	//   79: ldc_w './'
	//   82: astore_1
	//   83: goto -> 25
	//   86: astore_1
	//   87: aload_0
	//   88: monitorexit
	//   89: aload_1
	//   90: athrow
	//   91: aconst_null
	//   92: astore_1
	//   93: goto -> 21
	// Exception table:
	//   from	to	target	type
	//   2	21	86	finally
	//   25	48	86	finally
	//   51	61	86	finally
	//   65	76	86	finally
  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
  [DllImport("unknown")]
  public extern void createCache(string paramString);

  public void d()
  {
	lock (this.j)
	{
	  this.n = true;
	  this.o = true;
	  Monitor.PulseAll(this.j);
	  return;
	}
  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
  [DllImport("unknown")]
  public extern void deleteCache();

  public void e()
  {
	lock (this.j)
	{
	  this.o = true;
	  Monitor.PulseAll(this.j);
	  return;
	}
  }

  public void f()
  {
	createCache("/data/cache/ru/default");
  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
  [DllImport("unknown")]
  public extern void readTilesAll(am[] paramArrayOfam);

  public void run()
  {
	// Byte code:
	//   0: invokestatic registerCurrentThread : ()I
	//   3: pop
	//   4: aload_0
	//   5: invokevirtual c : ()V
	//   8: iconst_0
	//   9: istore_1
	//   10: iload_1
	//   11: aload_0
	//   12: getfield B : [[C
	//   15: arraylength
	//   16: if_icmpge -> 78
	//   19: aload_0
	//   20: getfield B : [[C
	//   23: astore_2
	//   24: new java/lang/StringBuilder
	//   27: astore_3
	//   28: aload_3
	//   29: invokespecial <init> : ()V
	//   32: aload_2
	//   33: iload_1
	//   34: aload_3
	//   35: aload_0
	//   36: getfield p : Ljava/lang/String;
	//   39: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   42: ldc 'cache'
	//   44: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   47: aload_0
	//   48: getfield x : C
	//   51: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   54: iload_1
	//   55: invokevirtual append : (I)Ljava/lang/StringBuilder;
	//   58: aload_0
	//   59: getfield x : C
	//   62: invokevirtual append : (C)Ljava/lang/StringBuilder;
	//   65: invokevirtual toString : ()Ljava/lang/String;
	//   68: invokevirtual toCharArray : ()[C
	//   71: aastore
	//   72: iinc #1, 1
	//   75: goto -> 10
	//   78: aload_0
	//   79: getfield B : [[C
	//   82: iconst_0
	//   83: aaload
	//   84: arraylength
	//   85: iconst_2
	//   86: isub
	//   87: putstatic a.C : I
	//   90: aload_0
	//   91: iconst_0
	//   92: putfield n : Z
	//   95: aload_0
	//   96: iconst_1
	//   97: putfield d : Z
	//   100: invokestatic currentTimeMillis : ()J
	//   103: lstore #4
	//   105: aload_0
	//   106: getfield k : Ljava/lang/Thread;
	//   109: ifnull -> 664
	//   112: aload_0
	//   113: getfield b : Z
	//   116: ifne -> 664
	//   119: aload_0
	//   120: getfield i : Ljava/lang/Object;
	//   123: astore #6
	//   125: aload #6
	//   127: monitorenter
	//   128: aload_0
	//   129: getfield m : Ljava/util/ArrayList;
	//   132: invokevirtual isEmpty : ()Z
	//   135: ifeq -> 307
	//   138: aload_0
	//   139: getfield l : Ljava/util/ArrayList;
	//   142: invokevirtual size : ()I
	//   145: ifle -> 302
	//   148: invokestatic currentTimeMillis : ()J
	//   151: lload #4
	//   153: lsub
	//   154: ldc2_w 15000
	//   157: lcmp
	//   158: ifle -> 302
	//   161: iconst_1
	//   162: istore_1
	//   163: iload_1
	//   164: ifne -> 174
	//   167: aload_0
	//   168: getfield n : Z
	//   171: ifeq -> 329
	//   174: aload_0
	//   175: iconst_0
	//   176: putfield n : Z
	//   179: aload_0
	//   180: getfield l : Ljava/util/ArrayList;
	//   183: invokevirtual size : ()I
	//   186: anewarray am
	//   189: astore_3
	//   190: aload_0
	//   191: getfield l : Ljava/util/ArrayList;
	//   194: aload_3
	//   195: invokevirtual toArray : ([Ljava/lang/Object;)[Ljava/lang/Object;
	//   198: pop
	//   199: aload_0
	//   200: getfield l : Ljava/util/ArrayList;
	//   203: invokevirtual clear : ()V
	//   206: aconst_null
	//   207: astore_2
	//   208: aload #6
	//   210: monitorexit
	//   211: aload_3
	//   212: ifnull -> 722
	//   215: aload_3
	//   216: arraylength
	//   217: ifle -> 722
	//   220: iconst_0
	//   221: istore_1
	//   222: iload_1
	//   223: aload_3
	//   224: arraylength
	//   225: if_icmpge -> 386
	//   228: aload_0
	//   229: aload_3
	//   230: iload_1
	//   231: aaload
	//   232: getfield i : I
	//   235: aload_3
	//   236: iload_1
	//   237: aaload
	//   238: getfield j : I
	//   241: aload_3
	//   242: iload_1
	//   243: aaload
	//   244: getfield zoom : I
	//   247: aload_3
	//   248: iload_1
	//   249: aaload
	//   250: getfield type : I
	//   253: aload_3
	//   254: iload_1
	//   255: aaload
	//   256: invokevirtual a : ()[B
	//   259: invokevirtual writeTile : (IIII[B)V
	//   262: iinc #1, 1
	//   265: goto -> 222
	//   268: astore_2
	//   269: aload_0
	//   270: getfield l : Ljava/util/ArrayList;
	//   273: ifnull -> 283
	//   276: aload_0
	//   277: getfield l : Ljava/util/ArrayList;
	//   280: invokevirtual clear : ()V
	//   283: aload_0
	//   284: aconst_null
	//   285: putfield k : Ljava/lang/Thread;
	//   288: aconst_null
	//   289: putstatic a.e : Ljava/lang/ref/WeakReference;
	//   292: aload_0
	//   293: iconst_1
	//   294: putfield b : Z
	//   297: aload_0
	//   298: invokespecial i : ()V
	//   301: return
	//   302: iconst_0
	//   303: istore_1
	//   304: goto -> 163
	//   307: aload_0
	//   308: getfield l : Ljava/util/ArrayList;
	//   311: invokevirtual size : ()I
	//   314: bipush #10
	//   316: if_icmplt -> 324
	//   319: iconst_1
	//   320: istore_1
	//   321: goto -> 163
	//   324: iconst_0
	//   325: istore_1
	//   326: goto -> 163
	//   329: aload_0
	//   330: getfield c : Z
	//   333: ifne -> 725
	//   336: aload_0
	//   337: getfield m : Ljava/util/ArrayList;
	//   340: invokevirtual size : ()I
	//   343: istore_1
	//   344: iload_1
	//   345: ifle -> 725
	//   348: iload_1
	//   349: anewarray am
	//   352: astore_2
	//   353: aload_0
	//   354: getfield m : Ljava/util/ArrayList;
	//   357: aload_2
	//   358: invokevirtual toArray : ([Ljava/lang/Object;)[Ljava/lang/Object;
	//   361: pop
	//   362: aload_0
	//   363: getfield m : Ljava/util/ArrayList;
	//   366: invokevirtual clear : ()V
	//   369: aconst_null
	//   370: astore_3
	//   371: goto -> 208
	//   374: astore_2
	//   375: aload #6
	//   377: monitorexit
	//   378: aload_2
	//   379: athrow
	//   380: astore_3
	//   381: aload_0
	//   382: iconst_0
	//   383: putfield d : Z
	//   386: invokestatic currentTimeMillis : ()J
	//   389: lstore #4
	//   391: aload_0
	//   392: getfield c : Z
	//   395: ifne -> 664
	//   398: aload_2
	//   399: ifnull -> 568
	//   402: aload_0
	//   403: aload_2
	//   404: invokevirtual readTilesAll : ([Lam;)V
	//   407: new java/util/ArrayList
	//   410: astore_3
	//   411: aload_3
	//   412: aload_2
	//   413: arraylength
	//   414: invokespecial <init> : (I)V
	//   417: iconst_0
	//   418: istore_1
	//   419: iload_1
	//   420: aload_2
	//   421: arraylength
	//   422: if_icmpge -> 532
	//   425: aload_2
	//   426: iload_1
	//   427: aaload
	//   428: invokevirtual a : ()[B
	//   431: ifnull -> 444
	//   434: aload_2
	//   435: iload_1
	//   436: aaload
	//   437: invokevirtual a : ()[B
	//   440: arraylength
	//   441: ifne -> 483
	//   444: aload_2
	//   445: iload_1
	//   446: aaload
	//   447: instanceof bg
	//   450: ifne -> 468
	//   453: aload_2
	//   454: iload_1
	//   455: aaload
	//   456: iconst_1
	//   457: putfield t : Z
	//   460: aload_3
	//   461: aload_2
	//   462: iload_1
	//   463: aaload
	//   464: invokevirtual add : (Ljava/lang/Object;)Z
	//   467: pop
	//   468: iinc #1, 1
	//   471: goto -> 419
	//   474: astore_3
	//   475: aload_0
	//   476: iconst_0
	//   477: putfield d : Z
	//   480: goto -> 386
	//   483: aload_2
	//   484: iload_1
	//   485: aaload
	//   486: iconst_0
	//   487: putfield t : Z
	//   490: aload_2
	//   491: iload_1
	//   492: aaload
	//   493: aload_2
	//   494: iload_1
	//   495: aaload
	//   496: invokevirtual a : ()[B
	//   499: invokevirtual a : ([B)V
	//   502: goto -> 468
	//   505: astore_3
	//   506: aload_0
	//   507: iconst_0
	//   508: putfield d : Z
	//   511: aload_2
	//   512: arraylength
	//   513: iconst_1
	//   514: isub
	//   515: istore_1
	//   516: iload_1
	//   517: iflt -> 562
	//   520: aload_2
	//   521: iload_1
	//   522: aaload
	//   523: invokestatic c : (Lam;)V
	//   526: iinc #1, -1
	//   529: goto -> 516
	//   532: aload_3
	//   533: invokevirtual size : ()I
	//   536: ifle -> 511
	//   539: aload_0
	//   540: aload_3
	//   541: iconst_0
	//   542: anewarray am
	//   545: invokevirtual toArray : ([Ljava/lang/Object;)[Ljava/lang/Object;
	//   548: checkcast [Lam;
	//   551: invokespecial a : ([Lam;)[Lam;
	//   554: pop
	//   555: goto -> 511
	//   558: astore_3
	//   559: goto -> 511
	//   562: invokestatic i : ()Laq;
	//   565: invokevirtual h : ()V
	//   568: aload_0
	//   569: getfield u : Z
	//   572: ifeq -> 594
	//   575: aload_0
	//   576: getfield c : Z
	//   579: ifne -> 594
	//   582: aload_0
	//   583: invokevirtual deleteCache : ()V
	//   586: aload_0
	//   587: invokespecial h : ()V
	//   590: aload_0
	//   591: invokevirtual f : ()V
	//   594: aload_0
	//   595: getfield b : Z
	//   598: ifne -> 661
	//   601: aload_0
	//   602: getfield c : Z
	//   605: ifne -> 661
	//   608: aload_0
	//   609: getfield j : Ljava/lang/Object;
	//   612: astore_2
	//   613: aload_2
	//   614: monitorenter
	//   615: aload_0
	//   616: getfield o : Z
	//   619: ifne -> 650
	//   622: aload_0
	//   623: getfield u : Z
	//   626: istore #7
	//   628: iload #7
	//   630: ifne -> 650
	//   633: aload_0
	//   634: getfield j : Ljava/lang/Object;
	//   637: invokevirtual wait : ()V
	//   640: aload_0
	//   641: iconst_0
	//   642: putfield o : Z
	//   645: aload_2
	//   646: monitorexit
	//   647: goto -> 105
	//   650: invokestatic yield : ()V
	//   653: goto -> 640
	//   656: astore_3
	//   657: aload_2
	//   658: monitorexit
	//   659: aload_3
	//   660: athrow
	//   661: goto -> 105
	//   664: aload_0
	//   665: getfield l : Ljava/util/ArrayList;
	//   668: ifnull -> 678
	//   671: aload_0
	//   672: getfield l : Ljava/util/ArrayList;
	//   675: invokevirtual clear : ()V
	//   678: aload_0
	//   679: aconst_null
	//   680: putfield k : Ljava/lang/Thread;
	//   683: aconst_null
	//   684: putstatic a.e : Ljava/lang/ref/WeakReference;
	//   687: aload_0
	//   688: iconst_1
	//   689: putfield b : Z
	//   692: aload_0
	//   693: iconst_0
	//   694: putfield c : Z
	//   697: aload_0
	//   698: invokespecial i : ()V
	//   701: invokestatic unregisterCurrentThread : ()I
	//   704: pop
	//   705: ldc_w 'file cache'
	//   708: ldc_w 'DESTROYED!!!'
	//   711: invokestatic w : (Ljava/lang/String;Ljava/lang/String;)I
	//   714: pop
	//   715: goto -> 301
	//   718: astore_3
	//   719: goto -> 640
	//   722: goto -> 391
	//   725: aconst_null
	//   726: astore_2
	//   727: aconst_null
	//   728: astore_3
	//   729: goto -> 208
	// Exception table:
	//   from	to	target	type
	//   4	8	268	java/lang/Throwable
	//   10	72	268	java/lang/Throwable
	//   78	100	268	java/lang/Throwable
	//   128	161	374	finally
	//   167	174	374	finally
	//   174	206	374	finally
	//   208	211	374	finally
	//   222	262	380	java/lang/Exception
	//   222	262	474	java/lang/Error
	//   307	319	374	finally
	//   329	344	374	finally
	//   348	369	374	finally
	//   402	417	505	java/lang/Exception
	//   402	417	558	java/lang/Error
	//   419	444	505	java/lang/Exception
	//   419	444	558	java/lang/Error
	//   444	468	505	java/lang/Exception
	//   444	468	558	java/lang/Error
	//   483	502	505	java/lang/Exception
	//   483	502	558	java/lang/Error
	//   532	555	505	java/lang/Exception
	//   532	555	558	java/lang/Error
	//   615	628	656	finally
	//   633	640	718	java/lang/InterruptedException
	//   633	640	656	finally
	//   640	647	656	finally
	//   650	653	656	finally
  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
  [DllImport("unknown")]
  public extern void writeTile(int paramInt1, int paramInt2, int paramInt3, int paramInt4, sbyte[] paramArrayOfbyte);
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\a.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */