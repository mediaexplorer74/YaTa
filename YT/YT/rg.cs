using CoreApplicationParams = ru.yandex.core.CoreApplicationParams;

internal class rg : CoreApplicationParams
{
  public override int GestureDispatcherConfig
  {
	  get
	  {
		return 0;
	  }
  }

  public override int HashResourceID
  {
	  get
	  {
		return 0;
	  }
  }

  public override string NativeLibraryName
  {
	  get
	  {
		return "cache";
	  }
  }

  public override bool shouldResourcesBeOnPhoneMemory()
  {
	return true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\rg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */