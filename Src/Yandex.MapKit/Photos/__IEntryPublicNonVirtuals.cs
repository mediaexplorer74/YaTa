// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.__IEntryPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [Guid(2283181260, 17257, 15701, 180, 0, 179, 208, 95, 144, 53, 144)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Entry))]
  internal interface __IEntryPublicNonVirtuals
  {
    global::Yandex.MapKit.Atom.Entry AtomEntry { get; }

    IVectorView<Image> Images { get; }

    Point Point { get; }
  }
}
