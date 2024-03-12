// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.SpeedLimitsRules
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Threading]
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__ISpeedLimitsRulesFactory), 1)]
  [MarshalingBehavior]
  public sealed class SpeedLimitsRules : __ISpeedLimitsRulesPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SpeedLimitsRules(
      [In] SpeedLimitsRulesType urban,
      [In] SpeedLimitsRulesType rural,
      [In] SpeedLimitsRulesType expressway);

    public extern SpeedLimitsRulesType Urban { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern SpeedLimitsRulesType Rural { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern SpeedLimitsRulesType Expressway { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
