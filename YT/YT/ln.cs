using View = android.view.View;
using RequirementsActivity = ru.yandex.taxi.activity.RequirementsActivity;
using Requirements = ru.yandex.taxi.data.Requirements;

public class ln : View.OnClickListener
{
  public ln(RequirementsActivity paramRequirementsActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	bool @bool;
	Requirements requirements = RequirementsActivity.a(this.a);
	if (!(RequirementsActivity.a(this.a)).conditioner)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	requirements.conditioner = @bool;
	RequirementsActivity.a(this.a, 0, (RequirementsActivity.a(this.a)).conditioner, 2130837563, 2130837564);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ln.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */