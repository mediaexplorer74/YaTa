// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.EntrySession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Guid(615482503, 43259, 13797, 134, 185, 242, 5, 54, 149, 248, 100)]
  [WebHostHidden]
  [Version(1)]
  public interface EntrySession
  {
    void Retry([In] OnEntryReceived onEntryReceived, [In] OnEntryError onEntryError);

    void Cancel();
  }
}
