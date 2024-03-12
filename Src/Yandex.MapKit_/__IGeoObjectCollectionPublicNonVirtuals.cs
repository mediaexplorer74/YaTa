// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IGeoObjectCollectionPublicNonVirtuals
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
  [WebHostHidden]
  [Guid(3171292304, 26591, 15463, 131, 138, 120, 253, 89, 133, 180, 106)]
  [Version(1)]
  [ExclusiveTo(typeof (GeoObjectCollection))]
  internal interface __IGeoObjectCollectionPublicNonVirtuals
  {
    BoundingBox BoundingBox { get; }

    AnyCollection MetadataContainer { get; }

    IVectorView<GeoObjectCollectionItem> Children { get; }
  }
}
