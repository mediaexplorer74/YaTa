namespace com.google.gson.annotations
{

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class SerializedName : System.Attribute
	{
	  internal string value;

		public SerializedName(String value)
		{
			this.value = value;
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\annotations\SerializedName.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}