﻿using Intent = android.content.Intent;
using Resources = android.content.res.Resources;
using Uri = android.net.Uri;
using View = android.view.View;
using InfoActivity = ru.yandex.taxi.activity.InfoActivity;

public class hi : View.OnClickListener
{
  public hi(InfoActivity paramInfoActivity, Resources paramResources)
  {
  }

  public virtual void onClick(View paramView)
  {
	Intent intent = (new Intent("android.intent.action.VIEW", Uri.parse(this.a.getString(2131296262)))).addCategory("android.intent.category.BROWSABLE");
	this.b.startActivity(intent);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */