// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IBriefSchedulePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (BriefSchedule))]
  [Version(1)]
  [WebHostHidden]
  [Guid(3162902648, 13696, 13197, 141, 198, 52, 199, 92, 188, 105, 206)]
  internal interface __IBriefSchedulePublicNonVirtuals
  {
    IVectorView<BriefScheduleScheduleEntry> ScheduleEntries { get; }
  }
}
