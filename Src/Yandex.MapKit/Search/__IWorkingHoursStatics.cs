// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IWorkingHoursStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1000266053, 26886, 15033, 182, 240, 27, 109, 38, 205, 122, 9)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WorkingHours))]
  internal interface __IWorkingHoursStatics
  {
    WorkingHours From([In] AnyCollection anyCollection);
  }
}
