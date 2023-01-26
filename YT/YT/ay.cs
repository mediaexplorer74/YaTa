using System.Text;

public sealed class ay
{
  public readonly double a;

  public readonly double b;

  public readonly int c;

  public readonly int d;

  internal ay(double paramDouble1, double paramDouble2, int paramInt, string paramString)
  {
	this.a = paramDouble1;
	this.b = paramDouble2;
	this.c = paramInt;
	if ("red".Equals(paramString))
	{
	  this.d = 1;
	}
	else if ("yellow".Equals(paramString))
	{
	  this.d = 2;
	}
	else if ("green".Equals(paramString))
	{
	  this.d = 3;
	}
	else if ("false".Equals(paramString))
	{
	  this.d = 4;
	}
	else
	{
	  this.d = 4;
	}
	StringBuilder stringBuilder = new StringBuilder(11);
	if (this.c >= 0 && this.d != 0)
	{
	  stringBuilder.Append("балл");
	  if (this.c >= 2 && this.c <= 4)
	  {
		stringBuilder.Append("а");
		return;
	  }
	  if (this.c == 0 || this.c >= 5)
	  {
		stringBuilder.Append("ов");
	  }
	  return;
	}
	stringBuilder.Append("нет данных");
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ay.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */