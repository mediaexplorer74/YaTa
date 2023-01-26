using Parcel = android.os.Parcel;
using Parcelable = android.os.Parcelable;

public class ar : Parcelable
{
  public static readonly Parcelable.Creator CREATOR = new u();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string a_Conflict = "";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string b_Conflict = "";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string c_Conflict = "";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool d_Conflict = true;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int e_Conflict = 30;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int f_Conflict = 120;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int g_Conflict = 600;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private string h_Conflict = "";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private bool i_Conflict = true;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int j_Conflict = 5;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int k_Conflict = 120;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private int l_Conflict = 600;

  public ar(string paramString1, string paramString2, string paramString3, bool paramBoolean1, int paramInt1, int paramInt2, int paramInt3, string paramString4, bool paramBoolean2, int paramInt4, int paramInt5, int paramInt6)
  {
	this.a_Conflict = paramString1;
	this.b_Conflict = paramString2;
	this.c_Conflict = paramString3;
	this.d_Conflict = paramBoolean1;
	this.e_Conflict = paramInt1;
	this.f_Conflict = paramInt2;
	this.g_Conflict = paramInt3;
	this.h_Conflict = paramString4;
	this.i_Conflict = paramBoolean2;
	this.j_Conflict = paramInt4;
	this.k_Conflict = paramInt5;
	this.l_Conflict = paramInt6;
  }

  public virtual string a()
  {
	return this.a_Conflict;
  }

  public virtual string b()
  {
	return this.b_Conflict;
  }

  public virtual string c()
  {
	return this.c_Conflict;
  }

  public virtual bool d()
  {
	return this.d_Conflict;
  }

  public virtual int describeContents()
  {
	return 0;
  }

  public virtual int e()
  {
	return this.e_Conflict;
  }

  public virtual int f()
  {
	return this.f_Conflict;
  }

  public virtual int g()
  {
	return this.g_Conflict;
  }

  public virtual string h()
  {
	return this.h_Conflict;
  }

  public virtual bool i()
  {
	return this.i_Conflict;
  }

  public virtual int j()
  {
	return this.j_Conflict;
  }

  public virtual int k()
  {
	return this.k_Conflict;
  }

  public virtual int l()
  {
	return this.l_Conflict;
  }

  public virtual void writeToParcel(Parcel paramParcel, int paramInt)
  {
	bool @bool = true;
	if (!string.ReferenceEquals(this.a_Conflict, null))
	{
	  paramParcel.writeString(this.a_Conflict);
	}
	else
	{
	  paramParcel.writeString("");
	}
	if (!string.ReferenceEquals(this.b_Conflict, null))
	{
	  paramParcel.writeString(this.b_Conflict);
	}
	else
	{
	  paramParcel.writeString("");
	}
	if (!string.ReferenceEquals(this.c_Conflict, null))
	{
	  paramParcel.writeString(this.c_Conflict);
	}
	else
	{
	  paramParcel.writeString("");
	}
	if (this.d_Conflict)
	{
	  paramInt = 1;
	}
	else
	{
	  paramInt = 0;
	}
	paramParcel.writeInt(paramInt);
	paramParcel.writeInt(this.e_Conflict);
	paramParcel.writeInt(this.f_Conflict);
	paramParcel.writeInt(this.g_Conflict);
	if (!string.ReferenceEquals(this.h_Conflict, null))
	{
	  paramParcel.writeString(this.h_Conflict);
	}
	else
	{
	  paramParcel.writeString("");
	}
	if (this.i_Conflict)
	{
	  paramInt = @bool;
	}
	else
	{
	  paramInt = 0;
	}
	paramParcel.writeInt(paramInt);
	paramParcel.writeInt(this.j_Conflict);
	paramParcel.writeInt(this.k_Conflict);
	paramParcel.writeInt(this.l_Conflict);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ar.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */