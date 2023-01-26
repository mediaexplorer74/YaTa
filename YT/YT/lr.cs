using View = android.view.View;
using LinearLayout = android.widget.LinearLayout;
using RequirementsActivity = ru.yandex.taxi.activity.RequirementsActivity;
using Requirements = ru.yandex.taxi.data.Requirements;

public class lr : View.OnClickListener
{
  public lr(RequirementsActivity paramRequirementsActivity, LinearLayout paramLinearLayout)
  {
  }

  public virtual void onClick(View paramView)
  {
	bool @bool;
	Requirements requirements = RequirementsActivity.a(this.b);
	if (!(RequirementsActivity.a(this.b)).animal)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	requirements.animal = @bool;
	RequirementsActivity.a(this.b, this.a.getChildCount() - 1, (RequirementsActivity.a(this.b)).animal, 2130837566, 2130837567);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */