using View = android.view.View;
using SlidingDrawer = ru.yandex.taxi.ui.slider.SlidingDrawer;

public class qw : View.OnClickListener
{
  private qw(SlidingDrawer paramSlidingDrawer, sbyte paramByte)
  {
  }

  public virtual void onClick(View paramView)
  {
	if (!SlidingDrawer.a(this.a))
	{
	  if (SlidingDrawer.b(this.a))
	  {
		this.a.animateToggle();
		return;
	  }
	  this.a.toggle();
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */