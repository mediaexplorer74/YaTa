using JSONArray = org.json.JSONArray;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class qd : JSONArray
{
  public qd(GeoPoint paramGeoPoint)
  {
	put(this.a.getLon());
	put(this.a.getLat());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */