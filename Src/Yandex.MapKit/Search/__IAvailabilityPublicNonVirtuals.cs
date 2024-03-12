// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAvailabilityPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2681538470, 38143, 14450, 140, 175, 219, 203, 166, 240, 117, 40)]
  [ExclusiveTo(typeof (Availability))]
  internal interface __IAvailabilityPublicNonVirtuals
  {
    DayGroup Days { get; }

    IVectorView<TimeRange> TimeRanges { get; }
  }
}
