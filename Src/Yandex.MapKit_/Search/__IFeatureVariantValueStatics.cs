// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IFeatureVariantValueStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (FeatureVariantValue))]
  [Guid(1193936729, 9387, 14968, 168, 155, 152, 221, 56, 94, 15, 206)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IFeatureVariantValueStatics
  {
    FeatureVariantValue FromBooleanValue([In] bool booleanValue);

    FeatureVariantValue FromTextValue([In] IVectorView<string> textValue);

    FeatureVariantValue FromEnumValue([In] IVectorView<FeatureEnumValue> enumValue);
  }
}
