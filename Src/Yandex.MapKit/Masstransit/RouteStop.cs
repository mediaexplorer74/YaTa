// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.RouteStop
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Static(typeof (__IRouteStopStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  [Activatable(typeof (__IRouteStopFactory), 1)]
  [Version(1)]
  [WebHostHidden]
  public sealed class RouteStop : __IRouteStopPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RouteStop From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RouteStop([In] Stop stop, [In] Point position);

    public extern Stop Stop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point Position { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
