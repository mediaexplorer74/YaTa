// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.__IRideInfoFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [ExclusiveTo(typeof (RideInfo))]
  [Version(1)]
  [Guid(2073705464, 5382, 14876, 171, 34, 195, 95, 52, 19, 254, 68)]
  [WebHostHidden]
  internal interface __IRideInfoFactory
  {
    [Overload("CreateInstance1")]
    RideInfo CreateInstance([In] IVectorView<RideOption> rideOptions);
  }
}
