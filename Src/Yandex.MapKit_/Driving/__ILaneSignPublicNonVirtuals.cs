// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ILaneSignPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (LaneSign))]
  [WebHostHidden]
  [Version(1)]
  [Guid(2334716316, 3013, 14155, 160, 114, 107, 77, 81, 233, 50, 161)]
  internal interface __ILaneSignPublicNonVirtuals
  {
    PolylinePosition Position { get; }

    IVectorView<Lane> Lanes { get; }
  }
}
