namespace ru.yandex.yandexmapkit.net
{
	public interface DownloadHandler
	{
	  DownloadJob onCreateDownloadJob(int paramInt);

	  bool onFinishDownload(DownloadJob paramDownloadJob, bool paramBoolean);

	  void onStartDownload(int paramInt);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\net\DownloadHandler.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}