// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAddressComponentStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(3251787874, 29251, 15418, 182, 57, 202, 128, 63, 226, 166, 123)]
  [ExclusiveTo(typeof (AddressComponent))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IAddressComponentStatics
  {
    AddressComponent From([In] AnyCollection anyCollection);
  }
}
