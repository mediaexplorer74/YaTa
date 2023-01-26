namespace ru.yandex.taxi.suggest
{
	using qo;
	using qp;

	public class Result
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private string a_Conflict;

	  private qo[] b;

	  private qp[] c;

	  internal virtual string a()
	  {
		return this.a_Conflict;
	  }

	  internal virtual void a(string paramString)
	  {
		this.a_Conflict = paramString;
	  }

	  internal virtual void a(qo[] paramArrayOfqo)
	  {
		this.b = paramArrayOfqo;
	  }

	  internal virtual void a(qp[] paramArrayOfqp)
	  {
		this.c = paramArrayOfqp;
	  }

	  public virtual bool equialPop(string paramString)
	  {
		bool @bool = false;
		int i = this.c.Length;
		for (sbyte b = 0;; b++)
		{
		  bool bool1 = @bool;
		  if (b < i)
		  {
			qp qp1 = this.c[b];
			if (qp1.Text.Equals(paramString) || (qp1.UA && qp1.TextUA.Equals(paramString)))
			{
			  this.c = Utils.removingItemFromArray<qp>(this.c, b);
			  return true;
			}
		  }
		  else
		  {
			return bool1;
		  }
		}
	  }

	  public virtual qo[] Geo
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public virtual int GeoSize
	  {
		  get
		  {
			return (this.b != null) ? this.b.Length : 0;
		  }
	  }

	  public virtual qp[] Pop
	  {
		  get
		  {
			return this.c;
		  }
	  }

	  public virtual int PopSize
	  {
		  get
		  {
			return (this.c != null) ? this.c.Length : 0;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\suggest\Result.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}