// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.ThreadAtStop
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Activatable(typeof (__IThreadAtStopFactory), 1)]
  [Threading]
  [Static(typeof (__IThreadAtStopStatics), 1)]
  [Version(1)]
  [WebHostHidden]
  [MarshalingBehavior]
  public sealed class ThreadAtStop : __IThreadAtStopPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern ThreadAtStop From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ThreadAtStop(
      [In] Thread thread,
      [In] bool noBoarding,
      [In] bool noDropOff,
      [In] BriefSchedule briefSchedule);

    public extern Thread Thread { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool NoBoarding { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool NoDropOff { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern BriefSchedule BriefSchedule { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
