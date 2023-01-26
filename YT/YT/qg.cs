using System;
using System.IO;

using Context = android.content.Context;
using SQLiteDatabase = android.database.sqlite.SQLiteDatabase;
using SQLiteOpenHelper = android.database.sqlite.SQLiteOpenHelper;
using Log = android.util.Log;
using HandlerBase = org.xml.sax.HandlerBase;
using StaticDataProvider = ru.yandex.taxi.db.StaticDataProvider;

public class qg : SQLiteOpenHelper
{
  public qg(StaticDataProvider paramStaticDataProvider, Context paramContext) : base(paramContext, "ru_yandex_taxi.db", null, 32)
  {
  }

  private void a(SQLiteDatabase paramSQLiteDatabase)
  {
	StreamReader bufferedReader = new StreamReader(this.a.getContext().getResources().openRawResource(2131099648));
	try
	{
	  while (true)
	  {
		string str = bufferedReader.ReadLine();
		if (!string.ReferenceEquals(str, null))
		{
		  str = str.Trim();
		  paramSQLiteDatabase.execSQL("insert into city(name,search_name) values (?, ?);", (object[])new string[] {str, str.ToLower()});
		  continue;
		}
		break;
	  }
	}
	catch (IOException iOException)
	{
	  Log.e("StaticDataProvider", "Fail fill city db", iOException);
	}
  }

  public virtual void onCreate(SQLiteDatabase paramSQLiteDatabase)
  {
	string str1 = "CREATE TABLE " + "cache_request" + " (" + "_id" + " INTEGER PRIMARY KEY," + "request" + " TEXT," + "response" + " TEXT," + "request_date" + " TEXT" + ");";
	string str2 = "CREATE TABLE " + "city" + " (" + "_id" + " INTEGER PRIMARY KEY," + "name" + " TEXT," + "search_name" + " TEXT" + ");";
	string str3 = "CREATE TABLE " + "no_calibrate" + " (" + "_id" + " INTEGER PRIMARY KEY," + "order_id" + " TEXT," + "due" + " TEXT" + ");";
	string str4 = "CREATE TABLE " + "taxi" + " (" + "_id" + " INTEGER PRIMARY KEY," + "taxi_id" + " LONG," + "locality_name" + "  VARCHAR(50)," + "name" + " TEXT," + "phone" + " TEXT," + "url" + " TEXT" + ");";
	string str5 = "CREATE TABLE " + "history" + " (" + "_id" + " INTEGER PRIMARY KEY," + "name" + " TEXT," + "point" + " TEXT," + "value" + " TEXT," + "type" + " INTEGER," + "last_use" + " LONG" + ");";
	string str6 = "CREATE TABLE " + "delay_order" + " (" + "_id" + " INTEGER PRIMARY KEY," + "order_id" + " TEXT," + "src" + " TEXT," + "desc" + " TEXT," + "park_id" + " TEXT," + "park_logo" + " TEXT," + "park_name" + " TEXT," + "park_phone" + " TEXT," + "tariff_id" + " TEXT" + ");";
	paramSQLiteDatabase.execSQL(str2);
	paramSQLiteDatabase.execSQL(str4);
	paramSQLiteDatabase.execSQL(str5);
	paramSQLiteDatabase.execSQL(str6);
	paramSQLiteDatabase.execSQL(str3);
	paramSQLiteDatabase.execSQL(str1);
	a(paramSQLiteDatabase);
	try
	{
	  SAXParser sAXParser = SAXParserFactory.newInstance().newSAXParser();
	  Stream inputStream = this.a.getContext().getResources().openRawResource(2131099649);
	  StaticDataProvider.TaxiHandler taxiHandler = new StaticDataProvider.TaxiHandler();
	  this(this.a, paramSQLiteDatabase);
	  sAXParser.parse(inputStream, (HandlerBase)taxiHandler);
	}
	catch (Exception exception)
	{
	  Log.e("StaticDataProvider", "Fail parse taxi xml file", exception);
	}
  }

  public virtual void onUpgrade(SQLiteDatabase paramSQLiteDatabase, int paramInt1, int paramInt2)
  {
	Log.w("StaticDataProvider", "Upgrading database from version " + paramInt1 + " to " + paramInt2 + ", which will destroy all old data");
	paramSQLiteDatabase.execSQL("DROP TABLE IF EXISTS city");
	paramSQLiteDatabase.execSQL("DROP TABLE IF EXISTS taxi");
	paramSQLiteDatabase.execSQL("DROP TABLE IF EXISTS history");
	paramSQLiteDatabase.execSQL("DROP TABLE IF EXISTS delay_order");
	paramSQLiteDatabase.execSQL("DROP TABLE IF EXISTS no_calibrate");
	paramSQLiteDatabase.execSQL("DROP TABLE IF EXISTS cache_request");
	onCreate(paramSQLiteDatabase);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */