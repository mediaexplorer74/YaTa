using System;

public sealed class h
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private sbyte[] a_Conflict;

  private int b;

  public h(int paramInt)
  {
	this.a_Conflict = new sbyte[paramInt];
	this.b = 0;
  }

  public void a(sbyte[] paramArrayOfbyte, int paramInt1, int paramInt2)
  {
	if (this.a_Conflict.Length < this.b + paramInt2)
	{
	  int i;
	  for (i = this.a_Conflict.Length; i < this.b + paramInt2; i <<= 1)
	  {
		  ;
	  }
	  sbyte[] arrayOfByte = new sbyte[i];
	  Array.Copy(this.a_Conflict, 0, arrayOfByte, 0, this.b);
	  this.a_Conflict = arrayOfByte;
	}
	Array.Copy(paramArrayOfbyte, paramInt1, this.a_Conflict, this.b, paramInt2);
	this.b += paramInt2;
  }

  public sbyte[] a()
  {
	sbyte[] arrayOfByte = new sbyte[this.b];
	Array.Copy(this.a_Conflict, 0, arrayOfByte, 0, this.b);
	return arrayOfByte;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\h.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */