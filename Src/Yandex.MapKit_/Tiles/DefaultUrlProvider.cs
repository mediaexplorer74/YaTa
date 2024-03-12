// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Tiles.DefaultUrlProvider
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Tiles
{
  [Threading]
  [Activatable(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  public sealed class DefaultUrlProvider : UrlProvider, __IDefaultUrlProviderPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern DefaultUrlProvider();

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern string FormatUrl([In] TileId tileId, [In] Version version);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern void setUrlPattern([In] string urlPattern);
  }
}
