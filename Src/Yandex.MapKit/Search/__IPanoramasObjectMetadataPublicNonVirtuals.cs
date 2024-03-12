// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPanoramasObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Guid(2925238651, 11379, 14912, 188, 136, 88, 77, 207, 15, 212, 238)]
  [ExclusiveTo(typeof (PanoramasObjectMetadata))]
  [Version(1)]
  internal interface __IPanoramasObjectMetadataPublicNonVirtuals
  {
    IVectorView<Panorama> Panoramas { get; }
  }
}
