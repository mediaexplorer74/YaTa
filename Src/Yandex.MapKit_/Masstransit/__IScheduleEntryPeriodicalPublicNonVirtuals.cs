// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IScheduleEntryPeriodicalPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (ScheduleEntryPeriodical))]
  [Version(1)]
  [WebHostHidden]
  [Guid(3621785988, 43482, 15603, 149, 39, 153, 221, 5, 62, 134, 249)]
  internal interface __IScheduleEntryPeriodicalPublicNonVirtuals
  {
    LocalizedValue Frequency { get; }

    I18nTime Begin { get; }

    I18nTime End { get; }

    IVectorView<ScheduleEntryEstimation> Estimations { get; }
  }
}
