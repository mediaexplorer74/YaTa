// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISearchMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Direct;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [ExclusiveTo(typeof (SearchMetadata))]
  [WebHostHidden]
  [Guid(3348067051, 54145, 16296, 144, 68, 100, 49, 205, 94, 114, 3)]
  internal interface __ISearchMetadataFactory
  {
    [Overload("CreateInstance1")]
    SearchMetadata CreateInstance(
      [In] int found,
      [In] DisplayType displayType,
      [In] BoundingBox boundingBox,
      [In] Sort sort,
      [In] GeoObject toponym,
      [In] ToponymResultMetadata toponymResultMetadata,
      [In] BusinessResultMetadata businessResultMetadata,
      [In] string reqid,
      [In] IVectorView<Banner> banners,
      [In] string context,
      [In] string requestText);
  }
}
