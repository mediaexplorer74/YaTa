// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.LocationSimulator
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Location
{
  [WebHostHidden]
  [Version(1)]
  [Guid(973859560, 35036, 14972, 186, 223, 67, 207, 37, 94, 191, 147)]
  public interface LocationSimulator : LocationManager
  {
    Polyline Geometry { get; [param: In] set; }

    PolylinePosition PolylinePosition { get; }

    double Speed { get; [param: In] set; }

    void SubscribeForSimulatorEvents([In] LocationSimulatorListener simulatorListener);

    void UnsubscribeFromSimulatorEvents([In] LocationSimulatorListener simulatorListener);

    bool Active { get; }
  }
}
