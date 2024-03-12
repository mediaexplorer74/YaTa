// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IGeoHelperStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Guid(2267748578, 51014, 14635, 180, 8, 178, 25, 91, 42, 107, 200)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GeoHelper))]
  [Version(1)]
  internal interface __IGeoHelperStatics
  {
    double GetDistance([In] Point firstPoint, [In] Point secondPoint);

    Point GetClosestPoint([In] Point point, [In] Segment segment);

    Point GetPointOnSegmentByFactor([In] Segment segment, [In] double lambda);

    double GetCourse([In] Point firstPoint, [In] Point secondPoint);
  }
}
