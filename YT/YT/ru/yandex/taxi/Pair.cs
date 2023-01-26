using System;

namespace ru.yandex.taxi
{

	[Serializable]
	public class Pair<T, V>
	{
	  public T first;

	  public V second;

	  public Pair()
	  {
	  }

	  public Pair(T paramT, V paramV)
	  {
		this.first = paramT;
		this.second = paramV;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\Pair.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}