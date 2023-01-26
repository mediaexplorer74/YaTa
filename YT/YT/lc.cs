using View = android.view.View;
using EditText = android.widget.EditText;
using RatingBar = android.widget.RatingBar;
using RateActivity = ru.yandex.taxi.activity.RateActivity;

public class lc : View.OnClickListener
{
  public lc(RateActivity paramRateActivity, EditText paramEditText, RatingBar paramRatingBar)
  {
  }

  public virtual void onClick(View paramView)
  {
	(new ld(this)).execute((object[])new string[] {this.a.getText().ToString()});
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */