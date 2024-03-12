// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.RouteStopMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Threading]
  [MarshalingBehavior]
  [Activatable(typeof (__IRouteStopMetadataFactory), 1)]
  [Version(1)]
  [WebHostHidden]
  [Static(typeof (__IRouteStopMetadataStatics), 1)]
  public sealed class RouteStopMetadata : __IRouteStopMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RouteStopMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RouteStopMetadata([In] Stop stop);

    public extern Stop Stop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
