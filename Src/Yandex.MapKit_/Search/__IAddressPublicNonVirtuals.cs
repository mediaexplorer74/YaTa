// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAddressPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(153130022, 20375, 14548, 132, 214, 80, 244, 10, 163, 212, 198)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Address))]
  internal interface __IAddressPublicNonVirtuals
  {
    string FormattedAddress { get; }

    string PostalCode { get; }

    string CountryCode { get; }

    IVectorView<AddressComponent> Components { get; }
  }
}
