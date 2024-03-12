// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymResultMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (ToponymResultMetadata))]
  [Version(1)]
  [Guid(3529605130, 28769, 15742, 186, 210, 234, 212, 78, 201, 80, 206)]
  [WebHostHidden]
  internal interface __IToponymResultMetadataStatics
  {
    ToponymResultMetadata From([In] AnyCollection anyCollection);
  }
}
