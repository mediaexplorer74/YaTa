// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IBriefScheduleScheduleEntryPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2720985110, 9600, 14368, 180, 29, 121, 40, 156, 15, 182, 182)]
  [ExclusiveTo(typeof (BriefScheduleScheduleEntry))]
  internal interface __IBriefScheduleScheduleEntryPublicNonVirtuals
  {
    ScheduleEntryPeriodical Periodical { get; }

    ScheduleEntryScheduled Scheduled { get; }
  }
}
