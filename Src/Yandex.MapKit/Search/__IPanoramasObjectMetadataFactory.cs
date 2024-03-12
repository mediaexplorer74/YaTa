// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPanoramasObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(2095197330, 10724, 14071, 163, 31, 145, 145, 86, 185, 255, 70)]
  [ExclusiveTo(typeof (PanoramasObjectMetadata))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IPanoramasObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    PanoramasObjectMetadata CreateInstance([In] IVectorView<Panorama> panoramas);
  }
}
