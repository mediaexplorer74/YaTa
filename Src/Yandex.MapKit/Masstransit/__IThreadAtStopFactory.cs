// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IThreadAtStopFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(2383891627, 21640, 14721, 163, 24, 130, 230, 127, 199, 132, 73)]
  [ExclusiveTo(typeof (ThreadAtStop))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IThreadAtStopFactory
  {
    [Overload("CreateInstance1")]
    ThreadAtStop CreateInstance(
      [In] Thread thread,
      [In] bool noBoarding,
      [In] bool noDropOff,
      [In] BriefSchedule briefSchedule);
  }
}
