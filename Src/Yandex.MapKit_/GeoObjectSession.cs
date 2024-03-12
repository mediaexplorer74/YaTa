// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.GeoObjectSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Version(1)]
  [Guid(3465408791, 28339, 15130, 186, 92, 160, 8, 173, 11, 190, 19)]
  public interface GeoObjectSession
  {
    void Cancel();

    void Retry([In] OnGeoObjectResult onGeoObjectResult, [In] OnGeoObjectError onGeoObjectError);
  }
}
