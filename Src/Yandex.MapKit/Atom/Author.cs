// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.Author
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IAuthorFactory), 1)]
  [Threading]
  public sealed class Author : __IAuthorPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Author([In] string name, [In] string uri, [In] string email);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Uri { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Email { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
