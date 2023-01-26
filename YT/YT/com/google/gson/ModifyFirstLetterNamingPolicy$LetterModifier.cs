using System.Collections.Generic;

namespace com.google.gson
{
	public sealed class ModifyFirstLetterNamingPolicy$LetterModifier
	{
	  public static readonly ModifyFirstLetterNamingPolicy$LetterModifier LOWER = new ModifyFirstLetterNamingPolicy$LetterModifier("LOWER", InnerEnum.LOWER);
	  public static readonly ModifyFirstLetterNamingPolicy$LetterModifier UPPER = new ModifyFirstLetterNamingPolicy$LetterModifier("UPPER", InnerEnum.UPPER);

	  private static readonly List<ModifyFirstLetterNamingPolicy$LetterModifier> valueList = new List<ModifyFirstLetterNamingPolicy$LetterModifier>();

	  public enum InnerEnum
	  {
		  LOWER,
		  UPPER
	  }

	  public readonly InnerEnum innerEnumValue;
	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private static int nextOrdinal = 0;

	  private ModifyFirstLetterNamingPolicy$LetterModifier(string name, InnerEnum innerEnum)
	  {
		  nameValue = name;
		  ordinalValue = nextOrdinal++;
		  innerEnumValue = innerEnum;
	  }

	  static ModifyFirstLetterNamingPolicy$LetterModifier()
	  {
		LOWER = new ModifyFirstLetterNamingPolicy$LetterModifier("LOWER", 1);
		a = new ModifyFirstLetterNamingPolicy$LetterModifier[] {UPPER, LOWER};

		  valueList.Add(LOWER);
		  valueList.Add(UPPER);
	  }

		public static ModifyFirstLetterNamingPolicy$LetterModifier[] values()
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

		public static ModifyFirstLetterNamingPolicy$LetterModifier valueOf(string name)
		{
			foreach (ModifyFirstLetterNamingPolicy$LetterModifier enumInstance in ModifyFirstLetterNamingPolicy$LetterModifier.valueList)
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\ModifyFirstLetterNamingPolicy$LetterModifier.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}