using System.Collections.Generic;

internal abstract class cf : et
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly et[] a_Conflict;

  public cf(params et[] paramVarArgs)
  {
	if (paramVarArgs == null)
	{
	  throw new System.NullReferenceException("naming policies can not be null.");
	}
	this.a_Conflict = paramVarArgs;
  }

  protected internal override string a(string paramString, Type paramType, ICollection<Annotation> paramCollection)
  {
	et[] arrayOfEt = this.a_Conflict;
	int i = arrayOfEt.Length;
	for (sbyte b = 0; b < i; b++)
	{
	  paramString = arrayOfEt[b].a(paramString, paramType, paramCollection);
	}
	return paramString;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */