// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Coverage.Coverage
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Coverage
{
  [WebHostHidden]
  [Guid(4204393430, 27894, 15699, 181, 43, 6, 161, 35, 140, 137, 187)]
  [Version(1)]
  public interface Coverage
  {
    [DefaultOverload]
    [Overload("IsCovered1")]
    IsCoveredSession IsCovered(
      [In] LinearRing area,
      [In] int zoom,
      [In] OnCoveredResponse onCoveredResponse,
      [In] OnCoveredError onCoveredError);

    [Overload("IsCovered2")]
    IsCoveredSession IsCovered(
      [In] Point point,
      [In] int zoom,
      [In] OnCoveredResponse onCoveredResponse,
      [In] OnCoveredError onCoveredError);

    RegionsSession Regions(
      [In] Point point,
      [In] int zoom,
      [In] OnRegionsResponse onRegionsResponse,
      [In] OnRegionsError onRegionsError);

    void SetActiveArea([In] LinearRing area, [In] int zoom);
  }
}
