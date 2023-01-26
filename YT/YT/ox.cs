using System.Threading;

using Context = android.content.Context;
using ErrorUtils = ru.yandex.taxi.error.ErrorUtils;

internal class ox : ThreadStart
{
  internal ox(ow paramow)
  {
  }

  public virtual void run()
  {
	ErrorUtils.showErrorMessage((Context)this.a.a, this.a.a.mResources.getString(2131296328));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ox.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */