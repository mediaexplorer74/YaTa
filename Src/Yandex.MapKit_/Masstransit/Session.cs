// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Session
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [Guid(3665924119, 42340, 15797, 140, 87, 53, 108, 220, 164, 43, 64)]
  [WebHostHidden]
  public interface Session
  {
    void Cancel();

    void Retry(
      [In] OnMasstransitRoutes onMasstransitRoutes,
      [In] OnMasstransitRoutesError onMasstransitRoutesError);
  }
}
