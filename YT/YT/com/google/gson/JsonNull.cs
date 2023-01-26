namespace com.google.gson
{
	using do;

	public sealed class JsonNull : JsonElement
	{
	  private static readonly JsonNull a = new JsonNull();

	  public static JsonNull c()
	  {
		return a;
	  }

	  public override bool Equals(object paramObject)
	  {
		return (this == paramObject || paramObject is JsonNull);
	  }

	  public override int GetHashCode()
	  {
		return typeof(JsonNull).GetHashCode();
	  }

	  protected internal override void toString(Appendable paramAppendable, do paramdo)
	  {
		paramAppendable.append("null");
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonNull.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}