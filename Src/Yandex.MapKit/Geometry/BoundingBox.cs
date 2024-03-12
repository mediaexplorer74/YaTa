// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.BoundingBox
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Threading]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IBoundingBoxFactory), 1)]
  [WebHostHidden]
  public sealed class BoundingBox : __IBoundingBoxPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BoundingBox([In] Point southWest, [In] Point northEast);

    public extern Point SouthWest { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point NorthEast { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
