using System.Collections.Generic;

namespace ru.yandex.taxi.suggest
{

	public class Attribute : IComparer<object>
	{
	  private string a;

	  private string b;

	  private bool c;

	  private bool d;

	  private int e;

	  protected internal int weight;

	  public Attribute(bool paramBoolean, int paramInt1, int paramInt2)
	  {
		this.d = paramBoolean;
		this.e = paramInt1;
		this.weight = paramInt2;
	  }

	  public virtual int Compare(object paramObject1, object paramObject2)
	  {
		null = ((Attribute)paramObject1).Index;
		int i = ((Attribute)paramObject2).Index;
		return (null > i) ? 1 : ((null < i) ? -1 : 0);
	  }

	  public virtual int Index
	  {
		  get
		  {
			return this.e;
		  }
	  }

	  protected internal virtual string Text
	  {
		  get
		  {
			return this.a;
		  }
		  set
		  {
			this.a = value;
		  }
	  }

	  protected internal virtual string TextUA
	  {
		  get
		  {
			return this.b;
		  }
		  set
		  {
			this.b = value;
			this.c = true;
		  }
	  }

	  protected internal virtual bool Type
	  {
		  get
		  {
			return this.d;
		  }
	  }

	  protected internal virtual int Weight
	  {
		  get
		  {
			return this.weight;
		  }
	  }

	  protected internal virtual bool UA
	  {
		  get
		  {
			return this.c;
		  }
	  }


	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\suggest\Attribute.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}