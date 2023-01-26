using System.Collections.Generic;

namespace ru.yandex.taxi.activity
{
	using ListActivity = android.app.ListActivity;
	using ContentResolver = android.content.ContentResolver;
	using Intent = android.content.Intent;
	using Cursor = android.database.Cursor;
	using Uri = android.net.Uri;
	using Bundle = android.os.Bundle;
	using TextWatcher = android.text.TextWatcher;
	using ContextMenu = android.view.ContextMenu;
	using KeyEvent = android.view.KeyEvent;
	using MenuItem = android.view.MenuItem;
	using View = android.view.View;
	using AdapterView = android.widget.AdapterView;
	using EditText = android.widget.EditText;
	using FilterQueryProvider = android.widget.FilterQueryProvider;
	using ListAdapter = android.widget.ListAdapter;
	using ListView = android.widget.ListView;
	using SimpleCursorAdapter = android.widget.SimpleCursorAdapter;
	using ls;
	using lt;
	using lu;
	using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;

	public class SearchCityActivity : ListActivity
	{
	  public const string CITY_NAME = "city name";

	  public const string TAXI_CITY = "taxi city";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly string[] a_Conflict = new string[] {"_id", "name", "search_name"};

	  private long b;

	  private IList<string> c = new List<string>();

	  private int d;

	  private ListView e;

	  private EditText f;

	  private void a()
	  {
		ContentResolver contentResolver = getContentResolver();
		Uri uri = StaticDataScheme.HistoryTable.CONTENT_URI;
		string str = "type = " + this.d;
		a(contentResolver.query(uri, new string[] {"_id", "name"}, str, null, "last_use DESC"), new string[] {"name"}, (FilterQueryProvider)null);
	  }

	  private void a(Cursor paramCursor, string[] paramArrayOfString, FilterQueryProvider paramFilterQueryProvider)
	  {
		SimpleCursorAdapter simpleCursorAdapter = new SimpleCursorAdapter(getApplicationContext(), 2130903064, paramCursor, paramArrayOfString, new int[] {2131558473});
		if (paramFilterQueryProvider != null)
		{
		  simpleCursorAdapter.setFilterQueryProvider(paramFilterQueryProvider);
		}
		ListAdapter listAdapter = this.e.getAdapter();
		if (listAdapter != null)
		{
		  ((SimpleCursorAdapter)listAdapter).getCursor().close();
		}
		this.e.setAdapter((ListAdapter)simpleCursorAdapter);
	  }

	  public virtual bool onContextItemSelected(MenuItem paramMenuItem)
	  {
		switch (paramMenuItem.getItemId())
		{
		  default:
			return true;
		  case 0:
			break;
		}
		long l = this.b;
		getContentResolver().delete(StaticDataScheme.HistoryTable.CONTENT_URI, "_id = ?", new string[] {l.ToString()});
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903059);
		getWindow().setFormat(1);
		this.e = getListView();
		this.f = (EditText)findViewById(2131558479);
		this.f.requestFocus();
		this.f.setOnTouchListener((View.OnTouchListener)new ls(this));
		registerForContextMenu((View)this.e);
		paramBundle = getIntent().getExtras();
		if (paramBundle != null && paramBundle.containsKey("type"))
		{
		  sbyte b;
		  if (paramBundle.getInt("type") == 0)
		  {
			b = 0;
		  }
		  else
		  {
			b = 2;
		  }
		  this.d = b;
		}
		string[] arrayOfString = getResources().getStringArray(2131165185);
		((List<string>)this.c).AddRange(new List<string> {arrayOfString});
		a();
		this.f.addTextChangedListener((TextWatcher)new lt(this));
	  }

	  public virtual void onCreateContextMenu(ContextMenu paramContextMenu, View paramView, ContextMenu.ContextMenuInfo paramContextMenuInfo)
	  {
		base.onCreateContextMenu(paramContextMenu, paramView, paramContextMenuInfo);
		AdapterView.AdapterContextMenuInfo adapterContextMenuInfo = (AdapterView.AdapterContextMenuInfo)paramContextMenuInfo;
		ContentResolver contentResolver = getContentResolver();
		Uri uri = StaticDataScheme.HistoryTable.CONTENT_URI;
		string str = "_id = " + adapterContextMenuInfo.id;
		Cursor cursor = contentResolver.query(uri, new string[] {"name"}, str, null, null);
		cursor.moveToFirst();
		str = cursor.getString(0);
		cursor.close();
		this.b = adapterContextMenuInfo.id;
		paramContextMenu.add(0, 0, 0, 2131296343);
		paramContextMenu.setHeaderTitle(str);
	  }

	  public virtual bool onKeyDown(int paramInt, KeyEvent paramKeyEvent)
	  {
		switch (paramInt)
		{
		  default:
			return base.onKeyDown(paramInt, paramKeyEvent);
		  case 4:
			break;
		}
		setResult(0);
	  }

	  protected internal virtual void onListItemClick(ListView paramListView, View paramView, int paramInt, long paramLong)
	  {
		Cursor cursor = ((SimpleCursorAdapter)this.e.getAdapter()).getCursor();
		cursor.moveToPosition(paramInt);
		string str = cursor.getString(1);
		Intent intent = new Intent();
		intent.putExtra("city name", str);
		intent.putExtra("taxi city", this.c.Contains(str));
		setResult(-1, intent);
		finish();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\SearchCityActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}