using JSONArray = org.json.JSONArray;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class qc : JSONArray
{
  public qc(GeoPoint paramGeoPoint)
  {
	put(this.a.getLon());
	put(this.a.getLat());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */