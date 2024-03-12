// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1255531222, 61068, 15286, 171, 170, 208, 179, 218, 51, 213, 56)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (BusinessObjectMetadata))]
  internal interface __IBusinessObjectMetadataPublicNonVirtuals
  {
    string Oid { get; }

    string Name { get; }

    Address Address { get; }

    IVectorView<Category> Categories { get; }

    Advertisement Advertisement { get; }

    IVectorView<Phone> Phones { get; }

    WorkingHours WorkingHours { get; }

    IReference<global::Yandex.MapKit.Search.Precision> Precision { get; }

    IVectorView<Feature> Features { get; }

    IVectorView<uint> Snippet { get; }

    IVectorView<SearchLink> Links { get; }

    LocalizedValue Distance { get; }

    IVectorView<Chain> Chains { get; }

    IReference<global::Yandex.MapKit.Search.Closed> Closed { get; }

    IReference<bool> Unreliable { get; }

    string Seoname { get; }
  }
}
