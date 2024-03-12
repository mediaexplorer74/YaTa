// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.MassTransitObjectMetadata
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
  [Static(typeof (__IMassTransitObjectMetadataStatics), 1)]
  [Version(1)]
  [Threading]
  [WebHostHidden]
  [MarshalingBehavior]
  [Activatable(typeof (__IMassTransitObjectMetadataFactory), 1)]
  public sealed class MassTransitObjectMetadata : __IMassTransitObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern MassTransitObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern MassTransitObjectMetadata([In] IVectorView<Stop> stops);

    public extern IVectorView<Stop> Stops { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
