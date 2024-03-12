// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Annotation
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Static(typeof (__IAnnotationStatics), 1)]
  [WebHostHidden]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IAnnotationFactory), 1)]
  [MarshalingBehavior]
  public sealed class Annotation : __IAnnotationPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Annotation From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Annotation(
      [In] IReference<global::Yandex.MapKit.Driving.Action> action,
      [In] string toponym,
      [In] string descriptionText,
      [In] ActionMetadata actionMetadata,
      [In] IVectorView<Landmark> landmarks);

    public extern IReference<global::Yandex.MapKit.Driving.Action> Action { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Toponym { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DescriptionText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ActionMetadata ActionMetadata { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Landmark> Landmarks { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
