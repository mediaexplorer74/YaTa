// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.SpeedingPolicy
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Version(1)]
  [Guid(513372522, 44759, 15516, 173, 241, 104, 131, 127, 152, 182, 95)]
  public interface SpeedingPolicy
  {
    void SetSpeedingTolerance([In] float ratio);

    SpeedLimits LegalSpeedLimits { get; }

    SpeedLimits CustomSpeedLimits { get; }

    SpeedLimitsRules SpeedLimitsRules { get; }

    IReference<int> CurrentRegion { get; }

    bool Valid { get; }
  }
}
