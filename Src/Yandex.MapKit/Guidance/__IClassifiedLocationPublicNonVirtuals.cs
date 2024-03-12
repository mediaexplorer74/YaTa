// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IClassifiedLocationPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [ExclusiveTo(typeof (ClassifiedLocation))]
  [Guid(638856247, 41897, 13497, 171, 220, 148, 56, 105, 24, 81, 147)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IClassifiedLocationPublicNonVirtuals
  {
    global::Yandex.MapKit.Location.Location Location { get; }

    LocationClass LocationClass { get; }

    NeedCameraJump NeedCameraJump { get; }
  }
}
