using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.client.response
{
	using Driver = ru.yandex.taxi.data.Driver;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	[Serializable]
	public class OnTheWayResponse : TaxiResponse
	{
	  public const string CANCELLED = "cancelled";

	  public const string COMPLETE = "complete";

	  public const string DRIVING = "driving";

	  public const string FAILED = "failed";

	  public const string PENDING = "pending";

	  public const string TRANSPORTING = "transporting";

	  public const string WAITING = "waiting";

	  private Dictionary<string, string> a = new Dictionary<string, string>();

	  private Dictionary<string, string> b = new Dictionary<string, string>();

	  private Driver c = new Driver();

	  private IList<GeoPoint> d = new LinkedList<GeoPoint>();

	  private string e;

	  private bool f;

	  private GeoPoint g;

	  private bool h;

	  private int i;

	  private bool j;

	  private string k;

	  public OnTheWayResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public OnTheWayResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public OnTheWayResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse.Code, paramTaxiResponse.RowData)
	  {
		Blocked = paramTaxiResponse.Blocked;
		BlockDate = paramTaxiResponse.BlockDate;
	  }

	  public virtual void addDestination(double paramDouble1, double paramDouble2)
	  {
		this.d.Add(new GeoPoint(paramDouble2, paramDouble1));
	  }

	  public virtual string BlockTime
	  {
		  get
		  {
			return this.k;
		  }
		  set
		  {
			this.k = value;
		  }
	  }

	  public virtual GeoPoint Car
	  {
		  get
		  {
			return this.g;
		  }
	  }

	  public virtual IList<GeoPoint> Destinations
	  {
		  get
		  {
			return this.d;
		  }
	  }

	  public virtual Driver Driver
	  {
		  get
		  {
			return this.c;
		  }
	  }

	  public virtual int DriverWayTime
	  {
		  get
		  {
			return this.i;
		  }
		  set
		  {
			this.i = value;
		  }
	  }

	  public virtual string Status
	  {
		  get
		  {
			return this.e;
		  }
		  set
		  {
			this.e = value;
		  }
	  }

	  public virtual Dictionary<string, string> Tariff
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public virtual Dictionary<string, string> Taxi
	  {
		  get
		  {
			return this.a;
		  }
	  }

	  public virtual bool Cancelled
	  {
		  get
		  {
			return this.f;
		  }
		  set
		  {
			this.f = value;
		  }
	  }

	  public virtual bool Finished
	  {
		  get
		  {
			return this.h;
		  }
		  set
		  {
			this.h = value;
		  }
	  }

	  public virtual bool Overdue
	  {
		  get
		  {
			return this.j;
		  }
		  set
		  {
			this.j = value;
		  }
	  }



	  public virtual void setCar(double paramDouble1, double paramDouble2)
	  {
		this.g = new GeoPoint(paramDouble2, paramDouble1);
	  }

	  public virtual void setDriver(string paramString1, string paramString2, string paramString3, string paramString4, string paramString5)
	  {
		this.c.model = paramString1;
		this.c.color = paramString2;
		this.c.plates = paramString3;
		this.c.name = paramString4;
		this.c.phone = paramString5;
	  }





	  public virtual void setTariff(string paramString1, string paramString2)
	  {
		this.b["tariffid"] = paramString1;
		this.b["name"] = paramString2;
	  }

	  public virtual void setTaxi(string paramString1, string paramString2, string paramString3, string paramString4)
	  {
		this.a["parkid"] = paramString1;
		this.a["name"] = paramString2;
		this.a["logo"] = paramString3;
		this.a["phone"] = paramString4;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\OnTheWayResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}