// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.ToponymResultMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IToponymResultMetadataFactory), 1)]
  [Static(typeof (__IToponymResultMetadataStatics), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class ToponymResultMetadata : __IToponymResultMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern ToponymResultMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ToponymResultMetadata(
      [In] int found,
      [In] ToponymResultMetadataResponseInfo responseInfo,
      [In] Point reversePoint);

    public extern int Found { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ToponymResultMetadataResponseInfo ResponseInfo { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point ReversePoint { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
