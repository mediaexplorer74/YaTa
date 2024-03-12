// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (ToponymObjectMetadata))]
  [WebHostHidden]
  [Version(1)]
  [Guid(3041065234, 19985, 13310, 161, 110, 1, 47, 44, 215, 86, 104)]
  internal interface __IToponymObjectMetadataPublicNonVirtuals
  {
    Address Address { get; }

    IReference<global::Yandex.MapKit.Search.Precision> Precision { get; }

    string FormerName { get; }

    global::Yandex.MapKit.Geometry.Point BalloonPoint { get; }
  }
}
