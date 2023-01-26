using System;
using System.IO;
using System.Text;

using XmlPullParser = org.xmlpull.v1.XmlPullParser;
using XmlPullParserFactory = org.xmlpull.v1.XmlPullParserFactory;
using GeoCode = ru.yandex.yandexmapkit.map.GeoCode;
using GeoCodeListener = ru.yandex.yandexmapkit.map.GeoCodeListener;
using DownloadHandler = ru.yandex.yandexmapkit.net.DownloadHandler;
using DownloadJob = ru.yandex.yandexmapkit.net.DownloadJob;
using Downloader = ru.yandex.yandexmapkit.net.Downloader;
using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class af : DownloadHandler
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private GeoCodeListener a_Conflict;

  private GeoPoint b;

  public af(GeoCodeListener paramGeoCodeListener, GeoPoint paramGeoPoint)
  {
	this.a_Conflict = paramGeoCodeListener;
	this.b = paramGeoPoint;
  }

  private static void a(Stream paramInputStream, GeoCode paramGeoCode)
  {
	XmlPullParserFactory xmlPullParserFactory = XmlPullParserFactory.newInstance();
	xmlPullParserFactory.setNamespaceAware(false);
	XmlPullParser xmlPullParser = xmlPullParserFactory.newPullParser();
	xmlPullParser.setInput(paramInputStream, null);
	int i = xmlPullParser.getEventType();
	for (sbyte b = 0; i != 1; b = b1)
	{
	  sbyte b1;
	  if (i == 2)
	  {
		string str = xmlPullParser.getName();
		if (str.Equals("result"))
		{
		  b1 = 1;
		}
		else if (b == 1 && str.Equals("addresses"))
		{
		  b1 = 2;
		}
		else
		{
		  b1 = b;
		  if (b == 2)
		  {
			b1 = b;
			if (str.Equals("object"))
			{
			  paramGeoCode.a(xmlPullParser.getAttributeValue(null, "kind"));
			  try
			  {
				b1 = int.Parse(xmlPullParser.getAttributeValue(null, "zoomid"));
			  }
			  catch (Exception)
			  {
				b1 = 0;
			  }
			  paramGeoCode.a(b1);
			  try
			  {
				GeoPoint geoPoint = b.a(xmlPullParser.getAttributeValue(null, "ll"), true);
			  }
			  catch (Exception exception)
			  {
				exception = null;
			  }
			  if (exception != null)
			  {
				paramGeoCode.a((GeoPoint)exception);
				paramGeoCode.a(CoordConversion.toXY((GeoPoint)exception, null));
			  }
			  paramGeoCode.b(xmlPullParser.getAttributeValue(null, "title"));
			  paramGeoCode.c(xmlPullParser.getAttributeValue(null, "subtitle"));
			  b1 = 3;
			}
		  }
		}
	  }
	  else
	  {
		b1 = b;
		if (i == 3)
		{
		  string str = xmlPullParser.getName();
		  if (b == 3 && str.Equals("object"))
		  {
			b1 = 2;
		  }
		  else
		  {
			b1 = b;
			if (b == 2)
			{
			  b1 = b;
			  if (str.Equals("addresses"))
			  {
				b1 = 1;
			  }
			}
		  }
		}
	  }
	  i = xmlPullParser.next();
	}
  }

  public virtual bool a(DownloadJob paramDownloadJob, GeoCode paramGeoCode)
  {
	bool bool1 = false;
	bool bool2 = bool1;
	if (paramDownloadJob.e == 200)
	{
	  bool2 = bool1;
	  if (paramDownloadJob.f != null)
	  {
		MemoryStream byteArrayInputStream1 = null;
		MemoryStream byteArrayInputStream2 = null;
		MemoryStream byteArrayInputStream3 = null;
		MemoryStream byteArrayInputStream4 = new MemoryStream(paramDownloadJob.f);
		MemoryStream byteArrayInputStream5 = byteArrayInputStream1;
		MemoryStream byteArrayInputStream6 = byteArrayInputStream2;
		try
		{
		  if (paramDownloadJob.f != null)
		  {
			MemoryStream byteArrayInputStream;
			byteArrayInputStream5 = byteArrayInputStream1;
			byteArrayInputStream6 = byteArrayInputStream2;
			if (b.a(paramDownloadJob.f))
			{
			  byteArrayInputStream5 = byteArrayInputStream1;
			  byteArrayInputStream6 = byteArrayInputStream2;
			  GZIPInputStream gZIPInputStream = new GZIPInputStream();
			  byteArrayInputStream5 = byteArrayInputStream1;
			  byteArrayInputStream6 = byteArrayInputStream2;
			  this(byteArrayInputStream4);
			}
			else
			{
			  byteArrayInputStream = byteArrayInputStream4;
			}
			byteArrayInputStream5 = byteArrayInputStream;
			byteArrayInputStream6 = byteArrayInputStream;
			a(byteArrayInputStream, paramGeoCode);
			byteArrayInputStream3 = byteArrayInputStream;
		  }
		  if (byteArrayInputStream3 != null)
		  {
			try
			{
			  byteArrayInputStream3.Close();
			}
			catch (IOException)
			{
			}
		  }
		}
		catch (Exception)
		{

		}
		finally
		{
		  if (byteArrayInputStream5 != null)
		  {
			try
			{
			  byteArrayInputStream5.Close();
			}
			catch (IOException)
			{
			}
		  }
		}
	  }
	}
	return bool2;
  }

  public virtual DownloadJob onCreateDownloadJob(int paramInt)
  {
	StringBuilder stringBuilder = new StringBuilder(Downloader.getServer(2));
	stringBuilder.Append("/geocode?uuid=");
	stringBuilder.Append(Downloader.UUID);
	stringBuilder.Append("&ll=");
	stringBuilder.Append(b.a(this.b.Lat));
	stringBuilder.Append(',');
	stringBuilder.Append(b.a(this.b.Lon));
	stringBuilder.Append("&ver=2");
	stringBuilder.Append("&gzip");
	return new DownloadJob(1, stringBuilder.ToString(), 0, null, this, null, 5000L);
  }

  public virtual bool onFinishDownload(DownloadJob paramDownloadJob, bool paramBoolean)
  {
	bool @bool = true;
	GeoCode geoCode = new GeoCode();
	if (a(paramDownloadJob, geoCode))
	{
	  this.a_Conflict.onFinishGeoCode(geoCode);
	  return @bool;
	}
	if (paramBoolean)
	{
	  this.a_Conflict.onFinishGeoCode(null);
	  return @bool;
	}
	return false;
  }

  public virtual void onStartDownload(int paramInt)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\af.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */