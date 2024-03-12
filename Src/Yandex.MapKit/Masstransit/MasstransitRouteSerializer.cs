// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.MasstransitRouteSerializer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Threading]
  [Static(typeof (__IMasstransitRouteSerializerStatics), 1)]
  [Activatable(1)]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class MasstransitRouteSerializer : __IMasstransitRouteSerializerPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern byte[] Save([In] Route route);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Route Load([In] byte[] data);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern MasstransitRouteSerializer();
  }
}
