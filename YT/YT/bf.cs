using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

using Context = android.content.Context;
using Build = android.os.Build;
using Log = android.util.Log;
using MapController = ru.yandex.yandexmapkit.MapController;
using DownloadHandler = ru.yandex.yandexmapkit.net.DownloadHandler;
using DownloadJob = ru.yandex.yandexmapkit.net.DownloadJob;
using Downloader = ru.yandex.yandexmapkit.net.Downloader;
using MyLocationItem = ru.yandex.yandexmapkit.overlay.location.MyLocationItem;
using MyLocationOverlay = ru.yandex.yandexmapkit.overlay.location.MyLocationOverlay;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class bf : Runnable, DownloadHandler
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly sbyte[] a_Conflict = "1".getBytes();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly string[] b_Conflict = new string[] {"data", "uuid", "packetid", "compressed", "oauth_token"};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly string[] c_Conflict = new string[] {"application/gzip", "text/plain", "text/plain", "text/plain", "text/plain"};

  private static readonly string[] d = new string[] {"data", "uuid", "gzip"};

  private static readonly string[] e = new string[] {"application/gzip", "text/plain", "text/plain"};

  private static readonly sbyte[] f = "A35D8D69227C3E57807B03D6BDCE7B89F6A1229005856BD03744ACAC8CF0ADB4C6C96F59ECD465B37E051ACA63309CF038AF527BAA6F1F2E5E1B71E6E0B46402DD30BA3DFD2DC20E5103".getBytes();

  private static string g;

  private static string h;

  private static string i;

  private static sbyte[] j;

  private static ar k;

  private Context A;

  private GeoPoint B;

  private float[] l;

  private long[] m;

  private int n;

  private readonly StringBuilder o = new StringBuilder(32768);

  private long p;

  private long q;

  private bb r;

  private bool s;

  private long t;

  private long u;

  private StringBuilder v;

  private Thread w;

  private bool x;

  private long y;

  private MapController z;

  static bf()
  {
	new object();
  }

  public bf(MapController paramMapController)
  {
	new LinkedList();
	new ArrayList();
	this.y = 600000L;
	this.z = paramMapController;
	this.A = paramMapController.Context;
	this.r = new bb(this.A);
	this.l = new float[100];
	this.m = new long[100];
	this.n = -1;
	this.v = new StringBuilder(300);
	long l = DateTimeHelper.CurrentUnixTimeMillis();
	this.t = l;
	this.u = l;
	this.p = l;
	this.q = l;
	this.s = false;
  }

  private void b()
  {
	this.o.Length = 0;
	this.o.Append("<?xml version=\"1.0\" encoding=\"utf8\" ?><traffic_collect>");
  }

  private void c()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: getstatic bf.k : Lar;
	//   5: ifnull -> 266
	//   8: getstatic bf.k : Lar;
	//   11: invokevirtual d : ()Z
	//   14: ifeq -> 266
	//   17: getstatic bf.k : Lar;
	//   20: invokevirtual c : ()Ljava/lang/String;
	//   23: ifnull -> 266
	//   26: getstatic bf.k : Lar;
	//   29: invokevirtual c : ()Ljava/lang/String;
	//   32: invokevirtual length : ()I
	//   35: ifle -> 266
	//   38: invokestatic currentTimeMillis : ()J
	//   41: lstore_1
	//   42: aload_0
	//   43: getfield z : Lru/yandex/yandexmapkit/MapController;
	//   46: invokevirtual getOverlayManager : ()Lru/yandex/yandexmapkit/OverlayManager;
	//   49: invokevirtual getMyLocation : ()Lru/yandex/yandexmapkit/overlay/location/MyLocationOverlay;
	//   52: astore_3
	//   53: aload_3
	//   54: ifnull -> 157
	//   57: aload_3
	//   58: invokevirtual isEnabled : ()Z
	//   61: ifeq -> 157
	//   64: aload_3
	//   65: invokevirtual getMyLocationItem : ()Lru/yandex/yandexmapkit/overlay/location/MyLocationItem;
	//   68: astore_3
	//   69: aload_3
	//   70: ifnull -> 157
	//   73: aload_3
	//   74: invokevirtual getType : ()I
	//   77: iconst_1
	//   78: if_icmpne -> 157
	//   81: aload_3
	//   82: invokevirtual getBearing : ()F
	//   85: f2i
	//   86: istore #4
	//   88: aload_3
	//   89: invokevirtual getGeoPoint : ()Lru/yandex/yandexmapkit/utils/GeoPoint;
	//   92: astore #5
	//   94: aload_0
	//   95: getfield r : Lbb;
	//   98: astore #6
	//   100: aload #5
	//   102: invokevirtual getLat : ()D
	//   105: invokestatic a : (D)Ljava/lang/String;
	//   108: astore #7
	//   110: aload #5
	//   112: invokevirtual getLon : ()D
	//   115: invokestatic a : (D)Ljava/lang/String;
	//   118: astore #5
	//   120: aload_3
	//   121: invokevirtual getSpeed : ()F
	//   124: fstore #8
	//   126: iload #4
	//   128: iconst_m1
	//   129: if_icmpeq -> 269
	//   132: iload #4
	//   134: invokestatic valueOf : (I)Ljava/lang/Integer;
	//   137: astore_3
	//   138: aload #6
	//   140: aload #7
	//   142: aload #5
	//   144: fload #8
	//   146: invokestatic valueOf : (F)Ljava/lang/String;
	//   149: aload_3
	//   150: invokestatic valueOf : (Ljava/lang/Object;)Ljava/lang/String;
	//   153: lload_1
	//   154: invokevirtual a : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V
	//   157: lload_1
	//   158: aload_0
	//   159: getfield u : J
	//   162: lsub
	//   163: getstatic bf.k : Lar;
	//   166: invokevirtual e : ()I
	//   169: sipush #1000
	//   172: imul
	//   173: i2l
	//   174: lcmp
	//   175: ifle -> 276
	//   178: iconst_1
	//   179: istore #4
	//   181: iload #4
	//   183: ifeq -> 206
	//   186: aload_0
	//   187: getfield r : Lbb;
	//   190: ldc 'normal'
	//   192: lload_1
	//   193: invokevirtual a : (Ljava/lang/String;J)V
	//   196: aload_0
	//   197: lload_1
	//   198: putfield u : J
	//   201: aload_0
	//   202: iconst_1
	//   203: putfield s : Z
	//   206: lload_1
	//   207: aload_0
	//   208: getfield t : J
	//   211: lsub
	//   212: getstatic bf.k : Lar;
	//   215: invokevirtual f : ()I
	//   218: sipush #1000
	//   221: imul
	//   222: i2l
	//   223: lcmp
	//   224: ifle -> 282
	//   227: iconst_1
	//   228: istore #4
	//   230: iload #4
	//   232: ifeq -> 266
	//   235: aload_0
	//   236: getfield s : Z
	//   239: ifeq -> 266
	//   242: aload_0
	//   243: getfield z : Lru/yandex/yandexmapkit/MapController;
	//   246: invokevirtual getDownloader : ()Lru/yandex/yandexmapkit/net/Downloader;
	//   249: aload_0
	//   250: iconst_1
	//   251: invokevirtual downloadProccess : (Lru/yandex/yandexmapkit/net/DownloadHandler;I)V
	//   254: aload_0
	//   255: getfield r : Lbb;
	//   258: invokevirtual c : ()V
	//   261: aload_0
	//   262: lload_1
	//   263: putfield t : J
	//   266: aload_0
	//   267: monitorexit
	//   268: return
	//   269: ldc_w ''
	//   272: astore_3
	//   273: goto -> 138
	//   276: iconst_0
	//   277: istore #4
	//   279: goto -> 181
	//   282: iconst_0
	//   283: istore #4
	//   285: goto -> 230
	//   288: astore_3
	//   289: aload_0
	//   290: monitorexit
	//   291: aload_3
	//   292: athrow
	// Exception table:
	//   from	to	target	type
	//   2	53	288	finally
	//   57	69	288	finally
	//   73	126	288	finally
	//   132	138	288	finally
	//   138	157	288	finally
	//   157	178	288	finally
	//   186	206	288	finally
	//   206	227	288	finally
	//   235	266	288	finally
  }

  public Thread a()
  {
	this.x = false;
	this.r.a();
	return this.w;
  }

  public void a(ar paramar)
  {
	if (this.w == null || !this.w.IsAlive)
	{
	  this.w = new Thread(this);
	  this.w.setName("ymm-jams-sender");
	  this.x = true;
	  this.w.Start();
	}
	k = paramar;
	j = paramar.a().ToString().GetBytes();
	g = paramar.a();
	h = paramar.b();
  }

  public DownloadJob onCreateDownloadJob(int paramInt)
  {
	if (paramInt == 2)
	{
	  try
	  {
		this.o.Append("</traffic_collect>");
		sbyte[] arrayOfByte2 = this.o.ToString().GetBytes();
		MemoryStream byteArrayOutputStream = new MemoryStream();
		this();
		GZIPOutputStream gZIPOutputStream = new GZIPOutputStream();
		this(byteArrayOutputStream);
		gZIPOutputStream.write(arrayOfByte2, 0, arrayOfByte2.Length);
		gZIPOutputStream.finish();
		try
		{
		  byteArrayOutputStream.Close();
		}
		catch (Exception)
		{
		}
		sbyte[] arrayOfByte3 = byteArrayOutputStream.toByteArray();
		this.v.Length = 0;
		this.v.Append(k.h());
		this.v.Append("/ymm_collect/2.x/?uuid=").Append(g);
		this.v.Append("&packetid=");
		arrayOfByte2 = new sbyte[arrayOfByte3.Length];
		Array.Copy(arrayOfByte3, 0, arrayOfByte2, 0, arrayOfByte2.Length);
		string str1 = Convert.ToString(Downloader.a(arrayOfByte2, j));
		this.v.Append(str1);
		this.v.Append("&compressed=1");
		sbyte[] arrayOfByte1 = Downloader.a(b_Conflict, c_Conflict, new sbyte[][] {arrayOfByte3, j, str1.GetBytes(), a_Conflict, i.GetBytes()});
		DownloadJob downloadJob = new DownloadJob();
		string str2 = this.v.ToString();
		long? long_ = new Long();
		this(DateTimeHelper.CurrentUnixTimeMillis());
		this(2, str2, 1, arrayOfByte1, this, long_, 5000L);
		downloadJob.a(true);
		return downloadJob;
	  }
	  catch (Exception)
	  {
	  }
	}
	else if (paramInt == 1)
	{
	  DownloadJob downloadJob;
	  try
	  {
		StringBuilder stringBuilder = new StringBuilder();
		this(32768);
		stringBuilder.Append("<?xml version=\"1.0\" encoding=\"windows-1251\" ?>");
		stringBuilder.Append("<wifipool ");
		stringBuilder.Append("uuid=\"").Append(g).Append("\" ");
		stringBuilder.Append("app_version=\"").Append(br.a()).Append("\" ");
		stringBuilder.Append("app_platform=\"").Append("android").Append("\" ");
		if (!"-1".Equals(h))
		{
		  stringBuilder.Append("clid=\"").Append(h).Append("\" ");
		}
		stringBuilder.Append("manufacturer=\"").Append(b.a(b.a())).Append("\" ");
		stringBuilder.Append("model=\"").Append(b.a(Build.MODEL)).Append("\" ");
		stringBuilder.Append(">");
		IEnumerator<bc> iterator = this.r.b().GetEnumerator();
		while (iterator.MoveNext())
		{
		  stringBuilder.Append(((bc)iterator.Current).a());
		}
	  }
	  catch (IOException null)
	  {
		return null;
	  }
	  SYNTHETIC_LOCAL_VARIABLE_3.append("</wifipool>");
	  sbyte[] arrayOfByte = SYNTHETIC_LOCAL_VARIABLE_3.ToString().GetBytes();
	  MemoryStream byteArrayOutputStream = new MemoryStream();
	  this();
	  GZIPOutputStream gZIPOutputStream = new GZIPOutputStream();
	  this(byteArrayOutputStream);
	  gZIPOutputStream.write(arrayOfByte, 0, arrayOfByte.Length);
	  gZIPOutputStream.finish();
	  try
	  {
		byteArrayOutputStream.Close();
		this.v.Length = 0;
		this.v.Append(k.c());
		this.v.Append("/wifipool?uuid=").Append(g);
		this.v.Append("&app_version=").Append(br.a());
		this.v.Append("&app_platform=android");
		if (!"-1".Equals(h))
		{
		  this.v.Append("&clid=").Append(h);
		}
		this.v.Append("&ver=").Append("1");
		this.v.Append("&manufacturer=").Append(b.a(b.a()));
		this.v.Append("&model=").Append(b.a(Build.MODEL));
		SimpleDateFormat simpleDateFormat = new SimpleDateFormat();
		this("ddMMyyyy:HHmmss");
		simpleDateFormat.setTimeZone(TimeZone.getTimeZone("UTC"));
		string str1 = simpleDateFormat.format(Convert.ToInt64(DateTimeHelper.CurrentUnixTimeMillis()));
		this.v.Append("&sendtime=").Append(str1);
		this.v.Append("&gzip=1");
		sbyte[] arrayOfByte1 = byteArrayOutputStream.toByteArray();
		Downloader.a(arrayOfByte1, f);
		arrayOfByte = Downloader.a(d, e, new sbyte[][] {arrayOfByte1, j, a_Conflict});
		this.t = DateTimeHelper.CurrentUnixTimeMillis();
		this.s = false;
		downloadJob = new DownloadJob();
		string str2 = this.v.ToString();
		long? long_ = new Long();
		this(DateTimeHelper.CurrentUnixTimeMillis());
		this(1, str2, 1, arrayOfByte, this, long_, 5000L);
		downloadJob.a(true);
	  }
	  catch (IOException)
	  {
	  }
	  return downloadJob;
	}
	return null;
  }

  public bool onFinishDownload(DownloadJob paramDownloadJob, bool paramBoolean)
  {
	paramDownloadJob.h = 0;
	long l1 = DateTimeHelper.CurrentUnixTimeMillis();
	long l2 = ((long?)paramDownloadJob.i).Value;
	switch (paramDownloadJob.a_Conflict)
	{
	  default:
		return true;
	  case 2:
		if (k != null)
		{
		  this.y = (k.l() * 1000);
		}
		return (paramDownloadJob.e == 200 || l1 - l2 > this.y);
	  case 1:
		break;
	}
	if (k != null)
	{
	  this.y = (k.g() * 1000);
	}
	return (paramDownloadJob.e == 200 || l1 - l2 > this.y);
  }

  public void onStartDownload(int paramInt)
  {
  }

  public void run()
  {
	while (this.x)
	{
	  try
	  {
		Thread.Sleep(2000L);
		MyLocationOverlay myLocationOverlay = this.z.OverlayManager.MyLocation;
		if (myLocationOverlay != null && myLocationOverlay.Enabled)
		{
		  MyLocationItem myLocationItem = myLocationOverlay.MyLocationItem;
		  if (myLocationItem != null && myLocationItem.Type == 1 && !myLocationItem.GeoPoint.Equals(this.B))
		  {
			this.B = myLocationItem.GeoPoint;
			this.n++;
			if (this.n >= this.l.Length)
			{
			  this.n = 0;
			}
			float f = myLocationItem.Speed;
			long l = myLocationItem.Time;
			this.l[this.n] = f;
			this.m[this.n] = l;
			if (k != null && k.i() && !string.ReferenceEquals(k.h(), null) && k.h().Length > 0)
			{
			  l = DateTimeHelper.CurrentUnixTimeMillis();
			  if (l - this.q >= (k.j() * 1000))
			  {
				i = 1;
			  }
			  else
			  {
				i = 0;
			  }
			  if (i)
			  {
				GeoPoint geoPoint = myLocationItem.GeoPoint;
				if (this.o.Length <= 0)
				{
				  b();
				}
				i = this.n;
				int j = this.l.Length;
				f = 0.0F;
				long l2 = this.m[i];
				int k = 0;
				sbyte b = 0;
				while (k < j && l2 - this.m[i] <= 20000L)
				{
				  float f1 = this.l[i];
				  int m = i - 1;
				  i = m;
				  if (m < 0)
				  {
					i = j - 1;
				  }
				  k++;
				  b++;
				  f = f1 + f;
				}
				if (b == 0)
				{
				  i = 0;
				}
				else
				{
				  i = (int)(f / b);
				}
				k = (int)myLocationItem.Bearing;
				this.o.Append("<point lat=\"").Append(b.a(geoPoint.Lat)).Append("\" lon=\"").Append(b.a(geoPoint.Lon)).Append("\" avg_speed=\"").Append(i);
				if (k != -1)
				{
				  this.o.Append("\" direction=\"").Append(k);
				}
				SimpleDateFormat simpleDateFormat = new SimpleDateFormat();
				this("ddMMyyyy:HHmmss");
				simpleDateFormat.setTimeZone(TimeZone.getTimeZone("UTC"));
				string str = simpleDateFormat.format(Convert.ToInt64(myLocationItem.Time));
				this.o.Append("\" time=\"").Append(str).Append("\" />");
				this.q = l;
			  }
			  long l1 = this.p;
			  int i = k.k();
			  if (l - l1 >= (i * 1000))
			  {
				i = 1;
			  }
			  else
			  {
				i = 0;
			  }
			  if (i != 0)
			  {
				try
				{
				  this.z.Downloader.downloadProccess(this, 2);
				  b();
				}
				catch (IOException iOException)
				{
				  StringBuilder stringBuilder = new StringBuilder();
				  this();
				  Log.w("JAMS_SERVICE", stringBuilder.Append("ERR send jams ").Append(iOException).ToString());
				  b();
				}
				finally
				{
				  b();
				  this.p = l;
				}
				continue;
			  }
			}
		  }
		}
		c();
	  }
	  catch (Exception)
	  {
	  }
	}
	this.x = false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */