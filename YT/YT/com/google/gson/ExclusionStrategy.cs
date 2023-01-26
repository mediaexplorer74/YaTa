using System;

namespace com.google.gson
{
	public interface ExclusionStrategy
	{
	  bool shouldSkipClass(Type paramClass);

	  bool shouldSkipField(FieldAttributes paramFieldAttributes);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\ExclusionStrategy.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}