// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RawSpeedLimit
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Static(typeof (__IRawSpeedLimitStatics), 1)]
  [WebHostHidden]
  [Activatable(typeof (__IRawSpeedLimitFactory), 1)]
  [Threading]
  [MarshalingBehavior]
  [Version(1)]
  public sealed class RawSpeedLimit : __IRawSpeedLimitPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawSpeedLimit From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawSpeedLimit([In] int count, [In] IReference<float> speed);

    public extern int Count { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> Speed { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
