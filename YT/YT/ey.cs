public class ey : Writer
{
  private readonly Appendable a;

  private readonly ez b = new ez();

  private ey(Appendable paramAppendable, sbyte paramByte)
  {
	this.a = paramAppendable;
  }

  public virtual void close()
  {
  }

  public virtual void flush()
  {
  }

  public virtual void write(int paramInt)
  {
	this.a.append((char)paramInt);
  }

  public virtual void write(char[] paramArrayOfchar, int paramInt1, int paramInt2)
  {
	this.b.a = paramArrayOfchar;
	this.a.append(this.b, paramInt1, paramInt1 + paramInt2);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ey.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */