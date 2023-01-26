using View = android.view.View;
using MapController = ru.yandex.yandexmapkit.MapController;

public class o : View.OnClickListener
{
  public o(MapController paramMapController)
  {
  }

  public virtual void onClick(View paramView)
  {
	if (paramView.Equals(this.a.h))
	{
	  this.a.zoomIn();
	  return;
	}
	if (paramView.Equals(this.a.i))
	{
	  this.a.zoomOut();
	  return;
	}
	if (paramView.Equals(this.a.j))
	{
	  this.a.f.getMyLocation().findMe();
	  return;
	}
	if (paramView.Equals(this.a.k))
	{
	  if (this.a.isJamsVisible())
	  {
		this.a.k.setBackgroundDrawable(this.a.l[0]);
		this.a.k.setText("");
		this.a.setJamsVisible(false);
		return;
	  }
	  this.a.k.setBackgroundDrawable(this.a.l[this.a.m]);
	  if (this.a.n >= 0)
	  {
		this.a.k.setText(this.a.n.ToString());
	  }
	  this.a.setJamsVisible(true);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\o.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */