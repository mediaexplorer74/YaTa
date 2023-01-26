using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.data
{

	[Serializable]
	public class Park
	{
	  public const string TYPE_DISPATCH = "dispatch";

	  public const string TYPE_PARK = "taxipark";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string a_Conflict;

	  private string b;

	  private string c;

	  private string d;

	  private string e;

	  private bool f;

	  private double g;

	  private string h;

	  private List<Tariff> i = new List<Tariff>();

	  private static int a(string paramString1, string paramString2)
	  {
		return paramString1.Equals(paramString2) ? 0 : (paramString1.Contains("час") ? (paramString2.Contains("час") ? string.CompareOrdinal(paramString1, paramString2) : 1) : (paramString2.Contains("час") ? (paramString1.Contains("час") ? string.CompareOrdinal(paramString1, paramString2) : -1) : string.CompareOrdinal(paramString1, paramString2)));
	  }

	  public virtual void addTariff(Tariff paramTariff)
	  {
		this.i.Add(paramTariff);
	  }

	  public virtual void clearTariffList()
	  {
		this.i.Clear();
	  }

	  public virtual string Car
	  {
		  get
		  {
			return this.e;
		  }
		  set
		  {
			this.e = value;
		  }
	  }

	  public virtual string Currency
	  {
		  get
		  {
			return (this.i.Count > 0) ? ((Tariff)this.i[0]).Currency : "руб";
		  }
	  }

	  public virtual string LogoUrl
	  {
		  get
		  {
			return this.c;
		  }
		  set
		  {
			this.c = value;
		  }
	  }

	  public virtual string getMaxInclude(bool paramBoolean, TariffLimits paramTariffLimits)
	  {
		IEnumerator<Tariff> iterator = this.i.GetEnumerator();
		for (object @object = "";; @object = SYNTHETIC_LOCAL_VARIABLE_5)
		{
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
		  if (iterator.hasNext())
		  {
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
			Tariff tariff = iterator.next();
			if (paramTariffLimits.checkClass(tariff.Clazz))
			{
			  string str;
			  if ("".Equals(@object))
			  {
				if (paramBoolean)
				{
				  @object = tariff.IncludedDay;
				  continue;
				}
				@object = tariff.IncludedNight;
				continue;
			  }
			  if (paramBoolean)
			  {
				str = tariff.IncludedDay;
			  }
			  else
			  {
				str = str.getIncludedNight();
			  }
			  if (a(str, (string)@object) > 0)
			  {
				continue;
			  }
			}
		  }
		  else
		  {
			return (string)@object;
		  }
		  object object1 = @object;
		  continue;
		}
	  }

	  public virtual int getMaxPrice(bool paramBoolean, TariffLimits paramTariffLimits)
	  {
		sbyte b = 0;
		if (paramBoolean)
		{
		  int j = b;
		  if (this.i.Count > 0)
		  {
			IEnumerator<Tariff> iterator = this.i.GetEnumerator();
			int k = 0;
			while (iterator.MoveNext())
			{
			  Tariff tariff = iterator.Current;
			  if (paramTariffLimits.checkClass(tariff.Clazz) && tariff.DayPrice > k)
			  {
				k = tariff.DayPrice;
			  }
			}
			if (k == 0)
			{
			  k = 0;
			}
			j = k;
		  }
		  return j;
		}
		int i = b;
		if (this.i.Count > 0)
		{
		  IEnumerator<Tariff> iterator = this.i.GetEnumerator();
		  int j = 0;
		  while (iterator.MoveNext())
		  {
			Tariff tariff = iterator.Current;
			if (paramTariffLimits.checkClass(tariff.Clazz) && tariff.NightPrice > j)
			{
			  j = tariff.NightPrice;
			}
		  }
		  i = b;
		  if (j != 0)
		  {
			i = j;
		  }
		}
		return i;
	  }

	  public virtual string getMinInclude(bool paramBoolean, TariffLimits paramTariffLimits)
	  {
		IEnumerator<Tariff> iterator = this.i.GetEnumerator();
		for (object @object = "";; @object = SYNTHETIC_LOCAL_VARIABLE_5)
		{
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
		  if (iterator.hasNext())
		  {
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
			Tariff tariff = iterator.next();
			if (paramTariffLimits.checkClass(tariff.Clazz))
			{
			  string str;
			  if ("".Equals(@object))
			  {
				if (paramBoolean)
				{
				  @object = tariff.IncludedDay;
				  continue;
				}
				@object = tariff.IncludedNight;
				continue;
			  }
			  if (paramBoolean)
			  {
				str = tariff.IncludedDay;
			  }
			  else
			  {
				str = str.getIncludedNight();
			  }
			  if (a(str, (string)@object) < 0)
			  {
				continue;
			  }
			}
		  }
		  else
		  {
			return (string)@object;
		  }
		  object object1 = @object;
		  continue;
		}
	  }

	  public virtual int getMinPrice(bool paramBoolean, TariffLimits paramTariffLimits)
	  {
		sbyte b = 0;
		if (paramBoolean)
		{
		  int j = b;
		  if (this.i.Count > 0)
		  {
			IEnumerator<Tariff> iterator = this.i.GetEnumerator();
			int k = int.MaxValue;
			while (iterator.MoveNext())
			{
			  Tariff tariff = iterator.Current;
			  if (paramTariffLimits.checkClass(tariff.Clazz) && tariff.DayPrice < k)
			  {
				k = tariff.DayPrice;
			  }
			}
			if (k == int.MaxValue)
			{
			  k = 0;
			}
			j = k;
		  }
		  return j;
		}
		int i = b;
		if (this.i.Count > 0)
		{
		  IEnumerator<Tariff> iterator = this.i.GetEnumerator();
		  int j = int.MaxValue;
		  while (iterator.MoveNext())
		  {
			Tariff tariff = iterator.Current;
			if (paramTariffLimits.checkClass(tariff.Clazz) && tariff.NightPrice < j)
			{
			  j = tariff.NightPrice;
			}
		  }
		  i = b;
		  if (j != int.MaxValue)
		  {
			i = j;
		  }
		}
		return i;
	  }

	  public virtual string Name
	  {
		  get
		  {
			return this.b;
		  }
		  set
		  {
			this.b = value;
		  }
	  }

	  public virtual string ParkId
	  {
		  get
		  {
			return this.a_Conflict;
		  }
		  set
		  {
			this.a_Conflict = value;
		  }
	  }

	  public virtual string Phone
	  {
		  get
		  {
			return this.d;
		  }
		  set
		  {
			this.d = value;
		  }
	  }

	  public virtual double Rating
	  {
		  get
		  {
			return this.g;
		  }
		  set
		  {
			this.g = value;
		  }
	  }

	  public virtual Tariff getTariff(int paramInt)
	  {
		return this.i[paramInt];
	  }

	  public virtual Tariff getTariffById(string paramString)
	  {
		// Byte code:
		//   0: aload_0
		//   1: getfield i : Ljava/util/ArrayList;
		//   4: invokevirtual iterator : ()Ljava/util/Iterator;
		//   7: astore_2
		//   8: aload_2
		//   9: invokeinterface hasNext : ()Z
		//   14: ifeq -> 42
		//   17: aload_2
		//   18: invokeinterface next : ()Ljava/lang/Object;
		//   23: checkcast ru/yandex/taxi/data/Tariff
		//   26: astore_3
		//   27: aload_3
		//   28: invokevirtual getId : ()Ljava/lang/String;
		//   31: aload_1
		//   32: invokevirtual equals : (Ljava/lang/Object;)Z
		//   35: ifeq -> 8
		//   38: aload_3
		//   39: astore_1
		//   40: aload_1
		//   41: areturn
		//   42: aconst_null
		//   43: astore_1
		//   44: goto -> 40
	  }

	  public virtual string[] TariffList
	  {
		  get
		  {
			string[] arrayOfString = new string[this.i.Count];
			for (sbyte b = 0; b < this.i.Count; b++)
			{
			  arrayOfString[b] = ((Tariff)this.i[b]).Name;
			}
			return arrayOfString;
		  }
		  set
		  {
			this.i = value;
		  }
	  }

	  public virtual int getTariffPosition(Tariff paramTariff)
	  {
		return this.i.IndexOf(paramTariff);
	  }

	  public virtual int TariffsCount
	  {
		  get
		  {
			return this.i.Count;
		  }
	  }

	  public virtual string Type
	  {
		  get
		  {
			return this.h;
		  }
		  set
		  {
			this.h = value;
		  }
	  }

	  public virtual bool OrderAllowed
	  {
		  get
		  {
			return this.f;
		  }
		  set
		  {
			this.f = value;
		  }
	  }









	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\Park.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}