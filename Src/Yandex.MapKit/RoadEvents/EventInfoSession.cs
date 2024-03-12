// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.EventInfoSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Guid(451607512, 27358, 14444, 157, 208, 85, 190, 133, 170, 158, 223)]
  [WebHostHidden]
  [Version(1)]
  public interface EventInfoSession
  {
    void Retry([In] OnEventInfoReceived onEventInfoReceived, [In] OnEventInfoError onEventInfoError);

    void Cancel();
  }
}
