// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.StopStyle
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IStopStyleFactory), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class StopStyle : __IStopStylePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern StopStyle([In] int color);

    public extern int Color { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
