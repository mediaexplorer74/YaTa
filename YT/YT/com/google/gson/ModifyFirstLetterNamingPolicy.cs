using System.Collections.Generic;
using System.Text;

namespace com.google.gson
{
	using  = com.google.gson.@internal.;
	using et;

	public sealed class ModifyFirstLetterNamingPolicy : et
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly ModifyFirstLetterNamingPolicy$LetterModifier a_Conflict;

	  public ModifyFirstLetterNamingPolicy(ModifyFirstLetterNamingPolicy$LetterModifier paramModifyFirstLetterNamingPolicy$LetterModifier)
	  {
		this.a_Conflict = (ModifyFirstLetterNamingPolicy$LetterModifier).Gson.Preconditions.checkNotNull(paramModifyFirstLetterNamingPolicy$LetterModifier);
	  }

	  private static string a(char paramChar, string paramString, int paramInt)
	  {
		return (paramInt < paramString.Length) ? (paramChar + paramString.Substring(paramInt)) : paramChar.ToString();
	  }

	  protected internal override string a(string paramString, Type paramType, ICollection<Annotation> paramCollection)
	  {
		bool @bool = false;
		StringBuilder stringBuilder = new StringBuilder();
		char c = paramString[0];
		sbyte b = 0;
		char c1;
		for (c1 = c; b < paramString.Length - 1 && !char.IsLetter(c1); c1 = c)
		{
		  stringBuilder.Append(c1);
		  c = paramString[++b];
		}
		if (b == paramString.Length)
		{
		  return stringBuilder.ToString();
		}
		if (this.a_Conflict == ModifyFirstLetterNamingPolicy$LetterModifier.UPPER)
		{
		  @bool = true;
		}
		if (@bool && !char.IsUpper(c1))
		{
		  return stringBuilder.Append(a(char.ToUpper(c1), paramString, b + 1)).ToString();
		}
		string str = paramString;
		if (!@bool)
		{
		  str = paramString;
		  if (char.IsUpper(c1))
		  {
			str = stringBuilder.Append(a(char.ToLower(c1), paramString, b + 1)).ToString();
		  }
		}
		return str;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\ModifyFirstLetterNamingPolicy.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}