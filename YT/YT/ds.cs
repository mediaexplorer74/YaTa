using FieldAttributes = com.google.gson.FieldAttributes;
using FieldNamingStrategy = com.google.gson.FieldNamingStrategy;
using  = com.google.gson.@internal.;

public sealed class ds : dr
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly FieldNamingStrategy a_Conflict;

  public ds(FieldNamingStrategy paramFieldNamingStrategy)
  {
	this.a_Conflict = (FieldNamingStrategy).Gson.Preconditions.checkNotNull(paramFieldNamingStrategy);
  }

  public string a(FieldAttributes paramFieldAttributes)
  {
	return this.a_Conflict.translateName(paramFieldAttributes.b());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ds.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */