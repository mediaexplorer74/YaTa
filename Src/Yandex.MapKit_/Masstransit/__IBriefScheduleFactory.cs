// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IBriefScheduleFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (BriefSchedule))]
  [Guid(3534595309, 24668, 15036, 156, 138, 13, 200, 111, 63, 184, 58)]
  internal interface __IBriefScheduleFactory
  {
    [Overload("CreateInstance1")]
    BriefSchedule CreateInstance(
      [In] IVectorView<BriefScheduleScheduleEntry> scheduleEntries);
  }
}
