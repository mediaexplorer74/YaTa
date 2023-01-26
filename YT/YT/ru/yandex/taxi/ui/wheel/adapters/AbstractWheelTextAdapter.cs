namespace ru.yandex.taxi.ui.wheel.adapters
{
	using Context = android.content.Context;
	using Typeface = android.graphics.Typeface;
	using Log = android.util.Log;
	using LayoutInflater = android.view.LayoutInflater;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using TextView = android.widget.TextView;

	public abstract class AbstractWheelTextAdapter : AbstractWheelAdapter
	{
	  public const int DEFAULT_TEXT_COLOR = -1;

	  public const int DEFAULT_TEXT_SIZE = 26;

	  public const int DISABLE_TEXT_COLOR = -7829368;

	  public const int LABEL_COLOR = -9437072;

	  protected internal const int NO_RESOURCE = 0;

	  public const int TEXT_VIEW_ITEM_RESOURCE = -1;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private int a_Conflict = -1;

	  private int b = 26;

	  protected internal Context context;

	  protected internal int emptyItemResourceId;

	  protected internal LayoutInflater inflater;

	  protected internal int itemResourceId;

	  protected internal int itemTextResourceId;

	  protected internal int maxDisabledItemsBorder = int.MaxValue;

	  protected internal int minDisabledItemsBorder;

	  protected internal AbstractWheelTextAdapter(Context paramContext) : this(paramContext, -1)
	  {
	  }

	  protected internal AbstractWheelTextAdapter(Context paramContext, int paramInt) : this(paramContext, paramInt, 0)
	  {
	  }

	  protected internal AbstractWheelTextAdapter(Context paramContext, int paramInt1, int paramInt2)
	  {
		this.context = paramContext;
		this.itemResourceId = paramInt1;
		this.itemTextResourceId = paramInt2;
		this.inflater = (LayoutInflater)paramContext.getSystemService("layout_inflater");
	  }

	  private View a(int paramInt, ViewGroup paramViewGroup)
	  {
		switch (paramInt)
		{
		  default:
			return this.inflater.inflate(paramInt, paramViewGroup, false);
		  case 0:
			return null;
		  case -1:
			break;
		}
		return (View)new TextView(this.context);
	  }

	  private static TextView a(View paramView, int paramInt)
	  {
		TextView textView = null;
		if (paramInt == 0)
		{
		  try
		  {
			if (paramView is TextView)
			{
			  return (TextView)paramView;
			}
			if (paramInt != 0)
			{
			  textView = (TextView)paramView.findViewById(paramInt);
			}
			return textView;
		  }
		  catch (System.InvalidCastException classCastException)
		  {
			Log.e("AbstractWheelAdapter", "You must supply a resource ID for a TextView");
			throw new System.InvalidOperationException("AbstractWheelAdapter requires the resource ID to be a TextView", classCastException);
		  }
		}
		if (paramInt != 0)
		{
		  textView = (TextView)classCastException.findViewById(paramInt);
		}
		return textView;
	  }

	  protected internal virtual void configureTextView(int paramInt, TextView paramTextView)
	  {
		if (paramInt < this.minDisabledItemsBorder || this.maxDisabledItemsBorder < paramInt)
		{
		  paramInt = -7829368;
		}
		else
		{
		  paramInt = this.a_Conflict;
		}
		paramTextView.setTextColor(paramInt);
		paramTextView.setGravity(17);
		paramTextView.setTextSize(this.b);
		paramTextView.setLines(1);
		paramTextView.setTypeface(Typeface.SANS_SERIF, 1);
	  }

	  public override View getEmptyItem(View paramView, ViewGroup paramViewGroup)
	  {
		if (paramView == null)
		{
		  paramView = a(this.emptyItemResourceId, paramViewGroup);
		}
		if (this.emptyItemResourceId == -1 && paramView is TextView)
		{
		  configureTextView(this.minDisabledItemsBorder, (TextView)paramView);
		}
		return paramView;
	  }

	  public virtual int EmptyItemResource
	  {
		  get
		  {
			return this.emptyItemResourceId;
		  }
		  set
		  {
			this.emptyItemResourceId = value;
		  }
	  }

	  public override View getItem(int paramInt, View paramView, ViewGroup paramViewGroup)
	  {
		if (paramInt >= 0 && paramInt < ItemsCount)
		{
		  View view1;
		  View view2 = paramView;
		  if (paramView == null)
		  {
			view2 = a(this.itemResourceId, paramViewGroup);
		  }
		  TextView textView = a(view2, this.itemTextResourceId);
		  paramView = view2;
		  if (textView != null)
		  {
			CharSequence charSequence2 = getItemText(paramInt);
			CharSequence charSequence1 = charSequence2;
			if (charSequence2 == null)
			{
			  charSequence1 = "";
			}
			textView.setText(charSequence1);
			view1 = view2;
			if (this.itemResourceId == -1)
			{
			  configureTextView(paramInt, textView);
			  view1 = view2;
			}
		  }
		  return view1;
		}
		return null;
	  }

	  public virtual int ItemResource
	  {
		  get
		  {
			return this.itemResourceId;
		  }
		  set
		  {
			this.itemResourceId = value;
		  }
	  }

	  protected internal abstract CharSequence getItemText(int paramInt);

	  public virtual int ItemTextResource
	  {
		  get
		  {
			return this.itemTextResourceId;
		  }
		  set
		  {
			this.itemTextResourceId = value;
		  }
	  }

	  public virtual int TextColor
	  {
		  get
		  {
			return this.a_Conflict;
		  }
		  set
		  {
			this.a_Conflict = value;
		  }
	  }

	  public virtual int TextSize
	  {
		  get
		  {
			return this.b;
		  }
		  set
		  {
			this.b = value;
		  }
	  }




	  public virtual int MaxDisabledItemsBorder
	  {
		  set
		  {
			this.maxDisabledItemsBorder = value;
		  }
	  }

	  public virtual int MinDisabledItemsBorder
	  {
		  set
		  {
			this.minDisabledItemsBorder = value;
		  }
	  }


	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\AbstractWheelTextAdapter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}