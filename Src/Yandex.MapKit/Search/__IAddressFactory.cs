// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAddressFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (Address))]
  [WebHostHidden]
  [Version(1)]
  [Guid(1611770951, 22349, 12932, 148, 85, 169, 121, 30, 65, 197, 96)]
  internal interface __IAddressFactory
  {
    [Overload("CreateInstance1")]
    Address CreateInstance(
      [In] string formattedAddress,
      [In] string postalCode,
      [In] string countryCode,
      [In] IVectorView<AddressComponent> components);
  }
}
