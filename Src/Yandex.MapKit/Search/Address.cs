// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Address
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Activatable(typeof (__IAddressFactory), 1)]
  [Version(1)]
  [Threading]
  [WebHostHidden]
  [Static(typeof (__IAddressStatics), 1)]
  public sealed class Address : __IAddressPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Address From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Address(
      [In] string formattedAddress,
      [In] string postalCode,
      [In] string countryCode,
      [In] IVectorView<AddressComponent> components);

    public extern string FormattedAddress { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string PostalCode { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string CountryCode { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<AddressComponent> Components { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
