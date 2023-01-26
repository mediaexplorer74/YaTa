using System;

namespace ru.yandex.yandexmapkit.utils
{
	using by;

	public sealed class CoordConversion
	{
	  public const double R = 6378137.0D;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static double a_Conflict = 3.141592653589D;

	  private static double b = 1.5707963267945D;

	  private static double c = a_Conflict * 0.25D;

	  private static double d = a_Conflict / 180.0D;

	  public const double defaultFactor = 53.5865939582453D;

	  private static double e = 180.0D / a_Conflict;

	  public const double earthEquatorLength2 = 2.0037508342789244E7D;

	  private static readonly double f = Math.Sqrt(0.00669437999014133D);

	  public static double GPS_Math_Deg_To_Rad(double paramDouble)
	  {
		return d * paramDouble;
	  }

	  public static double GPS_Math_Rad_To_Deg(double paramDouble)
	  {
		return e * paramDouble;
	  }

	  private static double a(double paramDouble1, double paramDouble2)
	  {
		double d = 0.0D;
		if (paramDouble2 != 0.0D)
		{
		  return paramDouble1 / paramDouble2;
		}
		paramDouble2 = d;
		if (paramDouble1 == 0.0D)
		{
		  paramDouble2 = 1.0D;
		}
		return paramDouble2;
	  }

	  public static double getDistance(double paramDouble1, double paramDouble2, double paramDouble3, double paramDouble4)
	  {
		if (paramDouble1 == paramDouble3 && paramDouble2 == paramDouble4)
		{
		  return 0.0D;
		}
		double d1 = GPS_Math_Deg_To_Rad(paramDouble2 - paramDouble4);
		paramDouble2 = GPS_Math_Deg_To_Rad(paramDouble1 - paramDouble3);
		paramDouble4 = Math.Sin(GPS_Math_Deg_To_Rad((paramDouble1 + paramDouble3) * 0.5D));
		double d2 = 1.0D - paramDouble4 * paramDouble4 * 0.006705621329494961D;
		paramDouble4 = a(6335367.6284903595D, Math.Pow(d2, 1.5D));
		d2 = a(6378137.0D, Math.Sqrt(d2));
		paramDouble2 = Math.Sin(paramDouble2 * 0.5D);
		double d3 = Math.Sin(0.5D * d1);
		paramDouble2 = Math.Sqrt(paramDouble2 * paramDouble2 + d3 * Math.Cos(d * paramDouble3) * Math.Cos(d * paramDouble1) * d3);
		paramDouble1 = paramDouble2;
		if (paramDouble2 < -1.0D)
		{
		  paramDouble1 = -1.0D;
		}
		paramDouble2 = paramDouble1;
		if (paramDouble1 > 1.0D)
		{
		  paramDouble2 = 1.0D;
		}
		d3 = 2.0D * Math.Asin(paramDouble2);
		paramDouble2 = Math.Cos(d * paramDouble3) * Math.Sin(d1) / Math.Sin(d3);
		paramDouble1 = paramDouble2;
		if (paramDouble2 < -1.0D)
		{
		  paramDouble1 = -1.0D;
		}
		paramDouble2 = paramDouble1;
		if (paramDouble1 > 1.0D)
		{
		  paramDouble2 = 1.0D;
		}
		paramDouble1 = paramDouble2 * paramDouble2;
		return a(paramDouble4 * d2, (1.0D - paramDouble1) * d2 + paramDouble4 * paramDouble1) * d3;
	  }

	  public static double getDistance(GeoPoint paramGeoPoint1, GeoPoint paramGeoPoint2)
	  {
		return getDistance(paramGeoPoint1.Lat, paramGeoPoint1.Lon, paramGeoPoint2.Lat, paramGeoPoint2.Lon);
	  }

	  public static GeoPoint getPointLLaddMetrs(GeoPoint paramGeoPoint, int paramInt)
	  {
		return new GeoPoint(paramGeoPoint.Lat + paramInt / 111120.0D, paramGeoPoint.Lon);
	  }

	  public static GeoPoint toLL(by paramby)
	  {
		double d1 = paramby.x / 53.5865939582453D;
		double d2 = -paramby.y / 53.5865939582453D;
		double d3 = b - Math.Atan(1.0D / Math.Exp((d2 + 2.0037508342789244E7D) / 6378137.0D)) * 2.0D;
		d2 = Math.Sin(d3 * 2.0D);
		double d4 = Math.Sin(4.0D * d3);
		double d5 = Math.Sin(6.0D * d3);
		d2 = Math.Sin(d3 * 8.0D) * 5.328478445E-11D + 0.003356551468879694D * d2 + d3 + 6.57187271079536E-6D * d4 + 1.764564338702E-8D * d5;
		d5 = (d1 - 2.0037508342789244E7D) / 6378137.0D;
		d1 = d2;
		if (Math.Abs(d2) > b)
		{
		  d1 = b;
		}
		d2 = d5;
		if (Math.Abs(d5) > a_Conflict)
		{
		  d2 = a_Conflict;
		}
		return new GeoPoint(d1 * e, d2 * e);
	  }

	  public static by toXY(GeoPoint paramGeoPoint, by paramby)
	  {
		double d1 = paramGeoPoint.Lat;
		double d2 = paramGeoPoint.Lon;
		if (d1 > 89.3D)
		{
		  d3 = 89.3D;
		}
		else
		{
		  d3 = d1;
		  if (d1 < -89.3D)
		  {
			d3 = -89.3D;
		  }
		}
		if (d2 > 180.0D)
		{
		  d1 = 180.0D;
		}
		else
		{
		  d1 = d2;
		  if (d2 < -180.0D)
		  {
			d1 = -180.0D;
		  }
		}
		double d4 = d3 * d;
		double d5 = d;
		d2 = f;
		double d3 = Math.Sin(d4);
		double d6 = Math.Tan(d4 * 0.5D + c);
		d4 = c;
		long l1 = (long)(Math.Log(d6 / Math.Pow(Math.Tan(Math.Asin(d2 * d3) * 0.5D + d4), f)) * 6378137.0D);
		long l2 = (long)(d1 * d5 * 6378137.0D);
		l1 = (long)((l1 - 2.0037508342789244E7D) * -53.5865939582453D);
		l2 = (long)((l2 + 2.0037508342789244E7D) * 53.5865939582453D);
		by by1 = paramby;
		if (paramby == null)
		{
		  by1 = new by();
		}
		by1.x = l2;
		by1.y = l1;
		return by1;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapki\\utils\CoordConversion.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}