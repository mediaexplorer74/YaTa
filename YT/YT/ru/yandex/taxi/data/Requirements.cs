using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ru.yandex.taxi.data
{
	using Context = android.content.Context;
	using ru.yandex.taxi;

	[Serializable]
	public class Requirements
	{
	  public const string DEFAULT_CHILD_CHAIR = "0";

	  public const string DEFAULT_SMOKE = "0";

	  public const string NO_SMOKE = "1";

	  public const string WILL_SMOKE = "2";

	  public bool animal;

	  public string childChair = "0";

	  public bool conditioner;

	  public string smoke = "0";

	  public bool universal;

	  public Requirements(Context paramContext)
	  {
	  }

	  public override bool Equals(object paramObject)
	  {
		if (paramObject == null)
		{
		  return false;
		}
		paramObject = paramObject;
		return RequirementsString.Equals(paramObject.getRequirementsString());
	  }

	  public virtual IList<Pair<string, string>> Pairs
	  {
		  get
		  {
			List<Pair> arrayList = new ArrayList();
			if (this.smoke.Equals("1"))
			{
			  str = "1";
			}
			else
			{
			  str = "0";
			}
			arrayList.Add(new Pair("nosmoking", str));
			if (this.smoke.Equals("2"))
			{
			  str = "1";
			}
			else
			{
			  str = "0";
			}
			arrayList.Add(new Pair("willsmoke", str));
			if (this.conditioner)
			{
			  str = "1";
			}
			else
			{
			  str = "0";
			}
			arrayList.Add(new Pair("conditioner", str));
			if (this.animal)
			{
			  str = "1";
			}
			else
			{
			  str = "0";
			}
			arrayList.Add(new Pair("animaltransport", str));
			if (this.universal)
			{
			  str = "1";
			  arrayList.Add(new Pair("universal", str));
			  arrayList.Add(new Pair("childchair", this.childChair));
			  return (System.Collections.IList)arrayList;
			}
			string str = "0";
			arrayList.Add(new Pair("universal", str));
			arrayList.Add(new Pair("childchair", this.childChair));
			return (System.Collections.IList)arrayList;
		  }
	  }

	  public virtual string RequirementsString
	  {
		  get
		  {
			StringBuilder stringBuilder = new StringBuilder();
			foreach (Pair<string, string> pair in Pairs)
			{
			  stringBuilder.Append((string)pair.first + ":" + (string)pair.second + ";");
			}
			return stringBuilder.ToString();
		  }
	  }

	  public virtual IList<Pair<string, string>> RushPairs
	  {
		  get
		  {
			IList<Pair<string, string>> list = Pairs;
			list.RemoveAt(list.Count - 1);
			return list;
		  }
	  }

	  public virtual bool Default
	  {
		  get
		  {
			return (!this.conditioner && !this.universal && !this.animal && "0".Equals(this.childChair) && "0".Equals(this.smoke));
		  }
	  }

	  public virtual string Requirements
	  {
		  set
		  {
			foreach (string value in value.Split(";", true))
			{
			  if (!"".Equals(value))
			  {
				string str;
				string[] arrayOfString = value.Split(":", true);
				if ("nosmoking".Equals(arrayOfString[0]))
				{
				  if ("1".Equals(arrayOfString[1]))
				  {
					str = "1";
				  }
				  else
				  {
					str = this.smoke;
				  }
				  this.smoke = str;
				}
				else if ("willsmoke".Equals(str[0]))
				{
				  if ("1".Equals(str[1]))
				  {
					str = "2";
				  }
				  else
				  {
					str = this.smoke;
				  }
				  this.smoke = str;
				}
				else if ("conditioner".Equals(str[0]))
				{
				  this.conditioner = "1".Equals(str[1]);
				}
				else if ("animaltransport".Equals(str[0]))
				{
				  this.animal = "1".Equals(str[1]);
				}
				else if ("universal".Equals(str[0]))
				{
				  this.universal = "1".Equals(str[1]);
				}
				else if ("childchair".Equals(str[0]))
				{
				  this.childChair = str[1];
				}
			  }
			}
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\Requirements.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}