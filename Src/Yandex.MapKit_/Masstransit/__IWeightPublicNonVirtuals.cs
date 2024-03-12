// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IWeightPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Weight))]
  [Guid(1078803510, 56176, 14790, 180, 116, 53, 189, 249, 3, 10, 92)]
  internal interface __IWeightPublicNonVirtuals
  {
    LocalizedValue Time { get; }

    LocalizedValue WalkingDistance { get; }

    uint TransfersCount { get; }
  }
}
