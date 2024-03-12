// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IRequestPointPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (RequestPoint))]
  [Guid(904968194, 38128, 14587, 139, 218, 160, 43, 92, 155, 59, 65)]
  [Version(1)]
  [WebHostHidden]
  internal interface __IRequestPointPublicNonVirtuals
  {
    Point Point { get; }

    RequestPointType Type { get; }
  }
}
