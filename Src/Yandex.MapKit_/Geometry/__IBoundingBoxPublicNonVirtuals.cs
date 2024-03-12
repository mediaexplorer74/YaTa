// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IBoundingBoxPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2745885384, 32001, 13478, 184, 163, 26, 18, 223, 83, 232, 190)]
  [ExclusiveTo(typeof (BoundingBox))]
  internal interface __IBoundingBoxPublicNonVirtuals
  {
    Point SouthWest { get; }

    Point NorthEast { get; }
  }
}
