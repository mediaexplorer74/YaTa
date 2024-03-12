// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.PanoramasObjectMetadata
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
  [Activatable(typeof (__IPanoramasObjectMetadataFactory), 1)]
  [Version(1)]
  [Static(typeof (__IPanoramasObjectMetadataStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class PanoramasObjectMetadata : __IPanoramasObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern PanoramasObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PanoramasObjectMetadata([In] IVectorView<Panorama> panoramas);

    public extern IVectorView<Panorama> Panoramas { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
