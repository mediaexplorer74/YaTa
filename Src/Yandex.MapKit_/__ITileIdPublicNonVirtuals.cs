// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.__ITileIdPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [Guid(1365366073, 61920, 15418, 154, 110, 254, 249, 88, 47, 183, 212)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TileId))]
  internal interface __ITileIdPublicNonVirtuals
  {
    uint X { get; }

    uint Y { get; }

    uint Z { get; }
  }
}
