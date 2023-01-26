using System;
using System.IO;
using System.Text;

namespace ru.yandex.yandexmapkit.net
{
	using af;
	using Build = android.os.Build;
	using b;
	using bh;
	using bi;
	using br;
	using GeoCodeListener = ru.yandex.yandexmapkit.map.GeoCodeListener;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public sealed class Downloader
	{
		private bool InstanceFieldsInitialized = false;

		private void InitializeInstanceFields()
		{
			f_Conflict = new bh(this);
		}

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public static readonly sbyte[] a_Conflict = new sbyte[] {101, 100, 103, 101, 95, 104, 101, 114, 101};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public static bi b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  protected internal static int c_Conflict = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static string d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static sbyte[] e_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static string g_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bh f_Conflict;

	  public Downloader() : this(null)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
	  }

	  public Downloader(string paramString)
	  {
		  if (!InstanceFieldsInitialized)
		  {
			  InitializeInstanceFields();
			  InstanceFieldsInitialized = true;
		  }
		g_Conflict = paramString;
	  }

	  public static long a(sbyte[] paramArrayOfbyte1, sbyte[] paramArrayOfbyte2)
	  {
		int i = paramArrayOfbyte1.Length;
		int j = paramArrayOfbyte2.Length;
		sbyte b1 = 0;
		for (sbyte b2 = 0; b2 < i; b2++)
		{
		  paramArrayOfbyte1[b2] = (sbyte)(sbyte)(paramArrayOfbyte1[b2] ^ paramArrayOfbyte2[b1]);
		  if (b1 == j - 1)
		  {
			b1 = 0;
		  }
		  else
		  {
			b1++;
		  }
		}
		return b.b(paramArrayOfbyte1);
	  }

	  public static void a(bi parambi)
	  {
		if (parambi != null)
		{
		  b_Conflict = parambi;
		  if (string.ReferenceEquals(UUID, null))
		  {
			a(parambi.d);
		  }
		}
	  }

	  public static void a(string paramString)
	  {
		if (!string.ReferenceEquals(paramString, null) && paramString.Trim().Length > 4)
		{
		  paramString = paramString.Trim();
		  d_Conflict = paramString;
		  e_Conflict = paramString.GetBytes();
		}
	  }

	  public static sbyte[] a(string[] paramArrayOfString1, string[] paramArrayOfString2, sbyte[][] paramArrayOfbyte)
	  {
		string[] arrayOfString1;
		string[] arrayOfString2 = null;
		if (paramArrayOfbyte == null)
		{
		  return (sbyte[])arrayOfString2;
		}
		try
		{
		  MemoryStream byteArrayOutputStream = new MemoryStream();
		  this();
		  for (sbyte b = 0; b < paramArrayOfString1.Length; b++)
		  {
			byteArrayOutputStream.WriteByte(45);
			byteArrayOutputStream.WriteByte(45);
			byteArrayOutputStream.Write(a_Conflict, 0, a_Conflict.Length);
			byteArrayOutputStream.WriteByte("\r\nContent-Disposition: form-data; name=\"".GetBytes());
			byteArrayOutputStream.WriteByte(paramArrayOfString1[b].GetBytes());
			byteArrayOutputStream.WriteByte(34);
			if (paramArrayOfString2 != null && !paramArrayOfString2[b].Equals(""))
			{
			  byteArrayOutputStream.WriteByte("\r\nContent-Type: ".GetBytes());
			  byteArrayOutputStream.WriteByte(paramArrayOfString2[b].GetBytes());
			}
			byteArrayOutputStream.WriteByte("\r\n\r\n".GetBytes());
			byteArrayOutputStream.WriteByte(paramArrayOfbyte[b]);
			byteArrayOutputStream.WriteByte("\r\n".GetBytes());
		  }
		  byteArrayOutputStream.WriteByte(45);
		  byteArrayOutputStream.WriteByte(45);
		  byteArrayOutputStream.Write(a_Conflict, 0, a_Conflict.Length);
		  byteArrayOutputStream.WriteByte("--\r\n".GetBytes());
		  sbyte[] arrayOfByte = byteArrayOutputStream.toByteArray();
		}
		catch (Exception)
		{
		  arrayOfString1 = arrayOfString2;
		}
		return (sbyte[])arrayOfString1;
	  }

	  public static bool b()
	  {
		return (b_Conflict != null && !b.g);
	  }

	  public static string c()
	  {
		return getServer(1);
	  }

	  public static bi d()
	  {
		return b_Conflict;
	  }

	  public static int e()
	  {
		return c_Conflict;
	  }

	  public static string g()
	  {
		return g_Conflict;
	  }

	  public static string getServer(int paramInt)
	  {
		if (b_Conflict != null)
		{
		  string str = (string)b.e[bi.a_Conflict[paramInt]];
		  if (!string.ReferenceEquals(str, null) && str.Length > 4)
		  {
			string str1 = str;
			if (!string.ReferenceEquals(g_Conflict, null))
			{
			  str1 = str + "/mapkit";
			}
			return str1;
		  }
		  str = (string)b.e[bi.a_Conflict[0]];
		  if (!string.ReferenceEquals(str, null) && str.Length > 4)
		  {
			string str1 = str;
			if (!string.ReferenceEquals(g_Conflict, null))
			{
			  str1 = str + "/mapkit";
			}
			return str1;
		  }
		}
		return br.b();
	  }

	  public static string UUID
	  {
		  get
		  {
			return d_Conflict;
		  }
	  }

	  public static sbyte[] UUIDBytes
	  {
		  get
		  {
			return e_Conflict;
		  }
	  }

	  public void a()
	  {
		this.f_Conflict.a();
	  }

	  public void a(int paramInt)
	  {
		c_Conflict = paramInt;
		bh bh1 = this.f_Conflict;
		if (bh1 != null)
		{
		  bh1.c();
		}
	  }

	  public void a(DownloadHandler paramDownloadHandler, string paramString, int paramInt1, int paramInt2)
	  {
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(br.b());
		stringBuilder.Append("/startup/?");
		if (string.ReferenceEquals(g_Conflict, null))
		{
		  stringBuilder.Append("app_version=");
		}
		else
		{
		  stringBuilder.Append("ymk_version=");
		}
		stringBuilder.Append(paramString);
		stringBuilder.Append("&app_platform=android&screen_w=");
		stringBuilder.Append(paramInt1);
		stringBuilder.Append("&screen_h=");
		stringBuilder.Append(paramInt2);
		if (!string.ReferenceEquals(d_Conflict, null))
		{
		  stringBuilder.Append("&uuid=");
		  stringBuilder.Append(d_Conflict);
		}
		stringBuilder.Append("&manufacturer=");
		stringBuilder.Append(b.a(b.a()));
		stringBuilder.Append("&model=");
		stringBuilder.Append(b.a(Build.MODEL));
		stringBuilder.Append("&os_version=");
		stringBuilder.Append(b.a(Build.VERSION.RELEASE));
		stringBuilder.Append("&utf");
		bh bh1 = this.f_Conflict;
		if (bh1 != null)
		{
		  bh1.a(new DownloadJob(-2147483648, stringBuilder.ToString(), 0, null, paramDownloadHandler, null, 4000L));
		  return;
		}
		throw new Exception();
	  }

	  public void downloadProccess(DownloadHandler paramDownloadHandler, int paramInt)
	  {
		DownloadJob downloadJob;
		bh bh1 = this.f_Conflict;
		if (bh1 != null && c_Conflict != 0)
		{
		  downloadJob = paramDownloadHandler.onCreateDownloadJob(paramInt);
		  if (downloadJob != null)
		  {
			bh1.a(downloadJob);
			bh1.c();
		  }
		  return;
		}
		downloadJob.onFinishDownload(new DownloadJob(paramInt, (DownloadHandler)downloadJob), true);
	  }

	  public void f()
	  {
		if (this.f_Conflict != null)
		{
		  this.f_Conflict.b();
		}
	  }

	  public void getGeoCode(GeoCodeListener paramGeoCodeListener, GeoPoint paramGeoPoint)
	  {
		downloadProccess((DownloadHandler)new af(paramGeoCodeListener, paramGeoPoint), 1);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\net\Downloader.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}