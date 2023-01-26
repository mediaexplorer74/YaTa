namespace ru.yandex.yandexmapkit
{
	using Context = android.content.Context;
	using AttributeSet = android.util.AttributeSet;
	using Log = android.util.Log;
	using View = android.view.View;
	using RelativeLayout = android.widget.RelativeLayout;
	using t;
	using w;
	using z;

	public class MapView : RelativeLayout
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly View a_Conflict;

	  private z b;

	  private readonly string c;

	  private View d;

	  public MapView(Context paramContext, AttributeSet paramAttributeSet) : base(paramContext, paramAttributeSet)
	  {
		this.c = paramAttributeSet.getAttributeValue("http://schemas.android.com/apk/res/android", "apiKey");
		Log.d("mw", "apiKey=" + this.c);
		string str = (string)getTag();
		if (!string.ReferenceEquals(str, null) && str.Equals("static"))
		{
		  this.a_Conflict = (View)new t(paramContext, paramAttributeSet, this);
		}
		else
		{
		  this.a_Conflict = (View)new w(paramContext, paramAttributeSet, this);
		}
		addView(this.a_Conflict);
		this.b = (z)this.a_Conflict;
	  }

	  public virtual string a()
	  {
		return this.c;
	  }

	  public virtual MapController MapController
	  {
		  get
		  {
			return this.b.a();
		  }
	  }

	  public virtual void showBuiltInScreenButtons(bool paramBoolean)
	  {
		if (paramBoolean)
		{
		  if (this.d == null)
		  {
			this.d = this.b.a().a();
		  }
		  this.d.setVisibility(0);
		  return;
		}
		this.d.setVisibility(4);
	  }

	  public virtual void showFindMeButton(bool paramBoolean)
	  {
		if (this.d == null)
		{
		  this.d = this.b.a().a();
		}
		this.b.a().a(paramBoolean);
	  }

	  public virtual void showJamsButton(bool paramBoolean)
	  {
		if (this.d == null)
		{
		  this.d = this.b.a().a();
		}
		this.b.a().b(paramBoolean);
	  }

	  public virtual void showZoomButtons(bool paramBoolean)
	  {
		if (this.d == null)
		{
		  this.d = this.b.a().a();
		}
		this.b.a().c(paramBoolean);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\MapView.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}