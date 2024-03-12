// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.TileId
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
  [MarshalingBehavior]
  [Activatable(typeof (__ITileIdFactory), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class TileId : __ITileIdPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TileId([In] uint x, [In] uint y, [In] uint z);

    public extern uint X { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Y { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Z { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
