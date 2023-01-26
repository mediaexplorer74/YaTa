using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class aj
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public int a_Conflict;

  public int b;

  public int c;

  public aj(int paramInt1, int paramInt2, int paramInt3)
  {
	this.a_Conflict = paramInt1;
	this.b = paramInt2;
	this.c = paramInt3;
  }

  public GeoPoint a()
  {
	return CoordConversion.toLL(new by(this.a_Conflict, this.b));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\aj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */