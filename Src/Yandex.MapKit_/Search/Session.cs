// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Session
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1393073772, 24212, 13212, 140, 123, 45, 165, 117, 54, 66, 46)]
  [WebHostHidden]
  [Version(1)]
  public interface Session
  {
    void Cancel();

    void Retry([In] OnSearchResponse onSearchResponse, [In] OnSearchError onSearchError);

    bool HasNextPage();

    void FetchNextPage([In] OnSearchResponse onSearchResponse, [In] OnSearchError onSearchError);

    void SetFilters([In] IVectorView<BusinessFilter> filters);

    void SetSortByRank();

    void SetSortByDistance([In] global::Yandex.MapKit.Geometry.Geometry origin);

    void SetSearchArea([In] global::Yandex.MapKit.Geometry.Geometry area);

    void SetSearchOptions([In] SearchOptions searchOptions);

    void Resubmit([In] OnSearchResponse onSearchResponse, [In] OnSearchError onSearchError);
  }
}
