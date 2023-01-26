using System.Collections.Generic;

using ServerMsg = ru.yandex.taxi.data.ServerMsg;

public class pl : IComparer<ServerMsg>
{
  public virtual int a(ServerMsg paramServerMsg1, ServerMsg paramServerMsg2)
  {
	return paramServerMsg1.date.compareTo(paramServerMsg2.date);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */