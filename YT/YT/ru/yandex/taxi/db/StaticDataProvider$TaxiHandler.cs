using System.Text;

namespace ru.yandex.taxi.db
{
	using SQLiteDatabase = android.database.sqlite.SQLiteDatabase;
	using AttributeList = org.xml.sax.AttributeList;
	using HandlerBase = org.xml.sax.HandlerBase;

	public class StaticDataProvider$TaxiHandler : HandlerBase
	{
	  private StringBuilder a = new StringBuilder();

	  private SQLiteDatabase b;

	  private string c = "insert into taxi(name,taxi_id,locality_name,phone,url) values (?, ?, ?, ?, ?);";

	  private string[] d = new string[5];

	  public StaticDataProvider$TaxiHandler(StaticDataProvider paramStaticDataProvider, SQLiteDatabase paramSQLiteDatabase)
	  {
		this.b = paramSQLiteDatabase;
	  }

	  public virtual void characters(char[] paramArrayOfchar, int paramInt1, int paramInt2)
	  {
		this.a.Append(paramArrayOfchar, paramInt1, paramInt2);
	  }

	  public virtual void endElement(string paramString)
	  {
		if ("name-ru".Equals(paramString))
		{
		  this.d[0] = CurrentElement;
		  return;
		}
		if ("company-id".Equals(paramString))
		{
		  this.d[1] = CurrentElement;
		  return;
		}
		if ("locality-name".Equals(paramString))
		{
		  this.d[2] = CurrentElement;
		  return;
		}
		if ("number".Equals(paramString))
		{
		  this.d[3] = CurrentElement;
		  return;
		}
		if ("url".Equals(paramString))
		{
		  this.d[4] = CurrentElement;
		  return;
		}
		if ("company".Equals(paramString))
		{
		  this.b.execSQL(this.c, (object[])this.d);
		  this.d = new string[5];
		}
	  }

	  protected internal virtual string CurrentElement
	  {
		  get
		  {
			return this.a.ToString().Trim();
		  }
	  }

	  public virtual void startElement(string paramString, AttributeList paramAttributeList)
	  {
		sbyte b = 0;
		this.a.Length = 0;
		if ("company".Equals(paramString))
		{
		  while (b < this.d.Length)
		  {
			this.d[b] = "";
			b++;
		  }
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataProvider$TaxiHandler.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}