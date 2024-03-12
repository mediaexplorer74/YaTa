// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Animation
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Activatable(typeof (__IAnimationFactory), 1)]
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class Animation : __IAnimationPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Animation([In] AnimationType type, [In] float duration);

    public extern AnimationType Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Duration { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
