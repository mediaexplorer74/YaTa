using DataSetObserver = android.database.DataSetObserver;
using AdapterWrapper = ru.yandex.taxi.ui.wheel.adapters.AdapterWrapper;

public class rc : DataSetObserver
{
  public rc(AdapterWrapper paramAdapterWrapper)
  {
  }

  public virtual void onChanged()
  {
	this.a.notifyDataSetChanged();
  }

  public virtual void onInvalidated()
  {
	this.a.notifyDataSetInvalidated();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\rc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */