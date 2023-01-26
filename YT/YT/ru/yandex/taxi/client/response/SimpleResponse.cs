using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.client.response
{

	[Serializable]
	public class SimpleResponse : TaxiResponse
	{
	  private Dictionary<string, string> a = new Dictionary<string, string>();

	  public SimpleResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public SimpleResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public SimpleResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse.Code, paramTaxiResponse.RowData)
	  {
		Blocked = paramTaxiResponse.Blocked;
		BlockDate = paramTaxiResponse.BlockDate;
		BlockType = paramTaxiResponse.BlockType;
	  }

	  public virtual Dictionary<string, string> Data
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


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\SimpleResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}