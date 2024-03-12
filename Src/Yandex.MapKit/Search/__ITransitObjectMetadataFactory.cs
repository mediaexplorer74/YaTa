// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ITransitObjectMetadataFactory
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
  [WebHostHidden]
  [Guid(2849745033, 55343, 15237, 131, 51, 51, 155, 180, 92, 26, 232)]
  [ExclusiveTo(typeof (TransitObjectMetadata))]
  internal interface __ITransitObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    TransitObjectMetadata CreateInstance([In] string routeId, [In] IVectorView<string> types);
  }
}
