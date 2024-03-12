// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IDirectionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Version(1)]
  [ExclusiveTo(typeof (Direction))]
  [Guid(1368099836, 13418, 14714, 142, 215, 150, 9, 51, 249, 132, 39)]
  [WebHostHidden]
  internal interface __IDirectionPublicNonVirtuals
  {
    double Azimuth { get; }

    double Tilt { get; }
  }
}
