using System;

namespace ru.yandex.taxi.client.response
{

	[Serializable]
	public class TaxiResponse
	{
	  private int a;

	  private string b;

	  private bool c;

	  private DateTime d;

	  private string e;

	  public TaxiResponse(int paramInt)
	  {
		this.a = paramInt;
	  }

	  public TaxiResponse(int paramInt, string paramString)
	  {
		this.a = paramInt;
		this.b = paramString;
	  }

	  public virtual DateTime BlockDate
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

	  public virtual string BlockType
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

	  public virtual int Code
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

	  public virtual string RowData
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

	  public virtual bool Blocked
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





	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\response\TaxiResponse.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}