// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Circle
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__ICircleFactory), 1)]
  public sealed class Circle : __ICirclePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Circle([In] Point center, [In] float radius);

    public extern Point Center { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Radius { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
