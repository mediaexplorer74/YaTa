// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.DisplayedAnnotations
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__IDisplayedAnnotationsFactory), 1)]
  [Version(1)]
  [Static(typeof (__IDisplayedAnnotationsStatics), 1)]
  [MarshalingBehavior]
  public sealed class DisplayedAnnotations : __IDisplayedAnnotationsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern DisplayedAnnotations From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern DisplayedAnnotations(
      [In] IVectorView<AnnotationWithDistance> annotations,
      [In] string nextRoadName,
      [In] LaneSign laneSign);

    public extern IVectorView<AnnotationWithDistance> Annotations { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string NextRoadName { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LaneSign LaneSign { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
