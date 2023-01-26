using System;
using System.Collections.Generic;
using System.Text;

namespace ru.yandex.taxi.map
{
	using Parcel = android.os.Parcel;
	using Parcelable = android.os.Parcelable;
	using Log = android.util.Log;
	using JSONArray = org.json.JSONArray;
	using JSONObject = org.json.JSONObject;
	using qh;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class GeocodeJsonObject : Parcelable
	{
	  public const string ADDRESSES = "addresses";

	  public const string COMMENT = "comment";

	  public const string COUNTRY = "country";

	  public static readonly Parcelable.Creator<GeocodeJsonObject> CREATOR = (Parcelable.Creator<GeocodeJsonObject>)new qh();

	  public const int DEFAULT_ACCURENCY = 10000;

	  public const string DEFAULT_COUNTRY = "Россия";

	  public const string FULL_NAME = "fullname";

	  public const string LOCALITY = "locality";

	  public const string ORGANIZATIONS = "organizations";

	  public const string PORCHNUMBER = "porchnumber";

	  public const string PREMISENUMBER = "premisenumber";

	  public const string THROUGHFARE = "thoroughfare";

	  public const string TYPE_ADDRESS = "address";

	  public const string TYPE_ORGANIZATION = "organization";

	  private string defaultview;

	  private bool? mAirport;

	  private string mBuilding;

	  private string mCity;

	  private string mComment;

	  private string mConstruction;

	  private string mCountry;

	  private string mEntrance;

	  private bool? mExact;

	  private int mFakeCount;

	  private string mFlight;

	  private volatile GeoPoint mGeoPoint;

	  private string mHouse;

	  private string mHouseOnly;

	  private string mName;

	  private string mStreet;

	  private string mTerminal;

	  private string mText;

	  private string mType;

	  private IList<GeocodeJsonObject$Objects> objects;

	  public GeocodeJsonObject()
	  {
		this.objects = new List<GeocodeJsonObject$Objects>();
		this.mFakeCount = -1;
		this.mEntrance = "";
		this.mTerminal = "";
		this.mFlight = "";
		this.mComment = "";
	  }

	  private GeocodeJsonObject(Parcel paramParcel)
	  {
		bool bool2;
		this.objects = new List<GeocodeJsonObject$Objects>();
		this.mFakeCount = -1;
		this.mEntrance = "";
		this.mTerminal = "";
		this.mFlight = "";
		this.mComment = "";
		int i = paramParcel.readInt();
		for (sbyte b = 0; b < i; b++)
		{
		  GeocodeJsonObject$Objects geocodeJsonObject$Objects = (GeocodeJsonObject$Objects)paramParcel.readSerializable();
		  this.objects.Add(geocodeJsonObject$Objects);
		}
		this.mText = paramParcel.readString();
		this.mName = paramParcel.readString();
		this.mCountry = paramParcel.readString();
		this.mCity = paramParcel.readString();
		this.mStreet = paramParcel.readString();
		this.mHouse = paramParcel.readString();
		this.mEntrance = paramParcel.readString();
		double[] arrayOfDouble = (double[])paramParcel.readSerializable();
		if (arrayOfDouble != null)
		{
		  this.mGeoPoint = new GeoPoint(arrayOfDouble[0], arrayOfDouble[1]);
		}
		this.mFakeCount = paramParcel.readInt();
		if (paramParcel.readInt() == 1)
		{
		  bool2 = true;
		}
		else
		{
		  bool2 = false;
		}
		this.mExact = Convert.ToBoolean(bool2);
		this.mComment = paramParcel.readString();
		if (paramParcel.readInt() == 1)
		{
		  bool2 = bool1;
		}
		else
		{
		  bool2 = false;
		}
		this.mAirport = Convert.ToBoolean(bool2);
		this.mTerminal = paramParcel.readString();
		this.mFlight = paramParcel.readString();
		this.mType = paramParcel.readString();
	  }

	  public GeocodeJsonObject(string paramString)
	  {
		this.objects = new List<GeocodeJsonObject$Objects>();
		this.mFakeCount = -1;
		this.mEntrance = "";
		this.mTerminal = "";
		this.mFlight = "";
		this.mComment = "";
		string[] arrayOfString = paramString.Split(";;", true);
		Text = arrayOfString[0];
		Name = arrayOfString[1];
		Country = arrayOfString[2];
		City = arrayOfString[3];
		if ("null".Equals(arrayOfString[4]))
		{
		  paramString = "";
		}
		else
		{
		  paramString = arrayOfString[4];
		}
		Street = paramString;
		if ("null".Equals(arrayOfString[5]))
		{
		  paramString = "";
		}
		else
		{
		  paramString = arrayOfString[5];
		}
		House = paramString;
		if ("null".Equals(arrayOfString[6]))
		{
		  paramString = "";
		}
		else
		{
		  paramString = arrayOfString[6];
		}
		Entrance = paramString;
		if (!"0--0".Equals(arrayOfString[7]))
		{
		  try
		  {
			string[] arrayOfString1 = arrayOfString[7].Split("--", true);
			GeoPoint geoPoint = new GeoPoint();
			this(Convert.ToDouble(arrayOfString1[0]), Convert.ToDouble(arrayOfString1[1]));
			GeoPoint = geoPoint;
		  }
		  catch (Exception exception)
		  {
			Log.e("GeocodeJsonObject", "Fail set geopoint", exception);
		  }
		}
		Exact = Convert.ToBoolean(arrayOfString[8]);
		if (arrayOfString.Length > 9)
		{
		  Comment = arrayOfString[9];
		  if (arrayOfString.Length > 10)
		  {
			setAirport(Convert.ToBoolean(arrayOfString[10]));
			if (arrayOfString.Length > 11)
			{
			  Terminal = arrayOfString[11];
			  Flight = arrayOfString[12];
			  if (arrayOfString.Length > 13)
			  {
				Type = arrayOfString[13];
			  }
			}
		  }
		}
		this.mFakeCount = 1;
	  }

	  public GeocodeJsonObject(IList<GeocodeJsonObject$Objects> paramList)
	  {
		this.objects = new List<GeocodeJsonObject$Objects>();
		this.mFakeCount = -1;
		this.mEntrance = "";
		this.mTerminal = "";
		this.mFlight = "";
		this.mComment = "";
		this.objects = paramList;
	  }

	  public GeocodeJsonObject(GeocodeJsonObject$Objects paramGeocodeJsonObject$Objects)
	  {
		this.objects = new List<GeocodeJsonObject$Objects>();
		this.mFakeCount = -1;
		this.mEntrance = "";
		this.mTerminal = "";
		this.mFlight = "";
		this.mComment = "";
		this.objects.Add(paramGeocodeJsonObject$Objects);
	  }

	  private string createFullName()
	  {
		string str = House;
		StringBuilder stringBuilder = (new StringBuilder()).Append(Country).Append(", ").Append(City).Append(", ").Append(Street);
		if ("".Equals(str))
		{
		  str = "";
		  return stringBuilder.Append(str).ToString();
		}
		str = ", " + str;
		return stringBuilder.Append(str).ToString();
	  }

	  private bool fetchAirport(int paramInt)
	  {
		bool @bool = false;
		null = @bool;
		if (this.objects != null)
		{
		  null = @bool;
		  if (this.objects.Count > paramInt)
		  {
			GeocodeJsonObject$Objects geocodeJsonObject$Objects = this.objects[paramInt];
			if ("аэропорт".Equals(geocodeJsonObject$Objects.type) || (!string.ReferenceEquals(geocodeJsonObject$Objects.street, null) && geocodeJsonObject$Objects.street.ToLower().StartsWith("аэропорт ", StringComparison.Ordinal)))
			{
			  return true;
			}
		  }
		  else
		  {
			return null;
		  }
		}
		else
		{
		  return null;
		}
		return false;
	  }

	  private string fetchCity(int paramInt)
	  {
		string str1 = null;
		string str2 = str1;
		if (this.objects != null)
		{
		  str2 = str1;
		  if (this.objects.Count > paramInt)
		  {
			str2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).city;
		  }
		}
		return str2;
	  }

	  private string fetchCountry(int paramInt)
	  {
		string str1 = null;
		string str2 = str1;
		if (this.objects != null)
		{
		  str2 = str1;
		  if (this.objects.Count > paramInt)
		  {
			str2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).country;
		  }
		}
		return str2;
	  }

	  private bool fetchExact(int paramInt)
	  {
		bool bool1 = false;
		bool bool2 = bool1;
		if (this.objects != null)
		{
		  bool2 = bool1;
		  if (this.objects.Count > paramInt)
		  {
			bool2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).exact;
		  }
		}
		return bool2;
	  }

	  private string fetchHouse(int paramInt)
	  {
		string str1 = null;
		string str2 = str1;
		if (this.objects != null)
		{
		  str2 = str1;
		  if (this.objects.Count > paramInt)
		  {
			str2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).house;
		  }
		}
		return str2;
	  }

	  private GeoPoint fetchPoint(int paramInt)
	  {
		GeoPoint geoPoint;
		IList<double> list1 = null;
		IList<double> list2 = list1;
		if (this.objects != null)
		{
		  list2 = list1;
		  if (this.objects.Count > paramInt)
		  {
			list2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).point;
			geoPoint = new GeoPoint(((double?)list2[1]).Value, ((double?)list2[0]).Value);
		  }
		}
		return geoPoint;
	  }

	  private string fetchShortText(int paramInt)
	  {
		string str1 = null;
		string str2 = str1;
		if (this.objects != null)
		{
		  str2 = str1;
		  if (this.objects.Count > paramInt)
		  {
			str2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).short_text;
		  }
		}
		return str2;
	  }

	  private string fetchStreet(int paramInt)
	  {
		// Byte code:
		//   0: aconst_null
		//   1: astore_2
		//   2: aload_2
		//   3: astore_3
		//   4: aload_0
		//   5: getfield objects : Ljava/util/List;
		//   8: ifnull -> 43
		//   11: aload_2
		//   12: astore_3
		//   13: aload_0
		//   14: getfield objects : Ljava/util/List;
		//   17: invokeinterface size : ()I
		//   22: iload_1
		//   23: if_icmple -> 43
		//   26: aload_0
		//   27: getfield objects : Ljava/util/List;
		//   30: iload_1
		//   31: invokeinterface get : (I)Ljava/lang/Object;
		//   36: checkcast ru/yandex/taxi/map/GeocodeJsonObject$Objects
		//   39: getfield street : Ljava/lang/String;
		//   42: astore_3
		//   43: ldc ''
		//   45: aload_3
		//   46: invokevirtual equals : (Ljava/lang/Object;)Z
		//   49: ifne -> 58
		//   52: aload_3
		//   53: astore_2
		//   54: aload_3
		//   55: ifnonnull -> 92
		//   58: aload_0
		//   59: iload_1
		//   60: invokespecial fetchShortText : (I)Ljava/lang/String;
		//   63: astore #4
		//   65: aload_0
		//   66: iload_1
		//   67: invokespecial fetchCity : (I)Ljava/lang/String;
		//   70: astore #5
		//   72: aload #5
		//   74: ifnull -> 89
		//   77: aload_3
		//   78: astore_2
		//   79: aload #5
		//   81: aload #4
		//   83: invokevirtual equals : (Ljava/lang/Object;)Z
		//   86: ifne -> 92
		//   89: aload #4
		//   91: astore_2
		//   92: aload_2
		//   93: areturn
	  }

	  private string fetchText(int paramInt)
	  {
		string str1 = null;
		string str2 = str1;
		if (this.objects != null)
		{
		  str2 = str1;
		  if (this.objects.Count > paramInt)
		  {
			str2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).full_text;
		  }
		}
		return str2;
	  }

	  private string fetchType(int paramInt)
	  {
		string str1 = null;
		string str2 = str1;
		if (this.objects != null)
		{
		  str2 = str1;
		  if (this.objects.Count > paramInt)
		  {
			str2 = ((GeocodeJsonObject$Objects)this.objects[paramInt]).type;
		  }
		}
		return str2;
	  }

	  public static string getHouseAndBuilding(string paramString1, string paramString2, string paramString3)
	  {
		StringBuilder stringBuilder2 = new StringBuilder();
		string str = paramString1;
		if ("".Equals(paramString1))
		{
		  str = "";
		}
		StringBuilder stringBuilder3 = stringBuilder2.Append(str);
		if ("".Equals(paramString2))
		{
		  paramString1 = "";
		}
		else
		{
		  paramString1 = "к" + paramString2;
		}
		StringBuilder stringBuilder1 = stringBuilder3.Append(paramString1);
		if ("".Equals(paramString3))
		{
		  paramString1 = "";
		  return stringBuilder1.Append(paramString1).ToString();
		}
		paramString1 = "с" + paramString3;
		return stringBuilder1.Append(paramString1).ToString();
	  }

	  public static string getShortAddress(string paramString1, string paramString2, string paramString3, string paramString4, string paramString5, string paramString6, string paramString7, string paramString8)
	  {
		StringBuilder stringBuilder;
		if (!"".Equals(paramString7) || !"".Equals(paramString8))
		{
		  stringBuilder = (new StringBuilder()).Append(paramString2);
		  if ("".Equals(paramString7))
		  {
			paramString1 = "";
		  }
		  else
		  {
			paramString1 = ", " + paramString7;
		  }
		  stringBuilder = stringBuilder.Append(paramString1);
		  if ("".Equals(paramString8))
		  {
			paramString1 = "";
		  }
		  else
		  {
			paramString1 = ", " + paramString8;
		  }
		  return stringBuilder.Append(paramString1).ToString();
		}
		paramString3 = getHouseAndBuilding(paramString3, paramString4, paramString5);
		if (!"".Equals(stringBuilder))
		{
		  stringBuilder = (new StringBuilder()).Append((string)stringBuilder);
		  if ("".Equals(paramString3))
		  {
			paramString1 = "";
		  }
		  else
		  {
			paramString1 = ", " + paramString3;
		  }
		  stringBuilder = stringBuilder.Append(paramString1);
		  if ("".Equals(paramString6))
		  {
			paramString1 = "";
		  }
		  else
		  {
			paramString1 = ", " + paramString6;
		  }
		  paramString1 = stringBuilder.Append(paramString1).ToString();
		}
		return paramString1;
	  }

	  public static void setHouseAndBuilding(GeocodeJsonObject paramGeocodeJsonObject, string paramString)
	  {
		if (!string.ReferenceEquals(paramString, null))
		{
		  int k;
		  string str1;
		  string str2;
		  string str3;
		  int i = paramString.IndexOf("к", StringComparison.Ordinal);
		  int j = paramString.IndexOf("соор", StringComparison.Ordinal);
		  if (j >= 0)
		  {
			k = j;
		  }
		  else
		  {
			k = paramString.IndexOf("с", StringComparison.Ordinal);
		  }
		  if (i >= 0)
		  {
			int m;
			str1 = paramString.Substring(0, i);
			if (k >= 0)
			{
			  m = k;
			}
			else
			{
			  m = paramString.Length;
			}
			str2 = paramString.Substring(i + 1, m - (i + 1));
		  }
		  else
		  {
			str1 = "";
			str2 = "";
		  }
		  if (k >= 0)
		  {
			int m;
			if (j >= 0)
			{
			  m = "соор".Length;
			}
			else
			{
			  m = "с".Length;
			}
			str3 = paramString.Substring(m + k, paramString.Length - (m + k));
			if ("".Equals(str1))
			{
			  str1 = paramString.Substring(0, k);
			}
		  }
		  else
		  {
			str3 = "";
		  }
		  string str4 = str1;
		  if ("".Equals(str1))
		  {
			str4 = str1;
			if (k != 0)
			{
			  str4 = str1;
			  if (i != 0)
			  {
				str4 = paramString;
			  }
			}
		  }
		  paramGeocodeJsonObject.HouseOnly = str4;
		  paramGeocodeJsonObject.Building = str2;
		  paramGeocodeJsonObject.Construction = str3;
		}
	  }

	  public virtual void addGeoObjects(GeocodeJsonObject paramGeocodeJsonObject)
	  {
		if (this.objects != null && paramGeocodeJsonObject != null && paramGeocodeJsonObject.Objects != null)
		{
		  ((List<GeocodeJsonObject$Objects>)this.objects).AddRange(paramGeocodeJsonObject.Objects);
		}
	  }

	  public virtual int describeContents()
	  {
		return 0;
	  }

	  public virtual bool? Airport
	  {
		  get
		  {
			bool bool1 = false;
			if (this.mAirport == null)
			{
			  this.mAirport = Convert.ToBoolean(fetchAirport(0));
			}
			if (!this.mAirport.Value)
			{
			  bool @bool = bool1;
			  if (!string.ReferenceEquals(this.mStreet, null))
			  {
				@bool = bool1;
				if (this.mStreet.ToLower().StartsWith("аэропорт ", StringComparison.Ordinal))
				{
				  @bool = true;
				  return Convert.ToBoolean(@bool);
				}
			  }
			  return Convert.ToBoolean(@bool);
			}
			bool bool2 = true;
			return Convert.ToBoolean(bool2);
		  }
		  set
		  {
			this.mAirport = Convert.ToBoolean(value);
		  }
	  }

	  public virtual string Building
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mBuilding, null))
			{
			  setHouseAndBuilding(this, House);
			}
			return this.mBuilding;
		  }
		  set
		  {
			this.mBuilding = value;
			this.mHouse = getHouseAndBuilding(this.mHouseOnly, this.mBuilding, this.mConstruction);
		  }
	  }

	  public virtual string City
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mCity, null))
			{
			  this.mCity = fetchCity(0);
			}
			return this.mCity;
		  }
		  set
		  {
			this.mCity = value;
		  }
	  }

	  public virtual string Comment
	  {
		  get
		  {
			return this.mComment;
		  }
		  set
		  {
			this.mComment = value;
		  }
	  }

	  public virtual string Construction
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mConstruction, null))
			{
			  setHouseAndBuilding(this, House);
			}
			return this.mConstruction;
		  }
		  set
		  {
			this.mConstruction = value;
			this.mHouse = getHouseAndBuilding(this.mHouseOnly, this.mBuilding, this.mConstruction);
		  }
	  }

	  public virtual int Count
	  {
		  get
		  {
			return (this.mFakeCount == -1 && this.objects != null) ? this.objects.Count : this.mFakeCount;
		  }
		  set
		  {
			this.mFakeCount = value;
		  }
	  }

	  public virtual string Country
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mCountry, null))
			{
			  this.mCountry = fetchCountry(0);
			}
			return this.mCountry;
		  }
		  set
		  {
			this.mCountry = value;
		  }
	  }

	  public virtual string DefaultView
	  {
		  get
		  {
			return this.defaultview;
		  }
	  }

	  public virtual int getDistance(GeoPoint paramGeoPoint, int paramInt)
	  {
		bool @bool = false;
		GeoPoint geoPoint = fetchPoint(paramInt);
		paramInt = @bool;
		if (geoPoint != null)
		{
		  paramInt = (int)CoordConversion.getDistance(paramGeoPoint.Lat, paramGeoPoint.Lon, geoPoint.Lat, geoPoint.Lon);
		}
		return paramInt;
	  }

	  public virtual string Entrance
	  {
		  get
		  {
			return this.mEntrance;
		  }
		  set
		  {
			this.mEntrance = value;
		  }
	  }

	  public virtual bool Exact
	  {
		  get
		  {
			if (this.mExact == null)
			{
			  this.mExact = Convert.ToBoolean(fetchExact(0));
			}
			return this.mExact.Value;
		  }
		  set
		  {
			this.mExact = Convert.ToBoolean(value);
		  }
	  }

	  public virtual string Flight
	  {
		  get
		  {
			return this.mFlight;
		  }
		  set
		  {
			this.mFlight = value;
		  }
	  }

	  public virtual string FullAddress
	  {
		  get
		  {
			string str1 = City;
			string str2 = str1;
			if (string.ReferenceEquals(str1, null))
			{
			  str2 = "Москва";
			}
			string str3 = ShortAddress;
			StringBuilder stringBuilder = (new StringBuilder()).Append(str2);
			if ("".Equals(str3))
			{
			  str2 = "";
			  return stringBuilder.Append(str2).ToString();
			}
			str2 = ", " + str3;
			return stringBuilder.Append(str2).ToString();
		  }
	  }

	  public virtual GeoPoint GeoPoint
	  {
		  get
		  {
			if (this.mGeoPoint == null)
			{
			  this.mGeoPoint = fetchPoint(0);
			}
			return this.mGeoPoint;
		  }
		  set
		  {
			this.mGeoPoint = value;
		  }
	  }

	  public virtual string House
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mHouse, null))
			{
			  this.mHouse = fetchHouse(0);
			}
			return this.mHouse;
		  }
		  set
		  {
			this.mHouse = value;
			setHouseAndBuilding(this, value);
		  }
	  }

	  public virtual string HouseOnly
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mHouseOnly, null))
			{
			  setHouseAndBuilding(this, House);
			}
			return this.mHouseOnly;
		  }
		  set
		  {
			this.mHouseOnly = value;
			this.mHouse = getHouseAndBuilding(this.mHouseOnly, this.mBuilding, this.mConstruction);
		  }
	  }

	  public virtual JSONObject JsonObject
	  {
		  get
		  {
			JSONObject jSONObject = new JSONObject();
			string str1 = Text;
			string str3 = str1;
			if ("".Equals(str1))
			{
			  str3 = createFullName();
			}
			jSONObject.put("fullname", str3);
			jSONObject.put("country", Country);
			jSONObject.put("locality", City);
			jSONObject.put("thoroughfare", Street);
			jSONObject.put("premisenumber", House);
			jSONObject.put("porchnumber", Entrance);
			GeoPoint geoPoint = GeoPoint;
			if (geoPoint != null)
			{
			  JSONArray jSONArray = new JSONArray();
			  jSONArray.put(geoPoint.Lon);
			  jSONArray.put(geoPoint.Lat);
			  jSONObject.put("geopoint", jSONArray);
			}
			string str2 = Terminal;
			if (!"".Equals(str2))
			{
			  jSONObject.put("terminal", str2);
			}
			str2 = Flight;
			if (!"".Equals(str2))
			{
			  jSONObject.put("flight", str2);
			}
			return jSONObject;
		  }
	  }

	  public virtual string Name
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mName, null))
			{
			  this.mName = fetchShortText(0);
			}
			return this.mName;
		  }
		  set
		  {
			this.mName = value;
		  }
	  }

	  public virtual string getName(int paramInt)
	  {
		return fetchShortText(paramInt);
	  }

	  public virtual GeocodeJsonObject getObject(int paramInt)
	  {
		return new GeocodeJsonObject(this.objects[paramInt]);
	  }

	  public virtual IList<GeocodeJsonObject$Objects> Objects
	  {
		  get
		  {
			return this.objects;
		  }
	  }

	  public virtual string ShortAddress
	  {
		  get
		  {
			return getShortAddress(City, Street, HouseOnly, Building, Construction, Entrance, Terminal, Flight);
		  }
	  }

	  public virtual string Street
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mStreet, null))
			{
			  this.mStreet = fetchStreet(0);
			}
			return this.mStreet;
		  }
		  set
		  {
			this.mStreet = value;
		  }
	  }

	  public virtual string Terminal
	  {
		  get
		  {
			return this.mTerminal;
		  }
		  set
		  {
			this.mTerminal = value;
		  }
	  }

	  public virtual string Text
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mText, null))
			{
			  this.mText = fetchText(0);
			}
			return this.mText;
		  }
		  set
		  {
			this.mText = value;
		  }
	  }

	  public virtual string getText(int paramInt)
	  {
		return fetchText(paramInt);
	  }

	  public virtual string Type
	  {
		  get
		  {
			if (string.ReferenceEquals(this.mType, null))
			{
			  this.mType = fetchType(0);
			}
			return this.mType;
		  }
		  set
		  {
			this.mType = value;
		  }
	  }

	  public virtual string serialize()
	  {
		if (Count == 0)
		{
		  return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Text + ";;");
		stringBuilder.Append(Name + ";;");
		stringBuilder.Append(Country + ";;");
		stringBuilder.Append(City + ";;");
		stringBuilder.Append(Street + ";;");
		stringBuilder.Append(House + ";;");
		stringBuilder.Append(this.mEntrance + ";;");
		if (GeoPoint == null)
		{
		  null = "0--0;;";
		}
		else
		{
		  null = GeoPoint.Lat + "--" + GeoPoint.Lon + ";;";
		}
		stringBuilder.Append(null);
		stringBuilder.Append(Exact + ";;");
		stringBuilder.Append(Comment + ";;");
		stringBuilder.Append(getAirport() + ";;");
		stringBuilder.Append(Terminal + ";;");
		stringBuilder.Append(Flight + ";;");
		stringBuilder.Append(Type);
		return stringBuilder.ToString();
	  }



















	  public virtual void writeToParcel(Parcel paramParcel, int paramInt)
	  {
		bool @bool = true;
		paramParcel.writeInt(this.objects.Count);
		IEnumerator<GeocodeJsonObject$Objects> iterator = this.objects.GetEnumerator();
		while (iterator.MoveNext())
		{
		  paramParcel.writeSerializable(iterator.Current);
		}
		paramParcel.writeString(this.mText);
		paramParcel.writeString(this.mName);
		paramParcel.writeString(this.mCountry);
		paramParcel.writeString(this.mCity);
		paramParcel.writeString(this.mStreet);
		paramParcel.writeString(this.mHouse);
		paramParcel.writeString(this.mEntrance);
		if (this.mGeoPoint != null)
		{
		  paramParcel.writeSerializable((Serializable)new double[] {this.mGeoPoint.Lat, this.mGeoPoint.Lon});
		}
		else
		{
		  paramParcel.writeArray(null);
		}
		paramParcel.writeInt(this.mFakeCount);
		if (Exact)
		{
		  paramInt = 1;
		}
		else
		{
		  paramInt = 0;
		}
		paramParcel.writeInt(paramInt);
		paramParcel.writeString(this.mComment);
		if (getAirport().Value)
		{
		  paramInt = @bool;
		}
		else
		{
		  paramInt = 0;
		}
		paramParcel.writeInt(paramInt);
		paramParcel.writeString(Terminal);
		paramParcel.writeString(Flight);
		paramParcel.writeString(Type);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\map\GeocodeJsonObject.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}