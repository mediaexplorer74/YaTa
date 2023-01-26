using System.Runtime.InteropServices;

namespace ru.yandex.core
{
	public class RemovableFsManager
	{
//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern boolean getIsMountedToRealSdcard();

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern void remount();
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\RemovableFsManager.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}