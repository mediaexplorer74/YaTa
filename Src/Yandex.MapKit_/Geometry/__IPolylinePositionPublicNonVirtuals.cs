// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPolylinePositionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Version(1)]
  [Guid(681430464, 34001, 15227, 158, 12, 152, 101, 96, 213, 255, 218)]
  [ExclusiveTo(typeof (PolylinePosition))]
  [WebHostHidden]
  internal interface __IPolylinePositionPublicNonVirtuals
  {
    uint SegmentIndex { get; }

    double SegmentPosition { get; }
  }
}
