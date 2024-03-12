// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.Guide
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;
using Yandex.MapKit.Geometry;
using Yandex.MapKit.Location;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Guid(3836383856, 28305, 14590, 159, 243, 176, 136, 214, 191, 112, 123)]
  [Version(1)]
  public interface Guide
  {
    void Subscribe([In] GuidanceListener guidanceListener);

    void Unsubscribe([In] GuidanceListener guidanceListener);

    void SetLocationManager([In] LocationManager locationManager);

    void SetSpeaker([In] Speaker speaker);

    void Suspend();

    void Resume();

    void Mute();

    void Unmute();

    void SetRoute([In] Route route);

    void ResetRoute();

    void EnableAnnotations();

    void EnableZoom();

    void SetReroutingEnabled([In] bool on);

    void SetFasterAlternativeEnabled([In] bool on);

    void SetParkingRoutesEnabled([In] bool on);

    void SetRouteActionsAnnotated([In] bool on);

    void SetRoadEventsAnnotated([In] bool on);

    void SetRoadEventTypeAnnotated([In] EventType type, [In] bool on);

    void SetSpeedLimitExceededAnnotated([In] bool on);

    void SetBackgroundModeEnabled([In] bool on);

    Route Route { get; }

    PolylinePosition RoutePosition { get; }

    ClassifiedLocation Location { get; }

    DisplayedAnnotations DisplayedAnnotations { get; }

    SpeedingPolicy SpeedingPolicy { get; }

    LocalizedValue SpeedLimit { get; }

    bool SpeedLimitExceeded { get; }

    ViewArea ViewArea { get; }

    string RoadName { get; }

    FasterAlternative FasterAlternative { get; }

    bool SnapToRoadsEnabled { get; [param: In] set; }

    bool ParkingRouteAvailable { get; }

    bool GpsSpoofed { get; }
  }
}
