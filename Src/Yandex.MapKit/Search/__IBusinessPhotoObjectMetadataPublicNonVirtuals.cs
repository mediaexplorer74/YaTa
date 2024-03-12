// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessPhotoObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1641519794, 31937, 14499, 130, 185, 104, 22, 203, 181, 99, 37)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BusinessPhotoObjectMetadata))]
  internal interface __IBusinessPhotoObjectMetadataPublicNonVirtuals
  {
    uint Count { get; }

    IVectorView<BusinessPhotoObjectMetadataPhoto> Photos { get; }
  }
}
