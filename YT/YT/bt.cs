using System;
using System.IO;

public sealed class bt : Reader
{
  private sbyte[] a;

  private readonly Stream b;

  public bt(Stream paramInputStream)
  {
	this.b = paramInputStream;
	this.a = new sbyte[8192];
  }

  public void close()
  {
	this.b.Close();
  }

  public int read(char[] paramArrayOfchar, int paramInt1, int paramInt2)
  {
	if (paramInt2 > this.a.Length)
	{
	  this.a = new sbyte[paramInt2 + 1];
	}
	int i = b.b(this.b, this.a, 0, Math.Min(paramInt2, this.a.Length));
	if (i > 0)
	{
	  sbyte[] arrayOfByte = this.a;
	  paramInt2 = 0;
	  int j = paramInt1;
	  while (true)
	  {
		if (paramInt2 < i)
		{
		  int k = arrayOfByte[paramInt2] & 0xFF;
		  paramInt1 = k;
		  if (k > 128)
		  {
			if (k > 191)
			{
			  paramInt1 = k + 848;
			}
			else
			{
			  switch (k)
			  {
				default:
				  paramInt1 = k;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 168:
				  paramInt1 = 1025;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 170:
				  paramInt1 = 1028;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 184:
				  paramInt1 = 1105;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 185:
				  paramInt1 = 8470;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 178:
				  paramInt1 = 1030;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 191:
				  paramInt1 = 239;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 175:
				  paramInt1 = 207;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 179:
				  paramInt1 = 1110;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 180:
				  paramInt1 = 1169;
				  paramArrayOfchar[j] = (char)(char)paramInt1;
				  j++;
				  paramInt2++;
				  continue;
				case 186:
				  break;
			  }
			  paramInt1 = 1108;
			}
		  }
		}
		else
		{
		  break;
		}
		paramArrayOfchar[j] = (char)(char)paramInt1;
		j++;
		paramInt2++;
	  }
	}
	return i;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bt.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */