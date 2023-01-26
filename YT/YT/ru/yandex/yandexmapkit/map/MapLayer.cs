using System;
using System.IO;
using System.Text;

namespace ru.yandex.yandexmapkit.map
{
	using Log = android.util.Log;
	using XmlPullParser = org.xmlpull.v1.XmlPullParser;
	using XmlPullParserFactory = org.xmlpull.v1.XmlPullParserFactory;

	public class MapLayer
	{
	  public bool isAllowNightMode;

	  public bool isCustom;

	  public bool isService;

	  public int layerId;

	  public string name;

	  public string requestName;

	  public int sizeInPixels;

	  public int version;

	  public MapLayer(string paramString1, int paramInt1, string paramString2, int paramInt2, bool paramBoolean1, int paramInt3, bool paramBoolean2)
	  {
		this.requestName = paramString1;
		this.layerId = paramInt1;
		this.name = paramString2;
		this.version = paramInt2;
		this.isService = paramBoolean1;
		this.sizeInPixels = paramInt3;
		this.isAllowNightMode = paramBoolean2;
		this.isCustom = false;
	  }

	  public static string a(System.Collections.IList paramList)
	  {
		if (paramList == null || paramList.Count == 0)
		{
		  return null;
		}
		StringBuilder stringBuilder = new StringBuilder(100);
		stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		stringBuilder.Append("<map_layers>");
		foreach (MapLayer mapLayer in paramList)
		{
		  if (!mapLayer.isCustom)
		  {
			string str;
			bool @bool;
			stringBuilder.Append("<l request=\"").Append(mapLayer.requestName + "\" ");
			stringBuilder.Append("id=\"").Append(mapLayer.layerId + "\" ");
			stringBuilder.Append("name=\"").Append(mapLayer.name + "\" ");
			if (mapLayer.version >= 0)
			{
			  stringBuilder.Append("ver=\"").Append(mapLayer.version + "\" ");
			}
			StringBuilder stringBuilder1 = stringBuilder.Append("service=\"");
			StringBuilder stringBuilder2 = new StringBuilder();
			if (mapLayer.isService)
			{
			  @bool = true;
			}
			else
			{
			  @bool = false;
			}
			stringBuilder1.Append(stringBuilder2.Append(@bool).Append("\" ").ToString());
			stringBuilder.Append("size_in_pixels=\"").Append(mapLayer.sizeInPixels + "\" ");
			stringBuilder2 = stringBuilder.Append("allows_night_mode=\"");
			stringBuilder1 = new StringBuilder();
			if (mapLayer.isAllowNightMode)
			{
			  str = "1";
			}
			else
			{
			  str = "0";
			}
			stringBuilder2.Append(stringBuilder1.Append(str).Append("\" ").ToString());
			stringBuilder.Append("/> ");
		  }
		}
		stringBuilder.Append("</map_layers>");
		return stringBuilder.ToString();
	  }

	  public static System.Collections.IList a(Stream paramInputStream)
	  {
		Exception exception2 = null;
		try
		{
		  XmlPullParserFactory xmlPullParserFactory = XmlPullParserFactory.newInstance();
		  xmlPullParserFactory.setNamespaceAware(true);
		  XmlPullParser xmlPullParser = xmlPullParserFactory.newPullParser();
		  xmlPullParser.setInput(paramInputStream, null);
		  System.Collections.IList list = a(xmlPullParser);
		}
		catch (Exception exception1)
		{
		  Log.w("maplayer", "Error while parse xml " + exception1);
		  exception1 = exception2;
		}
		return (System.Collections.IList)exception1;
	  }

	  public static System.Collections.IList a(XmlPullParser paramXmlPullParser)
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokeinterface getEventType : ()I
		//   6: istore_1
		//   7: new java/util/ArrayList
		//   10: astore_2
		//   11: aload_2
		//   12: invokespecial <init> : ()V
		//   15: aconst_null
		//   16: astore_3
		//   17: iconst_0
		//   18: istore #4
		//   20: iload_1
		//   21: iconst_1
		//   22: if_icmpeq -> 387
		//   25: iload_1
		//   26: iconst_2
		//   27: if_icmpne -> 350
		//   30: aload_0
		//   31: invokeinterface getName : ()Ljava/lang/String;
		//   36: astore #5
		//   38: ldc 'map_layers'
		//   40: aload #5
		//   42: invokevirtual equals : (Ljava/lang/Object;)Z
		//   45: ifeq -> 61
		//   48: iconst_1
		//   49: istore #4
		//   51: aload_0
		//   52: invokeinterface next : ()I
		//   57: istore_1
		//   58: goto -> 20
		//   61: iload #4
		//   63: istore_1
		//   64: iload #4
		//   66: iconst_1
		//   67: if_icmpne -> 344
		//   70: ldc 'l'
		//   72: aload #5
		//   74: invokevirtual equals : (Ljava/lang/Object;)Z
		//   77: istore #6
		//   79: iload #4
		//   81: istore_1
		//   82: iload #6
		//   84: ifeq -> 344
		//   87: aload_0
		//   88: aconst_null
		//   89: ldc 'request'
		//   91: invokeinterface getAttributeValue : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   96: astore #7
		//   98: aload_0
		//   99: aconst_null
		//   100: ldc 'id'
		//   102: invokeinterface getAttributeValue : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   107: invokestatic parseInt : (Ljava/lang/String;)I
		//   110: istore #8
		//   112: aload_0
		//   113: aconst_null
		//   114: ldc 'name'
		//   116: invokeinterface getAttributeValue : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   121: astore #9
		//   123: iconst_m1
		//   124: istore_1
		//   125: aload_0
		//   126: aconst_null
		//   127: ldc 'ver'
		//   129: invokeinterface getAttributeValue : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   134: invokestatic parseInt : (Ljava/lang/String;)I
		//   137: istore #4
		//   139: aload_0
		//   140: aconst_null
		//   141: ldc 'service'
		//   143: invokeinterface getAttributeValue : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   148: invokestatic parseInt : (Ljava/lang/String;)I
		//   151: istore_1
		//   152: iload_1
		//   153: iconst_1
		//   154: if_icmpne -> 259
		//   157: iconst_1
		//   158: istore #6
		//   160: iload #6
		//   162: istore #10
		//   164: sipush #128
		//   167: istore #11
		//   169: aload_0
		//   170: aconst_null
		//   171: ldc 'size_in_pixels'
		//   173: invokeinterface getAttributeValue : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   178: invokestatic parseInt : (Ljava/lang/String;)I
		//   181: istore_1
		//   182: aload_0
		//   183: aconst_null
		//   184: ldc 'allows_night_mode'
		//   186: invokeinterface getAttributeValue : (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
		//   191: astore #5
		//   193: aload #5
		//   195: ifnull -> 441
		//   198: ldc 'no'
		//   200: aload #5
		//   202: invokevirtual toLowerCase : ()Ljava/lang/String;
		//   205: invokevirtual equals : (Ljava/lang/Object;)Z
		//   208: ifne -> 224
		//   211: ldc '0'
		//   213: aload #5
		//   215: invokevirtual toLowerCase : ()Ljava/lang/String;
		//   218: invokevirtual equals : (Ljava/lang/Object;)Z
		//   221: ifeq -> 273
		//   224: iconst_0
		//   225: istore #6
		//   227: new ru/yandex/yandexmapkit/map/MapLayer
		//   230: astore #5
		//   232: aload #5
		//   234: aload #7
		//   236: iload #8
		//   238: aload #9
		//   240: iload #4
		//   242: iload #10
		//   244: iload_1
		//   245: iload #6
		//   247: invokespecial <init> : (Ljava/lang/String;ILjava/lang/String;IZIZ)V
		//   250: iconst_2
		//   251: istore #4
		//   253: aload #5
		//   255: astore_3
		//   256: goto -> 51
		//   259: iconst_0
		//   260: istore #6
		//   262: goto -> 160
		//   265: astore #5
		//   267: iconst_0
		//   268: istore #10
		//   270: goto -> 164
		//   273: ldc 'yes'
		//   275: aload #5
		//   277: invokevirtual toLowerCase : ()Ljava/lang/String;
		//   280: invokevirtual equals : (Ljava/lang/Object;)Z
		//   283: ifne -> 303
		//   286: ldc '1'
		//   288: aload #5
		//   290: invokevirtual toLowerCase : ()Ljava/lang/String;
		//   293: invokevirtual equals : (Ljava/lang/Object;)Z
		//   296: istore #6
		//   298: iload #6
		//   300: ifeq -> 441
		//   303: iconst_1
		//   304: istore #6
		//   306: goto -> 227
		//   309: astore #5
		//   311: new java/lang/StringBuilder
		//   314: astore #9
		//   316: aload #9
		//   318: invokespecial <init> : ()V
		//   321: ldc 'startup'
		//   323: aload #9
		//   325: ldc 'can't parse map layers tag layer'
		//   327: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   330: aload #5
		//   332: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   335: invokevirtual toString : ()Ljava/lang/String;
		//   338: invokestatic w : (Ljava/lang/String;Ljava/lang/String;)I
		//   341: pop
		//   342: iconst_2
		//   343: istore_1
		//   344: iload_1
		//   345: istore #4
		//   347: goto -> 51
		//   350: iload_1
		//   351: iconst_3
		//   352: if_icmpne -> 438
		//   355: ldc 'l'
		//   357: aload_0
		//   358: invokeinterface getName : ()Ljava/lang/String;
		//   363: invokevirtual equals : (Ljava/lang/Object;)Z
		//   366: ifeq -> 438
		//   369: aload_3
		//   370: ifnull -> 438
		//   373: aload_2
		//   374: aload_3
		//   375: invokeinterface add : (Ljava/lang/Object;)Z
		//   380: pop
		//   381: iconst_1
		//   382: istore #4
		//   384: goto -> 51
		//   387: aload_2
		//   388: astore_0
		//   389: aload_0
		//   390: areturn
		//   391: astore_0
		//   392: ldc 'maplayer'
		//   394: new java/lang/StringBuilder
		//   397: dup
		//   398: invokespecial <init> : ()V
		//   401: ldc 'Error while parse xml '
		//   403: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   406: aload_0
		//   407: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   410: invokevirtual toString : ()Ljava/lang/String;
		//   413: invokestatic w : (Ljava/lang/String;Ljava/lang/String;)I
		//   416: pop
		//   417: aconst_null
		//   418: astore_0
		//   419: goto -> 389
		//   422: astore #5
		//   424: iload #11
		//   426: istore_1
		//   427: goto -> 182
		//   430: astore #5
		//   432: iload_1
		//   433: istore #4
		//   435: goto -> 139
		//   438: goto -> 51
		//   441: iconst_1
		//   442: istore #6
		//   444: goto -> 227
		// Exception table:
		//   from	to	target	type
		//   0	15	391	java/lang/Exception
		//   30	48	391	java/lang/Exception
		//   51	58	391	java/lang/Exception
		//   70	79	391	java/lang/Exception
		//   87	123	309	java/lang/Exception
		//   125	139	430	java/lang/NumberFormatException
		//   125	139	309	java/lang/Exception
		//   139	152	265	java/lang/NumberFormatException
		//   139	152	309	java/lang/Exception
		//   169	182	422	java/lang/NumberFormatException
		//   169	182	309	java/lang/Exception
		//   182	193	309	java/lang/Exception
		//   198	224	309	java/lang/Exception
		//   227	250	309	java/lang/Exception
		//   273	298	309	java/lang/Exception
		//   311	342	391	java/lang/Exception
		//   355	369	391	java/lang/Exception
		//   373	381	391	java/lang/Exception
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\map\MapLayer.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}