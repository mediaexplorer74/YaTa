// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISearchMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Direct;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (SearchMetadata))]
  [Version(1)]
  [Guid(844410581, 28566, 15263, 153, 66, 3, 146, 78, 60, 120, 56)]
  [WebHostHidden]
  internal interface __ISearchMetadataPublicNonVirtuals
  {
    int Found { get; }

    DisplayType DisplayType { get; }

    BoundingBox BoundingBox { get; }

    Sort Sort { get; }

    GeoObject Toponym { get; }

    ToponymResultMetadata ToponymResultMetadata { get; }

    BusinessResultMetadata BusinessResultMetadata { get; }

    string Reqid { get; }

    IVectorView<Banner> Banners { get; }

    string Context { get; }

    string RequestText { get; }
  }
}
