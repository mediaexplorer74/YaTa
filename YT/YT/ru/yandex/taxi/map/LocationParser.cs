using System;
using System.IO;
using System.Text;

namespace ru.yandex.taxi.map
{
	using Attributes = org.xml.sax.Attributes;
	using ContentHandler = org.xml.sax.ContentHandler;
	using InputSource = org.xml.sax.InputSource;
	using Locator = org.xml.sax.Locator;
	using XMLReader = org.xml.sax.XMLReader;
	using ValueHelper = ru.yandex.taxi.client.ValueHelper;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class LocationParser : ContentHandler
	{
	  private GeoPoint a;

	  private bool b;

	  private bool c;

	  private bool d;

	  private double e;

	  private StringBuilder f = new StringBuilder();

	  public virtual void characters(char[] paramArrayOfchar, int paramInt1, int paramInt2)
	  {
		string str = new string(paramArrayOfchar, paramInt1, paramInt2);
		this.f.Append(str);
	  }

	  public virtual void endDocument()
	  {
	  }

	  public virtual void endElement(string paramString1, string paramString2, string paramString3)
	  {
		paramString1 = this.f.ToString();
		if (this.b)
		{
		  this.a.Lat = ValueHelper.getDouble(paramString1);
		}
		else if (this.c)
		{
		  this.a.Lon = ValueHelper.getDouble(paramString1);
		}
		if (paramString2.Equals("latitude") || paramString3.Equals("latitude"))
		{
		  this.b = false;
		  return;
		}
		if (paramString2.Equals("longitude") || paramString3.Equals("longitude"))
		{
		  this.c = false;
		  return;
		}
		if (paramString2.Equals("region") || paramString3.Equals("region"))
		{
		  this.d = false;
		  return;
		}
		if (paramString2.Equals("id") || paramString3.Equals("id"))
		{
		  if (this.d)
		  {
			  ;
		  }
		  return;
		}
		if (paramString2.Equals("precision") || paramString3.Equals("precision"))
		{
		  this.e = Convert.ToDouble(paramString1);
		}
	  }

	  public virtual void endPrefixMapping(string paramString)
	  {
	  }

	  public virtual GeoPoint getLocation(Stream paramInputStream)
	  {
		XMLReader xMLReader = SAXParserFactory.newInstance().newSAXParser().getXMLReader();
		xMLReader.setContentHandler(this);
		xMLReader.parse(new InputSource(paramInputStream));
		return this.a;
	  }

	  public virtual double Precision
	  {
		  get
		  {
			return this.e;
		  }
	  }

	  public virtual void ignorableWhitespace(char[] paramArrayOfchar, int paramInt1, int paramInt2)
	  {
	  }

	  public virtual void processingInstruction(string paramString1, string paramString2)
	  {
	  }

	  public virtual Locator DocumentLocator
	  {
		  set
		  {
		  }
	  }

	  public virtual void skippedEntity(string paramString)
	  {
	  }

	  public virtual void startDocument()
	  {
	  }

	  public virtual void startElement(string paramString1, string paramString2, string paramString3, Attributes paramAttributes)
	  {
		this.f.Length = 0;
		if (paramString2.Equals("ya_lbs_response") || paramString3.Equals("ya_lbs_response"))
		{
		  this.a = new GeoPoint();
		  return;
		}
		if (paramString2.Equals("latitude") || paramString3.Equals("latitude"))
		{
		  this.b = true;
		  return;
		}
		if (paramString2.Equals("longitude") || paramString3.Equals("longitude"))
		{
		  this.c = true;
		  return;
		}
		if (paramString2.Equals("region") || paramString3.Equals("region"))
		{
		  this.d = true;
		  return;
		}
		if (paramString2.Equals("id") || paramString3.Equals("id"))
		{
		  bool @bool = this.d;
		}
	  }

	  public virtual void startPrefixMapping(string paramString1, string paramString2)
	  {
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\map\LocationParser.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}