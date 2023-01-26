using System.Threading;

namespace ru.yandex.taxi.activity
{
	using BroadcastReceiver = android.content.BroadcastReceiver;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using Bundle = android.os.Bundle;
	using SmsMessage = android.telephony.gsm.SmsMessage;
	using go;

	public class ConfirmActivity$SmsReceiver : BroadcastReceiver
	{
	  private ConfirmActivity$SmsReceiver(ConfirmActivity paramConfirmActivity, sbyte paramByte)
	  {
	  }

	  public virtual void onReceive(Context paramContext, Intent paramIntent)
	  {
		Bundle bundle = paramIntent.getExtras();
		if (bundle != null)
		{
		  object[] arrayOfObject = (object[])bundle.get("pdus");
		  for (sbyte b = 0;; b++)
		  {
			if (b < arrayOfObject.Length)
			{
			  SmsMessage smsMessage = SmsMessage.createFromPdu((sbyte[])arrayOfObject[b]);
			  if ("Yandex".Equals(smsMessage.getOriginatingAddress()))
			  {
				string str = smsMessage.getMessageBody().ToString();
				this.a.runOnUiThread((ThreadStart)new go(this, str));
				return;
			  }
			}
			else
			{
			  return;
			}
		  }
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\ConfirmActivity$SmsReceiver.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}