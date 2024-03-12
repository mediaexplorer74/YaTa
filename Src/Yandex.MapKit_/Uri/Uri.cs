// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Uri.Uri
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Uri
{
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IUriFactory), 1)]
  [Threading]
  public sealed class Uri : __IUriPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Uri([In] string value);

    public extern string Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
