// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.SearchManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2943046595, 64089, 14297, 155, 0, 99, 3, 71, 58, 145, 37)]
  public interface SearchManager
  {
    [DefaultOverload]
    [Overload("Submit1")]
    Session Submit(
      [In] global::Yandex.MapKit.Geometry.Point point,
      [In] IReference<int> zoom,
      [In] SearchOptions searchOptions,
      [In] OnSearchResponse onSearchResponse,
      [In] OnSearchError onSearchError);

    [Overload("Submit2")]
    Session Submit(
      [In] string text,
      [In] global::Yandex.MapKit.Geometry.Geometry geometry,
      [In] SearchOptions searchOptions,
      [In] OnSearchResponse onSearchResponse,
      [In] OnSearchError onSearchError);

    Session ResolveURI(
      [In] string uri,
      [In] SearchOptions searchOptions,
      [In] OnSearchResponse onSearchResponse,
      [In] OnSearchError onSearchError);

    Session SearchByOid(
      [In] string oid,
      [In] SearchOptions searchOptions,
      [In] OnSearchResponse onSearchResponse,
      [In] OnSearchError onSearchError);

    void Suggest(
      [In] string text,
      [In] BoundingBox window,
      [In] SearchOptions searchOptions,
      [In] OnSuggestResponse onSuggestResponse,
      [In] OnSuggestError onSuggestError);

    void CancelSuggest();
  }
}
