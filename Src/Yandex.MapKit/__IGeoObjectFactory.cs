// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__IGeoObjectFactory
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
  [Guid(552212576, 47695, 15780, 184, 88, 241, 174, 55, 50, 84, 149)]
  [ExclusiveTo(typeof (GeoObject))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IGeoObjectFactory
  {
    [Overload("CreateInstance1")]
    GeoObject CreateInstance(
      [In] string name,
      [In] string descriptionText,
      [In] IVectorView<global::Yandex.MapKit.Geometry.Geometry> geometry,
      [In] BoundingBox boundingBox,
      [In] IMapView<string, Attribution> attributionMap,
      [In] AnyCollection metadataContainer,
      [In] IVectorView<string> aref);
  }
}
