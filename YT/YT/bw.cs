using System.Text;

public sealed class bw
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public int a_Conflict;

  public int b;

  public sbyte c;

  public string d;

  private StringBuilder e;

  public bw(int paramInt1, int paramInt2, int paramInt3)
  {
	this.a_Conflict = paramInt2;
	this.b = paramInt1;
	this.c = (sbyte)(sbyte)paramInt3;
	this.e = new StringBuilder();
  }

  public void a()
  {
	if (this.e != null)
	{
	  this.d = this.e.ToString();
	  this.e = null;
	}
  }

  public void a(char paramChar)
  {
	if (this.e == null)
	{
	  this.e = new StringBuilder(this.d);
	}
	this.e.Append(paramChar);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */