namespace com.google.gson.annotations
{

	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class Since : System.Attribute
	{
	  internal double value;

		public Since(double value)
		{
			this.value = value;
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\annotations\Since.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}