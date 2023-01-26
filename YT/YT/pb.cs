using System.Collections.Generic;

using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using ArrayAdapter = android.widget.ArrayAdapter;
using TransferListActivity = ru.yandex.taxi.activity.TransferListActivity;
using Tariff = ru.yandex.taxi.data.Tariff;

public class pb : ArrayAdapter
{
  private List<Tariff.Transfer> b;

  public pb(TransferListActivity paramTransferListActivity, List<Tariff.Transfer> paramArrayList) : base(paramTransferListActivity.getApplicationContext(), 2130903071, 2131558403)
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
	return ((Tariff.Transfer)this.b[paramInt]).name;
  }

  public virtual long getItemId(int paramInt)
  {
	return paramInt;
  }

  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
	paramView = base.getView(paramInt, paramView, paramViewGroup);
	if ((pd)paramView.getTag() == null)
	{
	  pd pd = new pd();
	  paramView.findViewById(2131558403);
	  paramView.setTag(pd);
	}
	paramView.setOnClickListener(new pc(this, paramInt));
	return paramView;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */