// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IGeometryPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [ExclusiveTo(typeof (global::Yandex.MapKit.Geometry.Geometry))]
  [Guid(1421665406, 61529, 13397, 175, 209, 60, 217, 13, 53, 99, 122)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IGeometryPublicNonVirtuals
  {
    Point Point { get; }

    Polyline Polyline { get; }

    Polygon Polygon { get; }

    BoundingBox BoundingBox { get; }

    Circle Circle { get; }
  }
}
