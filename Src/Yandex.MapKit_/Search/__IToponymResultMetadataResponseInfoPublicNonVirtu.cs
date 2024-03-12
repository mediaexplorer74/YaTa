// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymResultMetadataResponseInfoPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2870414448, 29035, 13685, 159, 146, 130, 233, 59, 220, 174, 192)]
  [ExclusiveTo(typeof (ToponymResultMetadataResponseInfo))]
  internal interface __IToponymResultMetadataResponseInfoPublicNonVirtuals
  {
    ToponymResultMetadataSearchMode Mode { get; }

    IReference<double> Accuracy { get; }
  }
}
