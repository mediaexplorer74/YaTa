using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.client.response
{
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	[Serializable]
	public class SearchResponse : TaxiResponse
	{
	  private bool a;

	  private bool b;

	  private string c;

	  private GeoPoint d;

	  private IList<GeoPoint> e = new LinkedList<GeoPoint>();

	  private IList<GeoPoint> f = new LinkedList<GeoPoint>();

	  public SearchResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public SearchResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public SearchResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse.Code, paramTaxiResponse.RowData)
	  {
		Blocked = paramTaxiResponse.Blocked;
		BlockDate = paramTaxiResponse.BlockDate;
	  }

	  public virtual void addBusyCar(GeoPoint paramGeoPoint)
	  {
		this.f.Add(paramGeoPoint);
	  }

	  public virtual void addFreeCar(GeoPoint paramGeoPoint)
	  {
		this.e.Add(paramGeoPoint);
	  }

	  public virtual IList<GeoPoint> BusyCars
	  {
		  get
		  {
			return this.f;
		  }
	  }

	  public virtual string Calibrate
	  {
		  get
		  {
			return this.c;
		  }
		  set
		  {
			this.c = value;
		  }
	  }

	  public virtual IList<GeoPoint> FreeCars
	  {
		  get
		  {
			return this.e;
		  }
	  }

	  public virtual GeoPoint Source
	  {
		  get
		  {
			return this.d;
		  }
		  set
		  {
			this.d = value;
		  }
	  }

	  public virtual bool Expired
	  {
		  get
		  {
			return this.b;
		  }
		  set
		  {
			this.b = value;
		  }
	  }

	  public virtual bool Found
	  {
		  get
		  {
			return this.a;
		  }
		  set
		  {
			this.a = value;
		  }
	  }




	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\SearchResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}