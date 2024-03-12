// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IRouterObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Guid(3440173507, 63369, 13974, 184, 73, 3, 13, 204, 235, 77, 110)]
  [ExclusiveTo(typeof (RouterObjectMetadata))]
  [Version(1)]
  internal interface __IRouterObjectMetadataPublicNonVirtuals
  {
    IVectorView<Router> Routers { get; }
  }
}
