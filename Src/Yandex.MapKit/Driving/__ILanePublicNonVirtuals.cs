// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ILanePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(1516459879, 26212, 12359, 171, 147, 145, 98, 215, 189, 4, 157)]
  [ExclusiveTo(typeof (Lane))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ILanePublicNonVirtuals
  {
    LaneKind LaneKind { get; }

    IVectorView<LaneDirection> Directions { get; }

    IReference<LaneDirection> HighlightedDirection { get; }
  }
}
