namespace com.google.gson.annotations
{

	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class Until : System.Attribute
	{
	  internal double value;

		public Until(double value)
		{
			this.value = value;
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\annotations\Until.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}