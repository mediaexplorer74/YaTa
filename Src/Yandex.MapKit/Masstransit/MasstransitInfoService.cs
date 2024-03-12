// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.MasstransitInfoService
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2074407883, 13251, 13570, 175, 169, 2, 210, 228, 196, 71, 53)]
  public interface MasstransitInfoService
  {
    GeoObjectSession Stop(
      [In] string id,
      [In] OnGeoObjectResult onGeoObjectResult,
      [In] OnGeoObjectError onGeoObjectError);

    GeoObjectSession ResolveUri(
      [In] string uri,
      [In] OnGeoObjectResult onGeoObjectResult,
      [In] OnGeoObjectError onGeoObjectError);

    VehicleSession Vehicle([In] string id, [In] OnResponse onResponse, [In] OnError onError);
  }
}
