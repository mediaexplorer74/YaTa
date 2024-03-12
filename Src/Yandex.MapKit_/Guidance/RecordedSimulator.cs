// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.RecordedSimulator
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;
using Yandex.MapKit.Location;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Guid(1983579571, 11017, 15410, 152, 220, 229, 74, 26, 72, 5, 210)]
  [Version(1)]
  [WebHostHidden]
  public interface RecordedSimulator : LocationManager
  {
    DateTime Timestamp { get; [param: In] set; }

    bool Active { get; }

    global::Yandex.MapKit.Location.Location Location { get; }

    Route Route { get; }

    void SubscribeForSimulatorEvents([In] RecordedSimulatorListener simulatorListener);

    void UnsubscribeFromSimulatorEvents([In] RecordedSimulatorListener simulatorListener);
  }
}
