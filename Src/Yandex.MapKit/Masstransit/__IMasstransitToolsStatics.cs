// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IMasstransitToolsStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Map;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3581935781, 23392, 16129, 145, 225, 44, 57, 87, 57, 121, 231)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MasstransitTools))]
  internal interface __IMasstransitToolsStatics
  {
    VehicleData GetVehicle([In] PlacemarkMapObject placemark);
  }
}
