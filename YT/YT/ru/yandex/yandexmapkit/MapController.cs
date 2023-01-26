using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ru.yandex.yandexmapkit
{
	using a;
	using aa;
	using ab;
	using ac;
	using ah;
	using am;
	using Context = android.content.Context;
	using SharedPreferences = android.content.SharedPreferences;
	using Resources = android.content.res.Resources;
	using Canvas = android.graphics.Canvas;
	using PointF = android.graphics.PointF;
	using Drawable = android.graphics.drawable.Drawable;
	using Build = android.os.Build;
	using Log = android.util.Log;
	using MotionEvent = android.view.MotionEvent;
	using View = android.view.View;
	using Button = android.widget.Button;
	using ap;
	using aq;
	using ar;
	using aw;
	using ay;
	using b;
	using bf;
	using bi;
	using bj;
	using br;
	using by;
	using o;
	using XmlPullParser = org.xmlpull.v1.XmlPullParser;
	using p;
	using MapEvent = ru.yandex.yandexmapkit.map.MapEvent;
	using MapLayer = ru.yandex.yandexmapkit.map.MapLayer;
	using OnMapListener = ru.yandex.yandexmapkit.map.OnMapListener;
	using DownloadHandler = ru.yandex.yandexmapkit.net.DownloadHandler;
	using DownloadJob = ru.yandex.yandexmapkit.net.DownloadJob;
	using Downloader = ru.yandex.yandexmapkit.net.Downloader;
	using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;
	using z;

	public class MapController : ac, DownloadHandler
	{
		private bool InstanceFieldsInitialized = false;

		private void InitializeInstanceFields()
		{
			B = (View.OnClickListener)new o(this);
		}

	  private static a u;

	  private bf A = null;

	  private View.OnClickListener B;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal readonly MapController$Map a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal readonly ah b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal readonly aq c_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public System.Collections.IList d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal View e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public OverlayManager f_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal View g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public View h_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public View i_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public View j_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public Button k_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public Drawable[] l_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public int m_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public int n_Conflict;

	  private readonly Context o;

	  private readonly Resources p;

	  private readonly ab q;

	  private readonly Downloader r;

	  private readonly bj s;

	  private readonly ap t;

	  private readonly aw v;

	  private bool w = true;

	  private bool x;

	  private MapView y;

	  private z z;

	  public MapController(z paramz, MapView paramMapView)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
		this.y = paramMapView;
		this.z = paramz;
		this.e_Conflict = (View)paramz;
		this.o = this.e_Conflict.getContext();
		this.d_Conflict = new ArrayList();
		this.a_Conflict = new MapController$Map(this);
		this.p = this.o.getResources();
		this.r = new Downloader(this.y.a());
		this.s = new bj(this, this.y.a());
		if (u == null)
		{
		  a a1 = new a(this.o);
		  u = a1;
		  a1.f();
		}
		this.t = new ap(u, this);
		this.c_Conflict = new aq(this, this.a_Conflict, this.t);
		this.v = new aw(this);
		this.v.c(true);
		this.n_Conflict = -1;
		this.b_Conflict = new ah(this.z);
		this.b_Conflict.a(0.0F);
		lock (this.d_Conflict)
		{
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: java.util.List<? extends E> list = n();
		  IList<E> list = n();
		  if (list != null)
		  {
			a(list);
			ArrayList arrayList = new ArrayList();
			this(list);
			this.d_Conflict = arrayList;
		  }
		  this.f_Conflict = new OverlayManager(this);
		  if (Build.VERSION.SDK == null || int.Parse(Build.VERSION.SDK) < 5)
		  {
			@bool = false;
		  }
		  if (@bool)
		  {
			this.q = (ab)new aa(this.o, this);
		  }
		  else
		  {
			this.q = new ab(this.o, this);
		  }
		  Downloader.a(this.o.getSharedPreferences("COMMON_PREFS", 0).getString("pref.uuid", null));
		  this.A = new bf(this);
		  return;
		}
	  }

	  private void a(bi parambi)
	  {
		// Byte code:
		//   0: aload_0
		//   1: getfield d : Ljava/util/List;
		//   4: astore_2
		//   5: aload_2
		//   6: monitorenter
		//   7: new java/util/ArrayList
		//   10: astore_3
		//   11: aload_3
		//   12: aload_1
		//   13: getfield p : Ljava/util/List;
		//   16: invokespecial <init> : (Ljava/util/Collection;)V
		//   19: aload_3
		//   20: invokeinterface size : ()I
		//   25: ifle -> 266
		//   28: aload_0
		//   29: getfield d : Ljava/util/List;
		//   32: invokeinterface iterator : ()Ljava/util/Iterator;
		//   37: astore_1
		//   38: aload_1
		//   39: invokeinterface hasNext : ()Z
		//   44: ifeq -> 83
		//   47: aload_1
		//   48: invokeinterface next : ()Ljava/lang/Object;
		//   53: checkcast ru/yandex/yandexmapkit/map/MapLayer
		//   56: astore #4
		//   58: aload #4
		//   60: getfield isCustom : Z
		//   63: ifeq -> 38
		//   66: aload_3
		//   67: aload #4
		//   69: invokeinterface add : (Ljava/lang/Object;)Z
		//   74: pop
		//   75: goto -> 38
		//   78: astore_1
		//   79: aload_2
		//   80: monitorexit
		//   81: aload_1
		//   82: athrow
		//   83: aload_0
		//   84: aload_3
		//   85: putfield d : Ljava/util/List;
		//   88: getstatic ru/yandex/yandexmapkit/MapController.u : La;
		//   91: invokevirtual a : ()Ljava/lang/String;
		//   94: astore_1
		//   95: aconst_null
		//   96: astore_3
		//   97: new java/io/File
		//   100: astore #4
		//   102: new java/lang/StringBuilder
		//   105: astore #5
		//   107: aload #5
		//   109: invokespecial <init> : ()V
		//   112: aload #4
		//   114: aload #5
		//   116: aload_1
		//   117: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   120: getstatic ru/yandex/yandexmapkit/MapController.u : La;
		//   123: invokevirtual b : ()C
		//   126: invokevirtual append : (C)Ljava/lang/StringBuilder;
		//   129: ldc_w 'config'
		//   132: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   135: invokevirtual toString : ()Ljava/lang/String;
		//   138: invokespecial <init> : (Ljava/lang/String;)V
		//   141: aload #4
		//   143: invokevirtual exists : ()Z
		//   146: ifne -> 155
		//   149: aload #4
		//   151: invokevirtual mkdir : ()Z
		//   154: pop
		//   155: new java/io/File
		//   158: astore #4
		//   160: new java/lang/StringBuilder
		//   163: astore #5
		//   165: aload #5
		//   167: invokespecial <init> : ()V
		//   170: aload #4
		//   172: aload #5
		//   174: aload_1
		//   175: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   178: getstatic ru/yandex/yandexmapkit/MapController.u : La;
		//   181: invokevirtual b : ()C
		//   184: invokevirtual append : (C)Ljava/lang/StringBuilder;
		//   187: ldc_w 'config'
		//   190: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   193: getstatic ru/yandex/yandexmapkit/MapController.u : La;
		//   196: invokevirtual b : ()C
		//   199: invokevirtual append : (C)Ljava/lang/StringBuilder;
		//   202: ldc_w 'system'
		//   205: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   208: ldc_w '.xml'
		//   211: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   214: invokevirtual toString : ()Ljava/lang/String;
		//   217: invokespecial <init> : (Ljava/lang/String;)V
		//   220: aload #4
		//   222: invokevirtual exists : ()Z
		//   225: ifeq -> 234
		//   228: aload #4
		//   230: invokevirtual delete : ()Z
		//   233: pop
		//   234: new java/io/FileOutputStream
		//   237: astore_1
		//   238: aload_1
		//   239: aload #4
		//   241: invokespecial <init> : (Ljava/io/File;)V
		//   244: aload_1
		//   245: aload_0
		//   246: getfield d : Ljava/util/List;
		//   249: invokestatic a : (Ljava/util/List;)Ljava/lang/String;
		//   252: invokevirtual getBytes : ()[B
		//   255: invokevirtual write : ([B)V
		//   258: aload_1
		//   259: invokevirtual flush : ()V
		//   262: aload_1
		//   263: invokevirtual close : ()V
		//   266: aload_2
		//   267: monitorexit
		//   268: return
		//   269: astore_1
		//   270: aload_3
		//   271: astore_1
		//   272: aload_1
		//   273: ifnull -> 266
		//   276: aload_1
		//   277: invokevirtual close : ()V
		//   280: goto -> 266
		//   283: astore_1
		//   284: goto -> 266
		//   287: astore_3
		//   288: aconst_null
		//   289: astore_1
		//   290: aload_1
		//   291: ifnull -> 298
		//   294: aload_1
		//   295: invokevirtual close : ()V
		//   298: aload_3
		//   299: athrow
		//   300: astore_1
		//   301: goto -> 266
		//   304: astore_1
		//   305: goto -> 298
		//   308: astore_3
		//   309: goto -> 290
		//   312: astore_3
		//   313: goto -> 272
		// Exception table:
		//   from	to	target	type
		//   7	38	78	finally
		//   38	75	78	finally
		//   83	95	78	finally
		//   97	155	269	java/lang/Exception
		//   97	155	287	finally
		//   155	234	269	java/lang/Exception
		//   155	234	287	finally
		//   234	244	269	java/lang/Exception
		//   234	244	287	finally
		//   244	262	312	java/lang/Exception
		//   244	262	308	finally
		//   262	266	300	java/lang/Exception
		//   262	266	78	finally
		//   266	268	78	finally
		//   276	280	283	java/lang/Exception
		//   276	280	78	finally
		//   294	298	304	java/lang/Exception
		//   294	298	78	finally
		//   298	300	78	finally
	  }

	  private static void a(IList<MapLayer> paramList)
	  {
		string str = u.a() + u.b() + "config";
		if (Directory.Exists(str) || File.Exists(str))
		{
		  string[] arrayOfString = b.a(str, "xml", false, null);
		  if (arrayOfString != null && arrayOfString.Length > 0)
		  {
			sbyte b = 0;
			while (true)
			{
			  if (b < arrayOfString.Length)
			  {
				if (!"system".Equals(arrayOfString[b]))
				{
				  File file = new File(str + u.b() + arrayOfString[b] + ".xml");
				  if (file.exists())
				  {
					if (file.canRead())
					{
					  try
					  {
						FileStream fileInputStream = new FileStream();
						this(file);
						System.Collections.IList list = MapLayer.a(fileInputStream);
						if (list != null)
						{
						  if (list.Count > 0)
						  {
							IEnumerator<MapLayer> iterator = list.GetEnumerator();
							while (true)
							{
							  MapLayer mapLayer;
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
							  if (iterator.hasNext())
							  {
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
								mapLayer = iterator.next();
								System.Collections.IEnumerator iterator1 = paramList.GetEnumerator();
								while (iterator1.MoveNext())
								{
								  if (((MapLayer)iterator1.Current).layerId == mapLayer.layerId)
								  {
									bool bool1 = true;
									goto label32Break;
								  }
									label32Continue:;
								}
								label32Break:;
							  }
							  else
							  {
								b++;
								goto label36Continue;
							  }
							  bool @bool = false;
							  if (!@bool && !mapLayer.isService)
							  {
								mapLayer.isCustom = true;
								paramList.Add(mapLayer);
							  }
							}
							break;
						  }
						  continue;
						}
						continue;
					  }
					  catch (FileNotFoundException)
					  {
						continue;
					  }
					}
					continue;
				  }
				  continue;
				}
				continue;
			  }
			  return;
				label36Continue:;
			}
			label36Break:;
		  }
		}
	  }

	  private System.Collections.IList n()
	  {
		string str1 = null;
		string str2 = u.a();
		File file = new File(str2 + u.b() + "config" + u.b() + "system" + ".xml");
		str2 = str1;
		if (file.exists())
		{
		  str2 = str1;
		  if (file.canRead())
		  {
			try
			{
			  FileStream fileInputStream = new FileStream();
			  this(file);
			  System.Collections.IList list = MapLayer.a(fileInputStream);
			}
			catch (FileNotFoundException)
			{
			  str2 = str1;
			}
		  }
		}
		if (!string.ReferenceEquals(str2, null))
		{
		  str1 = str2;
		  return (System.Collections.IList)((str2.size() == 0) ? MapLayer.a((XmlPullParser)this.p.getXml(this.p.getIdentifier("map_layers", "xml", this.o.getPackageName()))) : str1);
		}
		return MapLayer.a((XmlPullParser)this.p.getXml(this.p.getIdentifier("map_layers", "xml", this.o.getPackageName())));
	  }

	  public virtual View a()
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: getfield g : Landroid/view/View;
		//   6: ifnonnull -> 387
		//   9: aload_0
		//   10: getfield o : Landroid/content/Context;
		//   13: invokevirtual getResources : ()Landroid/content/res/Resources;
		//   16: astore_1
		//   17: aload_0
		//   18: aload_0
		//   19: getfield o : Landroid/content/Context;
		//   22: invokestatic from : (Landroid/content/Context;)Landroid/view/LayoutInflater;
		//   25: aload_1
		//   26: ldc_w 'screen_buttons_layout'
		//   29: ldc_w 'layout'
		//   32: aload_0
		//   33: getfield o : Landroid/content/Context;
		//   36: invokevirtual getPackageName : ()Ljava/lang/String;
		//   39: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   42: aload_0
		//   43: getfield y : Lru/yandex/yandexmapkit/MapView;
		//   46: invokevirtual inflate : (ILandroid/view/ViewGroup;)Landroid/view/View;
		//   49: putfield g : Landroid/view/View;
		//   52: aload_0
		//   53: aload_0
		//   54: getfield g : Landroid/view/View;
		//   57: aload_1
		//   58: ldc_w 'zoom_in'
		//   61: ldc_w 'id'
		//   64: aload_0
		//   65: getfield o : Landroid/content/Context;
		//   68: invokevirtual getPackageName : ()Ljava/lang/String;
		//   71: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   74: invokevirtual findViewById : (I)Landroid/view/View;
		//   77: putfield h : Landroid/view/View;
		//   80: aload_0
		//   81: getfield h : Landroid/view/View;
		//   84: ifnull -> 98
		//   87: aload_0
		//   88: getfield h : Landroid/view/View;
		//   91: aload_0
		//   92: getfield B : Landroid/view/View$OnClickListener;
		//   95: invokevirtual setOnClickListener : (Landroid/view/View$OnClickListener;)V
		//   98: aload_0
		//   99: aload_0
		//   100: getfield g : Landroid/view/View;
		//   103: aload_1
		//   104: ldc_w 'zoom_out'
		//   107: ldc_w 'id'
		//   110: aload_0
		//   111: getfield o : Landroid/content/Context;
		//   114: invokevirtual getPackageName : ()Ljava/lang/String;
		//   117: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   120: invokevirtual findViewById : (I)Landroid/view/View;
		//   123: putfield i : Landroid/view/View;
		//   126: aload_0
		//   127: getfield i : Landroid/view/View;
		//   130: ifnull -> 144
		//   133: aload_0
		//   134: getfield i : Landroid/view/View;
		//   137: aload_0
		//   138: getfield B : Landroid/view/View$OnClickListener;
		//   141: invokevirtual setOnClickListener : (Landroid/view/View$OnClickListener;)V
		//   144: aload_0
		//   145: aload_0
		//   146: getfield g : Landroid/view/View;
		//   149: aload_1
		//   150: ldc_w 'find_me'
		//   153: ldc_w 'id'
		//   156: aload_0
		//   157: getfield o : Landroid/content/Context;
		//   160: invokevirtual getPackageName : ()Ljava/lang/String;
		//   163: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   166: invokevirtual findViewById : (I)Landroid/view/View;
		//   169: putfield j : Landroid/view/View;
		//   172: aload_0
		//   173: getfield j : Landroid/view/View;
		//   176: ifnull -> 190
		//   179: aload_0
		//   180: getfield j : Landroid/view/View;
		//   183: aload_0
		//   184: getfield B : Landroid/view/View$OnClickListener;
		//   187: invokevirtual setOnClickListener : (Landroid/view/View$OnClickListener;)V
		//   190: aload_0
		//   191: aload_0
		//   192: getfield g : Landroid/view/View;
		//   195: aload_1
		//   196: ldc_w 'semaphore'
		//   199: ldc_w 'id'
		//   202: aload_0
		//   203: getfield o : Landroid/content/Context;
		//   206: invokevirtual getPackageName : ()Ljava/lang/String;
		//   209: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   212: invokevirtual findViewById : (I)Landroid/view/View;
		//   215: checkcast android/widget/Button
		//   218: putfield k : Landroid/widget/Button;
		//   221: aload_0
		//   222: getfield k : Landroid/widget/Button;
		//   225: ifnull -> 239
		//   228: aload_0
		//   229: getfield k : Landroid/widget/Button;
		//   232: aload_0
		//   233: getfield B : Landroid/view/View$OnClickListener;
		//   236: invokevirtual setOnClickListener : (Landroid/view/View$OnClickListener;)V
		//   239: aload_0
		//   240: iconst_5
		//   241: anewarray android/graphics/drawable/Drawable
		//   244: putfield l : [Landroid/graphics/drawable/Drawable;
		//   247: aload_0
		//   248: getfield l : [Landroid/graphics/drawable/Drawable;
		//   251: iconst_0
		//   252: aload_1
		//   253: aload_1
		//   254: ldc_w 'sgrayvga'
		//   257: ldc_w 'drawable'
		//   260: aload_0
		//   261: getfield o : Landroid/content/Context;
		//   264: invokevirtual getPackageName : ()Ljava/lang/String;
		//   267: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   270: invokevirtual getDrawable : (I)Landroid/graphics/drawable/Drawable;
		//   273: aastore
		//   274: aload_0
		//   275: getfield l : [Landroid/graphics/drawable/Drawable;
		//   278: iconst_1
		//   279: aload_1
		//   280: aload_1
		//   281: ldc_w 'sredvga'
		//   284: ldc_w 'drawable'
		//   287: aload_0
		//   288: getfield o : Landroid/content/Context;
		//   291: invokevirtual getPackageName : ()Ljava/lang/String;
		//   294: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   297: invokevirtual getDrawable : (I)Landroid/graphics/drawable/Drawable;
		//   300: aastore
		//   301: aload_0
		//   302: getfield l : [Landroid/graphics/drawable/Drawable;
		//   305: iconst_2
		//   306: aload_1
		//   307: aload_1
		//   308: ldc_w 'syellowvga'
		//   311: ldc_w 'drawable'
		//   314: aload_0
		//   315: getfield o : Landroid/content/Context;
		//   318: invokevirtual getPackageName : ()Ljava/lang/String;
		//   321: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   324: invokevirtual getDrawable : (I)Landroid/graphics/drawable/Drawable;
		//   327: aastore
		//   328: aload_0
		//   329: getfield l : [Landroid/graphics/drawable/Drawable;
		//   332: iconst_3
		//   333: aload_1
		//   334: aload_1
		//   335: ldc_w 'sgreenvga'
		//   338: ldc_w 'drawable'
		//   341: aload_0
		//   342: getfield o : Landroid/content/Context;
		//   345: invokevirtual getPackageName : ()Ljava/lang/String;
		//   348: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   351: invokevirtual getDrawable : (I)Landroid/graphics/drawable/Drawable;
		//   354: aastore
		//   355: aload_0
		//   356: getfield l : [Landroid/graphics/drawable/Drawable;
		//   359: iconst_4
		//   360: aload_1
		//   361: aload_1
		//   362: ldc_w 'stricolorvga'
		//   365: ldc_w 'drawable'
		//   368: aload_0
		//   369: getfield o : Landroid/content/Context;
		//   372: invokevirtual getPackageName : ()Ljava/lang/String;
		//   375: invokevirtual getIdentifier : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I
		//   378: invokevirtual getDrawable : (I)Landroid/graphics/drawable/Drawable;
		//   381: aastore
		//   382: aload_0
		//   383: iconst_4
		//   384: putfield m : I
		//   387: aload_0
		//   388: getfield g : Landroid/view/View;
		//   391: astore_1
		//   392: aload_0
		//   393: monitorexit
		//   394: aload_1
		//   395: areturn
		//   396: astore_1
		//   397: aload_0
		//   398: monitorexit
		//   399: aload_1
		//   400: athrow
		// Exception table:
		//   from	to	target	type
		//   2	98	396	finally
		//   98	144	396	finally
		//   144	190	396	finally
		//   190	239	396	finally
		//   239	387	396	finally
		//   387	392	396	finally
	  }

	  public virtual MapLayer a(int paramInt)
	  {
		// Byte code:
		//   0: aload_0
		//   1: getfield d : Ljava/util/List;
		//   4: astore_2
		//   5: aload_2
		//   6: monitorenter
		//   7: aload_0
		//   8: getfield d : Ljava/util/List;
		//   11: ifnull -> 70
		//   14: aload_0
		//   15: getfield d : Ljava/util/List;
		//   18: invokeinterface size : ()I
		//   23: ifle -> 70
		//   26: aload_0
		//   27: getfield d : Ljava/util/List;
		//   30: invokeinterface iterator : ()Ljava/util/Iterator;
		//   35: astore_3
		//   36: aload_3
		//   37: invokeinterface hasNext : ()Z
		//   42: ifeq -> 70
		//   45: aload_3
		//   46: invokeinterface next : ()Ljava/lang/Object;
		//   51: checkcast ru/yandex/yandexmapkit/map/MapLayer
		//   54: astore #4
		//   56: aload #4
		//   58: getfield layerId : I
		//   61: iload_1
		//   62: if_icmpne -> 36
		//   65: aload_2
		//   66: monitorexit
		//   67: aload #4
		//   69: areturn
		//   70: aload_2
		//   71: monitorexit
		//   72: aconst_null
		//   73: astore #4
		//   75: goto -> 67
		//   78: astore #4
		//   80: aload_2
		//   81: monitorexit
		//   82: aload #4
		//   84: athrow
		// Exception table:
		//   from	to	target	type
		//   7	36	78	finally
		//   36	67	78	finally
	  }

	  public virtual void a(float paramFloat1, float paramFloat2)
	  {
		if (Enabled)
		{
		  PointF pointF = this.b_Conflict.e(paramFloat1, paramFloat2);
		  zoomOut(pointF.x, pointF.y);
		}
	  }

	  public virtual void a(float paramFloat1, float paramFloat2, float paramFloat3)
	  {
		if (Enabled)
		{
		  this.a_Conflict.a(paramFloat1, paramFloat2, paramFloat3);
		}
	  }

	  public virtual void a(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4)
	  {
		if (!this.f_Conflict.a(paramFloat1, paramFloat2, paramFloat3, paramFloat4) && Enabled && (paramFloat1 > 1.0F || paramFloat2 > 1.0F || paramFloat1 < -1.0F || paramFloat2 < -1.0F))
		{
		  if (!this.x)
		  {
			this.a_Conflict.a(new MapEvent(1));
		  }
		  else
		  {
			this.a_Conflict.a(new MapEvent(2));
		  }
		  this.x = true;
		  this.a_Conflict.a(paramFloat1, paramFloat2);
		  this.v.b(false);
		}
	  }

	  public virtual void a(int paramInt1, int paramInt2)
	  {
		this.c_Conflict.a(paramInt1, paramInt2);
		if (!Downloader.b())
		{
		  this.r.a(this, br.a(), paramInt1, paramInt2);
		}
	  }

	  public virtual void a(Canvas paramCanvas)
	  {
		this.b_Conflict.d();
		paramCanvas.save();
		if (this.b_Conflict.a())
		{
		  paramCanvas.rotate(-this.b_Conflict.c(), this.b_Conflict.e(), this.b_Conflict.f());
		}
		aq.a(paramCanvas);
		paramCanvas.restore();
	  }

	  public virtual void a(ay paramay)
	  {
		if (JamsVisible && this.k_Conflict != null)
		{
		  this.k_Conflict.post((ThreadStart)new p(this, paramay));
		}
	  }

	  public virtual void a(by paramby)
	  {
		MapController$Map.a(this.a_Conflict, paramby.x, paramby.y, true, false, false);
	  }

	  public virtual void a(by paramby, int paramInt)
	  {
		MapController$Map.a(this.a_Conflict, paramby.x, paramby.y, paramInt, true, false, false);
	  }

	  internal virtual void a(string paramString, bi parambi)
	  {
		ar ar = new ar(paramString, "-1", Downloader.getServer(22), parambi.h, parambi.i, parambi.j, parambi.k, Downloader.getServer(21), parambi.l, parambi.m, parambi.n, parambi.o);
		this.A.a(ar);
	  }

	  public virtual void a(bool paramBoolean)
	  {
		if (this.j_Conflict != null)
		{
		  sbyte b;
		  View view = this.j_Conflict;
		  if (paramBoolean)
		  {
			b = 0;
		  }
		  else
		  {
			b = 8;
		  }
		  view.setVisibility(b);
		}
	  }

	  public virtual bool a(am paramam)
	  {
		return (paramam.type != this.c_Conflict.g() && !paramam.d_Conflict) ? false : this.c_Conflict.b(paramam.i, paramam.j);
	  }

	  public virtual bool a(MotionEvent paramMotionEvent)
	  {
		if (!this.f_Conflict.a(paramMotionEvent))
		{
		  this.q.a(paramMotionEvent);
		}
		return true;
	  }

	  public virtual void addMapListener(OnMapListener paramOnMapListener)
	  {
		this.a_Conflict.a(paramOnMapListener);
	  }

	  public virtual void b()
	  {
		Log.d("mw", "startAll destroyCache");
		this.a_Conflict.a();
		ap.a(this.t);
		aq.a(this.c_Conflict);
		this.c_Conflict.a();
		this.r.a();
		this.s.a();
		if (u != null && !u.d_Conflict)
		{
		  u.a(true);
		}
		if (u != null && u.b_Conflict)
		{
		  u.a_Conflict(this.o);
		}
		this.v.b(false);
		this.c_Conflict.h();
		if (Downloader.b())
		{
		  a(Downloader.UUID, Downloader.b_Conflict);
		}
	  }

	  public virtual void b(float paramFloat1, float paramFloat2)
	  {
		if (this.x && Enabled)
		{
		  this.a_Conflict.d(-paramFloat1 / 1000.0F, -paramFloat2 / 1000.0F);
		}
	  }

	  internal virtual void b(int paramInt)
	  {
		if (this.c_Conflict.g() != paramInt)
		{
		  aq.a(paramInt);
		  notifyRepaint();
		}
	  }

	  public virtual void b(by paramby)
	  {
		MapController$Map.a(this.a_Conflict, paramby.x, paramby.y, false, false, false);
	  }

	  public virtual void b(by paramby, int paramInt)
	  {
		MapController$Map.a(this.a_Conflict, paramby.x, paramby.y, paramInt, false, false, false);
		g().f();
	  }

	  public virtual void b(bool paramBoolean)
	  {
		if (this.k_Conflict != null)
		{
		  sbyte b;
		  Button button = this.k_Conflict;
		  if (paramBoolean)
		  {
			b = 0;
		  }
		  else
		  {
			b = 8;
		  }
		  button.setVisibility(b);
		}
	  }

	  public virtual bool b(MotionEvent paramMotionEvent)
	  {
		return this.f_Conflict.b(paramMotionEvent);
	  }

	  public virtual void c()
	  {
		SharedPreferences.Editor editor = this.o.getSharedPreferences("COMMON_PREFS", 0).edit();
		editor.putString("pref.uuid", Downloader.UUID);
		editor.commit();
		u.d();
		this.r.f();
		this.s.c();
		Thread thread2 = this.a_Conflict.d();
		Thread thread3 = this.b_Conflict.g();
		Thread thread1 = this.c_Conflict.j();
		if (thread2 != null && thread2.IsAlive)
		{
		  try
		  {
			thread2.Join();
		  }
		  catch (InterruptedException)
		  {
		  }
		}
		if (thread3 != null && thread3.IsAlive)
		{
		  try
		  {
			thread3.Join();
		  }
		  catch (InterruptedException)
		  {
		  }
		}
		if (thread1 != null && thread1.IsAlive)
		{
		  try
		  {
			thread1.Join();
		  }
		  catch (InterruptedException)
		  {
		  }
		}
		Log.d("mw", "stopAll destroyCache");
		if (this.A != null)
		{
		  thread1 = this.A.a();
		  if (thread1 != null && thread1 != null && thread1.IsAlive)
		  {
			try
			{
			  thread1.Join();
			}
			catch (InterruptedException)
			{
			}
		  }
		}
	  }

	  public virtual void c(float paramFloat1, float paramFloat2)
	  {
		if (Enabled)
		{
		  MapController$Map mapController$Map = this.a_Conflict;
		  mapController$Map.a(new MapEvent(7));
		  mapController$Map.c();
		  mapController$Map.h_Conflict = mapController$Map.i_Conflict;
		  mapController$Map.n.c.k();
		  mapController$Map.j_Conflict = mapController$Map.n.c.a(paramFloat1, paramFloat2, mapController$Map.j_Conflict);
		  Math.Pow(2.0D, (23.0F - mapController$Map.h_Conflict));
		  mapController$Map.d_Conflict = paramFloat1;
		  mapController$Map.e_Conflict = paramFloat2;
		  mapController$Map.g_Conflict = true;
		}
	  }

	  public virtual void c(bool paramBoolean)
	  {
		bool @bool = false;
		if (this.h_Conflict != null)
		{
		  sbyte b;
		  View view = this.h_Conflict;
		  if (paramBoolean)
		  {
			b = 0;
		  }
		  else
		  {
			b = 8;
		  }
		  view.setVisibility(b);
		}
		if (this.i_Conflict != null)
		{
		  sbyte b;
		  View view = this.i_Conflict;
		  if (paramBoolean)
		  {
			b = @bool;
		  }
		  else
		  {
			b = 8;
		  }
		  view.setVisibility(b);
		}
	  }

	  public virtual MapController$Map d()
	  {
		return this.a_Conflict;
	  }

	  public virtual void d(float paramFloat1, float paramFloat2)
	  {
		if (!this.f_Conflict.a(paramFloat1, paramFloat2))
		{
		  hideBalloon();
		}
	  }

	  public virtual ah e()
	  {
		return this.b_Conflict;
	  }

	  public virtual void e(float paramFloat1, float paramFloat2)
	  {
		if (!this.f_Conflict.b(paramFloat1, paramFloat2) && Enabled)
		{
		  d().a(new MapEvent(10, paramFloat1, paramFloat2));
		}
	  }

	  public virtual aw f()
	  {
		return this.v;
	  }

	  public virtual void f(float paramFloat1, float paramFloat2)
	  {
		if (!this.f_Conflict.c(paramFloat1, paramFloat2) && Enabled)
		{
		  this.x = false;
		  this.a_Conflict.c();
		}
	  }

	  public virtual aq g()
	  {
		return this.c_Conflict;
	  }

	  public virtual void g(float paramFloat1, float paramFloat2)
	  {
		this.f_Conflict.d(paramFloat1, paramFloat2);
	  }

	  public virtual by get23Point(ScreenPoint paramScreenPoint)
	  {
		aq aq1 = g();
		by by = new by();
		float f = (float)Math.Pow(2.0D, (23.0F - aq1.l()));
		by.x = (long)((paramScreenPoint.X - (this.e_Conflict.getWidth() >> 1)) / aq1.d() * f) + aq1.m();
		by.y = (long)(f * (paramScreenPoint.Y - (this.e_Conflict.getHeight() >> 1)) / aq1.d()) + aq1.n();
		return by;
	  }

	  public virtual Context Context
	  {
		  get
		  {
			return this.o;
		  }
	  }

	  public virtual MapLayer CurrentMapLayer
	  {
		  get
		  {
			return a(this.c_Conflict.g());
		  }
		  set
		  {
			b(value.layerId);
		  }
	  }

	  public virtual Downloader Downloader
	  {
		  get
		  {
			return this.r;
		  }
	  }

	  public virtual GeoPoint getGeoPoint(ScreenPoint paramScreenPoint)
	  {
		return CoordConversion.toLL(get23Point(paramScreenPoint));
	  }

	  public virtual int Height
	  {
		  get
		  {
			return this.e_Conflict.getHeight();
		  }
	  }

	  public virtual System.Collections.IList MapLayerList
	  {
		  get
		  {
			List<MapLayer> arrayList = new ArrayList();
			foreach (MapLayer mapLayer in this.d_Conflict)
			{
			  if (!mapLayer.isService)
			  {
				arrayList.Add(mapLayer);
			  }
			}
			return arrayList;
		  }
	  }

	  public virtual OverlayManager OverlayManager
	  {
		  get
		  {
			return this.f_Conflict;
		  }
	  }

	  public virtual ScreenPoint getScreenPoint(by paramby)
	  {
		by by1;
		by by2 = null;
		if (paramby == null)
		{
		  return (ScreenPoint)by2;
		}
		try
		{
		  float f1 = (float)Math.Pow(2.0D, (23.0F - this.c_Conflict.l()));
		  float f2 = (this.e_Conflict.getWidth() >> 1);
		  float f3 = (float)(this.c_Conflict.m() - paramby.x) * this.c_Conflict.d() / f1;
		  float f4 = (this.e_Conflict.getHeight() >> 1);
		  f1 = (float)(this.c_Conflict.n() - paramby.y) * this.c_Conflict.d() / f1;
		  PointF pointF = this.b_Conflict.c(f2 - f3, f4 - f1);
		  f4 = pointF.x;
		  f3 = pointF.y;
		  ScreenPoint screenPoint = new ScreenPoint();
		  this(f4, f3);
		}
		catch (Exception)
		{
		  by1 = by2;
		}
		return (ScreenPoint)by1;
	  }

	  public virtual ScreenPoint getScreenPoint(GeoPoint paramGeoPoint)
	  {
		GeoPoint geoPoint = null;
		return (ScreenPoint)((paramGeoPoint == null) ? geoPoint : getScreenPoint(CoordConversion.toXY(paramGeoPoint, null)));
	  }

	  public virtual int Width
	  {
		  get
		  {
			return this.e_Conflict.getWidth();
		  }
	  }

	  public virtual float ZoomCurrent
	  {
		  get
		  {
			return this.a_Conflict.j();
		  }
		  set
		  {
			this.a_Conflict.a(value);
		  }
	  }

	  public virtual bj h()
	  {
		return this.s;
	  }

	  public virtual void h(float paramFloat1, float paramFloat2)
	  {
		if (!this.f_Conflict.e(paramFloat1, paramFloat2) && Enabled)
		{
		  PointF pointF = this.b_Conflict.e(paramFloat1, paramFloat2);
		  zoomIn(pointF.x, pointF.y);
		}
	  }

	  public virtual void hideBalloon()
	  {
		if (this.f_Conflict.Balloon.Visible)
		{
		  this.f_Conflict.Balloon.Visible = false;
		  BalloonItem balloonItem = this.f_Conflict.Balloon.BalloonItem;
		  if (balloonItem != null && balloonItem.OnBalloonListener != null)
		  {
			balloonItem.OnBalloonListener.onBalloonHide(balloonItem);
		  }
		  notifyRepaint();
		}
	  }

	  public virtual void i()
	  {
		this.f_Conflict.b();
	  }

	  public virtual bool Enabled
	  {
		  get
		  {
			return this.w;
		  }
		  set
		  {
			this.w = value;
		  }
	  }

	  public virtual bool JamsVisible
	  {
		  get
		  {
			return this.v.a();
		  }
		  set
		  {
			if (this.v.a() != value)
			{
			  if (value)
			  {
				this.v.c(false);
			  }
			  this.v.a(value);
			  notifyRepaint();
			}
		  }
	  }

	  public virtual void j()
	  {
		this.f_Conflict.c();
	  }

	  public virtual void k()
	  {
		if (Enabled)
		{
		  MapController$Map mapController$Map = this.a_Conflict;
		  mapController$Map.a((int)mapController$Map.i_Conflict);
		  mapController$Map.g_Conflict = false;
		  mapController$Map.n.notifyRepaint();
		  mapController$Map.a(new MapEvent(9));
		}
	  }

	  public virtual View l()
	  {
		return this.e_Conflict;
	  }

	  public virtual MapLayer m()
	  {
		// Byte code:
		//   0: aload_0
		//   1: getfield d : Ljava/util/List;
		//   4: astore_1
		//   5: aload_1
		//   6: monitorenter
		//   7: aload_0
		//   8: getfield d : Ljava/util/List;
		//   11: ifnull -> 66
		//   14: aload_0
		//   15: getfield d : Ljava/util/List;
		//   18: invokeinterface size : ()I
		//   23: ifle -> 66
		//   26: aload_0
		//   27: getfield d : Ljava/util/List;
		//   30: invokeinterface iterator : ()Ljava/util/Iterator;
		//   35: astore_2
		//   36: aload_2
		//   37: invokeinterface hasNext : ()Z
		//   42: ifeq -> 66
		//   45: aload_2
		//   46: invokeinterface next : ()Ljava/lang/Object;
		//   51: checkcast ru/yandex/yandexmapkit/map/MapLayer
		//   54: astore_3
		//   55: aload_3
		//   56: getfield isService : Z
		//   59: ifeq -> 36
		//   62: aload_1
		//   63: monitorexit
		//   64: aload_3
		//   65: areturn
		//   66: aload_1
		//   67: monitorexit
		//   68: aconst_null
		//   69: astore_3
		//   70: goto -> 64
		//   73: astore_3
		//   74: aload_1
		//   75: monitorexit
		//   76: aload_3
		//   77: athrow
		// Exception table:
		//   from	to	target	type
		//   7	36	73	finally
		//   36	64	73	finally
	  }

	  public virtual void notifyRepaint()
	  {
		this.z.b();
	  }

	  public virtual DownloadJob onCreateDownloadJob(int paramInt)
	  {
		return null;
	  }

	  public virtual bool onFinishDownload(DownloadJob paramDownloadJob, bool paramBoolean)
	  {
		// Byte code:
		//   0: iconst_0
		//   1: istore_3
		//   2: aload_1
		//   3: ifnull -> 28
		//   6: aload_1
		//   7: getfield a : I
		//   10: tableswitch default -> 28, -2147483648 -> 34
		//   28: iconst_1
		//   29: istore #4
		//   31: iload #4
		//   33: ireturn
		//   34: aload_1
		//   35: getfield e : I
		//   38: sipush #200
		//   41: if_icmpne -> 392
		//   44: aload_1
		//   45: getfield f : [B
		//   48: ifnull -> 392
		//   51: aconst_null
		//   52: astore #5
		//   54: aload #5
		//   56: astore #6
		//   58: new java/io/ByteArrayInputStream
		//   61: astore #7
		//   63: aload #5
		//   65: astore #6
		//   67: aload #7
		//   69: aload_1
		//   70: getfield f : [B
		//   73: invokespecial <init> : ([B)V
		//   76: aload #5
		//   78: astore #6
		//   80: aload_1
		//   81: getfield f : [B
		//   84: invokestatic a : ([B)Z
		//   87: ifeq -> 316
		//   90: aload #5
		//   92: astore #6
		//   94: new java/util/zip/GZIPInputStream
		//   97: astore_1
		//   98: aload #5
		//   100: astore #6
		//   102: aload_1
		//   103: aload #7
		//   105: invokespecial <init> : (Ljava/io/InputStream;)V
		//   108: aload_1
		//   109: astore #6
		//   111: new bi
		//   114: astore #7
		//   116: aload_1
		//   117: astore #6
		//   119: aload #7
		//   121: invokespecial <init> : ()V
		//   124: aload_1
		//   125: astore #6
		//   127: new java/io/InputStreamReader
		//   130: astore #5
		//   132: aload_1
		//   133: astore #6
		//   135: aload #5
		//   137: aload_1
		//   138: ldc_w 'UTF-8'
		//   141: invokespecial <init> : (Ljava/io/InputStream;Ljava/lang/String;)V
		//   144: aload_1
		//   145: astore #6
		//   147: aload #7
		//   149: aload #5
		//   151: invokestatic a : (Lcd;Ljava/io/Reader;)V
		//   154: aload_1
		//   155: astore #6
		//   157: aload #7
		//   159: getfield g : Z
		//   162: ifne -> 284
		//   165: aload_1
		//   166: astore #6
		//   168: invokestatic getUUID : ()Ljava/lang/String;
		//   171: ifnonnull -> 322
		//   174: iconst_1
		//   175: istore #8
		//   177: aload_1
		//   178: astore #6
		//   180: aload #7
		//   182: invokestatic a : (Lbi;)V
		//   185: iload #8
		//   187: ifeq -> 218
		//   190: aload_1
		//   191: astore #6
		//   193: aload_0
		//   194: getfield r : Lru/yandex/yandexmapkit/net/Downloader;
		//   197: aload_0
		//   198: invokestatic a : ()Ljava/lang/String;
		//   201: aload_0
		//   202: getfield e : Landroid/view/View;
		//   205: invokevirtual getWidth : ()I
		//   208: aload_0
		//   209: getfield e : Landroid/view/View;
		//   212: invokevirtual getWidth : ()I
		//   215: invokevirtual a : (Lru/yandex/yandexmapkit/net/DownloadHandler;Ljava/lang/String;II)V
		//   218: aload_1
		//   219: astore #6
		//   221: aload_0
		//   222: invokestatic getUUID : ()Ljava/lang/String;
		//   225: getstatic ru/yandex/yandexmapkit/net/Downloader.b : Lbi;
		//   228: invokevirtual a : (Ljava/lang/String;Lbi;)V
		//   231: aload_1
		//   232: astore #6
		//   234: aload_0
		//   235: getfield r : Lru/yandex/yandexmapkit/net/Downloader;
		//   238: astore #5
		//   240: aload_1
		//   241: astore #6
		//   243: invokestatic getUUID : ()Ljava/lang/String;
		//   246: ifnonnull -> 328
		//   249: iconst_1
		//   250: istore #8
		//   252: aload_1
		//   253: astore #6
		//   255: aload #5
		//   257: iload #8
		//   259: invokevirtual a : (I)V
		//   262: aload_1
		//   263: astore #6
		//   265: aload_0
		//   266: aload #7
		//   268: invokespecial a : (Lbi;)V
		//   271: aload_1
		//   272: astore #6
		//   274: aload_0
		//   275: getfield v : Law;
		//   278: iconst_0
		//   279: invokevirtual b : (Z)V
		//   282: iconst_1
		//   283: istore_3
		//   284: aload_1
		//   285: invokevirtual close : ()V
		//   288: iload_3
		//   289: istore #4
		//   291: iload_3
		//   292: ifne -> 31
		//   295: iload_3
		//   296: istore #4
		//   298: iload_2
		//   299: ifeq -> 31
		//   302: aload_0
		//   303: getfield r : Lru/yandex/yandexmapkit/net/Downloader;
		//   306: iconst_1
		//   307: invokevirtual a : (I)V
		//   310: iload_3
		//   311: istore #4
		//   313: goto -> 31
		//   316: aload #7
		//   318: astore_1
		//   319: goto -> 108
		//   322: iconst_0
		//   323: istore #8
		//   325: goto -> 177
		//   328: iconst_2
		//   329: istore #8
		//   331: goto -> 252
		//   334: astore_1
		//   335: goto -> 288
		//   338: astore_1
		//   339: aload #6
		//   341: ifnull -> 392
		//   344: aload #6
		//   346: invokevirtual close : ()V
		//   349: iconst_0
		//   350: istore_3
		//   351: goto -> 288
		//   354: astore_1
		//   355: iconst_0
		//   356: istore_3
		//   357: goto -> 288
		//   360: astore_1
		//   361: aconst_null
		//   362: astore #6
		//   364: aload #6
		//   366: ifnull -> 374
		//   369: aload #6
		//   371: invokevirtual close : ()V
		//   374: aload_1
		//   375: athrow
		//   376: astore #6
		//   378: goto -> 374
		//   381: astore #7
		//   383: aload_1
		//   384: astore #6
		//   386: aload #7
		//   388: astore_1
		//   389: goto -> 364
		//   392: iconst_0
		//   393: istore_3
		//   394: goto -> 288
		// Exception table:
		//   from	to	target	type
		//   58	63	338	java/lang/Throwable
		//   58	63	360	finally
		//   67	76	338	java/lang/Throwable
		//   67	76	360	finally
		//   80	90	338	java/lang/Throwable
		//   80	90	360	finally
		//   94	98	338	java/lang/Throwable
		//   94	98	360	finally
		//   102	108	338	java/lang/Throwable
		//   102	108	360	finally
		//   111	116	338	java/lang/Throwable
		//   111	116	381	finally
		//   119	124	338	java/lang/Throwable
		//   119	124	381	finally
		//   127	132	338	java/lang/Throwable
		//   127	132	381	finally
		//   135	144	338	java/lang/Throwable
		//   135	144	381	finally
		//   147	154	338	java/lang/Throwable
		//   147	154	381	finally
		//   157	165	338	java/lang/Throwable
		//   157	165	381	finally
		//   168	174	338	java/lang/Throwable
		//   168	174	381	finally
		//   180	185	338	java/lang/Throwable
		//   180	185	381	finally
		//   193	218	338	java/lang/Throwable
		//   193	218	381	finally
		//   221	231	338	java/lang/Throwable
		//   221	231	381	finally
		//   234	240	338	java/lang/Throwable
		//   234	240	381	finally
		//   243	249	338	java/lang/Throwable
		//   243	249	381	finally
		//   255	262	338	java/lang/Throwable
		//   255	262	381	finally
		//   265	271	338	java/lang/Throwable
		//   265	271	381	finally
		//   274	282	338	java/lang/Throwable
		//   274	282	381	finally
		//   284	288	334	java/io/IOException
		//   344	349	354	java/io/IOException
		//   369	374	376	java/io/IOException
	  }

	  public virtual void onStartDownload(int paramInt)
	  {
	  }

	  public virtual void removeMapListener(OnMapListener paramOnMapListener)
	  {
		this.a_Conflict.b(paramOnMapListener);
	  }




	  public virtual GeoPoint PositionAnimationTo
	  {
		  set
		  {
			a(CoordConversion.toXY(value, null));
		  }
	  }

	  public virtual void setPositionAnimationTo(GeoPoint paramGeoPoint, int paramInt)
	  {
		a(CoordConversion.toXY(paramGeoPoint, null), paramInt);
	  }

	  public virtual GeoPoint PositionNoAnimationTo
	  {
		  set
		  {
			b(CoordConversion.toXY(value, null));
		  }
	  }

	  public virtual void setPositionNoAnimationTo(GeoPoint paramGeoPoint, int paramInt)
	  {
		b(CoordConversion.toXY(paramGeoPoint, null), paramInt);
	  }


	  public virtual void showBalloon(BalloonItem paramBalloonItem)
	  {
		this.f_Conflict.Balloon.Visible = true;
		this.f_Conflict.Balloon.BalloonItem = paramBalloonItem;
		if (paramBalloonItem != null && paramBalloonItem.OnBalloonListener != null)
		{
		  paramBalloonItem.OnBalloonListener.onBalloonShow(paramBalloonItem);
		}
		notifyRepaint();
	  }

	  public virtual void zoomIn()
	  {
		zoomIn((this.e_Conflict.getWidth() / 2), (this.e_Conflict.getHeight() / 2));
	  }

	  public virtual void zoomIn(float paramFloat1, float paramFloat2)
	  {
		this.a_Conflict.b(paramFloat1, paramFloat2);
	  }

	  public virtual void zoomOut()
	  {
		zoomOut((this.e_Conflict.getWidth() / 2), (this.e_Conflict.getHeight() / 2));
	  }

	  public virtual void zoomOut(float paramFloat1, float paramFloat2)
	  {
		this.a_Conflict.c(paramFloat1, paramFloat2);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\MapController.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}