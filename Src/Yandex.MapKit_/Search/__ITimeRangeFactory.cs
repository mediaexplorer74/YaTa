// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ITimeRangeFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(1299229148, 29673, 14000, 178, 63, 169, 134, 201, 9, 200, 115)]
  [ExclusiveTo(typeof (TimeRange))]
  [WebHostHidden]
  internal interface __ITimeRangeFactory
  {
    [Overload("CreateInstance1")]
    TimeRange CreateInstance(
      [In] IReference<bool> isTwentyFourHours,
      [In] IReference<uint> from,
      [In] IReference<uint> to);
  }
}
