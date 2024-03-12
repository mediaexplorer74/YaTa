// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.PedestrianRouter
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2291723380, 25995, 15621, 182, 190, 79, 19, 91, 17, 203, 86)]
  public interface PedestrianRouter
  {
    Session RequestRoutes(
      [In] Point source,
      [In] Point destination,
      [In] OnMasstransitRoutes onMasstransitRoutes,
      [In] OnMasstransitRoutesError onMasstransitRoutesError);

    Session ResolveUri(
      [In] string uri,
      [In] OnMasstransitRoutes onMasstransitRoutes,
      [In] OnMasstransitRoutesError onMasstransitRoutesError);
  }
}
