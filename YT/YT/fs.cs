using Editable = android.text.Editable;
using TextWatcher = android.text.TextWatcher;
using Button = android.widget.Button;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class fs : TextWatcher
{
  public fs(AuthorizeActivity paramAuthorizeActivity)
  {
  }

  public virtual void afterTextChanged(Editable paramEditable)
  {
	bool @bool;
	Button button = AuthorizeActivity.a(this.a);
	if (paramEditable.ToString().Length >= 7)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	button.setEnabled(@bool);
  }

  public virtual void beforeTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
  }

  public virtual void onTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fs.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */