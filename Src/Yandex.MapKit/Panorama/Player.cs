// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Panorama.Player
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Panorama
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3829628287, 1279, 15356, 156, 193, 63, 40, 253, 126, 174, 155)]
  public interface Player
  {
    void OpenPanorama([In] string panoramaId);

    string PanoramaId();

    Point Position();

    void LookAt([In] Point position);

    global::Yandex.MapKit.Geometry.Direction Direction();

    void SetDirection([In] global::Yandex.MapKit.Geometry.Direction direction);

    global::Yandex.MapKit.Geometry.Span Span();

    void SetSpan([In] global::Yandex.MapKit.Geometry.Span span);

    void Reset();

    void EnableZoom();

    void DisableZoom();

    bool ZoomEnabled();

    void EnableMove();

    void DisableMove();

    bool MoveEnabled();

    void EnableRotation();

    void DisableRotation();

    bool RotationEnabled();

    void EnableMarkers();

    void DisableMarkers();

    bool MarkersEnabled();

    void AddPanoramaChangeListener([In] PanoramaChangeListener panoramaChangeListener);

    void RemovePanoramaChangeListener([In] PanoramaChangeListener panoramaChangeListener);

    void AddDirectionChangeListener([In] DirectionChangeListener directionChangeListener);

    void RemoveDirectionChangeListener([In] DirectionChangeListener directionChangeListener);

    void AddSpanChangeListener([In] SpanChangeListener spanChangeListener);

    void RemoveSpanChangeListener([In] SpanChangeListener spanChangeListener);

    void AddErrorListener([In] ErrorListener errorListener);

    void RemoveErrorListener([In] ErrorListener errorListener);

    void EnableLoadingWheel();

    void DisableLoadingWheel();

    bool LoadingWheelEnabled();

    bool Valid { get; }
  }
}
