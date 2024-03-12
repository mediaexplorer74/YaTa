// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Taxi.TaxiManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Taxi
{
  [Guid(3378590588, 5573, 12576, 151, 18, 60, 197, 125, 214, 119, 103)]
  [WebHostHidden]
  [Version(1)]
  public interface TaxiManager
  {
    RideInfoSession RequestRideInfo(
      [In] Point startPoint,
      [In] Point endPoint,
      [In] OnRideInfoReceived onRideInfoReceived,
      [In] OnRideInfoError onRideInfoError);
  }
}
