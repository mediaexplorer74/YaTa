using Attribute = ru.yandex.taxi.suggest.Attribute;

public class qp : Attribute
{
  internal qp(int paramInt1, int paramInt2) : base(false, paramInt1, paramInt2)
  {
  }

  public override int Compare(object paramObject1, object paramObject2)
  {
	paramObject1 = paramObject1;
	paramObject2 = paramObject2;
	return (paramObject1.getWeight() > paramObject2.getWeight()) ? -1 : ((paramObject1.getWeight() < paramObject2.getWeight()) ? 1 : 0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */