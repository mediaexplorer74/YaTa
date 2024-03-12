// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymResultMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (ToponymResultMetadata))]
  [Guid(3783287522, 64034, 14075, 189, 0, 144, 35, 143, 232, 214, 91)]
  [Version(1)]
  [WebHostHidden]
  internal interface __IToponymResultMetadataPublicNonVirtuals
  {
    int Found { get; }

    ToponymResultMetadataResponseInfo ResponseInfo { get; }

    Point ReversePoint { get; }
  }
}
