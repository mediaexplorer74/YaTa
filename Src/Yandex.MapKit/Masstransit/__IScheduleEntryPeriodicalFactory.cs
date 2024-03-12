// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IScheduleEntryPeriodicalFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [Guid(2249695762, 52928, 12740, 136, 175, 72, 66, 8, 22, 192, 52)]
  [ExclusiveTo(typeof (ScheduleEntryPeriodical))]
  [WebHostHidden]
  internal interface __IScheduleEntryPeriodicalFactory
  {
    [Overload("CreateInstance1")]
    ScheduleEntryPeriodical CreateInstance(
      [In] LocalizedValue frequency,
      [In] I18nTime begin,
      [In] I18nTime end,
      [In] IVectorView<ScheduleEntryEstimation> estimations);
  }
}
