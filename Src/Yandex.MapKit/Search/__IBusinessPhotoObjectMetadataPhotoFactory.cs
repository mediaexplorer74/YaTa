// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessPhotoObjectMetadataPhotoFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [ExclusiveTo(typeof (BusinessPhotoObjectMetadataPhoto))]
  [WebHostHidden]
  [Guid(2474176825, 28712, 15273, 175, 184, 97, 105, 128, 113, 42, 224)]
  internal interface __IBusinessPhotoObjectMetadataPhotoFactory
  {
    [Overload("CreateInstance1")]
    BusinessPhotoObjectMetadataPhoto CreateInstance([In] string id);
  }
}
