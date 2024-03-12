// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IHousePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [ExclusiveTo(typeof (House))]
  [WebHostHidden]
  [Guid(1541747657, 28936, 14049, 183, 34, 212, 235, 149, 79, 184, 166)]
  internal interface __IHousePublicNonVirtuals
  {
    string Name { get; }

    Point Position { get; }
  }
}
