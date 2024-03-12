// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAvailabilityFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(475370704, 23604, 13876, 176, 212, 16, 155, 213, 56, 195, 171)]
  [ExclusiveTo(typeof (Availability))]
  [WebHostHidden]
  internal interface __IAvailabilityFactory
  {
    [Overload("CreateInstance1")]
    Availability CreateInstance([In] DayGroup days, [In] IVectorView<TimeRange> timeRanges);
  }
}
