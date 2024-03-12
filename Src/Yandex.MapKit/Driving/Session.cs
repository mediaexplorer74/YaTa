// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Session
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(2089773158, 42434, 14784, 175, 9, 161, 33, 236, 161, 56, 225)]
  [WebHostHidden]
  [Version(1)]
  public interface Session
  {
    void Cancel();

    void Retry([In] OnDrivingRoutes onDrivingRoutes, [In] OnDrivingRoutesError onDrivingRoutesError);
  }
}
