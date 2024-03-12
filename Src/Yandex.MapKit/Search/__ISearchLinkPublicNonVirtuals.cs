// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISearchLinkPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (SearchLink))]
  [WebHostHidden]
  [Version(1)]
  [Guid(2672141479, 62805, 13225, 170, 167, 25, 98, 227, 205, 111, 108)]
  internal interface __ISearchLinkPublicNonVirtuals
  {
    string Aref { get; }

    LinkType Type { get; }

    AttributionLink Link { get; }
  }
}
