public sealed class bs
{
  public static string a(sbyte[] paramArrayOfbyte)
  {
	int i = paramArrayOfbyte.Length;
	char[] arrayOfChar = new char[(i + 2) / 3 << 2];
	sbyte b1 = 0;
	sbyte b2 = 0;
	while (true)
	{
	  if (b2 < i)
	  {
		int m;
		int j = (paramArrayOfbyte[b2] & 0xFF) << 8;
		if (b2 + 1 < i)
		{
		  j |= paramArrayOfbyte[b2 + 1] & 0xFF;
		  k = 1;
		}
		else
		{
		  k = 0;
		}
		j <<= 8;
		if (b2 + 2 < i)
		{
		  j |= paramArrayOfbyte[b2 + 2] & 0xFF;
		  m = 1;
		}
		else
		{
		  m = 0;
		}
		if (m)
		{
		  m = j & 0x3F;
		}
		else
		{
		  m = 64;
		}
		arrayOfChar[b1 + 3] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="[m];
		j >>= 6;
		if (k)
		{
		  k = j & 0x3F;
		}
		else
		{
		  k = 64;
		}
		arrayOfChar[b1 + 2] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="[k];
		int k = j >> 6;
		arrayOfChar[b1 + 1] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="[k & 0x3F];
		arrayOfChar[b1] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="[k >> 6 & 0x3F];
		b1 += 4;
		b2 += 3;
		continue;
	  }
	  return new string(arrayOfChar);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bs.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */