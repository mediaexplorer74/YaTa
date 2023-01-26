using System;

namespace ru.yandex.taxi.client
{
	public class ValueHelper
	{
	  public static double getDouble(string paramString)
	  {
		double d = 0.0D;
		if (!string.ReferenceEquals(paramString, null))
		{
		  try
		  {
			double d1 = double.Parse(paramString);
			d = d1;
		  }
		  catch (Exception)
		  {
		  }
		}
		return d;
	  }

	  public static int getInteger(string paramString)
	  {
		int i = 0;
		if (!string.ReferenceEquals(paramString, null))
		{
		  try
		  {
			int j = int.Parse(paramString);
			i = j;
		  }
		  catch (Exception)
		  {
		  }
		}
		return i;
	  }

	  public static long getLong(string paramString)
	  {
		long l = 0L;
		if (!string.ReferenceEquals(paramString, null))
		{
		  try
		  {
			long l1 = long.Parse(paramString);
			l = l1;
		  }
		  catch (Exception)
		  {
		  }
		}
		return l;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\ValueHelper.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}