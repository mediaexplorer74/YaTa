// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Uri.__IUriFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Uri
{
  [ExclusiveTo(typeof (global::Yandex.MapKit.Uri.Uri))]
  [Version(1)]
  [Guid(1332092259, 42530, 13009, 174, 186, 201, 154, 185, 219, 251, 13)]
  [WebHostHidden]
  internal interface __IUriFactory
  {
    [Overload("CreateInstance1")]
    global::Yandex.MapKit.Uri.Uri CreateInstance([In] string value);
  }
}
