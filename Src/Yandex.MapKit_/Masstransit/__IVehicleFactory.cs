// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IVehicleFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3424572179, 50010, 13418, 175, 148, 157, 184, 149, 141, 141, 61)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Vehicle))]
  internal interface __IVehicleFactory
  {
    [Overload("CreateInstance1")]
    Vehicle CreateInstance(
      [In] string id,
      [In] string threadId,
      [In] Line line,
      [In] IVectorView<VehicleStop> stops,
      [In] Point position);
  }
}
