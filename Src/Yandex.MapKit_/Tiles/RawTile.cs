// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Tiles.RawTile
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Tiles
{
  [MarshalingBehavior]
  [Activatable(typeof (__IRawTileFactory), 1)]
  [Version(1)]
  [Static(typeof (__IRawTileStatics), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class RawTile : __IRawTilePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawTile From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawTile([In] Version version, [In] string etag, [In] RawTileState state, [In] byte[] rawData);

    public extern Version Version { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Etag { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RawTileState State { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern byte[] RawData { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
