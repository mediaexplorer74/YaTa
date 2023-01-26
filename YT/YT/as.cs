using System;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;

public sealed class @as : ExclusionStrategy
{
  private static bool a(Type paramClass)
  {
	return (!paramClass.IsAssignableFrom(typeof(Enum)) && (paramClass.isAnonymousClass() || paramClass.isLocalClass()));
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


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\as.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */