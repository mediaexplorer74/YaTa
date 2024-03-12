// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IFeaturePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1774552385, 43550, 15625, 165, 32, 242, 183, 247, 110, 137, 163)]
  [ExclusiveTo(typeof (Feature))]
  internal interface __IFeaturePublicNonVirtuals
  {
    string Id { get; }

    FeatureVariantValue Value { get; }

    string Name { get; }

    string Aref { get; }
  }
}
