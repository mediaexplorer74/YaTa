using System.Collections.Generic;

namespace com.google.gson
{
	using dr;
	using ef;
	using fg;

	public sealed class FieldNamingPolicy
	{
	  public static readonly FieldNamingPolicy LOWER_CASE_WITH_DASHES = new FieldNamingPolicy("LOWER_CASE_WITH_DASHES", InnerEnum.LOWER_CASE_WITH_DASHES);
	  public static readonly FieldNamingPolicy LOWER_CASE_WITH_UNDERSCORES = new FieldNamingPolicy("LOWER_CASE_WITH_UNDERSCORES", InnerEnum.LOWER_CASE_WITH_UNDERSCORES);
	  public static readonly FieldNamingPolicy UPPER_CAMEL_CASE = new FieldNamingPolicy("UPPER_CAMEL_CASE", InnerEnum.UPPER_CAMEL_CASE, (dr)new ModifyFirstLetterNamingPolicy(ModifyFirstLetterNamingPolicy$LetterModifier.UPPER));
	  public static readonly FieldNamingPolicy UPPER_CAMEL_CASE_WITH_SPACES = new FieldNamingPolicy("UPPER_CAMEL_CASE_WITH_SPACES", InnerEnum.UPPER_CAMEL_CASE_WITH_SPACES, (dr)new fg(" "));

	  private static readonly List<FieldNamingPolicy> valueList = new List<FieldNamingPolicy>();

	  public enum InnerEnum
	  {
		  LOWER_CASE_WITH_DASHES,
		  LOWER_CASE_WITH_UNDERSCORES,
		  UPPER_CAMEL_CASE,
		  UPPER_CAMEL_CASE_WITH_SPACES
	  }

	  public readonly InnerEnum innerEnumValue;
	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private static int nextOrdinal = 0;

	  private readonly dr a;

	  static FieldNamingPolicy()
	  {
		LOWER_CASE_WITH_UNDERSCORES = new FieldNamingPolicy("LOWER_CASE_WITH_UNDERSCORES", 2, (dr)new ef("_"));
		LOWER_CASE_WITH_DASHES = new FieldNamingPolicy("LOWER_CASE_WITH_DASHES", 3, (dr)new ef("-"));
		b = new FieldNamingPolicy[] {UPPER_CAMEL_CASE, UPPER_CAMEL_CASE_WITH_SPACES, LOWER_CASE_WITH_UNDERSCORES, LOWER_CASE_WITH_DASHES};

		  valueList.Add(LOWER_CASE_WITH_DASHES);
		  valueList.Add(LOWER_CASE_WITH_UNDERSCORES);
		  valueList.Add(UPPER_CAMEL_CASE);
		  valueList.Add(UPPER_CAMEL_CASE_WITH_SPACES);
	  }

	  internal FieldNamingPolicy(string name, InnerEnum innerEnum, dr paramdr)
	  {
		this.a = paramdr;

		  nameValue = name;
		  ordinalValue = nextOrdinal++;
		  innerEnumValue = innerEnum;
	  }

	  internal dr a()
	  {
		return this.a;
	  }

		public static FieldNamingPolicy[] values()
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

		public static FieldNamingPolicy valueOf(string name)
		{
			foreach (FieldNamingPolicy enumInstance in FieldNamingPolicy.valueList)
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\FieldNamingPolicy.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}