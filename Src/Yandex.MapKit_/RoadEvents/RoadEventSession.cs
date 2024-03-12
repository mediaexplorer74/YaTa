// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.RoadEventSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Guid(4038970931, 2901, 14108, 152, 156, 253, 86, 78, 174, 195, 39)]
  [Version(1)]
  [WebHostHidden]
  public interface RoadEventSession
  {
    void Retry([In] OnRoadEventReceived onRoadEventReceived, [In] OnRoadEventError onRoadEventError);

    void Cancel();
  }
}
