// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.ScreenRect
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [Threading]
  [WebHostHidden]
  [Activatable(typeof (__IScreenRectFactory), 1)]
  [MarshalingBehavior]
  public sealed class ScreenRect : __IScreenRectPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ScreenRect([In] ScreenPoint topLeft, [In] ScreenPoint bottomRight);

    public extern ScreenPoint TopLeft { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ScreenPoint BottomRight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
