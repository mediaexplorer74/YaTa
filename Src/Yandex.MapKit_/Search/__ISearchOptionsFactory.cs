// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISearchOptionsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1930764240, 35964, 13788, 163, 137, 49, 39, 165, 151, 137, 56)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SearchOptions))]
  [Version(1)]
  internal interface __ISearchOptionsFactory
  {
    [Overload("CreateInstance1")]
    SearchOptions CreateInstance(
      [In] SearchType searchTypes,
      [In] IReference<uint> resultPageSize,
      [In] Snippet snippets,
      [In] global::Yandex.MapKit.Geometry.Point userPosition,
      [In] string origin,
      [In] string directPageId,
      [In] string directStatId,
      [In] string appleCtx,
      [In] bool searchClosed,
      [In] bool geometry,
      [In] IReference<uint> maxAdverts);
  }
}
