using System.Collections.Generic;

namespace ru.yandex.taxi.ui.wheel
{
	using View = android.view.View;
	using LinearLayout = android.widget.LinearLayout;

	public class WheelRecycle
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private IList<View> a_Conflict;

	  private IList<View> b;

	  private WheelView c;

	  public WheelRecycle(WheelView paramWheelView)
	  {
		this.c = paramWheelView;
	  }

	  private static View a(IList<View> paramList)
	  {
		if (paramList != null && paramList.Count > 0)
		{
		  View view = paramList[0];
		  paramList.RemoveAt(0);
		  return view;
		}
		return null;
	  }

	  private static IList<View> a(View paramView, IList<View> paramList)
	  {
		IList<View> list = paramList;
		if (paramList == null)
		{
		  list = new LinkedList<View>();
		}
		list.Add(paramView);
		return list;
	  }

	  public virtual void clearAll()
	  {
		if (this.a_Conflict != null)
		{
		  this.a_Conflict.Clear();
		}
		if (this.b != null)
		{
		  this.b.Clear();
		}
	  }

	  public virtual View EmptyItem
	  {
		  get
		  {
			return a(this.b);
		  }
	  }

	  public virtual View Item
	  {
		  get
		  {
			return a(this.a_Conflict);
		  }
	  }

	  public virtual int recycleItems(LinearLayout paramLinearLayout, int paramInt, ItemsRange paramItemsRange)
	  {
		int i = 0;
		int j;
		for (j = paramInt; i < paramLinearLayout.getChildCount(); j = m)
		{
		  int k;
		  int m;
		  if (!paramItemsRange.contains(paramInt))
		  {
			View view = paramLinearLayout.getChildAt(i);
			k = this.c.ViewAdapter.ItemsCount;
			if ((paramInt < 0 || paramInt >= k) && !this.c.Cyclic)
			{
			  this.b = a(view, this.b);
			}
			else
			{
			  this.a_Conflict = a(view, this.a_Conflict);
			}
			paramLinearLayout.removeViewAt(i);
			k = i;
			m = j;
			if (i == 0)
			{
			  m = j + 1;
			  k = i;
			}
		  }
		  else
		  {
			k = i + 1;
			m = j;
		  }
		  paramInt++;
		  i = k;
		}
		return j;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\WheelRecycle.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}