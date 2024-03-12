// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhraseRoadEventFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (GuidancePhraseRoadEvent))]
  [Guid(2155136830, 34123, 12566, 140, 179, 1, 227, 217, 239, 191, 189)]
  internal interface __IGuidancePhraseRoadEventFactory
  {
    [Overload("CreateInstance1")]
    GuidancePhraseRoadEvent CreateInstance(
      [In] uint distance,
      [In] IVectorView<EventType> type,
      [In] IReference<float> speedLimit,
      [In] IVectorView<RoadEventLane> lanes);
  }
}
