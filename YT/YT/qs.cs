using Context = android.content.Context;
using SQLiteDatabase = android.database.sqlite.SQLiteDatabase;
using SQLiteOpenHelper = android.database.sqlite.SQLiteOpenHelper;

public class qs : SQLiteOpenHelper
{
  private SQLiteDatabase a;

  public qs(Context paramContext) : base(paramContext, "yandexsuggest_history.db", null, 2)
  {
  }

  public virtual void close()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: invokespecial close : ()V
	//   6: aload_0
	//   7: getfield a : Landroid/database/sqlite/SQLiteDatabase;
	//   10: ifnull -> 20
	//   13: aload_0
	//   14: getfield a : Landroid/database/sqlite/SQLiteDatabase;
	//   17: invokevirtual close : ()V
	//   20: aload_0
	//   21: monitorexit
	//   22: return
	//   23: astore_1
	//   24: aload_0
	//   25: monitorexit
	//   26: aload_1
	//   27: athrow
	//   28: astore_1
	//   29: goto -> 20
	// Exception table:
	//   from	to	target	type
	//   2	6	23	finally
	//   6	20	28	java/lang/Throwable
	//   6	20	23	finally
  }

  public virtual void onCreate(SQLiteDatabase paramSQLiteDatabase)
  {
	this.a = paramSQLiteDatabase;
	paramSQLiteDatabase.execSQL("CREATE VIRTUAL TABLE suggest USING fts3 (suggest_text_1, text_lower, suggest_text_2, time);");
  }

  public virtual void onUpgrade(SQLiteDatabase paramSQLiteDatabase, int paramInt1, int paramInt2)
  {
	paramSQLiteDatabase.execSQL("DROP TABLE IF EXISTS suggest;");
	onCreate(paramSQLiteDatabase);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qs.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */