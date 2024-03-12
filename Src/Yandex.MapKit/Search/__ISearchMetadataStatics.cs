// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISearchMetadataStatics
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
  [ExclusiveTo(typeof (SearchMetadata))]
  [WebHostHidden]
  [Guid(2221444718, 63838, 16043, 147, 236, 112, 194, 70, 63, 114, 29)]
  internal interface __ISearchMetadataStatics
  {
    SearchMetadata From([In] AnyCollection anyCollection);
  }
}
