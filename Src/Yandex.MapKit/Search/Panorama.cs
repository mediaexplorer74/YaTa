// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Panorama
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IPanoramaFactory), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class Panorama : __IPanoramaPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Panorama([In] string id, [In] Direction direction, [In] Span span, [In] Point point);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Direction Direction { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Span Span { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point Point { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
