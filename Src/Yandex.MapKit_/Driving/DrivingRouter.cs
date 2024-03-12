// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.DrivingRouter
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2882085736, 35228, 15917, 188, 160, 30, 79, 41, 173, 96, 157)]
  public interface DrivingRouter
  {
    Session RequestRoutes(
      [In] IVectorView<RequestPoint> points,
      [In] DrivingOptions drivingOptions,
      [In] OnDrivingRoutes onDrivingRoutes,
      [In] OnDrivingRoutesError onDrivingRoutesError);

    SummarySession RequestRoutesSummary(
      [In] IVectorView<RequestPoint> points,
      [In] DrivingOptions drivingOptions,
      [In] OnDrivingSummaries onDrivingSummaries,
      [In] OnDrivingSummariesError onDrivingSummariesError);

    Session RequestAlternativesForRoute(
      [In] Route route,
      [In] PolylinePosition routePosition,
      [In] DrivingOptions drivingOptions,
      [In] OnDrivingRoutes onDrivingRoutes,
      [In] OnDrivingRoutesError onDrivingRoutesError);

    Session RequestParkingRoutes(
      [In] Point location,
      [In] Point finish,
      [In] DrivingOptions drivingOptions,
      [In] OnDrivingRoutes onDrivingRoutes,
      [In] OnDrivingRoutesError onDrivingRoutesError);

    global::Yandex.MapKit.Driving.RouteSerializer RouteSerializer();

    void Suspend();

    void Resume();
  }
}
