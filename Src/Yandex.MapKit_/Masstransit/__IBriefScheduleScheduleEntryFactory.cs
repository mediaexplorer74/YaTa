// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IBriefScheduleScheduleEntryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1978889111, 61006, 15025, 147, 140, 75, 243, 130, 97, 167, 52)]
  [ExclusiveTo(typeof (BriefScheduleScheduleEntry))]
  internal interface __IBriefScheduleScheduleEntryFactory
  {
    [Overload("CreateInstance1")]
    BriefScheduleScheduleEntry CreateInstance(
      [In] ScheduleEntryPeriodical periodical,
      [In] ScheduleEntryScheduled scheduled);
  }
}
