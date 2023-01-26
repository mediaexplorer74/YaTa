using System.IO;

namespace ru.yandex.taxi.analytics
{
	using Build = android.os.Build;

	public sealed class Tools
	{
	  public static bool Android15
	  {
		  get
		  {
			bool @bool = true;
			string str = Build.VERSION.SDK;
			if (string.ReferenceEquals(str, null) || str.Length != 1 || !str.Equals("3"))
			{
			  @bool = false;
			}
			return @bool;
		  }
	  }

	  public static sbyte[] readAll(Stream paramInputStream)
	  {
		if (paramInputStream != null)
		{
		  sbyte[] arrayOfByte = new sbyte[1024];
		  MemoryStream byteArrayOutputStream = new MemoryStream();
		  try
		  {
			while (true)
			{
			  int i = paramInputStream.Read(arrayOfByte, 0, arrayOfByte.Length);
			  if (i == -1)
			  {
				return byteArrayOutputStream.toByteArray();
			  }
			  if (i > 0)
			  {
				byteArrayOutputStream.Write(arrayOfByte, 0, i);
			  }
			}
		  }
		  finally
		  {
			if (byteArrayOutputStream != null)
			{
			  byteArrayOutputStream.Close();
			}
		  }
		}
		return null;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\analytics\Tools.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}