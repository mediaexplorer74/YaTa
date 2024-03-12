// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RawSpeedLimits
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IRawSpeedLimitsFactory), 1)]
  [Static(typeof (__IRawSpeedLimitsStatics), 1)]
  [Threading]
  public sealed class RawSpeedLimits : __IRawSpeedLimitsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawSpeedLimits From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawSpeedLimits([In] IVectorView<RawSpeedLimit> speedLimits);

    public extern IVectorView<RawSpeedLimit> SpeedLimits { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
