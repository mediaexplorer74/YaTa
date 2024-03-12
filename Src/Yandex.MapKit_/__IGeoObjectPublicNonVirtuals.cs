// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IGeoObjectPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [ExclusiveTo(typeof (GeoObject))]
  [Guid(3445039379, 20651, 13146, 166, 143, 195, 115, 163, 207, 46, 141)]
  [WebHostHidden]
  internal interface __IGeoObjectPublicNonVirtuals
  {
    string Name { get; }

    string DescriptionText { get; }

    IVectorView<global::Yandex.MapKit.Geometry.Geometry> Geometry { get; }

    BoundingBox BoundingBox { get; }

    IMapView<string, Attribution> AttributionMap { get; }

    AnyCollection MetadataContainer { get; }

    IVectorView<string> Aref { get; }
  }
}
