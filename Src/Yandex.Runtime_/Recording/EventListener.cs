// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Recording.EventListener
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.Recording
{
  [Version(1)]
  [Guid(3052324957, 35033, 14160, 140, 250, 174, 171, 54, 69, 103, 178)]
  [WebHostHidden]
  public interface EventListener
  {
    void OnEvent([In] string @event, [In] IMapView<string, string> data);
  }
}
