// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IGeoObjectCollectionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit
{
  [Guid(2991969796, 44231, 14530, 168, 225, 230, 109, 217, 133, 254, 5)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GeoObjectCollection))]
  [Version(1)]
  internal interface __IGeoObjectCollectionFactory
  {
    [Overload("CreateInstance1")]
    GeoObjectCollection CreateInstance(
      [In] BoundingBox boundingBox,
      [In] AnyCollection metadataContainer,
      [In] IVectorView<GeoObjectCollectionItem> children);
  }
}
