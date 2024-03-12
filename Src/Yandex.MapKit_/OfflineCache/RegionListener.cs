// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.RegionListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [Version(1)]
  [Guid(2723047231, 23279, 13648, 166, 83, 117, 194, 69, 52, 146, 247)]
  [WebHostHidden]
  public interface RegionListener
  {
    void OnRegionStateChanged([In] Region region);

    void OnRegionProgress([In] Region region);

    void OnRegionError([In] Region region, [In] Error error);
  }
}
