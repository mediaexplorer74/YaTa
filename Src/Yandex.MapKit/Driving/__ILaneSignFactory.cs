// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ILaneSignFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Guid(1078729000, 58601, 16364, 134, 44, 240, 45, 68, 166, 248, 197)]
  [Version(1)]
  [ExclusiveTo(typeof (LaneSign))]
  internal interface __ILaneSignFactory
  {
    [Overload("CreateInstance1")]
    LaneSign CreateInstance([In] PolylinePosition position, [In] IVectorView<Lane> lanes);
  }
}
