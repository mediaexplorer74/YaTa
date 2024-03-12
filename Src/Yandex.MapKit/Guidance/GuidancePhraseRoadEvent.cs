// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.GuidancePhraseRoadEvent
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.RoadEvents;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Static(typeof (__IGuidancePhraseRoadEventStatics), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__IGuidancePhraseRoadEventFactory), 1)]
  [Threading]
  public sealed class GuidancePhraseRoadEvent : __IGuidancePhraseRoadEventPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GuidancePhraseRoadEvent From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern GuidancePhraseRoadEvent(
      [In] uint distance,
      [In] IVectorView<EventType> type,
      [In] IReference<float> speedLimit,
      [In] IVectorView<RoadEventLane> lanes);

    public extern uint Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<EventType> Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> SpeedLimit { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<RoadEventLane> Lanes { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
