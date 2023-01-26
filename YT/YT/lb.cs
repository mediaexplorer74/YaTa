using Button = android.widget.Button;
using EditText = android.widget.EditText;
using RatingBar = android.widget.RatingBar;
using RateActivity = ru.yandex.taxi.activity.RateActivity;

public class lb : RatingBar.OnRatingBarChangeListener
{
  public lb(RateActivity paramRateActivity, EditText paramEditText)
  {
  }

  public virtual void onRatingChanged(RatingBar paramRatingBar, float paramFloat, bool paramBoolean)
  {
	Button button = RateActivity.b(this.b);
	if (!RateActivity.a(this.b) && (!"".Equals(this.a.getText().ToString()) || paramRatingBar.getRating() > 0.0F))
	{
	  paramBoolean = true;
	}
	else
	{
	  paramBoolean = false;
	}
	button.setEnabled(paramBoolean);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */