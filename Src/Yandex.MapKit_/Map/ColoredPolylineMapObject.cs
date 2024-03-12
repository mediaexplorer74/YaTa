// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.ColoredPolylineMapObject
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [Guid(2890869524, 49439, 12923, 174, 172, 112, 44, 52, 205, 175, 74)]
  [WebHostHidden]
  public interface ColoredPolylineMapObject : MapObject
  {
    Polyline Geometry { get; [param: In] set; }

    float StrokeWidth { get; [param: In] set; }

    float GradientLength { get; [param: In] set; }

    uint OutlineColor { get; [param: In] set; }

    float OutlineWidth { get; [param: In] set; }

    void Select([In] uint color, [In] Subpolyline subpolyline);

    void Hide([In] Subpolyline subpolyline);

    [Overload("SetColors1")]
    void SetColors([In] IVectorView<uint> colors);

    [Overload("SetColors2")]
    void SetColors([In] IVectorView<uint> colors, [In] IVectorView<double> weights);

    Arrow AddArrow([In] PolylinePosition position, [In] float length, [In] uint fillColor);

    IVectorView<Arrow> Arrows();

    void AddArrowTapListener([In] ArrowTapListener tapListener);

    void RemoveArrowTapListener([In] ArrowTapListener tapListener);
  }
}
