// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.ToponymObjectMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Threading]
  [Static(typeof (__IToponymObjectMetadataStatics), 1)]
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IToponymObjectMetadataFactory), 1)]
  public sealed class ToponymObjectMetadata : __IToponymObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern ToponymObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ToponymObjectMetadata(
      [In] Address address,
      [In] IReference<global::Yandex.MapKit.Search.Precision> precision,
      [In] string formerName,
      [In] global::Yandex.MapKit.Geometry.Point balloonPoint);

    public extern Address Address { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<global::Yandex.MapKit.Search.Precision> Precision { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string FormerName { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern global::Yandex.MapKit.Geometry.Point BalloonPoint { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
