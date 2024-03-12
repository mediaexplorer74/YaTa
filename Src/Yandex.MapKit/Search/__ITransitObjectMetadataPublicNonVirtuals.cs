// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ITransitObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(2311031806, 3977, 14287, 166, 178, 59, 53, 210, 12, 198, 138)]
  [ExclusiveTo(typeof (TransitObjectMetadata))]
  [Version(1)]
  [WebHostHidden]
  internal interface __ITransitObjectMetadataPublicNonVirtuals
  {
    string RouteId { get; }

    IVectorView<string> Types { get; }
  }
}
