using System.Collections;
using System.Collections.Generic;
using System.Threading;

using Bitmap = android.graphics.Bitmap;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;
using SearchResponse = ru.yandex.taxi.client.response.SearchResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class nd : ThreadStart
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal SearchResponse a_Conflict;

  private nd(SearchTaxiActivity paramSearchTaxiActivity, sbyte paramByte)
  {
  }

  private static IList<GeoPoint> a(GeoPoint paramGeoPoint, IList<GeoPoint> paramList, double paramDouble)
  {
	List<GeoPoint> arrayList = new ArrayList();
	foreach (GeoPoint geoPoint in paramList)
	{
	  if (CoordConversion.getDistance(paramGeoPoint, geoPoint) <= paramDouble)
	  {
		arrayList.Add(geoPoint);
	  }
	}
	return arrayList;
  }

  private static void a(Overlay paramOverlay, IList<GeoPoint> paramList, Bitmap paramBitmap)
  {
	IList<OverlayItem> list = paramOverlay.OverlayItems;
	int i;
	for (i = 0; i < paramList.Count; i++)
	{
	  GeoPoint geoPoint = paramList[i];
	  if (i >= list.Count)
	  {
		paramOverlay.addOverlayItem(new OverlayItem(geoPoint, paramBitmap));
	  }
	  else
	  {
		((OverlayItem)list[i]).GeoPoint = geoPoint;
	  }
	}
	int j = list.Count;
	for (i = paramList.Count; i < j; i++)
	{
	  paramOverlay.removeOverlayItem(list[i]);
	}
  }

  public virtual void run()
  {
	if (!this.b.mInterrupt)
	{
	  GeoPoint geoPoint = this.a_Conflict.Source;
	  if (this.b.mSrcAddress == null)
	  {
		this.b.initRouteObjects(geoPoint);
		this.b.mSrcAddress = new GeocodeJsonObject();
		this.b.mSrcAddress.setGeoPoint(geoPoint);
		SearchTaxiActivity.a(this.b).setPositionNoAnimationTo(this.b.mSrcAddress.getGeoPoint());
		SearchTaxiActivity.d(this.b);
	  }
	  if (SearchTaxiActivity.i(this.b) != null)
	  {
		SearchTaxiActivity.i(this.b).dismiss();
	  }
	  ((OverlayItem)this.b.mUser.getOverlayItems().get(0)).GeoPoint = geoPoint;
	  ((OverlayItem)SearchTaxiActivity.j(this.b).getOverlayItems().get(0)).GeoPoint = geoPoint;
	  double[] arrayOfDouble = new double[this.a_Conflict.FreeCars.Count];
	  SearchTaxiActivity.initCarDistances(geoPoint, this.a_Conflict.FreeCars, arrayOfDouble);
	  arrayOfDouble = new double[this.a_Conflict.BusyCars.Count];
	  SearchTaxiActivity.initCarDistances(geoPoint, this.a_Conflict.BusyCars, arrayOfDouble);
	  IList<GeoPoint> list2 = a(geoPoint, this.a_Conflict.FreeCars, 5000.0D);
	  this.a_Conflict.FreeCars.RemoveAll(list2);
	  IList<GeoPoint> list3 = this.a_Conflict.FreeCars;
	  IList<GeoPoint> list1 = a(geoPoint, this.a_Conflict.BusyCars, 5000.0D);
	  this.a_Conflict.BusyCars.RemoveAll(list1);
	  IList<GeoPoint> list4 = this.a_Conflict.BusyCars;
	  a(SearchTaxiActivity.k(this.b), list2, SearchTaxiActivity.l(this.b));
	  a(SearchTaxiActivity.m(this.b), list3, SearchTaxiActivity.n(this.b));
	  a(SearchTaxiActivity.o(this.b), list1, SearchTaxiActivity.p(this.b));
	  a(SearchTaxiActivity.q(this.b), list4, SearchTaxiActivity.r(this.b));
	  if (this.b.mInitZoomFinished)
	  {
		bool @bool = this.b.mWrapTaxiZoomFinished;
	  }
	  if (!this.b.mInitZoom)
	  {
		SearchTaxiActivity.s(this.b);
	  }
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */