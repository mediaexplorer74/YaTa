// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.__ICameraPositionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(378925871, 61108, 13555, 153, 91, 169, 23, 81, 33, 62, 140)]
  [ExclusiveTo(typeof (CameraPosition))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ICameraPositionPublicNonVirtuals
  {
    Point Target { get; }

    float Zoom { get; }

    float Azimuth { get; }

    float Tilt { get; }
  }
}
