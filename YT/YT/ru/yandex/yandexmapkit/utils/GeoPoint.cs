namespace ru.yandex.yandexmapkit.utils
{
	using Parcel = android.os.Parcel;
	using Parcelable = android.os.Parcelable;
	using bu;

	public sealed class GeoPoint : Parcelable
	{
	  public static readonly Parcelable.Creator CREATOR = (Parcelable.Creator)new bu();

	  private double a;

	  private double b;

	  public GeoPoint()
	  {
	  }

	  public GeoPoint(double paramDouble1, double paramDouble2)
	  {
		this.a = paramDouble1;
		this.b = paramDouble2;
	  }

	  public static GeoPoint parse(string paramString)
	  {
		if (!string.ReferenceEquals(paramString, null))
		{
		  int i = paramString.IndexOf(',');
		  if (i > 0)
		  {
			char[] arrayOfChar = paramString.ToCharArray();
			float f1 = float.Parse(new string(arrayOfChar, 0, i));
			float f2 = float.Parse(new string(arrayOfChar, i + 1, arrayOfChar.Length - i - 1));
			return new GeoPoint(f1, f2);
		  }
		}
		return null;
	  }

	  public int describeContents()
	  {
		return 0;
	  }

	  public override bool Equals(object paramObject)
	  {
		bool @bool = true;
		if (this != paramObject)
		{
		  if (paramObject == null || this.GetType() != paramObject.GetType())
		  {
			return false;
		  }
		  paramObject = paramObject;
		  if (((GeoPoint)paramObject).a.CompareTo(this.a) != 0)
		  {
			return false;
		  }
		  if (((GeoPoint)paramObject).b.CompareTo(this.b) != 0)
		  {
			@bool = false;
		  }
		}
		return @bool;
	  }

	  public double Lat
	  {
		  get
		  {
			return this.a;
		  }
		  set
		  {
			this.a = value;
		  }
	  }

	  public double Lon
	  {
		  get
		  {
			return this.b;
		  }
		  set
		  {
			this.b = value;
		  }
	  }

	  public override int GetHashCode()
	  {
		long l1 = 0L;
		if (this.a != 0.0D)
		{
		  l2 = System.BitConverter.DoubleToInt64Bits(this.a);
		}
		else
		{
		  l2 = 0L;
		}
		int i = (int)(l2 ^ (int)((uint)l2 >> 32L));
		long l2 = l1;
		if (this.b != 0.0D)
		{
		  l2 = System.BitConverter.DoubleToInt64Bits(this.b);
		}
		return i * 31 + (int)(l2 ^ (long)((ulong)l2 >> 32L));
	  }



	  public void writeToParcel(Parcel paramParcel, int paramInt)
	  {
		paramParcel.writeDouble(this.a);
		paramParcel.writeDouble(this.b);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapki\\utils\GeoPoint.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}