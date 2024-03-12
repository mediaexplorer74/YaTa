// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.__IVisibleRegionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3944045421, 34777, 14721, 182, 168, 49, 173, 151, 74, 159, 116)]
  [ExclusiveTo(typeof (VisibleRegion))]
  internal interface __IVisibleRegionPublicNonVirtuals
  {
    Point TopLeft { get; }

    Point TopRight { get; }

    Point BottomLeft { get; }

    Point BottomRight { get; }
  }
}
