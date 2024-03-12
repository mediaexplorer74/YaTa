// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.UserLocation.UserLocationView
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Map;

#nullable disable
namespace Yandex.MapKit.UserLocation
{
  [Version(1)]
  [WebHostHidden]
  [Guid(623770856, 6972, 15736, 179, 139, 109, 65, 46, 95, 176, 97)]
  public interface UserLocationView
  {
    PlacemarkMapObject Arrow { get; }

    PlacemarkMapObject ArrowShadow { get; }

    PlacemarkMapObject Pin { get; }

    PlacemarkMapObject PinShadow { get; }

    CircleMapObject AccuracyCircle { get; }

    ScreenPoint ShadowOffset { get; [param: In] set; }

    bool Valid { get; }
  }
}
