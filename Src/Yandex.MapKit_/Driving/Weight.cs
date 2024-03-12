// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Weight
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Activatable(typeof (__IWeightFactory), 1)]
  [Threading]
  [Version(1)]
  [WebHostHidden]
  [MarshalingBehavior]
  public sealed class Weight : __IWeightPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Weight(
      [In] LocalizedValue time,
      [In] LocalizedValue timeWithTraffic,
      [In] LocalizedValue distance);

    public extern LocalizedValue Time { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue TimeWithTraffic { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
