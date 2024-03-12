// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IBoundingBoxHelperStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [ExclusiveTo(typeof (BoundingBoxHelper))]
  [WebHostHidden]
  [Version(1)]
  [Guid(1663829921, 39788, 12341, 128, 70, 242, 42, 66, 146, 56, 86)]
  internal interface __IBoundingBoxHelperStatics
  {
    [Overload("GetBounds5")]
    BoundingBox GetBounds([In] Point geometry);

    [Overload("GetBounds4")]
    BoundingBox GetBounds([In] Polyline geometry);

    [Overload("GetBounds3")]
    BoundingBox GetBounds([In] LinearRing geometry);

    [Overload("GetBounds2")]
    [DefaultOverload]
    BoundingBox GetBounds([In] Polygon geometry);

    [Overload("GetBounds1")]
    BoundingBox GetBounds([In] BoundingBox first, [In] BoundingBox second);
  }
}
