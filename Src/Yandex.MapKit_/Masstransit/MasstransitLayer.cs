// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.MasstransitLayer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Map;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [Guid(3506135018, 39872, 12704, 146, 218, 125, 144, 205, 255, 249, 220)]
  public interface MasstransitLayer
  {
    void SetVehiclesVisible([In] bool on);

    bool IsVehiclesVisible();

    void AddLineFilter([In] string lineId);

    void ClearLineFilter();

    void AddTypeFilter([In] Type type);

    void ClearTypeFilter();

    void SetVehicleTapListener([In] MasstransitVehicleTapListener tapListener);

    MapObjectCollection VehicleObjects { get; }

    bool Valid { get; }
  }
}
