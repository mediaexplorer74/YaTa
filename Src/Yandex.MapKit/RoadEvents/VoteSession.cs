// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.VoteSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Version(1)]
  [Guid(1778316008, 26784, 15139, 191, 0, 164, 38, 50, 253, 133, 98)]
  [WebHostHidden]
  public interface VoteSession
  {
    void Retry([In] OnVoteCompleted onVoteCompleted, [In] OnVoteError onVoteError);

    void Cancel();
  }
}
