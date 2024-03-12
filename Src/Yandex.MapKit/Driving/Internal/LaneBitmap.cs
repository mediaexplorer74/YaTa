// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.LaneBitmap
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Activatable(typeof (__ILaneBitmapFactory), 1)]
  [Static(typeof (__ILaneBitmapStatics), 1)]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class LaneBitmap : __ILaneBitmapPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern LaneBitmap From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LaneBitmap([In] int width, [In] int height, [In] byte[] data);

    public extern int Width { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int Height { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern byte[] Data { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
