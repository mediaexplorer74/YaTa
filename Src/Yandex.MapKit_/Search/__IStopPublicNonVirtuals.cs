// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IStopPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (Stop))]
  [Version(1)]
  [WebHostHidden]
  [Guid(251537208, 58144, 14703, 143, 31, 145, 206, 143, 120, 76, 77)]
  internal interface __IStopPublicNonVirtuals
  {
    string Name { get; }

    LocalizedValue Distance { get; }

    StopStyle Style { get; }

    Point Point { get; }
  }
}
