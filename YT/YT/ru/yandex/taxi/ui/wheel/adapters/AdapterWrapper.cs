namespace ru.yandex.taxi.ui.wheel.adapters
{
	using DataSetObserver = android.database.DataSetObserver;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using BaseAdapter = android.widget.BaseAdapter;
	using ListAdapter = android.widget.ListAdapter;
	using rc;

	public class AdapterWrapper : BaseAdapter
	{
	  private ListAdapter a = null;

	  public AdapterWrapper(ListAdapter paramListAdapter)
	  {
		this.a = paramListAdapter;
		paramListAdapter.registerDataSetObserver((DataSetObserver)new rc(this));
	  }

	  public virtual bool areAllItemsEnabled()
	  {
		return this.a.areAllItemsEnabled();
	  }

	  public virtual int Count
	  {
		  get
		  {
			return this.a.getCount();
		  }
	  }

	  public virtual object getItem(int paramInt)
	  {
		return this.a.getItem(paramInt);
	  }

	  public virtual long getItemId(int paramInt)
	  {
		return this.a.getItemId(paramInt);
	  }

	  public virtual int getItemViewType(int paramInt)
	  {
		return this.a.getItemViewType(paramInt);
	  }

	  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
	  {
		return this.a.getView(paramInt, paramView, paramViewGroup);
	  }

	  public virtual int ViewTypeCount
	  {
		  get
		  {
			return this.a.getViewTypeCount();
		  }
	  }

	  public virtual ListAdapter WrappedAdapter
	  {
		  get
		  {
			return this.a;
		  }
	  }

	  public virtual bool isEnabled(int paramInt)
	  {
		return this.a.isEnabled(paramInt);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\AdapterWrapper.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}