using Parcel = android.os.Parcel;
using Parcelable = android.os.Parcelable;

public class by : Parcelable
{
  public static readonly Parcelable.Creator CREATOR = new y();

  public long x;

  public long y;

  public by()
  {
  }

  public by(long paramLong1, long paramLong2)
  {
	this.x = paramLong1;
	this.y = paramLong2;
  }

  public virtual int describeContents()
  {
	return 0;
  }

  public virtual void writeToParcel(Parcel paramParcel, int paramInt)
  {
	paramParcel.writeLong(this.x);
	paramParcel.writeLong(this.y);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\by.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */