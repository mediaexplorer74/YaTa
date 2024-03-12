// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.LocationListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [Version(1)]
  [Guid(297250658, 34613, 15941, 147, 138, 20, 170, 243, 119, 108, 175)]
  [WebHostHidden]
  public interface LocationListener
  {
    void OnLocationUpdated([In] global::Yandex.MapKit.Location.Location location);

    void OnLocationStatusUpdated([In] LocationStatus status);
  }
}
