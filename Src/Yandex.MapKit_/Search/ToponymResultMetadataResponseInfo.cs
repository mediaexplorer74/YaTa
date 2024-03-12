// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.ToponymResultMetadataResponseInfo
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Activatable(typeof (__IToponymResultMetadataResponseInfoFactory), 1)]
  [Threading]
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  public sealed class ToponymResultMetadataResponseInfo : 
    __IToponymResultMetadataResponseInfoPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ToponymResultMetadataResponseInfo(
      [In] ToponymResultMetadataSearchMode mode,
      [In] IReference<double> accuracy);

    public extern ToponymResultMetadataSearchMode Mode { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> Accuracy { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
