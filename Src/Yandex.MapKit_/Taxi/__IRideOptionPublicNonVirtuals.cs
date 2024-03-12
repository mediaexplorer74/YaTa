// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.__IRideOptionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [Version(1)]
  [ExclusiveTo(typeof (RideOption))]
  [Guid(3648406133, 2604, 15360, 142, 22, 239, 240, 124, 173, 108, 122)]
  [WebHostHidden]
  internal interface __IRideOptionPublicNonVirtuals
  {
    LocalizedValue WaitingTime { get; }

    Money Cost { get; }
  }
}
