// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessListObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [ExclusiveTo(typeof (BusinessListObjectMetadata))]
  [Guid(4042704420, 60921, 13367, 132, 191, 79, 173, 129, 99, 65, 82)]
  [Version(1)]
  internal interface __IBusinessListObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    BusinessListObjectMetadata CreateInstance(
      [In] IVectorView<BusinessListObjectMetadataBusiness> businessList);
  }
}
