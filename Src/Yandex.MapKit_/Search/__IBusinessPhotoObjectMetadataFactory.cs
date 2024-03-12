// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessPhotoObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(4099662296, 39751, 15125, 136, 200, 70, 55, 56, 44, 18, 15)]
  [Version(1)]
  [ExclusiveTo(typeof (BusinessPhotoObjectMetadata))]
  [WebHostHidden]
  internal interface __IBusinessPhotoObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    BusinessPhotoObjectMetadata CreateInstance(
      [In] uint count,
      [In] IVectorView<BusinessPhotoObjectMetadataPhoto> photos);
  }
}
