internal class ez : CharSequence
{
  internal char[] a;

  public virtual char charAt(int paramInt)
  {
	return this.a[paramInt];
  }

  public virtual int length()
  {
	return this.a.Length;
  }

  public virtual CharSequence subSequence(int paramInt1, int paramInt2)
  {
	return new string(this.a, paramInt1, paramInt2 - paramInt1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ez.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */