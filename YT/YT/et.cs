using System.Collections.Generic;

using FieldAttributes = com.google.gson.FieldAttributes;

public abstract class et : dr
{
  public string a(FieldAttributes paramFieldAttributes)
  {
	return a(paramFieldAttributes.Name, paramFieldAttributes.DeclaredType, paramFieldAttributes.Annotations);
  }

  protected internal abstract string a(string paramString, Type paramType, ICollection<Annotation> paramCollection);
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\et.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */