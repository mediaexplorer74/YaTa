// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Tiles.TileProvider
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Tiles
{
  [WebHostHidden]
  [Guid(3909404227, 63030, 13521, 153, 136, 218, 86, 26, 100, 244, 228)]
  [Version(1)]
  public interface TileProvider
  {
    RawTile Load([In] TileId tileId, [In] Version version, [In] string etag);
  }
}
