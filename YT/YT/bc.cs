using System;
using System.Collections;
using System.Text;

public class bc
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string a_Conflict;

  private string b;

  private string c;

  private string d;

  private string e;

  private string f;

  private System.Collections.IList g;

  private string h;

  private string i;

  private System.Collections.IList j;

  public bc(string paramString, long paramLong)
  {
	this.a_Conflict = paramString;
	SimpleDateFormat simpleDateFormat = new SimpleDateFormat("ddMMyyyy:HHmmss");
	simpleDateFormat.setTimeZone(TimeZone.getTimeZone("UTC"));
	this.b = simpleDateFormat.format(Convert.ToInt64(paramLong));
	this.g = new ArrayList();
	this.j = new ArrayList();
	this.c = "";
	this.d = "";
	this.e = "";
	this.f = "";
	this.h = "";
	this.i = "";
  }

  public virtual string a()
  {
	bool @bool = false;
	StringBuilder stringBuilder = new StringBuilder(200);
	stringBuilder.Append("<chunk type=\"").Append(this.a_Conflict).Append("\" time=\"").Append(this.b).Append("\" >");
	if (!string.ReferenceEquals(this.c, null) && this.c.Length > 0)
	{
	  stringBuilder.Append("<gps lat=\"").Append(this.c).Append("\" lon=\"").Append(this.d).Append("\" speed=\"").Append(this.e).Append("\" course=\"").Append(this.f).Append("\" />");
	}
	stringBuilder.Append("<bssids>");
	sbyte b;
	for (b = 0; b < this.g.Count; b++)
	{
	  v v = this.g[b];
	  stringBuilder.Append("<bssid name=\"").Append(v.b).Append("\" channel=\"").Append(v.c).Append("\" sigstr=\"").Append(v.d).Append("\" age=\"").Append(v.e).Append("\">").Append(v.a).Append("</bssid>");
	}
	stringBuilder.Append("</bssids>");
	stringBuilder.Append("<cellinfos network_type=\"").Append(this.h).Append("\" radio_type=\"").Append(this.i).Append("\">");
	for (b = @bool; b < this.j.Count; b++)
	{
	  x x = this.j[b];
	  stringBuilder.Append("<cellinfo cellid=\"").Append(x.a).Append("\" lac=\"").Append(x.b).Append("\" operatorid=\"").Append(x.c).Append("\" countrycode=\"").Append(x.d).Append("\" sigstr=\"").Append(x.e).Append("\" age=\"").Append(x.f).Append("\" />");
	}
	stringBuilder.Append("</cellinfos>");
	stringBuilder.Append("</chunk>");
	return stringBuilder.ToString();
  }

  public virtual void a(string paramString1, string paramString2)
  {
	this.h = paramString1;
	this.i = paramString2;
  }

  public virtual void a(string paramString1, string paramString2, string paramString3, string paramString4)
  {
	this.c = paramString1;
	this.d = paramString2;
	this.e = paramString3;
	this.f = paramString4;
  }

  public virtual void a(string paramString1, string paramString2, string paramString3, string paramString4, string paramString5)
  {
	this.g.Add(new v(paramString1, paramString2, paramString3, paramString4, paramString5));
  }

  public virtual void a(string paramString1, string paramString2, string paramString3, string paramString4, string paramString5, string paramString6)
  {
	this.j.Add(new x(paramString1, paramString2, paramString3, paramString4, paramString5, paramString6));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */