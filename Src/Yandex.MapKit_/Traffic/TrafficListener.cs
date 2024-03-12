// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.TrafficListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [Guid(2897452688, 14428, 16113, 130, 213, 207, 127, 135, 40, 76, 124)]
  [Version(1)]
  [WebHostHidden]
  public interface TrafficListener
  {
    void OnTrafficChanged([In] TrafficLevel trafficLevel);

    void OnTrafficLoading();

    void OnTrafficExpired();
  }
}
