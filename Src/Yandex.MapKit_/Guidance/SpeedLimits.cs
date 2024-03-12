// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.SpeedLimits
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Activatable(typeof (__ISpeedLimitsFactory), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Threading]
  public sealed class SpeedLimits : __ISpeedLimitsPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SpeedLimits(
      [In] LocalizedValue urban,
      [In] LocalizedValue rural,
      [In] LocalizedValue expressway);

    public extern LocalizedValue Urban { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Rural { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Expressway { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
