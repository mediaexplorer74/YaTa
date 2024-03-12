// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISortPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(79646763, 20698, 16040, 138, 85, 144, 208, 161, 65, 136, 155)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Sort))]
  internal interface __ISortPublicNonVirtuals
  {
    SortType Type { get; }

    IReference<SortOrigin> Origin { get; }
  }
}
