// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Uri.__IUriObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Uri
{
  [Version(1)]
  [Guid(3086422199, 22651, 14710, 161, 216, 111, 224, 153, 203, 86, 196)]
  [ExclusiveTo(typeof (UriObjectMetadata))]
  [WebHostHidden]
  internal interface __IUriObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    UriObjectMetadata CreateInstance([In] IVectorView<global::Yandex.MapKit.Uri.Uri> uris);
  }
}
