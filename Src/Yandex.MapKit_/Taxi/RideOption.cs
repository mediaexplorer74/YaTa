// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.RideOption
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__IRideOptionFactory), 1)]
  public sealed class RideOption : __IRideOptionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RideOption([In] LocalizedValue waitingTime, [In] Money cost);

    public extern LocalizedValue WaitingTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Money Cost { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
