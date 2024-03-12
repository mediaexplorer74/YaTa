// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPhoneFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(546336353, 42102, 15688, 132, 8, 210, 142, 134, 33, 40, 37)]
  [ExclusiveTo(typeof (Phone))]
  [WebHostHidden]
  internal interface __IPhoneFactory
  {
    [Overload("CreateInstance1")]
    Phone CreateInstance(
      [In] PhoneType type,
      [In] string formattedNumber,
      [In] string info,
      [In] IReference<uint> country,
      [In] IReference<uint> prefix,
      [In] IReference<uint> ext,
      [In] uint number);
  }
}
