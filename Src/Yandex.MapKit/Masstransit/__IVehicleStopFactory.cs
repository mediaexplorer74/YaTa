// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IVehicleStopFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [ExclusiveTo(typeof (VehicleStop))]
  [WebHostHidden]
  [Guid(2982487524, 35731, 14166, 132, 47, 24, 0, 200, 223, 155, 50)]
  internal interface __IVehicleStopFactory
  {
    [Overload("CreateInstance1")]
    VehicleStop CreateInstance([In] Stop stop, [In] VehicleStopEstimation estimation);
  }
}
