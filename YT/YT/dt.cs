using System;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;

public sealed class dt : ExclusionStrategy
{
  private static bool a(Type paramClass)
  {
	null = true;
	if (paramClass.isMemberClass())
	{
	  bool @bool;
	  if ((paramClass.getModifiers() & 0x8) != 0)
	  {
		@bool = true;
	  }
	  else
	  {
		@bool = false;
	  }
	  if (!@bool)
	  {
		return null;
	  }
	}
	return false;
  }

  public bool shouldSkipClass(Type paramClass)
  {
	return a(paramClass);
  }

  public bool shouldSkipField(FieldAttributes paramFieldAttributes)
  {
	return a(paramFieldAttributes.DeclaredClass);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dt.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */