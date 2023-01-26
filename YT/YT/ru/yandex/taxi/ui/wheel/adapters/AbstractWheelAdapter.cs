using System.Collections.Generic;

namespace ru.yandex.taxi.ui.wheel.adapters
{
	using DataSetObserver = android.database.DataSetObserver;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;

	public abstract class AbstractWheelAdapter : WheelViewAdapter
	{
		public abstract int ItemsCount {get;}
		public abstract View getItem(int paramInt, View paramView, ViewGroup paramViewGroup);
	  private IList<DataSetObserver> a;

	  public virtual View getEmptyItem(View paramView, ViewGroup paramViewGroup)
	  {
		return null;
	  }

	  protected internal virtual void notifyDataChangedEvent()
	  {
		if (this.a != null)
		{
		  IEnumerator<DataSetObserver> iterator = this.a.GetEnumerator();
		  while (iterator.MoveNext())
		  {
			((DataSetObserver)iterator.Current).onChanged();
		  }
		}
	  }

	  protected internal virtual void notifyDataInvalidatedEvent()
	  {
		if (this.a != null)
		{
		  IEnumerator<DataSetObserver> iterator = this.a.GetEnumerator();
		  while (iterator.MoveNext())
		  {
			((DataSetObserver)iterator.Current).onInvalidated();
		  }
		}
	  }

	  public virtual void registerDataSetObserver(DataSetObserver paramDataSetObserver)
	  {
		if (this.a == null)
		{
		  this.a = new LinkedList<DataSetObserver>();
		}
		this.a.Add(paramDataSetObserver);
	  }

	  public virtual void unregisterDataSetObserver(DataSetObserver paramDataSetObserver)
	  {
		if (this.a != null)
		{
		  this.a.Remove(paramDataSetObserver);
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\AbstractWheelAdapter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}