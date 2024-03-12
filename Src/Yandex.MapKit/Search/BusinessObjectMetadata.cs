// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessObjectMetadata
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
  [Static(typeof (__IBusinessObjectMetadataStatics), 1)]
  [WebHostHidden]
  [Activatable(typeof (__IBusinessObjectMetadataFactory), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [Threading]
  public sealed class BusinessObjectMetadata : __IBusinessObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BusinessObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessObjectMetadata(
      [In] string oid,
      [In] string name,
      [In] Address address,
      [In] IVectorView<Category> categories,
      [In] Advertisement advertisement,
      [In] IVectorView<Phone> phones,
      [In] WorkingHours workingHours,
      [In] IReference<global::Yandex.MapKit.Search.Precision> precision,
      [In] IVectorView<Feature> features,
      [In] IVectorView<uint> snippet,
      [In] IVectorView<SearchLink> links,
      [In] LocalizedValue distance,
      [In] IVectorView<Chain> chains,
      [In] IReference<global::Yandex.MapKit.Search.Closed> closed,
      [In] IReference<bool> unreliable,
      [In] string seoname);

    public extern string Oid { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Address Address { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Category> Categories { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Advertisement Advertisement { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Phone> Phones { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern WorkingHours WorkingHours { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<global::Yandex.MapKit.Search.Precision> Precision { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Feature> Features { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<uint> Snippet { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<SearchLink> Links { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Chain> Chains { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<global::Yandex.MapKit.Search.Closed> Closed { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<bool> Unreliable { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Seoname { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
