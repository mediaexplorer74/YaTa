// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Panorama.ErrorListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Panorama
{
  [WebHostHidden]
  [Guid(447877827, 3099, 15951, 159, 120, 181, 121, 38, 0, 68, 122)]
  [Version(1)]
  public interface ErrorListener
  {
    void OnPanoramaOpenError([In] Player player, [In] Error error);
  }
}
