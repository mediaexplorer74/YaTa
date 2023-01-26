using System;

internal sealed class ae : FilenameFilter
{
  internal ae(string paramString)
  {
  }

  public bool accept(File paramFile, string paramString)
  {
	return paramString.EndsWith(this.a, StringComparison.Ordinal);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ae.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */