namespace com.google.gson.@internal
{
	public sealed class $Gson$Preconditions
	{
	  public static void checkArgument(bool paramBoolean)
	  {
		if (!paramBoolean)
		{
		  throw new System.ArgumentException();
		}
	  }

	  public static T checkNotNull<T>(T paramT)
	  {
		if (paramT == null)
		{
		  throw new System.NullReferenceException();
		}
		return paramT;
	  }

	  public static void checkState(bool paramBoolean)
	  {
		if (!paramBoolean)
		{
		  throw new System.InvalidOperationException();
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\internal\$Gson$Preconditions.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}