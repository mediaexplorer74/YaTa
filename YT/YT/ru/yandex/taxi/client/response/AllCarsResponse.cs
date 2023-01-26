using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.client.response
{
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	[Serializable]
	public class AllCarsResponse : TaxiResponse
	{
	  private IList<GeoPoint> a = new LinkedList<GeoPoint>();

	  private IList<GeoPoint> b = new LinkedList<GeoPoint>();

	  public AllCarsResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public AllCarsResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public AllCarsResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse.Code, paramTaxiResponse.RowData)
	  {
		Blocked = paramTaxiResponse.Blocked;
		BlockDate = paramTaxiResponse.BlockDate;
	  }

	  public virtual void addBusyCar(GeoPoint paramGeoPoint)
	  {
		this.b.Add(paramGeoPoint);
	  }

	  public virtual void addFreeCar(GeoPoint paramGeoPoint)
	  {
		this.a.Add(paramGeoPoint);
	  }

	  public virtual IList<GeoPoint> BusyCars
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public virtual IList<GeoPoint> FreeCars
	  {
		  get
		  {
			return this.a;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\AllCarsResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}