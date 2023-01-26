using System.Collections.Generic;

using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using ArrayAdapter = android.widget.ArrayAdapter;
using TextView = android.widget.TextView;
using ru.yandex.taxi;
using TransferActivity = ru.yandex.taxi.activity.TransferActivity;

public class oz : ArrayAdapter
{
  private List<Pair<string, string>> b;

  public oz(TransferActivity paramTransferActivity, List<Pair<string, string>> paramArrayList) : base(paramTransferActivity.getApplicationContext(), 2130903069, 2131558403)
  {
	this.b = paramArrayList;
  }

  public virtual int Count
  {
	  get
	  {
		return this.b.Count;
	  }
  }

  public virtual object getItem(int paramInt)
  {
	return ((Pair)this.b[paramInt]).first;
  }

  public virtual long getItemId(int paramInt)
  {
	return paramInt;
  }

  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
	View view = base.getView(paramInt, paramView, paramViewGroup);
	pa pa2 = (pa)view.getTag();
	pa pa1 = pa2;
	if (pa2 == null)
	{
	  pa1 = new pa();
	  view.findViewById(2131558403);
	  pa1.a = (TextView)view.findViewById(2131558457);
	  view.setTag(pa1);
	}
	pa1.a.setText((string)((Pair)this.b[paramInt]).second + " " + TransferActivity.a(this.a));
	return view;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\oz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */