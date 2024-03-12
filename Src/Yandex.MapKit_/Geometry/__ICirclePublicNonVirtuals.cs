// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ICirclePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [ExclusiveTo(typeof (Circle))]
  [Version(1)]
  [Guid(2188524715, 6256, 16281, 183, 71, 48, 252, 243, 160, 4, 232)]
  [WebHostHidden]
  internal interface __ICirclePublicNonVirtuals
  {
    Point Center { get; }

    float Radius { get; }
  }
}
