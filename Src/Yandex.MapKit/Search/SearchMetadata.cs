// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.SearchMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Direct;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [WebHostHidden]
  [Static(typeof (__ISearchMetadataStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  [Activatable(typeof (__ISearchMetadataFactory), 1)]
  public sealed class SearchMetadata : __ISearchMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SearchMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SearchMetadata(
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

    public extern int Found { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DisplayType DisplayType { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern BoundingBox BoundingBox { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Sort Sort { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern GeoObject Toponym { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ToponymResultMetadata ToponymResultMetadata { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern BusinessResultMetadata BusinessResultMetadata { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Reqid { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Banner> Banners { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Context { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string RequestText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
