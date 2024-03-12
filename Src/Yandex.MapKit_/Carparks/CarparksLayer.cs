// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Carparks.CarparksLayer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Carparks
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2922168612, 51722, 13565, 168, 70, 179, 57, 235, 22, 107, 11)]
  public interface CarparksLayer
  {
    bool IsVisible();

    void SetVisible([In] bool on);

    bool Valid { get; }
  }
}
