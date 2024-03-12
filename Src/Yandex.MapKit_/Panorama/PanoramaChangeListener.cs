// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Panorama.PanoramaChangeListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Panorama
{
  [WebHostHidden]
  [Version(1)]
  [Guid(4254235507, 46715, 13517, 191, 196, 152, 27, 205, 232, 8, 78)]
  public interface PanoramaChangeListener
  {
    void OnPanoramaChanged([In] Player player);
  }
}
