using System.Text;
using System.Threading;

using Context = android.content.Context;
using SharedPreferences = android.content.SharedPreferences;
using BitmapFactory = android.graphics.BitmapFactory;
using PreferenceManager = android.preference.PreferenceManager;
using Log = android.util.Log;
using Toast = android.widget.Toast;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;
using OnTheWayResponse = ru.yandex.taxi.client.response.OnTheWayResponse;
using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class ot : ThreadStart
{
  internal OnTheWayResponse a;

  private ot(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity, sbyte paramByte)
  {
  }

  public virtual void run()
  {
	int i;
	GeoPoint geoPoint;
	SharedPreferences sharedPreferences;
	bool @bool = true;
	TaxiOnTheWayToSourceActivity.f(this.b);
	TaxiOnTheWayToSourceActivity.a(this.b, this.a.BlockTime);
	if (this.a.Car != null)
	{
	  TaxiOnTheWayToSourceActivity.a(this.b, this.a.Car);
	}
	if ("transporting".Equals(this.b.mCurrentStatus))
	{
	  i = 1;
	}
	else
	{
	  i = 0;
	}
	if (this.a.Destinations.Count > i)
	{
	  geoPoint = this.a.Destinations[i];
	}
	else
	{
	  geoPoint = null;
	}
	if (this.b.mSource == null && this.a.Code == 200)
	{
	  this.b.initTaxiInfoUi((string)this.a.Taxi["parkid"], (string)this.a.Taxi["phone"], (string)this.a.Taxi["name"], (string)this.a.Tariff["tariffid"], (string)this.a.Tariff["name"]);
	  if (this.a.Driver != null)
	  {
		this.b.mDriver = this.a.Driver;
		TaxiOnTheWayToSourceActivity.a(this.b, this.a.DriverWayTime);
	  }
	  if (geoPoint != null)
	  {
		this.b.mSource = new Overlay(this.b.mMapController);
		OverlayItem overlayItem = new OverlayItem(geoPoint, this.b.mSourceBitmap);
		overlayItem.OffsetX = -this.b.mSourceBitmap.getWidth() / 4;
		overlayItem.OffsetY = this.b.mSourceBitmap.getHeight() / 2;
		if ((this.b.mWayDirection == 0 && this.b.mSrcAddress != null) || (1 == this.b.mWayDirection && this.b.mDestAddress != null))
		{
		  string str;
		  TaxiOnTheWayToSourceActivity taxiOnTheWayToSourceActivity = this.b;
		  if (this.b.mWayDirection == 0)
		  {
			str = this.b.mSrcAddress.getShortAddress();
		  }
		  else
		  {
			str = this.b.mDestAddress.getShortAddress();
		  }
		  if (1 != this.b.mWayDirection)
		  {
			@bool = false;
		  }
		  taxiOnTheWayToSourceActivity.addAddressBalloon(geoPoint, str, overlayItem, @bool);
		}
		this.b.mSource.addOverlayItem(overlayItem);
		try
		{
		  this.b.mMapController.setPositionNoAnimationTo(geoPoint);
		}
		catch (System.NullReferenceException nullPointerException)
		{
		  Log.e("TaxiOnTheWayToSourceActivity", "Fail animate to position " + nullPointerException);
		}
	  }
	  if (TaxiOnTheWayToSourceActivity.g(this.b) != null)
	  {
		TaxiOnTheWayToSourceActivity.a(this.b, new Overlay(this.b.mMapController));
		TaxiOnTheWayToSourceActivity.h(this.b).addOverlayItem(new OverlayItem(TaxiOnTheWayToSourceActivity.g(this.b), BitmapFactory.decodeResource(this.b.mResources, 2130837547)));
		if (TaxiOnTheWayToSourceActivity.g(this.b) != null)
		{
		  BalloonItem balloonItem = new BalloonItem(TaxiOnTheWayToSourceActivity.g(this.b), null);
		  StringBuilder stringBuilder = (new StringBuilder()).Append("");
		  if (this.b.mDriver.model != null && !"".Equals(this.b.mDriver.model))
		  {
			str = this.b.mDriver.model + "<br/>";
		  }
		  else
		  {
			str = "";
		  }
		  string str = stringBuilder.Append(str).ToString();
		  stringBuilder = (new StringBuilder()).Append(str);
		  if (this.b.mDriver.color != null && !"".Equals(this.b.mDriver.color))
		  {
			str = this.b.mDriver.color + "<br/>";
		  }
		  else
		  {
			str = "";
		  }
		  str = stringBuilder.Append(str).ToString();
		  stringBuilder = (new StringBuilder()).Append(str);
		  if (this.b.mDriver.plates != null && !"".Equals(this.b.mDriver.plates))
		  {
			str = this.b.mDriver.plates;
		  }
		  else
		  {
			str = "";
		  }
		  balloonItem.Text = stringBuilder.Append(str).ToString();
		  balloonItem.OnBalloonListener = new ov(this);
		  ((OverlayItem)TaxiOnTheWayToSourceActivity.h(this.b).getOverlayItems().get(0)).BalloonItem = balloonItem;
		  this.b.mMapController.showBalloon(balloonItem);
		  this.b.mMapController.notifyRepaint();
		}
	  }
	  sharedPreferences = PreferenceManager.getDefaultSharedPreferences((Context)this.b);
	  if (this.b.mArrived && !this.b.mOrderId.Equals(sharedPreferences.getString("taxi arrived dialog", "")))
	  {
		this.b.showDialog(4);
	  }
	}
	else if (this.a.Code == 200)
	{
	  if (sharedPreferences != null)
	  {
		((OverlayItem)this.b.mSource.getOverlayItems().get(0)).GeoPoint = (GeoPoint)sharedPreferences;
	  }
	  if (TaxiOnTheWayToSourceActivity.g(this.b) != null)
	  {
		if (TaxiOnTheWayToSourceActivity.h(this.b) == null)
		{
		  TaxiOnTheWayToSourceActivity.a(this.b, new Overlay(this.b.mMapController));
		  TaxiOnTheWayToSourceActivity.h(this.b).addOverlayItem(new OverlayItem(TaxiOnTheWayToSourceActivity.g(this.b), BitmapFactory.decodeResource(this.b.mResources, 2130837547)));
		}
		((OverlayItem)TaxiOnTheWayToSourceActivity.h(this.b).getOverlayItems().get(0)).GeoPoint = TaxiOnTheWayToSourceActivity.g(this.b);
	  }
	  if (this.a.Overdue)
	  {
		TaxiOnTheWayToSourceActivity taxiOnTheWayToSourceActivity = this.b;
		if (this.b.mArrived)
		{
		  i = 2131296329;
		}
		else
		{
		  i = 2131296328;
		}
		Toast.makeText((Context)taxiOnTheWayToSourceActivity, i, 0).show();
	  }
	}
	if (this.b.mSource != null)
	{
	  this.b.mOverlayManager.addOverlay(this.b.mSource);
	}
	if (TaxiOnTheWayToSourceActivity.h(this.b) != null)
	{
	  this.b.mOverlayManager.addOverlay(TaxiOnTheWayToSourceActivity.h(this.b));
	}
	else
	{
	  this.b.runOnUiThread(new ou(this));
	}
	if (!TaxiOnTheWayToSourceActivity.i(this.b) && this.b.mScreenVisible)
	{
	  TaxiOnTheWayToSourceActivity.j(this.b);
	}
	this.b.mMapController.notifyRepaint();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ot.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */