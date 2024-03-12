// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.GuidanceListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Version(1)]
  [Guid(4256760209, 51194, 14125, 147, 53, 71, 134, 2, 178, 136, 220)]
  [WebHostHidden]
  public interface GuidanceListener
  {
    void OnLocationUpdated();

    void OnRoutePositionUpdated();

    void OnAnnotationsUpdated();

    void OnRoadNameUpdated();

    void OnFinishedRoute();

    void OnLostRoute();

    void OnReturnedToRoute();

    void OnRouteUpdated();

    void OnSpeedLimitUpdated();

    void OnSpeedLimitExceededUpdated();

    void OnSpeedLimitExceeded();

    void OnLaneSignUpdated();

    void OnFasterAlternativeUpdated();

    void OnParkingRouteAvailableUpdated();

    void OnGpsSpoofedUpdated();
  }
}
