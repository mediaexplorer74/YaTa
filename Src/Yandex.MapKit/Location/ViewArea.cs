// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.ViewArea
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Activatable(typeof (__IViewAreaFactory), 1)]
  public sealed class ViewArea : __IViewAreaPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ViewArea([In] double lengthwise, [In] double transverse);

    public extern double Lengthwise { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double Transverse { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
