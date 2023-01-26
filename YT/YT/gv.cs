using Editable = android.text.Editable;
using TextWatcher = android.text.TextWatcher;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;

public class gv : TextWatcher
{
  public gv(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual void afterTextChanged(Editable paramEditable)
  {
	EditAddressActivity.a(this.a, false);
	EditAddressActivity.b(this.a, null);
  }

  public virtual void beforeTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
  }

  public virtual void onTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */