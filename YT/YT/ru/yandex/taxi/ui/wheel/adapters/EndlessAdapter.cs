using System;

namespace ru.yandex.taxi.ui.wheel.adapters
{
	using Context = android.content.Context;
	using Log = android.util.Log;
	using LayoutInflater = android.view.LayoutInflater;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using ListAdapter = android.widget.ListAdapter;
	using rd;

	public abstract class EndlessAdapter : AdapterWrapper
	{
	  private View a = null;

	  private AtomicBoolean b = new AtomicBoolean(true);

	  private Context c;

	  private int d = -1;

	  public EndlessAdapter(Context paramContext, ListAdapter paramListAdapter, int paramInt) : base(paramListAdapter)
	  {
		this.c = paramContext;
		this.d = paramInt;
	  }

	  public EndlessAdapter(ListAdapter paramListAdapter) : base(paramListAdapter)
	  {
	  }

	  public abstract void appendCachedData();

	  public abstract bool cacheInBackground();

	  protected internal virtual Context Context
	  {
		  get
		  {
			return this.c;
		  }
	  }

	  public override int Count
	  {
		  get
		  {
			return this.b.get() ? (base.Count + 1) : base.Count;
		  }
	  }

	  public override int getItemViewType(int paramInt)
	  {
		return (paramInt == WrappedAdapter.getCount()) ? -1 : base.getItemViewType(paramInt);
	  }

	  protected internal virtual View getPendingView(ViewGroup paramViewGroup)
	  {
		if (this.c != null)
		{
		  return ((LayoutInflater)this.c.getSystemService("layout_inflater")).inflate(this.d, paramViewGroup, false);
		}
		throw new Exception("You must either override getPendingView() or supply a pending View resource via the constructor");
	  }

	  public override View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
	  {
		if (paramInt == base.Count && this.b.get())
		{
		  if (this.a == null)
		  {
			this.a = getPendingView(paramViewGroup);
			(new rd(this)).execute((object[])new Void[0]);
		  }
		  return this.a;
		}
		return base.getView(paramInt, paramView, paramViewGroup);
	  }

	  public override int ViewTypeCount
	  {
		  get
		  {
			return base.ViewTypeCount + 1;
		  }
	  }

	  public virtual bool onException(View paramView, Exception paramException)
	  {
		Log.e("EndlessAdapter", "Exception in cacheInBackground()", paramException);
		return false;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\EndlessAdapter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}