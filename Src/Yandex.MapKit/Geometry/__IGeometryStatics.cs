// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IGeometryStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Guid(54316425, 17946, 16274, 176, 6, 78, 49, 240, 133, 136, 60)]
  [Version(1)]
  [ExclusiveTo(typeof (global::Yandex.MapKit.Geometry.Geometry))]
  [WebHostHidden]
  internal interface __IGeometryStatics
  {
    global::Yandex.MapKit.Geometry.Geometry FromPoint([In] Point point);

    global::Yandex.MapKit.Geometry.Geometry FromPolyline([In] Polyline polyline);

    global::Yandex.MapKit.Geometry.Geometry FromPolygon([In] Polygon polygon);

    global::Yandex.MapKit.Geometry.Geometry FromBoundingBox([In] BoundingBox boundingBox);

    global::Yandex.MapKit.Geometry.Geometry FromCircle([In] Circle circle);
  }
}
