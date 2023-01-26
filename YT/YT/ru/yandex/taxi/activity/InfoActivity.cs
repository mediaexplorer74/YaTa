namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Bundle = android.os.Bundle;
	using hl;
	using hm;

	public class InfoActivity : Activity
	{
	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		// Byte code:
		//   0: aload_0
		//   1: aload_1
		//   2: invokespecial onCreate : (Landroid/os/Bundle;)V
		//   5: aload_0
		//   6: ldc 2130903047
		//   8: invokevirtual setContentView : (I)V
		//   11: aload_0
		//   12: invokevirtual getWindow : ()Landroid/view/Window;
		//   15: iconst_1
		//   16: invokevirtual setFormat : (I)V
		//   19: aload_0
		//   20: invokevirtual getResources : ()Landroid/content/res/Resources;
		//   23: astore_2
		//   24: new ru/yandex/taxi/client/TaxiClient
		//   27: dup
		//   28: aload_0
		//   29: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   32: new ru/yandex/taxi/client/HttpUrlConnectionUtils
		//   35: dup
		//   36: invokespecial <init> : ()V
		//   39: invokespecial <init> : (Landroid/content/Context;Lru/yandex/taxi/client/HttpUtils;)V
		//   42: pop
		//   43: aload_0
		//   44: ldc 2131558438
		//   46: invokevirtual findViewById : (I)Landroid/view/View;
		//   49: checkcast android/widget/TextView
		//   52: aload_2
		//   53: ldc 2131296474
		//   55: invokevirtual getString : (I)Ljava/lang/String;
		//   58: iconst_1
		//   59: anewarray java/lang/Object
		//   62: dup
		//   63: iconst_0
		//   64: ldc '340'
		//   66: aastore
		//   67: invokestatic format : (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
		//   70: invokevirtual setText : (Ljava/lang/CharSequence;)V
		//   73: new java/text/SimpleDateFormat
		//   76: dup
		//   77: ldc 'd MMMM yyyy'
		//   79: invokespecial <init> : (Ljava/lang/String;)V
		//   82: new java/util/Date
		//   85: dup
		//   86: aload_2
		//   87: ldc 2131296256
		//   89: invokevirtual getString : (I)Ljava/lang/String;
		//   92: invokestatic valueOf : (Ljava/lang/String;)Ljava/lang/Long;
		//   95: invokevirtual longValue : ()J
		//   98: invokespecial <init> : (J)V
		//   101: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   104: astore_3
		//   105: aload_0
		//   106: invokevirtual getApplication : ()Landroid/app/Application;
		//   109: pop
		//   110: aload_2
		//   111: ldc 2131296475
		//   113: invokevirtual getString : (I)Ljava/lang/String;
		//   116: astore #4
		//   118: aload_0
		//   119: invokevirtual getPackageManager : ()Landroid/content/pm/PackageManager;
		//   122: aload_0
		//   123: invokevirtual getPackageName : ()Ljava/lang/String;
		//   126: iconst_0
		//   127: invokevirtual getPackageInfo : (Ljava/lang/String;I)Landroid/content/pm/PackageInfo;
		//   130: getfield versionName : Ljava/lang/String;
		//   133: astore_1
		//   134: aload_0
		//   135: ldc 2131558437
		//   137: invokevirtual findViewById : (I)Landroid/view/View;
		//   140: checkcast android/widget/TextView
		//   143: aload #4
		//   145: iconst_2
		//   146: anewarray java/lang/Object
		//   149: dup
		//   150: iconst_0
		//   151: aload_1
		//   152: aastore
		//   153: dup
		//   154: iconst_1
		//   155: aload_3
		//   156: aastore
		//   157: invokestatic format : (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
		//   160: invokevirtual setText : (Ljava/lang/CharSequence;)V
		//   163: aload_0
		//   164: ldc 2131558440
		//   166: invokevirtual findViewById : (I)Landroid/view/View;
		//   169: new hi
		//   172: dup
		//   173: aload_0
		//   174: aload_2
		//   175: invokespecial <init> : (Lru/yandex/taxi/activity/InfoActivity;Landroid/content/res/Resources;)V
		//   178: invokevirtual setOnClickListener : (Landroid/view/View$OnClickListener;)V
		//   181: aload_0
		//   182: ldc 2131558439
		//   184: invokevirtual findViewById : (I)Landroid/view/View;
		//   187: new hj
		//   190: dup
		//   191: aload_0
		//   192: aload_2
		//   193: invokespecial <init> : (Lru/yandex/taxi/activity/InfoActivity;Landroid/content/res/Resources;)V
		//   196: invokevirtual setOnClickListener : (Landroid/view/View$OnClickListener;)V
		//   199: aload_0
		//   200: ldc 2131558434
		//   202: invokevirtual findViewById : (I)Landroid/view/View;
		//   205: checkcast android/widget/Button
		//   208: astore_1
		//   209: aload_0
		//   210: invokestatic isVideoCompatible : (Landroid/app/Activity;)Z
		//   213: ifeq -> 245
		//   216: aload_1
		//   217: new hk
		//   220: dup
		//   221: aload_0
		//   222: invokespecial <init> : (Lru/yandex/taxi/activity/InfoActivity;)V
		//   225: invokevirtual setOnClickListener : (Landroid/view/View$OnClickListener;)V
		//   228: return
		//   229: astore_1
		//   230: ldc 'InfoActivity'
		//   232: ldc 'Fail get version number'
		//   234: aload_1
		//   235: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
		//   238: pop
		//   239: ldc '1.0'
		//   241: astore_1
		//   242: goto -> 134
		//   245: aload_1
		//   246: bipush #8
		//   248: invokevirtual setVisibility : (I)V
		//   251: goto -> 228
		// Exception table:
		//   from	to	target	type
		//   118	134	229	android/content/pm/PackageManager$NameNotFoundException
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		Dialog dialog = null;
		switch (paramInt)
		{
		  default:
			return dialog;
		  case 1:
			break;
		}
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)this);
		builder.setTitle(2131296457).setMessage(2131296487).setPositiveButton(2131296459, (DialogInterface.OnClickListener)new hm(this)).setNegativeButton(2131296279, (DialogInterface.OnClickListener)new hl(this));
		AlertDialog alertDialog = builder.create();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\InfoActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}