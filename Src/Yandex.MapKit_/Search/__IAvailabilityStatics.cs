// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAvailabilityStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(3641400335, 28950, 16164, 166, 35, 181, 119, 188, 210, 241, 17)]
  [ExclusiveTo(typeof (Availability))]
  [WebHostHidden]
  internal interface __IAvailabilityStatics
  {
    Availability From([In] AnyCollection anyCollection);
  }
}
