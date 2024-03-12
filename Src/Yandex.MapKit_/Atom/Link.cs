// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.Link
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [MarshalingBehavior]
  [Activatable(typeof (__ILinkFactory), 1)]
  [Threading]
  [Version(1)]
  [WebHostHidden]
  public sealed class Link : __ILinkPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Link([In] string href, [In] string rel, [In] string type);

    public extern string Href { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Rel { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
