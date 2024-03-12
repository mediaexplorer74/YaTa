// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(297625476, 44694, 13698, 168, 49, 114, 249, 71, 32, 28, 226)]
  [Version(1)]
  [ExclusiveTo(typeof (ToponymObjectMetadata))]
  [WebHostHidden]
  internal interface __IToponymObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    ToponymObjectMetadata CreateInstance(
      [In] Address address,
      [In] IReference<Precision> precision,
      [In] string formerName,
      [In] global::Yandex.MapKit.Geometry.Point balloonPoint);
  }
}
