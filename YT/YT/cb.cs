using System;
using System.Text;

using FieldAttributes = com.google.gson.FieldAttributes;

internal sealed class cb : Exception
{
  private const long serialVersionUID = 7444343294106513081L;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly object a_Conflict;

  internal cb(object paramObject) : base("circular reference error")
  {
	this.a_Conflict = paramObject;
  }

  public System.InvalidOperationException a(FieldAttributes paramFieldAttributes)
  {
	StringBuilder stringBuilder = new StringBuilder(getMessage());
	if (paramFieldAttributes != null)
	{
	  stringBuilder.Append("\n  ").Append("Offending field: ").Append(paramFieldAttributes.Name + "\n");
	}
	if (this.a_Conflict != null)
	{
	  stringBuilder.Append("\n  ").Append("Offending object: ").Append(this.a_Conflict);
	}
	return new System.InvalidOperationException(stringBuilder.ToString(), this);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */