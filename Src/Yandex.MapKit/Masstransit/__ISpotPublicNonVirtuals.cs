// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISpotPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(552361370, 26842, 12444, 142, 249, 172, 81, 89, 105, 134, 229)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Spot))]
  internal interface __ISpotPublicNonVirtuals
  {
    IReference<PedestrianSpotType> Type { get; }

    uint Position { get; }
  }
}
