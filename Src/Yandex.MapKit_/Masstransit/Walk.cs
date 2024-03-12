// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Walk
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IWalkFactory), 1)]
  [Static(typeof (__IWalkStatics), 1)]
  public sealed class Walk : __IWalkPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Walk From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Walk(
      [In] IVectorView<PedestrianConstructionID> constructions,
      [In] IVectorView<Spot> spots);

    public extern IVectorView<PedestrianConstructionID> Constructions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Spot> Spots { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
