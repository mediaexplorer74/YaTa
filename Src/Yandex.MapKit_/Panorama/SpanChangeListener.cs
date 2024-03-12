// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Panorama.SpanChangeListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Panorama
{
  [Version(1)]
  [Guid(4278508738, 1851, 14880, 178, 252, 49, 72, 234, 22, 148, 89)]
  [WebHostHidden]
  public interface SpanChangeListener
  {
    void OnPanoramaSpanChanged([In] Player player);
  }
}
