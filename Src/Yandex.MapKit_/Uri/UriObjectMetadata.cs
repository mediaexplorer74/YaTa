// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Uri.UriObjectMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Uri
{
  [Threading]
  [Activatable(typeof (__IUriObjectMetadataFactory), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Static(typeof (__IUriObjectMetadataStatics), 1)]
  public sealed class UriObjectMetadata : __IUriObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern UriObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern UriObjectMetadata([In] IVectorView<global::Yandex.MapKit.Uri.Uri> uris);

    public extern IVectorView<global::Yandex.MapKit.Uri.Uri> Uris { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
