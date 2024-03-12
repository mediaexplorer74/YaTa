// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(2267119834, 43709, 15046, 183, 48, 90, 90, 33, 140, 74, 105)]
  [ExclusiveTo(typeof (BusinessFilter))]
  [WebHostHidden]
  internal interface __IBusinessFilterPublicNonVirtuals
  {
    string Id { get; }

    string Name { get; }

    IReference<bool> Disabled { get; }

    BusinessFilterValues Values { get; }
  }
}
