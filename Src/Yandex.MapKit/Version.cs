// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Version
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Threading]
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IVersionFactory), 1)]
  public sealed class Version : __IVersionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Version([In] string str);

    public extern string Str { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
