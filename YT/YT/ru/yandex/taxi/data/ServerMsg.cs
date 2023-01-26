using System;

namespace ru.yandex.taxi.data
{

	public class ServerMsg
	{
	  public DateTime date;

	  public string header;

	  public string msg;

	  public ServerMsg(string paramString1, string paramString2, DateTime paramDate)
	  {
		this.header = paramString1;
		this.msg = paramString2;
		this.date = paramDate;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\ServerMsg.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}