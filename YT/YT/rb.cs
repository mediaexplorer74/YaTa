using DataSetObserver = android.database.DataSetObserver;
using WheelView = ru.yandex.taxi.ui.wheel.WheelView;

public class rb : DataSetObserver
{
  public rb(WheelView paramWheelView)
  {
  }

  public virtual void onChanged()
  {
	this.a.invalidateWheel(false);
  }

  public virtual void onInvalidated()
  {
	this.a.invalidateWheel(true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\rb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */