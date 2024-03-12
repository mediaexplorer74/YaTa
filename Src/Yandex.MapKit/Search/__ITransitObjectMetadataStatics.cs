// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ITransitObjectMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [ExclusiveTo(typeof (TransitObjectMetadata))]
  [WebHostHidden]
  [Guid(4118649479, 45822, 16023, 183, 149, 113, 181, 85, 117, 221, 116)]
  internal interface __ITransitObjectMetadataStatics
  {
    TransitObjectMetadata From([In] AnyCollection anyCollection);
  }
}
