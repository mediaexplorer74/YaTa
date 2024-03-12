// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAdvertisementFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (Advertisement))]
  [WebHostHidden]
  [Guid(1278412428, 22172, 14612, 149, 104, 231, 136, 33, 46, 28, 224)]
  [Version(1)]
  internal interface __IAdvertisementFactory
  {
    [Overload("CreateInstance1")]
    Advertisement CreateInstance(
      [In] string text,
      [In] IVectorView<string> disclaimers,
      [In] string title,
      [In] string extra,
      [In] string url);
  }
}
