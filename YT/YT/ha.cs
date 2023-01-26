using Activity = android.app.Activity;
using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using EditText = android.widget.EditText;
using ru.yandex.taxi;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using MapUtils = ru.yandex.taxi.map.MapUtils;
using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class ha : AsyncTask<int, int, GeocodeJsonObject>
{
  private bool c;

  public ha(EditAddressActivity paramEditAddressActivity, int paramInt)
  {
  }

  private GeocodeJsonObject a(Pair<GeoPoint, bool> paramPair)
  {
	GeoPoint geoPoint;
	if (paramPair == null)
	{
	  geoPoint = null;
	}
	else
	{
	  geoPoint = (GeoPoint)paramPair.first;
	}
	if (geoPoint != null)
	{
	  GeocodeJsonObject geocodeJsonObject = EditAddressActivity.s(this.b).getGeoObject(geoPoint);
	  if (paramPair != null)
	  {
		((bool?)paramPair.second).Value;
	  }
	  return geocodeJsonObject;
	}
	return null;
  }

  protected internal virtual GeocodeJsonObject a()
  {
	bool bool1 = true;
	Pair<GeoPoint, bool> pair = new Pair();
	try
	{
	  bool @bool;
	  EditAddressActivity editAddressActivity = this.b;
	  hb hb = new hb();
	  this(this);
	  if (this.a == 1)
	  {
		@bool = true;
	  }
	  else
	  {
		@bool = false;
	  }
	  Pair<GeoPoint, bool> pair1 = MapUtils.getLbsLocation((Activity)editAddressActivity, hb, @bool);
	  pair = pair1;
	  if (pair == null)
	  {
		@bool = bool1;
		this.c = @bool;
		return a(pair);
	  }
	}
	catch (IOException iOException)
	{
	  Log.e("EditAddressActivity", "Fail get user location", iOException);
	  if (pair == null)
	  {
		bool @bool = bool1;
		this.c = @bool;
		return a(pair);
	  }
	}
	bool bool2 = false;
	this.c = bool2;
	return a(pair);
  }

  protected internal virtual void a(GeocodeJsonObject paramGeocodeJsonObject)
  {
	bool @bool = true;
	if (!this.c && paramGeocodeJsonObject != null && !EditAddressActivity.p(this.b))
	{
	  bool bool1;
	  bool bool2;
	  EditText editText;
	  EditAddressActivity editAddressActivity;
	  EditAddressActivity.b(this.b, paramGeocodeJsonObject.GeoPoint);
	  if (EditAddressActivity.b(this.b) != null && CoordConversion.getDistance(EditAddressActivity.b(this.b), MapUtils.DEFAULT_POINT) < 100000.0D)
	  {
		bool1 = true;
	  }
	  else
	  {
		bool1 = false;
	  }
	  if (EditAddressActivity.q(this.b).contains(EditAddressActivity.c(this.b).getText().ToString()) || bool1)
	  {
		bool2 = true;
	  }
	  else
	  {
		bool2 = false;
	  }
	  switch (this.a)
	  {
		default:
		  if (bool2)
		  {
			EditAddressActivity.k(this.b).setEnabled(true);
			EditAddressActivity.k(this.b).requestFocus();
		  }
		  if (!bool2 || "".Equals(EditAddressActivity.f(this.b).getText().ToString()))
		  {
			@bool = false;
		  }
		  EditAddressActivity.g(this.b).setEnabled(@bool);
		  EditAddressActivity.h(this.b).setEnabled(@bool);
		  EditAddressActivity.i(this.b).setEnabled(@bool);
		  EditAddressActivity.j(this.b).setEnabled(@bool);
		  if (@bool)
		  {
			EditAddressActivity.g(this.b).requestFocus();
		  }
		  else
		  {
			break;
		  }
		  if (!this.c)
		  {
			EditAddressActivity.r(this.b).dismiss();
		  }
		  return;
		case 0:
		  EditAddressActivity.c(this.b).setText(paramGeocodeJsonObject.City);
		  if (EditAddressActivity.q(this.b).contains(EditAddressActivity.c(this.b).getText().ToString()) || bool1)
		  {
			bool2 = true;
		  }
		  else
		  {
			bool2 = false;
		  }
		  EditAddressActivity.f(this.b).setEnabled(bool2);
			goto case 1;
		case 1:
		  editText = EditAddressActivity.f(this.b);
		  editAddressActivity = this.b;
		  editText.setText(EditAddressActivity.a(paramGeocodeJsonObject));
		  break;
	  }
	  if (!bool2 && !"".Equals(EditAddressActivity.c(this.b).getText().ToString()))
	  {
		EditAddressActivity.n(this.b);
		this.b.finish();
	  }
	}
	else if (!this.c && paramGeocodeJsonObject == null)
	{
	  this.b.showDialog(0);
	}
	if (!this.c)
	{
	  EditAddressActivity.r(this.b).dismiss();
	}
  }

  protected internal virtual void onPreExecute()
  {
	EditAddressActivity.a(this.b, ProgressDialog.show((Context)this.b, "", this.b.getResources().getString(2131296366), true, true, new he(this)));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ha.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */