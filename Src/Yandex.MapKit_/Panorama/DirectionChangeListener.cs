// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Panorama.DirectionChangeListener
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
  [Guid(1233771682, 17889, 16300, 129, 255, 189, 111, 168, 67, 166, 83)]
  public interface DirectionChangeListener
  {
    void OnPanoramaDirectionChanged([In] Player player);
  }
}
