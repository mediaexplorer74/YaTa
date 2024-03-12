// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.LocationManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [WebHostHidden]
  [Guid(1552956603, 45514, 15895, 141, 187, 194, 168, 140, 176, 46, 21)]
  [Version(1)]
  public interface LocationManager
  {
    void SubscribeForLocationUpdates(
      [In] double desiredAccuracy,
      [In] long minTime,
      [In] double minDistance,
      [In] bool allowUseInBackground,
      [In] LocationListener locationListener);

    void RequestSingleUpdate([In] LocationListener locationListener);

    void Unsubscribe([In] LocationListener locationListener);

    void Suspend();

    void Resume();
  }
}
