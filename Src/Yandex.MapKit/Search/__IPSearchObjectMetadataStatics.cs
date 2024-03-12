// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPSearchObjectMetadataStatics
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
  [ExclusiveTo(typeof (PSearchObjectMetadata))]
  [WebHostHidden]
  [Guid(1005266898, 47056, 14321, 147, 150, 118, 6, 137, 62, 237, 77)]
  internal interface __IPSearchObjectMetadataStatics
  {
    PSearchObjectMetadata From([In] AnyCollection anyCollection);
  }
}
