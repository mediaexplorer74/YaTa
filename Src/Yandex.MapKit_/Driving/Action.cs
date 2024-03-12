// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Action
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  public enum Action
  {
    Unknown,
    Straight,
    SlightLeft,
    SlightRight,
    Left,
    Right,
    HardLeft,
    HardRight,
    ForkLeft,
    ForkRight,
    UturnLeft,
    UturnRight,
    EnterRoundabout,
    LeaveRoundabout,
    BoardFerry,
    LeaveFerry,
    ExitLeft,
    ExitRight,
    Finish,
  }
}
