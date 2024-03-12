// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IWorkingHoursPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(730159469, 41591, 12589, 143, 118, 71, 213, 177, 132, 30, 46)]
  [ExclusiveTo(typeof (WorkingHours))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IWorkingHoursPublicNonVirtuals
  {
    string Text { get; }

    IVectorView<Availability> Availabilities { get; }
  }
}
