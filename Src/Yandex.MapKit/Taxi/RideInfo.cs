// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.RideInfo
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [Static(typeof (__IRideInfoStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__IRideInfoFactory), 1)]
  public sealed class RideInfo : __IRideInfoPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RideInfo From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RideInfo([In] IVectorView<RideOption> rideOptions);

    public extern IVectorView<RideOption> RideOptions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
