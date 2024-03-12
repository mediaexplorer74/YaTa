// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ISubpolylineHelperStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Guid(3060671378, 34923, 16263, 185, 54, 22, 16, 62, 74, 224, 245)]
  [ExclusiveTo(typeof (SubpolylineHelper))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ISubpolylineHelperStatics
  {
    Polyline GetSubpolyline([In] Polyline polyline, [In] Subpolyline subpolyline);

    double GetSubpolylineLength([In] Polyline polyline, [In] Subpolyline subpolyline);
  }
}
