using System;

using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class ax : cd
{
  private static int u = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public int a_Conflict = -1;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public readonly int b_Conflict;

  public long c;

  public sbyte d;

  public int e;

  public int f;

  public int g;

  public ba[] h;

  public az i;

  public ay[] j;

  public readonly int k;

  public readonly int l;

  public readonly int m;

  public readonly int n;

  private int o;

  private float p;

  private int q;

  private int r;

  private int s;

  private int t;

  private long v;

  public ax(int paramInt1, int paramInt2, int paramInt3, int paramInt4, int paramInt5)
  {
	this.d = (sbyte)(sbyte)paramInt1;
	this.k = paramInt2;
	this.l = paramInt3;
	this.m = paramInt4;
	this.n = paramInt5;
	paramInt1 = u;
	u = paramInt1 + 1;
	this.b_Conflict = paramInt1;
	this.h = new ba[50];
	this.j = new ay[20];
	long l = DateTimeHelper.CurrentUnixTimeMillis();
	this.c = l;
	this.v = l;
  }

  public override void a(string paramString)
  {
	if (paramString.Equals("meta"))
	{
	  this.t = 0;
	  this.i = new az(this.v);
	  return;
	}
	if (paramString.Equals("jam_informers"))
	{
	  this.t = 0;
	}
  }

  public override void a(string paramString, cc paramcc)
  {
	this.s = 0;
	if (this.t == 2)
	{
	  if (paramString.Equals("track"))
	  {
		this.s = 9;
		try
		{
		  this.o = int.Parse(paramcc.a("style_id"));
		}
		catch (Exception)
		{
		}
		paramString = paramcc.a("avg_speed");
		if (!string.ReferenceEquals(paramString, null) && !paramString.Equals(""))
		{
		  try
		  {
			this.p = float.Parse(paramString);
			paramString = paramcc.a("street_category");
		  }
		  catch (System.FormatException)
		  {
			this.p = -1.0F;
			string str = paramcc.a("street_category");
		  }
		}
		else
		{
		  this.p = -1.0F;
		  paramString = paramcc.a("street_category");
		}
	  }
	  else
	  {
		return;
	  }
	  this.q = 1;
	  return;
	}
	if (paramString.Equals("tracks"))
	{
	  this.t = 2;
	  this.s = 2;
	  return;
	}
	if (paramString.Equals("tjam_tracks"))
	{
	  try
	  {
		paramString = paramcc.a("error");
		if (!string.ReferenceEquals(paramString, null) && paramString.Trim().Length > 0)
		{
		  this.a_Conflict = int.Parse(paramString);
		  return;
		}
	  }
	  catch (Exception)
	  {
		return;
	  }
	  this.a_Conflict = -1;
	  return;
	}
	if (exception.Equals("meta"))
	{
	  this.t = 1;
	  this.s = 1;
	  return;
	}
	if (this.t == 1)
	{
	  if (exception.Equals("time"))
	  {
		this.s = 3;
		return;
	  }
	  if (exception.Equals("next_update"))
	  {
		this.s = 4;
		return;
	  }
	  if (exception.Equals("informer_expire_in"))
	  {
		this.s = 5;
		return;
	  }
	  if (exception.Equals("jams_expire_in"))
	  {
		this.s = 6;
		return;
	  }
	  if (exception.Equals("retry_timeout"))
	  {
		this.s = 7;
		return;
	  }
	  if (exception.Equals("jam_informers"))
	  {
		this.t = 8;
		this.s = 8;
	  }
	  return;
	}
	if (this.t == 8 && exception.Equals("informer"))
	{
	  try
	  {
		double d1 = double.Parse(paramcc.a("lat"));
		double d2 = double.Parse(paramcc.a("lon"));
		int i = int.Parse(paramcc.a("value"));
		string str = paramcc.a("color");
		ay ay1 = new ay();
		this(d1, d2, i, str);
		if (this.g >= this.j.Length)
		{
		  ay[] arrayOfAy = new ay[this.j.Length << 1];
		  Array.Copy(this.j, 0, arrayOfAy, 0, this.j.Length);
		  this.j = arrayOfAy;
		}
		this.j[this.g] = ay1;
		this.g++;
	  }
	  catch (Exception)
	  {
	  }
	}
  }

  public override void a(char[] paramArrayOfchar, int paramInt)
  {
	string str = null;
	if (this.s != 9)
	{
	  str = new string(paramArrayOfchar, 0, paramInt);
	}
	switch (this.s)
	{
	  default:
		this.s = 0;
		return;
	  case 3:
		this.v = long.Parse(str);
		  goto case 4;
	  case 4:
		try
		{
		  this.r = int.Parse(str) * 1000;
		}
		catch (Exception)
		{
		  this.r = 120000;
		}
		  goto case 5;
	  case 5:
		try
		{
		  int.Parse(str);
		}
		catch (Exception)
		{
		}
		  goto case 6;
	  case 6:
		try
		{
		  this.e = int.Parse(str) * 1000;
		}
		catch (Exception)
		{
		  this.e = 600000;
		}
		  goto case 7;
	  case 7:
		try
		{
		  int.Parse(str);
		}
		catch (Exception)
		{
		}
		  goto case 9;
	  case 9:
		break;
	}
	try
	{
	  Thread.yield();
	  ba ba1 = new ba();
	  this(this.o, this.p, this.q, paramInt / 7);
	  GeoPoint geoPoint = new GeoPoint();
	  this();
	  sbyte b = 0;
	  int i = 0;
	  bool @bool;
	  for (@bool = false; b < paramInt; @bool = bool1)
	  {
		int j = i;
		bool bool1 = @bool;
		if (exception[b] == 32)
		{
		  double d = b.a((char[])exception, i, b);
		  if (@bool)
		  {
			geoPoint.Lon = d;
			ba1.a(geoPoint);
			@bool = false;
		  }
		  else
		  {
			geoPoint.Lat = d;
			@bool = true;
		  }
		  j = b + 1;
		  bool1 = @bool;
		}
		b++;
		i = j;
	  }
	  if (this.f >= this.h.Length)
	  {
		ba[] arrayOfBa = new ba[this.h.Length << 1];
		Array.Copy(this.h, 0, arrayOfBa, 0, this.h.Length);
		this.h = arrayOfBa;
	  }
	  ba1.j = null;
	  this.h[this.f] = ba1;
	  this.f++;
	}
	catch (Exception)
	{
	}
  }

  internal bool a()
  {
	return (DateTimeHelper.CurrentUnixTimeMillis() > this.c + this.r);
  }

  internal bool b()
  {
	return (DateTimeHelper.CurrentUnixTimeMillis() > this.c + this.e);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ax.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */