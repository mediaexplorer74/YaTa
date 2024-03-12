// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Weight
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [Activatable(typeof (__IWeightFactory), 1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class Weight : __IWeightPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Weight([In] LocalizedValue time, [In] LocalizedValue walkingDistance, [In] uint transfersCount);

    public extern LocalizedValue Time { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue WalkingDistance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint TransfersCount { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
