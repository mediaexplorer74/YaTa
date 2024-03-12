// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IMassTransitObjectMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1661236164, 18007, 16147, 185, 0, 222, 125, 123, 250, 39, 13)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MassTransitObjectMetadata))]
  internal interface __IMassTransitObjectMetadataStatics
  {
    MassTransitObjectMetadata From([In] AnyCollection anyCollection);
  }
}
