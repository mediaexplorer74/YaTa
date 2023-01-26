using Editable = android.text.Editable;
using TextWatcher = android.text.TextWatcher;
using Button = android.widget.Button;
using RatingBar = android.widget.RatingBar;
using RateActivity = ru.yandex.taxi.activity.RateActivity;

public class la : TextWatcher
{
  public la(RateActivity paramRateActivity, RatingBar paramRatingBar)
  {
  }

  public virtual void afterTextChanged(Editable paramEditable)
  {
  }

  public virtual void beforeTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
  }

  public virtual void onTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
	bool @bool;
	Button button = RateActivity.b(this.b);
	if (!RateActivity.a(this.b) && (!"".Equals(paramCharSequence.ToString()) || this.a.getRating() > 0.0F))
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	button.setEnabled(@bool);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\la.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */