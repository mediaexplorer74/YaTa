// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Response
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Version(1)]
  [Threading]
  [Activatable(typeof (__IResponseFactory), 1)]
  [Static(typeof (__IResponseStatics), 1)]
  [WebHostHidden]
  public sealed class Response : __IResponsePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Response From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Response([In] SearchMetadata metadata, [In] GeoObjectCollection collection, [In] bool isOffline);

    public extern SearchMetadata Metadata { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern GeoObjectCollection Collection { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool IsOffline { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
