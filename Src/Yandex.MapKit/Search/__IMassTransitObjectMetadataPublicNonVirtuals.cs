// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IMassTransitObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(604689624, 38241, 14748, 141, 130, 243, 115, 166, 138, 95, 129)]
  [Version(1)]
  [ExclusiveTo(typeof (MassTransitObjectMetadata))]
  [WebHostHidden]
  internal interface __IMassTransitObjectMetadataPublicNonVirtuals
  {
    IVectorView<Stop> Stops { get; }
  }
}
