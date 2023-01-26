using System.Threading;

using MapController = ru.yandex.yandexmapkit.MapController;

public class p : ThreadStart
{
  public p(MapController paramMapController, ay paramay)
  {
  }

  public virtual void run()
  {
	if (this.a != null)
	{
	  this.b.k.setBackgroundDrawable(this.b.l[this.a.d]);
	  if (this.a.d != 4)
	  {
		this.b.k.setText(this.a.c.ToString());
		this.b.n = this.a.c;
	  }
	  else
	  {
		this.b.k.setText("");
		this.b.n = -1;
	  }
	  this.b.m = this.a.d;
	  return;
	}
	this.b.k.setBackgroundDrawable(this.b.l[4]);
	this.b.k.setText("");
	this.b.m = 4;
	this.b.n = -1;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\p.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */