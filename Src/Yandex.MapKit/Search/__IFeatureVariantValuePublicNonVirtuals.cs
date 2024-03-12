// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IFeatureVariantValuePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(3248504966, 21492, 13701, 150, 155, 29, 76, 32, 0, 29, 45)]
  [ExclusiveTo(typeof (FeatureVariantValue))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IFeatureVariantValuePublicNonVirtuals
  {
    IReference<bool> BooleanValue { get; }

    IVectorView<string> TextValue { get; }

    IVectorView<FeatureEnumValue> EnumValue { get; }
  }
}
