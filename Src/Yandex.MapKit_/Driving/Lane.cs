// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Lane
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__ILaneFactory), 1)]
  [Threading]
  [Static(typeof (__ILaneStatics), 1)]
  public sealed class Lane : __ILanePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Lane From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Lane(
      [In] LaneKind laneKind,
      [In] IVectorView<LaneDirection> directions,
      [In] IReference<LaneDirection> highlightedDirection);

    public extern LaneKind LaneKind { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<LaneDirection> Directions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<LaneDirection> HighlightedDirection { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
