// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IRouterObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(2130037369, 14961, 16338, 147, 128, 197, 38, 185, 3, 78, 14)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RouterObjectMetadata))]
  internal interface __IRouterObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    RouterObjectMetadata CreateInstance([In] IVectorView<Router> routers);
  }
}
