using Editable = android.text.Editable;
using TextWatcher = android.text.TextWatcher;
using EditText = android.widget.EditText;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;

public class hf : TextWatcher
{
  private EditText b;

  public hf(EditAddressActivity paramEditAddressActivity, EditText paramEditText)
  {
	this.b = paramEditText;
  }

  public virtual void afterTextChanged(Editable paramEditable)
  {
  }

  public virtual void beforeTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
  }

  public virtual void onTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
	paramInt1 = 2130837570;
	if ("".Equals(paramCharSequence.ToString()))
	{
	  paramInt1 = 2130837596;
	}
	this.b.setCompoundDrawablesWithIntrinsicBounds(0, 0, paramInt1, 0);
	EditAddressActivity.a(this.a, false);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */