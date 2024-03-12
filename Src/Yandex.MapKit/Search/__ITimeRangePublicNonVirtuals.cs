// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ITimeRangePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (TimeRange))]
  [Version(1)]
  [Guid(1916328036, 33171, 14163, 184, 120, 16, 194, 64, 161, 94, 95)]
  [WebHostHidden]
  internal interface __ITimeRangePublicNonVirtuals
  {
    IReference<bool> IsTwentyFourHours { get; }

    IReference<uint> From { get; }

    IReference<uint> To { get; }
  }
}
