// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Layers.GeoObjectTapListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Layers
{
  [Version(1)]
  [Guid(617739568, 28569, 15624, 165, 191, 54, 210, 32, 215, 126, 232)]
  [WebHostHidden]
  public interface GeoObjectTapListener
  {
    void OnObjectTap([In] GeoObjectTapEvent @event);

    void OnDeselect();
  }
}
