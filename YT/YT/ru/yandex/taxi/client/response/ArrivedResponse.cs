using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.client.response
{

	[Serializable]
	public class ArrivedResponse : TaxiResponse
	{
	  private Dictionary<string, string> a = new Dictionary<string, string>();

	  private Dictionary<string, string> b = new Dictionary<string, string>();

	  private Dictionary<string, string> c = new Dictionary<string, string>();

	  public ArrivedResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public ArrivedResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public ArrivedResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse.Code, paramTaxiResponse.RowData)
	  {
		Blocked = paramTaxiResponse.Blocked;
		BlockDate = paramTaxiResponse.BlockDate;
	  }

	  public virtual void addParam(string paramString1, string paramString2)
	  {
		this.c[paramString1] = paramString2;
	  }

	  public virtual Dictionary<string, string> Params
	  {
		  get
		  {
			return this.c;
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

	  public virtual void setTariff(string paramString1, string paramString2)
	  {
		this.b["tariffid"] = paramString1;
		this.b["name"] = paramString2;
	  }

	  public virtual void setTaxi(string paramString1, string paramString2)
	  {
		this.a["parkid"] = paramString1;
		this.a["name"] = paramString2;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\ArrivedResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}