// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterEnumValuePublicNonVirtuals
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
  [Guid(1292894189, 36284, 14058, 173, 111, 56, 140, 200, 244, 195, 171)]
  [ExclusiveTo(typeof (BusinessFilterEnumValue))]
  internal interface __IBusinessFilterEnumValuePublicNonVirtuals
  {
    FeatureEnumValue Value { get; }

    IReference<bool> Selected { get; }

    IReference<bool> Disabled { get; }
  }
}
