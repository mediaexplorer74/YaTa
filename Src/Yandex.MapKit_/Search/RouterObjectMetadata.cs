// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.RouterObjectMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Activatable(typeof (__IRouterObjectMetadataFactory), 1)]
  [Version(1)]
  [Static(typeof (__IRouterObjectMetadataStatics), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class RouterObjectMetadata : __IRouterObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RouterObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RouterObjectMetadata([In] IVectorView<Router> routers);

    public extern IVectorView<Router> Routers { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
