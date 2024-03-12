// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.BriefScheduleScheduleEntry
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
  [Activatable(typeof (__IBriefScheduleScheduleEntryFactory), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [Static(typeof (__IBriefScheduleScheduleEntryStatics), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class BriefScheduleScheduleEntry : __IBriefScheduleScheduleEntryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BriefScheduleScheduleEntry From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BriefScheduleScheduleEntry(
      [In] ScheduleEntryPeriodical periodical,
      [In] ScheduleEntryScheduled scheduled);

    public extern ScheduleEntryPeriodical Periodical { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ScheduleEntryScheduled Scheduled { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
