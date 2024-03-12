// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.LaneDirection
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  public enum LaneDirection
  {
    UnknownDirection,
    Left180,
    Left135,
    Left90,
    Left45,
    StraightAhead,
    Right45,
    Right90,
    Right135,
    Right180,
    LeftFromRight,
    RightFromLeft,
    LeftShift,
    RightShift,
  }
}
