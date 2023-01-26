using System;

using Location = android.location.Location;
using LocationListener = android.location.LocationListener;
using Bundle = android.os.Bundle;
using MyLocationOverlay = ru.yandex.yandexmapkit.overlay.location.MyLocationOverlay;
using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class bq : LocationListener
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal MyLocationOverlay a_Conflict = null;

  private bool b = false;

  public bq(MyLocationOverlay paramMyLocationOverlay)
  {
	this.a_Conflict = paramMyLocationOverlay;
  }

  public virtual void a(bool paramBoolean)
  {
	this.b = paramBoolean;
  }

  public virtual bool a()
  {
	return this.b;
  }

  public virtual void onLocationChanged(Location paramLocation)
  {
	if (paramLocation != null && "network".Equals(paramLocation.getProvider()))
	{
	  GeoPoint geoPoint = new GeoPoint(paramLocation.getLatitude(), paramLocation.getLongitude());
	  this.a_Conflict.i.GeoPoint = geoPoint;
	  this.a_Conflict.h_Conflict.GeoPoint = geoPoint;
	  if (paramLocation.hasAccuracy())
	  {
		by by1 = CoordConversion.toXY(CoordConversion.getPointLLaddMetrs(geoPoint, (int)paramLocation.getAccuracy()), null);
		by by2 = CoordConversion.toXY(geoPoint, null);
		int i = (int)Math.Abs(by1.y - by2.y);
		this.a_Conflict.i.a(i);
	  }
	  if (!this.a_Conflict.d_Conflict)
	  {
		if (this.a_Conflict.e_Conflict)
		{
		  this.a_Conflict.e_Conflict = false;
		  this.a_Conflict.MapController.a(this.a_Conflict.h_Conflict.Point);
		}
		else if (this.a_Conflict.f_Conflict)
		{
		  this.a_Conflict.MapController.b(this.a_Conflict.h_Conflict.Point);
		}
		this.a_Conflict.a(false);
		this.a_Conflict.MapController.notifyRepaint();
	  }
	}
  }

  public virtual void onProviderDisabled(string paramString)
  {
  }

  public virtual void onProviderEnabled(string paramString)
  {
  }

  public virtual void onStatusChanged(string paramString, int paramInt, Bundle paramBundle)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */