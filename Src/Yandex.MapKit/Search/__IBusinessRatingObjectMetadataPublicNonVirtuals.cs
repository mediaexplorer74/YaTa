// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessRatingObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (BusinessRatingObjectMetadata))]
  [WebHostHidden]
  [Version(1)]
  [Guid(628371946, 39648, 16251, 164, 96, 221, 76, 253, 12, 9, 147)]
  internal interface __IBusinessRatingObjectMetadataPublicNonVirtuals
  {
    uint Ratings { get; }

    uint Reviews { get; }

    IReference<float> Score { get; }

    IVectorView<Facet> Facets { get; }
  }
}
