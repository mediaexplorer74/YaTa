// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.UserLocation.UserLocationTapListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.UserLocation
{
  [WebHostHidden]
  [Guid(861100367, 8012, 16154, 180, 233, 255, 98, 210, 48, 83, 229)]
  [Version(1)]
  public interface UserLocationTapListener
  {
    void OnUserLocationObjectTap([In] Point point);
  }
}
