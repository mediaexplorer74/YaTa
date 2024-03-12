// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessResultMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Static(typeof (__IBusinessResultMetadataStatics), 1)]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IBusinessResultMetadataFactory), 1)]
  [WebHostHidden]
  public sealed class BusinessResultMetadata : __IBusinessResultMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BusinessResultMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessResultMetadata(
      [In] IVectorView<Category> categories,
      [In] IVectorView<BusinessFilter> businessFilters);

    public extern IVectorView<Category> Categories { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<BusinessFilter> BusinessFilters { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
