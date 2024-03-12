// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Panorama.PanoramaService
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Panorama
{
  [Guid(2861227366, 39252, 16175, 166, 48, 98, 246, 61, 59, 244, 135)]
  [Version(1)]
  [WebHostHidden]
  public interface PanoramaService
  {
    PanoramaServiceSearchSession FindNearest(
      [In] Point position,
      [In] OnPanoramaSearchResult onPanoramaSearchResult,
      [In] OnPanoramaSearchError onPanoramaSearchError);
  }
}
