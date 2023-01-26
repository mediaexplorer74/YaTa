namespace ru.yandex.yandexmapkit.overlay.balloon
{
	using MotionEvent = android.view.MotionEvent;

	public interface OnBalloonListener
	{
	  void onBalloonClick(MotionEvent paramMotionEvent, BalloonItem paramBalloonItem);

	  void onBalloonHide(BalloonItem paramBalloonItem);

	  void onBalloonShow(BalloonItem paramBalloonItem);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\balloon\OnBalloonListener.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}