using View = android.view.View;
using RequirementsActivity = ru.yandex.taxi.activity.RequirementsActivity;
using Requirements = ru.yandex.taxi.data.Requirements;

public class lp : View.OnClickListener
{
  public lp(RequirementsActivity paramRequirementsActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	bool @bool;
	Requirements requirements = RequirementsActivity.a(this.a);
	if (!(RequirementsActivity.a(this.a)).universal)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	requirements.universal = @bool;
	RequirementsActivity.a(this.a, 2, (RequirementsActivity.a(this.a)).universal, 2130837578, 2130837579);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */