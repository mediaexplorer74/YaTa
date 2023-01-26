namespace com.google.gson.annotations
{

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class Expose : System.Attribute
	{
	  internal bool deserialize;

	  internal bool serialize;

		public Expose(boolean deserialize = true, boolean serialize = true)
		{
			this.deserialize = deserialize;
			this.serialize = serialize;
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\annotations\Expose.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}