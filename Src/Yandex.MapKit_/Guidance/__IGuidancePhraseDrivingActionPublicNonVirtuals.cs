// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhraseDrivingActionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GuidancePhraseDrivingAction))]
  [Version(1)]
  [Guid(3745357313, 56041, 16057, 171, 4, 128, 240, 38, 54, 60, 18)]
  internal interface __IGuidancePhraseDrivingActionPublicNonVirtuals
  {
    IReference<uint> Distance { get; }

    Action Action { get; }

    IReference<uint> ExitNumber { get; }

    IReference<uint> Length { get; }

    IReference<Landmark> ActionLandmark { get; }

    IReference<Landmark> DestinationLandmark { get; }
  }
}
