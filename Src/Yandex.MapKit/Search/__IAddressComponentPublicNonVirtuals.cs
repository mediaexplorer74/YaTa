// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAddressComponentPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (AddressComponent))]
  [WebHostHidden]
  [Guid(1337156118, 38875, 15222, 152, 21, 17, 56, 217, 167, 101, 51)]
  [Version(1)]
  internal interface __IAddressComponentPublicNonVirtuals
  {
    string Name { get; }

    IVectorView<ComponentKind> Kinds { get; }
  }
}
