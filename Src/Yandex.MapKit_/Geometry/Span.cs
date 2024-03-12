// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Span
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [WebHostHidden]
  [Activatable(typeof (__ISpanFactory), 1)]
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  public sealed class Span : __ISpanPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Span([In] double horizontalAngle, [In] double verticalAngle);

    public extern double HorizontalAngle { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double VerticalAngle { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
