namespace ru.yandex.taxi.ui.wheel.adapters
{
	using DataSetObserver = android.database.DataSetObserver;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;

	public interface WheelViewAdapter
	{
	  View getEmptyItem(View paramView, ViewGroup paramViewGroup);

	  View getItem(int paramInt, View paramView, ViewGroup paramViewGroup);

	  int ItemsCount {get;}

	  void registerDataSetObserver(DataSetObserver paramDataSetObserver);

	  void unregisterDataSetObserver(DataSetObserver paramDataSetObserver);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\WheelViewAdapter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}