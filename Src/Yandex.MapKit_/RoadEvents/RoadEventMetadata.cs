// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.RoadEventMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__IRoadEventMetadataFactory), 1)]
  [Static(typeof (__IRoadEventMetadataStatics), 1)]
  [Threading]
  public sealed class RoadEventMetadata : __IRoadEventMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RoadEventMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RoadEventMetadata(
      [In] string eventId,
      [In] string description,
      [In] IVectorView<EventType> types,
      [In] TimePeriod timePeriod,
      [In] I18nTime modificationTime,
      [In] IReference<int> commentsCount,
      [In] AttributionAuthor author);

    public extern string EventId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Description { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<EventType> Types { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TimePeriod TimePeriod { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime ModificationTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<int> CommentsCount { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern AttributionAuthor Author { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
