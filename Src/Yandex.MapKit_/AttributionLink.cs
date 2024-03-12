// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.AttributionLink
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [WebHostHidden]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IAttributionLinkFactory), 1)]
  [MarshalingBehavior]
  public sealed class AttributionLink : __IAttributionLinkPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern AttributionLink([In] string href);

    public extern string Href { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
