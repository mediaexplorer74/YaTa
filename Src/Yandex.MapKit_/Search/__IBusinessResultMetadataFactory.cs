// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessResultMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(3761439544, 7825, 13224, 136, 218, 88, 157, 231, 244, 227, 250)]
  [ExclusiveTo(typeof (BusinessResultMetadata))]
  [WebHostHidden]
  internal interface __IBusinessResultMetadataFactory
  {
    [Overload("CreateInstance1")]
    BusinessResultMetadata CreateInstance(
      [In] IVectorView<Category> categories,
      [In] IVectorView<BusinessFilter> businessFilters);
  }
}
