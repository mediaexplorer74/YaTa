// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Direct.__IBannerFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Direct
{
  [Version(1)]
  [ExclusiveTo(typeof (Banner))]
  [WebHostHidden]
  [Guid(2071327016, 7634, 15979, 131, 199, 20, 16, 214, 213, 130, 248)]
  internal interface __IBannerFactory
  {
    [Overload("CreateInstance1")]
    Banner CreateInstance(
      [In] string title,
      [In] string text,
      [In] string extra,
      [In] IVectorView<string> disclaimers,
      [In] string domain,
      [In] string url,
      [In] string counter);
  }
}
