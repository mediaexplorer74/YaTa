// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessRatingObjectMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Activatable(typeof (__IBusinessRatingObjectMetadataFactory), 1)]
  [Static(typeof (__IBusinessRatingObjectMetadataStatics), 1)]
  [Threading]
  public sealed class BusinessRatingObjectMetadata : __IBusinessRatingObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BusinessRatingObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessRatingObjectMetadata(
      [In] uint ratings,
      [In] uint reviews,
      [In] IReference<float> score,
      [In] IVectorView<Facet> facets);

    public extern uint Ratings { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Reviews { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> Score { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Facet> Facets { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
