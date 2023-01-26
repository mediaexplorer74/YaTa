using Editable = android.text.Editable;
using TextWatcher = android.text.TextWatcher;
using Button = android.widget.Button;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;

public class gi : TextWatcher
{
  public gi(ConfirmActivity paramConfirmActivity)
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
	Button button = ConfirmActivity.a(this.a);
	if (paramCharSequence.length() > 0)
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


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */