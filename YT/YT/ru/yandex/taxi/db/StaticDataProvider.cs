using System.Collections;
using System.Collections.Generic;

namespace ru.yandex.taxi.db
{
	using ContentProvider = android.content.ContentProvider;
	using ContentValues = android.content.ContentValues;
	using UriMatcher = android.content.UriMatcher;
	using Cursor = android.database.Cursor;
	using SQLException = android.database.SQLException;
	using SQLiteQueryBuilder = android.database.sqlite.SQLiteQueryBuilder;
	using Uri = android.net.Uri;
	using TextUtils = android.text.TextUtils;
	using qg;

	public class StaticDataProvider : ContentProvider
	{
	  public const int CACHE_REQUEST = 7;

	  public const int CITY = 1;

	  public const int DELAY_ORDER = 4;

	  public const int HISTORY = 3;

	  public const int NO_CALIBRATE = 6;

	  public const int TAXI = 2;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static Dictionary<string, string> a_Conflict;

	  private static Dictionary<string, string> b;

	  private static Dictionary<string, string> c;

	  private static Dictionary<string, string> d;

	  private static Dictionary<string, string> e;

	  private static Dictionary<string, string> f;

	  private static readonly UriMatcher g;

	  private qg h;

	  static StaticDataProvider()
	  {
		UriMatcher uriMatcher = new UriMatcher(-1);
		g = uriMatcher;
		uriMatcher.addURI("ru.yandex.taxi", "city", 1);
		g.addURI("ru.yandex.taxi", "taxi", 2);
		g.addURI("ru.yandex.taxi", "history", 3);
		g.addURI("ru.yandex.taxi", "delay_order", 4);
		g.addURI("ru.yandex.taxi", "no_calibrate", 6);
		g.addURI("ru.yandex.taxi", "cache_request", 7);
		Dictionary<object, object> hashMap = new Dictionary<object, object>();
		a_Conflict = (Hashtable)hashMap;
		hashMap["_id"] = "_id";
		a_Conflict["name"] = "name";
		a_Conflict["search_name"] = "search_name";
		hashMap = new Dictionary<object, object>();
		b = (Hashtable)hashMap;
		hashMap["_id"] = "_id";
		b["locality_name"] = "locality_name";
		b["phone"] = "phone";
		b["name"] = "name";
		b["taxi_id"] = "taxi_id";
		b["url"] = "url";
		hashMap = new Dictionary<object, object>();
		c = (Hashtable)hashMap;
		hashMap["_id"] = "_id";
		c["name"] = "name";
		c["point"] = "point";
		c["value"] = "value";
		c["last_use"] = "last_use";
		c["type"] = "type";
		hashMap = new Dictionary<object, object>();
		d = (Hashtable)hashMap;
		hashMap["_id"] = "_id";
		d["src"] = "src";
		d["desc"] = "desc";
		d["order_id"] = "order_id";
		d["park_id"] = "park_id";
		d["park_logo"] = "park_logo";
		d["park_name"] = "park_name";
		d["park_phone"] = "park_phone";
		d["tariff_id"] = "tariff_id";
		hashMap = new Dictionary<object, object>();
		e = (Hashtable)hashMap;
		hashMap["_id"] = "_id";
		e["order_id"] = "order_id";
		e["due"] = "due";
		hashMap = new Dictionary<object, object>();
		f = (Hashtable)hashMap;
		hashMap["_id"] = "_id";
		f["request"] = "request";
		f["response"] = "response";
		f["request_date"] = "request_date";
	  }

	  private static string a(Uri paramUri)
	  {
		switch (g.match(paramUri))
		{
		  default:
			throw new System.ArgumentException("Unknown URI " + paramUri);
		  case 1:
			return "city";
		  case 2:
			return "taxi";
		  case 3:
			return "history";
		  case 4:
			return "delay_order";
		  case 6:
			return "no_calibrate";
		  case 7:
			break;
		}
		return "cache_request";
	  }

	  public virtual int delete(Uri paramUri, string paramString, string[] paramArrayOfString)
	  {
		int i = this.h.getWritableDatabase().delete(a(paramUri), paramString, paramArrayOfString);
		getContext().getContentResolver().notifyChange(paramUri, null);
		return i;
	  }

	  public virtual string getType(Uri paramUri)
	  {
		return null;
	  }

	  public virtual Uri insert(Uri paramUri, ContentValues paramContentValues)
	  {
		ContentValues contentValues = paramContentValues;
		if (paramContentValues == null)
		{
		  contentValues = new ContentValues();
		}
		string str = a(paramUri);
		int i = (int)this.h.getWritableDatabase().insert(str, str, contentValues);
		if (i == 0)
		{
		  throw new SQLException("Failed to insert row into " + paramUri);
		}
		return Uri.parse("/" + i);
	  }

	  public virtual bool onCreate()
	  {
		this.h = new qg(this, getContext());
		return true;
	  }

	  public virtual Cursor query(Uri paramUri, string[] paramArrayOfString1, string paramString1, string[] paramArrayOfString2, string paramString2)
	  {
		SQLiteQueryBuilder sQLiteQueryBuilder = new SQLiteQueryBuilder();
		switch (g.match(paramUri))
		{
		  default:
			throw new System.ArgumentException("Unknown URI " + paramUri);
		  case 1:
			sQLiteQueryBuilder.setTables("city");
			sQLiteQueryBuilder.setProjectionMap(a_Conflict);
			str = paramString2;
			if (TextUtils.isEmpty(paramString2))
			{
			  str = "name ASC";
			}
			paramString2 = str;
			cursor = sQLiteQueryBuilder.query(this.h.getReadableDatabase(), paramArrayOfString1, paramString1, paramArrayOfString2, null, null, paramString2);
			cursor.setNotificationUri(getContext().getContentResolver(), paramUri);
			return cursor;
		  case 2:
			sQLiteQueryBuilder.setTables("taxi");
			sQLiteQueryBuilder.setProjectionMap(b);
			str = paramString2;
			if (TextUtils.isEmpty(paramString2))
			{
			  str = "locality_name ASC, name ASC";
			}
			paramString2 = str;
			cursor = sQLiteQueryBuilder.query(this.h.getReadableDatabase(), (string[])cursor, paramString1, paramArrayOfString2, null, null, paramString2);
			cursor.setNotificationUri(getContext().getContentResolver(), paramUri);
			return cursor;
		  case 3:
			sQLiteQueryBuilder.setTables("history");
			sQLiteQueryBuilder.setProjectionMap(c);
			str = paramString2;
			if (TextUtils.isEmpty(paramString2))
			{
			  str = "last_use DESC";
			}
			paramString2 = str;
			cursor = sQLiteQueryBuilder.query(this.h.getReadableDatabase(), (string[])cursor, paramString1, paramArrayOfString2, null, null, paramString2);
			cursor.setNotificationUri(getContext().getContentResolver(), paramUri);
			return cursor;
		  case 4:
			sQLiteQueryBuilder.setTables("delay_order");
			sQLiteQueryBuilder.setProjectionMap(d);
			str = paramString2;
			if (TextUtils.isEmpty(paramString2))
			{
			  str = "order_id ASC";
			}
			paramString2 = str;
			cursor = sQLiteQueryBuilder.query(this.h.getReadableDatabase(), (string[])cursor, paramString1, paramArrayOfString2, null, null, paramString2);
			cursor.setNotificationUri(getContext().getContentResolver(), paramUri);
			return cursor;
		  case 6:
			sQLiteQueryBuilder.setTables("no_calibrate");
			sQLiteQueryBuilder.setProjectionMap(e);
			str = paramString2;
			if (TextUtils.isEmpty(paramString2))
			{
			  str = "order_id ASC";
			}
			paramString2 = str;
			cursor = sQLiteQueryBuilder.query(this.h.getReadableDatabase(), (string[])cursor, paramString1, paramArrayOfString2, null, null, paramString2);
			cursor.setNotificationUri(getContext().getContentResolver(), paramUri);
			return cursor;
		  case 7:
			break;
		}
		sQLiteQueryBuilder.setTables("cache_request");
		sQLiteQueryBuilder.setProjectionMap(f);
		string str = paramString2;
		if (TextUtils.isEmpty(paramString2))
		{
		  str = "request ASC";
		}
		paramString2 = str;
		Cursor cursor = sQLiteQueryBuilder.query(this.h.getReadableDatabase(), (string[])cursor, paramString1, paramArrayOfString2, null, null, paramString2);
		cursor.setNotificationUri(getContext().getContentResolver(), paramUri);
		return cursor;
	  }

	  public virtual int update(Uri paramUri, ContentValues paramContentValues, string paramString, string[] paramArrayOfString)
	  {
		int i = this.h.getWritableDatabase().update(a(paramUri), paramContentValues, paramString, paramArrayOfString);
		getContext().getContentResolver().notifyChange(paramUri, null);
		return i;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataProvider.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}