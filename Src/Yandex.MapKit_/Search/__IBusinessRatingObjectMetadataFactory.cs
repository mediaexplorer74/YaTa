// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessRatingObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (BusinessRatingObjectMetadata))]
  [Guid(1718851157, 26025, 12571, 138, 149, 243, 10, 73, 207, 25, 35)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IBusinessRatingObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    BusinessRatingObjectMetadata CreateInstance(
      [In] uint ratings,
      [In] uint reviews,
      [In] IReference<float> score,
      [In] IVectorView<Facet> facets);
  }
}
