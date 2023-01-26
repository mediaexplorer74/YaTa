using System.Collections.Generic;
using System.Text;

using  = com.google.gson.@internal.;

internal sealed class bz : et
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly string a_Conflict;

  public bz(string paramString)
  {
	bool @bool;
	.Gson.Preconditions.checkNotNull(paramString);
	if (!"".Equals(paramString))
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	.Gson.Preconditions.checkArgument(@bool);
	this.a_Conflict = paramString;
  }

  protected internal override string a(string paramString, Type paramType, ICollection<Annotation> paramCollection)
  {
	StringBuilder stringBuilder = new StringBuilder();
	for (sbyte b = 0; b < paramString.Length; b++)
	{
	  char c = paramString[b];
	  if (char.IsUpper(c) && stringBuilder.Length != 0)
	  {
		stringBuilder.Append(this.a_Conflict);
	  }
	  stringBuilder.Append(c);
	}
	return stringBuilder.ToString();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */