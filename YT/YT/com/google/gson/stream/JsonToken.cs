using System.Collections.Generic;

namespace com.google.gson.stream
{
	public sealed class JsonToken
	{
	  public static readonly JsonToken BEGIN_ARRAY = new JsonToken("BEGIN_ARRAY", InnerEnum.BEGIN_ARRAY);
	  public static readonly JsonToken BEGIN_OBJECT = new JsonToken("BEGIN_OBJECT", InnerEnum.BEGIN_OBJECT);
	  public static readonly JsonToken BOOLEAN = new JsonToken("BOOLEAN", InnerEnum.BOOLEAN);
	  public static readonly JsonToken END_ARRAY = new JsonToken("END_ARRAY", InnerEnum.END_ARRAY);
	  public static readonly JsonToken END_DOCUMENT = new JsonToken("END_DOCUMENT", InnerEnum.END_DOCUMENT);
	  public static readonly JsonToken END_OBJECT = new JsonToken("END_OBJECT", InnerEnum.END_OBJECT);
	  public static readonly JsonToken NAME = new JsonToken("NAME", InnerEnum.NAME);
	  public static readonly JsonToken NULL = new JsonToken("NULL", InnerEnum.NULL);
	  public static readonly JsonToken NUMBER = new JsonToken("NUMBER", InnerEnum.NUMBER);
	  public static readonly JsonToken STRING = new JsonToken("STRING", InnerEnum.STRING);

	  private static readonly List<JsonToken> valueList = new List<JsonToken>();

	  public enum InnerEnum
	  {
		  BEGIN_ARRAY,
		  BEGIN_OBJECT,
		  BOOLEAN,
		  END_ARRAY,
		  END_DOCUMENT,
		  END_OBJECT,
		  NAME,
		  NULL,
		  NUMBER,
		  STRING
	  }

	  public readonly InnerEnum innerEnumValue;
	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private static int nextOrdinal = 0;

	  private JsonToken(string name, InnerEnum innerEnum)
	  {
		  nameValue = name;
		  ordinalValue = nextOrdinal++;
		  innerEnumValue = innerEnum;
	  }

	  static JsonToken()
	  {
		BEGIN_OBJECT = new JsonToken("BEGIN_OBJECT", 2);
		END_OBJECT = new JsonToken("END_OBJECT", 3);
		NAME = new JsonToken("NAME", 4);
		STRING = new JsonToken("STRING", 5);
		NUMBER = new JsonToken("NUMBER", 6);
		BOOLEAN = new JsonToken("BOOLEAN", 7);
		NULL = new JsonToken("NULL", 8);
		END_DOCUMENT = new JsonToken("END_DOCUMENT", 9);
		a = new JsonToken[] {BEGIN_ARRAY, END_ARRAY, BEGIN_OBJECT, END_OBJECT, NAME, STRING, NUMBER, BOOLEAN, NULL, END_DOCUMENT};

		  valueList.Add(BEGIN_ARRAY);
		  valueList.Add(BEGIN_OBJECT);
		  valueList.Add(BOOLEAN);
		  valueList.Add(END_ARRAY);
		  valueList.Add(END_DOCUMENT);
		  valueList.Add(END_OBJECT);
		  valueList.Add(NAME);
		  valueList.Add(NULL);
		  valueList.Add(NUMBER);
		  valueList.Add(STRING);
	  }

		public static JsonToken[] values()
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

		public static JsonToken valueOf(string name)
		{
			foreach (JsonToken enumInstance in JsonToken.valueList)
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\stream\JsonToken.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}