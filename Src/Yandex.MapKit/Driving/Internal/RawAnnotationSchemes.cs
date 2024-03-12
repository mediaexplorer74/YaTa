// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RawAnnotationSchemes
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Static(typeof (__IRawAnnotationSchemesStatics), 1)]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__IRawAnnotationSchemesFactory), 1)]
  [MarshalingBehavior]
  [Threading]
  public sealed class RawAnnotationSchemes : __IRawAnnotationSchemesPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawAnnotationSchemes From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawAnnotationSchemes([In] IVectorView<RawAnnotationScheme> schemes);

    public extern IVectorView<RawAnnotationScheme> Schemes { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
