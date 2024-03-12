// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessObjectMetadataFactory
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
  [Guid(3278844495, 28448, 15046, 190, 180, 111, 102, 233, 185, 125, 243)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BusinessObjectMetadata))]
  internal interface __IBusinessObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    BusinessObjectMetadata CreateInstance(
      [In] string oid,
      [In] string name,
      [In] Address address,
      [In] IVectorView<Category> categories,
      [In] Advertisement advertisement,
      [In] IVectorView<Phone> phones,
      [In] WorkingHours workingHours,
      [In] IReference<Precision> precision,
      [In] IVectorView<Feature> features,
      [In] IVectorView<uint> snippet,
      [In] IVectorView<SearchLink> links,
      [In] LocalizedValue distance,
      [In] IVectorView<Chain> chains,
      [In] IReference<Closed> closed,
      [In] IReference<bool> unreliable,
      [In] string seoname);
  }
}
