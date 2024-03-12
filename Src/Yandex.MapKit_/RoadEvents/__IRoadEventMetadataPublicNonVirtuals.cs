// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__IRoadEventMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [WebHostHidden]
  [Guid(979225911, 36186, 15004, 173, 232, 80, 240, 166, 81, 124, 245)]
  [ExclusiveTo(typeof (RoadEventMetadata))]
  [Version(1)]
  internal interface __IRoadEventMetadataPublicNonVirtuals
  {
    string EventId { get; }

    string Description { get; }

    IVectorView<EventType> Types { get; }

    TimePeriod TimePeriod { get; }

    I18nTime ModificationTime { get; }

    IReference<int> CommentsCount { get; }

    AttributionAuthor Author { get; }
  }
}
