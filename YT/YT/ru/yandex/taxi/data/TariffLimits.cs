using System;
using System.Collections.Generic;
using System.Text;

namespace ru.yandex.taxi.data
{

	[Serializable]
	public class TariffLimits
	{
	  private List<string> a = new List<string>();

	  private List<string> b = new List<string>();

	  private bool c;

	  public TariffLimits()
	  {
		this.a.Add("econom");
		this.a.Add("business");
	  }

	  public virtual void addClass(string paramString)
	  {
		this.a.Add(paramString);
	  }

	  public virtual void addExcludePark(string paramString)
	  {
		this.b.Add(paramString);
	  }

	  public virtual bool checkClass(string paramString)
	  {
		return this.a.Contains(paramString);
	  }

	  public virtual bool checkExcludePark(string paramString)
	  {
		return this.b.Contains(paramString);
	  }

	  public override bool Equals(object paramObject)
	  {
		bool bool1 = false;
		if (paramObject == null)
		{
		  return bool1;
		}
		paramObject = paramObject;
		bool bool2 = bool1;
		if (ClassesString.Equals(paramObject.getClassesString()))
		{
		  bool2 = bool1;
		  if (ExcludedParksString.Equals(paramObject.getExcludedParksString()))
		  {
			bool2 = true;
		  }
		}
		return bool2;
	  }

	  public virtual string getClass(int paramInt)
	  {
		return this.a[paramInt];
	  }

	  public virtual string[] Classes
	  {
		  get
		  {
			return this.a.toArray<string>(new string[0]);
		  }
	  }

	  public virtual int ClassesCount
	  {
		  get
		  {
			return this.a.Count;
		  }
	  }

	  public virtual string ClassesString
	  {
		  get
		  {
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string str in this.a)
			{
			  stringBuilder.Append(str + ";");
			}
			return stringBuilder.ToString();
		  }
	  }

	  public virtual string getExcludePark(int paramInt)
	  {
		return this.b[paramInt];
	  }

	  public virtual string[] ExcludeParks
	  {
		  get
		  {
			return this.b.toArray<string>(new string[0]);
		  }
	  }

	  public virtual int ExcludeParksCount
	  {
		  get
		  {
			return this.b.Count;
		  }
	  }

	  public virtual string ExcludedParksString
	  {
		  get
		  {
			StringBuilder stringBuilder = new StringBuilder(this.c + ";");
			foreach (string str in this.b)
			{
			  stringBuilder.Append(str + ";");
			}
			return stringBuilder.ToString();
		  }
	  }

	  public virtual bool AllUnchecked
	  {
		  get
		  {
			return this.c;
		  }
	  }

	  public virtual bool Business
	  {
		  get
		  {
			return this.a.Contains("vip");
		  }
	  }

	  public virtual bool Default
	  {
		  get
		  {
			return (this.a.Count == Tariff.CLASSES.Count && this.b.Count == 0);
		  }
	  }

	  public virtual bool Econom
	  {
		  get
		  {
			return this.a.Contains("econom");
		  }
	  }

	  public virtual bool Norm
	  {
		  get
		  {
			return this.a.Contains("business");
		  }
	  }

	  public virtual void removeClass(string paramString)
	  {
		this.a.Remove(paramString);
	  }

	  public virtual void removeExcludePark(string paramString)
	  {
		this.b.Remove(paramString);
	  }

	  public virtual bool AllUnckecked
	  {
		  set
		  {
			this.c = value;
		  }
	  }

	  public virtual void setTariffLimits(string paramString1, string paramString2)
	  {
		string[] arrayOfString = paramString2.Split(";", true);
		this.c = "true".Equals(arrayOfString[0]);
		sbyte b;
		for (b = 1; b < arrayOfString.Length; b++)
		{
		  string str = arrayOfString[b];
		  if (!"".Equals(str))
		  {
			this.b.Add(str);
		  }
		}
		arrayOfString = paramString1.Split(";", true);
		if (arrayOfString.Length > 0)
		{
		  this.a.Clear();
		  int i = arrayOfString.Length;
		  for (b = 0; b < i; b++)
		  {
			paramString1 = arrayOfString[b];
			if (!"".Equals(paramString1))
			{
			  this.a.Add(paramString1);
			}
		  }
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\TariffLimits.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}