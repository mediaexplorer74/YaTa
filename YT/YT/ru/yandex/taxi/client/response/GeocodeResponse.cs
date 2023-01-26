using System;

namespace ru.yandex.taxi.client.response
{
	using JSONObject = org.json.JSONObject;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

	[Serializable]
	public class GeocodeResponse : TaxiResponse
	{
	  private JSONObject a;

	  private GeocodeJsonObject b;

	  public GeocodeResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public GeocodeResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public GeocodeResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse.Code, paramTaxiResponse.RowData)
	  {
		Blocked = paramTaxiResponse.Blocked;
		BlockDate = paramTaxiResponse.BlockDate;
	  }

	  public virtual GeocodeJsonObject GeocodeObject
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

	  public virtual JSONObject ResponseObject
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


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\GeocodeResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}