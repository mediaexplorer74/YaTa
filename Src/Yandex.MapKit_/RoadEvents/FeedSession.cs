// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.FeedSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Guid(2969884886, 30133, 14851, 149, 110, 183, 197, 125, 32, 80, 145)]
  [WebHostHidden]
  [Version(1)]
  public interface FeedSession
  {
    bool HasNextPage();

    void FetchNextPage([In] OnFeedReceived onFeedReceived, [In] OnFeedError onFeedError);

    void Cancel();
  }
}
