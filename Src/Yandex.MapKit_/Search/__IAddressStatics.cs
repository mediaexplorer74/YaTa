// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAddressStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(2559513617, 35126, 15547, 142, 245, 126, 206, 53, 104, 46, 81)]
  [Version(1)]
  [ExclusiveTo(typeof (Address))]
  [WebHostHidden]
  internal interface __IAddressStatics
  {
    Address From([In] AnyCollection anyCollection);
  }
}
