// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RawLaneSigns
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
  [Version(1)]
  [Threading]
  [Activatable(typeof (__IRawLaneSignsFactory), 1)]
  [Static(typeof (__IRawLaneSignsStatics), 1)]
  [MarshalingBehavior]
  public sealed class RawLaneSigns : __IRawLaneSignsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawLaneSigns From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawLaneSigns([In] IVectorView<RawLaneSign> laneSigns);

    public extern IVectorView<RawLaneSign> LaneSigns { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
