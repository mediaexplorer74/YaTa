// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.AnnotationWithDistance
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Threading]
  [WebHostHidden]
  [Static(typeof (__IAnnotationWithDistanceStatics), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IAnnotationWithDistanceFactory), 1)]
  public sealed class AnnotationWithDistance : __IAnnotationWithDistancePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern AnnotationWithDistance From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern AnnotationWithDistance([In] Annotation annotation, [In] LocalizedValue distance);

    public extern Annotation Annotation { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
