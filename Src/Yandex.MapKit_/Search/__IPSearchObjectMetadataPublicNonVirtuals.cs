// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPSearchObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(4143982515, 58833, 12690, 129, 218, 80, 145, 150, 20, 224, 111)]
  [Version(1)]
  [ExclusiveTo(typeof (PSearchObjectMetadata))]
  [WebHostHidden]
  internal interface __IPSearchObjectMetadataPublicNonVirtuals
  {
    string Name { get; }

    string Address { get; }

    string Category { get; }

    LocalizedValue Distance { get; }
  }
}
