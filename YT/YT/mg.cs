using Editable = android.text.Editable;
using TextWatcher = android.text.TextWatcher;
using View = android.view.View;
using Filterable = android.widget.Filterable;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;

public class mg : TextWatcher
{
  public mg(SearchStreetActivity paramSearchStreetActivity)
  {
  }

  public virtual void afterTextChanged(Editable paramEditable)
  {
  }

  public virtual void beforeTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
	if (!"".Equals(paramCharSequence) && "".Equals(SearchStreetActivity.c(this.a).getText().ToString()))
	{
	  SearchStreetActivity.a(this.a, true);
	  SearchStreetActivity.f(this.a);
	  this.a.unregisterForContextMenu((View)SearchStreetActivity.g(this.a));
	  SearchStreetActivity.c(this.a).setCompoundDrawablesWithIntrinsicBounds(2130837601, 0, 2130837570, 0);
	}
  }

  public virtual void onTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
	if ("".Equals(paramCharSequence.ToString()) && !SearchStreetActivity.h(this.a))
	{
	  SearchStreetActivity.a(this.a, false);
	  SearchStreetActivity.i(this.a);
	  this.a.registerForContextMenu((View)SearchStreetActivity.g(this.a));
	  SearchStreetActivity.c(this.a).setCompoundDrawablesWithIntrinsicBounds(2130837601, 0, 2130837636, 0);
	  return;
	}
	((Filterable)SearchStreetActivity.g(this.a).getAdapter()).getFilter().filter(paramCharSequence.ToString());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */