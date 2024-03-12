// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Tiles.__IRawTileFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Tiles
{
  [Guid(4074434639, 51112, 12571, 172, 35, 105, 208, 118, 100, 240, 217)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (RawTile))]
  internal interface __IRawTileFactory
  {
    [Overload("CreateInstance1")]
    RawTile CreateInstance([In] Version version, [In] string etag, [In] RawTileState state, [In] byte[] rawData);
  }
}
