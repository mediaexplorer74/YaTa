// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RawAnnotationScheme
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  [Static(typeof (__IRawAnnotationSchemeStatics), 1)]
  [Version(1)]
  [Activatable(typeof (__IRawAnnotationSchemeFactory), 1)]
  public sealed class RawAnnotationScheme : __IRawAnnotationSchemePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawAnnotationScheme From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawAnnotationScheme([In] int count, [In] AnnotationSchemeID schemeId);

    public extern int Count { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern AnnotationSchemeID SchemeId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
