// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessListObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (BusinessListObjectMetadata))]
  [WebHostHidden]
  [Guid(2946864076, 49738, 15420, 138, 50, 45, 249, 69, 207, 42, 164)]
  [Version(1)]
  internal interface __IBusinessListObjectMetadataPublicNonVirtuals
  {
    IVectorView<BusinessListObjectMetadataBusiness> BusinessList { get; }
  }
}
