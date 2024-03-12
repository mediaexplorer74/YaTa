// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IMassTransitObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(3345231351, 56482, 12456, 130, 182, 193, 6, 188, 118, 248, 254)]
  [ExclusiveTo(typeof (MassTransitObjectMetadata))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IMassTransitObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    MassTransitObjectMetadata CreateInstance([In] IVectorView<Stop> stops);
  }
}
