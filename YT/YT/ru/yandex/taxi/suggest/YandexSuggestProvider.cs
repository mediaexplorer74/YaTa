using System;
using System.Collections;
using System.Collections.Generic;

namespace ru.yandex.taxi.suggest
{
	using ContentValues = android.content.ContentValues;
	using Context = android.content.Context;
	using SearchRecentSuggestionsProvider = android.content.SearchRecentSuggestionsProvider;
	using UriMatcher = android.content.UriMatcher;
	using Cursor = android.database.Cursor;
	using MatrixCursor = android.database.MatrixCursor;
	using SQLiteDatabase = android.database.sqlite.SQLiteDatabase;
	using SQLiteQueryBuilder = android.database.sqlite.SQLiteQueryBuilder;
	using Uri = android.net.Uri;
	using qo;
	using qs;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class YandexSuggestProvider : SearchRecentSuggestionsProvider
	{
	  public const string AUTHORITY = "ru.yandex.taxi.suggest.YandexSuggestProvider";

	  public const string CONTENT_TYPE = "vnd.android.cursor.dir/vnd.yandex.yandexmaps.map.suggest";

	  public static readonly Uri CONTENT_URI = Uri.parse("content://ru.yandex.taxi.suggest.YandexSuggestProvider/yandexsuggest");

	  public const string DEFINITION_MIME_TYPE = "vnd.android.cursor.item/vnd.yandex.yandexmaps.map.suggest";

	  public const string KEY_DEFINITION = "suggest_text_2";

	  public const string KEY_ICON = "suggest_icon_1";

	  public const string KEY_ID = "docid";

	  public const string KEY_TIME = "time";

	  public const string KEY_WORD = "suggest_text_1";

	  public const string KEY_WORD_LOWER = "text_lower";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly UriMatcher a_Conflict;

	  private static Dictionary<string, string> b;

	  private static Suggest c;

	  private static Result d;

	  private static YandexSuggestProvider e;

	  private static qs f;

	  static YandexSuggestProvider()
	  {
		Dictionary<object, object> hashMap = new Dictionary<object, object>();
		hashMap["suggest_text_1"] = "suggest_text_1";
		hashMap["text_lower"] = "text_lower";
		hashMap["suggest_text_2"] = "suggest_text_2";
		hashMap["_id"] = "rowid AS _id";
		hashMap["suggest_intent_data_id"] = "rowid AS suggest_intent_data_id";
		b = (Hashtable)hashMap;
		UriMatcher uriMatcher = new UriMatcher(-1);
		a_Conflict = uriMatcher;
		uriMatcher.addURI("ru.yandex.taxi.suggest.YandexSuggestProvider", "search_suggest_query", 1);
		a_Conflict.addURI("ru.yandex.taxi.suggest.YandexSuggestProvider", "search_suggest_query/*", 1);
		a_Conflict.addURI("ru.yandex.taxi.suggest.YandexSuggestProvider", "yandexsuggest", 1);
		a_Conflict.addURI("ru.yandex.taxi.suggest.YandexSuggestProvider", "yandexsuggest/#", 2);
	  }

	  private static Cursor a(string paramString1, string[] paramArrayOfString, string paramString2, int paramInt)
	  {
		string str;
		Cursor cursor2 = null;
		SQLiteQueryBuilder sQLiteQueryBuilder = new SQLiteQueryBuilder();
		sQLiteQueryBuilder.setTables("suggest");
		sQLiteQueryBuilder.setProjectionMap(b);
		SQLiteDatabase sQLiteDatabase = f.getReadableDatabase();
		if (paramInt == 0)
		{
		  str = null;
		}
		else
		{
		  str = paramInt.ToString();
		}
		Cursor cursor1 = sQLiteQueryBuilder.query(sQLiteDatabase, new string[] {"_id", "suggest_text_1", "suggest_text_2", "suggest_intent_data_id"}, paramString1, paramArrayOfString, null, null, paramString2, str);
		if (cursor1 == null)
		{
		  return cursor2;
		}
		if (!cursor1.moveToFirst())
		{
		  cursor1.close();
		  cursor1 = cursor2;
		}
		return cursor1;
	  }

	  private static MatrixCursor a(string paramString1, MatrixCursor paramMatrixCursor, string paramString2)
	  {
		int i;
		sbyte b1;
		int j;
		GeoPoint geoPoint = new GeoPoint(55.752004D, 37.617017D);
		if (geoPoint.Lat != 0.0D && geoPoint.Lon != 0.0D)
		{
		  d = c.search(paramString1, geoPoint.Lat, geoPoint.Lon);
		  i = 0;
		  b1 = 0;
		  if (!string.ReferenceEquals(paramString2, null))
		  {
			paramMatrixCursor.addRow(new object[] {Convert.ToInt32(0), Convert.ToInt32(0), paramString2, "", Convert.ToInt32(0)});
			d.a(paramString2);
			b1 = 1;
			i = 1;
		  }
		  int m = 0;
		  j = d.PopSize;
		  sbyte b = 0;
		  while (b < j)
		  {
			if (!d.equialPop(paramString2))
			{
			  int i1 = m + 1;
			  if (m < 10)
			  {
				paramMatrixCursor.addRow(new object[] {Convert.ToInt32(b + b1), Convert.ToInt32(0), d.Pop[b].Text, "", Convert.ToInt32(b + b1)});
				m = i + 1;
				i = i1;
			  }
			  else
			  {
				break;
			  }
			}
			else
			{
			  b--;
			  j--;
			  int i1 = i;
			  i = m;
			  m = i1;
			}
			b++;
			int n = m;
			m = i;
			i = n;
		  }
		}
		else
		{
		  throw new System.ArgumentException("YandexSuggestProvider: Lat and lon coordinates must not be 0");
		}
		sbyte b3 = 0;
		int k = d.GeoSize;
		sbyte b2 = 0;
		while (b2 < k)
		{
		  if (b3 < 10 - i)
		  {
			qo qo = d.Geo[b2];
			paramMatrixCursor.addRow(new object[] {Convert.ToInt32(b2 + j + b1), Convert.ToInt32(0), qo.j(), qo.l(), Convert.ToInt32(b2 + j + b1)});
		  }
		  b2++;
		  b3++;
		}
		return paramMatrixCursor;
	  }

	  public static void add(Context paramContext, string paramString)
	  {
		if (e != null && !string.ReferenceEquals(paramString, null))
		{
		  ContentValues contentValues = new ContentValues();
		  contentValues.put("suggest_text_1", paramString);
		  contentValues.put("text_lower", paramString.ToLower());
		  contentValues.put("time", Convert.ToInt64(DateTimeHelper.CurrentUnixTimeMillis()));
		  e.insert(CONTENT_URI, contentValues);
		}
	  }

	  public static void clear()
	  {
		f.getWritableDatabase().execSQL("DELETE FROM suggest;");
	  }

	  public static void close()
	  {
		if (c != null)
		{
		  c.close();
		  c = null;
		}
		d = null;
		if (f != null)
		{
		  f.close();
		  f = null;
		}
	  }

	  public virtual int delete(Uri paramUri, string paramString, string[] paramArrayOfString)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: new java/lang/UnsupportedOperationException
		//   5: astore_1
		//   6: aload_1
		//   7: invokespecial <init> : ()V
		//   10: aload_1
		//   11: athrow
		//   12: astore_1
		//   13: aload_0
		//   14: monitorexit
		//   15: aload_1
		//   16: athrow
		// Exception table:
		//   from	to	target	type
		//   2	12	12	finally
	  }

	  public virtual string getType(Uri paramUri)
	  {
		switch (a_Conflict.match(paramUri))
		{
		  default:
			throw new System.ArgumentException("Unknown URI " + paramUri);
		  case 1:
			return "vnd.android.cursor.dir/vnd.yandex.yandexmaps.map.suggest";
		  case 2:
			break;
		}
		return "vnd.android.cursor.item/vnd.yandex.yandexmaps.map.suggest";
	  }

	  public virtual Uri insert(Uri paramUri, ContentValues paramContentValues)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.a : Landroid/content/UriMatcher;
		//   5: aload_1
		//   6: invokevirtual match : (Landroid/net/Uri;)I
		//   9: iconst_1
		//   10: if_icmpeq -> 50
		//   13: new java/lang/IllegalArgumentException
		//   16: astore_3
		//   17: new java/lang/StringBuilder
		//   20: astore_2
		//   21: aload_2
		//   22: invokespecial <init> : ()V
		//   25: aload_3
		//   26: aload_2
		//   27: ldc_w 'Unknown URI '
		//   30: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   33: aload_1
		//   34: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   37: invokevirtual toString : ()Ljava/lang/String;
		//   40: invokespecial <init> : (Ljava/lang/String;)V
		//   43: aload_3
		//   44: athrow
		//   45: astore_1
		//   46: aload_0
		//   47: monitorexit
		//   48: aload_1
		//   49: athrow
		//   50: aload_2
		//   51: ifnull -> 227
		//   54: new android/content/ContentValues
		//   57: astore_3
		//   58: aload_3
		//   59: aload_2
		//   60: invokespecial <init> : (Landroid/content/ContentValues;)V
		//   63: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.f : Lqs;
		//   66: invokevirtual getWritableDatabase : ()Landroid/database/sqlite/SQLiteDatabase;
		//   69: astore #4
		//   71: aconst_null
		//   72: aconst_null
		//   73: aconst_null
		//   74: iconst_0
		//   75: invokestatic a : (Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;I)Landroid/database/Cursor;
		//   78: astore #5
		//   80: aload #5
		//   82: ifnull -> 112
		//   85: aload #5
		//   87: invokeinterface getCount : ()I
		//   92: bipush #50
		//   94: if_icmplt -> 105
		//   97: aload #4
		//   99: ldc_w 'DELETE FROM suggest WHERE docid = (SELECT docid FROM suggest ORDER BY time ASC);'
		//   102: invokevirtual execSQL : (Ljava/lang/String;)V
		//   105: aload #5
		//   107: invokeinterface close : ()V
		//   112: ldc_w 'text_lower = ?'
		//   115: iconst_1
		//   116: anewarray java/lang/String
		//   119: dup
		//   120: iconst_0
		//   121: aload_2
		//   122: ldc 'text_lower'
		//   124: invokevirtual get : (Ljava/lang/String;)Ljava/lang/Object;
		//   127: invokestatic valueOf : (Ljava/lang/Object;)Ljava/lang/String;
		//   130: aastore
		//   131: aconst_null
		//   132: iconst_1
		//   133: invokestatic a : (Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;I)Landroid/database/Cursor;
		//   136: astore #5
		//   138: aload #5
		//   140: ifnull -> 150
		//   143: aload #5
		//   145: invokeinterface close : ()V
		//   150: aload #5
		//   152: ifnull -> 238
		//   155: aload #5
		//   157: invokeinterface getCount : ()I
		//   162: ifle -> 238
		//   165: aload #4
		//   167: ldc 'suggest'
		//   169: aload_3
		//   170: ldc_w 'text_lower = ?'
		//   173: iconst_1
		//   174: anewarray java/lang/String
		//   177: dup
		//   178: iconst_0
		//   179: aload_2
		//   180: ldc 'text_lower'
		//   182: invokevirtual get : (Ljava/lang/String;)Ljava/lang/Object;
		//   185: invokestatic valueOf : (Ljava/lang/Object;)Ljava/lang/String;
		//   188: aastore
		//   189: invokevirtual update : (Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I
		//   192: i2l
		//   193: lstore #6
		//   195: lload #6
		//   197: lconst_0
		//   198: lcmp
		//   199: ifle -> 252
		//   202: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.CONTENT_URI : Landroid/net/Uri;
		//   205: lload #6
		//   207: invokestatic withAppendedId : (Landroid/net/Uri;J)Landroid/net/Uri;
		//   210: astore_1
		//   211: aload_0
		//   212: invokevirtual getContext : ()Landroid/content/Context;
		//   215: invokevirtual getContentResolver : ()Landroid/content/ContentResolver;
		//   218: aload_1
		//   219: aconst_null
		//   220: invokevirtual notifyChange : (Landroid/net/Uri;Landroid/database/ContentObserver;)V
		//   223: aload_0
		//   224: monitorexit
		//   225: aload_1
		//   226: areturn
		//   227: new android/content/ContentValues
		//   230: dup
		//   231: invokespecial <init> : ()V
		//   234: astore_3
		//   235: goto -> 63
		//   238: aload #4
		//   240: ldc 'suggest'
		//   242: aconst_null
		//   243: aload_3
		//   244: invokevirtual insert : (Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J
		//   247: lstore #6
		//   249: goto -> 195
		//   252: new android/database/SQLException
		//   255: astore_2
		//   256: new java/lang/StringBuilder
		//   259: astore_3
		//   260: aload_3
		//   261: invokespecial <init> : ()V
		//   264: aload_2
		//   265: aload_3
		//   266: ldc_w 'Failed to insert row into '
		//   269: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   272: aload_1
		//   273: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   276: invokevirtual toString : ()Ljava/lang/String;
		//   279: invokespecial <init> : (Ljava/lang/String;)V
		//   282: aload_2
		//   283: athrow
		// Exception table:
		//   from	to	target	type
		//   2	45	45	finally
		//   54	63	45	finally
		//   63	80	45	finally
		//   85	105	45	finally
		//   105	112	45	finally
		//   112	138	45	finally
		//   143	150	45	finally
		//   155	195	45	finally
		//   202	223	45	finally
		//   227	235	45	finally
		//   238	249	45	finally
		//   252	284	45	finally
	  }

	  public virtual bool onCreate()
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: ldc 'ru.yandex.taxi.suggest.YandexSuggestProvider'
		//   5: iconst_1
		//   6: invokevirtual setupSuggestions : (Ljava/lang/String;I)V
		//   9: aload_0
		//   10: putstatic ru/yandex/taxi/suggest/YandexSuggestProvider.e : Lru/yandex/taxi/suggest/YandexSuggestProvider;
		//   13: aload_0
		//   14: invokevirtual getContext : ()Landroid/content/Context;
		//   17: astore_1
		//   18: new ru/yandex/taxi/suggest/Suggest
		//   21: astore_2
		//   22: aload_2
		//   23: aload_1
		//   24: invokespecial <init> : (Landroid/content/Context;)V
		//   27: aload_2
		//   28: putstatic ru/yandex/taxi/suggest/YandexSuggestProvider.c : Lru/yandex/taxi/suggest/Suggest;
		//   31: new qs
		//   34: astore_2
		//   35: aload_2
		//   36: aload_1
		//   37: invokespecial <init> : (Landroid/content/Context;)V
		//   40: aload_2
		//   41: putstatic ru/yandex/taxi/suggest/YandexSuggestProvider.f : Lqs;
		//   44: aload_0
		//   45: monitorexit
		//   46: iconst_1
		//   47: ireturn
		//   48: astore_1
		//   49: aload_0
		//   50: monitorexit
		//   51: aload_1
		//   52: athrow
		// Exception table:
		//   from	to	target	type
		//   2	44	48	finally
	  }

	  public virtual Cursor query(Uri paramUri, string[] paramArrayOfString1, string paramString1, string[] paramArrayOfString2, string paramString2)
	  {
		// Byte code:
		//   0: aconst_null
		//   1: astore_2
		//   2: aload_0
		//   3: monitorenter
		//   4: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.a : Landroid/content/UriMatcher;
		//   7: aload_1
		//   8: invokevirtual match : (Landroid/net/Uri;)I
		//   11: tableswitch default -> 32, 1 -> 69, 2 -> 349
		//   32: new java/lang/IllegalArgumentException
		//   35: astore_2
		//   36: new java/lang/StringBuilder
		//   39: astore_3
		//   40: aload_3
		//   41: invokespecial <init> : ()V
		//   44: aload_2
		//   45: aload_3
		//   46: ldc_w 'Unknown URI '
		//   49: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   52: aload_1
		//   53: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   56: invokevirtual toString : ()Ljava/lang/String;
		//   59: invokespecial <init> : (Ljava/lang/String;)V
		//   62: aload_2
		//   63: athrow
		//   64: astore_1
		//   65: aload_0
		//   66: monitorexit
		//   67: aload_1
		//   68: athrow
		//   69: aload #4
		//   71: ifnonnull -> 106
		//   74: new java/lang/IllegalArgumentException
		//   77: astore_3
		//   78: new java/lang/StringBuilder
		//   81: astore_2
		//   82: aload_2
		//   83: invokespecial <init> : ()V
		//   86: aload_3
		//   87: aload_2
		//   88: ldc_w 'selectionArgs must be provided for the Uri: '
		//   91: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   94: aload_1
		//   95: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   98: invokevirtual toString : ()Ljava/lang/String;
		//   101: invokespecial <init> : (Ljava/lang/String;)V
		//   104: aload_3
		//   105: athrow
		//   106: aload #4
		//   108: iconst_0
		//   109: aaload
		//   110: astore_1
		//   111: aload_1
		//   112: ifnull -> 201
		//   115: aload_1
		//   116: invokevirtual length : ()I
		//   119: iconst_1
		//   120: if_icmpgt -> 201
		//   123: aconst_null
		//   124: putstatic ru/yandex/taxi/suggest/YandexSuggestProvider.d : Lru/yandex/taxi/suggest/Result;
		//   127: aload_1
		//   128: invokevirtual length : ()I
		//   131: ifne -> 159
		//   134: aconst_null
		//   135: astore #4
		//   137: aconst_null
		//   138: astore_1
		//   139: bipush #20
		//   141: istore #6
		//   143: aload_1
		//   144: aload #4
		//   146: ldc_w 'text_lower ASC'
		//   149: iload #6
		//   151: invokestatic a : (Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;I)Landroid/database/Cursor;
		//   154: astore_1
		//   155: aload_0
		//   156: monitorexit
		//   157: aload_1
		//   158: areturn
		//   159: new java/lang/StringBuilder
		//   162: astore_1
		//   163: aload_1
		//   164: invokespecial <init> : ()V
		//   167: aload #4
		//   169: iconst_0
		//   170: aload_1
		//   171: aload #4
		//   173: iconst_0
		//   174: aaload
		//   175: invokevirtual toLowerCase : ()Ljava/lang/String;
		//   178: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   181: ldc_w '*'
		//   184: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   187: invokevirtual toString : ()Ljava/lang/String;
		//   190: aastore
		//   191: ldc_w 'text_lower MATCH ?'
		//   194: astore_1
		//   195: iconst_0
		//   196: istore #6
		//   198: goto -> 143
		//   201: aload #4
		//   203: iconst_0
		//   204: aaload
		//   205: astore_3
		//   206: new java/lang/StringBuilder
		//   209: astore_1
		//   210: aload_1
		//   211: invokespecial <init> : ()V
		//   214: aload #4
		//   216: iconst_0
		//   217: aload_1
		//   218: aload #4
		//   220: iconst_0
		//   221: aaload
		//   222: invokevirtual toLowerCase : ()Ljava/lang/String;
		//   225: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   228: ldc_w '*'
		//   231: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   234: invokevirtual toString : ()Ljava/lang/String;
		//   237: aastore
		//   238: ldc_w 'text_lower MATCH ?'
		//   241: aload #4
		//   243: ldc_w 'text_lower ASC'
		//   246: iconst_1
		//   247: invokestatic a : (Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;I)Landroid/database/Cursor;
		//   250: astore_1
		//   251: aload_1
		//   252: ifnull -> 339
		//   255: aload_1
		//   256: iconst_1
		//   257: invokeinterface getString : (I)Ljava/lang/String;
		//   262: astore_1
		//   263: aload_3
		//   264: invokevirtual toLowerCase : ()Ljava/lang/String;
		//   267: astore #4
		//   269: new android/database/MatrixCursor
		//   272: astore_3
		//   273: aload_3
		//   274: iconst_5
		//   275: anewarray java/lang/String
		//   278: dup
		//   279: iconst_0
		//   280: ldc '_id'
		//   282: aastore
		//   283: dup
		//   284: iconst_1
		//   285: ldc 'suggest_icon_1'
		//   287: aastore
		//   288: dup
		//   289: iconst_2
		//   290: ldc 'suggest_text_1'
		//   292: aastore
		//   293: dup
		//   294: iconst_3
		//   295: ldc 'suggest_text_2'
		//   297: aastore
		//   298: dup
		//   299: iconst_4
		//   300: ldc 'suggest_intent_data_id'
		//   302: aastore
		//   303: invokespecial <init> : ([Ljava/lang/String;)V
		//   306: aload #4
		//   308: invokevirtual length : ()I
		//   311: iconst_2
		//   312: if_icmplt -> 344
		//   315: aload #4
		//   317: aload_3
		//   318: aload_1
		//   319: invokestatic a : (Ljava/lang/String;Landroid/database/MatrixCursor;Ljava/lang/String;)Landroid/database/MatrixCursor;
		//   322: pop
		//   323: aload_3
		//   324: invokevirtual moveToFirst : ()Z
		//   327: ifne -> 344
		//   330: aload_3
		//   331: invokevirtual close : ()V
		//   334: aload_2
		//   335: astore_1
		//   336: goto -> 155
		//   339: aconst_null
		//   340: astore_1
		//   341: goto -> 263
		//   344: aload_3
		//   345: astore_1
		//   346: goto -> 155
		//   349: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.d : Lru/yandex/taxi/suggest/Result;
		//   352: ifnonnull -> 375
		//   355: ldc_w 'rowid = ?'
		//   358: iconst_1
		//   359: anewarray java/lang/String
		//   362: dup
		//   363: iconst_0
		//   364: aload_3
		//   365: aastore
		//   366: aconst_null
		//   367: iconst_1
		//   368: invokestatic a : (Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;I)Landroid/database/Cursor;
		//   371: astore_1
		//   372: goto -> 155
		//   375: aload_3
		//   376: invokestatic parseInt : (Ljava/lang/String;)I
		//   379: istore #7
		//   381: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.d : Lru/yandex/taxi/suggest/Result;
		//   384: invokevirtual getPopSize : ()I
		//   387: istore #8
		//   389: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.d : Lru/yandex/taxi/suggest/Result;
		//   392: invokevirtual a : ()Ljava/lang/String;
		//   395: astore_1
		//   396: iload #7
		//   398: istore #6
		//   400: aload_1
		//   401: ifnull -> 410
		//   404: iload #7
		//   406: iconst_1
		//   407: isub
		//   408: istore #6
		//   410: aload_1
		//   411: ifnull -> 497
		//   414: iload #6
		//   416: iconst_m1
		//   417: if_icmpne -> 497
		//   420: new android/database/MatrixCursor
		//   423: astore_2
		//   424: aload_2
		//   425: iconst_5
		//   426: anewarray java/lang/String
		//   429: dup
		//   430: iconst_0
		//   431: ldc '_id'
		//   433: aastore
		//   434: dup
		//   435: iconst_1
		//   436: ldc 'suggest_icon_1'
		//   438: aastore
		//   439: dup
		//   440: iconst_2
		//   441: ldc 'suggest_text_1'
		//   443: aastore
		//   444: dup
		//   445: iconst_3
		//   446: ldc 'suggest_text_2'
		//   448: aastore
		//   449: dup
		//   450: iconst_4
		//   451: ldc 'suggest_intent_data_id'
		//   453: aastore
		//   454: invokespecial <init> : ([Ljava/lang/String;)V
		//   457: aload_2
		//   458: iconst_5
		//   459: anewarray java/lang/Object
		//   462: dup
		//   463: iconst_0
		//   464: iconst_0
		//   465: invokestatic valueOf : (I)Ljava/lang/Integer;
		//   468: aastore
		//   469: dup
		//   470: iconst_1
		//   471: aconst_null
		//   472: aastore
		//   473: dup
		//   474: iconst_2
		//   475: aload_1
		//   476: aastore
		//   477: dup
		//   478: iconst_3
		//   479: ldc ''
		//   481: aastore
		//   482: dup
		//   483: iconst_4
		//   484: iconst_0
		//   485: invokestatic valueOf : (I)Ljava/lang/Integer;
		//   488: aastore
		//   489: invokevirtual addRow : ([Ljava/lang/Object;)V
		//   492: aload_2
		//   493: astore_1
		//   494: goto -> 155
		//   497: iload #6
		//   499: iload #8
		//   501: if_icmpge -> 520
		//   504: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.d : Lru/yandex/taxi/suggest/Result;
		//   507: invokevirtual getPop : ()[Lqp;
		//   510: iload #6
		//   512: aaload
		//   513: invokevirtual getText : ()Ljava/lang/String;
		//   516: astore_1
		//   517: goto -> 420
		//   520: getstatic ru/yandex/taxi/suggest/YandexSuggestProvider.d : Lru/yandex/taxi/suggest/Result;
		//   523: invokevirtual getGeo : ()[Lqo;
		//   526: iload #6
		//   528: iload #8
		//   530: isub
		//   531: aaload
		//   532: invokevirtual i : ()Ljava/lang/String;
		//   535: astore_1
		//   536: goto -> 420
		// Exception table:
		//   from	to	target	type
		//   4	32	64	finally
		//   32	64	64	finally
		//   74	106	64	finally
		//   115	134	64	finally
		//   143	155	64	finally
		//   159	191	64	finally
		//   206	251	64	finally
		//   255	263	64	finally
		//   263	334	64	finally
		//   349	372	64	finally
		//   375	396	64	finally
		//   420	492	64	finally
		//   504	517	64	finally
		//   520	536	64	finally
	  }

	  public virtual int update(Uri paramUri, ContentValues paramContentValues, string paramString, string[] paramArrayOfString)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: new java/lang/UnsupportedOperationException
		//   5: astore_1
		//   6: aload_1
		//   7: invokespecial <init> : ()V
		//   10: aload_1
		//   11: athrow
		//   12: astore_1
		//   13: aload_0
		//   14: monitorexit
		//   15: aload_1
		//   16: athrow
		// Exception table:
		//   from	to	target	type
		//   2	12	12	finally
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\suggest\YandexSuggestProvider.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}