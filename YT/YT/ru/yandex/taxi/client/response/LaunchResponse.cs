using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.client.response
{
	using CurrentOrder = ru.yandex.taxi.data.CurrentOrder;
	using ServerMsg = ru.yandex.taxi.data.ServerMsg;

	[Serializable]
	public class LaunchResponse : SimpleResponse
	{
	  private IList<CurrentOrder> a = new List<CurrentOrder>();

	  private IList<ServerMsg> b = new List<ServerMsg>();

	  public LaunchResponse(int paramInt) : base(paramInt)
	  {
	  }

	  public LaunchResponse(int paramInt, string paramString) : base(paramInt, paramString)
	  {
	  }

	  public LaunchResponse(TaxiResponse paramTaxiResponse) : base(paramTaxiResponse)
	  {
	  }

	  public virtual void addOrderId(CurrentOrder paramCurrentOrder)
	  {
		this.a.Add(paramCurrentOrder);
	  }

	  public virtual void addServerMsg(ServerMsg paramServerMsg)
	  {
		this.b.Add(paramServerMsg);
	  }

	  public virtual IList<CurrentOrder> CurrentOrders
	  {
		  get
		  {
			return this.a;
		  }
	  }

	  public virtual IList<ServerMsg> ServerMsgs
	  {
		  get
		  {
			return this.b;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\LaunchResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}