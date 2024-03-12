// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IResponseFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (Response))]
  [WebHostHidden]
  [Guid(1996842323, 59588, 12759, 171, 248, 42, 71, 174, 138, 165, 176)]
  [Version(1)]
  internal interface __IResponseFactory
  {
    [Overload("CreateInstance1")]
    Response CreateInstance(
      [In] SearchMetadata metadata,
      [In] GeoObjectCollection collection,
      [In] bool isOffline);
  }
}
