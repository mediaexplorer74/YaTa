// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.GeoObject
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__IGeoObjectFactory), 1)]
  [Static(typeof (__IGeoObjectStatics), 1)]
  [Version(1)]
  [MarshalingBehavior]
  public sealed class GeoObject : __IGeoObjectPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GeoObject From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern GeoObject(
      [In] string name,
      [In] string descriptionText,
      [In] IVectorView<global::Yandex.MapKit.Geometry.Geometry> geometry,
      [In] BoundingBox boundingBox,
      [In] IMapView<string, Attribution> attributionMap,
      [In] AnyCollection metadataContainer,
      [In] IVectorView<string> aref);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DescriptionText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<global::Yandex.MapKit.Geometry.Geometry> Geometry { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern BoundingBox BoundingBox { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IMapView<string, Attribution> AttributionMap { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern AnyCollection MetadataContainer { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<string> Aref { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
