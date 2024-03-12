// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.TrafficLayer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [Version(1)]
  [Guid(3702312390, 15047, 15421, 146, 117, 131, 231, 77, 226, 25, 103)]
  [WebHostHidden]
  public interface TrafficLayer
  {
    bool IsTrafficVisible();

    void SetTrafficVisible([In] bool on);

    bool IsRoadEventVisible([In] EventType type);

    void SetRoadEventVisible([In] EventType type, [In] bool on);

    void AddTrafficListener([In] TrafficListener trafficListener);

    void RemoveTrafficListener([In] TrafficListener trafficListener);

    bool Valid { get; }
  }
}
