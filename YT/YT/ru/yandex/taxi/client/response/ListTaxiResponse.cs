using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.client.response
{

	[Serializable]
	public class ListTaxiResponse : TaxiResponse
	{
	  private Dictionary<string, string> a = new Dictionary<string, string>();

	  private IList<Dictionary<string, string>> b = new LinkedList<Dictionary<string, string>>();

	  public ListTaxiResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public ListTaxiResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public ListTaxiResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse.Code, paramTaxiResponse.RowData)
	  {
		Blocked = paramTaxiResponse.Blocked;
		BlockDate = paramTaxiResponse.BlockDate;
	  }

	  public virtual void addListParam(Dictionary<string, string> paramHashMap)
	  {
		this.b.Add(paramHashMap);
	  }

	  public virtual void addParam(string paramString1, string paramString2)
	  {
		this.a[paramString1] = paramString2;
	  }

	  public virtual IList<Dictionary<string, string>> List
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public virtual string getParam(string paramString)
	  {
		return this.a[paramString];
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\ListTaxiResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}