// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.GeoObjectCollection
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
  [MarshalingBehavior]
  [Static(typeof (__IGeoObjectCollectionStatics), 1)]
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__IGeoObjectCollectionFactory), 1)]
  [Version(1)]
  public sealed class GeoObjectCollection : __IGeoObjectCollectionPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GeoObjectCollection From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern GeoObjectCollection(
      [In] BoundingBox boundingBox,
      [In] AnyCollection metadataContainer,
      [In] IVectorView<GeoObjectCollectionItem> children);

    public extern BoundingBox BoundingBox { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern AnyCollection MetadataContainer { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<GeoObjectCollectionItem> Children { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
