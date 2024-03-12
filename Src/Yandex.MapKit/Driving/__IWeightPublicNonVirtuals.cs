// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IWeightPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2467023100, 57886, 12723, 190, 162, 74, 28, 15, 59, 12, 250)]
  [ExclusiveTo(typeof (Weight))]
  internal interface __IWeightPublicNonVirtuals
  {
    LocalizedValue Time { get; }

    LocalizedValue TimeWithTraffic { get; }

    LocalizedValue Distance { get; }
  }
}
