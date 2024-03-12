// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RawLaneSign
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
  [Threading]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__IRawLaneSignFactory), 1)]
  [MarshalingBehavior]
  [Static(typeof (__IRawLaneSignStatics), 1)]
  public sealed class RawLaneSign : __IRawLaneSignPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawLaneSign From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawLaneSign([In] uint position, [In] IVectorView<Lane> lanes);

    public extern uint Position { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Lane> Lanes { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
