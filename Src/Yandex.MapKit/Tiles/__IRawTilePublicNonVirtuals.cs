// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Tiles.__IRawTilePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Tiles
{
  [Version(1)]
  [WebHostHidden]
  [Guid(381237604, 7214, 13498, 185, 78, 49, 19, 255, 131, 128, 49)]
  [ExclusiveTo(typeof (RawTile))]
  internal interface __IRawTilePublicNonVirtuals
  {
    Version Version { get; }

    string Etag { get; }

    RawTileState State { get; }

    byte[] RawData { get; }
  }
}
