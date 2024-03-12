// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.CameraListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [WebHostHidden]
  [Guid(461172522, 44712, 14174, 130, 74, 53, 72, 78, 185, 254, 136)]
  public interface CameraListener
  {
    void OnCameraPositionChanged(
      [In] global::Yandex.MapKit.Map.Map map,
      [In] CameraPosition cameraPosition,
      [In] CameraUpdateSource cameraUpdateSource,
      [In] bool finished);
  }
}
