// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.MasstransitRouter
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3252515730, 50773, 16059, 187, 108, 150, 193, 164, 59, 26, 17)]
  public interface MasstransitRouter
  {
    Session RequestRoutes(
      [In] Point source,
      [In] Point destination,
      [In] OnMasstransitRoutes onMasstransitRoutes,
      [In] OnMasstransitRoutesError onMasstransitRoutesError);

    SummarySession RequestRoutesSummary(
      [In] Point source,
      [In] Point destination,
      [In] OnMasstransitSummaries onMasstransitSummaries,
      [In] OnMasstransitSummariesError onMasstransitSummariesError);

    Session ResolveUri(
      [In] string uri,
      [In] OnMasstransitRoutes onMasstransitRoutes,
      [In] OnMasstransitRoutesError onMasstransitRoutesError);

    Session Alternatives(
      [In] string uri,
      [In] OnMasstransitRoutes onMasstransitRoutes,
      [In] OnMasstransitRoutesError onMasstransitRoutesError);
  }
}
