// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__ITimePeriodFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TimePeriod))]
  [Guid(321039956, 50153, 14110, 139, 138, 12, 81, 72, 154, 200, 185)]
  internal interface __ITimePeriodFactory
  {
    [Overload("CreateInstance1")]
    TimePeriod CreateInstance([In] I18nTime begin, [In] I18nTime end);
  }
}
