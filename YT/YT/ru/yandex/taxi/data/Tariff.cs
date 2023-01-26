using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.data
{
	using qe;
	using qf;

	[Serializable]
	public class Tariff
	{
	  public const string BUSINESS = "vip";

	  public static readonly List<string> CLASSES;

	  public const int DAY_FINISH_HOUR = 21;

	  public const int DAY_START_HOUR = 10;

	  public const string ECONOM = "econom";

	  public const string VIP = "business";

	  public static readonly List<int> WEEKEND = (List<int>)new qe();

	  private SimpleDateFormat a = new SimpleDateFormat("HH:mm");

	  private string b;

	  private string c;

	  private List<Tariff$TariffDescription> d = new List<Tariff$TariffDescription>();

	  private string e;

	  private int f;

	  private int g;

	  private string h;

	  private string i;

	  private string j;

	  private string k;

	  static Tariff()
	  {
		CLASSES = (List<string>)new qf();
	  }

	  public static bool isDayNow(DateTime paramDate)
	  {
		return (paramDate.Hour >= 10 && paramDate.Hour < 21 && !WEEKEND.Contains(Convert.ToInt32(paramDate.getDay())));
	  }

	  public virtual void addInterval(Tariff$TariffDescription paramTariff$TariffDescription)
	  {
		this.d.Add(paramTariff$TariffDescription);
	  }

	  public virtual string Clazz
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
			return this.h;
		  }
		  set
		  {
			this.h = value;
		  }
	  }

	  public virtual int getCurrentInterval(DateTime paramDate)
	  {
		// Byte code:
		//   0: iconst_0
		//   1: istore_2
		//   2: aload_0
		//   3: getfield d : Ljava/util/ArrayList;
		//   6: invokevirtual size : ()I
		//   9: iconst_1
		//   10: isub
		//   11: istore_3
		//   12: iload_2
		//   13: istore #4
		//   15: iload_3
		//   16: iflt -> 226
		//   19: aload_0
		//   20: getfield d : Ljava/util/ArrayList;
		//   23: iload_3
		//   24: invokevirtual get : (I)Ljava/lang/Object;
		//   27: checkcast ru/yandex/taxi/data/Tariff$TariffDescription
		//   30: astore #5
		//   32: aload_1
		//   33: invokevirtual getDay : ()I
		//   36: ifne -> 161
		//   39: bipush #7
		//   41: istore #6
		//   43: aload #5
		//   45: getfield schedules : Ljava/util/ArrayList;
		//   48: invokevirtual iterator : ()Ljava/util/Iterator;
		//   51: astore #7
		//   53: iconst_0
		//   54: istore #4
		//   56: aload #7
		//   58: invokeinterface hasNext : ()Z
		//   63: ifeq -> 214
		//   66: aload #7
		//   68: invokeinterface next : ()Ljava/lang/Object;
		//   73: checkcast ru/yandex/taxi/data/Tariff$Schedule
		//   76: astore #5
		//   78: aload #5
		//   80: getfield days : Ljava/util/ArrayList;
		//   83: iload #6
		//   85: invokestatic valueOf : (I)Ljava/lang/Integer;
		//   88: invokevirtual contains : (Ljava/lang/Object;)Z
		//   91: ifeq -> 235
		//   94: aload_0
		//   95: getfield a : Ljava/text/SimpleDateFormat;
		//   98: aload_1
		//   99: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   102: astore #8
		//   104: aload #5
		//   106: getfield start : Ljava/lang/String;
		//   109: aload #5
		//   111: getfield end : Ljava/lang/String;
		//   114: invokevirtual compareTo : (Ljava/lang/String;)I
		//   117: ifge -> 176
		//   120: aload #5
		//   122: getfield start : Ljava/lang/String;
		//   125: aload #8
		//   127: invokevirtual compareTo : (Ljava/lang/String;)I
		//   130: ifgt -> 170
		//   133: aload #5
		//   135: getfield end : Ljava/lang/String;
		//   138: aload #8
		//   140: invokevirtual compareTo : (Ljava/lang/String;)I
		//   143: iflt -> 170
		//   146: iconst_1
		//   147: istore #4
		//   149: iload #4
		//   151: istore #9
		//   153: iload #4
		//   155: ifne -> 218
		//   158: goto -> 56
		//   161: aload_1
		//   162: invokevirtual getDay : ()I
		//   165: istore #6
		//   167: goto -> 43
		//   170: iconst_0
		//   171: istore #4
		//   173: goto -> 149
		//   176: aload #5
		//   178: getfield start : Ljava/lang/String;
		//   181: aload #8
		//   183: invokevirtual compareTo : (Ljava/lang/String;)I
		//   186: ifle -> 202
		//   189: aload #5
		//   191: getfield end : Ljava/lang/String;
		//   194: aload #8
		//   196: invokevirtual compareTo : (Ljava/lang/String;)I
		//   199: iflt -> 208
		//   202: iconst_1
		//   203: istore #4
		//   205: goto -> 149
		//   208: iconst_0
		//   209: istore #4
		//   211: goto -> 149
		//   214: iload #4
		//   216: istore #9
		//   218: iload #9
		//   220: ifeq -> 229
		//   223: iload_3
		//   224: istore #4
		//   226: iload #4
		//   228: ireturn
		//   229: iinc #3, -1
		//   232: goto -> 12
		//   235: goto -> 158
	  }

	  public virtual int DayPrice
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

	  public virtual string Id
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

	  public virtual string IncludedDay
	  {
		  get
		  {
			return this.i;
		  }
		  set
		  {
			this.i = value;
		  }
	  }

	  public virtual string IncludedNight
	  {
		  get
		  {
			return this.j;
		  }
		  set
		  {
			this.j = value;
		  }
	  }

	  public virtual Tariff$TariffDescription getInterval(int paramInt)
	  {
		return this.d[paramInt];
	  }

	  public virtual int IntervalSize
	  {
		  get
		  {
			return this.d.Count;
		  }
	  }

	  public virtual string Name
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

	  public virtual int NightPrice
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

	  public virtual string Other
	  {
		  get
		  {
			return this.k;
		  }
		  set
		  {
			this.k = value;
		  }
	  }









	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\Tariff.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}