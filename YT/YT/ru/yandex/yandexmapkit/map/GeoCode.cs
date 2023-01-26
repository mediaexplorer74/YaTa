using System.Text;

namespace ru.yandex.yandexmapkit.map
{
	using by;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class GeoCode
	{
	  public const string OBJECT_KIND_AREA = "area";

	  public const string OBJECT_KIND_BRIDGE = "bridge";

	  public const string OBJECT_KIND_CEMETERY = "cemetery";

	  public const string OBJECT_KIND_COUNTRY = "country";

	  public const string OBJECT_KIND_DISTRICT = "district";

	  public const string OBJECT_KIND_HOUSE = "house";

	  public const string OBJECT_KIND_HYDRO = "hydro";

	  public const string OBJECT_KIND_KM = "km";

	  public const string OBJECT_KIND_LOCALITY = "locality";

	  public const string OBJECT_KIND_METRO = "metro";

	  public const string OBJECT_KIND_OTHER = "other";

	  public const string OBJECT_KIND_PROVINCE = "province";

	  public const string OBJECT_KIND_RAILWAY = "railway";

	  public const string OBJECT_KIND_ROUTE = "route";

	  public const string OBJECT_KIND_STREET = "street";

	  public const string OBJECT_KIND_VEGETATION = "vegetation";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string c_Conflict;

	  private int d;

	  private by e;

	  private GeoPoint f;

	  public virtual void a(int paramInt)
	  {
		this.d = paramInt;
	  }

	  public virtual void a(by paramby)
	  {
		this.e = paramby;
	  }

	  public virtual void a(string paramString)
	  {
		this.c_Conflict = paramString;
	  }

	  public virtual void a(GeoPoint paramGeoPoint)
	  {
		this.f = paramGeoPoint;
	  }

	  public virtual void b(string paramString)
	  {
		this.a_Conflict = paramString;
	  }

	  public virtual void c(string paramString)
	  {
		this.b_Conflict = paramString;
	  }

	  public virtual string DisplayName
	  {
		  get
		  {
			StringBuilder stringBuffer = new StringBuilder();
			if (!string.ReferenceEquals(this.b_Conflict, null) && !this.b_Conflict.Equals("") && !this.b_Conflict.Equals(this.a_Conflict))
			{
			  stringBuffer.Append(this.b_Conflict).Append(", ");
			}
			stringBuffer.Append(this.a_Conflict);
			return stringBuffer.ToString();
		  }
	  }

	  public virtual GeoPoint GeoPoint
	  {
		  get
		  {
			return this.f;
		  }
	  }

	  public virtual string Kind
	  {
		  get
		  {
			return this.c_Conflict;
		  }
	  }

	  public virtual by Point
	  {
		  get
		  {
			return this.e;
		  }
	  }

	  public virtual string Subtitle
	  {
		  get
		  {
			return this.b_Conflict;
		  }
	  }

	  public virtual string Title
	  {
		  get
		  {
			return this.a_Conflict;
		  }
	  }

	  public virtual int Zoomid
	  {
		  get
		  {
			return this.d;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\map\GeoCode.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}