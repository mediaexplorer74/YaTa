// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.ScreenPoint
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [MarshalingBehavior]
  [Activatable(typeof (__IScreenPointFactory), 1)]
  [Version(1)]
  [WebHostHidden]
  [Threading]
  public sealed class ScreenPoint : __IScreenPointPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ScreenPoint([In] float x, [In] float y);

    public extern float X { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Y { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
