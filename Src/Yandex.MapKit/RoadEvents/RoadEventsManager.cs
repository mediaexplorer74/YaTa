// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.RoadEventsManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3030175967, 45730, 14029, 162, 86, 6, 105, 69, 69, 31, 242)]
  public interface RoadEventsManager
  {
    RoadEventSession AddEvent(
      [In] EventType eventType,
      [In] string descriptionText,
      [In] Point eventLocation,
      [In] OnRoadEventReceived onRoadEventReceived,
      [In] OnRoadEventError onRoadEventError);

    EventInfoSession RequestEventInfo(
      [In] string eventId,
      [In] OnEventInfoReceived onEventInfoReceived,
      [In] OnEventInfoError onEventInfoError);

    VoteSession VoteUp([In] string eventId, [In] OnVoteCompleted onVoteCompleted, [In] OnVoteError onVoteError);

    VoteSession VoteDown([In] string eventId, [In] OnVoteCompleted onVoteCompleted, [In] OnVoteError onVoteError);

    FeedSession Comments([In] string eventId);

    EntrySession AddComment(
      [In] string eventId,
      [In] string text,
      [In] OnEntryReceived onEntryReceived,
      [In] OnEntryError onEntryError);
  }
}
