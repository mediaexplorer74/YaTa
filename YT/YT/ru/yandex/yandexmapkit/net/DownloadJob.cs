using System;

namespace ru.yandex.yandexmapkit.net
{
	public sealed class DownloadJob
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public int a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public string b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public int c_Conflict;

	  public sbyte[] d;

	  public int e;

	  public sbyte[] f;

	  public DownloadHandler g;

	  public int h;

	  public readonly object i;

	  public long j;

	  public long k;

	  private int l;

	  private bool m = false;

	  public DownloadJob(int paramInt1, string paramString, int paramInt2, sbyte[] paramArrayOfbyte, DownloadHandler paramDownloadHandler, object paramObject, long paramLong)
	  {
		this.a_Conflict = paramInt1;
		this.b_Conflict = paramString;
		this.c_Conflict = paramInt2;
		this.d = paramArrayOfbyte;
		this.g = paramDownloadHandler;
		this.i = paramObject;
		this.h = 0;
		this.k = Math.Max(500L, paramLong);
		this.l = 0;
	  }

	  internal DownloadJob(int paramInt, DownloadHandler paramDownloadHandler) : this(paramInt, null, 0, null, paramDownloadHandler, null, 1000L)
	  {
	  }

	  public void a(bool paramBoolean)
	  {
		this.m = paramBoolean;
	  }

	  public bool a()
	  {
		return this.m;
	  }

	  public bool b()
	  {
		bool bool1 = true;
		this.h++;
		bool bool2 = bool1;
		if (this.g != null)
		{
		  try
		  {
			DownloadHandler downloadHandler = this.g;
			if (this.h >= 4)
			{
			  bool2 = true;
			}
			else
			{
			  bool2 = false;
			}
			bool2 = downloadHandler.onFinishDownload(this, bool2);
		  }
		  catch (Exception)
		  {
			bool2 = bool1;
		  }
		}
		return bool2;
	  }

	  public void c()
	  {
		if (this.g != null)
		{
		  try
		  {
			this.g.onStartDownload(this.a_Conflict);
		  }
		  catch (Exception)
		  {
		  }
		}
	  }

	  public override bool Equals(object paramObject)
	  {
		return (paramObject != null && this.GetType() == paramObject.GetType() && this.a_Conflict == ((DownloadJob)paramObject).a_Conflict && this.g.Equals(((DownloadJob)paramObject).g));
	  }

	  public int Priority
	  {
		  get
		  {
			return this.l;
		  }
		  set
		  {
			this.l = value;
		  }
	  }

	  public override int GetHashCode()
	  {
		int i = this.a_Conflict;
		if (!string.ReferenceEquals(this.b_Conflict, null))
		{
		  int j = this.b_Conflict.GetHashCode();
		  return j + (i + 115) * 23;
		}
		sbyte b = 0;
		return b + (i + 115) * 23;
	  }

	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\net\DownloadJob.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}