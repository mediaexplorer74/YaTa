public class bx
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly char[] a_Conflict = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};

  public static string a(sbyte[] paramArrayOfbyte)
  {
	int i = 0;
	char[] arrayOfChar = new char[paramArrayOfbyte.Length << 1];
	for (sbyte b = 0; b < paramArrayOfbyte.Length; b++)
	{
	  int j = i + 1;
	  arrayOfChar[i] = (char)a_Conflict[(int)((uint)paramArrayOfbyte[b] >> 4) & 0xF];
	  i = j + 1;
	  arrayOfChar[j] = (char)a_Conflict[paramArrayOfbyte[b] & 0xF];
	}
	return new string(arrayOfChar);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */