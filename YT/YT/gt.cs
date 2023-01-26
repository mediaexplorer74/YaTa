using System.Threading;

using Activity = android.app.Activity;
using Log = android.util.Log;
using ru.yandex.taxi;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using MapUtils = ru.yandex.taxi.map.MapUtils;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class gt : ThreadStart
{
  public gt(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual void run()
  {
	try
	{
	  EditAddressActivity editAddressActivity = this.a;
	  gu gu = new gu();
	  this(this);
	  Pair pair = MapUtils.getLbsLocation((Activity)editAddressActivity, gu, true);
	  editAddressActivity = this.a;
	  if (pair != null)
	  {
		GeoPoint geoPoint = (GeoPoint)pair.first;
	  }
	  else
	  {
		pair = null;
	  }
	  EditAddressActivity.a(editAddressActivity, (GeoPoint)pair);
	}
	catch (IOException iOException)
	{
	  Log.e("EditAddressActivity", "Fail get user location", iOException);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gt.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */