using FieldAttributes = com.google.gson.FieldAttributes;
using SerializedName = com.google.gson.annotations.SerializedName;

public sealed class ev : dr
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly dr a_Conflict;

  public ev(dr paramdr)
  {
	this.a_Conflict = paramdr;
  }

  public string a(FieldAttributes paramFieldAttributes)
  {
	SerializedName serializedName = (SerializedName)paramFieldAttributes.getAnnotation(typeof(SerializedName));
	return (serializedName == null) ? this.a_Conflict.a(paramFieldAttributes) : serializedName.value();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ev.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */