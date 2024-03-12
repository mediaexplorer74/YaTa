// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.GeoObjectTapEvent
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [Guid(437145948, 56492, 12945, 186, 205, 134, 94, 118, 236, 174, 86)]
  [WebHostHidden]
  [Version(1)]
  public interface GeoObjectTapEvent
  {
    GeoObject GeoObject { get; }

    bool Selected { get; [param: In] set; }

    bool Valid { get; }
  }
}
