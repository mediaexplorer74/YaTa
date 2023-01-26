using System.Collections.Generic;

namespace com.google.gson
{
	using ec;
	using ed;
	using ee;

	public sealed class LongSerializationPolicy
	{
	  public static readonly LongSerializationPolicy DEFAULT = new LongSerializationPolicy("DEFAULT", InnerEnum.DEFAULT, (ed)new ec());
	  public static readonly LongSerializationPolicy STRING = new LongSerializationPolicy("STRING", InnerEnum.STRING, (ed)new ee());

	  private static readonly List<LongSerializationPolicy> valueList = new List<LongSerializationPolicy>();

	  static LongSerializationPolicy()
	  {
		  valueList.Add(DEFAULT);
		  valueList.Add(STRING);
	  }

	  public enum InnerEnum
	  {
		  DEFAULT,
		  STRING
	  }

	  public readonly InnerEnum innerEnumValue;
	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private static int nextOrdinal = 0;

	  private readonly ed a;

	  internal LongSerializationPolicy(string name, InnerEnum innerEnum, ed paramed)
	  {
		this.a = paramed;

		  nameValue = name;
		  ordinalValue = nextOrdinal++;
		  innerEnumValue = innerEnum;
	  }

	  public JsonElement serialize(long? paramLong)
	  {
		return this.a.a(paramLong);
	  }

		public static LongSerializationPolicy[] values()
		{
			return valueList.ToArray();
		}

		public int ordinal()
		{
			return ordinalValue;
		}

		public override string ToString()
		{
			return nameValue;
		}

		public static LongSerializationPolicy valueOf(string name)
		{
			foreach (LongSerializationPolicy enumInstance in LongSerializationPolicy.valueList)
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\LongSerializationPolicy.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}