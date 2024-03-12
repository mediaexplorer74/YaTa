// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.TransitObjectMetadata
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
  [Static(typeof (__ITransitObjectMetadataStatics), 1)]
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Activatable(typeof (__ITransitObjectMetadataFactory), 1)]
  public sealed class TransitObjectMetadata : __ITransitObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern TransitObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TransitObjectMetadata([In] string routeId, [In] IVectorView<string> types);

    public extern string RouteId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<string> Types { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
