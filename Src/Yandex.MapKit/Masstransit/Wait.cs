// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Wait
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Activatable(typeof (__IWaitFactory), 1)]
  [MarshalingBehavior]
  [Threading]
  [Version(1)]
  public sealed class Wait : __IWaitPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Wait([In] uint dummy);

    public extern uint Dummy { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
