// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.RideInfoSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [WebHostHidden]
  [Guid(1352531606, 62950, 15999, 189, 181, 234, 6, 103, 54, 15, 5)]
  [Version(1)]
  public interface RideInfoSession
  {
    void Retry([In] OnRideInfoReceived onRideInfoReceived, [In] OnRideInfoError onRideInfoError);

    void Cancel();
  }
}
