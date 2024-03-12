// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.BriefSchedule
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
  [Threading]
  [Activatable(typeof (__IBriefScheduleFactory), 1)]
  [MarshalingBehavior]
  [Static(typeof (__IBriefScheduleStatics), 1)]
  [WebHostHidden]
  [Version(1)]
  public sealed class BriefSchedule : __IBriefSchedulePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BriefSchedule From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BriefSchedule(
      [In] IVectorView<BriefScheduleScheduleEntry> scheduleEntries);

    public extern IVectorView<BriefScheduleScheduleEntry> ScheduleEntries { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
