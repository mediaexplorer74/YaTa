using System;
using System.Collections;
using System.Collections.Generic;

using Log = android.util.Log;
using MapLayer = ru.yandex.yandexmapkit.map.MapLayer;

public sealed class bi : cd
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static readonly string[] a_Conflict = new string[] {"default", "tiles", "search", "userpoicats", "userpoiget", "userpoiiconget", "userpoisend", "trafficget", "trafficsend", "userreport", "auth", "clublist", "clubusers", "userprefs", "cellid", "gpsstat", "sessionlogs", "geocode", "userpoivote", "megafon", "mts", "trafficcollect", "wifipool", "tinyurl"};

  public readonly ArrayList b = new ArrayList();

  public readonly ArrayList c = new ArrayList();

  public string d;

  public readonly Hashtable e = new Dictionary<object, object>();

  public readonly System.Collections.IDictionary f = new Dictionary<object, object>();

  public bool g = false;

  public bool h = true;

  public int i = 30;

  public int j = 120;

  public int k = 600;

  public bool l = true;

  public int m = 5;

  public int n = 120;

  public int o = 600;

  public readonly System.Collections.IList p = new ArrayList();

  public MapLayer q;

  private int r;

  private int s;

  private int t;

  private string u;

  internal void a(int paramInt, string paramString)
  {
	this.b.Add(paramString);
	this.c.Add(Convert.ToInt32(paramInt));
  }

  public override void a(string paramString)
  {
	if (paramString.Equals("maps") || paramString.Equals("query_hosts") || paramString.Equals("objectshowintervals") || paramString.Equals("features"))
	{
	  this.s = 0;
	}
	if (this.s == 11 && paramString.Equals("l") && this.q != null)
	{
	  this.p.Add(this.q);
	  this.s = 11;
	}
  }

  internal void a(string paramString, int paramInt1, int paramInt2)
  {
	this.f[paramString] = new ak(paramInt1, paramInt2);
  }

  public override void a(string paramString, cc paramcc)
  {
	string str;
	bool bool1 = true;
	bool bool2 = true;
	bool bool3 = true;
	this.r = 0;
	if (paramString.Equals("error"))
	{
	  this.g = true;
	  return;
	}
	if (paramString.Equals("app"))
	{
	  paramString = paramcc.a("cur_app_version");
	  str = paramcc.a("min_app_version");
	  try
	  {
		int.Parse(paramString);
		int.Parse(str);
	  }
	  catch (Exception)
	  {
	  }
	  return;
	}
	if (exception.Equals("changelog"))
	{
	  this.r = 1;
	  return;
	}
	if (exception.Equals("news"))
	{
	  this.r = 2;
	  try
	  {
		int.Parse(str.a("id"));
	  }
	  catch (Exception)
	  {
	  }
	  str.a("url");
	  return;
	}
	if (exception.Equals("ui_actions_log"))
	{
	  str.a("events");
	  return;
	}
	if (exception.Equals("uuid"))
	{
	  this.r = 3;
	  return;
	}
	if (exception.Equals("operator"))
	{
	  this.r = 9;
	  str.a("msisdn");
	  return;
	}
	if (exception.Equals("features"))
	{
	  this.s = 10;
	  return;
	}
	if (this.s == 10 && exception.Equals("operator_branding"))
	{
	  try
	  {
		int.Parse(str.a("timeout"));
	  }
	  catch (Exception)
	  {
	  }
	  return;
	}
	if (this.s != 10 || !exception.Equals("operator_lbs"))
	{
	  if (this.s == 10 && exception.Equals("network_scanner"))
	  {
		try
		{
		  if (int.Parse(str.a("enabled")) != 1)
		  {
			bool3 = false;
		  }
		  this.h = bool3;
		}
		catch (Exception)
		{
		}
		try
		{
		  this.i = int.Parse(str.a("scan_timeout"));
		}
		catch (Exception)
		{
		}
		try
		{
		  this.j = int.Parse(str.a("send_timeout"));
		}
		catch (Exception)
		{
		}
		try
		{
		  this.k = int.Parse(str.a("error_timeout"));
		}
		catch (Exception)
		{
		}
		return;
	  }
	  if (this.s == 10 && exception1.Equals("traffic_collect"))
	  {
		try
		{
		  if (int.Parse(str.a("enabled")) == 1)
		  {
			bool3 = bool1;
		  }
		  else
		  {
			bool3 = false;
		  }
		  this.l = bool3;
		}
		catch (Exception)
		{
		}
		try
		{
		  this.m = int.Parse(str.a("scan_timeout"));
		}
		catch (Exception)
		{
		}
		try
		{
		  this.n = int.Parse(str.a("send_timeout"));
		}
		catch (Exception)
		{
		}
		try
		{
		  this.o = int.Parse(str.a("error_timeout"));
		}
		catch (Exception)
		{
		}
		return;
	  }
	  if (this.s == 4 && exception1.Equals("changes"))
	  {
		this.r = 5;
		try
		{
		  this.t = int.Parse(str.a("version"));
		}
		catch (Exception)
		{
		}
		return;
	  }
	  if (exception1.Equals("openpos"))
	  {
		try
		{
		  double.Parse(str.a("lat"));
		  double.Parse(str.a("lon"));
		  int.Parse(str.a("zoomid"));
		}
		catch (Exception)
		{
		}
		try
		{
		  int.Parse(str.a("success"));
		}
		catch (Exception)
		{
		}
		return;
	  }
	  if (exception1.Equals("query_hosts"))
	  {
		this.s = 6;
		return;
	  }
	  if (this.s == 6 && exception1.Equals("host"))
	  {
		this.r = 7;
		this.u = str.a("type");
		return;
	  }
	  if (exception1.Equals("objectshowintervals"))
	  {
		this.s = 8;
		return;
	  }
	  if (this.s == 8 && exception1.Equals("interval"))
	  {
		string str1 = str.a("object");
		try
		{
		  a(str1, int.Parse(str.a("min_zoom")), int.Parse(str.a("max_zoom")));
		}
		catch (Exception)
		{
		}
		return;
	  }
	  if (exception1.Equals("map_layers"))
	  {
		this.s = 11;
		return;
	  }
	  if (this.s == 11 && exception1.Equals("l"))
	  {
		try
		{
		  bool @bool;
		  string str1 = str.a("request");
		  int i = int.Parse(str.a("id"));
		  string str2 = str.a("name");
		  int j = -1;
		  try
		  {
			@bool = int.Parse(str.a("ver"));
			j = @bool;
		  }
		  catch (System.FormatException)
		  {
		  }
		  try
		  {
			@bool = int.Parse(str.a("service"));
			if (@bool == true)
			{
			  bool3 = true;
			}
			else
			{
			  bool3 = false;
			}
		  }
		  catch (System.FormatException)
		  {
			bool3 = false;
		  }
		  try
		  {
			@bool = int.Parse(str.a("size_in_pixels"));
		  }
		  catch (System.FormatException)
		  {
			@bool = false;
		  }
		  str = str.a("allows_night_mode");
		  bool1 = bool2;
		  if (!string.ReferenceEquals(str, null))
		  {
			if ("no".Equals(str.ToLower()) || "0".Equals(str.ToLower()))
			{
			  bool1 = false;
			}
			else
			{
			  bool1 = bool2;
			  if (!"yes".Equals(str.ToLower()))
			  {
				bool bool4 = "1".Equals(str.ToLower());
				bool1 = bool2;
				if (bool4)
				{
				  bool1 = bool2;
				}
			  }
			}
		  }
		  MapLayer mapLayer = new MapLayer();
		  this(str1, i, str2, j, bool3, @bool, bool1);
		  this.q = mapLayer;
		}
		catch (Exception exception2)
		{
		  Log.w("startup", "can't parse map layers tag layer" + exception2);
		}
	  }
	}
  }

  internal void a(string paramString1, string paramString2)
  {
	this.e[paramString1] = paramString2;
  }

  public override void a(char[] paramArrayOfchar, int paramInt)
  {
	string str = new string(paramArrayOfchar, 0, paramInt);
	switch (this.r)
	{
	  default:
		this.r = 0;
		return;
	  case 3:
		this.d = str;
		  goto case 5;
	  case 5:
		a(this.t, str);
		  goto case 7;
	  case 7:
		break;
	}
	a(this.u, str);
  }

  public bool a(string paramString, int paramInt)
  {
	ak ak = (ak)this.f[paramString];
	return (ak == null) ? true : ((paramInt >= ak.a && paramInt <= ak.b));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */