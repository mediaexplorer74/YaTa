using Editable = android.text.Editable;
using TextWatcher = android.text.TextWatcher;
using View = android.view.View;
using Filterable = android.widget.Filterable;
using SearchCityActivity = ru.yandex.taxi.activity.SearchCityActivity;

public class lt : TextWatcher
{
  public lt(SearchCityActivity paramSearchCityActivity)
  {
  }

  public virtual void afterTextChanged(Editable paramEditable)
  {
  }

  public virtual void beforeTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
	if (!"".Equals(paramCharSequence) && "".Equals(SearchCityActivity.a(this.a).getText().ToString()))
	{
	  SearchCityActivity.b(this.a);
	  this.a.unregisterForContextMenu((View)SearchCityActivity.c(this.a));
	  SearchCityActivity.a(this.a).setCompoundDrawablesWithIntrinsicBounds(2130837601, 0, 2130837570, 0);
	}
  }

  public virtual void onTextChanged(CharSequence paramCharSequence, int paramInt1, int paramInt2, int paramInt3)
  {
	if ("".Equals(paramCharSequence.ToString()))
	{
	  SearchCityActivity.d(this.a);
	  this.a.registerForContextMenu((View)SearchCityActivity.c(this.a));
	  SearchCityActivity.a(this.a).setCompoundDrawablesWithIntrinsicBounds(2130837601, 0, 2130837636, 0);
	  return;
	}
	((Filterable)SearchCityActivity.c(this.a).getAdapter()).getFilter().filter(paramCharSequence.ToString());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lt.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */