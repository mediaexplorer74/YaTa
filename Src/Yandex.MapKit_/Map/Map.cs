// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.Map
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Carparks;
using Yandex.MapKit.Geometry;
using Yandex.MapKit.Geometry.Geo;
using Yandex.MapKit.Glyphs;
using Yandex.MapKit.Layers;
using Yandex.MapKit.Masstransit;
using Yandex.MapKit.Tiles;
using Yandex.MapKit.Traffic;
using Yandex.MapKit.UserLocation;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(2524428931, 54255, 15642, 132, 52, 14, 217, 234, 175, 254, 142)]
  [WebHostHidden]
  [Version(1)]
  public interface Map
  {
    CameraPosition CameraPosition { get; }

    CameraPosition GetCameraPosition([In] BoundingBox boundingBox);

    VisibleRegion VisibleRegion { get; }

    VisibleRegion GetVisibleRegion([In] CameraPosition cameraPosition);

    void Move(
      [In] CameraPosition cameraPosition,
      [In] Animation animationType,
      [In] OnMoveFinished onMoveFinished);

    float GetMinZoom();

    float GetMaxZoom();

    [Overload("AddLayer1")]
    Layer AddLayer(
      [In] string layerId,
      [In] string contentType,
      [In] LayerOptions layerOptions,
      [In] UrlProvider tilesUrlProvider,
      [In] global::Yandex.MapKit.ResourceUrlProvider.ResourceUrlProvider imageUrlProvider,
      [In] global::Yandex.MapKit.ResourceUrlProvider.ResourceUrlProvider modelUrlProvider,
      [In] GlyphUrlProvider glyphUrlProvider,
      [In] Projection projection);

    [DefaultOverload]
    [Overload("AddLayer2")]
    Layer AddLayer(
      [In] string layerId,
      [In] string contentType,
      [In] LayerOptions layerOptions,
      [In] UrlProvider urlProvider,
      [In] global::Yandex.MapKit.ResourceUrlProvider.ResourceUrlProvider imageUrlProvider,
      [In] Projection projection);

    [Overload("AddLayer3")]
    Layer AddLayer(
      [In] string layerId,
      [In] string contentType,
      [In] LayerOptions layerOptions,
      [In] TileProvider tileProvider,
      [In] global::Yandex.MapKit.ResourceUrlProvider.ResourceUrlProvider imageUrlProvider,
      [In] Projection projection);

    MasstransitLayer MasstransitLayer { get; }

    TrafficLayer TrafficLayer { get; }

    CarparksLayer CarparksLayer { get; }

    CarparksLayer CarparksEventsLayer { get; }

    global::Yandex.MapKit.SearchLayer.SearchLayer SearchLayer { get; }

    bool NightModeEnabled { get; [param: In] set; }

    bool ZoomGesturesEnabled { get; [param: In] set; }

    bool ScrollGesturesEnabled { get; [param: In] set; }

    bool TiltGesturesEnabled { get; [param: In] set; }

    bool RotateGesturesEnabled { get; [param: In] set; }

    MapType MapType { get; [param: In] set; }

    void AddInputListener([In] InputListener inputListener);

    void RemoveInputListener([In] InputListener inputListener);

    void AddCameraListener([In] CameraListener cameraListener);

    void RemoveCameraListener([In] CameraListener cameraListener);

    MapObjectCollection MapObjects { get; }

    void AddTapListener([In] GeoObjectTapListener tapListener);

    void RemoveTapListener([In] GeoObjectTapListener tapListener);

    void DeselectAll();

    UserLocationLayer UserLocationLayer { get; }

    bool Valid { get; }
  }
}
