// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.VehicleSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1682416195, 37129, 13773, 140, 108, 48, 218, 88, 233, 179, 164)]
  public interface VehicleSession
  {
    void Cancel();

    void Retry([In] OnResponse onResponse, [In] OnError onError);
  }
}
