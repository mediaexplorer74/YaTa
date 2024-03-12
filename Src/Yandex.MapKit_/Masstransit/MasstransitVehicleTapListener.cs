// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.MasstransitVehicleTapListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Guid(887306744, 3624, 15170, 130, 53, 197, 98, 250, 131, 153, 185)]
  [Version(1)]
  public interface MasstransitVehicleTapListener
  {
    bool OnVehicleTap([In] VehicleData vehicle);
  }
}
