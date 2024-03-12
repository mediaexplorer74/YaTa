// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IWorkingHoursFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WorkingHours))]
  [Version(1)]
  [Guid(1851251526, 33228, 14777, 156, 238, 40, 43, 196, 173, 66, 176)]
  internal interface __IWorkingHoursFactory
  {
    [Overload("CreateInstance1")]
    WorkingHours CreateInstance([In] string text, [In] IVectorView<Availability> availabilities);
  }
}
