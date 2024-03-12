// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.LaneSign
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__ILaneSignFactory), 1)]
  [Static(typeof (__ILaneSignStatics), 1)]
  [MarshalingBehavior]
  public sealed class LaneSign : __ILaneSignPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern LaneSign From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LaneSign([In] PolylinePosition position, [In] IVectorView<Lane> lanes);

    public extern PolylinePosition Position { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Lane> Lanes { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
