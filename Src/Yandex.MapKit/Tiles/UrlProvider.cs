// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Tiles.UrlProvider
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Tiles
{
  [WebHostHidden]
  [Guid(3038026714, 4688, 12681, 168, 103, 25, 57, 51, 249, 245, 89)]
  [Version(1)]
  public interface UrlProvider
  {
    string FormatUrl([In] TileId tileId, [In] Version version);
  }
}
