// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ILaneFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(3471390110, 34143, 16309, 190, 56, 103, 99, 224, 208, 159, 75)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Lane))]
  [Version(1)]
  internal interface __ILaneFactory
  {
    [Overload("CreateInstance1")]
    Lane CreateInstance(
      [In] LaneKind laneKind,
      [In] IVectorView<LaneDirection> directions,
      [In] IReference<LaneDirection> highlightedDirection);
  }
}
