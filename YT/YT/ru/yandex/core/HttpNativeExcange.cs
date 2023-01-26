using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ru.yandex.core
{
	using Header = org.apache.http.Header;
	using BasicHeader = org.apache.http.message.BasicHeader;

	public class HttpNativeExcange : Comparable, ThreadStart
	{
	  private const int CHUNK_SIZE = 16384;

	  private sbyte[] body;

	  private long creatioTime;

	  private Header[] headers;

	  private volatile bool isCancelled = false;

	  private long jniHandle;

	  private string method;

	  private int priority;

	  private int timeout;

	  private URI uri;

	  internal static string[][] convertHeadersToJni(System.Collections.IDictionary paramMap)
	  {
		string[] arrayOfString1 = new string[paramMap.Count];
		string[] arrayOfString2 = new string[paramMap.Count];
		IEnumerator<DictionaryEntry> iterator = paramMap.SetOfKeyValuePairs().GetEnumerator();
		for (sbyte b = 0; iterator.MoveNext(); b++)
		{
		  DictionaryEntry entry = iterator.Current;
		  arrayOfString1[b] = (string)entry.Key;
		  if (string.ReferenceEquals(arrayOfString1[b], null))
		  {
			arrayOfString1[b] = "";
		  }
		  if (((System.Collections.IList)entry.Value).Count > 0)
		  {
			IList<string> list = (System.Collections.IList)entry.Value;
			if (list.Count == 1)
			{
			  arrayOfString2[b] = list[0];
			}
			else
			{
			  IEnumerator<string> iterator1 = list.GetEnumerator();
			  StringBuilder stringBuilder = new StringBuilder();
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
			  stringBuilder.Append(iterator1.next());
			  while (!iterator1.MoveNext())
			  {
				stringBuilder.Append("; ");
				stringBuilder.Append(iterator1.Current);
			  }
			  arrayOfString2[b] = stringBuilder.ToString();
			}
		  }
		  else
		  {
			arrayOfString2[b] = "";
		  }
		}
		return new string[][] {arrayOfString1, arrayOfString2};
	  }

	  public static HttpNativeExcange create(long paramLong1, long paramLong2, int paramInt1, int paramInt2, string paramString1, string paramString2, sbyte[] paramArrayOfbyte, string[] paramArrayOfString1, string[] paramArrayOfString2, string[] paramArrayOfString3, string[] paramArrayOfString4)
	  {
		HttpNativeExcange httpNativeExcange = new HttpNativeExcange();
		httpNativeExcange.jniHandle = paramLong1;
		httpNativeExcange.creatioTime = paramLong2;
		httpNativeExcange.priority = paramInt1;
		httpNativeExcange.timeout = paramInt2;
		httpNativeExcange.method = paramString1;
		try
		{
		  httpNativeExcange.uri = getURI(paramString2, paramArrayOfString1, paramArrayOfString2);
		  httpNativeExcange.body = paramArrayOfbyte;
		  httpNativeExcange.headers = new Header[paramArrayOfString3.Length];
		  for (paramInt1 = 0; paramInt1 < paramArrayOfString3.Length; paramInt1++)
		  {
			httpNativeExcange.headers[paramInt1] = (Header)new BasicHeader(paramArrayOfString3[paramInt1], paramArrayOfString4[paramInt1]);
		  }
		}
		catch (URISyntaxException)
		{
		  throw new Exception("Invalid url:" + paramString2);
		}
		return httpNativeExcange;
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void didFinish(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void didReceiveBodyData(long paramLong, sbyte[] paramArrayOfbyte, int paramInt1, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void didReceiveResponse(long paramLong1, int paramInt, long paramLong2, string[] paramArrayOfString1, string[] paramArrayOfString2);

	  private static URI getURI(string paramString, string[] paramArrayOfString1, string[] paramArrayOfString2)
	  {
		URI uRI = new URI(paramString);
		if (paramArrayOfString1.Length != 0)
		{
		  string str2 = uRI.getScheme();
		  string str3 = uRI.getUserInfo();
		  string str4 = uRI.getHost();
		  int i = uRI.getPort();
		  string str5 = uRI.getPath();
		  string str6 = uRI.getQuery();
		  string str1 = uRI.getFragment();
		  StringBuilder stringBuilder2 = new StringBuilder();
		  if (!string.ReferenceEquals(str6, null))
		  {
			stringBuilder2.Append(str6);
		  }
		  for (sbyte b = 0; b < paramArrayOfString1.Length; b++)
		  {
			if (b != 0 || !string.ReferenceEquals(str6, null))
			{
			  stringBuilder2.Append('&');
			}
			stringBuilder2.Append(paramArrayOfString1[b]);
			stringBuilder2.Append('=');
			stringBuilder2.Append(paramArrayOfString2[b]);
		  }
		  StringBuilder stringBuilder1 = new StringBuilder();
		  if (!string.ReferenceEquals(str2, null))
		  {
			stringBuilder1.Append(str2);
			stringBuilder1.Append("://");
		  }
		  if (!string.ReferenceEquals(str3, null))
		  {
			stringBuilder1.Append(str3);
			stringBuilder1.Append('@');
		  }
		  if (!string.ReferenceEquals(str4, null))
		  {
			stringBuilder1.Append(str4);
		  }
		  if (i != -1)
		  {
			stringBuilder1.Append(':');
			stringBuilder1.Append(i);
		  }
		  if (!string.ReferenceEquals(str5, null))
		  {
			stringBuilder1.Append(str5);
		  }
		  if (stringBuilder2.Length > 0)
		  {
			stringBuilder1.Append('?');
			stringBuilder1.Append(stringBuilder2.ToString());
		  }
		  if (!string.ReferenceEquals(str1, null))
		  {
			stringBuilder1.Append('#');
			stringBuilder1.Append(str1);
		  }
		  uRI = new URI(stringBuilder1.ToString());
		}
		return uRI;
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void releaseNative(long paramLong);

	  public virtual void cancel()
	  {
		this.isCancelled = true;
	  }

	  public virtual int CompareTo(HttpNativeExcange paramHttpNativeExcange)
	  {
		return (this.priority != paramHttpNativeExcange.priority) ? (paramHttpNativeExcange.priority - this.priority) : ((this.creatioTime < paramHttpNativeExcange.creatioTime) ? -1 : 1);
	  }

	  internal virtual void didFinish(int paramInt)
	  {
		if (!this.isCancelled)
		{
		  didFinish(this.jniHandle, paramInt);
		}
	  }

	  internal virtual void didReceiveBodyData(sbyte[] paramArrayOfbyte, int paramInt1, int paramInt2)
	  {
		if (!this.isCancelled)
		{
		  didReceiveBodyData(this.jniHandle, paramArrayOfbyte, paramInt1, paramInt2);
		}
	  }

	  internal virtual void didReceiveResponse(int paramInt, long paramLong, System.Collections.IDictionary paramMap)
	  {
		if (!this.isCancelled)
		{
		  string[][] arrayOfString = convertHeadersToJni(paramMap);
		  string[] arrayOfString1 = arrayOfString[0];
		  string[] arrayOfString2 = arrayOfString[1];
		  didReceiveResponse(this.jniHandle, paramInt, paramLong, arrayOfString1, arrayOfString2);
		}
	  }

	  ~HttpNativeExcange()
	  {
		releaseNative(this.jniHandle);
//JAVA TO C# CONVERTER NOTE: The base class finalizer method is automatically called in C#:
//		base.finalize();
	  }

	  public virtual void run()
	  {
		// Byte code:
		//   0: aconst_null
		//   1: astore_1
		//   2: aconst_null
		//   3: astore_2
		//   4: aconst_null
		//   5: astore_3
		//   6: aload_0
		//   7: getfield isCancelled : Z
		//   10: ifeq -> 14
		//   13: return
		//   14: new java/net/URL
		//   17: astore #4
		//   19: aload #4
		//   21: aload_0
		//   22: getfield uri : Ljava/net/URI;
		//   25: invokevirtual toASCIIString : ()Ljava/lang/String;
		//   28: invokespecial <init> : (Ljava/lang/String;)V
		//   31: aload #4
		//   33: invokevirtual openConnection : ()Ljava/net/URLConnection;
		//   36: checkcast java/net/HttpURLConnection
		//   39: astore #4
		//   41: aload #4
		//   43: iconst_0
		//   44: invokevirtual setAllowUserInteraction : (Z)V
		//   47: aload #4
		//   49: aload_0
		//   50: getfield method : Ljava/lang/String;
		//   53: invokevirtual setRequestMethod : (Ljava/lang/String;)V
		//   56: aload #4
		//   58: aload_0
		//   59: getfield timeout : I
		//   62: invokevirtual setConnectTimeout : (I)V
		//   65: aload #4
		//   67: aload_0
		//   68: getfield timeout : I
		//   71: invokevirtual setReadTimeout : (I)V
		//   74: aload_0
		//   75: getfield headers : [Lorg/apache/http/Header;
		//   78: astore #5
		//   80: aload #5
		//   82: arraylength
		//   83: istore #6
		//   85: iconst_0
		//   86: istore #7
		//   88: iload #7
		//   90: iload #6
		//   92: if_icmpge -> 127
		//   95: aload #5
		//   97: iload #7
		//   99: aaload
		//   100: astore #8
		//   102: aload #4
		//   104: aload #8
		//   106: invokeinterface getName : ()Ljava/lang/String;
		//   111: aload #8
		//   113: invokeinterface getValue : ()Ljava/lang/String;
		//   118: invokevirtual setRequestProperty : (Ljava/lang/String;Ljava/lang/String;)V
		//   121: iinc #7, 1
		//   124: goto -> 88
		//   127: aload_0
		//   128: getfield isCancelled : Z
		//   131: istore #9
		//   133: iload #9
		//   135: ifeq -> 156
		//   138: aload #4
		//   140: ifnull -> 148
		//   143: aload #4
		//   145: invokevirtual disconnect : ()V
		//   148: aload_0
		//   149: iconst_m1
		//   150: invokevirtual didFinish : (I)V
		//   153: goto -> 13
		//   156: aload #4
		//   158: iconst_1
		//   159: invokevirtual setDoInput : (Z)V
		//   162: aload_0
		//   163: getfield body : [B
		//   166: arraylength
		//   167: ifle -> 186
		//   170: aload #4
		//   172: iconst_1
		//   173: invokevirtual setDoOutput : (Z)V
		//   176: aload #4
		//   178: aload_0
		//   179: getfield body : [B
		//   182: arraylength
		//   183: invokevirtual setFixedLengthStreamingMode : (I)V
		//   186: aload #4
		//   188: invokevirtual connect : ()V
		//   191: aload_0
		//   192: getfield body : [B
		//   195: arraylength
		//   196: ifle -> 225
		//   199: aload #4
		//   201: invokevirtual getOutputStream : ()Ljava/io/OutputStream;
		//   204: astore #5
		//   206: aload #5
		//   208: aload_0
		//   209: getfield body : [B
		//   212: invokevirtual write : ([B)V
		//   215: aload #5
		//   217: invokevirtual flush : ()V
		//   220: aload #5
		//   222: invokevirtual close : ()V
		//   225: aload_0
		//   226: getfield isCancelled : Z
		//   229: istore #9
		//   231: iload #9
		//   233: ifeq -> 254
		//   236: aload #4
		//   238: ifnull -> 246
		//   241: aload #4
		//   243: invokevirtual disconnect : ()V
		//   246: aload_0
		//   247: iconst_m1
		//   248: invokevirtual didFinish : (I)V
		//   251: goto -> 13
		//   254: aload_0
		//   255: aload #4
		//   257: invokevirtual getResponseCode : ()I
		//   260: aload #4
		//   262: invokevirtual getContentLength : ()I
		//   265: i2l
		//   266: aload #4
		//   268: invokevirtual getHeaderFields : ()Ljava/util/Map;
		//   271: invokevirtual didReceiveResponse : (IJLjava/util/Map;)V
		//   274: aload #4
		//   276: invokevirtual getInputStream : ()Ljava/io/InputStream;
		//   279: astore #5
		//   281: aload_0
		//   282: getfield isCancelled : Z
		//   285: istore #9
		//   287: iload #9
		//   289: ifeq -> 335
		//   292: aload #5
		//   294: ifnull -> 302
		//   297: aload #5
		//   299: invokevirtual close : ()V
		//   302: aload #4
		//   304: ifnull -> 312
		//   307: aload #4
		//   309: invokevirtual disconnect : ()V
		//   312: aload_0
		//   313: iconst_m1
		//   314: invokevirtual didFinish : (I)V
		//   317: goto -> 13
		//   320: astore #5
		//   322: ldc_w 'HttpNativeExcange'
		//   325: ldc_w 'in.close error'
		//   328: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   331: pop
		//   332: goto -> 302
		//   335: sipush #16384
		//   338: newarray byte
		//   340: astore #8
		//   342: aload_0
		//   343: getfield isCancelled : Z
		//   346: istore #9
		//   348: iload #9
		//   350: ifeq -> 396
		//   353: aload #5
		//   355: ifnull -> 363
		//   358: aload #5
		//   360: invokevirtual close : ()V
		//   363: aload #4
		//   365: ifnull -> 373
		//   368: aload #4
		//   370: invokevirtual disconnect : ()V
		//   373: aload_0
		//   374: iconst_m1
		//   375: invokevirtual didFinish : (I)V
		//   378: goto -> 13
		//   381: astore #5
		//   383: ldc_w 'HttpNativeExcange'
		//   386: ldc_w 'in.close error'
		//   389: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   392: pop
		//   393: goto -> 363
		//   396: aload #5
		//   398: aload #8
		//   400: iconst_0
		//   401: sipush #16384
		//   404: invokevirtual read : ([BII)I
		//   407: istore #7
		//   409: iload #7
		//   411: iflt -> 513
		//   414: aload_0
		//   415: aload #8
		//   417: iconst_0
		//   418: iload #7
		//   420: invokevirtual didReceiveBodyData : ([BII)V
		//   423: goto -> 342
		//   426: astore #8
		//   428: aload #4
		//   430: astore #8
		//   432: aload #5
		//   434: astore #4
		//   436: aload #8
		//   438: astore #5
		//   440: aload_3
		//   441: astore #8
		//   443: new java/lang/StringBuilder
		//   446: astore_1
		//   447: aload_1
		//   448: invokespecial <init> : ()V
		//   451: ldc_w 'HttpNativeExcange'
		//   454: aload_1
		//   455: ldc_w 'MalformedURLException: '
		//   458: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   461: aload_0
		//   462: getfield uri : Ljava/net/URI;
		//   465: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   468: invokevirtual toString : ()Ljava/lang/String;
		//   471: invokestatic e : (Ljava/lang/String;Ljava/lang/String;)I
		//   474: pop
		//   475: aload #8
		//   477: ifnull -> 485
		//   480: aload #8
		//   482: invokevirtual close : ()V
		//   485: aload #4
		//   487: ifnull -> 495
		//   490: aload #4
		//   492: invokevirtual close : ()V
		//   495: aload #5
		//   497: ifnull -> 505
		//   500: aload #5
		//   502: invokevirtual disconnect : ()V
		//   505: aload_0
		//   506: iconst_m1
		//   507: invokevirtual didFinish : (I)V
		//   510: goto -> 13
		//   513: aload #5
		//   515: ifnull -> 523
		//   518: aload #5
		//   520: invokevirtual close : ()V
		//   523: aload #4
		//   525: ifnull -> 533
		//   528: aload #4
		//   530: invokevirtual disconnect : ()V
		//   533: aload_0
		//   534: iconst_0
		//   535: invokevirtual didFinish : (I)V
		//   538: goto -> 13
		//   541: astore #5
		//   543: ldc_w 'HttpNativeExcange'
		//   546: ldc_w 'in.close error'
		//   549: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   552: pop
		//   553: goto -> 523
		//   556: astore #8
		//   558: ldc_w 'HttpNativeExcange'
		//   561: ldc_w 'out.close error'
		//   564: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   567: pop
		//   568: goto -> 485
		//   571: astore #4
		//   573: ldc_w 'HttpNativeExcange'
		//   576: ldc_w 'in.close error'
		//   579: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   582: pop
		//   583: goto -> 495
		//   586: astore #4
		//   588: aconst_null
		//   589: astore #5
		//   591: aconst_null
		//   592: astore #8
		//   594: new java/lang/StringBuilder
		//   597: astore_2
		//   598: aload_2
		//   599: invokespecial <init> : ()V
		//   602: ldc_w 'HttpNativeExcange'
		//   605: aload_2
		//   606: aload #4
		//   608: invokevirtual getClass : ()Ljava/lang/Class;
		//   611: invokevirtual toString : ()Ljava/lang/String;
		//   614: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   617: ldc_w ' '
		//   620: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   623: aload #4
		//   625: invokevirtual getMessage : ()Ljava/lang/String;
		//   628: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   631: ldc_w ' on: '
		//   634: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   637: aload_0
		//   638: getfield uri : Ljava/net/URI;
		//   641: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   644: invokevirtual toString : ()Ljava/lang/String;
		//   647: invokestatic e : (Ljava/lang/String;Ljava/lang/String;)I
		//   650: pop
		//   651: aload #5
		//   653: ifnull -> 661
		//   656: aload #5
		//   658: invokevirtual close : ()V
		//   661: aload_1
		//   662: ifnull -> 669
		//   665: aload_1
		//   666: invokevirtual close : ()V
		//   669: aload #8
		//   671: ifnull -> 679
		//   674: aload #8
		//   676: invokevirtual disconnect : ()V
		//   679: aload_0
		//   680: iconst_m1
		//   681: invokevirtual didFinish : (I)V
		//   684: goto -> 13
		//   687: astore #4
		//   689: ldc_w 'HttpNativeExcange'
		//   692: ldc_w 'out.close error'
		//   695: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   698: pop
		//   699: goto -> 661
		//   702: astore #4
		//   704: ldc_w 'HttpNativeExcange'
		//   707: ldc_w 'in.close error'
		//   710: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   713: pop
		//   714: goto -> 669
		//   717: astore #4
		//   719: aconst_null
		//   720: astore #5
		//   722: aconst_null
		//   723: astore #8
		//   725: aload_2
		//   726: astore_1
		//   727: aload #5
		//   729: ifnull -> 737
		//   732: aload #5
		//   734: invokevirtual close : ()V
		//   737: aload_1
		//   738: ifnull -> 745
		//   741: aload_1
		//   742: invokevirtual close : ()V
		//   745: aload #8
		//   747: ifnull -> 755
		//   750: aload #8
		//   752: invokevirtual disconnect : ()V
		//   755: aload_0
		//   756: iconst_m1
		//   757: invokevirtual didFinish : (I)V
		//   760: aload #4
		//   762: athrow
		//   763: astore #5
		//   765: ldc_w 'HttpNativeExcange'
		//   768: ldc_w 'out.close error'
		//   771: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   774: pop
		//   775: goto -> 737
		//   778: astore #5
		//   780: ldc_w 'HttpNativeExcange'
		//   783: ldc_w 'in.close error'
		//   786: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   789: pop
		//   790: goto -> 745
		//   793: astore #5
		//   795: aload #4
		//   797: astore #8
		//   799: aload #5
		//   801: astore #4
		//   803: aconst_null
		//   804: astore #5
		//   806: aload_2
		//   807: astore_1
		//   808: goto -> 727
		//   811: astore_1
		//   812: aload #4
		//   814: astore #8
		//   816: aload_1
		//   817: astore #4
		//   819: aload_2
		//   820: astore_1
		//   821: goto -> 727
		//   824: astore_1
		//   825: aload #4
		//   827: astore #8
		//   829: aload_1
		//   830: astore #4
		//   832: aconst_null
		//   833: astore_2
		//   834: aload #5
		//   836: astore_1
		//   837: aload_2
		//   838: astore #5
		//   840: goto -> 727
		//   843: astore_3
		//   844: aload #5
		//   846: astore_2
		//   847: aload #8
		//   849: astore #5
		//   851: aload #4
		//   853: astore_1
		//   854: aload_3
		//   855: astore #4
		//   857: aload_2
		//   858: astore #8
		//   860: goto -> 727
		//   863: astore #4
		//   865: goto -> 727
		//   868: astore #5
		//   870: aload #4
		//   872: astore #8
		//   874: aload #5
		//   876: astore #4
		//   878: aconst_null
		//   879: astore #5
		//   881: goto -> 594
		//   884: astore_2
		//   885: aload #4
		//   887: astore #8
		//   889: aload_2
		//   890: astore #4
		//   892: goto -> 594
		//   895: astore_1
		//   896: aload #4
		//   898: astore #8
		//   900: aload_1
		//   901: astore #4
		//   903: aconst_null
		//   904: astore_2
		//   905: aload #5
		//   907: astore_1
		//   908: aload_2
		//   909: astore #5
		//   911: goto -> 594
		//   914: astore #4
		//   916: aconst_null
		//   917: astore #4
		//   919: aconst_null
		//   920: astore #5
		//   922: aload_3
		//   923: astore #8
		//   925: goto -> 443
		//   928: astore #5
		//   930: aload #4
		//   932: astore #5
		//   934: aconst_null
		//   935: astore #4
		//   937: aload_3
		//   938: astore #8
		//   940: goto -> 443
		//   943: astore #8
		//   945: aload #4
		//   947: astore_1
		//   948: aconst_null
		//   949: astore #4
		//   951: aload #5
		//   953: astore #8
		//   955: aload_1
		//   956: astore #5
		//   958: goto -> 443
		// Exception table:
		//   from	to	target	type
		//   14	41	914	java/net/MalformedURLException
		//   14	41	586	java/io/IOException
		//   14	41	717	finally
		//   41	85	928	java/net/MalformedURLException
		//   41	85	868	java/io/IOException
		//   41	85	793	finally
		//   102	121	928	java/net/MalformedURLException
		//   102	121	868	java/io/IOException
		//   102	121	793	finally
		//   127	133	928	java/net/MalformedURLException
		//   127	133	868	java/io/IOException
		//   127	133	793	finally
		//   156	186	928	java/net/MalformedURLException
		//   156	186	868	java/io/IOException
		//   156	186	793	finally
		//   186	206	928	java/net/MalformedURLException
		//   186	206	868	java/io/IOException
		//   186	206	793	finally
		//   206	225	943	java/net/MalformedURLException
		//   206	225	884	java/io/IOException
		//   206	225	811	finally
		//   225	231	928	java/net/MalformedURLException
		//   225	231	868	java/io/IOException
		//   225	231	793	finally
		//   254	281	928	java/net/MalformedURLException
		//   254	281	868	java/io/IOException
		//   254	281	793	finally
		//   281	287	426	java/net/MalformedURLException
		//   281	287	895	java/io/IOException
		//   281	287	824	finally
		//   297	302	320	java/io/IOException
		//   335	342	426	java/net/MalformedURLException
		//   335	342	895	java/io/IOException
		//   335	342	824	finally
		//   342	348	426	java/net/MalformedURLException
		//   342	348	895	java/io/IOException
		//   342	348	824	finally
		//   358	363	381	java/io/IOException
		//   396	409	426	java/net/MalformedURLException
		//   396	409	895	java/io/IOException
		//   396	409	824	finally
		//   414	423	426	java/net/MalformedURLException
		//   414	423	895	java/io/IOException
		//   414	423	824	finally
		//   443	475	843	finally
		//   480	485	556	java/io/IOException
		//   490	495	571	java/io/IOException
		//   518	523	541	java/io/IOException
		//   594	651	863	finally
		//   656	661	687	java/io/IOException
		//   665	669	702	java/io/IOException
		//   732	737	763	java/io/IOException
		//   741	745	778	java/io/IOException
	  }

	  public virtual HttpNativeExcange$SyncResponseHolder sendSynchronousRequest()
	  {
		// Byte code:
		//   0: aconst_null
		//   1: astore_1
		//   2: aconst_null
		//   3: astore_2
		//   4: aconst_null
		//   5: astore_3
		//   6: new ru/yandex/core/HttpNativeExcange$SyncResponseHolder
		//   9: dup
		//   10: invokespecial <init> : ()V
		//   13: astore #4
		//   15: new java/net/URL
		//   18: astore #5
		//   20: aload #5
		//   22: aload_0
		//   23: getfield uri : Ljava/net/URI;
		//   26: invokevirtual toASCIIString : ()Ljava/lang/String;
		//   29: invokespecial <init> : (Ljava/lang/String;)V
		//   32: aload #5
		//   34: invokevirtual openConnection : ()Ljava/net/URLConnection;
		//   37: checkcast java/net/HttpURLConnection
		//   40: astore #5
		//   42: aload #5
		//   44: iconst_0
		//   45: invokevirtual setAllowUserInteraction : (Z)V
		//   48: aload #5
		//   50: aload_0
		//   51: getfield method : Ljava/lang/String;
		//   54: invokevirtual setRequestMethod : (Ljava/lang/String;)V
		//   57: aload #5
		//   59: aload_0
		//   60: getfield timeout : I
		//   63: invokevirtual setConnectTimeout : (I)V
		//   66: aload #5
		//   68: aload_0
		//   69: getfield timeout : I
		//   72: invokevirtual setReadTimeout : (I)V
		//   75: aload_0
		//   76: getfield headers : [Lorg/apache/http/Header;
		//   79: astore #6
		//   81: aload #6
		//   83: arraylength
		//   84: istore #7
		//   86: iconst_0
		//   87: istore #8
		//   89: iload #8
		//   91: iload #7
		//   93: if_icmpge -> 128
		//   96: aload #6
		//   98: iload #8
		//   100: aaload
		//   101: astore #9
		//   103: aload #5
		//   105: aload #9
		//   107: invokeinterface getName : ()Ljava/lang/String;
		//   112: aload #9
		//   114: invokeinterface getValue : ()Ljava/lang/String;
		//   119: invokevirtual setRequestProperty : (Ljava/lang/String;Ljava/lang/String;)V
		//   122: iinc #8, 1
		//   125: goto -> 89
		//   128: aload #5
		//   130: iconst_1
		//   131: invokevirtual setDoInput : (Z)V
		//   134: aload_0
		//   135: getfield body : [B
		//   138: arraylength
		//   139: ifle -> 158
		//   142: aload #5
		//   144: iconst_1
		//   145: invokevirtual setDoOutput : (Z)V
		//   148: aload #5
		//   150: aload_0
		//   151: getfield body : [B
		//   154: arraylength
		//   155: invokevirtual setFixedLengthStreamingMode : (I)V
		//   158: aload #5
		//   160: invokevirtual connect : ()V
		//   163: aload_0
		//   164: getfield body : [B
		//   167: arraylength
		//   168: ifle -> 197
		//   171: aload #5
		//   173: invokevirtual getOutputStream : ()Ljava/io/OutputStream;
		//   176: astore #9
		//   178: aload #9
		//   180: aload_0
		//   181: getfield body : [B
		//   184: invokevirtual write : ([B)V
		//   187: aload #9
		//   189: invokevirtual flush : ()V
		//   192: aload #9
		//   194: invokevirtual close : ()V
		//   197: aload #5
		//   199: invokevirtual getHeaderFields : ()Ljava/util/Map;
		//   202: invokestatic convertHeadersToJni : (Ljava/util/Map;)[[Ljava/lang/String;
		//   205: astore #6
		//   207: aload #4
		//   209: aload #6
		//   211: iconst_0
		//   212: aaload
		//   213: putfield headerKeys : [Ljava/lang/String;
		//   216: aload #4
		//   218: aload #6
		//   220: iconst_1
		//   221: aaload
		//   222: putfield headerValues : [Ljava/lang/String;
		//   225: aload #4
		//   227: aload #5
		//   229: invokevirtual getResponseCode : ()I
		//   232: putfield statusCode : I
		//   235: aload #4
		//   237: aload #5
		//   239: invokevirtual getContentLength : ()I
		//   242: putfield contentLength : I
		//   245: aload #5
		//   247: invokevirtual getInputStream : ()Ljava/io/InputStream;
		//   250: astore #6
		//   252: new h
		//   255: astore #9
		//   257: aload #9
		//   259: sipush #16384
		//   262: invokespecial <init> : (I)V
		//   265: sipush #16384
		//   268: newarray byte
		//   270: astore_1
		//   271: aload #6
		//   273: aload_1
		//   274: iconst_0
		//   275: sipush #16384
		//   278: invokevirtual read : ([BII)I
		//   281: istore #8
		//   283: iload #8
		//   285: iflt -> 390
		//   288: aload #9
		//   290: aload_1
		//   291: iconst_0
		//   292: iload #8
		//   294: invokevirtual a : ([BII)V
		//   297: goto -> 271
		//   300: astore #9
		//   302: aload #5
		//   304: astore_1
		//   305: aload #6
		//   307: astore #5
		//   309: aload_3
		//   310: astore #9
		//   312: aload_1
		//   313: astore #6
		//   315: new java/lang/StringBuilder
		//   318: astore_1
		//   319: aload_1
		//   320: invokespecial <init> : ()V
		//   323: ldc_w 'HttpNativeExcange'
		//   326: aload_1
		//   327: ldc_w 'MalformedURLException: '
		//   330: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   333: aload_0
		//   334: getfield uri : Ljava/net/URI;
		//   337: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   340: invokevirtual toString : ()Ljava/lang/String;
		//   343: invokestatic e : (Ljava/lang/String;Ljava/lang/String;)I
		//   346: pop
		//   347: aload #9
		//   349: ifnull -> 357
		//   352: aload #9
		//   354: invokevirtual close : ()V
		//   357: aload #5
		//   359: ifnull -> 367
		//   362: aload #5
		//   364: invokevirtual close : ()V
		//   367: aload #6
		//   369: ifnull -> 827
		//   372: aload #6
		//   374: invokevirtual disconnect : ()V
		//   377: iconst_m1
		//   378: istore #8
		//   380: aload #4
		//   382: iload #8
		//   384: putfield errorCode : I
		//   387: aload #4
		//   389: areturn
		//   390: aload #4
		//   392: aload #9
		//   394: invokevirtual a : ()[B
		//   397: putfield data : [B
		//   400: aload #6
		//   402: ifnull -> 410
		//   405: aload #6
		//   407: invokevirtual close : ()V
		//   410: aload #5
		//   412: ifnull -> 833
		//   415: aload #5
		//   417: invokevirtual disconnect : ()V
		//   420: iconst_0
		//   421: istore #8
		//   423: goto -> 380
		//   426: astore #6
		//   428: ldc_w 'HttpNativeExcange'
		//   431: ldc_w 'in.close error'
		//   434: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   437: pop
		//   438: goto -> 410
		//   441: astore #9
		//   443: ldc_w 'HttpNativeExcange'
		//   446: ldc_w 'out.close error'
		//   449: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   452: pop
		//   453: goto -> 357
		//   456: astore #5
		//   458: ldc_w 'HttpNativeExcange'
		//   461: ldc_w 'in.close error'
		//   464: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   467: pop
		//   468: goto -> 367
		//   471: astore #5
		//   473: aconst_null
		//   474: astore #9
		//   476: aconst_null
		//   477: astore #6
		//   479: new java/lang/StringBuilder
		//   482: astore_2
		//   483: aload_2
		//   484: invokespecial <init> : ()V
		//   487: ldc_w 'HttpNativeExcange'
		//   490: aload_2
		//   491: aload #5
		//   493: invokevirtual getClass : ()Ljava/lang/Class;
		//   496: invokevirtual toString : ()Ljava/lang/String;
		//   499: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   502: ldc_w ' '
		//   505: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   508: aload #5
		//   510: invokevirtual getMessage : ()Ljava/lang/String;
		//   513: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   516: ldc_w ' on: '
		//   519: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   522: aload_0
		//   523: getfield uri : Ljava/net/URI;
		//   526: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   529: invokevirtual toString : ()Ljava/lang/String;
		//   532: invokestatic e : (Ljava/lang/String;Ljava/lang/String;)I
		//   535: pop
		//   536: aload #9
		//   538: ifnull -> 546
		//   541: aload #9
		//   543: invokevirtual close : ()V
		//   546: aload_1
		//   547: ifnull -> 554
		//   550: aload_1
		//   551: invokevirtual close : ()V
		//   554: aload #6
		//   556: ifnull -> 827
		//   559: aload #6
		//   561: invokevirtual disconnect : ()V
		//   564: iconst_m1
		//   565: istore #8
		//   567: goto -> 380
		//   570: astore #5
		//   572: ldc_w 'HttpNativeExcange'
		//   575: ldc_w 'out.close error'
		//   578: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   581: pop
		//   582: goto -> 546
		//   585: astore #5
		//   587: ldc_w 'HttpNativeExcange'
		//   590: ldc_w 'in.close error'
		//   593: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   596: pop
		//   597: goto -> 554
		//   600: astore #5
		//   602: aconst_null
		//   603: astore #9
		//   605: aconst_null
		//   606: astore #6
		//   608: aload_2
		//   609: astore_1
		//   610: aload #9
		//   612: ifnull -> 620
		//   615: aload #9
		//   617: invokevirtual close : ()V
		//   620: aload_1
		//   621: ifnull -> 628
		//   624: aload_1
		//   625: invokevirtual close : ()V
		//   628: aload #6
		//   630: ifnull -> 638
		//   633: aload #6
		//   635: invokevirtual disconnect : ()V
		//   638: aload #5
		//   640: athrow
		//   641: astore #9
		//   643: ldc_w 'HttpNativeExcange'
		//   646: ldc_w 'out.close error'
		//   649: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   652: pop
		//   653: goto -> 620
		//   656: astore #9
		//   658: ldc_w 'HttpNativeExcange'
		//   661: ldc_w 'in.close error'
		//   664: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   667: pop
		//   668: goto -> 628
		//   671: astore_1
		//   672: aconst_null
		//   673: astore #9
		//   675: aload #5
		//   677: astore #6
		//   679: aload_1
		//   680: astore #5
		//   682: aload_2
		//   683: astore_1
		//   684: goto -> 610
		//   687: astore_1
		//   688: aload #5
		//   690: astore #6
		//   692: aload_1
		//   693: astore #5
		//   695: aload_2
		//   696: astore_1
		//   697: goto -> 610
		//   700: astore_1
		//   701: aload #5
		//   703: astore #9
		//   705: aload_1
		//   706: astore #5
		//   708: aload #6
		//   710: astore_1
		//   711: aconst_null
		//   712: astore_2
		//   713: aload #9
		//   715: astore #6
		//   717: aload_2
		//   718: astore #9
		//   720: goto -> 610
		//   723: astore_2
		//   724: aload #5
		//   726: astore_1
		//   727: aload_2
		//   728: astore #5
		//   730: goto -> 610
		//   733: astore #5
		//   735: goto -> 610
		//   738: astore_2
		//   739: aconst_null
		//   740: astore #9
		//   742: aload #5
		//   744: astore #6
		//   746: aload_2
		//   747: astore #5
		//   749: goto -> 479
		//   752: astore_2
		//   753: aload #5
		//   755: astore #6
		//   757: aload_2
		//   758: astore #5
		//   760: goto -> 479
		//   763: astore_1
		//   764: aload #5
		//   766: astore #9
		//   768: aload_1
		//   769: astore #5
		//   771: aload #6
		//   773: astore_1
		//   774: aconst_null
		//   775: astore_2
		//   776: aload #9
		//   778: astore #6
		//   780: aload_2
		//   781: astore #9
		//   783: goto -> 479
		//   786: astore #5
		//   788: aconst_null
		//   789: astore #5
		//   791: aconst_null
		//   792: astore #6
		//   794: aload_3
		//   795: astore #9
		//   797: goto -> 315
		//   800: astore #6
		//   802: aload #5
		//   804: astore #6
		//   806: aconst_null
		//   807: astore #5
		//   809: aload_3
		//   810: astore #9
		//   812: goto -> 315
		//   815: astore #6
		//   817: aload #5
		//   819: astore #6
		//   821: aconst_null
		//   822: astore #5
		//   824: goto -> 315
		//   827: iconst_m1
		//   828: istore #8
		//   830: goto -> 380
		//   833: iconst_0
		//   834: istore #8
		//   836: goto -> 380
		// Exception table:
		//   from	to	target	type
		//   15	42	786	java/net/MalformedURLException
		//   15	42	471	java/io/IOException
		//   15	42	600	finally
		//   42	86	800	java/net/MalformedURLException
		//   42	86	738	java/io/IOException
		//   42	86	671	finally
		//   103	122	800	java/net/MalformedURLException
		//   103	122	738	java/io/IOException
		//   103	122	671	finally
		//   128	158	800	java/net/MalformedURLException
		//   128	158	738	java/io/IOException
		//   128	158	671	finally
		//   158	178	800	java/net/MalformedURLException
		//   158	178	738	java/io/IOException
		//   158	178	671	finally
		//   178	197	815	java/net/MalformedURLException
		//   178	197	752	java/io/IOException
		//   178	197	687	finally
		//   197	252	800	java/net/MalformedURLException
		//   197	252	738	java/io/IOException
		//   197	252	671	finally
		//   252	271	300	java/net/MalformedURLException
		//   252	271	763	java/io/IOException
		//   252	271	700	finally
		//   271	283	300	java/net/MalformedURLException
		//   271	283	763	java/io/IOException
		//   271	283	700	finally
		//   288	297	300	java/net/MalformedURLException
		//   288	297	763	java/io/IOException
		//   288	297	700	finally
		//   315	347	723	finally
		//   352	357	441	java/io/IOException
		//   362	367	456	java/io/IOException
		//   390	400	300	java/net/MalformedURLException
		//   390	400	763	java/io/IOException
		//   390	400	700	finally
		//   405	410	426	java/io/IOException
		//   479	536	733	finally
		//   541	546	570	java/io/IOException
		//   550	554	585	java/io/IOException
		//   615	620	641	java/io/IOException
		//   624	628	656	java/io/IOException
	  }

	  public virtual void start()
	  {
		HttpEngine.start(this);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\HttpNativeExcange.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}