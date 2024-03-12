// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Spot
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [MarshalingBehavior]
  [Activatable(typeof (__ISpotFactory), 1)]
  [Threading]
  [Version(1)]
  [Static(typeof (__ISpotStatics), 1)]
  [WebHostHidden]
  public sealed class Spot : __ISpotPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Spot From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Spot([In] IReference<PedestrianSpotType> type, [In] uint position);

    public extern IReference<PedestrianSpotType> Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Position { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
