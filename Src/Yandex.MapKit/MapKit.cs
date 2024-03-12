// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.MapKit
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;
using Yandex.MapKit.Experiments;
using Yandex.MapKit.Geometry;
using Yandex.MapKit.Guidance;
using Yandex.MapKit.Location;
using Yandex.MapKit.Map;
using Yandex.MapKit.Masstransit;
using Yandex.MapKit.OfflineCache;
using Yandex.MapKit.Panorama;
using Yandex.MapKit.Photos;
using Yandex.MapKit.Reviews;
using Yandex.MapKit.RoadEvents;
using Yandex.MapKit.Search;
using Yandex.MapKit.Suggest;
using Yandex.MapKit.Taxi;
using Yandex.MapKit.Time;
using Yandex.Runtime;
using Yandex.Runtime.Auth;
using Yandex.Runtime.Init;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Guid(3348502497, 42141, 13790, 162, 172, 234, 110, 174, 74, 145, 200)]
  [global::Windows.Foundation.Metadata.Version(1)]
  public interface MapKit
  {
    void Initialize([In] string uuid, [In] string deviceId);

    void SetAccount([In] Account account);

    void OnResume();

    void OnPause();

    MiidManager MiidManager { get; }

    AdjustedClock AdjustedClock { get; }

    global::Yandex.MapKit.Coverage.Coverage CreateCoverage([In] string coverageId);

    UiExperimentsManager UiExperimentsManager { get; }

    LocationManager CreateLocationManager();

    LocationSimulator CreateLocationSimulator([In] Polyline geometry);

    Guide CreateGuide();

    RecordedSimulator CreateRecordedSimulator([In] Report report);

    ReportFactory CreateReportFactory();

    MasstransitInfoService CreateMasstransitInfoService();

    MapWindow CreateMapWindow([In] PlatformView platformView);

    OfflineCacheManager OfflineCacheManager { get; }

    PanoramaService CreatePanoramaService();

    Player CreatePanoramaPlayer([In] PlatformView platformView);

    PhotosManager CreatePhotosManager();

    ReviewsManager CreateReviewsManager();

    RoadEventsManager CreateRoadEventsManager();

    DrivingRouter CreateDrivingRouter();

    MasstransitRouter CreateMasstransitRouter();

    PedestrianRouter CreatePedestrianRouter();

    SearchManager CreateSearchManager([In] SearchManagerType searchManagerType);

    HistoryManager CreateHistoryManager([In] int maxItemsCount);

    TaxiManager CreateTaxiManager();

    string Version { get; }

    bool Valid { get; }
  }
}
