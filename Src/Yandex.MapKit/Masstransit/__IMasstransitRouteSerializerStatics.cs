// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IMasstransitRouteSerializerStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(640950406, 35280, 13466, 164, 81, 198, 176, 171, 35, 100, 103)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MasstransitRouteSerializer))]
  [Version(1)]
  internal interface __IMasstransitRouteSerializerStatics
  {
    byte[] Save([In] Route route);

    Route Load([In] byte[] data);
  }
}
