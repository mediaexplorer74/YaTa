// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhraseRoadEventPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GuidancePhraseRoadEvent))]
  [Guid(955554176, 9474, 14788, 151, 98, 159, 121, 163, 48, 105, 243)]
  [Version(1)]
  internal interface __IGuidancePhraseRoadEventPublicNonVirtuals
  {
    uint Distance { get; }

    IVectorView<EventType> Type { get; }

    IReference<float> SpeedLimit { get; }

    IVectorView<RoadEventLane> Lanes { get; }
  }
}
