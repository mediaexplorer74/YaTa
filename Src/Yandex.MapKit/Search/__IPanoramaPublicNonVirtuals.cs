// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPanoramaPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [WebHostHidden]
  [Guid(4216535085, 21189, 15053, 158, 38, 38, 195, 61, 49, 204, 3)]
  [ExclusiveTo(typeof (Panorama))]
  internal interface __IPanoramaPublicNonVirtuals
  {
    string Id { get; }

    Direction Direction { get; }

    Span Span { get; }

    Point Point { get; }
  }
}
