using System;
using System.IO;

namespace ru.yandex.taxi.suggest
{

	public class Utils
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal static sbyte[] a_Conflict = new sbyte[2];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal static sbyte[] b_Conflict = new sbyte[4];

	  public static short a(Stream paramInputStream)
	  {
		short s3;
		short s1 = 0;
		short s2 = 0;
		try
		{
		  paramInputStream.Read(a_Conflict, 0, a_Conflict.Length);
		  sbyte b = 0;
		  while (true)
		  {
			s3 = s2;
			if (b < 2)
			{
			  s1 = s2;
			  sbyte b1 = a_Conflict[b];
			  s2 = (short)(s2 | (short)(b1 & 0xFF) << b << 3);
			  b++;
			  continue;
			}
			break;
		  }
		}
		catch (IOException)
		{
		  s3 = s1;
		}
		return s3;
	  }

	  public static short a(sbyte[] paramArrayOfbyte)
	  {
		sbyte b = 0;
		short s1 = 0;
		short s2;
		for (s2 = s1; b < 2 && b < paramArrayOfbyte.Length; s2 = s1)
		{
		  s1 = (short)(s2 | (paramArrayOfbyte[b] & 0xFF) << b << 3);
		  b++;
		}
		return s2;
	  }

	  public static int b(Stream paramInputStream)
	  {
		int i = 0;
		int j = 0;
		try
		{
		  paramInputStream.Read(b_Conflict, 0, b_Conflict.Length);
		  i = 0;
		  while (true)
		  {
			int k = i;
			i = j;
			if (k < 4)
			{
			  i = j;
			  sbyte b = b[k];
			  i = k + 1;
			  j = (b & 0xFF) << k << 3 | j;
			  continue;
			}
			break;
		  }
		}
		catch (IOException)
		{
		}
		return i;
	  }

	  public static int b(sbyte[] paramArrayOfbyte)
	  {
		sbyte b = 0;
		int i = 0;
		while (b < 4 && b < paramArrayOfbyte.Length)
		{
		  i |= (paramArrayOfbyte[b] & 0xFF) << b << 3;
		  b++;
		}
		return i;
	  }

	  public static sbyte[] readMassive(sbyte[] paramArrayOfbyte, int paramInt1, int paramInt2)
	  {
		sbyte[] arrayOfByte = new sbyte[paramInt2];
		Array.Copy(paramArrayOfbyte, paramInt1, arrayOfByte, 0, paramInt2);
		return arrayOfByte;
	  }

	  public static T[] removingItemFromArray<T>(T[] paramArrayOfT, int paramInt)
	  {
		return removingItemFromArray(paramArrayOfT, paramInt, 0);
	  }

	  public static T[] removingItemFromArray<T>(T[] paramArrayOfT, int paramInt1, int paramInt2)
	  {
		object[] arrayOfObject1 = null;
		object[] arrayOfObject2 = arrayOfObject1;
		if (paramArrayOfT != null)
		{
		  if (paramInt2 <= 0)
		  {
			paramInt2 = paramArrayOfT.Length - 1 - paramInt2;
		  }
		  else
		  {
			paramInt2--;
		  }
		  arrayOfObject2 = arrayOfObject1;
		  if (paramInt2 > 0)
		  {
			arrayOfObject2 = (object[])Array.CreateInstance(paramArrayOfT[0].GetType(), paramInt2);
			if (paramInt1 > 0)
			{
			  if (paramInt1 < paramInt2)
			  {
				Array.Copy(paramArrayOfT, 0, arrayOfObject2, 0, paramInt1);
				Array.Copy(paramArrayOfT, paramInt1 + 1, arrayOfObject2, paramInt1, paramInt2 - paramInt1);
				return (T[])arrayOfObject2;
			  }
			  Array.Copy(paramArrayOfT, 0, arrayOfObject2, 0, paramInt2);
			  return (T[])arrayOfObject2;
			}
		  }
		  else
		  {
			return (T[])arrayOfObject2;
		  }
		}
		else
		{
		  return (T[])arrayOfObject2;
		}
		Array.Copy(paramArrayOfT, 1, arrayOfObject2, 0, paramInt2);
		return (T[])arrayOfObject2;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\suggest\Utils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}