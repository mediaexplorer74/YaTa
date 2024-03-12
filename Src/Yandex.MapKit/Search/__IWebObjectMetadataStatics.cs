// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IWebObjectMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(865757932, 3557, 14966, 137, 176, 62, 23, 207, 126, 111, 65)]
  [ExclusiveTo(typeof (WebObjectMetadata))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IWebObjectMetadataStatics
  {
    WebObjectMetadata From([In] AnyCollection anyCollection);
  }
}
