// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.RouteSerializer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(874089412, 390, 12470, 179, 238, 122, 196, 36, 81, 209, 191)]
  [Version(1)]
  [WebHostHidden]
  public interface RouteSerializer
  {
    byte[] Save([In] Route route);

    Route Load([In] byte[] data);
  }
}
