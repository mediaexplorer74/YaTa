// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IFacetPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(4122062533, 47207, 15299, 187, 18, 197, 218, 167, 147, 116, 151)]
  [Version(1)]
  [ExclusiveTo(typeof (Facet))]
  [WebHostHidden]
  internal interface __IFacetPublicNonVirtuals
  {
    string FacetClass { get; }

    string Name { get; }

    uint Ratings { get; }

    IReference<float> Score { get; }
  }
}
