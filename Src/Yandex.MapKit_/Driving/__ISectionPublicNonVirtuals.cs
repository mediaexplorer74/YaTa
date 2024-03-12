// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ISectionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (Section))]
  [WebHostHidden]
  [Guid(2228640819, 42602, 12685, 190, 231, 134, 235, 249, 49, 186, 200)]
  [Version(1)]
  internal interface __ISectionPublicNonVirtuals
  {
    SectionMetadata Metadata { get; }

    Subpolyline Geometry { get; }
  }
}
